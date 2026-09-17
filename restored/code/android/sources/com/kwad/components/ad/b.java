package com.kwad.components.ad;

import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class b implements com.kwad.components.core.internal.api.a {
    public com.kwad.components.core.internal.api.c bz = new com.kwad.components.core.internal.api.c();
    protected final AdResultData mAdResultData;
    protected final AdTemplate mAdTemplate;

    @Override // com.kwad.components.core.internal.api.a
    public final boolean supportPushAd() {
        return true;
    }

    public b(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    public boolean isVideo() {
        return com.kwad.sdk.core.response.helper.a.bi(e.eM(this.mAdTemplate));
    }

    public int getECPM() {
        return com.kwad.sdk.core.response.helper.a.aX(e.eM(this.mAdTemplate));
    }

    public void setBidEcpm(int i) {
        setBidEcpm(i, -1L);
    }

    public void setBidEcpm(long j, long j2) {
        this.mAdTemplate.mBidEcpm = j;
        com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, j);
    }

    public Map<String, Object> getMediaExtraInfo() {
        HashMap map = new HashMap();
        if (com.kwad.sdk.core.config.e.Ka()) {
            map.put("llsid", Long.valueOf(this.mAdTemplate.llsid));
        }
        return map;
    }

    public void reportAdExposureFailed(int i, AdExposureFailedReason adExposureFailedReason) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, i, adExposureFailedReason);
    }

    public int getMaterialType() {
        return com.kwad.sdk.core.response.helper.a.bk(e.eM(this.mAdTemplate));
    }

    public int getInteractionType() {
        return com.kwad.sdk.core.response.helper.a.aW(e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.components.core.internal.api.a
    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void a(com.kwad.components.core.internal.api.b bVar) {
        this.bz.a(bVar);
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void b(com.kwad.components.core.internal.api.b bVar) {
        this.bz.b(bVar);
    }
}
