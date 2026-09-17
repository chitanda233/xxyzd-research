package com.sigmob.sdk.manager;

import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.Sigmob;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.h;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.common.p;
import com.sigmob.sdk.base.j;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.mraid.g;
import com.sigmob.sdk.mraid.i;
import com.sigmob.sdk.videoAd.k;
import com.sigmob.sdk.videoAd.m;
import com.sigmob.windad.WindAdError;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class f extends b implements h.b, p, com.sigmob.sdk.base.network.f.a {
    protected final Handler h = new Handler(Looper.getMainLooper()) { // from class: com.sigmob.sdk.manager.f.1
        @Override // android.os.Handler
        public void handleMessage(Message msg) {
            if (msg.what == 8193 && f.this.b == AdStatus.AdStatusLoading) {
                f.this.h.removeMessages(8193);
                f.this.a(WindAdError.ERROR_SIGMOB_AD_TIME_OUT);
            }
        }
    };
    protected String i;
    protected String j;
    protected String k;
    protected long l;
    protected LoadAdRequest m;
    protected BaseAdUnit n;
    protected List<BaseAdUnit> o;
    protected i p;
    protected k q;
    protected m r;

    /* JADX INFO: Access modifiers changed from: private */
    public void a(BaseAdUnit adUnit, String error, boolean isPreload) {
        com.sigmob.sdk.base.network.h.a(adUnit, s.a((CharSequence) error) ? com.sigmob.sdk.base.common.a.x : com.sigmob.sdk.base.common.a.y);
        ad.a(PointCategory.LOADEND, s.a((CharSequence) error) ? "1" : "0", adUnit, null, this.m, null);
        this.h.removeMessages(8193);
        if (adUnit == null) {
            return;
        }
        if (isPreload) {
            a(adUnit, this.m);
        }
        if (adUnit.getPlayMode() == 0) {
            if (s.a((CharSequence) error)) {
                this.l = adUnit.getCreate_time();
                if (v.b(Boolean.valueOf(isPreload))) {
                    a((WindAdError) null);
                    return;
                }
                return;
            }
            WindAdError windAdError = WindAdError.ERROR_SIGMOB_FILE_DOWNLOAD;
            windAdError.setMessage(error);
            a(adUnit, "load", adUnit.getAd_type(), adUnit.getAdslot_id(), adUnit.getLoad_id(), windAdError);
            if (v.b(Boolean.valueOf(isPreload))) {
                a(windAdError);
            }
            g();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(LoadAdRequest loadAdRequest) {
        ad.a(PointCategory.RESPOND, "0", loadAdRequest);
    }

    private boolean b(LoadAdRequest request, String traceId) {
        if (!c()) {
            return false;
        }
        BaseAdUnit baseAdUnitE = e();
        if (v.b(baseAdUnitE)) {
            baseAdUnitE.setTraceId(traceId);
            baseAdUnitE.setRequestSceneType(request.getRequest_scene_type());
        }
        this.p.a((Map<String, Object>) null, baseAdUnitE);
        SigmobLog.d("isExistCache: placementId = " + this.i);
        n();
        a((WindAdError) null);
        l(baseAdUnitE);
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void p(BaseAdUnit adUnit) {
        ad.a(PointCategory.LOADSTART, null, adUnit, null, this.m, null);
        com.sigmob.sdk.base.network.h.a(adUnit, "load");
    }

    private void q(BaseAdUnit adUnit) {
        if (adUnit == null || this.m == null) {
            return;
        }
        int playMode = adUnit.getPlayMode();
        if (adUnit.getDisableAutoLoad() || playMode == 0 || !s.a((CharSequence) adUnit.getBid_token()) || adUnit.bidding_response != null) {
            return;
        }
        this.m.setLastCampid(adUnit.getCamp_id());
        this.m.setLastCrid(adUnit.getCrid());
        a(this.m, j.AutoNextPreload);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void t() {
        this.n = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void u() {
        a(this.m, j.AutoNextPreload);
    }

    public String a() {
        return h(this.b == AdStatus.AdStatusPlaying ? this.n : e());
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(int error, String message, String requestId, LoadAdRequest loadAdRequest) {
        b(loadAdRequest);
        ad.a(PointCategory.RESPOND, "0", error, message, loadAdRequest);
        WindAdError windAdError = WindAdError.getWindAdError(error);
        if (windAdError == null) {
            windAdError = WindAdError.ERROR_SIGMOB_REQUEST;
            windAdError.setErrorMessage(error, message);
        }
        b(windAdError);
        a(windAdError);
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit) {
        p(adUnit);
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit, String error) {
        a(adUnit, error, false);
    }

    protected void a(LoadAdRequest loadAdRequest, j sceneType) {
        a(loadAdRequest, sceneType, (String) null, new com.sigmob.sdk.base.network.f.a() { // from class: com.sigmob.sdk.manager.f.2
            @Override // com.sigmob.sdk.base.network.f.a
            public void a(int error, String message, String request_id, LoadAdRequest loadAdRequest2) {
                f.this.b(loadAdRequest2);
                ad.a(PointCategory.RESPOND, "0", error, message, loadAdRequest2);
            }

            @Override // com.sigmob.sdk.base.network.f.a
            public void a(List<BaseAdUnit> adUnits, LoadAdRequest loadAdRequest2) {
                if (com.sigmob.sdk.base.utils.f.a(adUnits)) {
                    return;
                }
                BaseAdUnit baseAdUnit = adUnits.get(0);
                f.this.k = baseAdUnit.getRequestId();
                f.this.o = adUnits;
                f.this.a(adUnits, loadAdRequest2, baseAdUnit);
                int request_scene_type = loadAdRequest2.getRequest_scene_type();
                f.this.a(request_scene_type);
                SigmobLog.d("preloadAdsRequest: sceneType = " + request_scene_type);
                if (v.b(f.this.p) && !f.this.p.a(baseAdUnit)) {
                    f.this.a(WindAdError.ERROR_SIGMOB_INFORMATION_LOSE);
                    return;
                }
                for (BaseAdUnit baseAdUnit2 : f.this.o) {
                    if (b.n(baseAdUnit2)) {
                        h.g().f(baseAdUnit2);
                    }
                }
                int playMode = baseAdUnit.getPlayMode();
                if (playMode != 0) {
                    f.this.l = baseAdUnit.getCreate_time();
                }
                h.a(adUnits);
                h.b bVar = new h.b() { // from class: com.sigmob.sdk.manager.f.2.1
                    @Override // com.sigmob.sdk.base.common.h.b
                    public void a(BaseAdUnit adUnit) {
                        f.this.p(adUnit);
                    }

                    @Override // com.sigmob.sdk.base.common.h.b
                    public void a(BaseAdUnit adUnit, String error) {
                        f.this.a(adUnit, error, true);
                    }
                };
                int creativeType = baseAdUnit.getCreativeType();
                SigmobLog.d("preloadAdsRequest: playMode = " + playMode + ", creativeType = " + creativeType);
                if (creativeType != n.CreativeTypeMRAIDTWO.a()) {
                    if (playMode == 2) {
                        f.this.a(baseAdUnit, loadAdRequest2);
                        return;
                    } else {
                        f.this.p.a(new HashMap(), baseAdUnit);
                        h.g().a(baseAdUnit, bVar);
                        return;
                    }
                }
                boolean zA = new com.sigmob.sdk.base.common.e(adUnits, bVar, f.this.m).a(false);
                SigmobLog.d("preloadAdsRequest: cache = " + zA);
                if (zA) {
                    f.this.p.a(new HashMap(), baseAdUnit);
                } else {
                    f.this.a(baseAdUnit, loadAdRequest2);
                }
            }
        });
    }

    protected void a(LoadAdRequest loadAdRequest, j sceneType, String traceId, com.sigmob.sdk.base.network.f.a listener) {
        g();
        boolean zA = a(sceneType);
        loadAdRequest.setOriginVid(zA ? this.d : "");
        loadAdRequest.setOriginPrice(zA ? this.e : "");
        loadAdRequest.setRequest_scene_type(sceneType.a());
        loadAdRequest.setExpired(d());
        if (!s.b(traceId)) {
            traceId = b.j();
        }
        this.m.setTraceId(traceId);
        a(loadAdRequest);
        com.sigmob.sdk.base.network.f.a(loadAdRequest, listener);
    }

    public void a(LoadAdRequest loadAdRequest, m windAdShowListener) {
        this.r = windAdShowListener;
        this.m = loadAdRequest;
        i iVarP = p();
        if (iVarP == null) {
            return;
        }
        BaseAdUnit baseAdUnitE = e();
        this.n = baseAdUnitE;
        this.j = baseAdUnitE.getRequestId();
        String loadId = this.m.getLoadId();
        String adSceneId = this.m.getAdSceneId();
        String adSceneDesc = this.m.getAdSceneDesc();
        this.n.setLoad_id(loadId);
        this.n.setAd_scene_id(adSceneId);
        this.n.setAd_scene_desc(adSceneDesc);
        SigMacroCommon macroCommon = this.n.getMacroCommon();
        if (s.b(adSceneDesc)) {
            macroCommon.addMarcoKey(SigMacroCommon._ADSCENE_, adSceneDesc);
        }
        if (s.b(adSceneId)) {
            macroCommon.addMarcoKey(SigMacroCommon._ADSCENEID_, adSceneId);
        }
        String video_url = this.n.getVideo_url();
        if (s.b(video_url)) {
            macroCommon.addMarcoKey(SigMacroCommon._VMD5_, h.g().k(this.n.getVideoPath()));
            try {
                macroCommon.addMarcoKey(SigMacroCommon._VURL_, URLEncoder.encode(video_url, "UTF-8"));
            } catch (UnsupportedEncodingException e) {
                SigmobLog.e("show: error = " + e.getMessage());
            }
        }
        boolean z = true;
        if (this.n.getCreativeType() == n.CreativeTypeMRAIDTWO.a()) {
            if (!new com.sigmob.sdk.base.common.e(this.o, this, this.m).a(true)) {
                iVarP.a(new HashMap(), this.n);
            }
        } else if (this.n.getPlayMode() == 2) {
            iVarP.a(new HashMap(), this.n);
            h.g().a(this.n, this);
        }
        Bundle bundle = new Bundle();
        bundle.putBoolean(com.sigmob.sdk.base.n.v, this.m.isEnable_keep_on() || o.a().i());
        if (!this.m.isEnable_screen_lock_displayad() && !o.a().h()) {
            z = false;
        }
        bundle.putBoolean(com.sigmob.sdk.base.n.u, z);
        iVarP.a(this.n, bundle);
        this.b = AdStatus.AdStatusPlaying;
        this.l = 0L;
    }

    public void a(LoadAdRequest request, String traceId) {
        this.b = AdStatus.AdStatusLoading;
        if (request == null || s.a((CharSequence) request.getPlacementId())) {
            SigmobLog.e("loadAd: request or placementId is null.");
            a(WindAdError.ERROR_SIGMOB_PLACEMENTID_EMPTY);
            return;
        }
        try {
            WindAdError sigMobError = Sigmob.getInstance().getSigMobError();
            if (v.b(sigMobError)) {
                SigmobLog.e("loadAd: error = " + sigMobError);
                PointEntitySigmobError.SigmobError("load", sigMobError.getErrorCode(), sigMobError.getMessage()).commit();
                a(sigMobError);
                return;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        if (s.b(request.getBidToken())) {
            g();
        }
        this.i = request.getPlacementId();
        this.m = request;
        if (this.p == null) {
            this.p = o();
        }
        if (b(request, traceId)) {
            return;
        }
        if (s.b(this.j)) {
            h.b(this.j);
        }
        if (s.b(this.k)) {
            h.b(this.k);
        }
        request.setLastCampid(h.g().o());
        request.setLastCrid(h.g().n());
        a(request, j.NormalRequest, traceId, this);
        this.h.sendEmptyMessageDelayed(8193, o.a().v());
    }

    public void a(k windAdLoadListener) {
        this.q = windAdLoadListener;
    }

    protected void a(WindAdError error) {
        if (this.b != AdStatus.AdStatusLoading) {
            return;
        }
        if (error == null) {
            this.b = AdStatus.AdStatusReady;
            a(this);
            a(e(), this.m);
        } else {
            this.b = AdStatus.AdStatusNone;
        }
        String strH = h();
        k kVar = this.q;
        if (kVar == null) {
            return;
        }
        if (error == null) {
            kVar.onAdLoadSuccess(strH);
        } else {
            kVar.onAdLoadError(error, strH);
        }
    }

    public void a(String key, String value) {
        a(this.b == AdStatus.AdStatusPlaying ? this.n : e(), key, value);
    }

    @Override // com.sigmob.sdk.manager.b
    public void a(String originVid, String originPrice, j requestSceneType) {
        super.a(originVid, originPrice, requestSceneType);
        LoadAdRequest loadAdRequestF = f();
        if (loadAdRequestF != null && s.a((CharSequence) loadAdRequestF.getBidToken())) {
            loadAdRequestF.setLastCampid("");
            loadAdRequestF.setLastCrid("");
            a(loadAdRequestF, requestSceneType);
        }
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(List<BaseAdUnit> adUnits, LoadAdRequest loadAdRequest) {
        try {
            if (com.sigmob.sdk.base.utils.f.a(adUnits)) {
                WindAdError windAdError = WindAdError.ERROR_SIGMOB_INFORMATION_LOSE;
                b(windAdError);
                ad.a(PointCategory.RESPOND, "0", windAdError.getErrorCode(), windAdError.getMessage(), loadAdRequest);
                a(windAdError);
                return;
            }
            BaseAdUnit baseAdUnit = adUnits.get(0);
            this.j = baseAdUnit.getRequestId();
            this.o = adUnits;
            a(adUnits, loadAdRequest, baseAdUnit);
            if (this.p == null) {
                this.p = o();
            }
            if (!this.p.a(baseAdUnit)) {
                a(WindAdError.ERROR_SIGMOB_INFORMATION_LOSE);
                return;
            }
            n();
            h.a(adUnits);
            for (BaseAdUnit baseAdUnit2 : this.o) {
                if (n(baseAdUnit2)) {
                    h.g().f(baseAdUnit2);
                }
            }
            int playMode = baseAdUnit.getPlayMode();
            if (playMode != 0) {
                this.l = baseAdUnit.getCreate_time();
                a((WindAdError) null);
            }
            if (baseAdUnit.getCreativeType() == n.CreativeTypeMRAIDTWO.a()) {
                if (new com.sigmob.sdk.base.common.e(adUnits, this, this.m).a(false)) {
                    this.p.a(new HashMap(), baseAdUnit);
                    return;
                }
                return;
            }
            if (playMode == 2) {
                return;
            }
            this.p.a(new HashMap(), baseAdUnit);
            h.g().a(baseAdUnit, this);
        } catch (Throwable th) {
            String message = th.getMessage();
            SigmobLog.e("onSuccess: error = " + message);
            g();
            WindAdError windAdError2 = WindAdError.ERROR_SIGMOB_INFORMATION_LOSE;
            int errorCode = windAdError2.getErrorCode();
            windAdError2.setMessage(message);
            ad.a(PointCategory.RESPOND, "0", errorCode, message, loadAdRequest);
            a(windAdError2);
        }
    }

    public String b() {
        return i(this.b == AdStatus.AdStatusPlaying ? this.n : e());
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit) {
        a("start", adUnit);
        q();
        g();
        b(this);
        if (v.b(this.r)) {
            this.r.onAdShow(this.i);
        }
        if (adUnit == null || this.m == null) {
            return;
        }
        int playMode = adUnit.getPlayMode();
        if (!adUnit.getDisableAutoLoad() && playMode == 0 && s.a((CharSequence) adUnit.getBid_token()) && adUnit.bidding_response == null) {
            this.m.setLastCampid(adUnit.getCamp_id());
            this.m.setLastCrid(adUnit.getCrid());
            this.h.post(new Runnable() { // from class: com.sigmob.sdk.manager.f$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.u();
                }
            });
        }
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit, String errMsg) {
        this.h.removeMessages(8193);
        com.sigmob.sdk.base.utils.k.f(this.f3469a, "onInterstitialFailed: error = " + errMsg, new Object[0]);
        ad.a(PointCategory.LOADEND, "0", adUnit, null, this.m, null);
        com.sigmob.sdk.base.network.h.a(adUnit, com.sigmob.sdk.base.common.a.y);
        g();
        if (adUnit != null && adUnit.getPlayMode() == 0) {
            WindAdError windAdError = WindAdError.ERROR_SIGMOB_FILE_DOWNLOAD;
            windAdError.setMessage(errMsg);
            a(adUnit, "load", adUnit.getAd_type(), adUnit.getAdslot_id(), adUnit.getLoad_id(), windAdError);
            a(windAdError);
        }
    }

    protected void b(WindAdError error) {
        k kVar;
        if (this.b != AdStatus.AdStatusLoading || (kVar = this.q) == null) {
            return;
        }
        kVar.onAdPreLoadFail(error, this.i);
    }

    @Override // com.sigmob.sdk.base.common.p
    public void c(BaseAdUnit adUnit) {
        a("click", adUnit);
        if (v.b(this.r)) {
            this.r.onAdClicked(this.i);
        }
    }

    @Override // com.sigmob.sdk.manager.b
    public boolean c() {
        i iVar;
        BaseAdUnit baseAdUnitE = e();
        if (baseAdUnitE != null && !d() && g(baseAdUnitE) && (iVar = this.p) != null && iVar.a(baseAdUnitE) && h.e(baseAdUnitE.getUuid()) != null) {
            return true;
        }
        if (!v.b(baseAdUnitE)) {
            return false;
        }
        h.g().e(baseAdUnitE);
        return false;
    }

    @Override // com.sigmob.sdk.base.common.p
    public void d(BaseAdUnit adUnit) {
        a("dismissed", (Map<String, String>) null);
        if (this.b == AdStatus.AdStatusClose) {
            return;
        }
        this.b = AdStatus.AdStatusClose;
        if (v.b(this.p)) {
            this.p.b(adUnit);
        }
        r();
        if (v.b(this.r)) {
            this.r.onAdClosed(this.i);
        }
        this.h.post(new Runnable() { // from class: com.sigmob.sdk.manager.f$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.t();
            }
        });
        q(adUnit);
    }

    @Override // com.sigmob.sdk.manager.b
    public boolean d() {
        if (this.l == 0) {
            return false;
        }
        return f(e());
    }

    @Override // com.sigmob.sdk.manager.b
    public BaseAdUnit e() {
        if (com.sigmob.sdk.base.utils.f.a(this.o)) {
            return null;
        }
        return this.o.get(0);
    }

    @Override // com.sigmob.sdk.base.common.p
    public void e(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return;
        }
        h.g().j(adUnit.getCamp_id());
        h.g().i(adUnit.getCrid());
        g();
    }

    @Override // com.sigmob.sdk.manager.b
    public LoadAdRequest f() {
        return this.m;
    }

    @Override // com.sigmob.sdk.manager.b
    public BaseAdUnit i() {
        return this.n;
    }

    public Map<String, BiddingResponse> m() {
        return j(this.b == AdStatus.AdStatusPlaying ? this.n : e());
    }

    protected void n() {
        k kVar;
        if (this.b != AdStatus.AdStatusLoading || (kVar = this.q) == null) {
            return;
        }
        kVar.onAdPreLoadSuccess(this.i);
    }

    public abstract i o();

    public void o(BaseAdUnit adUnit) {
        if (v.b(this.r)) {
            this.r.onVideoAdPlayEnd(this.i);
        }
    }

    /* JADX WARN: Code duplicated, block: B:30:0x0057  */
    /* JADX WARN: Code duplicated, block: B:32:0x0067  */
    protected i p() {
        String message;
        String str;
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_AD_PLAY_CHECK_FAIL;
        BaseAdUnit baseAdUnitE = e();
        boolean z = false;
        if (this.b == AdStatus.AdStatusPlaying) {
            message = WindAdError.ERROR_SIGMOB_AD_PLAY_HAS_PLAYING.getMessage();
        } else if (this.o == null || baseAdUnitE == null) {
            message = "not ready adUnit";
        } else {
            if (this.b == AdStatus.AdStatusReady) {
                if (this.p == null) {
                    message = "interstitial object is null";
                } else if (d()) {
                    windAdError = WindAdError.ERROR_SIGMOB_EXPIRED;
                } else {
                    if (!g(baseAdUnitE)) {
                        str = "check ad unit endcard is invalid";
                    } else if (this.p.a(baseAdUnitE)) {
                        z = true;
                    } else {
                        str = "check ad unit info is invalid";
                    }
                    windAdError.setMessage(str);
                }
                if (!z) {
                    return this.p;
                }
                a(windAdError, this.r);
                b(this);
                ad.a(PointCategory.PLAY, windAdError, baseAdUnitE, this.m);
                return null;
            }
            message = "ad status is not ready";
        }
        windAdError.setMessage(message);
        baseAdUnitE = null;
        if (!z) {
            return this.p;
        }
        a(windAdError, this.r);
        b(this);
        ad.a(PointCategory.PLAY, windAdError, baseAdUnitE, this.m);
        return null;
    }

    protected void q() {
    }

    protected void r() {
    }

    public void s() {
        a(g.b, (Map<String, String>) null);
        if (s.b(this.j)) {
            h.b(this.j);
        }
        if (s.b(this.k)) {
            h.b(this.k);
        }
        g();
        this.q = null;
        this.r = null;
        this.n = null;
        this.h.removeCallbacksAndMessages(null);
        b(this);
    }
}
