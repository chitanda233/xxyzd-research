package com.sigmob.sdk.mraid;

import android.os.Bundle;
import android.text.TextUtils;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class i extends com.sigmob.sdk.base.common.y {
    protected i(com.sigmob.sdk.base.common.p customEventInterstitialListener) {
        super(customEventInterstitialListener);
    }

    protected static boolean a(MaterialMeta material) {
        return material.creative_type.intValue() == com.sigmob.sdk.base.common.n.CreativeTypeMRAID.a() && (!TextUtils.isEmpty(material.html_url) || (material.html_snippet != null && material.html_snippet.size() > 10));
    }

    public static boolean c(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return false;
        }
        return (adUnit.getMaterial() == null || TextUtils.isEmpty(adUnit.getCrid())) ? false : true;
    }

    @Override // com.sigmob.sdk.base.common.y
    protected void a(com.sigmob.sdk.base.common.p customEventInterstitialListener) {
        this.f3205a = customEventInterstitialListener;
    }

    @Override // com.sigmob.sdk.base.common.y
    public void a(BaseAdUnit adUnit, Bundle option) {
        List<BaseAdUnit> listE;
        if (adUnit.getCreativeType() == com.sigmob.sdk.base.common.n.CreativeTypeMRAIDTWO.a() && (listE = com.sigmob.sdk.base.common.h.e(adUnit.getUuid())) == null) {
            com.sigmob.sdk.mraid2.b.a().a(adUnit.getUuid(), new com.sigmob.sdk.mraid2.e(com.sigmob.sdk.b.e(), listE));
        }
        super.a(adUnit, option);
    }

    @Override // com.sigmob.sdk.base.common.y
    public boolean a(BaseAdUnit adUnit) {
        return c(adUnit);
    }
}
