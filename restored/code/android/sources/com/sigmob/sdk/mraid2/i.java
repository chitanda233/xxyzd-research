package com.sigmob.sdk.mraid2;

import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import java.io.ByteArrayInputStream;

/* JADX INFO: loaded from: classes3.dex */
public class i extends com.sigmob.sdk.base.l {
    private static final String c = "Mraid2WebViewClient";

    private WebResourceResponse a() {
        return new WebResourceResponse("text/javascript", "UTF-8", new ByteArrayInputStream(g.INJECTION_JAVASCRIPT.getBytes()));
    }

    @Override // com.sigmob.sdk.base.l, android.webkit.WebViewClient
    public WebResourceResponse shouldInterceptRequest(WebView view, String url) {
        if (com.sigmob.sdk.base.utils.x.a(url)) {
            return null;
        }
        if (a(url)) {
            try {
                return a();
            } catch (Exception e) {
                com.sigmob.sdk.base.utils.k.f(c, "shouldInterceptRequest: error = " + e.getMessage(), new Object[0]);
            }
        }
        return super.shouldInterceptRequest(view, url);
    }
}
