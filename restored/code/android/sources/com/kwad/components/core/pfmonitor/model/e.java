package com.kwad.components.core.pfmonitor.model;

import android.content.Context;
import android.os.Environment;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private String aiA;
    private String aiB;
    private String aiC;

    private e(String str, String str2, String str3) {
        this.aiA = str;
        this.aiB = str2;
        this.aiC = str3;
    }

    public static e j(Context context, String str) {
        if (str.startsWith("/appInner/")) {
            return new e("/appInner/", str, aJ(context) + str.substring(9));
        }
        if (str.startsWith("/appInnerFiles/")) {
            try {
                return new e("/appInnerFiles/", str, context.getFilesDir().getAbsolutePath() + str.substring(14));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                return null;
            }
        }
        if (str.startsWith("/appInnerCache/")) {
            try {
                return new e("/appInnerCache/", str, context.getCacheDir().getAbsolutePath() + str.substring(14));
            } catch (Exception e2) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e2);
                return null;
            }
        }
        if (str.startsWith("/appExternal/")) {
            String strSubstring = str.substring(12);
            String strAG = aG(context);
            if (strAG != null) {
                return new e("/appExternal/", str, strAG + strSubstring);
            }
            return null;
        }
        if (str.startsWith("/appExternalFiles/")) {
            return new e("/appExternalFiles/", str, aH(context) + str.substring(17));
        }
        if (str.startsWith("/appExternalCache/")) {
            return new e("/appExternalCache/", str, aI(context) + str.substring(17));
        }
        if (!str.startsWith("/sdcard/")) {
            return null;
        }
        return new e("/sdcard/", str, Environment.getExternalStorageDirectory().getAbsolutePath() + str.substring(7));
    }

    private static String aG(Context context) {
        try {
            return context.getExternalFilesDir(null).getParent();
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static String aH(Context context) {
        try {
            return context.getExternalFilesDir(null).getAbsolutePath();
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static String aI(Context context) {
        try {
            return context.getExternalFilesDir(null).getAbsolutePath();
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static String aJ(Context context) {
        return context.getDataDir().getAbsolutePath();
    }

    public final String vH() {
        return this.aiC;
    }

    public final String vI() {
        return this.aiB;
    }
}
