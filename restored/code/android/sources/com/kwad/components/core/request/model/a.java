package com.kwad.components.core.request.model;

import android.text.TextUtils;
import com.kwad.components.core.request.j;
import com.kwad.sdk.commercial.convert.e;
import com.kwad.sdk.core.response.model.AdResultData;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public final ImpInfo abv;
    public final com.kwad.components.core.request.c ajM;
    public j ajN;
    public List<String> ajO;
    public boolean ajP;
    public boolean ajQ;
    public c ajR;
    private String ajS;

    /* synthetic */ a(C0459a c0459a, byte b) {
        this(c0459a);
    }

    public static void a(a aVar, AdResultData adResultData, boolean z) {
        e.a(aVar.abv.adScene, aVar.wo(), adResultData.getAdSource());
        if (adResultData.isAdResultDataEmpty()) {
            aVar.ajM.a(com.kwad.sdk.core.network.e.aTe.errorCode, TextUtils.isEmpty(adResultData.testErrorMsg) ? com.kwad.sdk.core.network.e.aTe.msg : adResultData.testErrorMsg, z);
        } else {
            aVar.ajM.a(adResultData, z);
        }
    }

    public static void a(a aVar, int i, String str, boolean z) {
        aVar.ajM.a(i, str, z);
        e.a(aVar.getAdStyle(), i, str, aVar.wo());
    }

    private a(C0459a c0459a) {
        this.abv = c0459a.abv;
        this.ajM = c0459a.ajM;
        this.ajP = c0459a.ajP;
        this.ajQ = c0459a.ajQ;
        this.ajN = c0459a.ajT;
    }

    public final long getPosId() {
        if (this.abv.adScene != null) {
            return this.abv.adScene.getPosId();
        }
        return -1L;
    }

    public final int getAdNum() {
        if (this.abv.adScene != null) {
            return this.abv.adScene.getAdNum();
        }
        return 1;
    }

    public final j wn() {
        return this.ajN;
    }

    public final int getAdStyle() {
        if (this.abv.adScene != null) {
            return this.abv.adScene.adStyle;
        }
        return 0;
    }

    public final String wo() {
        return !TextUtils.isEmpty(this.ajS) ? this.ajS : "network_only";
    }

    public final void bg(String str) {
        this.ajS = str;
    }

    /* JADX INFO: renamed from: com.kwad.components.core.request.model.a$a, reason: collision with other inner class name */
    public static class C0459a {
        public ImpInfo abv;
        public com.kwad.components.core.request.c ajM;
        public boolean ajP;
        public boolean ajQ;
        public j ajT;

        public final C0459a e(ImpInfo impInfo) {
            this.abv = impInfo;
            return this;
        }

        public final C0459a aY(boolean z) {
            this.ajP = true;
            return this;
        }

        public final C0459a aZ(boolean z) {
            this.ajQ = z;
            return this;
        }

        public final C0459a a(com.kwad.components.core.request.c cVar) {
            this.ajM = cVar;
            return this;
        }

        public final C0459a a(j jVar) {
            this.ajT = jVar;
            return this;
        }

        public final a wp() {
            if (com.kwad.components.ad.f.a.oV.booleanValue() && (this.abv == null || this.ajM == null)) {
                throw new IllegalStateException("AdRequestParams build Illegal");
            }
            return new a(this, (byte) 0);
        }
    }
}
