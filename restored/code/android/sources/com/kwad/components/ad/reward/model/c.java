package com.kwad.components.ad.reward.model;

import android.content.Intent;
import android.text.TextUtils;
import com.kwad.components.ad.reward.KSRewardVideoActivityProxy;
import com.kwad.components.core.c.f;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdGlobalConfigInfo;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ac;
import java.io.File;
import java.io.Serializable;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private AdInfo mAdInfo;
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private JSONObject mReportExtData;
    public int mScreenOrientation;
    private KsVideoPlayConfig mVideoPlayConfig;
    private int rewardType = 1;
    public final boolean jE = com.kwad.components.ad.reward.a.b.hX();

    public static c a(Intent intent) {
        KsVideoPlayConfig ksVideoPlayConfigB;
        if (e.KN()) {
            ksVideoPlayConfigB = com.kwad.components.core.internal.api.e.b(intent.getStringExtra("key_video_play_config_json"), true);
        } else {
            Serializable serializableExtra = intent.getSerializableExtra("key_video_play_config");
            if (!(serializableExtra instanceof KsVideoPlayConfig)) {
                com.kwad.sdk.core.d.c.e("RewardActivityModel", "data is not instanceof VideoPlayConfigImpl:" + serializableExtra);
                return null;
            }
            ksVideoPlayConfigB = (KsVideoPlayConfig) serializableExtra;
        }
        int intExtra = intent.getIntExtra(KSRewardVideoActivityProxy.KEY_REWARD_TYPE, 1);
        try {
            AdResultData adResultDataD = f.oR().d(intent.getIntExtra("key_ad_result_cache_idx", 0), true);
            if (adResultDataD == null) {
                return null;
            }
            return a(adResultDataD, intExtra, ksVideoPlayConfigB);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return null;
        }
    }

    private static c a(AdResultData adResultData, int i, KsVideoPlayConfig ksVideoPlayConfig) {
        c cVar = new c();
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        if (adTemplateR == null) {
            com.kwad.sdk.core.d.c.e("RewardActivityModel", "data is null:");
            return null;
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplateR);
        if (!c(adTemplateR, adInfoEM)) {
            return null;
        }
        boolean zIsShowLandscape = ksVideoPlayConfig.isShowLandscape();
        adTemplateR.mInitVoiceStatus = ksVideoPlayConfig.isVideoSoundEnable() ? 2 : 1;
        if (!TextUtils.isEmpty(ksVideoPlayConfig.getShowScene())) {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "ext_showscene", ksVideoPlayConfig.getShowScene());
            cVar.mReportExtData = jSONObject;
        }
        cVar.mVideoPlayConfig = ksVideoPlayConfig;
        cVar.mAdResultData = adResultData;
        cVar.mAdTemplate = adTemplateR;
        cVar.mAdInfo = adInfoEM;
        cVar.mScreenOrientation = zIsShowLandscape ? 1 : 0;
        cVar.rewardType = i;
        return cVar;
    }

    private static boolean c(AdTemplate adTemplate, AdInfo adInfo) {
        if (!e.KN() && com.kwad.sdk.core.response.helper.e.fc(adTemplate) < 0) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(com.kwad.sdk.core.response.helper.a.M(adInfo));
            if (fileCM == null || !fileCM.exists()) {
                return false;
            }
        }
        return true;
    }

    public final boolean iC() {
        return com.kwad.sdk.core.response.helper.e.m(getAdTemplate(), com.kwad.components.ad.reward.a.b.l(cW()));
    }

    public final boolean iE() {
        return com.kwad.sdk.core.response.helper.e.O(getAdTemplate());
    }

    public final boolean cX() {
        return com.kwad.sdk.core.response.helper.e.eY(this.mAdTemplate);
    }

    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    public final AdResultData iF() {
        return this.mAdResultData;
    }

    public final AdInfo cW() {
        return this.mAdInfo;
    }

    public final KsVideoPlayConfig iG() {
        return this.mVideoPlayConfig;
    }

    public final int iH() {
        return this.rewardType;
    }

    public final int getScreenOrientation() {
        return this.mScreenOrientation;
    }

    public final JSONObject iI() {
        return this.mReportExtData;
    }

    public final AdGlobalConfigInfo iJ() {
        AdResultData adResultData = this.mAdResultData;
        if (adResultData != null) {
            return adResultData.adGlobalConfigInfo;
        }
        return null;
    }
}
