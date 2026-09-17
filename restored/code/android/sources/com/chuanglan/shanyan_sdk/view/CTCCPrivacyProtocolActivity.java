package com.chuanglan.shanyan_sdk.view;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
import android.graphics.Typeface;
import android.net.Uri;
import android.net.http.SslError;
import android.os.Build;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.webkit.SslErrorHandler;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.window.OnBackInvokedCallback;
import cn.thinkingdata.core.router.TRouterMap;
import com.alipay.sdk.m.c0.d;
import com.chuanglan.shanyan_sdk.AbstractC0600f;
import com.chuanglan.shanyan_sdk.AbstractC0606l;
import com.chuanglan.shanyan_sdk.C0616v;
import com.chuanglan.shanyan_sdk.O;
import com.chuanglan.shanyan_sdk.Q;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import com.chuanglan.shanyan_sdk.w0;
import com.chuanglan.shanyan_sdk.x0;
import com.chuanglan.shanyan_sdk.z0;

/* JADX INFO: loaded from: classes2.dex */
public class CTCCPrivacyProtocolActivity extends Activity {
    private static final String[] m = {"e.189.cn", "wap.cmpassport.com", "auth.wosms.cn", "ms.zzx9.cn"};

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WebView f2018a;
    private TextView b;
    private View c;
    private RelativeLayout d;
    private ImageView e;
    private int f;
    private ShanYanUIConfig g;
    private LinearLayout h;
    private OnBackInvokedCallback i;
    private Context j;
    private String k;
    private String l;

    class a implements OnBackInvokedCallback {
        a() {
        }

        @Override // android.window.OnBackInvokedCallback
        public void onBackInvoked() {
            Q.a("ProcessShanYanLogger", "CTCCPrivacyProtocolActivity onBackInvoked");
            CTCCPrivacyProtocolActivity.this.b();
        }
    }

    class b implements View.OnClickListener {
        b() {
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            CTCCPrivacyProtocolActivity.this.b();
        }
    }

