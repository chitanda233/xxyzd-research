package com.sigmob.sdk.nativead;

import android.content.Context;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.TouchLocation;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.NativeAdSetting;
import com.sigmob.sdk.base.models.rtb.SingleNativeAdSetting;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class e extends com.sigmob.sdk.base.common.i {
    private int l;
    private int m;
    private int n;
    private int o;
    private int p;
    private int q;
    private boolean r;
    private Boolean s;

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(int i, int i2, int i3, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put("video_time", String.valueOf(i));
            options.put("begin_time", String.valueOf(i2));
            options.put("end_time", String.valueOf(i3));
            options.put("is_first", String.valueOf(i2 == 0 ? 1 : 0));
            options.put("is_last", String.valueOf(i3 < i + (-1000) ? 0 : 1));
            pointEntitySigmob.setOptions(options);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(int i, int i2, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put("video_time", String.valueOf(i));
            options.put("begin_time", String.valueOf(i2));
            pointEntitySigmob.setOptions(options);
        }
    }

    public static e d(BaseAdUnit adUnit) {
        e eVar = new e();
        eVar.b(adUnit);
        return eVar;
    }

    @Override // com.sigmob.sdk.base.common.i
    public void a(Context context, TouchLocation down, TouchLocation up, com.sigmob.sdk.base.a clickUIType, BaseAdUnit adUnit) {
        String coordinate;
        SigMacroCommon macroCommon = adUnit.getMacroCommon();
        if (macroCommon == null) {
            coordinate = "";
        } else {
            macroCommon.updateClickMarco(down, up);
            coordinate = macroCommon.getCoordinate();
        }
        a(clickUIType, coordinate, true);
    }

    public void a(BaseAdUnit adUnit, final int currentPosition, final int duration) {
        com.sigmob.sdk.base.common.ad.a("video_start", (String) null, adUnit, new com.sigmob.sdk.base.common.ad.a() { // from class: com.sigmob.sdk.nativead.e$$ExternalSyntheticLambda1
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                e.a(currentPosition, duration, obj);
            }
        });
        SigMacroCommon macroCommon = adUnit.getMacroCommon();
        macroCommon.addMarcoKey(SigMacroCommon._VIDEOTIME_, String.valueOf(duration));
        macroCommon.addMarcoKey(SigMacroCommon._BEGINTIME_, String.valueOf(currentPosition));
        com.sigmob.sdk.base.network.h.a(adUnit, "video_start");
    }

    public void a(BaseAdUnit adUnit, final int endTime, final int currentPosition, final int duration) {
        com.sigmob.sdk.base.common.ad.a("video_pause", (String) null, adUnit, new com.sigmob.sdk.base.common.ad.a() { // from class: com.sigmob.sdk.nativead.e$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                e.a(duration, currentPosition, endTime, obj);
            }
        });
        SigMacroCommon macroCommon = adUnit.getMacroCommon();
        macroCommon.addMarcoKey(SigMacroCommon._VIDEOTIME_, String.valueOf(duration));
        macroCommon.addMarcoKey(SigMacroCommon._BEGINTIME_, String.valueOf(currentPosition));
        macroCommon.addMarcoKey(SigMacroCommon._ENDTIME_, String.valueOf(endTime));
        macroCommon.addMarcoKey(SigMacroCommon._PLAYFIRSTFRAME_, String.valueOf(currentPosition == 0 ? 1 : 0));
        macroCommon.addMarcoKey(SigMacroCommon._ENDTIME_, String.valueOf(endTime));
        macroCommon.addMarcoKey(SigMacroCommon._ENDTIME_, String.valueOf(endTime));
        com.sigmob.sdk.base.network.h.a(adUnit, "video_pause");
    }

    public void a(boolean isMute) {
        this.s = Boolean.valueOf(isMute);
    }

    @Override // com.sigmob.sdk.base.common.i
    public void b(BaseAdUnit adUnit) {
        super.b(adUnit);
        NativeAdSetting nativeAdSetting = adUnit.getNativeAdSetting();
        SingleNativeAdSetting singleNativeSetting = adUnit.getSingleNativeSetting();
        if (singleNativeSetting != null) {
            this.r = singleNativeSetting.use_na_video_component.booleanValue();
        }
        if (nativeAdSetting != null) {
            this.m = nativeAdSetting.preview_page_video_mute.intValue();
            this.n = nativeAdSetting.detail_page_video_mute.intValue();
            this.o = nativeAdSetting.impression_percent.intValue();
            this.p = nativeAdSetting.impression_time.intValue();
            this.l = nativeAdSetting.video_auto_play.intValue();
            this.q = nativeAdSetting.end_impression_time.intValue();
        }
        ArrayList arrayList = new ArrayList();
        arrayList.add(new com.sigmob.sdk.videoAd.d(com.sigmob.sdk.base.common.a.k, 0.25f));
        arrayList.add(new com.sigmob.sdk.videoAd.d(com.sigmob.sdk.base.common.a.m, 0.5f));
        arrayList.add(new com.sigmob.sdk.videoAd.d(com.sigmob.sdk.base.common.a.n, 0.75f));
        a((List<com.sigmob.sdk.videoAd.d>) arrayList);
    }

    public void c(Context context, BaseAdUnit adUnit) {
        com.sigmob.sdk.base.common.ad.a(PointCategory.TEMPLATE_SHOW, (String) null, adUnit, (com.sigmob.sdk.base.common.ad.a) null);
    }

    public void d(Context context, BaseAdUnit adUnit) {
        com.sigmob.sdk.base.common.ad.a(PointCategory.TEMPLATE_CLOSE, (String) null, adUnit, (com.sigmob.sdk.base.common.ad.a) null);
    }

    public void e(Context context, BaseAdUnit adUnit) {
        com.sigmob.sdk.base.common.ad.a("ad_show", (String) null, adUnit, (com.sigmob.sdk.base.common.ad.a) null);
        com.sigmob.sdk.base.network.h.a(adUnit, "ad_show");
    }

    public void f(Context context, BaseAdUnit adUnit) {
        com.sigmob.sdk.base.common.ad.a("feed_click", (String) null, adUnit, (com.sigmob.sdk.base.common.ad.a) null);
        com.sigmob.sdk.base.network.h.a(adUnit, "feed_click");
    }

    public boolean l() {
        return this.r;
    }

    public int m() {
        return this.l;
    }

    public boolean n() {
        Boolean bool = this.s;
        if (bool != null) {
            return bool.booleanValue();
        }
        return this.m == 0;
    }

    public boolean o() {
        return this.n != 0;
    }

    public int p() {
        return this.o;
    }

    public int q() {
        return this.p;
    }

    public int r() {
        return this.q;
    }

    public int s() {
        int i = this.o;
        if (i >= 0) {
            return i;
        }
        return 50;
    }

    public int t() {
        int i = this.p;
        if (i >= 0) {
            return i;
        }
        return 1;
    }

    public boolean u() {
        int iM = m();
        if (iM != 0) {
            return iM == 1 && ClientMetadata.getInstance().getActiveNetworkType() == 100;
        }
        return true;
    }
}
