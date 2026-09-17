package com.kwad.components.ad.reward.n;

import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.al;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.bf;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.br;

/* JADX INFO: loaded from: classes3.dex */
public class e extends com.kwad.sdk.core.download.a.a implements al.b, as.b {
    private View Dc;
    private bf Dd;
    private f De;
    private KsAdWebView eZ;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private com.kwad.sdk.core.webview.d.a.a fg;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private final com.kwad.components.ad.reward.e.l mRewardVerifyListener = new com.kwad.components.ad.reward.e.l() { // from class: com.kwad.components.ad.reward.n.e.1
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (e.this.Dd != null) {
                e.this.Dd.aj(true);
            }
        }
    };

    public e(KsAdWebView ksAdWebView, View view, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar) {
        this.Dc = view;
        this.eZ = ksAdWebView;
        this.mApkDownloadHelper = dVar;
        this.fg = aVar;
    }

    public final void a(f fVar) {
        this.De = fVar;
    }

    public final void a(AdTemplate adTemplate, ViewGroup viewGroup) {
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView != null) {
            ksAdWebView.setBackgroundColor(0);
            if (this.eZ.getBackground() != null) {
                this.eZ.getBackground().setAlpha(0);
            }
        }
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.mAdTemplate = adTemplate;
        b(adTemplate, viewGroup);
        aa(com.kwad.sdk.core.response.helper.b.cQ(this.mAdTemplate));
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.b(this);
        }
    }

    public final void lw() {
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.c(this);
        }
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
    }

    private void ae(boolean z) {
        com.kwad.sdk.core.d.c.d("BottomCardWebViewHelper", "switchWebView: " + z);
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView == null) {
            return;
        }
        ksAdWebView.setVisibility(z ? 0 : 8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void lx() {
        View view = this.Dc;
        if (view != null) {
            view.setVisibility(0);
        }
        ae(false);
    }

    private void b(AdTemplate adTemplate, ViewGroup viewGroup) {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(adTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.bbV = null;
        this.fc.adZ = viewGroup;
        this.fc.adg = this.eZ;
        this.fc.mReportExtData = null;
        this.fc.bbX = true;
    }

    private void aa(String str) {
        if (br.isNullString(str)) {
            lx();
            return;
        }
        bh();
        this.eZ.setClientConfig(this.eZ.getClientConfig().fm(this.mAdTemplate).b(getWebErrorListener()));
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.eZ);
        this.fb = aVar;
        a(aVar, str);
        this.eZ.addJavascriptInterface(this.fb, "KwaiAd");
        this.eZ.loadUrl(str);
    }

    private KsAdWebView.e getWebErrorListener() {
        return new KsAdWebView.e() { // from class: com.kwad.components.ad.reward.n.e.2
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                com.kwad.sdk.core.d.c.d("BottomCardWebViewHelper", "onReceivedHttpError: " + i + ", " + str);
                e.this.lx();
            }
        };
    }

    private void a(com.kwad.components.core.webview.a aVar, String str) {
        aVar.a(new z(this.fc, this.mApkDownloadHelper, this.fg));
        aVar.a(new af(this.fc));
        aVar.a(new ae(this.fc));
        aVar.a(new as(this, str));
        bf bfVar = new bf();
        this.Dd = bfVar;
        aVar.a(bfVar);
        aVar.a(new am(this.fc));
        aVar.b(new com.kwad.components.core.webview.jshandler.o(this.fc));
        aVar.b(new com.kwad.components.core.webview.jshandler.n(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new com.kwad.components.core.webview.tachikoma.b.f());
        aVar.a(new al(this.fc, this));
        aVar.a(new bc(this.fc, this.mApkDownloadHelper));
        aVar.a(new com.kwad.components.ad.reward.i.b(this.eZ.getContext(), this.mAdTemplate, PlayableSource.ACTIONBAR_CLICK));
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    @Override // com.kwad.components.core.webview.jshandler.as.b
    public final void a(as.a aVar) {
        com.kwad.sdk.core.d.c.d("BottomCardWebViewHelper", getClass().getName() + " updatePageStatus: " + aVar);
        if (aVar.status == 1) {
            ae(true);
        } else {
            lx();
        }
    }

    @Override // com.kwad.components.core.webview.jshandler.al.b
    public final void a(al.a aVar) {
        com.kwad.sdk.core.d.c.d("BottomCardWebViewHelper", "onAdFrameValid : " + aVar.toJson());
    }

    private void k(String str, int i) {
        f fVar = this.De;
        if (fVar != null) {
            fVar.i(str, i);
        }
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onIdle() {
        AdTemplate adTemplate = this.mAdTemplate;
        k(adTemplate != null ? com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即下载", 100);
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onProgressUpdate(int i) {
        if (i != 0) {
            k(com.kwad.sdk.core.response.helper.a.ev(i), i);
        }
    }

    @Override // com.kwad.sdk.core.download.a.a
    public final void onPaused(int i) {
        k(com.kwad.sdk.core.response.helper.a.ew(i), i);
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onDownloadFinished() {
        AdTemplate adTemplate = this.mAdTemplate;
        k(adTemplate == null ? "" : com.kwad.sdk.core.response.helper.a.cF(adTemplate), 100);
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onInstalled() {
        AdTemplate adTemplate = this.mAdTemplate;
        k(adTemplate != null ? com.kwad.sdk.core.response.helper.a.af(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即打开", 100);
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onDownloadFailed() {
        AdTemplate adTemplate = this.mAdTemplate;
        k(adTemplate != null ? com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即下载", 100);
    }
}
