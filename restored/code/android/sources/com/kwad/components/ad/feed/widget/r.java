package com.kwad.components.ad.feed.widget;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import android.widget.FrameLayout;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.ax;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bb;
import com.kwad.components.core.webview.jshandler.x;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.components.model.FeedType;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.FeedSlideConf;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.widget.KSFrameLayout;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class r extends com.kwad.components.core.widget.b<AdResultData, AdTemplate> implements com.kwad.sdk.widget.d {
    private KsAdVideoPlayConfig ce;
    private com.kwad.components.core.webview.tachikoma.b.o dj;
    private com.kwad.components.core.l.a.b fP;
    private com.kwad.components.core.webview.tachikoma.i gg;
    private long hH;
    private float hI;
    private float hJ;
    private com.kwad.components.ad.feed.d.b hu;
    private com.kwad.components.ad.feed.d.InterfaceC0364d hv;
    private com.kwad.components.core.widget.b iY;
    private boolean iZ;
    private com.kwad.components.core.widget.b.a jj;
    private KSFrameLayout jt;
    private az ju;
    private com.kwad.sdk.core.webview.c.c jv;
    private a jw;
    private FrameLayout.LayoutParams jx;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private int mHeight;
    private boolean mIsNative;
    private int mWidth;

    public interface a {
        void d(int i, String str);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
    }

    public r(Context context) {
        this(context, null);
    }

    private r(Context context, AttributeSet attributeSet) {
        this(context, null, 0);
    }

    private r(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, 0);
        this.mWidth = getContext().getResources().getDisplayMetrics().widthPixels;
        this.mIsNative = false;
        this.jj = new com.kwad.components.core.widget.b.a() { // from class: com.kwad.components.ad.feed.widget.r.9
            @Override // com.kwad.components.core.widget.b.a
            public final void onAdClicked() {
                if (r.this.avu != null) {
                    r.this.avu.onAdClicked();
                }
                com.kwad.components.ad.feed.monitor.b.a(r.this.mAdTemplate, 1, r.this.getStayTime());
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onAdShow() {
                if (r.this.mIsNative) {
                    if (r.this.avu != null) {
                        r.this.avu.onAdShow();
                    }
                    com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                    com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                    FeedType feedTypeFromInt = FeedType.fromInt(r.this.mAdTemplate.type, r.this.mAdTemplate.defaultType);
                    if (feedTypeFromInt == FeedType.FEED_TYPE_TEXT_NEW) {
                        feedTypeFromInt = FeedType.FEED_TYPE_TEXT_BELOW;
                    }
                    c0502a.templateId = String.valueOf(feedTypeFromInt.getType());
                    c0502a.aLj = String.valueOf(feedTypeFromInt.getFeedDefaultType() == null ? 0 : feedTypeFromInt.getFeedDefaultType().getDefaultType());
                    bVar.b(c0502a);
                    bVar.z(r.this.getHeight(), r.this.mWidth);
                    com.kwad.components.core.t.b.wR().a(r.this.mAdTemplate, null, bVar);
                    com.kwad.components.ad.feed.monitor.b.c(r.this.mAdTemplate, 1, 3);
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDislikeClicked() {
                if (r.this.avu != null) {
                    r.this.avu.onDislikeClicked();
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogShow() {
                if (r.this.avu != null) {
                    r.this.avu.onDownloadTipsDialogShow();
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogDismiss() {
                if (r.this.avu != null) {
                    r.this.avu.onDownloadTipsDialogDismiss();
                }
            }
        };
        init(context);
    }

    private void init(Context context) {
        int iA = com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPw);
        final WeakReference weakReference = new WeakReference(com.kwad.sdk.wrapper.m.getActivityFromContext(context));
        this.gg = new com.kwad.components.core.webview.tachikoma.i(context, iA, iA);
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.ad.feed.widget.r.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                Activity activity2 = (Activity) weakReference.get();
                if (activity2 == null || !activity2.equals(activity)) {
                    return;
                }
                r.this.onRelease();
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void onRelease() {
        com.kwad.components.core.webview.tachikoma.i iVar = this.gg;
        if (iVar != null) {
            iVar.kT();
        }
        az azVar = this.ju;
        if (azVar != null) {
            azVar.onDestroy();
        }
        com.kwad.components.ad.feed.d.InterfaceC0364d interfaceC0364d = this.hv;
        if (interfaceC0364d != null) {
            com.kwad.components.ad.feed.d.a(interfaceC0364d);
        }
        com.kwad.components.ad.feed.d.b bVar = this.hu;
        if (bVar != null) {
            com.kwad.components.ad.feed.d.a(bVar);
        }
        com.kwad.components.ad.feed.d.D(this.mContext);
        com.kwad.components.ad.feed.d.E(this.mContext);
    }

    @Override // com.kwad.components.core.widget.b
    public final void by() {
        this.jt = (KSFrameLayout) findViewById(R.id.ksad_container);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cP() {
        if (this.jt != null) {
            this.jx = new FrameLayout.LayoutParams(this.jt.getLayoutParams());
        }
    }

    public final void setWidth(int i) {
        if (i <= 0) {
            i = getContext().getResources().getDisplayMetrics().widthPixels;
        }
        this.mWidth = i;
    }

    public final void setVideoPlayConfig(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        this.ce = ksAdVideoPlayConfig;
        cR();
        cS();
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bv() {
        super.bv();
        com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
        az azVar = this.ju;
        if (azVar != null) {
            azVar.yN();
        }
        setLifeStatue("pageVisiable");
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bw() {
        super.bw();
        az azVar = this.ju;
        if (azVar != null) {
            azVar.yO();
            com.kwad.components.core.l.a.ty().c(this.fP);
        }
        setLifeStatue("pageInvisiable");
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        this.mApkDownloadHelper = dVar;
        dVar.setOnShowListener(this);
        this.mApkDownloadHelper.setOnDismissListener(this);
        this.hH = SystemClock.elapsedRealtime();
        if (com.kwad.sdk.core.response.helper.b.dw(this.mAdTemplate) > 0.0d) {
            this.mHeight = (int) (((double) this.mWidth) * com.kwad.sdk.core.response.helper.b.dw(this.mAdTemplate));
        } else {
            this.mHeight = this.jt.getHeight();
        }
        final long jElapsedRealtime = SystemClock.elapsedRealtime();
        this.gg.a(com.kwad.sdk.wrapper.m.getActivityFromContext(this.mContext), adResultData, new com.kwad.components.core.webview.tachikoma.j() { // from class: com.kwad.components.ad.feed.widget.r.5
            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.components.core.webview.tachikoma.b.p pVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.components.core.webview.tachikoma.c.n nVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(u uVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aC() {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void f(AdTemplate adTemplate) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getRegisterViewKey() {
                return "ksad-feed-card";
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getTKReaderScene() {
                return "tk_feed_tk_card";
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final com.kwad.sdk.widget.g getTouchCoordsView() {
                return null;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getTkTemplateId() {
                return com.kwad.sdk.core.response.helper.b.er(r.this.mAdTemplate);
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final FrameLayout getTKContainer() {
                r.this.cP();
                return r.this.jt;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(TKRenderFailReason tKRenderFailReason) {
                r.this.cT();
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aB() {
                if (r.this.jw != null) {
                    r.this.jw.d(3, "");
                }
                com.kwad.sdk.core.d.c.d("TKFeedView", "TK load success, cost time: " + (SystemClock.elapsedRealtime() - jElapsedRealtime));
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
                if (r.this.gg.zh()) {
                    return;
                }
                tVar.c(new com.kwad.components.core.webview.tachikoma.b.n() { // from class: com.kwad.components.ad.feed.widget.r.5.1
                    @Override // com.kwad.components.core.webview.tachikoma.b.w, com.kwad.sdk.core.webview.c.a
                    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                        super.a(str, cVar);
                        r.this.jv = cVar;
                        r.this.cR();
                    }
                });
                tVar.c(new x() { // from class: com.kwad.components.ad.feed.widget.r.5.2
                    @Override // com.kwad.components.core.webview.jshandler.x
                    public final void b(y yVar) {
                        super.b(yVar);
                        if (com.kwad.components.core.t.a.aN(r.this.mContext).wP() && r.this.dj != null) {
                            com.kwad.components.core.webview.tachikoma.c.n nVar = new com.kwad.components.core.webview.tachikoma.c.n();
                            nVar.auv = true;
                            r.this.dj.c(nVar);
                        }
                        com.kwad.components.core.l.a.ty().a(r.this.getCurrentVoiceItem());
                        com.kwad.components.ad.feed.monitor.b.a(r.this.mAdTemplate, 1, 1, com.kwad.sdk.core.response.helper.a.M(r.this.mAdInfo), null, SystemClock.elapsedRealtime() - r.this.hH);
                    }

                    @Override // com.kwad.components.core.webview.jshandler.x
                    public final void a(y yVar) {
                        super.a(yVar);
                        com.kwad.components.ad.feed.monitor.b.a(r.this.mAdTemplate, 2, 1, com.kwad.sdk.core.response.helper.a.M(r.this.mAdInfo), yVar.errorReason, SystemClock.elapsedRealtime() - r.this.hH);
                        com.kwad.components.core.p.a.vX().g(r.this.mAdTemplate, yVar.errorCode, yVar.zI());
                    }

                    @Override // com.kwad.components.core.webview.jshandler.x
                    public final void c(y yVar) {
                        super.c(yVar);
                        com.kwad.components.core.l.a.ty().c(r.this.fP);
                    }
                });
                bb bbVar = new bb(new bb.a() { // from class: com.kwad.components.ad.feed.widget.r.5.3
                    @Override // com.kwad.components.core.webview.jshandler.bb.a
                    public final void cN() {
                        r.this.cH();
                    }
                });
                ax axVar = new ax(new ax.a() { // from class: com.kwad.components.ad.feed.widget.r.5.4
                    @Override // com.kwad.components.core.webview.jshandler.ax.a
                    public final void c(com.kwad.components.core.webview.tachikoma.f.d dVar2) {
                        r.this.a(dVar2);
                    }

                    @Override // com.kwad.components.core.webview.jshandler.ax.a
                    public final void d(com.kwad.components.core.webview.tachikoma.f.d dVar2) {
                        r.this.b(dVar2);
                    }

                    @Override // com.kwad.components.core.webview.jshandler.ax.a
                    public final void e(com.kwad.components.core.webview.tachikoma.f.d dVar2) {
                        r.this.a(dVar2);
                        r.this.b(dVar2);
                    }
                });
                tVar.c(bbVar);
                tVar.c(axVar);
                tVar.c(new z(bVar, r.this.mApkDownloadHelper, (com.kwad.sdk.core.webview.d.a.a) r.this.gg, true));
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (r.this.avu != null) {
                    r.this.avu.onAdClicked();
                }
                r.this.cI();
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(ae.a aVar) {
                aVar.width = com.kwad.sdk.c.a.a.px2dip(r.this.mContext, r.this.mWidth);
                aVar.height = com.kwad.sdk.c.a.a.px2dip(r.this.mContext, r.this.mHeight);
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.components.core.webview.tachikoma.b.o oVar) {
                r.this.dj = oVar;
                r.this.dj.a(new com.kwad.components.core.webview.tachikoma.b.o.a() { // from class: com.kwad.components.ad.feed.widget.r.5.5
                    @Override // com.kwad.components.core.webview.tachikoma.b.o.a
                    public final boolean isMuted() {
                        return r.this.getMuteStatus();
                    }
                });
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(WebCloseStatus webCloseStatus) {
                if (r.this.ju != null) {
                    r.this.ju.yL();
                    r.this.ju.yM();
                }
                r.this.setLifeStatue("hideStart");
                r.this.setLifeStatue("hideEnd");
                by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.r.5.6
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        r.this.Aa();
                    }
                });
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(az azVar) {
                r.this.ju = azVar;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
                if (r.this.avu != null) {
                    String str = c0464a.apu;
                    str.hashCode();
                    switch (str) {
                        case "adShowCallback":
                            r.this.avu.onAdShow();
                            break;
                        case "adDownloadConfirmTipCancel":
                        case "adDownloadConfirmTipDismiss":
                            r.this.avu.onDownloadTipsDialogDismiss();
                            break;
                        case "adCloseCallback":
                            r.this.avu.onDislikeClicked();
                            break;
                        case "adDownloadConfirmTipShow":
                            r.this.avu.onDownloadTipsDialogShow();
                            break;
                        case "adClickCallback":
                            r.this.avu.onAdClicked();
                            break;
                    }
                }
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aD() {
                r.this.gg.a("setSensorMotionType", (String) null, new com.kwad.sdk.components.m() { // from class: com.kwad.components.ad.feed.widget.r.5.7
                    @Override // com.kwad.sdk.components.m
                    public final Object call(Object... objArr) {
                        if (objArr != null && objArr.length != 0) {
                            try {
                                Object obj = objArr[0];
                                if (obj instanceof Integer) {
                                    int iIntValue = ((Integer) obj).intValue();
                                    if (iIntValue == 1) {
                                        r.this.cU();
                                    } else if (iIntValue == 2) {
                                        r.this.cV();
                                    } else if (iIntValue == 3) {
                                        r.this.cU();
                                        r.this.cV();
                                    }
                                }
                            } catch (Throwable unused) {
                            }
                        }
                        return null;
                    }
                });
                r.this.cS();
                r.this.cQ();
                r.this.bP();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bP() {
        com.kwad.components.core.webview.tachikoma.c.n nVar = new com.kwad.components.core.webview.tachikoma.c.n();
        nVar.auv = getMuteStatus();
        this.gg.a("setVideoMuteStateListener", nVar.toJson().toString(), (com.kwad.sdk.components.m) null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cQ() {
        this.gg.a("setVideoPlayStatusCallback", (String) null, new com.kwad.components.core.webview.tachikoma.a.g() { // from class: com.kwad.components.ad.feed.widget.r.6
            @Override // com.kwad.components.core.webview.tachikoma.a.g
            public final void bR() {
            }

            @Override // com.kwad.components.core.webview.tachikoma.a.g
            public final void bS() {
            }

            @Override // com.kwad.components.core.webview.tachikoma.a.g
            public final void a(y yVar) {
                com.kwad.components.ad.feed.monitor.b.a(r.this.mAdTemplate, 2, 1, com.kwad.sdk.core.response.helper.a.M(r.this.mAdInfo), yVar.errorReason, SystemClock.elapsedRealtime() - r.this.hH);
                com.kwad.components.core.p.a.vX().g(r.this.mAdTemplate, yVar.errorCode, yVar.zI());
            }

            @Override // com.kwad.components.core.webview.tachikoma.a.g
            public final void bT() {
                com.kwad.components.core.l.a.ty().c(r.this.fP);
            }

            @Override // com.kwad.components.core.webview.tachikoma.a.g
            public final void bU() {
                if (com.kwad.components.core.t.a.aN(r.this.mContext).wP() && r.this.gg != null) {
                    com.kwad.components.core.webview.tachikoma.c.n nVar = new com.kwad.components.core.webview.tachikoma.c.n();
                    nVar.auv = r.this.getMuteStatus();
                    r.this.gg.a("setVideoMuteStateListener", nVar.toJson().toString(), (com.kwad.sdk.components.m) null);
                }
                com.kwad.components.core.l.a.ty().a(r.this.getCurrentVoiceItem());
                com.kwad.components.ad.feed.monitor.b.a(r.this.mAdTemplate, 1, 1, com.kwad.sdk.core.response.helper.a.M(r.this.mAdInfo), null, SystemClock.elapsedRealtime() - r.this.hH);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:12:0x0024  */
    /* JADX WARN: Code duplicated, block: B:20:0x0043  */
    /* JADX WARN: Code duplicated, block: B:21:0x0044 A[PHI: r1
  0x0044: PHI (r1v4 boolean) = (r1v0 boolean), (r1v1 boolean), (r1v0 boolean), (r1v0 boolean) binds: [B:18:0x0040, B:20:0x0043, B:10:0x0021, B:5:0x0011] A[DONT_GENERATE, DONT_INLINE]] */
    public boolean getMuteStatus() {
        KsAdVideoPlayConfig ksAdVideoPlayConfig;
        boolean z;
        boolean z2 = true;
        if (!com.kwad.sdk.core.config.e.hM() && com.kwad.components.core.t.a.aN(this.mContext).wP()) {
            z = z2;
        } else if (this.fP != null) {
            com.kwad.components.core.l.a.ty();
            if (com.kwad.components.core.l.a.b(this.fP)) {
                ksAdVideoPlayConfig = this.ce;
                if (!(ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) && ((KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig).getVideoSoundValue() != 0) {
                    z = !this.ce.isVideoSoundEnable();
                } else {
                    if (com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo)) {
                        z2 = false;
                    }
                    z = z2;
                }
            } else {
                z = z2;
            }
        } else {
            ksAdVideoPlayConfig = this.ce;
            if (!(ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl)) {
            }
            if (com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo)) {
                z2 = false;
            }
            z = z2;
        }
        if (this.mAdTemplate != 0) {
            this.mAdTemplate.mIsAudioEnable = !z;
        }
        return z;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cR() {
        if (this.jv == null) {
            return;
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.r.7
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.components.core.webview.tachikoma.c.d dVar = new com.kwad.components.core.webview.tachikoma.c.d();
                boolean zIsNetworkConnected = aq.isNetworkConnected(r.this.mContext);
                boolean zIsWifiConnected = aq.isWifiConnected(r.this.mContext);
                if (r.this.ce instanceof KSAdVideoPlayConfigImpl) {
                    KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) r.this.ce;
                    dVar.aum = r.this.a(zIsNetworkConnected, zIsWifiConnected, kSAdVideoPlayConfigImpl, kSAdVideoPlayConfigImpl.getVideoAutoPlayType());
                } else {
                    dVar.aum = r.this.b(zIsNetworkConnected, zIsWifiConnected);
                }
                r.this.jv.b(dVar);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cS() {
        com.kwad.components.core.webview.tachikoma.i iVar = this.gg;
        if (iVar == null || iVar.zx() == null) {
            return;
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.r.8
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.components.core.webview.tachikoma.c.d dVar = new com.kwad.components.core.webview.tachikoma.c.d();
                boolean zIsNetworkConnected = aq.isNetworkConnected(r.this.mContext);
                boolean zIsWifiConnected = aq.isWifiConnected(r.this.mContext);
                if (r.this.ce instanceof KSAdVideoPlayConfigImpl) {
                    KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) r.this.ce;
                    dVar.aum = r.this.a(zIsNetworkConnected, zIsWifiConnected, kSAdVideoPlayConfigImpl, kSAdVideoPlayConfigImpl.getVideoAutoPlayType());
                } else {
                    dVar.aum = r.this.b(zIsNetworkConnected, zIsWifiConnected);
                }
                if (r.this.gg != null) {
                    r.this.gg.a("setVideoAutoPlayListener", dVar.toJson().toString(), (com.kwad.sdk.components.m) null);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean a(boolean z, boolean z2, KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl, int i) {
        if (i == 1) {
            return z;
        }
        if (i == 2) {
            return z2;
        }
        if (i == 3) {
            return false;
        }
        if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() != 0) {
            return kSAdVideoPlayConfigImpl.isDataFlowAutoStart() ? z : z2;
        }
        return b(z, z2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean b(boolean z, boolean z2) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        if (com.kwad.sdk.core.response.helper.a.cj(adInfoEM)) {
            return z;
        }
        if (com.kwad.sdk.core.response.helper.a.ck(adInfoEM)) {
            return z2;
        }
        if (com.kwad.sdk.core.response.helper.a.cl(adInfoEM)) {
            return false;
        }
        return com.kwad.sdk.core.config.e.Kh() ? z : z2;
    }

    @Override // com.kwad.components.core.widget.b
    public final void aa() {
        if (this.mAdTemplate.mPvReported || this.mAdTemplate.mHasAdShow) {
            return;
        }
        az azVar = this.ju;
        if (azVar != null) {
            azVar.yJ();
            this.ju.yK();
            com.kwad.components.ad.feed.monitor.b.c(this.mAdTemplate, 3, 3);
        }
        if (this.gg.zx() != null) {
            setLifeStatue("showStart");
            setLifeStatue("showEnd");
            com.kwad.components.ad.feed.monitor.b.c(this.mAdTemplate, 3, 3);
        }
        if (this.avu != null) {
            this.avu.onAdShow();
            this.mAdTemplate.mHasAdShow = true;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cT() {
        if (this.iY == null) {
            this.mIsNative = true;
            com.kwad.components.core.widget.b bVarA = com.kwad.components.ad.feed.b.a(this.mContext, FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType), com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo));
            this.iY = bVarA;
            if (bVarA != null) {
                int iA = com.kwad.sdk.c.a.a.a(this.mContext, 16.0f);
                FrameLayout.LayoutParams layoutParams = this.jx;
                if (layoutParams != null) {
                    this.jt.setLayoutParams(layoutParams);
                }
                this.iY.setMargin(iA);
                this.jt.removeAllViews();
                this.iY.setInnerAdInteractionListener(this.jj);
                this.jt.addView(this.iY);
                a aVar = this.jw;
                if (aVar != null) {
                    aVar.d(1, "");
                }
                this.iY.d(this.mAdResultData);
                com.kwad.components.core.widget.b bVar = this.iY;
                if (bVar instanceof c) {
                    ((c) bVar).b(this.ce);
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cI() {
        if (this.iZ) {
            return;
        }
        this.iZ = true;
        com.kwad.components.ad.feed.monitor.b.a(this.mAdTemplate, 3, getStayTime());
    }

    @Override // com.kwad.components.core.widget.b
    public final int getLayoutId() {
        return R.layout.ksad_feed_tkview;
    }

    @Override // android.view.ViewGroup
    public final boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        int action = motionEvent.getAction() & 255;
        if (!com.kwad.sdk.core.config.e.Kt() || !com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate)) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        FeedSlideConf feedSlideConfCM = com.kwad.sdk.core.response.helper.b.cM(this.mAdTemplate);
        if (feedSlideConfCM == null) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        b(motionEvent);
        if ((action == 2 || action == 3) && this.jt != null && !this.mIsNative && Math.abs(motionEvent.getX() - this.hI) > 0.0f) {
            this.jt.requestDisallowInterceptTouchEvent(true);
            double dAbs = Math.abs(motionEvent.getX() - this.hI);
            double dAbs2 = Math.abs(motionEvent.getY() - this.hJ);
            if (Math.tan(feedSlideConfCM.maxRange) * dAbs < dAbs2 || Math.tan(feedSlideConfCM.minRange) * dAbs < dAbs2) {
                this.jt.requestDisallowInterceptTouchEvent(false);
            }
        }
        return super.onInterceptTouchEvent(motionEvent);
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
    }

    private void b(MotionEvent motionEvent) {
        if (motionEvent.getActionMasked() == 0) {
            this.hI = motionEvent.getX();
            this.hJ = motionEvent.getY();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.feed.widget.r.10
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                }
            });
        }
        return this.fP;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cH() {
        float fDt = com.kwad.sdk.core.response.helper.b.dt(this.mAdTemplate);
        if (this.hv == null) {
            this.hv = new com.kwad.components.ad.feed.d.InterfaceC0364d() { // from class: com.kwad.components.ad.feed.widget.r.11
                @Override // com.kwad.components.ad.feed.d.InterfaceC0364d
                public final boolean b(final double d) {
                    if (!cb.r(r.this.jt, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !r.this.fv() || !com.kwad.components.ad.feed.d.ca()) {
                        return false;
                    }
                    com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(r.this.getContext()).aF(r.this.mAdTemplate).b(r.this.mApkDownloadHelper).aD(2).as(false).au(false).aC(157).aB(5).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.r.11.1
                        @Override // com.kwad.components.core.e.d.a.b
                        public final void onAdClicked() {
                            com.kwad.sdk.core.d.c.d("TKFeedView", "convertEnable End" + com.kwad.sdk.core.response.helper.e.eW(r.this.mAdTemplate));
                            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                            bVar.j(d);
                            bVar.dS(157);
                            r.this.c(bVar);
                        }
                    }));
                    return true;
                }
            };
        }
        com.kwad.components.ad.feed.d.a(com.kwad.sdk.core.response.helper.b.dI(this.mAdInfo), fDt, this.mContext, this.hv, com.kwad.sdk.core.response.helper.b.dJ(this.mAdInfo));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cU() {
        AdMatrixInfo.RotateInfo rotateInfoDH = com.kwad.sdk.core.response.helper.b.dH(this.mAdTemplate);
        if (this.hu == null) {
            this.hu = new com.kwad.components.ad.feed.d.b() { // from class: com.kwad.components.ad.feed.widget.r.12
                @Override // com.kwad.components.ad.feed.d.b
                public final boolean s(String str) {
                    if (!cb.r(r.this.jt, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !r.this.fv() || !com.kwad.components.ad.feed.d.ca()) {
                        return false;
                    }
                    r.this.gg.a("setSensorParams", new com.kwad.components.core.webview.tachikoma.c.i(1, str).toJson().toString(), (com.kwad.sdk.components.m) null);
                    return true;
                }
            };
        }
        com.kwad.components.ad.feed.d.a(rotateInfoDH, this.mContext, this.hu);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cV() {
        float fDt = com.kwad.sdk.core.response.helper.b.dt(this.mAdTemplate);
        if (this.hv == null) {
            this.hv = new com.kwad.components.ad.feed.d.InterfaceC0364d() { // from class: com.kwad.components.ad.feed.widget.r.2
                @Override // com.kwad.components.ad.feed.d.InterfaceC0364d
                public final boolean b(double d) {
                    if (!cb.r(r.this.jt, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !r.this.fv() || !com.kwad.components.ad.feed.d.ca()) {
                        return false;
                    }
                    r.this.gg.a("setSensorParams", new com.kwad.components.core.webview.tachikoma.c.i(2, Double.toString(d)).toJson().toString(), (com.kwad.sdk.components.m) null);
                    return true;
                }
            };
        }
        com.kwad.components.ad.feed.d.a(com.kwad.sdk.core.response.helper.b.dI(this.mAdInfo), fDt, this.mContext, this.hv, com.kwad.sdk.core.response.helper.b.dJ(this.mAdInfo));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final com.kwad.components.core.webview.tachikoma.f.d dVar) {
        float fDt = com.kwad.sdk.core.response.helper.b.dt(this.mAdTemplate);
        if (this.hv == null) {
            this.hv = new com.kwad.components.ad.feed.d.InterfaceC0364d() { // from class: com.kwad.components.ad.feed.widget.r.3
                @Override // com.kwad.components.ad.feed.d.InterfaceC0364d
                public final boolean b(double d) {
                    if (!cb.r(r.this.jt, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !r.this.fv() || !com.kwad.components.ad.feed.d.ca()) {
                        return false;
                    }
                    dVar.t(2, Double.toString(d));
                    return true;
                }
            };
        }
        com.kwad.components.ad.feed.d.a(com.kwad.sdk.core.response.helper.b.dI(this.mAdInfo), fDt, this.mContext, this.hv, com.kwad.sdk.core.response.helper.b.dJ(this.mAdInfo));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(final com.kwad.components.core.webview.tachikoma.f.d dVar) {
        AdMatrixInfo.RotateInfo rotateInfoDH = com.kwad.sdk.core.response.helper.b.dH(this.mAdTemplate);
        if (this.hu == null) {
            this.hu = new com.kwad.components.ad.feed.d.b() { // from class: com.kwad.components.ad.feed.widget.r.4
                @Override // com.kwad.components.ad.feed.d.b
                public final boolean s(String str) {
                    if (!cb.r(r.this.jt, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !r.this.fv() || !com.kwad.components.ad.feed.d.ca()) {
                        return false;
                    }
                    dVar.t(1, str);
                    return true;
                }
            };
        }
        com.kwad.components.ad.feed.d.a(rotateInfoDH, this.mContext, this.hu);
    }

    public final void setLifeStatue(String str) {
        com.kwad.components.core.webview.tachikoma.i iVar = this.gg;
        if (iVar != null) {
            iVar.a("setLifeStatus", str, (com.kwad.sdk.components.m) null);
        }
    }

    public final void setTKLoadListener(a aVar) {
        a aVar2 = this.jw;
        if (aVar2 != null) {
            aVar2.d(this.mIsNative ? 1 : 3, "");
        }
        this.jw = aVar;
    }
}
