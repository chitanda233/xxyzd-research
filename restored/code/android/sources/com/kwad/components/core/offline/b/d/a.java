package com.kwad.components.core.offline.b.d;

import android.content.Context;
import android.webkit.CookieManager;
import android.webkit.WebView;
import android.widget.FrameLayout;
import com.kwad.components.offline.api.core.webview.BaseKsWebView;
import com.kwad.sdk.core.response.helper.c;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.ce;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends BaseKsWebView {
    private KsAdWebView acX;
    private boolean enableScroll;

    public a(Context context) {
        super(context);
        init(context);
    }

    private void init(Context context) {
        setBackgroundColor(0);
        this.acX = new KsAdWebView(context);
        this.acX.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
        this.acX.setBackgroundColor(0);
        this.acX.setClientConfig(this.acX.getClientConfig().b(new KsAdWebView.e() { // from class: com.kwad.components.core.offline.b.d.a.3
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                if (a.this.mWebLoadListener != null) {
                    a.this.mWebLoadListener.onReceivedHttpError(i, str, str2);
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
                if (a.this.mWebLoadListener != null) {
                    a.this.mWebLoadListener.onPageStart();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                if (a.this.mWebLoadListener != null) {
                    a.this.mWebLoadListener.onPageFinished();
                }
            }
        }).a(new KsAdWebView.b() { // from class: com.kwad.components.core.offline.b.d.a.2
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                if (a.this.mDeeplinkListener != null) {
                    a.this.mDeeplinkListener.onSuccess();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                if (a.this.mDeeplinkListener != null) {
                    a.this.mDeeplinkListener.onFailed();
                }
            }
        }).a(new KsAdWebView.d() { // from class: com.kwad.components.core.offline.b.d.a.1
            @Override // com.kwad.sdk.core.webview.KsAdWebView.d
            public final boolean shouldOverrideUrlLoading(WebView webView, String str) {
                if (a.this.mWebLoadListener != null) {
                    return a.this.mWebLoadListener.shouldOverrideUrlLoading(webView, str);
                }
                return false;
            }
        }));
        addView(this.acX);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setContextUniqId(int i) {
        AdTemplate adTemplateR = c.r(com.kwad.components.core.offline.a.f.a.a.bf(i));
        if (adTemplateR == null || this.acX.getClientConfig() == null) {
            return;
        }
        this.acX.getClientConfig().fm(adTemplateR);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAdCacheId(int i, String str) {
        AdTemplate adTemplateA = c.a(com.kwad.components.core.offline.a.f.a.a.bf(i), str);
        if (adTemplateA == null || this.acX.getClientConfig() == null) {
            return;
        }
        this.acX.getClientConfig().fm(adTemplateA);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAdTemplateString(String str) {
        try {
            JSONObject jSONObject = new JSONObject(str);
            AdTemplate adTemplate = new AdTemplate();
            adTemplate.parseJson(jSONObject);
            this.acX.getClientConfig().fm(adTemplate);
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setEnableWebCache(boolean z) {
        this.acX.setNeedHybridLoad(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void callJs(String str) {
        ce.a(this.acX, str, (String) null);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void callJs(String str, String str2) {
        ce.a(this.acX, str, str2);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final boolean canGoBack() {
        return this.acX.canGoBack();
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final boolean canGoForward() {
        return this.acX.canGoForward();
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void goBack() {
        this.acX.goBack();
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void goForward() {
        this.acX.goForward();
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setDeeplinkEnabled(boolean z) {
        if (this.acX.getClientConfig() != null) {
            this.acX.getClientConfig().bR(z);
        }
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setInnerDownloadEnabled(boolean z) {
        if (this.acX.getClientConfig() != null) {
            this.acX.getClientConfig().bU(z);
        }
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAllowFileAccess(boolean z) {
        this.acX.getSettings().setAllowFileAccess(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setCacheMode(int i) {
        this.acX.getSettings().setCacheMode(i);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAllowContentAccess(boolean z) {
        this.acX.getSettings().setAllowContentAccess(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setJavaScriptEnabled(boolean z) {
        this.acX.getSettings().setJavaScriptEnabled(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setSavePassword(boolean z) {
        this.acX.getSettings().setSavePassword(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setTextZoom(int i) {
        this.acX.getSettings().setTextZoom(i);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAllowFileAccessFromFileURLs(boolean z) {
        this.acX.getSettings().setAllowFileAccessFromFileURLs(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAllowUniversalAccessFromFileURLs(boolean z) {
        this.acX.getSettings().setAllowUniversalAccessFromFileURLs(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setMixedContentMode(int i) {
        this.acX.getSettings().setMixedContentMode(i);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setDebugEnabled(boolean z) {
        WebView.setWebContentsDebuggingEnabled(z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setAcceptThirdPartyCookies(boolean z) {
        CookieManager.getInstance().setAcceptThirdPartyCookies(this.acX, z);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void setEnableScroll(boolean z) {
        this.enableScroll = z;
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView, android.view.View
    public final void scrollTo(int i, int i2) {
        if (this.enableScroll) {
            this.acX.scrollTo(i, i2);
        }
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView, android.view.View
    public final void scrollBy(int i, int i2) {
        if (this.enableScroll) {
            this.acX.scrollBy(i, i2);
        }
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void loadUrl(String str) {
        this.acX.loadUrl(str);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void addJavascriptInterface(Object obj, String str) {
        this.acX.addJavascriptInterface(obj, str);
    }

    @Override // com.kwad.components.offline.api.core.webview.BaseKsWebView
    public final void destroy() {
        this.acX.destroy();
    }
}
