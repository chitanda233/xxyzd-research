package com.sigmob.sdk.base.models;

/* JADX INFO: loaded from: classes3.dex */
public class WindAdMetaData {
    private String adId;

    private WindAdMetaData() {
    }

    private WindAdMetaData(String adId) {
        this.adId = adId;
    }

    public static WindAdMetaData create(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return null;
        }
        return new WindAdMetaData(adUnit.getVid());
    }

    public String getAdId() {
        return this.adId;
    }
}
