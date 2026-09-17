package com.byazt.j;

import android.os.Build;
import android.text.TextUtils;
import com.alipay.sdk.m.y.l;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 955, 20})
public class c {
    public static final String c;

    static {
        StringBuilder sb = new StringBuilder("AppDownloader");
        boolean z = !TextUtils.isEmpty(Build.VERSION.RELEASE);
        boolean z2 = !TextUtils.isEmpty(Build.ID);
        boolean z3 = "REL".equals(Build.VERSION.CODENAME) && !TextUtils.isEmpty(Build.MODEL);
        if (z) {
            sb.append("/").append(Build.VERSION.RELEASE);
        }
        sb.append(" (Linux; U; Android");
        if (z) {
            sb.append(" ").append(Build.VERSION.RELEASE);
        }
        if (z3 || z2) {
            sb.append(l.b);
            if (z3) {
                sb.append(" ").append(Build.MODEL);
            }
            if (z2) {
                sb.append(" Build/").append(Build.ID);
            }
        }
        sb.append(")");
        c = sb.toString();
    }
}
