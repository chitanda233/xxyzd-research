package com.sigmob.sdk.base.common;

import android.text.TextUtils;
import android.util.Log;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class e implements h.b {
    private final List<BaseAdUnit> b;
    private final h.b c;
    private final LoadAdRequest d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f3167a = "AdListCacheManger";
    private final List<BaseAdUnit> e = new ArrayList();

    public e(List<BaseAdUnit> adUnits, h.b listener, LoadAdRequest loadAdRequest) {
        this.b = adUnits;
        this.c = listener;
        this.d = loadAdRequest;
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.a(adUnit);
        }
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit, String message) {
        if (com.sigmob.sdk.base.utils.f.a(this.b)) {
            return;
        }
        BaseAdUnit baseAdUnit = this.b.get(0);
        if (adUnit != baseAdUnit) {
            com.sigmob.sdk.base.network.h.a(adUnit, TextUtils.isEmpty(message) ? a.x : a.y);
            ad.a(PointCategory.LOADEND, TextUtils.isEmpty(message) ? "1" : "0", adUnit, null, this.d, null);
        } else {
            if (com.sigmob.sdk.base.utils.v.b(this.c)) {
                this.c.a(baseAdUnit, message);
            }
            Log.d("AdListCacheManger", "loadEnd: size = " + this.e.size());
        }
    }

    public boolean a(boolean showAd) {
        if (com.sigmob.sdk.base.utils.f.b(this.b)) {
            if (showAd) {
                BaseAdUnit baseAdUnit = this.b.get(0);
                if (baseAdUnit.getPlayMode() == 2) {
                    this.e.add(baseAdUnit);
                    h.g().a(baseAdUnit, this);
                }
            } else {
                for (int i = 0; i < this.b.size(); i++) {
                    BaseAdUnit baseAdUnit2 = this.b.get(i);
                    if (baseAdUnit2.getPlayMode() != 2) {
                        this.e.add(baseAdUnit2);
                        baseAdUnit2.setCatchVideo(true);
                        h.g().a(baseAdUnit2, this);
                    }
                }
            }
            Log.d("AdListCacheManger", "cacheList: size = " + this.e.size());
        }
        return com.sigmob.sdk.base.utils.f.b(this.e);
    }
}
