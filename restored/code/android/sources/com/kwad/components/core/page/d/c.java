package com.kwad.components.core.page.d;

import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends Presenter {
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private as.b fj = new as.b() { // from class: com.kwad.components.core.page.d.c.1
        @Override // com.kwad.components.core.webview.jshandler.as.b
        public final void a(as.a aVar) {
        }
    };
    private AdTemplate mAdTemplate;
    private KsAdWebView mAdWebView;

    private void bg() {
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.mAdWebView);
        this.fb = aVar;
        a(aVar);
        this.mAdWebView.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.mAdTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.adg = this.mAdWebView;
    }

    private void a(com.kwad.components.core.webview.a aVar) {
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new as(this.fj, com.kwad.sdk.core.response.helper.a.aY(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))));
        aVar.a(new am(this.fc));
        aVar.b(new o(this.fc));
        aVar.b(new n(this.fc));
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mAdTemplate = ((com.kwad.components.core.page.recycle.e) SK()).adTemplate;
        KsAdWebView ksAdWebView = (KsAdWebView) getRootView().findViewById(R.id.ksad_video_webView);
        this.mAdWebView = ksAdWebView;
        this.mAdWebView.setClientConfig(ksAdWebView.getClientConfig().bV(true).fm(this.mAdTemplate));
        be();
        bg();
        this.mAdWebView.loadUrl(com.kwad.sdk.core.response.helper.a.aY(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)));
        this.mAdWebView.onActivityCreate();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        bh();
        KsAdWebView ksAdWebView = this.mAdWebView;
        if (ksAdWebView != null) {
            ksAdWebView.onActivityDestroy();
            this.mAdWebView = null;
        }
    }
}
