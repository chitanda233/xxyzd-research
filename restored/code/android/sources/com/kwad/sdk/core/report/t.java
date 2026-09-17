package com.kwad.sdk.core.report;

import android.content.Context;
import android.content.SharedPreferences;
import java.util.UUID;

/* JADX INFO: loaded from: classes3.dex */
public final class t {
    private static String aWG = Nw();
    private static long aWH = 0;
    private static Context aWI;

    public static void init(Context context) {
        aWI = context;
    }

    public static String Ns() {
        com.kwad.sdk.core.d.c.d("ReportIdManager", ">> updateSessionId");
        String strNw = Nw();
        aWG = strNw;
        return strNw;
    }

    public static String Nt() {
        return aWG;
    }

    public static long Nu() {
        long jBY = bY(aWI);
        b(aWI, 1 + jBY);
        return jBY;
    }

    public static long Nv() {
        return aWH;
    }

    private static String Nw() {
        return UUID.randomUUID().toString();
    }

    private static boolean b(Context context, long j) {
        if (context == null) {
            return false;
        }
        SharedPreferences.Editor editorEdit = context.getSharedPreferences("ksadsdk_seq", 0).edit();
        editorEdit.putLong("seq", j);
        return editorEdit.commit();
    }

    private static long bY(Context context) {
        SharedPreferences sharedPreferences;
        if (context == null || (sharedPreferences = context.getSharedPreferences("ksadsdk_seq", 0)) == null) {
            return 0L;
        }
        return sharedPreferences.getLong("seq", 1L);
    }
}
