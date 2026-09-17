package com.kwad.components.core.page.d.a;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebView;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.mvp.a {
    public AdWebViewActivityProxy.a adE;
    public WebView aed;
    public com.kwad.components.core.page.a.b aee;
    public KsAdWebView.c aef;
    public f.a aeg;

    @Deprecated
    public com.kwad.components.core.webview.jshandler.b aeh;
    public com.kwad.components.core.page.a.a aei;
    public com.kwad.components.core.b.a aej;
    public boolean aek = false;
    public boolean ael = false;
    public AdTemplate mAdTemplate;
    public KsAdWebView mAdWebView;
    public boolean mAutoShow;
    public Context mContext;
    public String mH5AuthUrl;
    public String mPageTitle;
    public String mPageUrl;
    public ViewGroup mRootContainer;
    public boolean mShowPermission;
    public com.kwad.sdk.core.webview.d.a.b mWebCardCloseListener;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        this.aef = null;
        this.aeg = null;
        this.mWebCardCloseListener = null;
        this.aeh = null;
    }

    public final boolean uh() {
        return this.mShowPermission;
    }

    public final void a(KsAdWebView.c cVar) {
        this.aef = cVar;
    }

    public final void a(f.a aVar) {
        this.aeg = aVar;
    }

    public final void setWebCardCloseListener(com.kwad.sdk.core.webview.d.a.b bVar) {
        this.mWebCardCloseListener = bVar;
    }

    public final void setH5AuthListener(com.kwad.components.core.page.a.a aVar) {
        this.aei = aVar;
    }

    private void aU(boolean z) {
        this.ael = z;
    }

    public final void a(boolean z, View view) {
        KsAdWebView ksAdWebView = this.mAdWebView;
        if (ksAdWebView != null && ksAdWebView.canGoBack()) {
            this.mAdWebView.goBack();
            if (z) {
                com.kwad.sdk.core.adlog.c.cr(this.mAdTemplate);
                return;
            }
            return;
        }
        com.kwad.components.core.page.a.b bVar = this.aee;
        if (bVar != null) {
            bVar.uc();
        }
    }

    public final boolean uw() {
        return this.ael;
    }

    public final void a(com.kwad.components.core.webview.jshandler.b bVar) {
        this.aeh = bVar;
        aU(true);
    }

    public final void ux() {
        this.aeh = null;
        aU(false);
    }

    public final void uo() {
        com.kwad.components.core.webview.jshandler.b bVar = this.aeh;
        if (bVar != null) {
            bVar.uJ();
        }
    }

    public final boolean uy() {
        return !uh();
    }
}
