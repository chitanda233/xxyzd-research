package com.kwad.sdk.i;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
final class i implements b {
    public double aJX;
    public String biJ;
    public String biK;
    public String biL;
    public long biM = System.currentTimeMillis();

    public static i Si() {
        return new i();
    }

    public final i gV(String str) {
        this.biJ = str;
        return this;
    }

    public final i gW(String str) {
        this.biK = str;
        return this;
    }

    public final i gX(String str) {
        this.biL = str;
        return this;
    }

    public final i l(double d) {
        this.aJX = d;
        return this;
    }

    @Override // com.kwad.sdk.i.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        c.a(jSONObject, com.sigmob.sdk.base.n.C, Double.valueOf(this.aJX));
        c.a(jSONObject, "ratio_count", Double.valueOf(j.m(this.aJX)));
        c.putValue(jSONObject, "log_build_time_ms", this.biM);
        c.putValue(jSONObject, "log_level", this.biJ);
        c.putValue(jSONObject, "log_tag", this.biK);
        c.putValue(jSONObject, "log_content", this.biL);
        return jSONObject;
    }
}
