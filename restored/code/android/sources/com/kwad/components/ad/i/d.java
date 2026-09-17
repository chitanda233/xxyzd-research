package com.kwad.components.ad.i;

import android.R;
import android.app.Activity;
import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.g;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends KSFrameLayout implements j, com.kwad.sdk.core.j.c {
    public static String rA = "PUSH_VIEW_TAG";
    private az ff;
    private final com.kwad.components.core.widget.a.c fs;
    private i gg;
    private AdTemplate rB;
    private com.kwad.components.ad.b.a.b rC;
    private boolean rD;
    private ViewGroup rE;
    private boolean rF;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getRegisterViewKey() {
        return null;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_push_ad";
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final g getTouchCoordsView() {
        return this;
    }

    public d(Context context, AdTemplate adTemplate) {
        super(context);
        this.rD = false;
        setTag(rA);
        this.rB = adTemplate;
        this.fs = new com.kwad.components.core.widget.a.c(this, 100);
        this.gg = new i(-1L, getContext()) { // from class: com.kwad.components.ad.i.d.1
            {
                super(-1L, context);
            }

            @Override // com.kwad.components.core.webview.tachikoma.i
            public final void a(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, t tVar, ViewGroup viewGroup) {
                super.a(bVar, dVar, tVar, viewGroup);
                tVar.c(new z(bVar, dVar, this) { // from class: com.kwad.components.ad.i.d.1.1
                    @Override // com.kwad.components.core.webview.jshandler.z
                    public final void Y(int i) {
                        super.Y(i);
                        if (i == 3) {
                            d.this.a((WebCloseStatus) null);
                        }
                    }
                });
            }
        };
        this.gg.a((Activity) null, com.kwad.sdk.core.response.helper.c.ex(this.rB), this);
    }

    public final boolean c(com.kwad.components.ad.b.a.b bVar) {
        this.rC = bVar;
        if (!this.rD || !gn()) {
            return false;
        }
        gk();
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gj() {
        if (this.rF) {
            return;
        }
        this.rF = true;
        gm();
        destroy();
    }

    private void destroy() {
        this.gg.kT();
        ViewGroup viewGroup = this.rE;
        if (viewGroup != null) {
            viewGroup.removeView(this);
        }
        ViewParent parent = getParent();
        if (parent instanceof ViewGroup) {
            ((ViewGroup) parent).removeView(this);
        }
    }

    private void gk() {
        com.kwad.components.ad.b.a.b bVar = this.rC;
        if (bVar != null) {
            bVar.Y();
        }
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yJ();
            this.ff.yK();
        }
    }

    public final boolean gl() {
        return this.rD;
    }

    private void gm() {
        com.kwad.components.ad.b.a.b bVar = this.rC;
        if (bVar != null) {
            bVar.Z();
        }
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yL();
            this.ff.yM();
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        this.fs.a(this);
        this.fs.Am();
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        this.fs.release();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ep(this.rB);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        com.kwad.sdk.core.d.c.d("PushAdView", "onTkLoadFailed");
        this.rD = false;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        com.kwad.sdk.core.d.c.d("PushAdView", "onTkLoadSuccess");
        this.rD = true;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        com.kwad.sdk.core.d.c.d("PushAdView", "onAdClicked");
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        float screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
        aVar.width = (int) ((com.kwad.sdk.c.a.a.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((screenHeight / fBA) + 0.5f);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.ff = azVar;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        gj();
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.sdk.core.d.c.d("PushAdView", "onPageVisible: ");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yN();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        com.kwad.sdk.core.d.c.d("PushAdView", "onPageInvisible: ");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yO();
        }
    }

    private boolean gn() {
        try {
            com.kwad.sdk.core.c.b.Mh();
            final Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
            if (currentActivity != null && !currentActivity.isFinishing()) {
                View viewFindViewById = currentActivity.getWindow().getDecorView().findViewById(R.id.content);
                if (!(viewFindViewById instanceof ViewGroup)) {
                    return false;
                }
                this.rE = (ViewGroup) viewFindViewById;
                this.rE.addView(this, new ViewGroup.LayoutParams(-1, -1));
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.ad.i.d.2
                    @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
                    /* JADX INFO: renamed from: onActivityDestroyed */
                    public final void b(Activity activity) {
                        super.b(activity);
                        com.kwad.sdk.core.c.b.Mh();
                        com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
                        if (activity.equals(currentActivity)) {
                            d.this.gj();
                        }
                    }
                });
                return true;
            }
            return false;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
            return false;
        }
    }
}
