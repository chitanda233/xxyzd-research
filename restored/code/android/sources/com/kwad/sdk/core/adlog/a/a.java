package com.kwad.sdk.core.adlog.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public JSONObject aLM;
    public com.kwad.sdk.core.adlog.c.a aLN;
    public long aLO;
    public int aLP;
    public String aLQ;
    public int retryCount;
    public String url;

    public static a Jg() {
        return new a();
    }

    public final a dU(String str) {
        this.url = str;
        return this;
    }

    public final a j(JSONObject jSONObject) {
        this.aLM = jSONObject;
        return this;
    }

    public final a c(com.kwad.sdk.core.adlog.c.a aVar) {
        this.aLN = aVar;
        return this;
    }

    public final a av(long j) {
        this.aLO = j;
        return this;
    }

    public final a dz(int i) {
        this.aLP = i;
        return this;
    }

    public final a dV(String str) {
        this.aLQ = str;
        return this;
    }

    public final String toString() {
        return "AdLogCache {actionType=" + this.aLN.aKK + ", retryCount=" + this.retryCount + ", retryErrorCode=" + this.aLP + ", retryErrorMsg=" + this.aLQ + '}';
    }
}
