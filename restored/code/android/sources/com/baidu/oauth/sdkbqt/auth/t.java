package com.baidu.oauth.sdkbqt.auth;

import android.graphics.Bitmap;
import android.net.http.SslError;
import android.text.TextUtils;
import android.webkit.SslErrorHandler;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import com.baidu.oauth.sdkbqt.result.OauthResult;
import com.byazt.nys.PluginConstants;
import java.util.HashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class t extends WebViewClient {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f586a;

    t(i iVar) {
        this.f586a = iVar;
    }

    @Override // android.webkit.WebViewClient
    public boolean shouldOverrideUrlLoading(WebView webView, String str) {
        com.baidu.oauth.sdkbqt.a.d.a(i.b, "override the loading url that is " + str);
        if (!TextUtils.isEmpty(str) && str.contains(BdOauthSdk.getAuthInfo().getRedirectUrl())) {
            HashMap<String, String> mapA = com.baidu.oauth.sdkbqt.a.h.a(str.substring(str.indexOf("#") + 1, str.length()));
            com.baidu.oauth.sdkbqt.result.b bVar = new com.baidu.oauth.sdkbqt.result.b();
            if (mapA.containsKey("error")) {
                bVar.setResultCode(OauthResult.ERROR_CODE_RESPONSE_INVALID);
                bVar.setResultMsg(mapA.get("error_description"));
                this.f586a.s.onFailure(bVar);
            } else {
                JSONObject jSONObject = new JSONObject();
                try {
                    jSONObject.put(PluginConstants.KEY_ERROR_CODE, mapA.get(PluginConstants.KEY_ERROR_CODE));
                    jSONObject.put("state", mapA.get("state"));
                    jSONObject.put("showLogin", this.f586a.j ? "1" : "0");
                    jSONObject.put("finishLogin", "1");
                    bVar.f597a = jSONObject;
                    bVar.setResultCode(0);
                    this.f586a.s.onSuccess(bVar);
                } catch (JSONException e) {
                    com.baidu.oauth.sdkbqt.a.d.a(e);
                    bVar.setResultCode(OauthResult.ERROR_CODE_UNKNOW_ERROR);
                    this.f586a.s.onFailure(bVar);
                }
            }
            this.f586a.c();
            return true;
        }
        return super.shouldOverrideUrlLoading(webView, str);
    }

    @Override // android.webkit.WebViewClient
    public void onPageStarted(WebView webView, String str, Bitmap bitmap) {
        super.onPageStarted(webView, str, bitmap);
        if (!com.baidu.oauth.sdkbqt.a.h.a(this.f586a.getContext()) && !str.startsWith("javascript:")) {
            this.f586a.i();
        }
        this.f586a.o.a(str);
        this.f586a.n.postDelayed(this.f586a.o, this.f586a.m);
    }

    @Override // android.webkit.WebViewClient
    public void onReceivedSslError(WebView webView, SslErrorHandler sslErrorHandler, SslError sslError) {
        super.onReceivedSslError(webView, sslErrorHandler, sslError);
        this.f586a.h();
    }

    @Override // android.webkit.WebViewClient
    public void onPageFinished(WebView webView, String str) {
        super.onPageFinished(webView, str);
        if (com.baidu.oauth.sdkbqt.a.h.a(this.f586a.getContext()) && this.f586a.g != null && this.f586a.g.getVisibility() != 4) {
            this.f586a.g.setVisibility(4);
        }
        if (this.f586a.e != null) {
            this.f586a.loadUrl("javascript:prompt(JSON.stringify({action:{name:'action_set_title',params:[document.title, 'prompt_on_cancel', 'prompt_on_cancel']}}));");
        }
        this.f586a.n.removeCallbacks(this.f586a.o);
    }

    @Override // android.webkit.WebViewClient
    public void onReceivedError(WebView webView, int i, String str, String str2) {
        super.onReceivedError(webView, i, str, str2);
        this.f586a.h();
    }
}
