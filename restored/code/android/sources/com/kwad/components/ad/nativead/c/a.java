package com.kwad.components.ad.nativead.c;

import android.app.Activity;
import android.content.Context;
import android.view.ViewTreeObserver;
import android.widget.FrameLayout;
import com.kwad.components.ad.nativead.b;
import com.kwad.components.ad.nativead.g;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.ax;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.j.c;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends KSFrameLayout {
    private c fA;
    private com.kwad.components.core.widget.a.c fs;
    private i gg;
    private KSFrameLayout gh;
    private az iQ;
    private AdInfo mAdInfo;
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;
    private Context mContext;
    private b.c pd;
    private b.e pe;
    private boolean qA;
    private boolean qB;
    private boolean qC;
    private boolean qD;
    private com.kwad.components.ad.nativead.d.a qu;
    private ViewTreeObserver qv;
    private ViewTreeObserver.OnGlobalLayoutListener qw;
    private ae.d qx;
    private int qy;
    private int qz;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.qA = true;
        return true;
    }

    public a(Context context) {
        super(context);
        this.qy = 0;
        this.qz = 0;
        this.qA = false;
        B(context);
    }

    private void B(Context context) {
        this.mContext = context;
        m.inflate(context, R.layout.ksad_native_tk_card_layout, this);
        this.gh = (KSFrameLayout) findViewById(R.id.ksad_native_tk_container);
        int iA = e.a(com.kwad.sdk.core.config.c.aPy);
        this.gg = new i(context, iA, iA);
        final WeakReference weakReference = new WeakReference(m.getActivityFromContext(context));
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.ad.nativead.c.a.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                Activity activity2 = (Activity) weakReference.get();
                if (activity2 == null || !activity2.equals(activity)) {
                    return;
                }
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
                a.this.release();
            }
        });
    }

    public final void a(AdResultData adResultData, d dVar) {
        this.mAdResultData = adResultData;
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        this.mAdTemplate = adTemplateR;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplateR);
        this.mApkDownloadHelper = dVar;
        fO();
        bN();
    }

    private void fO() {
        if (this.fs == null) {
            this.fs = new g(this.gh);
        }
        if (this.fA == null) {
            this.fA = new c() { // from class: com.kwad.components.ad.nativead.c.a.2
                @Override // com.kwad.sdk.core.j.c
                public final void bv() {
                    if (a.this.iQ != null) {
                        if (!a.this.qA) {
                            a.this.iQ.yJ();
                            a.this.iQ.yK();
                            a.a(a.this, true);
                        }
                        a.this.iQ.yN();
                    }
                }

                @Override // com.kwad.sdk.core.j.c
                public final void bw() {
                    if (a.this.iQ != null) {
                        a.this.iQ.yO();
                    }
                }
            };
        }
        this.fs.a(this.fA);
        this.fs.Am();
        this.qw = new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.kwad.components.ad.nativead.c.a.3
            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public final void onGlobalLayout() {
                if (a.this.gh == null) {
                    return;
                }
                int iPx2dip = com.kwad.sdk.c.a.a.px2dip(a.this.mContext, a.this.gh.getWidth());
                int iPx2dip2 = com.kwad.sdk.c.a.a.px2dip(a.this.mContext, a.this.gh.getHeight());
                if (iPx2dip == a.this.qy && iPx2dip2 == a.this.qz) {
                    return;
                }
                com.kwad.sdk.core.d.c.d("NativeTKView", "监听器1 - 尺寸: " + iPx2dip + "x" + iPx2dip2 + " old: " + a.this.qy + "x" + a.this.qz);
                a.this.qy = iPx2dip;
                a.this.qz = iPx2dip2;
                if (a.this.qx != null) {
                    a.this.qx.u(iPx2dip, iPx2dip2);
                }
            }
        };
    }

    private void bN() {
        i iVar = this.gg;
        if (iVar != null) {
            iVar.a(m.getActivityFromContext(this.mContext), this.mAdResultData, new j() { // from class: com.kwad.components.ad.nativead.c.a.4
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
                public final String getTKReaderScene() {
                    return "tk_native_interact_card";
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final com.kwad.sdk.widget.g getTouchCoordsView() {
                    return null;
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final String getTkTemplateId() {
                    return com.kwad.sdk.core.response.helper.b.dp(a.this.mAdTemplate).templateId;
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final FrameLayout getTKContainer() {
                    return a.this.gh;
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(TKRenderFailReason tKRenderFailReason) {
                    if (a.this.gh != null) {
                        a.this.gh.setVisibility(8);
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void aB() {
                    if (a.this.gh != null) {
                        a.this.gh.setVisibility(0);
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
                    tVar.c(new ax(new ax.b() { // from class: com.kwad.components.ad.nativead.c.a.4.1
                        @Override // com.kwad.components.core.webview.jshandler.ax.b
                        public final void b(com.kwad.components.core.webview.tachikoma.f.d dVar, AdMatrixInfo.ShakeInfo shakeInfo) {
                            a.this.a(dVar, shakeInfo);
                        }

                        @Override // com.kwad.components.core.webview.jshandler.ax.b
                        public final void b(com.kwad.components.core.webview.tachikoma.f.d dVar, AdMatrixInfo.RotateInfo rotateInfo) {
                            a.this.a(dVar, rotateInfo);
                        }

                        @Override // com.kwad.components.core.webview.jshandler.ax.b
                        public final void a(com.kwad.components.core.webview.tachikoma.f.d dVar, AdMatrixInfo.ShakeInfo shakeInfo, AdMatrixInfo.RotateInfo rotateInfo) {
                            a.this.a(dVar, shakeInfo);
                            a.this.a(dVar, rotateInfo);
                        }
                    }));
                    tVar.c(new z(bVar, a.this.mApkDownloadHelper, (com.kwad.sdk.core.webview.d.a.a) a.this.gg, true));
                    tVar.c(new com.kwad.components.core.webview.jshandler.j(new com.kwad.components.core.webview.jshandler.p() { // from class: com.kwad.components.ad.nativead.c.a.4.2
                        @Override // com.kwad.components.core.webview.jshandler.p
                        public final void a(com.kwad.components.core.webview.jshandler.j jVar, String str) {
                            if (str.equals("getConvertCount")) {
                                jVar.bT(a.this.mAdInfo.convertCount);
                            }
                        }
                    }));
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                    if (a.this.qu != null) {
                        a.this.qu.l(new FrameLayout(a.this.mContext));
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(ae.a aVar) {
                    if (a.this.gh != null) {
                        aVar.width = com.kwad.sdk.c.a.a.px2dip(a.this.mContext, a.this.gh.getWidth());
                        aVar.height = com.kwad.sdk.c.a.a.px2dip(a.this.mContext, a.this.gh.getHeight());
                    }
                    if (aVar instanceof ae.b) {
                        a.this.qx = ((ae.b) aVar).aqr;
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(WebCloseStatus webCloseStatus) {
                    a.this.release();
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(az azVar) {
                    a.this.iQ = azVar;
                }

                /* JADX WARN: Can't fix incorrect switch cases order, some code will duplicate */
                /* JADX WARN: Code duplicated, block: B:23:0x0049  */
                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
                    byte b;
                    if (a.this.qu == null || c0464a == null) {
                        return;
                    }
                    switch (c0464a.apu) {
                        case "adShowCallback":
                            b = 1;
                            break;
                        case "adDownloadConfirmTipShow":
                            b = 2;
                            break;
                        case "adDownloadConfirmTipDismiss":
                            b = 3;
                            break;
                        case "handleDownloadDialog":
                            b = 4;
                            break;
                        case "adClickCallback":
                            b = 0;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    if (b == 0) {
                        a.this.qu.l(new FrameLayout(a.this.mContext));
                        return;
                    }
                    if (b == 1) {
                        a.this.qu.fw();
                    } else if (b == 2) {
                        a.this.qu.onDownloadTipsDialogShow();
                    } else {
                        if (b != 3) {
                            return;
                        }
                        a.this.qu.onDownloadTipsDialogDismiss();
                    }
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final com.kwad.components.core.webview.tachikoma.f.d dVar, AdMatrixInfo.ShakeInfo shakeInfo) {
        if (shakeInfo == null) {
            return;
        }
        float f = shakeInfo.acceleration;
        if (f <= 0.0f) {
            return;
        }
        this.pe = new b.e() { // from class: com.kwad.components.ad.nativead.c.a.5
            @Override // com.kwad.components.ad.nativead.b.e
            public final boolean b(double d) {
                if (!cb.r(a.this.gh, (int) (e.Ko() * 100.0f)) || a.this.fv() || !b.ca()) {
                    return false;
                }
                dVar.t(2, Double.toString(d));
                return true;
            }
        };
        b.fr().a(com.kwad.sdk.core.response.helper.b.du(this.mAdTemplate) || com.kwad.sdk.core.response.helper.a.am(this.mAdInfo), f, this.gh, this.pe, com.kwad.sdk.core.response.helper.b.dK(this.mAdInfo));
        this.qC = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final com.kwad.components.core.webview.tachikoma.f.d dVar, AdMatrixInfo.RotateInfo rotateInfo) {
        if (rotateInfo == null) {
            return;
        }
        this.pd = new b.c() { // from class: com.kwad.components.ad.nativead.c.a.6
            @Override // com.kwad.components.ad.nativead.b.c
            public final boolean s(String str) {
                if (!cb.r(a.this.gh, (int) (e.Ko() * 100.0f)) || a.this.fv() || !b.ca()) {
                    return false;
                }
                dVar.t(1, str);
                return true;
            }
        };
        b.fr().a(rotateInfo, this.mContext, this.pd);
        this.qD = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void release() {
        try {
            az azVar = this.iQ;
            if (azVar != null) {
                azVar.yL();
                this.iQ.yM();
                this.iQ = null;
            }
            com.kwad.components.core.widget.a.c cVar = this.fs;
            if (cVar != null) {
                cVar.b(this.fA);
                this.fs.An();
            }
            i iVar = this.gg;
            if (iVar != null) {
                iVar.kT();
            }
            ViewTreeObserver viewTreeObserver = this.qv;
            if (viewTreeObserver != null) {
                if (viewTreeObserver.isAlive()) {
                    this.qv.removeOnGlobalLayoutListener(this.qw);
                }
                this.qv = null;
            }
            if (this.pe != null) {
                b.fr().a(this.pe);
            }
            if (this.pd != null) {
                b.fr().a(this.pd);
            }
            KSFrameLayout kSFrameLayout = this.gh;
            if (kSFrameLayout != null) {
                kSFrameLayout.removeAllViews();
                this.gh.setVisibility(8);
                this.gh = null;
            }
            this.qB = true;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        KSFrameLayout kSFrameLayout = this.gh;
        if (kSFrameLayout == null) {
            return;
        }
        ViewTreeObserver viewTreeObserver = kSFrameLayout.getViewTreeObserver();
        this.qv = viewTreeObserver;
        viewTreeObserver.addOnGlobalLayoutListener(this.qw);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        ViewTreeObserver viewTreeObserver = this.qv;
        if (viewTreeObserver != null) {
            if (viewTreeObserver.isAlive()) {
                this.qv.removeOnGlobalLayoutListener(this.qw);
            }
            this.qv = null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean fv() {
        return this.mAdInfo.status == 2 || this.mAdInfo.status == 3;
    }

    public final void setAdInteractionListener(com.kwad.components.ad.nativead.d.a aVar) {
        this.qu = aVar;
    }

    public final boolean fP() {
        return this.qB;
    }

    public final boolean fQ() {
        return this.qC;
    }

    public final boolean fR() {
        return this.qD;
    }
}
