package com.sigmob.sdk.newInterstitial;

import android.os.Bundle;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.common.AdActivity;
import com.sigmob.sdk.base.common.TransparentAdActivity;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.common.p;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class f extends com.sigmob.sdk.mraid.i {
    protected f(p customEventInterstitialListener) {
        super(customEventInterstitialListener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, Object obj) {
        Map<String, String> options;
        if (!(obj instanceof PointEntitySigmob) || (options = ((PointEntitySigmob) obj).getOptions()) == null) {
            return;
        }
        options.put("show_count", String.valueOf(com.sigmob.sdk.base.common.h.h(str)));
        com.sigmob.sdk.base.common.h.g(str);
    }

    private static boolean b(MaterialMeta material) {
        return material.creative_type.intValue() == n.CreativeTypeMRAIDTWO.a();
    }

    private static boolean c(MaterialMeta material) {
        return material.creative_type.intValue() == n.CreativeTypeNewInterstitial.a() && material.template_id.intValue() != 0;
    }

    public static boolean d(BaseAdUnit baseAdUnit) {
        boolean zC = c(baseAdUnit);
        MaterialMeta material = baseAdUnit.getMaterial();
        return zC && (b(material) || c(material));
    }

    @Override // com.sigmob.sdk.mraid.i, com.sigmob.sdk.base.common.y
    protected void a(p customEventInterstitialListener) {
        super.a(customEventInterstitialListener);
    }

    @Override // com.sigmob.sdk.mraid.i, com.sigmob.sdk.base.common.y
    public void a(BaseAdUnit baseAdUnit, Bundle option) {
        com.sigmob.sdk.base.common.h.a(baseAdUnit);
        super.a(baseAdUnit, option);
        if (this.f3205a instanceof e) {
            NewInterstitialAdBroadcastReceiver newInterstitialAdBroadcastReceiver = new NewInterstitialAdBroadcastReceiver(baseAdUnit, (e) this.f3205a, baseAdUnit.getUuid());
            newInterstitialAdBroadcastReceiver.a(newInterstitialAdBroadcastReceiver);
        }
        int ad_type = baseAdUnit.getAd_type();
        String str = BaseAdActivity.j;
        if (ad_type == 6) {
            if (baseAdUnit.getCreativeType() == n.CreativeTypeMRAIDTWO.a()) {
                str = BaseAdActivity.d;
            } else {
                n.CreativeTypeNewInterstitial.a();
            }
        }
        final String adslot_id = baseAdUnit.getAdslot_id();
        ad.a(PointCategory.VOPEN, null, baseAdUnit, null, null, new ad.a() { // from class: com.sigmob.sdk.newInterstitial.f$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                f.a(adslot_id, obj);
            }
        });
        AdActivity.a(com.sigmob.sdk.b.e(), (baseAdUnit.getMaterial().theme_data.intValue() == 1 || baseAdUnit.getTemplateType() == 1) ? TransparentAdActivity.class : AdActivity.class, baseAdUnit.getUuid(), option, str);
    }

    @Override // com.sigmob.sdk.mraid.i, com.sigmob.sdk.base.common.y
    public boolean a(BaseAdUnit baseAdUnit) {
        boolean zA = super.a(baseAdUnit);
        MaterialMeta material = baseAdUnit.getMaterial();
        return zA && (b(material) || c(material));
    }
}
