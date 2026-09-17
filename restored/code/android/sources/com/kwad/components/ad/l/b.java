package com.kwad.components.ad.l;

import android.text.TextUtils;
import android.view.View;
import android.widget.FrameLayout;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.webview.c;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.ak;
import com.kwad.components.core.webview.jshandler.ao;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bf;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.wrapper.m;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    private bf Dd;
    protected View NI;
    private String NK;
    private a NL;
    private InterfaceC0383b NM;
    protected KsAdWebView eZ;
    protected com.kwad.sdk.core.webview.b fc;
    protected az ff;
    private com.kwad.sdk.core.webview.d.a.a fg;
    private FrameLayout fp;
    private AdBaseFrameLayout gF;
    private com.kwad.components.core.webview.b jh;
    protected AdTemplate mAdTemplate;
    private JSONObject mReportExtData;
    private List<AdTemplate> NG = new ArrayList();
    private List<d> NH = new ArrayList();
    private int fe = -1;
    protected boolean NJ = false;
    private c ji = new c() { // from class: com.kwad.components.ad.l.b.1
        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.components.core.webview.a aVar, com.kwad.sdk.core.webview.b bVar) {
            b.this.fc = bVar;
            b.this.b(bVar);
            b.this.a(aVar);
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(WebCloseStatus webCloseStatus) {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.l.b.1.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (b.this.NL != null) {
                        b.this.NL.jV();
                    }
                }
            });
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(as.a aVar) {
            b.this.fe = aVar.status;
            com.kwad.sdk.core.d.c.i("PlayEndWebCard", b.this.getName() + "updatePageStatus mPageState: " + aVar + "，targetUrl: " + b.this.NK);
            if (aVar.isSuccess() && b.this.NM != null) {
                b.this.NM.je();
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(az azVar) {
            b.this.ff = azVar;
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            if (b.this.fg != null) {
                b.this.fg.a(aVar);
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void onReceivedHttpError(int i, String str, String str2) {
            b.this.NJ = false;
        }

        @Override // com.kwad.components.core.webview.c
        public final void onPageFinished() {
            b.this.NJ = true;
            b.this.gH();
        }
    };
    private ak.b fi = new ak.b() { // from class: com.kwad.components.ad.l.b.2
        @Override // com.kwad.components.core.webview.jshandler.ak.b
        public final void a(ak.a aVar) {
            b.this.op();
        }
    };

    public interface a {
        void jV();
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.l.b$b, reason: collision with other inner class name */
    public interface InterfaceC0383b {
        void je();
    }

    protected boolean gD() {
        return true;
    }

    protected void gF() {
    }

    protected void gG() {
    }

    protected void gH() {
    }

    protected String getName() {
        return "PlayEndWebCard";
    }

    public b() {
    }

    public b(JSONObject jSONObject, String str) {
        this.mReportExtData = jSONObject;
        this.NK = str;
    }

    public final void a(com.kwad.sdk.core.webview.d.a.a aVar) {
        this.fg = aVar;
    }

    public final void a(FrameLayout frameLayout, AdBaseFrameLayout adBaseFrameLayout, AdTemplate adTemplate, d dVar) {
        a(frameLayout, adBaseFrameLayout, adTemplate, dVar, 0);
    }

    @Deprecated
    public void a(FrameLayout frameLayout, AdBaseFrameLayout adBaseFrameLayout, AdTemplate adTemplate, d dVar, int i) {
        this.NH.add(dVar);
        this.gF = adBaseFrameLayout;
        this.fp = frameLayout;
        this.mAdTemplate = adTemplate;
        gC();
    }

    public final void a(FrameLayout frameLayout, AdBaseFrameLayout adBaseFrameLayout, List<AdTemplate> list, List<d> list2) {
        this.NH = list2;
        this.gF = adBaseFrameLayout;
        this.fp = frameLayout;
        if (list != null && list.size() > 0) {
            this.NG = list;
            this.mAdTemplate = list.get(0);
        }
        gC();
    }

    private static int getLayoutId() {
        return R.layout.ksad_ad_web_card_layout;
    }

    protected void gC() {
        this.fp.removeAllViews();
        this.fp.setVisibility(4);
        this.NI = m.inflate(this.fp.getContext(), getLayoutId(), this.fp);
        KsAdWebView ksAdWebView = (KsAdWebView) this.fp.findViewById(R.id.ksad_web_card_webView);
        this.eZ = ksAdWebView;
        if (ksAdWebView != null) {
            boolean z = false;
            ksAdWebView.setBackgroundColor(0);
            this.eZ.getBackground().setAlpha(0);
            this.jh = new com.kwad.components.core.webview.b();
            com.kwad.components.core.webview.b.a aVarF = new com.kwad.components.core.webview.b.a().be(this.mAdTemplate).bs(K(this.mAdTemplate)).f(this.eZ).f(this.mReportExtData).m(this.gF).f(this.NH.get(0));
            if (this.NH.size() > 1 && this.NG.size() > 1) {
                z = true;
            }
            this.jh.a(aVarF.bj(z).a(this.ji));
            this.eZ.loadUrl(K(this.mAdTemplate));
            gF();
        }
    }

    public final void aj(boolean z) {
        this.Dd.aj(true);
    }

    protected void b(com.kwad.sdk.core.webview.b bVar) {
        bVar.setAdTemplate(this.mAdTemplate);
    }

    public final void a(InterfaceC0383b interfaceC0383b) {
        this.NM = interfaceC0383b;
        this.fp.setVisibility(4);
        this.fe = -1;
        String strK = K(this.mAdTemplate);
        com.kwad.sdk.core.d.c.d("PlayEndWebCard", "startPreloadWebView url : " + strK);
        if (TextUtils.isEmpty(strK) || this.eZ == null) {
            return;
        }
        gG();
        this.eZ.loadUrl(strK);
    }

    public final long getLoadTime() {
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView != null) {
            return ksAdWebView.getLoadTime();
        }
        return -1L;
    }

    public final void a(a aVar) {
        this.NL = aVar;
    }

    protected String K(AdTemplate adTemplate) {
        String str = this.NK;
        return str == null ? com.kwad.sdk.core.response.helper.b.de(this.mAdTemplate) : str;
    }

    protected void a(com.kwad.components.core.webview.a aVar) {
        if (this.NH.size() > 1 && this.NG.size() > 1) {
            aVar.a(new ac(this.fc, this.NH.get(0), this.fg, (byte) 0));
            aVar.a(new z(this.fc, this.NH, this.fg));
            aVar.a(new ao(this.NG, this.NH));
        }
        bf bfVar = new bf();
        this.Dd = bfVar;
        aVar.a(bfVar);
        aVar.a(new ak(this.fi));
    }

    protected boolean cJ() {
        return this.fe == 1;
    }

    public final boolean aY() {
        if (cJ()) {
            az azVar = this.ff;
            if (azVar != null) {
                azVar.yJ();
            }
            FrameLayout frameLayout = this.fp;
            if (frameLayout != null) {
                frameLayout.setVisibility(0);
            }
            if (this.ff == null || !gD()) {
                return true;
            }
            this.ff.yK();
            return true;
        }
        FrameLayout frameLayout2 = this.fp;
        if (frameLayout2 != null) {
            frameLayout2.setVisibility(4);
        }
        bo();
        return false;
    }

    public final void op() {
        if (cb.a(this.eZ, 50, false)) {
            az azVar = this.ff;
            if (azVar != null) {
                azVar.yL();
            }
            this.fp.setVisibility(4);
            az azVar2 = this.ff;
            if (azVar2 != null) {
                azVar2.yM();
            }
        }
    }

    private void bo() {
        String str;
        int i = this.fe;
        if (i == -1) {
            str = "timeout";
        } else {
            str = i != 1 ? "h5error" : "others";
        }
        com.kwad.sdk.core.d.c.w("PlayEndWebCard", "show webCard fail, reason: ".concat(str));
    }

    public final void release() {
        this.NM = null;
    }

    public final void ob() {
        com.kwad.components.core.webview.b bVar = this.jh;
        if (bVar != null) {
            bVar.kT();
        }
    }
}
