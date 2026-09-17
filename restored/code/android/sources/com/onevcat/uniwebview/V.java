package com.onevcat.uniwebview;

import android.app.DownloadManager;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.os.Environment;
import android.widget.Toast;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.io.File;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes3.dex */
public final class V extends BroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ W f2866a;

    public V(W w) {
        this.f2866a = w;
    }

    /* JADX WARN: Code duplicated, block: B:12:0x009b  */
    @Override // android.content.BroadcastReceiver
    public final void onReceive(Context context, Intent intent) {
        String strValueOf;
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(intent, "intent");
        long longExtra = intent.getLongExtra("extra_download_id", -1L);
        C0639g c0639g = (C0639g) this.f2866a.f.get(Long.valueOf(longExtra));
        if (c0639g != null) {
            String strA = c0639g.a();
            String str = c0639g.b;
            DownloadManager.Query query = new DownloadManager.Query();
            query.setFilterById(longExtra);
            Object systemService = context.getSystemService("download");
            String absolutePath = "";
            if (systemService instanceof DownloadManager) {
                Cursor cursorQuery = ((DownloadManager) systemService).query(query);
                if (!cursorQuery.moveToFirst()) {
                    strValueOf = "-1";
                } else if (cursorQuery.getInt(cursorQuery.getColumnIndex("status")) == 8) {
                    Toast.makeText(this.f2866a.f2868a, context.getResources().getString(R.string.DOWNLOAD_COMPLETED), 0).show();
                    absolutePath = new File(this.f2866a.f2868a.getExternalFilesDir(Environment.DIRECTORY_DOWNLOADS), str).getAbsolutePath();
                    Intrinsics.checkNotNullExpressionValue(absolutePath, "file.absolutePath");
                    strValueOf = "0";
                } else {
                    strValueOf = String.valueOf(cursorQuery.getInt(cursorQuery.getColumnIndex(MediationConstant.KEY_REASON)));
                }
            } else {
                strValueOf = "-1";
            }
            if (c0639g.c) {
                Y1 y1 = new Y1(strA, strValueOf, absolutePath, null);
                W w = this.f2866a;
                w.c.a(w.b, d2.FileDownloadFinished, y1);
            }
            this.f2866a.f.remove(Long.valueOf(longExtra));
        }
    }
}
