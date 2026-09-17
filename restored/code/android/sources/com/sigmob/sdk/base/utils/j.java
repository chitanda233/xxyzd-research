package com.sigmob.sdk.base.utils;

import android.util.Base64;
import android.webkit.WebSettings;
import com.czhj.sdk.common.utils.ReflectionUtil;
import com.czhj.sdk.logger.SigmobLogger;

/* JADX INFO: loaded from: classes3.dex */
public class j {
    public static void a(String tag, WebSettings webSettings) {
        a(tag, webSettings, com.sigmob.sdk.base.n.D);
        a(tag, webSettings, com.sigmob.sdk.base.n.F);
    }

    public static void a(String tag, WebSettings webSettings, String encryptedStr) {
        try {
            ReflectionUtil.MethodBuilder methodBuilder = new ReflectionUtil.MethodBuilder(webSettings, new String(Base64.decode(encryptedStr, 2)));
            methodBuilder.addParam(Boolean.TYPE, true);
            methodBuilder.execute();
        } catch (Exception e) {
            SigmobLogger.e(tag, "executeJsMethod: error = " + e.getMessage(), new Object[0]);
        }
    }
}
