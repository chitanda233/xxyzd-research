package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.os.Vibrator;
import android.text.TextUtils;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.webkit.WebView;
import android.widget.FrameLayout;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bb;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.by;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class t extends e implements com.kwad.components.ad.splashscreen.e, com.kwad.components.ad.splashscreen.g, com.kwad.sdk.core.j.c {
    private com.kwad.components.ad.splashscreen.e.b Jb;
    private boolean Jc;
    private long Je;
    private az Jf;
    private ViewGroup Jh;
    private KsAdWebView eZ;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private com.kwad.sdk.core.g.d hm;
    private Vibrator ho;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private long mStartTime;
    private boolean Jd = false;
    private boolean Jg = false;
    private final Runnable Ji = new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.t.1
        @Override // java.lang.Runnable
        public final void run() {
            t.a(t.this, true);
            com.kwad.components.ad.splashscreen.monitor.c.a(t.this.mAdTemplate, com.kwad.sdk.core.response.helper.b.cO(t.this.mAdTemplate), SystemClock.elapsedRealtime() - t.this.Je, 1, "");
            t.this.nd();
        }
    };

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
    }

    static /* synthetic */ boolean a(t tVar, boolean z) {
        tVar.Jg = true;
        return true;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mStartTime = SystemClock.elapsedRealtime();
        this.Hu.GH.a(this);
        ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_splash_webview_container);
        this.Jh = viewGroup;
        viewGroup.setVisibility(0);
        try {
            this.eZ = new KsAdWebView(getContext());
            this.eZ.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
            this.Jh.addView(this.eZ);
        } catch (Throwable unused) {
        }
        AdTemplate adTemplate = this.Hu.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.Jc = false;
        this.Jd = false;
        String strCO = com.kwad.sdk.core.response.helper.b.cO(this.mAdTemplate);
        if (this.eZ != null && !TextUtils.isEmpty(strCO) && !this.Hu.GM) {
            this.Je = SystemClock.elapsedRealtime();
            com.kwad.components.ad.splashscreen.monitor.c.au(this.mAdTemplate);
            a(this.eZ, strCO);
            by.a(this.Ji, null, com.kwad.sdk.core.response.helper.b.et(this.mAdInfo));
        } else {
            nd();
        }
        this.Hu.a(this);
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.mAdTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.bbV = this.Hu.mRootContainer;
        this.fc.adZ = this.Hu.mRootContainer;
        this.fc.adg = this.eZ;
        this.fc.mReportExtData = null;
        this.fc.bbX = false;
        this.fc.bbY = com.kwad.components.ad.splashscreen.h.o(this.mAdInfo);
    }

    private void a(KsAdWebView ksAdWebView, final String str) {
        ksAdWebView.setBackgroundColor(0);
        ksAdWebView.setVisibility(0);
        be();
        a((WebView) ksAdWebView, str);
        ksAdWebView.setClientConfig(ksAdWebView.getClientConfig().fm(this.Hu.mAdTemplate).b(new com.kwad.sdk.core.webview.f() { // from class: com.kwad.components.ad.splashscreen.presenter.t.3
            @Override // com.kwad.sdk.core.webview.f, com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str2, String str3) {
                super.onReceivedHttpError(i, str2, str3);
                by.b(t.this.Ji);
                t.this.nd();
                com.kwad.components.ad.splashscreen.monitor.c.a(t.this.mAdTemplate, str, SystemClock.elapsedRealtime() - t.this.Je, 2, str2);
            }

            @Override // com.kwad.sdk.core.webview.f, com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                super.onPageFinished();
                com.kwad.components.ad.splashscreen.monitor.c.b(t.this.mAdTemplate, str, SystemClock.elapsedRealtime() - t.this.Je);
            }
        }));
        com.kwad.components.ad.splashscreen.monitor.c.d(str, this.mAdTemplate);
        try {
            ksAdWebView.loadUrl(str);
        } catch (Throwable unused) {
            nd();
        }
    }

    private void a(WebView webView, String str) {
        bh();
        webView.getSettings().setAllowFileAccess(true);
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(webView);
        this.fb = aVar;
        a(aVar, str);
        webView.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    private void a(com.kwad.components.core.webview.a aVar, final String str) {
        aVar.a(new bc(this.fc, this.Hu.mApkDownloadHelper));
        aVar.a(ng());
        aVar.a(nf());
        aVar.a(new af(this.fc));
        aVar.a(new com.kwad.components.core.webview.tachikoma.b.f());
        aVar.a(new as(new as.b() { // from class: com.kwad.components.ad.splashscreen.presenter.t.4
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(as.a aVar2) {
                com.kwad.sdk.core.d.c.d("SplashWebViewPresenter", "updatePageStatus: " + aVar2);
                by.b(t.this.Ji);
                if (aVar2.status == 1) {
                    t.this.Hu.GX = SystemClock.elapsedRealtime() - t.this.mStartTime;
                    if (!t.this.Jg) {
                        if (t.this.Jf != null) {
                            t.this.Jf.yJ();
                            t.this.Jf.yK();
                        }
                    } else {
                        t.this.Hu.isWebTimeout = true;
                    }
                    if (com.kwad.sdk.core.response.helper.b.er(t.this.mAdInfo)) {
                        t.this.nc();
                        return;
                    }
                    return;
                }
                com.kwad.components.ad.splashscreen.monitor.c.a(t.this.mAdTemplate, str, SystemClock.elapsedRealtime() - t.this.Je, 3, "");
                t.this.nd();
            }
        }, str));
        aVar.a(new bb(new bb.a() { // from class: com.kwad.components.ad.splashscreen.presenter.t.5
            @Override // com.kwad.components.core.webview.jshandler.bb.a
            public final void cN() {
                t.this.cH();
            }
        }));
        aVar.a(new am(this.fc));
        aVar.b(new com.kwad.components.core.webview.jshandler.o(this.fc));
        aVar.b(new com.kwad.components.core.webview.jshandler.n(this.fc));
        az azVar = new az();
        this.Jf = azVar;
        aVar.a(azVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cH() {
        if (this.hm != null || this.Jd) {
            return;
        }
        float fDF = com.kwad.sdk.core.response.helper.b.dF(this.Hu.mAdTemplate);
        boolean zDZ = com.kwad.sdk.core.response.helper.b.dZ(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        boolean zEa = com.kwad.sdk.core.response.helper.b.ea(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        com.kwad.sdk.core.g.d dVar = new com.kwad.sdk.core.g.d(zDZ, fDF);
        this.hm = dVar;
        dVar.bG(zEa);
        this.hm.a(new com.kwad.sdk.core.g.b() { // from class: com.kwad.components.ad.splashscreen.presenter.t.6
            @Override // com.kwad.sdk.core.g.b
            public final void cf() {
            }

            @Override // com.kwad.sdk.core.g.b
            public final void a(double d) {
                boolean zPF = com.kwad.components.core.e.c.b.pF();
                if (!t.this.Hu.GH.Aq() || zPF) {
                    return;
                }
                t.this.f(d);
                if (t.this.ho == null) {
                    t tVar = t.this;
                    tVar.ho = tVar.F(tVar.getContext());
                }
                by.a(t.this.getContext(), t.this.ho);
                t.this.hm.cb(t.this.getContext());
            }
        });
        this.hm.ca(getContext());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Vibrator F(Context context) {
        if (context != null) {
            return (Vibrator) getContext().getSystemService("vibrator");
        }
        return null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void f(final double d) {
        if (this.Hu != null) {
            this.Hu.a(1, getContext(), 157, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.t.7
                @Override // com.kwad.components.ad.splashscreen.h.a
                public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                    bVar.j(d);
                }
            });
        }
    }

    public final void nc() {
        if (this.Jc) {
            return;
        }
        this.Jc = true;
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        c0502a.aLk = com.kwad.components.ad.splashscreen.local.b.t(this.mAdInfo);
        com.kwad.sdk.core.adlog.c.d(this.Hu.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dU(123).b(c0502a));
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(123);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void nd() {
        this.Jd = true;
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView != null) {
            ksAdWebView.setVisibility(8);
        }
        ViewGroup viewGroup = this.Jh;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
        final Presenter presenterZ = z(this.mAdInfo);
        if (presenterZ != null) {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.t.8
                @Override // java.lang.Runnable
                public final void run() {
                    t.this.a(presenterZ, true);
                }
            });
        } else {
            ne();
        }
    }

    private Presenter z(AdInfo adInfo) {
        if (com.kwad.sdk.core.response.helper.a.dv(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            if (com.kwad.sdk.core.response.helper.b.ei(adInfo)) {
                return new m();
            }
            return null;
        }
        if (com.kwad.sdk.core.response.helper.b.eg(this.mAdInfo)) {
            return new o();
        }
        if (com.kwad.sdk.core.response.helper.b.ei(this.mAdInfo)) {
            return new m();
        }
        if (com.kwad.sdk.core.response.helper.b.el(this.mAdInfo)) {
            return new r();
        }
        if (com.kwad.sdk.utils.as.isOrientationPortrait() && com.kwad.sdk.core.response.helper.b.em(this.mAdInfo)) {
            return new l();
        }
        if (com.kwad.sdk.utils.as.isOrientationPortrait() && com.kwad.sdk.core.response.helper.b.en(this.mAdInfo)) {
            return new n();
        }
        if (com.kwad.sdk.utils.as.isOrientationPortrait() && com.kwad.sdk.core.response.helper.b.eo(this.mAdInfo)) {
            return new q();
        }
        if (com.kwad.sdk.utils.as.isOrientationPortrait() && com.kwad.sdk.core.response.helper.b.ep(this.mAdInfo)) {
            return new p();
        }
        return null;
    }

    private void ne() {
        nc();
        com.kwad.components.ad.splashscreen.e.b bVar = new com.kwad.components.ad.splashscreen.e.b((ViewGroup) getRootView(), (ViewStub) findViewById(R.id.ksad_splash_actionbar_native_stub), com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate), this.Hu.mApkDownloadHelper);
        this.Jb = bVar;
        bVar.av(this.mAdTemplate);
        this.Jb.a(this);
        this.Jb.nd();
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.ca(getContext());
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
    }

    private z nf() {
        return new z(this.fc, this.Hu.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.t.9
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (com.kwad.sdk.c.a.a.Ii()) {
                    return;
                }
                if (aVar.PV() || com.kwad.components.ad.splashscreen.h.o(t.this.mAdInfo)) {
                    t.this.a(false, aVar.arc, aVar.ne, aVar.ard.QQ);
                }
            }
        });
    }

    private ac ng() {
        return new ac(this.fc, this.Hu.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.t.10
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar.ara || !com.kwad.components.ad.splashscreen.h.o(t.this.mAdInfo)) {
                    t.this.a(false, aVar.ara ? 1 : 3, aVar.ne, "");
                }
            }
        }, (byte) 0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:24:0x0051  */
    public void a(boolean z, int i, int i2, String str) {
        this.Hu.ab();
        boolean z2 = !TextUtils.isEmpty(str);
        int i3 = 0;
        boolean z3 = i == 1;
        if (z2) {
            i3 = i2;
        } else {
            JSONObject jSONObject = new JSONObject();
            try {
                if (this.Hu != null) {
                    if (this.Hu.GF != null) {
                        jSONObject.put(MediationConstant.EXTRA_DURATION, this.Hu.GF.getCurrentPosition());
                    }
                    if (z) {
                        i3 = MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT;
                    } else if (z3) {
                        i3 = MediaPlayer.MEDIA_PLAYER_OPTION_MEDIA_CODEC_SIDE_DATA;
                    }
                    try {
                        com.kwad.sdk.core.adlog.c.a(this.Hu.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dS(i3), jSONObject);
                    } catch (JSONException e) {
                        e = e;
                        com.kwad.sdk.core.d.c.printStackTrace(e);
                    }
                } else {
                    i3 = i2;
                }
            } catch (JSONException e2) {
                e = e2;
                i3 = i2;
            }
        }
        com.kwad.components.core.e.d.a.C0428a c0428aAD = new com.kwad.components.core.e.d.a.C0428a(this.Hu.mRootContainer.getContext()).aF(this.Hu.mAdTemplate).b(this.Hu.mApkDownloadHelper).as(z3).aD(i);
        if (!z2) {
            i2 = i3;
        }
        com.kwad.components.core.e.d.a.a(c0428aAD.aC(i2).ao(str).aB(1).au(z2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.splashscreen.presenter.t.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
            }
        }));
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.ad.splashscreen.e.b bVar = this.Jb;
        if (bVar != null) {
            bVar.onUnbind();
        }
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
        az azVar = this.Jf;
        if (azVar != null) {
            azVar.yL();
            this.Jf.yM();
        }
        if (this.Hu != null && this.Hu.GH != null) {
            this.Hu.GH.b(this);
        }
        bh();
    }

    @Override // com.kwad.components.ad.splashscreen.e
    public final void i(boolean z, boolean z2) {
        com.kwad.sdk.core.d.c.d("SplashWebViewPresenter", "isClick: " + z + ", isActionBar: " + z2);
        a(!z, z2 ? 1 : 3, MediaPlayer.MEDIA_PLAYER_OPTION_MEDIA_CODEC_SIDE_DATA, null);
    }
}
