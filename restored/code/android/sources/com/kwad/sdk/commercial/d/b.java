package com.kwad.sdk.commercial.d;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKu;
    public String aKv;

    public static b ID() {
        return new b();
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: cf, reason: merged with bridge method [inline-methods] */
    public final b setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        return this;
    }

    public final b du(String str) {
        this.aKu = str;
        return this;
    }

    public final b dv(String str) {
        this.aKv = str;
        return this;
    }
}
