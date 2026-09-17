package com.sigmob.sdk.base.common;

import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.mta.PointFiveEntity;
import com.sigmob.windad.WindAdRequest;

/* JADX INFO: loaded from: classes3.dex */
public class al {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3150a;
    private String b;
    private String c;
    private String d;
    private WindAdRequest e;
    private LoadAdRequest f;
    private ad.a g;
    private BaseAdUnit h;

    private al() {
    }

    public static al a(String category) {
        al alVar = new al();
        alVar.f3150a = category;
        return alVar;
    }

    public al a(ad.a extraInfo) {
        this.g = extraInfo;
        return this;
    }

    public al a(BaseAdUnit adUnit) {
        this.h = adUnit;
        return this;
    }

    public al a(LoadAdRequest loadAdRequest) {
        this.f = loadAdRequest;
        return this;
    }

    public al a(WindAdRequest windAdRequest) {
        this.e = windAdRequest;
        return this;
    }

    public void a() {
        PointFiveEntity pointFiveEntity = new PointFiveEntity();
        pointFiveEntity.setAc_type("5");
        pointFiveEntity.setCategory(this.f3150a);
        pointFiveEntity.setSub_category(this.b);
        if (com.sigmob.sdk.base.utils.s.b(this.c)) {
            pointFiveEntity.setAdtype(this.c);
        }
        ad.a(this.f3150a, this.b, pointFiveEntity, this.e);
        ad.a(this.f3150a, this.b, pointFiveEntity, this.f);
        ad.a(this.f3150a, this.b, this.h, pointFiveEntity);
        if (com.sigmob.sdk.base.utils.v.b(this.g)) {
            this.g.onAddExtra(pointFiveEntity);
        }
        ad.a(pointFiveEntity);
        pointFiveEntity.commit();
    }

    public al b(String ad_type) {
        this.c = ad_type;
        return this;
    }

    public al c(String subCategory) {
        this.b = subCategory;
        return this;
    }

    public al d(String placementId) {
        this.d = placementId;
        return this;
    }
}
