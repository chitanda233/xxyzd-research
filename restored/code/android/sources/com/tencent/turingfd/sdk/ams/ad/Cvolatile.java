package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.text.TextUtils;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.volatile, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cvolatile {
    public static String a(Context context, boolean z, int i, p pVar) {
        Context context2;
        StringBuilder sb = new StringBuilder();
        if (sb.length() > 0) {
            sb.append(",");
        }
        sb.append("T:");
        long j = d0.f3921a;
        sb.append(j);
        sb.append(",");
        sb.append("LT:");
        sb.append(System.currentTimeMillis() - j);
        sb.append(",");
        sb.append("F:");
        sb.append("1");
        sb.append(",");
        sb.append("PT:");
        sb.append(0);
        sb.append(",");
        sb.append("PKG:");
        sb.append("1");
        sb.append(",");
        sb.append("SC:");
        sb.append(z ? "1" : "0");
        if (Olive.f3871a == 105748) {
            sb.append(",");
            sb.append("SOTR:");
            sb.append(Tangerine.a().toString() + com.alipay.sdk.m.y.l.b + Tangerine.a(context).toString());
        }
        sb.append(",");
        sb.append("SRT:");
        sb.append(i);
        String strB = p.b(context, "204");
        if (TextUtils.isEmpty(strB)) {
            strB = "0_".concat("1");
        }
        if (!TextUtils.isEmpty(strB)) {
            sb.append(",");
            sb.append("R:");
            sb.append(strB);
        }
        sb.append(",");
        sb.append("US:");
        long jC = p.c();
        sb.append(jC);
        if (jC == -1) {
            sb.append("_");
            pVar.getClass();
            synchronized (Ccatch.class) {
                context2 = Ccatch.f3917a;
            }
            sb.append(p.a(context2, "504"));
        }
        sb.append(",");
        sb.append("STIF:");
        sb.append(p.b(context, "904"));
        sb.append(",");
        sb.append("GCI:");
        sb.append("1d1724d");
        e.b();
        return sb.toString();
    }
}
