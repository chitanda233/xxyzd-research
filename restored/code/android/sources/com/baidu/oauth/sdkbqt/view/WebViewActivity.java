package com.baidu.oauth.sdkbqt.view;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import com.baidu.oauth.sdkbqt.R;
import com.baidu.oauth.sdkbqt.auth.AuthInfo;
import com.baidu.oauth.sdkbqt.auth.BdOauthSdk;
import com.baidu.oauth.sdkbqt.auth.BdSsoHandler;
import com.byazt.nys.PluginConstants;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class WebViewActivity extends a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f598a = "WebViewActivity";
    private static final String b = "extra_oauth_result_json";
    private static final int c = -201;
    private static final int d = -205;
    private boolean e = false;
    private boolean f = false;

    private void b() {
    }

    @Override // android.app.Activity
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        c();
        try {
            AuthInfo authInfo = BdOauthSdk.getAuthInfo();
            if (authInfo != null && authInfo.getFindViewDelegate() != null) {
                setContentView(authInfo.getFindViewDelegate().oauthResID(com.baidu.mobads.sdk.internal.b.a.b.f433a));
            } else {
                setContentView(R.layout.layout_bd_oauth_sdk_webview_with_title);
            }
            this.e = TextUtils.isEmpty(new com.baidu.oauth.sdkbqt.auth.a().a(this));
            b();
            setupViews();
        } catch (Throwable unused) {
            setResult(0, com.baidu.oauth.sdkbqt.a.i.a(-201));
            finish();
        }
    }

    private void c() {
        if (getActionBar() != null) {
            getActionBar().hide();
        }
        getWindow().getDecorView().setBackgroundColor(-657931);
    }

    @Override // com.baidu.oauth.sdkbqt.view.a
    protected void setupViews() {
        super.setupViews();
        setTitle("百度");
        String stringExtra = getIntent().getStringExtra(BdSsoHandler.EXTRA_REDIRECT_URL);
        String stringExtra2 = getIntent().getStringExtra(BdSsoHandler.EXTRA_QR_CODE_URL);
        String stringExtra3 = getIntent().getStringExtra(BdSsoHandler.EXTRA_SCOPE);
        boolean booleanExtra = getIntent().getBooleanExtra(BdSsoHandler.EXTRA_DEGRADE_H5_AUTH, false);
        boolean booleanExtra2 = getIntent().getBooleanExtra(BdSsoHandler.EXTRA_DEGRADE_EXEMPT_AUTH_PAGE, false);
        this.oauthWebView.a(new j(this));
        k kVar = new k(this, stringExtra, stringExtra2, stringExtra3);
        com.baidu.oauth.sdkbqt.auth.i.c cVar = new com.baidu.oauth.sdkbqt.auth.i.c();
        cVar.b = stringExtra;
        cVar.f572a = kVar;
        this.oauthWebView.a(cVar);
        String stringExtra4 = getIntent().getStringExtra(BdSsoHandler.EXTRA_OAUTH_STATE);
        if (getIntent().getIntExtra(BdSsoHandler.EXTRA_GUID_TYPE, 0) == 1) {
            HashMap map = new HashMap();
            map.put("client", "android");
            map.put("clientfrom", "native");
            map.put("suppcheck", "1");
            map.put("oauth_redirect_uri", stringExtra);
            map.put("getauthorizationcode", "1");
            this.oauthWebView.a(stringExtra2, (Map<String, String>) map);
            return;
        }
        if (booleanExtra2) {
            this.oauthWebView.c(stringExtra4);
        } else if (booleanExtra) {
            this.oauthWebView.b(stringExtra4);
        } else {
            this.oauthWebView.a(stringExtra4);
        }
    }

    @Override // com.baidu.oauth.sdkbqt.view.a
    protected void onFinish() {
        setResult(0, com.baidu.oauth.sdkbqt.a.i.a(-205));
        finish();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Intent a(int i) {
        Intent intent = new Intent();
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, i);
            String str = "1";
            jSONObject.put("showLogin", this.e ? "1" : "0");
            if (!this.f) {
                str = "0";
            }
            jSONObject.put("finishLogin", str);
        } catch (JSONException e) {
            com.baidu.oauth.sdkbqt.a.d.a(e);
        }
        intent.putExtra("extra_oauth_result_json", jSONObject.toString());
        return intent;
    }
}
