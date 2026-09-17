package com.unicom.online.account.kernel;

import android.content.Context;
import android.telephony.TelephonyManager;

/* JADX INFO: loaded from: classes4.dex */
public abstract class c {
    public static final StringBuffer b = new StringBuffer();

    public static String b(int i, Context context, String str, String str2) {
        String simOperator = ((TelephonyManager) context.getSystemService("phone")).getSimOperator();
        if (1 == i) {
            return "AC_" + str + str2 + simOperator + b.toString();
        }
        String strSubstring = au.b(au.b()).substring(2, 10);
        StringBuffer stringBuffer = b;
        stringBuffer.setLength(0);
        stringBuffer.append(strSubstring);
        if (bh.c(strSubstring).booleanValue()) {
            return "AC_" + str + str2 + simOperator + strSubstring;
        }
        return null;
    }
}
