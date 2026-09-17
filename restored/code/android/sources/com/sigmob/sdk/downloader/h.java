package com.sigmob.sdk.downloader;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.graphics.Bitmap;
import android.text.TextUtils;
import android.util.Log;
import android.widget.RemoteViews;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.czhj.sdk.logger.SigmobLog;

/* JADX INFO: loaded from: classes3.dex */
public class h extends com.sigmob.sdk.downloader.core.listener.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Notification.Builder f3460a;
    private NotificationManager b;
    private RemoteViews c;
    private Context e;

    public h(Context context) {
        this.e = context.getApplicationContext();
        this.c = new RemoteViews(context.getPackageName(), ResourceUtil.getLayoutId(context, "sig_download_notification_layout"));
    }

    public void a(PendingIntent intent) {
        this.c.setOnClickPendingIntent(ResourceUtil.getId(this.e, "sig_download_notification_button"), intent);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.c
    protected void a(f task) {
        if (!task.m().renameTo(task.n())) {
            SigmobLog.e("download temp file renameTo failed");
        }
        SigmobLog.d("FileDownloaderNotificationListener completed ");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_speed"), "下载完成,立即安装");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 4);
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_status"), 8);
        this.f3460a.setOngoing(false);
        this.f3460a.setAutoCancel(true);
        this.b.notify(task.c(), this.f3460a.build());
    }

    public void a(f task, int blockCount, long currentOffset, long totalLength) {
        RemoteViews remoteViews;
        int id;
        StringBuilder sbAppend;
        String str;
        if (currentOffset > 1048576) {
            remoteViews = this.c;
            id = ResourceUtil.getId(this.e, "sig_download_notification_speed");
            sbAppend = new StringBuilder().append((currentOffset / 1024) / 1024);
            str = "M/";
        } else {
            remoteViews = this.c;
            id = ResourceUtil.getId(this.e, "sig_download_notification_speed");
            sbAppend = new StringBuilder().append(currentOffset / 1024);
            str = "KB/";
        }
        remoteViews.setTextViewText(id, sbAppend.append(str).append((totalLength / 1024) / 1024).append("M").toString());
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_status"), "正在下载");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.b.notify(task.c(), this.f3460a.build());
    }

    public void a(f task, long currentOffset, long totalLength) {
        RemoteViews remoteViews;
        int id;
        StringBuilder sbAppend;
        String str;
        Log.d("NotificationActivity", "progress " + currentOffset);
        if (currentOffset > 1048576) {
            remoteViews = this.c;
            id = ResourceUtil.getId(this.e, "sig_download_notification_speed");
            sbAppend = new StringBuilder().append((currentOffset / 1024) / 1024);
            str = "M/";
        } else {
            remoteViews = this.c;
            id = ResourceUtil.getId(this.e, "sig_download_notification_speed");
            sbAppend = new StringBuilder().append(currentOffset / 1024);
            str = "KB/";
        }
        remoteViews.setTextViewText(id, sbAppend.append(str).append((totalLength / 1024) / 1024).append("M").toString());
        if (totalLength > 0) {
            this.c.setProgressBar(ResourceUtil.getId(this.e, "sig_download_notification_progressBar"), 100, (int) ((currentOffset * 100) / totalLength), false);
        }
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.b.notify(task.c(), this.f3460a.build());
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.a.InterfaceC0564a
    public void a(f task, com.sigmob.sdk.downloader.core.cause.b cause) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.c
    protected void a(f task, Exception e) {
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_status"), "下载失败");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_button"), "重试");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.b.notify(task.c(), this.f3460a.build());
    }

    public void a(String icon_url, String title, String description) {
        this.b = (NotificationManager) this.e.getSystemService("notification");
        this.b.createNotificationChannel(new NotificationChannel("sig_filedownloader_notification", "sig_filedownloader", 1));
        this.f3460a = new Notification.Builder(this.e, "sig_filedownloader_notification");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_title"), title);
        if (!TextUtils.isEmpty(icon_url)) {
            try {
                com.sigmob.sdk.base.common.h.a().getBitmap(icon_url, new ImageManager.BitmapLoadedListener() { // from class: com.sigmob.sdk.downloader.h.1
                    @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
                    public void onBitmapLoadFailed() {
                    }

                    @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
                    public void onBitmapLoaded(Bitmap bitmap) {
                        h.this.c.setImageViewBitmap(ResourceUtil.getId(h.this.e, "sig_download_notification_icon"), bitmap);
                    }
                });
            } catch (Throwable unused) {
            }
        }
        this.c.setProgressBar(ResourceUtil.getId(this.e, "sig_download_notification_progress"), 100, 0, false);
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_speed"), "0M/0M");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_status"), "等待开始");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.f3460a.setDefaults(4).setOngoing(true).setSmallIcon(this.e.getApplicationInfo().icon).setPriority(0);
        this.f3460a.setCustomContentView(this.c);
    }

    public void b(PendingIntent intent) {
        this.f3460a.setContentIntent(intent);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.c
    protected void b(f task) {
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_status"), "准备下载");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_button"), "暂停");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.b.notify(task.c(), this.f3460a.build());
    }

    @Override // com.sigmob.sdk.downloader.core.listener.c
    protected void c(f task) {
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_status"), "下载暂停");
        this.c.setTextViewText(ResourceUtil.getId(this.e, "sig_download_notification_button"), "继续");
        this.c.setViewVisibility(ResourceUtil.getId(this.e, "sig_download_notification_button"), 0);
        this.b.notify(task.c(), this.f3460a.build());
    }

    @Override // com.sigmob.sdk.downloader.core.listener.c
    protected void d(f task) {
    }
}
