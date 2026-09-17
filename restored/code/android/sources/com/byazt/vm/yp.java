package com.byazt.vm;

import android.content.Context;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.net.Uri;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public final class yp implements nu {
    public tt<Boolean> c = new tt<Boolean>() { // from class: com.byazt.vm.yp.1
        @Override // com.byazt.vm.tt
        /* JADX INFO: renamed from: ve, reason: merged with bridge method [inline-methods] */
        public Boolean c(Object... objArr) {
            try {
                PackageManager packageManager = ((Context) objArr[0]).getPackageManager();
                if (packageManager != null) {
                    return Boolean.valueOf(packageManager.resolveContentProvider("com.meizu.flyme.openidsdk", 0) != null);
                }
            } catch (Exception unused) {
            }
            return Boolean.FALSE;
        }
    };

    @Override // com.byazt.vm.nu
    public boolean tt(Context context) {
        if (context == null) {
            return false;
        }
        return this.c.tt(context).booleanValue();
    }

    @Override // com.byazt.vm.nu
    public nu.c ve(Context context) {
        Cursor cursorQuery;
        try {
            cursorQuery = context.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{"oaid"}, null);
            if (cursorQuery != null) {
                try {
                    nu.c cVar = new nu.c();
                    cVar.tt = c(cursorQuery);
                    com.byazt.yv.u.c(cursorQuery);
                    return cVar;
                } catch (Throwable th) {
                    th = th;
                    try {
                        com.byazt.yv.da.c(th);
                        return null;
                    } finally {
                        com.byazt.yv.u.c(cursorQuery);
                    }
                }
            }
            com.byazt.yv.u.c(cursorQuery);
            return null;
        } catch (Throwable th2) {
            th = th2;
            cursorQuery = null;
        }
    }

    private String c(Cursor cursor) {
        if (cursor == null || cursor.isClosed()) {
            return null;
        }
        cursor.moveToFirst();
        int columnIndex = cursor.getColumnIndex("value");
        if (columnIndex >= 0) {
            return cursor.getString(columnIndex);
        }
        return null;
    }
}
