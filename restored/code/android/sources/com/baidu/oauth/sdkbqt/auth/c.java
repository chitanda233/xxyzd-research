package com.baidu.oauth.sdkbqt.auth;

import android.os.Looper;
import com.baidu.oauth.sdkbqt.callback.QrCodeCallback;
import com.baidu.oauth.sdkbqt.callback.QrLoginStatusCheckCallback;
import com.baidu.oauth.sdkbqt.result.QrCodeResult;
import com.baidu.oauth.sdkbqt.result.QrLoginStatusCheckResult;
import com.baidu.passbqt.http.PassHttpClientRequest;
import com.baidu.passbqt.http.ReqPriority;
import java.net.HttpCookie;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
class c {
    private static String c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private com.baidu.oauth.sdkbqt.a.a.a f565a;
    private PassHttpClientRequest b;

    c() {
    }

    void a(com.baidu.oauth.sdkbqt.callback.a aVar) {
        new b(new d(this, aVar)).execute(com.baidu.oauth.sdkbqt.a.h.b(com.baidu.oauth.sdkbqt.a.b.f));
    }

    void a(String str, QrCodeCallback qrCodeCallback) {
        com.baidu.oauth.sdkbqt.a.h.a(qrCodeCallback, "QrCodeCallback can not null");
        com.baidu.oauth.sdkbqt.a.a.g gVar = new com.baidu.oauth.sdkbqt.a.a.g();
        gVar.a("response_type", "sso_qrcode");
        AuthInfo authInfo = BdOauthSdk.getAuthInfo();
        gVar.a("client_id", authInfo.getAppKey());
        gVar.a("redirect_uri", authInfo.getRedirectUrl());
        gVar.a("scope", authInfo.getScope());
        gVar.a("get_auth_code", "1");
        c = str;
        new com.baidu.oauth.sdkbqt.a.a.a().a(com.baidu.oauth.sdkbqt.a.c.a(com.baidu.oauth.sdkbqt.a.b.h), gVar, new e(this, Looper.getMainLooper(), qrCodeCallback, new QrCodeResult()));
    }

    void a() {
        PassHttpClientRequest passHttpClientRequest = this.b;
        if (passHttpClientRequest != null) {
            passHttpClientRequest.a();
        }
        if (this.f565a != null) {
            this.f565a = null;
            c = null;
        }
    }

    void a(String str, boolean z, QrLoginStatusCheckCallback qrLoginStatusCheckCallback) {
        com.baidu.oauth.sdkbqt.a.h.a(qrLoginStatusCheckCallback, "QrLoginStatusCheckCallback can not null");
        com.baidu.oauth.sdkbqt.a.h.a(str, "channelId can not null");
        f fVar = new f(this, qrLoginStatusCheckCallback);
        com.baidu.oauth.sdkbqt.a.a.g gVar = new com.baidu.oauth.sdkbqt.a.a.g();
        gVar.a("channel_id", str);
        gVar.a("tpl", "dev");
        gVar.a("callback", "cb");
        QrLoginStatusCheckResult qrLoginStatusCheckResult = new QrLoginStatusCheckResult();
        this.f565a = new com.baidu.oauth.sdkbqt.a.a.a();
        this.b = this.f565a.a(com.baidu.oauth.sdkbqt.a.c.a() + com.baidu.oauth.sdkbqt.a.h.b(com.baidu.oauth.sdkbqt.a.b.i), ReqPriority.IMMEDIATE, gVar, (List<HttpCookie>) null, (String) null, 40000, new g(this, Looper.getMainLooper(), z, fVar, qrLoginStatusCheckResult, str));
    }
}
