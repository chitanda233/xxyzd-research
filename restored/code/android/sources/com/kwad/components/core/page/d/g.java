package com.kwad.components.core.page.d;

import android.text.TextUtils;
import android.view.ViewGroup;
import android.webkit.WebView;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.aq;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends d {
    private int adY = -1;
    private ViewGroup adZ;
    private WebView adg;
    private final a aea;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private AdTemplate mAdTemplate;
    private final boolean mIsRewardLandPage;

    public interface a {
        void bm(int i);
    }

    public g(a aVar, boolean z) {
        this.aea = aVar;
        this.mIsRewardLandPage = z;
    }

    @Override // com.kwad.components.core.page.d.d, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.adW.mAdTemplate;
        this.mAdTemplate = adTemplate;
        String strDc = com.kwad.sdk.core.response.helper.b.dc(adTemplate);
        if (!TextUtils.isEmpty(strDc)) {
            be();
            aZ(strDc);
        } else {
            a aVar = this.aea;
            if (aVar != null) {
                aVar.bm(this.adY);
            }
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        bh();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.adg = (WebView) findViewById(R.id.ksad_landing_page_webview);
        this.adZ = (ViewGroup) findViewById(R.id.ksad_web_card_container);
        this.adg.setBackgroundColor(0);
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.mAdTemplate);
        this.fc.adZ = this.adZ;
        this.fc.adg = this.adg;
    }

    private void aZ(String str) {
        bg();
        this.adg.loadUrl(str);
    }

    private void bg() {
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.adg);
        this.fb = aVar;
        a(aVar);
        this.adg.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void a(com.kwad.components.core.webview.a aVar) {
        com.kwad.sdk.core.d.c.d("LandPageWebViewPresenter", "registerWebCardHandler");
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.adW.mAdTemplate);
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new bc(this.fc, dVar));
        aVar.a(new ae(this.fc));
        aVar.a(new az());
        aVar.a(new as(uv(), com.kwad.sdk.core.response.helper.b.dc(this.mAdTemplate)));
        aVar.a(new am(this.fc));
        aVar.b(new o(this.fc));
        aVar.b(new n(this.fc));
        aVar.a(new aq(getOpenNewPageListener()));
        aVar.a(new ac(this.fc, dVar, null, (byte) 0));
        aVar.a(new z(this.fc, dVar, null, 2, this.mIsRewardLandPage));
    }

    private as.b uv() {
        return new as.b() { // from class: com.kwad.components.core.page.d.g.1
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(as.a aVar) {
                g.this.adY = aVar.status;
                if (g.this.aea != null) {
                    g.this.aea.bm(aVar.status);
                }
                if (aVar.status == 1) {
                    g.this.adZ.setVisibility(0);
                } else {
                    g.this.adg.setVisibility(8);
                }
            }
        };
    }

    private aq.a getOpenNewPageListener() {
        return new aq.a() { // from class: com.kwad.components.core.page.d.g.2
            @Override // com.kwad.components.core.webview.jshandler.aq.a
            public final void a(com.kwad.components.core.webview.a.b bVar) {
                AdWebViewActivityProxy.launch(g.this.adg.getContext(), new AdWebViewActivityProxy.a.C0449a().aW(bVar.title).aX(bVar.url).aQ(true).aU(g.this.mAdTemplate).um());
            }
        };
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }
}
