package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Norma {
    public static String a(String str) {
        int iIndexOf;
        String[] strArrSplit = str.split(" ", 3);
        if (strArrSplit.length <= 2 || !"rwxp".equals(strArrSplit[1]) || (iIndexOf = strArrSplit[2].indexOf(47)) == -1) {
            return null;
        }
        String strTrim = strArrSplit[2].substring(iIndexOf).trim();
        if (strTrim.startsWith("/data/")) {
            return null;
        }
        return strArrSplit[1] + com.alipay.sdk.m.y.l.b + strTrim;
    }
}