    static class c extends WebViewClient {
        c() {
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedSslError(WebView webView, SslErrorHandler sslErrorHandler, SslError sslError) {
            sslErrorHandler.cancel();
        }

        @Override // android.webkit.WebViewClient
        public boolean shouldOverrideKeyEvent(WebView webView, KeyEvent keyEvent) {
            return super.shouldOverrideKeyEvent(webView, keyEvent);
        }

        @Override // android.webkit.WebViewClient
        public boolean shouldOverrideUrlLoading(WebView webView, String str) {
            if (CTCCPrivacyProtocolActivity.b(str)) {
                webView.loadUrl(str);
            } else {
                Q.d("ExceptionShanYanLogger", "WebView blocked unsafe redirect url=", str);
            }
            return true;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b() {
        Q.a("ProcessShanYanLogger", "CTCCPrivacyProtocolActivity onBackPressed");
        WebView webView = this.f2018a;
        if (webView == null || !webView.canGoBack()) {
            Q.a("ProcessShanYanLogger", "Finish PrivacyProtocolActivity");
            finish();
        } else {
            this.f2018a.goBack();
            Q.a("ProcessShanYanLogger", "WebView go back");
        }
    }

    private void c() {
        Intent intent = getIntent();
        this.k = intent.getStringExtra("url");
        this.l = intent.getStringExtra(d.w);
    }

    private void d() {
        this.j = getApplicationContext();
        this.f = getResources().getConfiguration().orientation;
        this.g = com.chuanglan.shanyan_sdk.tool.a.b().a();
        this.c = findViewById(O.a(this.j).b("shanyan_view_navigationbar_include"));
        this.d = (RelativeLayout) findViewById(O.a(this.j).b("shanyan_view_navigationbar_back_root"));
        this.b = (TextView) findViewById(O.a(this.j).b("shanyan_view_navigationbar_title"));
        this.e = (ImageView) findViewById(O.a(this.j).b("shanyan_view_navigationbar_back"));
        this.f2018a = (WebView) findViewById(O.a(this.j).b("shanyan_view_baseweb_webview"));
        this.h = (LinearLayout) findViewById(O.a(this.j).b("shanyan_view_privacy_layout"));
    }

    private void e() {
        String privacyEnterAnim = this.g.getPrivacyEnterAnim();
        String privacyExitAnim = this.g.getPrivacyExitAnim();
        if (privacyEnterAnim == null && privacyExitAnim == null) {
            return;
        }
        overridePendingTransition(O.a(this.j).a(privacyEnterAnim), O.a(this.j).a(privacyExitAnim));
    }

    private void f() {
        m();
        i();
    }

    private void g() {
        this.d.setOnClickListener(new b());
    }

    private void h() {
        try {
            n();
            a();
            f();
            j();
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CTCCPrivacyProtocolActivity setViews Exception=", e);
        }
    }

    private void i() {
        WebSettings settings = this.f2018a.getSettings();
        if (AbstractC0600f.b(this.k) && this.k.startsWith("file://")) {
            settings.setJavaScriptEnabled(false);
            settings.setAllowFileAccess(true);
        } else {
            settings.setJavaScriptEnabled(true);
            settings.setAllowFileAccess(false);
            settings.setAllowFileAccessFromFileURLs(false);
            settings.setAllowUniversalAccessFromFileURLs(false);
        }
        if (this.g.isViewPortEnabled()) {
            settings.setUseWideViewPort(true);
            settings.setLoadWithOverviewMode(true);
        }
        settings.setSupportZoom(true);
        settings.setSavePassword(false);
        settings.setBuiltInZoomControls(true);
        settings.setCacheMode(2);
        settings.setSupportMultipleWindows(true);
        settings.setAllowFileAccessFromFileURLs(false);
        settings.setAllowUniversalAccessFromFileURLs(false);
        settings.setJavaScriptCanOpenWindowsAutomatically(true);
        settings.setDomStorageEnabled(true);
        settings.setPluginState(WebSettings.PluginState.ON);
        this.f2018a.setWebViewClient(new c());
        if (AbstractC0600f.b(this.k) && b(this.k)) {
            this.f2018a.loadUrl(this.k);
        } else {
            Q.d("ExceptionShanYanLogger", "CTCCPrivacyProtocolActivity blocked unsafe url=", this.k);
        }
    }

    private void j() {
        try {
            if (!this.g.isPrivacyBackNavigationEnabled() || Build.VERSION.SDK_INT < 33) {
                return;
            }
            this.i = new a();
            getOnBackInvokedDispatcher().registerOnBackInvokedCallback(0, this.i);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void k() {
        if (this.g.isPrivacyNavReturnImgHidden()) {
            this.d.setVisibility(8);
            return;
        }
        this.d.setVisibility(0);
        if (this.g.getPrivacyNavReturnImgPath() != null) {
            this.e.setImageDrawable(this.g.getPrivacyNavReturnImgPath());
        } else {
            this.e.setImageResource(this.j.getResources().getIdentifier("umcsdk_return_bg", "drawable", C0616v.g().c(this.j)));
        }
        w0.a(this.j, this.d, this.g.getPrivacyNavReturnBtnOffsetX(), this.g.getPrivacyNavReturnBtnOffsetY(), this.g.getPrivacyNavReturnBtnOffsetRightX(), this.g.getPrivacyReturnBtnWidth(), this.g.getPrivacyReturnBtnHeight(), this.e);
    }

    private void l() {
        if (AbstractC0600f.a(this.l)) {
            this.b.setVisibility(8);
            return;
        }
        this.b.setVisibility(0);
        this.b.setText(this.l);
        this.b.setTextColor(this.g.getPrivacyNavTextColor());
        this.b.setTextSize(this.g.isTextSizeIsdp() ? 1 : 2, this.g.getPrivacyNavTextSize());
        this.b.setTypeface(Typeface.defaultFromStyle(this.g.isPrivacyNavTextBold() ? 1 : 0));
    }

    private void m() {
        if (this.g.isPrivacyNavHidden()) {
            this.c.setVisibility(8);
            return;
        }
        this.c.setVisibility(0);
        this.c.setBackgroundColor(this.g.getPrivacyNavColor());
        if (this.g.isPrivacyNavTransparent()) {
            this.c.getBackground().setAlpha(0);
        }
        l();
        k();
    }

    private void n() {
        com.chuanglan.shanyan_sdk.tool.a aVarB = com.chuanglan.shanyan_sdk.tool.a.b();
        ShanYanUIConfig shanYanUIConfigA = aVarB.a();
        ShanYanUIConfig shanYanUIConfigC = aVarB.c();
        if (shanYanUIConfigC == null) {
            shanYanUIConfigC = shanYanUIConfigA;
        }
        if (this.f != 1) {
            shanYanUIConfigA = shanYanUIConfigC;
        }
        this.g = shanYanUIConfigA;
    }

    @Override // android.app.Activity
    public void finish() {
        super.finish();
        try {
            e();
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CTCCPrivacyProtocolActivity finish Exception=", e);
        }
    }

    @Override // android.app.Activity, android.content.ComponentCallbacks
    public void onConfigurationChanged(Configuration configuration) {
        super.onConfigurationChanged(configuration);
        try {
            int i = configuration.orientation;
            Q.a("UIShanYanLogger", "configurationChanged", Integer.valueOf(i), Integer.valueOf(this.f));
            if (this.f != i) {
                this.f = i;
                h();
            }
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CTCCPrivacyProtocolActivity onConfigurationChanged Exception=", e);
        }
    }

    @Override // android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        try {
            if (bundle != null) {
                Q.a("ProcessShanYanLogger", "recreate and savedInstanceState is not null");
                finish();
                return;
            }
            setContentView(O.a(this).c("layout_shanyan_privacy"));
            d();
            c();
            g();
            h();
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CTCCPrivacyProtocolActivity onCreate Exception=", e);
            finish();
        }
    }

    @Override // android.app.Activity
    protected void onDestroy() {
        super.onDestroy();
        try {
            if (this.i != null && Build.VERSION.SDK_INT >= 33) {
                getOnBackInvokedDispatcher().unregisterOnBackInvokedCallback(this.i);
                this.i = null;
            }
            WebView webView = this.f2018a;
            if (webView != null) {
                webView.stopLoading();
                this.f2018a.setWebViewClient(null);
                this.f2018a.destroy();
                this.f2018a = null;
            }
            LinearLayout linearLayout = this.h;
            if (linearLayout != null) {
                x0.a(linearLayout);
                this.h = null;
            }
            View view = this.c;
            if (view != null) {
                x0.a(view);
                this.c = null;
            }
            RelativeLayout relativeLayout = this.d;
            if (relativeLayout != null) {
                x0.a(relativeLayout);
                this.d = null;
            }
            this.b = null;
            this.e = null;
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @Override // android.app.Activity, android.view.KeyEvent.Callback
    public boolean onKeyDown(int i, KeyEvent keyEvent) {
        if (i != 4 || keyEvent.getRepeatCount() != 0) {
            return super.onKeyDown(i, keyEvent);
        }
        Q.a("ProcessShanYanLogger", "CTCCPrivacyProtocolActivity onKeyDown");
        b();
        return true;
    }

    private void a() {
        z0.a(this, this.g.isPrivacyFlagSecureEnable());
        e();
        z0.b(this, this.g.isPrivacyFullScreen());
        if (!this.g.isPrivacyFullScreen()) {
            z0.b(this, this.g);
        }
        z0.a(this.h, this.g.isFitsSystemWindows());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean b(String str) {
        int i;
        if (!AbstractC0606l.K) {
            return true;
        }
        if (AbstractC0600f.a(str)) {
            return false;
        }
        if (str.startsWith("file://")) {
            return true;
        }
        try {
            String host = Uri.parse(str).getHost();
            if (AbstractC0600f.a(host)) {
                return false;
            }
            for (String str2 : m) {
                i = (host.equals(str2) || host.endsWith(TRouterMap.DOT + str2)) ? 0 : i + 1;
                return true;
            }
            for (String str3 : AbstractC0606l.L) {
                if (AbstractC0600f.b(str3) && (host.equals(str3) || host.endsWith(TRouterMap.DOT + str3))) {
                    return true;
                }
            }
            return false;
        } catch (Exception e) {
            Q.d("ExceptionShanYanLogger", "isUrlSafe parse Exception=", e);
            return false;
        }
    }
}
