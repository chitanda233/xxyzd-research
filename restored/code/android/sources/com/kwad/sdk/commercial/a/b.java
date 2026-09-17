package com.kwad.sdk.commercial.a;

import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKa;
    public String aKb;
    public String aKc;
    public long aKd;
    public long aKe;
    public int aKf;
    public int aKg;
    public String downloadId;
    public long downloadTime;
    public int status;
    public String url;

    public static b IA() {
        return new b();
    }

    public final b dk(int i) {
        this.status = i;
        return this;
    }

    public final b au(long j) {
        this.downloadTime = j;
        return this;
    }

    public final b dl(int i) {
        this.aKf = i;
        return this;
    }

    public final b dm(int i) {
        this.aKg = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: bF, reason: merged with bridge method [inline-methods] */
    public final b setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        AdInfo adInfoEM = e.eM(adTemplate);
        this.url = e.eP(adTemplate);
        try {
            this.aKa = new URL(this.url).getHost();
        } catch (Throwable unused) {
        }
        this.downloadId = adInfoEM.downloadId;
        this.aKb = adInfoEM.adBaseInfo.appPackageName;
        this.aKc = adInfoEM.adBaseInfo.appName;
        this.aKd = adInfoEM.totalBytes;
        this.aKe = adInfoEM.soFarBytes;
        return this;
    }
}
