package com.kwad.sdk.core.download.b;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Build;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.text.TextUtils;
import android.util.SparseArray;
import android.widget.RemoteViews;
import com.kwad.sdk.DownloadTask;
import com.kwad.sdk.api.push.KsNotificationCompat;
import com.kwad.sdk.core.download.DownloadParams;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.d;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.av;
import com.kwad.sdk.utils.bc;
import com.kwad.sdk.utils.v;
import java.io.File;
import java.lang.ref.WeakReference;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements d {
    private static c aSm;
    private boolean aSo = false;
    private boolean aSp = false;
    private int aSq = 0;
    private static HashMap<String, WeakReference<Bitmap>> aSl = new HashMap<>();
    private static final Handler aSn = new HandlerC0510a();

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(int i, Notification notification) {
        LP();
        NotificationManager notificationManager = (NotificationManager) ServiceProvider.Um().getSystemService("notification");
        try {
            NotificationChannel notificationChannel = new NotificationChannel("download_channel", "ksad", 3);
            notificationChannel.enableLights(false);
            notificationChannel.enableVibration(false);
            notificationChannel.setSound(null, null);
            notificationChannel.setShowBadge(false);
            notificationManager.createNotificationChannel(notificationChannel);
            notificationManager.notify(i, notification);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    private static void LP() {
        if (aSm != null) {
            return;
        }
        aSm = new c();
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction("com.ksad.action.ACTION_NOTIFICATION_CLICK_CONTROL_BTN");
        intentFilter.addAction("com.ksad.action.ACTION_NOTIFICATION_REMOVED");
        if (Build.VERSION.SDK_INT >= 33) {
            ServiceProvider.Um().registerReceiver(aSm, intentFilter, 2);
        } else {
            ServiceProvider.Um().registerReceiver(aSm, intentFilter);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static String M(long j) {
        return String.format("%.2fMB", Float.valueOf((j / 1000.0f) / 1000.0f));
    }

    @Override // com.kwad.sdk.d
    public final void i(DownloadTask downloadTask) {
        Object tag = downloadTask.getTag();
        if (tag instanceof DownloadParams) {
            String str = ((DownloadParams) tag).mAppIcon;
            if (TextUtils.isEmpty(str)) {
                return;
            }
            File fileCM = ((com.kwad.sdk.service.a.d) ServiceProvider.get(com.kwad.sdk.service.a.d.class)).cM(str);
            if (fileCM == null || !fileCM.exists()) {
                ((com.kwad.sdk.service.a.d) ServiceProvider.get(com.kwad.sdk.service.a.d.class)).a(true, str, "", "");
            }
        }
    }

    @Override // com.kwad.sdk.d
    public final void a(DownloadTask downloadTask, boolean z) {
        com.kwad.sdk.core.download.b.c cVarA;
        Context contextUm = ServiceProvider.Um();
        if (contextUm == null || downloadTask.isNotificationRemoved() || (cVarA = com.kwad.sdk.core.download.b.c.a(contextUm, downloadTask.getId(), downloadTask.downloadEnablePause)) == null) {
            return;
        }
        if (!this.aSo) {
            this.aSo = true;
            this.aSp = ((h) ServiceProvider.get(h.class)).Gu();
            this.aSq = ((h) ServiceProvider.get(h.class)).Gv();
        }
        com.kwad.sdk.core.d.c.d("AdDownloadNotificationPerformer", "DownloadProgressTransformUtil in notifyDownloadProgress");
        a(contextUm, cVarA, b.a(downloadTask, "正在下载", null, this.aSp, this.aSq));
        a(contextUm, cVarA.build(), false, true, null, downloadTask.getId(), z ? 1 : 0, downloadTask.isCompleted() ? 1 : 0);
    }

    @Override // com.kwad.sdk.d
    public final void j(DownloadTask downloadTask) {
        Context contextUm = ServiceProvider.Um();
        if (contextUm == null || downloadTask.isNotificationRemoved()) {
            return;
        }
        String str = downloadTask.getSmallFileSoFarBytes() > 0 && downloadTask.getSmallFileTotalBytes() > 0 ? "正在下载" : "准备下载";
        if (!this.aSo) {
            this.aSo = true;
            this.aSp = ((h) ServiceProvider.get(h.class)).Gu();
            this.aSq = ((h) ServiceProvider.get(h.class)).Gv();
        }
        com.kwad.sdk.core.d.c.d("AdDownloadNotificationPerformer", "DownloadProgressTransformUtil in notifyDownloadError");
        b bVarA = b.a(downloadTask, str, null, this.aSp, this.aSq);
        com.kwad.sdk.core.download.b.c cVarA = com.kwad.sdk.core.download.b.c.a(contextUm, downloadTask.getId(), downloadTask.downloadEnablePause);
        if (cVarA == null) {
            return;
        }
        a(contextUm, cVarA, bVarA);
        a(contextUm, cVarA.build(), false, true, null, downloadTask.getId(), 1, downloadTask.isCompleted() ? 1 : 0);
    }

    @Override // com.kwad.sdk.d
    public final void k(DownloadTask downloadTask) {
        DownloadParams downloadParamsM;
        com.kwad.sdk.core.download.b.b bVarBS;
        Context contextUm = ServiceProvider.Um();
        if (contextUm == null || (downloadParamsM = m(downloadTask)) == null || (bVarBS = com.kwad.sdk.core.download.b.b.bS(contextUm)) == null) {
            return;
        }
        if (!this.aSo) {
            this.aSo = true;
            this.aSp = ((h) ServiceProvider.get(h.class)).Gu();
            this.aSq = ((h) ServiceProvider.get(h.class)).Gv();
        }
        com.kwad.sdk.core.d.c.d("AdDownloadNotificationPerformer", "DownloadProgressTransformUtil in notifyDownloadCompleted");
        a(contextUm, bVarBS, b.a(downloadTask, "下载完成", "立即安装", this.aSp, this.aSq));
        com.kwad.sdk.core.a.IT().a(downloadTask.getTargetFilePath(), downloadParamsM);
        com.kwad.sdk.core.a.IT().a(downloadParamsM.mPkgname, downloadParamsM);
        a(contextUm, bVarBS.build(), false, false, av.a(contextUm, new File(downloadTask.getTargetFilePath()), downloadParamsM.mTaskId, downloadParamsM.requestInstallPermission), downloadTask.getId(), 1, 1);
    }

    @Override // com.kwad.sdk.d
    public final void g(File file) {
        Context contextUm = ServiceProvider.Um();
        if (contextUm == null) {
            return;
        }
        DownloadParams downloadParamsDQ = com.kwad.sdk.core.a.IT().dQ(file.getAbsolutePath());
        com.kwad.sdk.core.a.IT().dR(file.getAbsolutePath());
        if (downloadParamsDQ == null) {
            return;
        }
        AdTemplate adTemplateDS = com.kwad.sdk.core.a.IT().dS(downloadParamsDQ.mDownloadid);
        if (adTemplateDS != null) {
            adTemplateDS.installFrom = "recall";
        }
        b bVarA = b.a(downloadParamsDQ, "下载完成", "立即安装");
        com.kwad.sdk.core.download.b.b bVarBS = com.kwad.sdk.core.download.b.b.bS(contextUm);
        if (bVarBS == null) {
            return;
        }
        a(contextUm, bVarBS, bVarA);
        a(contextUm, bVarBS.build(), false, false, av.a(contextUm, file, downloadParamsDQ.mTaskId, downloadParamsDQ.requestInstallPermission), downloadParamsDQ.mTaskId, 1, 2);
    }

    @Override // com.kwad.sdk.d
    public final void cK(String str) {
        Context contextUm = ServiceProvider.Um();
        DownloadParams downloadParamsDQ = com.kwad.sdk.core.a.IT().dQ(str);
        com.kwad.sdk.core.a.IT().dR(str);
        if (contextUm == null || downloadParamsDQ == null) {
            return;
        }
        com.kwad.sdk.core.a.IT().dR(downloadParamsDQ.filePath);
        b bVarA = b.a(downloadParamsDQ, "安装完成", "立刻打开");
        com.kwad.sdk.core.download.b.b bVarBS = com.kwad.sdk.core.download.b.b.bS(contextUm);
        if (bVarBS == null) {
            return;
        }
        a(contextUm, bVarBS, bVarA);
        a(contextUm, bVarBS.build(), false, false, av.d(contextUm, downloadParamsDQ.mPkgname, downloadParamsDQ.mTaskId), downloadParamsDQ.mTaskId, 1, 2);
    }

    private static DownloadParams m(DownloadTask downloadTask) {
        DownloadParams downloadParams;
        if (downloadTask == null) {
            return null;
        }
        Object tag = downloadTask.getTag();
        if (tag instanceof DownloadParams) {
            downloadParams = (DownloadParams) tag;
        } else {
            downloadParams = new DownloadParams();
        }
        downloadParams.mAppSize = downloadTask.getSmallFileTotalBytes();
        downloadParams.mTaskId = downloadTask.getId();
        downloadParams.filePath = downloadTask.getTargetFilePath();
        return downloadParams;
    }

    private boolean a(com.kwad.sdk.core.download.b.c cVar, File file) {
        try {
            cVar.setIcon(q(file));
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.service.d.gatherException(e);
            return false;
        }
    }

    private boolean a(Context context, com.kwad.sdk.core.download.b.c cVar, String str) {
        try {
            cVar.setIcon(J(context, str));
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.service.d.gatherException(e);
            return false;
        }
    }

    private boolean a(com.kwad.sdk.core.download.b.b bVar, File file) {
        try {
            bVar.setIcon(q(file));
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.service.d.gatherException(e);
            return false;
        }
    }

    private boolean a(Context context, com.kwad.sdk.core.download.b.b bVar, String str) {
        try {
            bVar.setIcon(J(context, str));
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.service.d.gatherException(e);
            return false;
        }
    }

    private static Bitmap q(File file) {
        String absolutePath = file.getAbsolutePath();
        WeakReference<Bitmap> weakReference = aSl.get(absolutePath);
        Bitmap bitmap = weakReference != null ? weakReference.get() : null;
        if (bitmap != null && !bitmap.isRecycled()) {
            return bitmap;
        }
        Bitmap bitmapDecodeFile = BitmapFactory.decodeFile(absolutePath);
        aSl.put(absolutePath, new WeakReference<>(bitmapDecodeFile));
        return bitmapDecodeFile;
    }

    private static Bitmap J(Context context, String str) {
        WeakReference<Bitmap> weakReference = aSl.get(str);
        Bitmap bitmap = weakReference != null ? weakReference.get() : null;
        if (bitmap != null && !bitmap.isRecycled()) {
            return bitmap;
        }
        Bitmap bitmapDecodeResource = BitmapFactory.decodeResource(bc.dM(context), bc.aD(context, str));
        aSl.put(str, new WeakReference<>(bitmapDecodeResource));
        return bitmapDecodeResource;
    }

    @Override // com.kwad.sdk.d
    public final void dd(int i) {
        Context contextUm = ServiceProvider.Um();
        if (contextUm == null) {
            return;
        }
        ((NotificationManager) contextUm.getSystemService("notification")).cancel(i);
    }

    private void a(Context context, RemoteViews remoteViews, boolean z, boolean z2, PendingIntent pendingIntent, int i, int i2, int i3) {
        KsNotificationCompat.Builder builder = new KsNotificationCompat.Builder(context, "download_channel");
        builder.setWhen(System.currentTimeMillis()).setOngoing(false).setAutoCancel(false).setOnlyAlertOnce(true).setPriority(-1).setContentIntent(pendingIntent).setSmallIcon(bc.getAppIconId(context));
        a(builder, remoteViews);
        if (z2) {
            Intent intent = new Intent("com.ksad.action.ACTION_NOTIFICATION_REMOVED");
            intent.putExtra("taskId", i);
            builder.setDeleteIntent(av.a(context, i, intent));
        }
        Handler handler = aSn;
        handler.removeMessages(i);
        handler.obtainMessage(i, i2, i3, builder.build()).sendToTarget();
    }

    private static void a(KsNotificationCompat.Builder builder, RemoteViews remoteViews) {
        try {
            builder.setDecoratedCustomStyle().setCustomBigContentView(remoteViews).setCustomContentView(remoteViews);
        } catch (Throwable unused) {
            builder.setContent(remoteViews);
        }
    }

    /* JADX INFO: renamed from: com.kwad.sdk.core.download.b.a$a, reason: collision with other inner class name */
    static class HandlerC0510a extends Handler {
        private final SparseArray<Long> aSr;

        HandlerC0510a() {
            super(Looper.getMainLooper());
            this.aSr = new SparseArray<>();
        }

        @Override // android.os.Handler
        public final void handleMessage(Message message) {
            boolean z = message.arg1 == 1;
            boolean z2 = message.arg2 == 1;
            boolean z3 = message.arg2 == 2;
            Long l = this.aSr.get(message.what);
            NotificationManager notificationManager = (NotificationManager) com.kwad.sdk.c.EK().getContext().getSystemService("notification");
            if (notificationManager == null) {
                return;
            }
            if (com.kwad.sdk.c.EK().da(message.what) == null && !z3) {
                removeMessages(message.what);
                notificationManager.cancel(message.what);
            } else {
                if (z || l == null || System.currentTimeMillis() - l.longValue() >= 110) {
                    if (z2) {
                        notificationManager.cancel(message.what);
                    }
                    a.a(message.what, (Notification) message.obj);
                    this.aSr.put(message.what, Long.valueOf(System.currentTimeMillis()));
                    return;
                }
                sendMessageDelayed(Message.obtain(message), (l.longValue() + 110) - System.currentTimeMillis());
            }
        }
    }

    private void a(Context context, com.kwad.sdk.core.download.b.c cVar, b bVar) {
        cVar.setName(bVar.getName());
        File fileLU = bVar.LU();
        if (!((fileLU == null || !fileLU.exists()) ? false : a(cVar, fileLU))) {
            a(context, cVar, b.LQ());
        }
        cVar.setStatus(bVar.LT());
        cVar.setSize(bVar.LR());
        cVar.setPercentNum(bVar.LV());
        cVar.setProgress(100, bVar.getProgress(), false);
        cVar.setControlBtnPaused(bVar.isPaused());
    }

    private void a(Context context, com.kwad.sdk.core.download.b.b bVar, b bVar2) {
        bVar.setName(bVar2.getName());
        File fileLU = bVar2.LU();
        if (!((fileLU == null || !fileLU.exists()) ? false : a(bVar, fileLU))) {
            a(context, bVar, b.LQ());
        }
        bVar.setStatus(bVar2.LT());
        bVar.setSize(bVar2.LS());
        bVar.setInstallText(bVar2.LW());
    }

    static class b {
        private static String aSs = "ksad_notification_default_icon";
        private String aSt;
        private String aSu;
        private String aSw;
        private String auC;
        private String name;
        private int progress;
        private File aSv = null;
        private boolean aSx = false;

        private b() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static b a(DownloadTask downloadTask, String str, String str2, boolean z, int i) {
            b bVar = new b();
            Object tag = downloadTask.getTag();
            if (tag instanceof DownloadParams) {
                DownloadParams downloadParams = (DownloadParams) tag;
                File fileCM = ((com.kwad.sdk.service.a.d) ServiceProvider.get(com.kwad.sdk.service.a.d.class)).cM(downloadParams.mAppIcon);
                if (fileCM != null && fileCM.exists()) {
                    bVar.aSv = fileCM;
                }
                bVar.name = downloadParams.mAppName;
            }
            bVar.aSx = downloadTask.isPaused();
            bVar.auC = str;
            bVar.aSw = str2;
            bVar.aSu = a.M(downloadTask.getSmallFileTotalBytes());
            int iA = v.a(downloadTask.getSmallFileSoFarBytes(), downloadTask.getSmallFileTotalBytes(), z, i);
            bVar.progress = iA;
            bVar.aSt = a.M((long) (((double) downloadTask.getSmallFileTotalBytes()) * ((((double) iA) * 1.0d) / 100.0d))) + " / " + a.M(downloadTask.getSmallFileTotalBytes());
            return bVar;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static b a(DownloadParams downloadParams, String str, String str2) {
            File fileCM;
            b bVar = new b();
            bVar.name = downloadParams.mAppName;
            if (!TextUtils.isEmpty(downloadParams.mAppIcon) && (fileCM = ((com.kwad.sdk.service.a.d) ServiceProvider.get(com.kwad.sdk.service.a.d.class)).cM(downloadParams.mAppIcon)) != null && fileCM.exists()) {
                bVar.aSv = fileCM;
            }
            bVar.auC = str;
            bVar.aSu = a.M(downloadParams.mAppSize);
            bVar.aSw = str2;
            return bVar;
        }

        public static String LQ() {
            return aSs;
        }

        public final String getName() {
            String str = this.name;
            return str == null ? "" : str;
        }

        public final String LR() {
            return this.aSt;
        }

        public final String LS() {
            return this.aSu;
        }

        public final String LT() {
            return this.auC;
        }

        public final File LU() {
            return this.aSv;
        }

        public final String LV() {
            return "正在下载 " + this.progress + "%";
        }

        public final int getProgress() {
            return this.progress;
        }

        public final String LW() {
            return this.aSw;
        }

        public final boolean isPaused() {
            return this.aSx;
        }
    }

    static class c extends BroadcastReceiver {
        @Override // android.content.BroadcastReceiver
        public final void onReceive(Context context, Intent intent) {
            if (intent == null || intent.getExtras() == null) {
                return;
            }
            String action = intent.getAction();
            if ("com.ksad.action.ACTION_NOTIFICATION_CLICK_CONTROL_BTN".equals(action)) {
                e(intent);
            } else if ("com.ksad.action.ACTION_NOTIFICATION_REMOVED".equals(action)) {
                f(intent);
            }
        }

        private static void e(Intent intent) {
            DownloadTask downloadTaskG = g(intent);
            if (downloadTaskG == null) {
                return;
            }
            com.kwad.sdk.c.EK().dc(downloadTaskG.getId());
        }

        private static void f(Intent intent) {
            DownloadTask downloadTaskG = g(intent);
            if (downloadTaskG == null) {
                return;
            }
            downloadTaskG.setNotificationRemoved(true);
        }

        private static DownloadTask g(Intent intent) {
            int i = intent.getExtras().getInt("taskId", 0);
            if (i == 0) {
                return null;
            }
            return com.kwad.sdk.c.EK().da(i);
        }
    }
}
