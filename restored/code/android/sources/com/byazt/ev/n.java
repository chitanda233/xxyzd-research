package com.byazt.ev;

import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1445, 46})
public class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static long f911a = 5242880;
    public static volatile String c = "";
    public static final JSONObject i = new JSONObject();
    public static long n = 50;
    public static long sp = 31457280;
    public static volatile String tt = "";
    public static long uj = 512000;
    public static volatile String ve = "";
    public static long x = 10485760;

    public static void c(String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        c = str;
    }
}
