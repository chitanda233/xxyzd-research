package cn.com.chinatelecom.account.api.utils;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
public class ParamFactory {
    private static ParamProvider mParamProvider = new SoParamProvider();

    public static String getPreLoginUrl() {
        return mParamProvider.getPreLoginUrl(true);
    }

    public static String getPreBiomLoginUrl() {
        return mParamProvider.getPreLoginUrl(false);
    }

    public static String getPreLoginParams(Context context, String str, String str2, String str3, long j, String str4) {
        return mParamProvider.getPreLoginParams(context, str, str2, str3, j, true, str4);
    }

    public static String getPreBiomLoginParams(Context context, String str, String str2, String str3, long j, String str4) {
        return mParamProvider.getPreLoginParams(context, str, str2, str3, j, false, str4);
    }

    public static String decryptPreLoginResult(String str, String str2) {
        return mParamProvider.decryptPreLoginResult(str, str2);
    }

    public static String getPreCodeParamsByJs(Context context, long j, String str) {
        return mParamProvider.getPreCodeParamsByJs(context, j, str);
    }
}
