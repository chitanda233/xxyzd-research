package com.sigmob.sdk.mraid;

import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import com.czhj.volley.toolbox.StringUtil;
import java.io.ByteArrayInputStream;

/* JADX INFO: loaded from: classes3.dex */
public class w extends com.sigmob.sdk.base.l {
    private static final String c = "MraidWebViewClient";
    private String d;

    private WebResourceResponse a() {
        return new WebResourceResponse("text/javascript", "UTF-8", new ByteArrayInputStream(b().getBytes()));
    }

    private String b() {
        if (this.d == null) {
            this.d = j.INJECTION_JAVASCRIPT.replaceAll("xxx", StringUtil.decode(StringUtil.s));
        }
        return this.d;
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
