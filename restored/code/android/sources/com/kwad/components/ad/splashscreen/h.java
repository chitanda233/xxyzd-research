package com.kwad.components.ad.splashscreen;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.components.ad.splashscreen.monitor.SplashMonitorInfo;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.sdk.api.KsSplashScreenAd;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bx;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends com.kwad.sdk.mvp.a {
    public com.kwad.components.ad.splashscreen.d.a GF;
    public StyleTemplate GG;
    public com.kwad.sdk.core.j.a GH;
    public int GP;
    public int GQ;
    public long GR;
    public long GS;
    public long GT;
    public long GU;
    public long GV;
    public long GW;
    public long GX;
    private KsSplashScreenAd.SplashScreenAdInteractionListener Gt;
    public AdResultData mAdResultData;
    public SceneImpl mAdScene;
    public com.kwad.components.core.e.d.d mApkDownloadHelper;
    public AdBaseFrameLayout mRootContainer;
    public long mStartRenderTime;
    public bx mTimerHelper;
    public KsVideoPlayConfig mVideoPlayConfig;
    private List<g> GI = new CopyOnWriteArrayList();
    private List<f> GJ = new CopyOnWriteArrayList();
    public boolean GK = false;
    private boolean GL = false;
    public boolean GM = false;
    public boolean GN = false;
    public boolean bY = false;
    public long GO = SystemClock.elapsedRealtime();
    public boolean isWebTimeout = false;

    public interface a {
        void b(com.kwad.sdk.core.adlog.c.b bVar);
    }

    public final void a(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    public static boolean s(AdInfo adInfo) {
        return com.kwad.sdk.core.response.helper.b.dL(adInfo) && com.kwad.sdk.core.response.helper.a.bj(adInfo);
    }

    public static boolean af(AdTemplate adTemplate) {
        AdMatrixInfo.SplashPlayCardTKInfo splashPlayCardTKInfoDR;
        return com.kwad.sdk.core.config.e.JX() && (splashPlayCardTKInfoDR = com.kwad.sdk.core.response.helper.b.dR(adTemplate)) != null && !TextUtils.isEmpty(splashPlayCardTKInfoDR.templateId) && splashPlayCardTKInfoDR.renderType == 1;
    }

    public final void c(int i, Context context, int i2, int i3) {
        a(i, context, i2, i3, null);
    }

    public final void a(final int i, Context context, final int i2, int i3, final a aVar) {
        com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(context).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(i3).as(i3 == 1).aC(i2).aB(i).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.splashscreen.h.1
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.components.ad.splashscreen.monitor.a.mr().aj(h.this.mAdTemplate);
                if (h.this.Gt != null) {
                    h.this.Gt.onAdClicked();
                }
                com.kwad.components.ad.splashscreen.monitor.a.mr().ah(h.this.mAdTemplate);
                JSONObject jSONObject = new JSONObject();
                try {
                    if (h.this.GF != null) {
                        jSONObject.put(MediationConstant.EXTRA_DURATION, h.this.GF.getCurrentPosition());
                    }
                } catch (JSONException e) {
                    com.kwad.sdk.core.d.c.printStackTrace(e);
                }
                com.kwad.sdk.core.adlog.c.b bVarF = new com.kwad.sdk.core.adlog.c.b().dS(i2).f(h.this.mRootContainer.getTouchCoords());
                if (i == 2) {
                    bVarF.eb(6);
                }
                com.kwad.sdk.core.adlog.c.a(h.this.mAdTemplate, bVarF, jSONObject);
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.b(bVarF);
                }
            }
        }));
    }

    public final void setSplashScreenAdListener(KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener) {
        this.Gt = splashScreenAdInteractionListener;
    }

    public final void ab() {
        this.mAdTemplate.converted = true;
        com.kwad.components.ad.splashscreen.monitor.a.mr().aj(this.mAdTemplate);
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdClicked();
        }
        com.kwad.components.ad.splashscreen.monitor.a.mr().ah(this.mAdTemplate);
    }

    public final void ag(boolean z) {
        if (this.GL) {
            return;
        }
        this.GL = true;
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowStart();
        }
        if (z && com.kwad.sdk.core.config.e.KV()) {
            com.kwad.components.core.t.b.wR().a(this.mAdTemplate, null, null);
        }
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        this.mAdTemplate.showTime = jElapsedRealtime;
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.a(this.mAdTemplate, jElapsedRealtime - this.mAdTemplate.showStartTime, jElapsedRealtime - this.mAdTemplate.addStartTime, jElapsedRealtime - this.mAdTemplate.requestStartTime);
        com.kwad.components.ad.splashscreen.monitor.c.at(this.mAdTemplate);
        com.kwad.components.ad.splashscreen.monitor.a.mr().v(this.mAdTemplate);
        com.kwad.sdk.a.a.c.Hx().bB(true);
        bx bxVar = this.mTimerHelper;
        if (bxVar != null) {
            bxVar.startTiming();
        }
    }

    public final void mb() {
        com.kwad.components.ad.splashscreen.monitor.a.mr().ak(this.mAdTemplate);
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowEnd();
        }
        com.kwad.components.ad.splashscreen.monitor.a.mr().w(this.mAdTemplate);
    }

    public final void mc() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowError(0, "onMediaPlayError");
        }
    }

    public final void md() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowStart();
        }
    }

    public final void me() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowEnd();
        }
    }

    public final void mf() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onSkippedAd();
        }
    }

    public final void mg() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdClicked();
        }
    }

    public final void mh() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            try {
                splashScreenAdInteractionListener.onDownloadTipsDialogShow();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
    }

    public final void mi() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            try {
                splashScreenAdInteractionListener.onDownloadTipsDialogCancel();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
    }

    public final void mj() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            try {
                splashScreenAdInteractionListener.onDownloadTipsDialogDismiss();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
    }

    public final void mk() {
        if (this.GK) {
            return;
        }
        this.GK = true;
        if (!s(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)) || this.mAdTemplate.converted) {
            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
            bx bxVar = this.mTimerHelper;
            if (bxVar != null) {
                c0502a.duration = bxVar.getTime();
            }
            com.kwad.sdk.core.adlog.c.b(this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dT(14).eb(22).b(c0502a), (JSONObject) null);
            com.kwad.components.ad.splashscreen.monitor.a.mr().ak(this.mAdTemplate);
            KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
            if (splashScreenAdInteractionListener != null) {
                splashScreenAdInteractionListener.onAdShowEnd();
            }
            com.kwad.components.ad.splashscreen.monitor.a.mr().w(this.mAdTemplate);
        } else {
            mp();
        }
        mn();
    }

    public final void ml() {
        com.kwad.components.ad.splashscreen.monitor.a.mr().ak(this.mAdTemplate);
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowEnd();
        }
        com.kwad.components.ad.splashscreen.monitor.a.mr().w(this.mAdTemplate);
    }

    public final void mm() {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onSkippedAd();
        }
        com.kwad.components.ad.splashscreen.monitor.a.mr().w(this.mAdTemplate);
        mn();
    }

    public final void c(int i, String str) {
        KsSplashScreenAd.SplashScreenAdInteractionListener splashScreenAdInteractionListener = this.Gt;
        if (splashScreenAdInteractionListener != null) {
            splashScreenAdInteractionListener.onAdShowError(i, str);
        }
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.e(this.mAdTemplate, i, String.valueOf(str));
        mn();
    }

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        com.kwad.components.ad.splashscreen.d.a aVar = this.GF;
        if (aVar != null) {
            aVar.release();
        }
        com.kwad.sdk.core.j.a aVar2 = this.GH;
        if (aVar2 != null) {
            aVar2.release();
        }
    }

    public final void a(g gVar) {
        this.GI.add(gVar);
    }

    public final void b(g gVar) {
        this.GI.remove(gVar);
    }

    private void mn() {
        mo();
        Iterator<g> it = this.GI.iterator();
        while (it.hasNext()) {
            it.next().ma();
        }
    }

    public final void an(int i) {
        Iterator<g> it = this.GI.iterator();
        while (it.hasNext()) {
            it.next().am(i);
        }
    }

    private void mo() {
        long jDT;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        SplashMonitorInfo elementTypes = new SplashMonitorInfo().setLoadType(this.mAdTemplate.splashAdLoadType).setStatus(8).setElementTypes(com.kwad.components.core.webview.tachikoma.e.a.zM().zN());
        bx bxVar = this.mTimerHelper;
        SplashMonitorInfo rotateComposeTimeout = elementTypes.setShowEndTime(bxVar != null ? bxVar.getTime() : -1L).setRotateComposeTimeout(this.bY);
        if (af(this.mAdTemplate)) {
            jDT = com.kwad.sdk.core.response.helper.b.dS(this.mAdTemplate);
        } else {
            jDT = com.kwad.sdk.core.response.helper.b.dT(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
        }
        com.kwad.sdk.commercial.c.m(rotateComposeTimeout.setTkDefaultTimeout(jDT).setSoSource(this.GP).setSoLoadTime(this.GR).setOfflineSource(this.GQ).setOfflineLoadTime(this.GS).setTkFileLoadTime(this.GT).setTkInitTime(this.GU).setTkRenderTime(this.GV).setNativeLoadTime(this.GW).setWebTimeout(this.isWebTimeout).setWebLoadTime(this.GX).setInteractiveStyle(com.kwad.sdk.core.response.helper.b.ee(adInfoEM)).setInteractivityDefaultStyle(com.kwad.sdk.core.response.helper.b.ef(adInfoEM)).setCreativeId(com.kwad.sdk.core.response.helper.a.L(adInfoEM)).setAdTemplate(this.mAdTemplate));
        com.kwad.components.core.webview.tachikoma.e.a.zM().zO();
    }

    public final void a(f fVar) {
        if (fVar == null) {
            return;
        }
        this.GJ.add(fVar);
    }

    public final void b(f fVar) {
        if (fVar == null) {
            return;
        }
        this.GJ.remove(fVar);
    }

    private void mp() {
        Iterator<f> it = this.GJ.iterator();
        while (it.hasNext()) {
            it.next().lW();
        }
    }

    public final void mq() {
        this.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.h.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (com.kwad.components.core.e.c.b.pF()) {
                    h.this.mRootContainer.postDelayed(this, 1000L);
                } else {
                    h.this.ml();
                }
            }
        });
    }

    public final void U(Context context) {
        if (this.mAdTemplate.mPvReported) {
            return;
        }
        com.kwad.components.ad.splashscreen.local.a.V(context);
        if (!com.kwad.sdk.core.config.e.KV()) {
            com.kwad.components.core.t.b.wR().a(this.mAdTemplate, null, null);
        }
        com.kwad.sdk.commercial.convert.c.cd(this.mAdTemplate);
        ag(true);
    }

    public static boolean o(AdInfo adInfo) {
        return adInfo.adSplashInfo.fullScreenClickSwitch == 1;
    }
}
