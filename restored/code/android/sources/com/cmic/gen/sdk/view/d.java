package com.cmic.gen.sdk.view;

import android.app.Dialog;
import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.WindowManager;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import androidx.core.view.InputDeviceCompat;
import com.cmic.gen.sdk.auth.GenAuthnHelper;

/* JADX INFO: compiled from: ServerClauseDialog.java */
/* JADX INFO: loaded from: classes2.dex */
public class d extends Dialog {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WebView f2160a;
    private String b;
    private String c;
    private LinearLayout d;

    public d(Context context, int i, String str, String str2) {
        super(context, i);
        try {
            this.c = str;
            this.b = str2;
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    protected void a() {
        requestWindowFeature(1);
        getWindow().setFeatureDrawableAlpha(0, 0);
        GenAuthThemeConfig authThemeConfig = GenAuthnHelper.getInstance(getContext()).getAuthThemeConfig();
        if (authThemeConfig.isPrivacyPageFullScreen()) {
            getWindow().setFlags(1024, 1024);
            WindowManager.LayoutParams attributes = getWindow().getAttributes();
            if (Build.VERSION.SDK_INT >= 28) {
                attributes.layoutInDisplayCutoutMode = 1;
            }
            getWindow().setAttributes(attributes);
            getWindow().getDecorView().setSystemUiVisibility(1280);
            getWindow().setStatusBarColor(0);
        } else {
            if (authThemeConfig.getStatusBarColor() != 0) {
                getWindow().addFlags(Integer.MIN_VALUE);
                getWindow().clearFlags(67108864);
                getWindow().setStatusBarColor(authThemeConfig.getClauseStatusColor());
                getWindow().setNavigationBarColor(authThemeConfig.getStatusBarColor());
            }
            int i = authThemeConfig.isLightColor() ? 8192 : 0;
            if (authThemeConfig.isNavHidden()) {
                i |= InputDeviceCompat.SOURCE_TOUCHSCREEN;
            }
            getWindow().getDecorView().setSystemUiVisibility(i);
        }
        setContentView(c());
    }

    private ViewGroup c() {
        View viewFindViewById;
        try {
            LinearLayout linearLayout = new LinearLayout(getContext());
            this.d = linearLayout;
            linearLayout.setOrientation(1);
            this.d.setLayoutParams(new ViewGroup.LayoutParams(-1, -1));
            GenAuthThemeConfig authThemeConfig = GenAuthnHelper.getInstance(getContext()).getAuthThemeConfig();
            int clauseLayoutResID = authThemeConfig.getClauseLayoutResID();
            String str = TextUtils.isEmpty(this.c) ? com.cmic.gen.sdk.c.g[authThemeConfig.getAppLanguageType()] : this.c;
            if (authThemeConfig.isGetWebViewTitle()) {
                str = "";
            }
            String str2 = str;
            if (clauseLayoutResID != -1) {
                String clauseLayoutReturnID = authThemeConfig.getClauseLayoutReturnID();
                RelativeLayout relativeLayoutA = e.a(getContext(), getLayoutInflater().inflate(clauseLayoutResID, (ViewGroup) this.d, false), 1118481, c.a(getContext(), clauseLayoutReturnID), str2, null);
                if (!TextUtils.isEmpty(clauseLayoutReturnID) && (viewFindViewById = relativeLayoutA.findViewById(c.a(getContext(), clauseLayoutReturnID))) != null) {
                    viewFindViewById.setOnClickListener(new View.OnClickListener() { // from class: com.cmic.gen.sdk.view.d.1
                        @Override // android.view.View.OnClickListener
                        public void onClick(View view) {
                            d.this.f2160a.stopLoading();
                            d.this.b();
                        }
                    });
                }
                this.d.addView(relativeLayoutA);
            } else {
                this.d.addView(e.a(getContext(), null, 1118481, 2236962, str2, new View.OnClickListener() { // from class: com.cmic.gen.sdk.view.d.2
                    @Override // android.view.View.OnClickListener
                    public void onClick(View view) {
                        d.this.f2160a.stopLoading();
                        d.this.b();
                    }
                }));
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return this.d;
    }

    @Override // android.app.Dialog, android.content.DialogInterface
    public void dismiss() {
        super.dismiss();
        WebView webView = this.f2160a;
        if (webView != null) {
            webView.stopLoading();
        }
    }

    public void b() {
        if (this.f2160a.canGoBack()) {
            this.f2160a.goBack();
        } else {
            dismiss();
        }
    }

    @Override // android.app.Dialog
    public void show() {
        if (this.d == null) {
            a();
        }
        if (this.f2160a == null) {
            d();
        }
        super.show();
    }

    private void d() {
        final GenAuthThemeConfig authThemeConfig = GenAuthnHelper.getInstance(getContext()).getAuthThemeConfig();
        WebView webView = new WebView(getContext());
        this.f2160a = webView;
        WebSettings settings = webView.getSettings();
        settings.setAllowFileAccess(false);
        settings.setAllowContentAccess(false);
        settings.setSavePassword(false);
        settings.setBuiltInZoomControls(false);
        settings.setUseWideViewPort(true);
        settings.setLoadWithOverviewMode(true);
        settings.setLayoutAlgorithm(WebSettings.LayoutAlgorithm.SINGLE_COLUMN);
        settings.setDomStorageEnabled(authThemeConfig.getWebStorage());
        settings.setJavaScriptEnabled(true);
        this.d.addView(this.f2160a, new LinearLayout.LayoutParams(-1, -1));
        this.f2160a.setWebViewClient(new WebViewClient() { // from class: com.cmic.gen.sdk.view.d.3
            @Override // android.webkit.WebViewClient
            public void onPageFinished(WebView webView2, String str) {
                super.onPageFinished(webView2, str);
                if (authThemeConfig.isGetWebViewTitle()) {
                    ((TextView) d.this.d.findViewById(1118481).findViewById(3355443)).setText(d.this.f2160a.getTitle());
                }
            }
        });
        this.f2160a.loadUrl(this.b);
    }
}
