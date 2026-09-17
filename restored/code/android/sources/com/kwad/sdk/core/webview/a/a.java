package com.kwad.sdk.core.webview.a;

import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import com.kwad.sdk.core.config.e;

/* JADX INFO: loaded from: classes3.dex */
public class a extends WebViewClient {
    private boolean bcl = true;
    protected String mUniqueId = "";

    public final void setNeedHybridLoad(boolean z) {
        this.bcl = z;
    }

    @Override // android.webkit.WebViewClient
    public WebResourceResponse shouldInterceptRequest(WebView webView, String str) {
        if (!this.bcl || !e.Km()) {
            return super.shouldInterceptRequest(webView, str);
        }
        com.kwad.sdk.core.d.c.d("HybridWebViewClient", "shouldInterceptRequest: " + str);
        WebResourceResponse webResourceResponseAc = com.kwad.sdk.core.webview.b.a.PQ().ac(str, this.mUniqueId);
        return webResourceResponseAc == null ? super.shouldInterceptRequest(webView, str) : webResourceResponseAc;
    }

    @Override // android.webkit.WebViewClient
    public WebResourceResponse shouldInterceptRequest(WebView webView, WebResourceRequest webResourceRequest) {
        if (!this.bcl || !e.Km()) {
            return super.shouldInterceptRequest(webView, webResourceRequest);
        }
        String string = webResourceRequest.getUrl().toString();
        com.kwad.sdk.core.d.c.d("HybridWebViewClient", "shouldInterceptRequestAPI 21: " + string);
        WebResourceResponse webResourceResponseAc = com.kwad.sdk.core.webview.b.a.PQ().ac(string, this.mUniqueId);
        return webResourceResponseAc == null ? super.shouldInterceptRequest(webView, webResourceRequest) : webResourceResponseAc;
    }
}
