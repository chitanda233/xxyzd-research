package com.sigmob.sdk.splash;

import android.content.Context;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.common.utils.TouchLocation;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.SplashAdSetting;

/* JADX INFO: loaded from: classes4.dex */
public class a extends com.sigmob.sdk.base.common.i {
    private int l = 3;
    private boolean m;

    public static a d(BaseAdUnit adUnit) {
        a aVar = new a();
        aVar.b(adUnit);
        return aVar;
    }

    @Override // com.sigmob.sdk.base.common.i
    public void a(Context context, TouchLocation down, TouchLocation up, com.sigmob.sdk.base.a clickUIType, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
        com.sigmob.sdk.base.network.h.a(adUnit, "click");
    }

    @Override // com.sigmob.sdk.base.common.i
    public void b(Context context, int contentPlayHead, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null.");
        ad.a("close", (String) null, adUnit, (ad.a) null);
        com.sigmob.sdk.base.network.h.a(adUnit, com.sigmob.sdk.base.common.a.u);
    }

    @Override // com.sigmob.sdk.base.common.i
    public void b(BaseAdUnit adUnit) {
        super.b(adUnit);
        SplashAdSetting splashAdSetting = adUnit.getSplashAdSetting();
        if (splashAdSetting == null) {
            return;
        }
        this.l = splashAdSetting.show_duration.intValue();
        this.m = splashAdSetting.enable_close_on_click.booleanValue();
    }

    @Override // com.sigmob.sdk.base.common.i
    public void c(Context context, int contentPlayHead, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null.");
        ad.a("skip", (String) null, adUnit, (ad.a) null);
        com.sigmob.sdk.base.network.h.a(adUnit, "skip");
    }

    public int l() {
        return this.l;
    }

    public boolean m() {
        return this.m;
    }
}
