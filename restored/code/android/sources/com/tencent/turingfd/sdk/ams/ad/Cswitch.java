package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import java.util.Iterator;
import java.util.Locale;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.switch, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cswitch {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3962a;
    public final int b;
    public final a c;

    public Cswitch(String str, int i, a aVar) {
        this.f3962a = str;
        this.b = i;
        this.c = aVar;
    }

    public static String a(String str) {
        if (str == null) {
            str = "";
        }
        Tangor tangor = Teazle.f3900a;
        if (!TextUtils.isEmpty(str)) {
            str = str.replace(":", "%3A");
        }
        if (!TextUtils.isEmpty(str)) {
            str = str.replace(com.alipay.sdk.m.y.l.b, "%3B");
        }
        if (!TextUtils.isEmpty(str)) {
            str = str.replace("_", "%5F");
        }
        if (!TextUtils.isEmpty(str)) {
            str = str.replace(",", "%54");
        }
        return !TextUtils.isEmpty(str) ? str.replace(com.alipay.sdk.m.w.a.p, "%0A") : str;
    }

    public final String a() {
        StringBuilder sb = new StringBuilder();
        sb.append(a(this.f3962a));
        sb.append("_");
        sb.append(this.b);
        sb.append("_");
        a aVar = this.c;
        if (aVar == null) {
            return sb.toString();
        }
        sb.append(aVar.f3909a);
        sb.append(":");
        sb.append(this.c.b);
        sb.append(":");
        Iterator it = this.c.c.iterator();
        while (it.hasNext()) {
            b bVar = (b) it.next();
            sb.append(bVar.f3912a);
            sb.append(",,,");
            Locale locale = Locale.SIMPLIFIED_CHINESE;
            String strReplaceAll = String.format(locale, "%.5f", Float.valueOf(bVar.d));
            if (strReplaceAll.indexOf(TRouterMap.DOT) > 0) {
                strReplaceAll = strReplaceAll.replaceAll("0+?$", "").replaceAll("[.]$", "");
            }
            sb.append(strReplaceAll);
            sb.append(",");
            String strReplaceAll2 = String.format(locale, "%.5f", Float.valueOf(bVar.e));
            if (strReplaceAll2.indexOf(TRouterMap.DOT) > 0) {
                strReplaceAll2 = strReplaceAll2.replaceAll("0+?$", "").replaceAll("[.]$", "");
            }
            sb.append(strReplaceAll2);
            if (it.hasNext()) {
                sb.append(com.alipay.sdk.m.y.l.b);
            }
        }
        sb.append(":");
        sb.append(this.c.d);
        return sb.toString();
    }
}
