package com.kwad.sdk.utils;

import android.content.Context;
import android.os.Environment;
import android.text.TextUtils;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class bg {
    private static String bqc;
    private static File bqd;

    private static boolean Wv() {
        try {
            return "mounted".equals(Environment.getExternalStorageState()) || !Environment.isExternalStorageRemovable();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return false;
        }
    }

    private static String ec(Context context) {
        if (!TextUtils.isEmpty(bqc)) {
            return bqc;
        }
        String path = null;
        if (Wv()) {
            try {
                File externalFilesDir = context.getExternalFilesDir(null);
                if (externalFilesDir != null) {
                    path = externalFilesDir.getPath();
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        if (TextUtils.isEmpty(path)) {
            path = context.getFilesDir().getPath();
        }
        String str = path + File.separator + "ksadsdk";
        bqc = str;
        return str;
    }

    public static File ed(Context context) {
        File file = bqd;
        if (file != null) {
            return file;
        }
        String path = null;
        if (Wv()) {
            try {
                File externalCacheDir = context.getExternalCacheDir();
                if (externalCacheDir != null) {
                    path = externalCacheDir.getPath();
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        if (TextUtils.isEmpty(path)) {
            path = context.getCacheDir().getPath();
        }
        File file2 = new File(path + File.separator + "ksadsdk");
        bqd = file2;
        if (!file2.exists()) {
            bqd.mkdirs();
        }
        return bqd;
    }

    public static File ee(Context context) {
        File file = new File(ec(context) + File.separator + "Download");
        if (!file.exists()) {
            file.mkdirs();
        }
        return file;
    }

    public static File ef(Context context) {
        File file = new File(ec(context) + File.separator + "downloadFileSync/.temp");
        if (!file.exists()) {
            file.mkdirs();
        }
        return file;
    }

    public static File eg(Context context) {
        String strEc;
        if (com.kwad.framework.a.a.oV.booleanValue()) {
            strEc = ec(context);
        } else {
            strEc = context.getFilesDir().getAbsolutePath() + File.separator + "ksadsdk";
        }
        return new File(strEc + File.separator + "ksadlog");
    }

    public static String eh(Context context) {
        File filesDir;
        return (context == null || (filesDir = context.getFilesDir()) == null) ? "" : filesDir.getPath() + File.separator + "ksadsdk";
    }

    public static String getTkJsRootDir(Context context) {
        if (context == null) {
            return "";
        }
        return eh(context) + File.separator + "ksad/download/js";
    }

    public static String getTkJsFileDir(Context context, String str) {
        if (context == null) {
            return "";
        }
        return eh(context) + File.separator + "ksad/download/js" + File.separator + str;
    }

    public static String ei(Context context) {
        return ed(context).getPath() + "/cookie";
    }
}
