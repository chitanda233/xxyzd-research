package com.baidu.oauth.sdkbqt.a.a;

import android.os.Build;
import com.baidu.oauth.sdkbqt.auth.AuthInfo;
import com.baidu.oauth.sdkbqt.auth.BdOauthSdk;
import com.byazt.nys.PluginConstants;
import com.kuaishou.weapon.p0.t;
import com.sigmob.sdk.base.n;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f551a = "Utils";

    h() {
    }

    static Map<String, String> a() {
        com.baidu.oauth.sdkbqt.a.d.b(f551a, "buildCommonParams begin");
        HashMap map = new HashMap();
        map.put("client", "android");
        map.put(t.c, String.valueOf(System.currentTimeMillis()));
        map.put(com.alipay.sdk.m.t.e.p, Build.MODEL);
        map.put(PluginConstants.KEY_SDK_VERSION, "2.0.6.10");
        AuthInfo authInfo = BdOauthSdk.getAuthInfo();
        if (authInfo != null) {
            map.put(com.alipay.sdk.m.n.b.h, authInfo.getAppKey());
            map.put("pkg", authInfo.getPackageName());
            map.put("cuid", authInfo.getDeviceId());
            map.put(n.r, com.baidu.oauth.sdkbqt.a.h.b(authInfo.getContext()));
        }
        return map;
    }
}
