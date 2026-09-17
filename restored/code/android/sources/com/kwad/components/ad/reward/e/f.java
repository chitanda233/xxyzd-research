package com.kwad.components.ad.reward.e;

import com.kwad.sdk.api.KsRewardVideoAd;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private static final HashMap<String, f> vg = new HashMap<>();
    private KsRewardVideoAd.RewardAdInteractionListener mInteractionListener;
    private com.kwad.components.core.j.d se;
    private KsRewardVideoAd.RewardAdInteractionListener vh;

    private static f L(String str) {
        return vg.get(str);
    }

    public static void a(String str, KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListener, com.kwad.components.core.j.d dVar) {
        f fVar = new f();
        fVar.mInteractionListener = rewardAdInteractionListener;
        fVar.se = dVar;
        fVar.vh = rewardAdInteractionListener;
        vg.put(str, fVar);
    }

    public static KsRewardVideoAd.RewardAdInteractionListener M(String str) {
        f fVarL = L(str);
        if (fVarL != null) {
            return fVarL.vh;
        }
        return null;
    }

    public static void N(String str) {
        f fVarL = L(str);
        if (fVarL != null) {
            fVarL.vh = fVarL.mInteractionListener;
        }
    }

    public static com.kwad.components.core.j.d O(String str) {
        f fVarL = L(str);
        if (fVarL != null) {
            return fVarL.se;
        }
        return null;
    }

    public static void P(String str) {
        f fVarL = L(str);
        if (fVarL != null) {
            fVarL.destroy();
            vg.put(str, null);
        }
    }

    private void destroy() {
        this.mInteractionListener = null;
        this.vh = null;
        com.kwad.components.core.j.d dVar = this.se;
        if (dVar != null) {
            dVar.destroy();
            this.se = null;
        }
    }
}
