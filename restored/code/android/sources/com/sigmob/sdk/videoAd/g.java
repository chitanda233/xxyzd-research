package com.sigmob.sdk.videoAd;

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
import com.sigmob.sdk.base.utils.s;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class g extends com.sigmob.sdk.mraid.i {
    private RewardVideoAdBroadcastReceiver c;
    private final boolean d;

    public g(p listener, boolean isHalfInterstitial) {
        super(listener);
        this.d = isHalfInterstitial;
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
        return (material.creative_type.intValue() == n.CreativeTypeVideo_Tar.a()) && s.b(material.endcard_md5) && s.b(material.endcard_url) && s.b(material.video_url);
    }

    private static boolean c(MaterialMeta material) {
        return (material.creative_type.intValue() == n.CreativeTypeVideo_Html_Snippet.a() || material.creative_type.intValue() == n.CreativeTypeVideo_transparent_html.a()) && (material.html_snippet != null && material.html_snippet.size() > 10) && s.b(material.video_url);
    }

    public static boolean d(BaseAdUnit baseAdUnit) {
        boolean zA;
        boolean zC = c(baseAdUnit);
        MaterialMeta material = baseAdUnit.getMaterial();
        if (baseAdUnit.getCreativeType() == n.CreativeTypeMRAID.a()) {
            zA = a(material);
        } else {
            zA = b(material) || c(material) || d(material);
        }
        return zC && zA;
    }

    private static boolean d(MaterialMeta material) {
        return (material.creative_type.intValue() == n.CreativeTypeVideo_EndCardURL.a()) && s.b(material.html_url) && s.b(material.video_url);
    }

    /* JADX WARN: Code duplicated, block: B:14:0x0046  */
    @Override // com.sigmob.sdk.mraid.i, com.sigmob.sdk.base.common.y
    public void a(BaseAdUnit baseAdUnit, Bundle option) {
        String str;
        com.sigmob.sdk.base.common.h.a(baseAdUnit);
        super.a(baseAdUnit, option);
        if (this.f3205a instanceof h) {
            RewardVideoAdBroadcastReceiver rewardVideoAdBroadcastReceiver = new RewardVideoAdBroadcastReceiver(baseAdUnit, (h) this.f3205a, baseAdUnit.getUuid());
            this.c = rewardVideoAdBroadcastReceiver;
            rewardVideoAdBroadcastReceiver.a(rewardVideoAdBroadcastReceiver);
        }
        int ad_type = baseAdUnit.getAd_type();
        if (ad_type != 1 && ad_type != 4) {
            str = "reward";
        } else if (baseAdUnit.getCreativeType() == n.CreativeTypeMRAID.a()) {
            str = BaseAdActivity.c;
        } else if (baseAdUnit.getCreativeType() == n.CreativeTypeMRAIDTWO.a()) {
            str = BaseAdActivity.d;
        } else {
            str = "reward";
        }
        if (option != null) {
            option.putBoolean(com.sigmob.sdk.base.n.y, this.d);
        }
        final String adslot_id = baseAdUnit.getAdslot_id();
        ad.a(PointCategory.VOPEN, null, baseAdUnit, null, null, new ad.a() { // from class: com.sigmob.sdk.videoAd.g$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                g.a(adslot_id, obj);
            }
        });
        AdActivity.a(com.sigmob.sdk.b.e(), ((ad_type == 4 && (baseAdUnit.getMaterial().theme_data.intValue() == 1 || this.d)) || (baseAdUnit.getCreativeType() == n.CreativeTypeMRAIDTWO.a() && (baseAdUnit.getMaterial().theme_data.intValue() == 1 || baseAdUnit.getTemplateType() == 1))) ? TransparentAdActivity.class : AdActivity.class, baseAdUnit.getUuid(), option, str);
    }

    /* JADX WARN: Code duplicated, block: B:7:0x0023  */
    @Override // com.sigmob.sdk.mraid.i, com.sigmob.sdk.base.common.y
    public boolean a(BaseAdUnit baseAdUnit) {
        boolean zA;
        boolean zA2 = super.a(baseAdUnit);
        MaterialMeta material = baseAdUnit.getMaterial();
        int creativeType = baseAdUnit.getCreativeType();
        if (creativeType == n.CreativeTypeMRAID.a()) {
            zA = a(material);
        } else if (creativeType == n.CreativeTypeMRAIDTWO.a()) {
            zA = true;
        } else {
            boolean zB = b(material);
            boolean zC = c(material);
            boolean zD = d(material);
            if (zB || zC || zD) {
                zA = true;
            } else {
                zA = false;
            }
        }
        return zA2 && zA;
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    @Override // com.sigmob.sdk.base.common.y
    public void b(BaseAdUnit baseAdUnit) {
        RewardVideoAdBroadcastReceiver rewardVideoAdBroadcastReceiver = this.c;
        if (rewardVideoAdBroadcastReceiver != null) {
            rewardVideoAdBroadcastReceiver.b(rewardVideoAdBroadcastReceiver);
            this.c = null;
        }
        super.b(baseAdUnit);
    }
}
