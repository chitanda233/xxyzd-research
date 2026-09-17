package cn.com.chinatelecom.account.api.utils;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
public interface ParamProvider {
    String decryptPreLoginResult(String str, String str2);

    String getPreCodeParamsByJs(Context context, long j, String str);

    String getPreLoginParams(Context context, String str, String str2, String str3, long j, boolean z, String str4);

    String getPreLoginUrl(boolean z);
}
