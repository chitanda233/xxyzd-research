package com.unicom.online.account.kernel;

/* JADX INFO: loaded from: classes4.dex */
public abstract class bh {
    public static Boolean b(String str) {
        return (str == null || str.length() == 0 || str.trim().length() == 0 || "null".equals(str)) ? Boolean.TRUE : Boolean.FALSE;
    }

    public static Boolean c(String str) {
        return (str == null || str.length() == 0 || str.trim().length() == 0 || "null".equals(str) || str.equals("")) ? Boolean.FALSE : Boolean.TRUE;
    }
}
