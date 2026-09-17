package com.kwad.components.core.page.d.a;

import android.app.Activity;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.webkit.WebView;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.av;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bg;
import com.kwad.components.core.webview.jshandler.bi;
import com.kwad.components.core.webview.tachikoma.c.l;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ao;
import com.kwad.sdk.utils.by;
import java.net.URI;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends a implements com.kwad.components.core.webview.jshandler.a.c {
    private static final Handler jc = new Handler(Looper.getMainLooper());
    public AdWebViewActivityProxy.a adE;
    private az aeG;
    private av aeH;
    private bi aeI;
    private String aeJ;
    private Runnable aeK;
    private com.kwad.components.core.webview.b jh;
    public AdTemplate mAdTemplate;
    private KsAdWebView mAdWebView;
    private boolean adN = false;
    private boolean aeF = false;
    private boolean aeL = false;
    private final com.kwad.sdk.core.c.c Bi = new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.core.page.d.a.g.3
        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityResumed */
        public final void d(Activity activity) {
            super.d(activity);
            g.this.show();
        }

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityPaused */
        public final void c(Activity activity) {
            super.c(activity);
            g.this.hide();
        }

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityDestroyed */
        public final void b(Activity activity) {
            super.b(activity);
            if (g.this.mAdWebView == null || g.this.getActivity() == null || !g.this.getActivity().equals(activity)) {
                return;
            }
            g.this.mAdWebView.onActivityDestroy();
            g.a(g.this, (KsAdWebView) null);
        }
    };
    private com.kwad.components.core.webview.jshandler.b aeh = new com.kwad.components.core.webview.jshandler.b() { // from class: com.kwad.components.core.page.d.a.g.4
        @Override // com.kwad.components.core.webview.jshandler.b
        public final void uJ() {
            if (g.this.aeH != null) {
                g.this.aeH.yI();
            }
        }
    };
    private com.kwad.components.core.webview.c ji = new com.kwad.components.core.webview.c() { // from class: com.kwad.components.core.page.d.a.g.5
        @Override // com.kwad.components.core.webview.c
        public final boolean uK() {
            return true;
        }

        @Override // com.kwad.components.core.webview.c
        public final boolean uL() {
            return true;
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.components.core.webview.a aVar, com.kwad.sdk.core.webview.b bVar) {
            aVar.a(new bg(new bg.b() { // from class: com.kwad.components.core.page.d.a.g.5.1
                @Override // com.kwad.components.core.webview.jshandler.bg.b
                public final void a(bg.a aVar2) {
                    if (g.this.aec.aeg == null || aVar2 == null) {
                        return;
                    }
                    g.this.aec.aeg.bn(aVar2.visibility);
                }
            }));
            g.this.aeH = new av(new av.b() { // from class: com.kwad.components.core.page.d.a.g.5.2
                @Override // com.kwad.components.core.webview.jshandler.av.b
                public final void uM() {
                    g.this.aec.a(g.this.aeh);
                }
            });
            g.this.aeI = new bi(new bi.a() { // from class: com.kwad.components.core.page.d.a.g.5.3
                @Override // com.kwad.components.core.webview.jshandler.bi.a
                public final void uN() {
                    g.this.aec.ux();
                }
            });
            aVar.a(g.this.aeH);
            aVar.a(g.this.aeI);
            aVar.a(new com.kwad.components.core.webview.tachikoma.b.b(bVar, g.this.aec.mAdTemplate));
            l lVar = new l();
            lVar.aut = g.this.aec.mAutoShow ? 1 : 0;
            aVar.a(new com.kwad.components.core.webview.tachikoma.b.g(lVar));
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(az azVar) {
            g.this.aeG = azVar;
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(as.a aVar) {
            g.this.aec.aek = aVar.isSuccess();
        }

        @Override // com.kwad.components.core.webview.c
        public final void onReceivedHttpError(int i, String str, String str2) {
            String string;
            g.this.adN = false;
            try {
                URI uri = new URI(g.this.adE.uf());
                if (TextUtils.isEmpty(uri.getPath())) {
                    string = new URI(g.this.adE.uf() + "/").normalize().toString();
                } else {
                    string = uri.normalize().toString();
                }
                if (!TextUtils.equals(str2, g.this.adE.uf()) && !TextUtils.equals(str2, string)) {
                    com.kwad.sdk.commercial.f.a.b(g.this.mAdTemplate, g.this.adE.ug(), g.this.adE.uf(), i, str);
                    return;
                }
                com.kwad.sdk.commercial.f.a.a(g.this.mAdTemplate, g.this.adE.ug(), g.this.adE.uf(), i, str);
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void onPageFinished() {
            g.this.adN = true;
            if (!g.this.aeF) {
                g.b(g.this, true);
                com.kwad.sdk.commercial.f.a.n(g.this.mAdTemplate, g.this.adE.ug(), g.this.adE.uf());
            }
            if (g.this.aec.uy()) {
                g.this.show();
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(WebCloseStatus webCloseStatus) {
            if (g.this.aec.mWebCardCloseListener != null) {
                g.this.aec.mWebCardCloseListener.b(webCloseStatus);
            }
        }
    };

    static /* synthetic */ KsAdWebView a(g gVar, KsAdWebView ksAdWebView) {
        gVar.mAdWebView = null;
        return null;
    }

    static /* synthetic */ boolean b(g gVar, boolean z) {
        gVar.aeF = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.mAdWebView = (KsAdWebView) findViewById(R.id.ksad_video_webview);
    }

    @Override // com.kwad.components.core.page.d.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.adE = this.aec.adE;
        this.mAdTemplate = this.aec.mAdTemplate;
        fy();
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(this.Bi);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.jh.kT();
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.b(this.Bi);
    }

    private void fy() {
        com.kwad.components.core.webview.b bVar = new com.kwad.components.core.webview.b();
        this.jh = bVar;
        bVar.bi(true);
        this.jh.a(new com.kwad.components.core.webview.b.a().be(this.aec.mAdTemplate).bs(this.aec.mPageUrl).f(this.mAdWebView).m(this.aec.mRootContainer).a(this.ji).b(this.aec.aef).a(this));
        uH();
        com.kwad.sdk.commercial.f.a.m(this.mAdTemplate, this.adE.ug(), this.adE.uf());
        if (this.mAdWebView.getClientConfig() != null) {
            this.mAdWebView.getClientConfig().a(new KsAdWebView.d() { // from class: com.kwad.components.core.page.d.a.g.1
                @Override // com.kwad.sdk.core.webview.KsAdWebView.d
                public final boolean shouldOverrideUrlLoading(WebView webView, String str) {
                    com.kwad.sdk.core.d.c.w("LandPageWebViewLoadPresenter", "shouldOverrideUrlLoading url=" + str);
                    com.kwad.sdk.core.webview.b.c.b.ag(g.this.mAdWebView.getUniqueId(), "shouldOverrideUrlLoading");
                    AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(g.this.mAdTemplate);
                    g.this.aeJ = str;
                    if (!com.kwad.sdk.core.response.helper.a.bq(adInfoEM) || !ao.dx(g.this.aec.mContext) || !ao.hO(str)) {
                        return false;
                    }
                    final com.kwad.sdk.core.webview.a.c.a clientConfig = g.this.mAdWebView.getClientConfig();
                    final com.kwad.components.core.urlReplace.c cVar = new com.kwad.components.core.urlReplace.c();
                    final Object obj = new Object();
                    g.this.aeK = new Runnable() { // from class: com.kwad.components.core.page.d.a.g.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            synchronized (obj) {
                                com.kwad.components.core.urlReplace.c cVar2 = cVar;
                                if (cVar2 != null) {
                                    cVar2.wN();
                                }
                                com.kwad.sdk.core.webview.a.c.a aVar = clientConfig;
                                if (aVar != null && aVar.PN() && clientConfig.PH()) {
                                    if (g.this.a(clientConfig, g.this.aeJ) == 1) {
                                        com.kwad.sdk.core.adlog.c.h(g.this.mAdTemplate, false);
                                    } else {
                                        com.kwad.sdk.core.adlog.c.i(g.this.mAdTemplate, false);
                                    }
                                } else {
                                    com.kwad.sdk.core.d.c.i("LandPageWebViewLoadPresenter", "deeplink unable");
                                }
                            }
                        }
                    };
                    g.jc.postDelayed(g.this.aeK, com.kwad.sdk.core.response.helper.a.br(adInfoEM));
                    cVar.a(str, new com.kwad.components.core.urlReplace.a() { // from class: com.kwad.components.core.page.d.a.g.1.2
                        @Override // com.kwad.components.core.urlReplace.a
                        public final void onSuccess(String str2) {
                            synchronized (obj) {
                                g.this.aeJ = str2;
                                if (g.this.aeK != null) {
                                    g.jc.removeCallbacks(g.this.aeK);
                                }
                                com.kwad.sdk.core.webview.a.c.a aVar = clientConfig;
                                if (aVar != null && aVar.PN() && clientConfig.PH()) {
                                    if (g.this.a(clientConfig, g.this.aeJ) == 1) {
                                        com.kwad.sdk.core.adlog.c.h(g.this.mAdTemplate, true);
                                    } else {
                                        com.kwad.sdk.core.adlog.c.i(g.this.mAdTemplate, true);
                                    }
                                } else {
                                    com.kwad.sdk.core.d.c.i("LandPageWebViewLoadPresenter", "deeplink unable");
                                }
                            }
                        }
                    });
                    return true;
                }
            });
        }
        this.mAdWebView.loadUrl(this.aec.mPageUrl);
        this.mAdWebView.onActivityCreate();
    }

    public final int a(com.kwad.sdk.core.webview.a.c.a aVar, String str) {
        boolean zCr;
        int I;
        try {
            zCr = com.kwad.sdk.core.response.helper.a.cr(com.kwad.sdk.core.response.helper.e.eM(aVar.getAdTemplate()));
        } catch (Throwable unused) {
            zCr = false;
        }
        com.kwad.sdk.core.adlog.c.a aVar2 = new com.kwad.sdk.core.adlog.c.a();
        if (zCr) {
            if (aVar2.QR == null) {
                aVar2.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            aVar2.QR.aLr = true;
            I = com.kwad.sdk.core.download.a.b.a(aVar.getContext(), str, new com.kwad.sdk.core.download.a.b.a() { // from class: com.kwad.components.core.page.d.a.g.2
                @Override // com.kwad.sdk.core.download.a.b.a
                public final void aJ(int i) {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onError(Throwable th) {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onPreStart() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onStart() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onSuccess() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void qF() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final boolean qG() {
                    return true;
                }
            });
        } else {
            I = com.kwad.sdk.core.download.a.b.I(aVar.getContext(), str);
        }
        if (I == 1) {
            if (aVar.on() != null) {
                aVar.on().onSuccess();
            }
            com.kwad.sdk.core.adlog.c.c(aVar.getAdTemplate(), "", 2, aVar2);
            com.kwad.sdk.core.adlog.c.l(aVar.getAdTemplate(), zCr);
        } else {
            if (aVar.on() != null) {
                aVar.on().onFailed();
            }
            if (I == -1 && !this.aeL) {
                this.aeL = true;
                com.kwad.sdk.core.adlog.c.d(aVar.getAdTemplate(), "", 2, aVar2);
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 0);
            } else if (I == 0 && TextUtils.isEmpty(str)) {
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 3);
            } else if (I == 0 && aVar.getContext() == null) {
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 4);
            }
        }
        return I;
    }

    public final void show() {
        if (this.adN) {
            az azVar = this.aeG;
            if (azVar != null) {
                azVar.yJ();
            }
            try {
                if (this.aec.mAdWebView != null) {
                    this.aec.mAdWebView.setVisibility(0);
                }
            } catch (Exception e) {
                com.kwad.components.core.d.a.reportSdkCaughtException(e);
            }
            az azVar2 = this.aeG;
            if (azVar2 != null) {
                azVar2.yK();
            }
        }
    }

    public final void hide() {
        az azVar = this.aeG;
        if (azVar != null) {
            azVar.yL();
        }
        if (this.aec.mAdWebView != null) {
            this.aec.mAdWebView.setVisibility(8);
        }
        az azVar2 = this.aeG;
        if (azVar2 != null) {
            azVar2.yM();
        }
    }

    private void uH() {
        KsAdWebView ksAdWebView;
        this.mAdWebView.setClientConfig(this.mAdWebView.getClientConfig().bV(true).fm(this.aec.mAdTemplate).bR(false));
        if (com.kwad.sdk.core.response.helper.a.bR(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate)) > 0) {
            by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.core.page.d.a.g.6
                @Override // java.lang.Runnable
                public final void run() {
                    if (g.this.mAdWebView != null) {
                        g.this.mAdWebView.getClientConfig().bR(true);
                        g.this.mAdWebView.getClientConfig().bT(true);
                    }
                }
            }, com.kwad.sdk.core.response.helper.a.bR(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate)));
        } else if (com.kwad.sdk.core.response.helper.a.bR(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate)) == 0 && (ksAdWebView = this.mAdWebView) != null) {
            ksAdWebView.getClientConfig().bR(true);
        }
        this.mAdWebView.setOnTouchListener(new View.OnTouchListener() { // from class: com.kwad.components.core.page.d.a.g.7
            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                if (motionEvent.getAction() != 0) {
                    return false;
                }
                g.this.mAdWebView.getClientConfig().bR(true);
                g.this.mAdWebView.getClientConfig().bS(true);
                return false;
            }
        });
    }

    @Override // com.kwad.components.core.webview.jshandler.a.c
    public final void us() {
        Activity activity = getActivity();
        if (activity != null) {
            activity.finish();
        }
    }
}
