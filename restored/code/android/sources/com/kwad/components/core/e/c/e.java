package com.kwad.components.core.e.c;

import android.view.View;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.ak;
import com.kwad.components.core.webview.jshandler.al;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.ag;
import com.kwad.sdk.utils.au;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends c implements View.OnClickListener {
    public b Qn;
    public b.C0427b Qo;
    private Runnable Qw;
    private KsAdWebView eZ;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private az ff;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private boolean Qx = false;
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.core.e.c.e.1
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            com.kwad.sdk.core.d.c.d("DownloadTipsDialogWebCardPresenter", "onAdClicked convertBridgeClicked: " + e.this.Qx);
            e.a(e.this, true);
        }
    };
    private al.b fh = new al.b() { // from class: com.kwad.components.core.e.c.e.4
        @Override // com.kwad.components.core.webview.jshandler.al.b
        public final void a(al.a aVar) {
            com.kwad.sdk.core.d.c.d("DownloadTipsDialogWebCardPresenter", "onAdFrameValid=" + aVar);
            e.this.eZ.setTranslationY(aVar.height + aVar.bottomMargin);
        }
    };
    private ak.b fi = new ak.b() { // from class: com.kwad.components.core.e.c.e.5
        @Override // com.kwad.components.core.webview.jshandler.ak.b
        public final void a(ak.a aVar) {
            com.kwad.sdk.core.d.c.d("DownloadTipsDialogWebCardPresenter", "handleWebCardHide");
            e.this.bm();
        }
    };
    private as.b fj = new as.b() { // from class: com.kwad.components.core.e.c.e.6
        @Override // com.kwad.components.core.webview.jshandler.as.b
        public final void a(as.a aVar) {
            com.kwad.sdk.core.d.c.i("DownloadTipsDialogWebCardPresenter", "updatePageStatus mPageState: " + aVar);
            if (aVar.status == 1) {
                e.this.pL();
                return;
            }
            e.this.bm();
            if (e.this.getContext() != null) {
                ae.V(e.this.getContext(), ag.dk(e.this.getContext()));
            }
        }
    };

    static /* synthetic */ boolean a(e eVar, boolean z) {
        eVar.Qx = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.eZ = (KsAdWebView) findViewById(R.id.ksad_download_tips_web_card_webView);
    }

    @Override // com.kwad.components.core.e.c.c, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Qn = this.Qp.Qn;
        this.Qo = this.Qp.Qo;
        this.mAdTemplate = this.Qp.mAdTemplate;
        this.Qp.mRootContainer.setOnClickListener(this);
        this.mApkDownloadHelper = this.Qp.mApkDownloadHelper;
        be();
        pJ();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        pL();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        release();
    }

    private void release() {
        this.eZ.setVisibility(8);
        this.eZ.release();
        bh();
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.Qp.mAdTemplate);
        this.fc.bbV = this.Qp.mRootContainer;
        this.fc.adZ = this.Qp.mRootContainer;
        this.fc.adg = this.eZ;
    }

    private void pJ() {
        bg();
        this.eZ.loadUrl(this.Qo.url);
        this.eZ.postDelayed(pK(), 1500L);
        this.eZ.setBackgroundColor(0);
        this.eZ.getBackground().setAlpha(0);
        this.eZ.setVisibility(0);
    }

    private Runnable pK() {
        if (this.Qw == null) {
            this.Qw = new Runnable() { // from class: com.kwad.components.core.e.c.e.2
                @Override // java.lang.Runnable
                public final void run() {
                    e.this.bm();
                    if (e.this.getContext() != null) {
                        ae.V(e.this.getContext(), ag.dk(e.this.getContext()));
                    }
                }
            };
        }
        return this.Qw;
    }

    private void bg() {
        com.kwad.sdk.core.d.c.d("DownloadTipsDialogWebCardPresenter", "setupJsBridge");
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.eZ);
        this.fb = aVar;
        a(aVar);
        this.eZ.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    private void a(com.kwad.components.core.webview.a aVar) {
        aVar.a(new ac(this.fc, this.mApkDownloadHelper, this.fg));
        aVar.a(new z(this.fc, this.mApkDownloadHelper, this.fg, 1));
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new com.kwad.components.core.webview.jshandler.ae(this.fc));
        aVar.a(new al(this.fc, this.fh));
        aVar.a(new as(this.fj, this.Qo.url));
        az azVar = new az();
        this.ff = azVar;
        aVar.a(azVar);
        aVar.a(new bc(this.fc, this.mApkDownloadHelper, new com.kwad.sdk.core.download.a.c() { // from class: com.kwad.components.core.e.c.e.3
            @Override // com.kwad.sdk.core.download.a.c, com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                super.onInstalled();
                AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(e.this.mAdTemplate);
                String strAE = com.kwad.sdk.core.response.helper.a.aE(adInfoEM);
                if (com.kwad.sdk.core.response.helper.a.aU(adInfoEM) && com.kwad.sdk.core.response.helper.a.aL(adInfoEM) && au.aw(e.this.getContext(), strAE) && com.kwad.components.core.r.a.wy().wC() && com.kwad.sdk.core.response.helper.a.aT(adInfoEM) == 1) {
                    e.this.Qn.dismiss();
                }
            }
        }));
        aVar.a(new ak(this.fi));
        aVar.a(new am(this.fc));
        aVar.b(new o(this.fc));
        aVar.b(new n(this.fc));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void pL() {
        Runnable runnable = this.Qw;
        if (runnable != null) {
            this.eZ.removeCallbacks(runnable);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bm() {
        com.kwad.sdk.core.d.c.d("DownloadTipsDialogWebCardPresenter", "hideWithOutAnimation  convertBridgeClicked: " + this.Qx);
        if (this.eZ.getVisibility() != 0) {
            return;
        }
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yL();
        }
        this.eZ.setVisibility(4);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yM();
        }
        if (this.Qx) {
            com.kwad.sdk.core.adlog.c.ct(this.mAdTemplate);
        }
        b bVar = this.Qn;
        if (bVar == null || !bVar.isShowing()) {
            return;
        }
        this.Qn.an(this.Qx);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        com.kwad.sdk.core.adlog.c.ct(this.mAdTemplate);
        b bVar = this.Qn;
        if (bVar != null) {
            bVar.dismiss();
        }
    }
}
