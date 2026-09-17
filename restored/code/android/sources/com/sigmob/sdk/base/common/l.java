package com.sigmob.sdk.base.common;

import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.VideoStatusCommon;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public abstract class l implements u {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected final String f3185a = getClass().getSimpleName();

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(HashMap map, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            if (com.sigmob.sdk.base.utils.f.b(map)) {
                pointEntitySigmob.getOptions().putAll(map);
            }
        }
    }

    protected void a(BaseAdUnit adUnit, String event, String sub, final HashMap<String, String> options) {
        ad.a(event, sub, adUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.l$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                l.a(options, obj);
            }
        });
    }

    protected void a(BaseAdUnit adUnit, String event, boolean isMulti, String category) {
        SigMacroCommon macroCommon = adUnit.getMacroCommon();
        VideoStatusCommon videoCommon = adUnit.getVideoCommon();
        macroCommon.addMarcoKey(SigMacroCommon._VIDEOTIME_, String.valueOf(videoCommon.video_time));
        macroCommon.addMarcoKey(SigMacroCommon._BEGINTIME_, String.valueOf(videoCommon.begin_time));
        macroCommon.addMarcoKey(SigMacroCommon._ENDTIME_, String.valueOf(videoCommon.end_time));
        macroCommon.addMarcoKey(SigMacroCommon._PLAYFIRSTFRAME_, String.valueOf(videoCommon.is_first));
        macroCommon.addMarcoKey(SigMacroCommon._PLAYLASTFRAME_, String.valueOf(videoCommon.is_last));
        macroCommon.addMarcoKey(SigMacroCommon._SCENE_, String.valueOf(videoCommon.scene));
        macroCommon.addMarcoKey(SigMacroCommon._TYPE_, String.valueOf(videoCommon.type));
        macroCommon.addMarcoKey(SigMacroCommon._BEHAVIOR_, String.valueOf(videoCommon.is_auto_play));
        macroCommon.addMarcoKey(SigMacroCommon._STATUS_, String.valueOf(videoCommon.status));
        com.sigmob.sdk.base.network.h.a(adUnit, event, isMulti);
        HashMap<String, String> map = new HashMap<>();
        map.put("video_time", String.valueOf(videoCommon.video_time));
        map.put("begin_time", String.valueOf(videoCommon.begin_time));
        map.put("end_time", String.valueOf(videoCommon.end_time));
        map.put("is_first", String.valueOf(videoCommon.is_first));
        map.put("scene", String.valueOf(videoCommon.scene));
        map.put("type", String.valueOf(videoCommon.type));
        map.put("is_auto_play", String.valueOf(videoCommon.is_auto_play));
        map.put("status", String.valueOf(videoCommon.status));
        a(adUnit, category, (String) null, map);
    }

    @Override // com.sigmob.sdk.base.common.u
    public boolean a(BaseAdUnit adUnit) {
        return true;
    }

    @Override // com.sigmob.sdk.base.common.u
    public boolean a(BaseAdUnit adUnit, int duration, int endTime) {
        return false;
    }

    @Override // com.sigmob.sdk.base.common.u
    public boolean a(BaseAdUnit adUnit, boolean isForceShow, int playHeadMillis) {
        return false;
    }
}
