package com.kwad.components.core.webview;

import android.net.Uri;
import android.text.TextUtils;
import android.view.ViewGroup;
import android.webkit.WebView;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.webview.jsPublicBridge.KSAdChinaMobileJSBridge;
import com.kwad.components.core.webview.jsPublicBridge.KSAdPublicJSBridge;
import com.kwad.components.core.webview.jshandler.aa;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.aj;
import com.kwad.components.core.webview.jshandler.al;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.ar;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.au;
import com.kwad.components.core.webview.jshandler.aw;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.bh;
import com.kwad.components.core.webview.jshandler.i;
import com.kwad.components.core.webview.jshandler.m;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.components.core.webview.jshandler.q;
import com.kwad.components.core.webview.jshandler.r;
import com.kwad.components.core.webview.jshandler.u;
import com.kwad.components.core.webview.jshandler.v;
import com.kwad.components.core.webview.jshandler.w;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.b.f;
import com.kwad.components.core.webview.tachikoma.b.j;
import com.kwad.components.core.webview.tachikoma.b.k;
import com.kwad.components.core.webview.tachikoma.b.l;
import com.kwad.components.core.webview.tachikoma.b.s;
import com.kwad.components.core.webview.tachikoma.c.g;
import com.kwad.components.core.webview.tachikoma.c.t;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.download.d;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.ae;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private KsAdWebView Nu;
    private KsAdWebView.c aef;
    private ViewGroup aoB;
    private com.kwad.components.core.webview.a.a aoC;
    private aw aoD;
    private d aoE;
    private boolean aoF;
    private com.kwad.components.core.webview.jshandler.a.c aoG;
    private KSAdPublicJSBridge aoH;
    private KSAdChinaMobileJSBridge aoI;
    private boolean aoJ = false;
    private as.b aoK = new as.b() { // from class: com.kwad.components.core.webview.b.13
        @Override // com.kwad.components.core.webview.jshandler.as.b
        public final void a(as.a aVar) {
            if (b.this.ji != null) {
                b.this.ji.a(aVar);
            }
        }
    };
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private c ji;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private String mPageUrl;

    private boolean yn() {
        return false;
    }

    public final void bi(boolean z) {
        this.aoJ = true;
    }

    public final void a(a aVar) {
        this.mPageUrl = aVar.uf();
        this.mAdTemplate = aVar.getAdTemplate();
        this.aoB = aVar.yt();
        this.Nu = aVar.yu();
        this.ji = aVar.yv();
        this.mApkDownloadHelper = aVar.it();
        this.aoF = aVar.yw();
        this.aef = aVar.uF();
        this.aoG = aVar.yx();
        fy();
        a(this.ji, this.Nu);
        be();
        if (e.Lj().contains(br(this.mPageUrl)) && this.aoJ) {
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.R(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            e(this.Nu);
        } else if (com.kwad.sdk.core.response.helper.b.fk(this.mPageUrl)) {
            b(this.Nu);
        }
        c(this.Nu);
        d(this.Nu);
    }

    private static String br(String str) {
        if (str != null && !str.trim().isEmpty()) {
            try {
                return Uri.parse(str).getHost();
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        return "";
    }

    private void fy() {
        this.Nu.setClientConfig(this.Nu.getClientConfig().fm(this.mAdTemplate).eK(yr()).b(yq()).a(yp()).c(this.aef));
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.mAdTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.adg = this.Nu;
        this.fc.adZ = this.aoB;
    }

    private void b(KsAdWebView ksAdWebView) {
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(ksAdWebView);
        this.fb = aVar;
        b(aVar, this.fc);
        c cVar = this.ji;
        if (cVar != null) {
            cVar.a(this.fb, this.fc);
        }
        ksAdWebView.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void c(KsAdWebView ksAdWebView) {
        KSAdPublicJSBridge kSAdPublicJSBridge = new KSAdPublicJSBridge(ksAdWebView);
        this.aoH = kSAdPublicJSBridge;
        ksAdWebView.addJavascriptInterface(kSAdPublicJSBridge, "KwaiAdPublic");
    }

    private void d(KsAdWebView ksAdWebView) {
        KSAdChinaMobileJSBridge kSAdChinaMobileJSBridge = new KSAdChinaMobileJSBridge(ksAdWebView);
        this.aoI = kSAdChinaMobileJSBridge;
        ksAdWebView.addJavascriptInterface(kSAdChinaMobileJSBridge, "KSAdChinaMobile");
    }

    private void e(KsAdWebView ksAdWebView) {
        bh();
        com.kwad.components.core.webview.a.a aVar = new com.kwad.components.core.webview.a.a(ksAdWebView, this.fc);
        this.aoC = aVar;
        ksAdWebView.addJavascriptInterface(aVar, "KwaiAdForThird");
    }

    private void b(com.kwad.components.core.webview.a aVar, com.kwad.sdk.core.webview.b bVar) {
        az azVar = new az();
        aVar.a(azVar);
        a(azVar);
        aVar.a(new v());
        aVar.a(new com.kwad.components.core.webview.jshandler.d());
        aVar.a(new w());
        aVar.a(new q());
        aVar.a(new r());
        am amVar = new am(bVar);
        aVar.b(new o(bVar));
        aVar.b(new n(bVar));
        amVar.a(yo());
        aVar.a(amVar);
        aVar.a(new af(bVar));
        aVar.a(new f());
        if (this.mApkDownloadHelper == null) {
            this.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        }
        if (!this.aoF) {
            aVar.a(new ac(this.fc, this.mApkDownloadHelper, getClickListener(), ym(), false, true));
            aVar.a(new z(this.fc, this.mApkDownloadHelper, getClickListener(), ym(), 0, yn(), true));
        }
        aVar.a(new bc(this.fc, this.mApkDownloadHelper));
        aVar.a(new au(this.fc));
        aVar.a(new ar(this.fc.adg.getContext(), this.mAdTemplate));
        aVar.a(new bh(new bh.a() { // from class: com.kwad.components.core.webview.b.1
            @Override // com.kwad.components.core.webview.jshandler.bh.a
            public final void ys() {
                if (com.kwad.sdk.core.response.helper.b.dL(b.this.mAdTemplate)) {
                    com.kwad.components.core.e.c.b.a(b.this.fc.adg.getContext(), new com.kwad.components.core.e.c.b.a().aD(b.this.mAdTemplate).am(com.kwad.sdk.core.response.helper.b.dK(b.this.mAdTemplate)).pI());
                }
            }
        }));
        aVar.a(new aj(this.fc));
        aVar.a(new as(this.aoK, this.mPageUrl));
        aw awVar = new aw();
        this.aoD = awVar;
        aVar.a(awVar);
        aVar.a(new aa(new com.kwad.sdk.core.webview.d.a.b() { // from class: com.kwad.components.core.webview.b.6
            @Override // com.kwad.sdk.core.webview.d.a.b
            public final void b(WebCloseStatus webCloseStatus) {
                if (b.this.ji != null) {
                    b.this.ji.a(webCloseStatus);
                }
            }
        }));
        s sVar = new s();
        sVar.a(new s.a() { // from class: com.kwad.components.core.webview.b.7
            @Override // com.kwad.components.core.webview.tachikoma.b.s.a
            public final void a(t tVar) {
                if (TextUtils.isEmpty(tVar.message)) {
                    return;
                }
                ae.d(b.this.fc.adg.getContext(), tVar.message, 0L);
            }
        });
        aVar.a(sVar);
        aVar.a(new k());
        aVar.a(new ai(bVar));
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            final l lVar = new l();
            aVar.a(lVar);
            this.aoE = new d(this.mAdTemplate) { // from class: com.kwad.components.core.webview.b.8
                @Override // com.kwad.sdk.core.download.d, com.kwad.sdk.core.download.c
                public final void b(String str, String str2, com.kwad.sdk.core.download.e eVar) {
                    super.b(str, str2, eVar);
                    com.kwad.components.core.webview.tachikoma.c.b bVar2 = new com.kwad.components.core.webview.tachikoma.c.b();
                    bVar2.auk = 1;
                    lVar.a(bVar2);
                }
            };
            com.kwad.sdk.core.download.b.LK().a(this.aoE, this.mAdTemplate);
        }
        aVar.a(new com.kwad.components.core.webview.tachikoma.b.d() { // from class: com.kwad.components.core.webview.b.9
            @Override // com.kwad.components.core.webview.tachikoma.b.d
            public final void a(g gVar) {
                com.kwad.components.core.p.a.vX().a(gVar.actionType, b.this.mAdTemplate, gVar.QQ);
            }
        });
        aVar.a(new j() { // from class: com.kwad.components.core.webview.b.10
            @Override // com.kwad.components.core.webview.tachikoma.b.j
            public final void a(com.kwad.components.core.webview.tachikoma.c.o oVar) {
                super.a(oVar);
                AdWebViewActivityProxy.launch(b.this.fc.adg.getContext(), new AdWebViewActivityProxy.a.C0449a().aW(oVar.title).aX(oVar.url).aQ(true).aU(b.this.mAdTemplate).um());
            }
        });
        aVar.a(new com.kwad.components.core.webview.jshandler.f());
        aVar.a(new i());
        aVar.a(new com.kwad.components.core.webview.jshandler.l());
        aVar.a(new com.kwad.components.core.webview.jshandler.e());
        com.kwad.components.core.webview.jshandler.ae aeVar = new com.kwad.components.core.webview.jshandler.ae(this.fc);
        aeVar.a(new com.kwad.components.core.webview.jshandler.ae.c() { // from class: com.kwad.components.core.webview.b.11
            @Override // com.kwad.components.core.webview.jshandler.ae.c
            public final void c(com.kwad.components.core.webview.jshandler.ae.a aVar2) {
                if (b.this.ji != null) {
                    b.this.ji.b(aVar2);
                }
            }
        });
        aVar.a(aeVar);
        aVar.a(new m(this.fc.adg.getContext(), this.mAdTemplate));
        aVar.a(new al(this.fc, new al.b() { // from class: com.kwad.components.core.webview.b.12
            @Override // com.kwad.components.core.webview.jshandler.al.b
            public final void a(al.a aVar2) {
                if (b.this.ji != null) {
                    b.this.ji.a(aVar2);
                }
            }
        }));
        aVar.a(new com.kwad.components.core.webview.jshandler.k());
        aVar.a(new u());
        aVar.a(new com.kwad.components.core.webview.jshandler.t());
        aVar.a(new com.kwad.components.core.webview.jshandler.s());
        aVar.a(new com.kwad.components.core.webview.jshandler.a.f(this.fc.getContext()));
        aVar.a(new com.kwad.components.core.webview.jshandler.a.d(this.fc.getContext()));
        aVar.a(new com.kwad.components.core.webview.jshandler.a.b(this.aoG));
        aVar.a(new com.kwad.components.core.webview.jshandler.a.a());
        aVar.a(new com.kwad.components.core.webview.jshandler.a.e(this.fc.getContext()));
    }

    private boolean ym() {
        c cVar = this.ji;
        if (cVar == null) {
            return false;
        }
        return cVar.uL();
    }

    private void a(az azVar) {
        c cVar = this.ji;
        if (cVar == null) {
            return;
        }
        cVar.a(azVar);
    }

    private com.kwad.sdk.core.webview.d.a.a getClickListener() {
        return new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.core.webview.b.2
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (b.this.ji != null) {
                    b.this.ji.a(aVar);
                }
            }
        };
    }

    private am.a yo() {
        return new am.a() { // from class: com.kwad.components.core.webview.b.3
            @Override // com.kwad.components.core.webview.jshandler.am.a
            public final void onAdShow() {
                if (b.this.ji != null) {
                    b.this.ji.onAdShow();
                }
            }
        };
    }

    private KsAdWebView.b yp() {
        return new KsAdWebView.b() { // from class: com.kwad.components.core.webview.b.4
            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onSuccess() {
                if (b.this.aoD != null) {
                    b.this.aoD.onSuccess();
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.b
            public final void onFailed() {
                if (b.this.aoD != null) {
                    b.this.aoD.onFailed();
                }
            }
        };
    }

    private KsAdWebView.e yq() {
        return new KsAdWebView.e() { // from class: com.kwad.components.core.webview.b.5
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                if (b.this.ji != null) {
                    b.this.ji.onReceivedHttpError(i, str, str2);
                }
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                if (b.this.ji != null) {
                    b.this.ji.onPageFinished();
                }
            }
        };
    }

    private int yr() {
        return com.kwad.sdk.core.response.helper.a.V(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)) ? 5 : 1;
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
        com.kwad.components.core.webview.a.a aVar2 = this.aoC;
        if (aVar2 != null) {
            aVar2.destroy();
            this.aoC = null;
        }
        KSAdPublicJSBridge kSAdPublicJSBridge = this.aoH;
        if (kSAdPublicJSBridge != null) {
            kSAdPublicJSBridge.destroy();
            this.aoH = null;
        }
        if (this.aoI != null) {
            this.aoI = null;
        }
    }

    public final void kT() {
        bh();
        if (this.aoE != null) {
            com.kwad.sdk.core.download.b.LK().a(this.aoE);
        }
        this.aoG = null;
    }

    private static void a(c cVar, WebView webView) {
        if (cVar == null || !cVar.uK()) {
            return;
        }
        webView.getSettings().setAllowFileAccess(true);
    }

    public static class a {
        private KsAdWebView Nu;
        private KsAdWebView.c aef;
        private ViewGroup aoB;
        private boolean aoF;
        private com.kwad.components.core.webview.jshandler.a.c aoG;
        private c ji;
        private AdTemplate mAdTemplate;
        private com.kwad.components.core.e.d.d mApkDownloadHelper;
        private String mPageUrl;
        private JSONObject mReportExtData;

        public final String uf() {
            return this.mPageUrl;
        }

        public final a bs(String str) {
            this.mPageUrl = str;
            return this;
        }

        public final AdTemplate getAdTemplate() {
            return this.mAdTemplate;
        }

        public final a be(AdTemplate adTemplate) {
            this.mAdTemplate = adTemplate;
            return this;
        }

        public final ViewGroup yt() {
            return this.aoB;
        }

        public final a m(ViewGroup viewGroup) {
            this.aoB = viewGroup;
            return this;
        }

        public final KsAdWebView yu() {
            return this.Nu;
        }

        public final a f(KsAdWebView ksAdWebView) {
            this.Nu = ksAdWebView;
            return this;
        }

        public final c yv() {
            return this.ji;
        }

        public final a a(c cVar) {
            this.ji = cVar;
            return this;
        }

        public final a f(com.kwad.components.core.e.d.d dVar) {
            this.mApkDownloadHelper = dVar;
            return this;
        }

        public final com.kwad.components.core.e.d.d it() {
            return this.mApkDownloadHelper;
        }

        public final KsAdWebView.c uF() {
            return this.aef;
        }

        public final a b(KsAdWebView.c cVar) {
            this.aef = cVar;
            return this;
        }

        public final a f(JSONObject jSONObject) {
            this.mReportExtData = jSONObject;
            return this;
        }

        public final boolean yw() {
            return this.aoF;
        }

        public final a bj(boolean z) {
            this.aoF = z;
            return this;
        }

        public final com.kwad.components.core.webview.jshandler.a.c yx() {
            return this.aoG;
        }

        public final a a(com.kwad.components.core.webview.jshandler.a.c cVar) {
            this.aoG = cVar;
            return this;
        }
    }
}
