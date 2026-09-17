package com.sigmob.sdk.splash;

import android.content.Context;
import android.widget.RelativeLayout;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;

/* JADX INFO: loaded from: classes4.dex */
class b extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected int f3616a;

    public b(Context context) {
        super(context);
    }

    public static b a(Context context, BaseAdUnit adUnit) {
        MaterialMeta material;
        if (context == null || adUnit == null || (material = adUnit.getMaterial()) == null || material.creative_type == null) {
            return null;
        }
        return material.creative_type.intValue() == n.CreativeTypeSplashVideo.a() ? new h(context, adUnit) : new c(context);
    }

    public void a() {
        setVisibility(0);
    }

    public boolean a(BaseAdUnit adUnit) {
        return false;
    }

    public void b() {
    }

    public void c() {
    }

    public int getDuration() {
        return this.f3616a;
    }

    public void setAspectRatio(float aspectRatio) {
    }
}
