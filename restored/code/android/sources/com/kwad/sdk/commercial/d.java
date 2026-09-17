package com.kwad.sdk.commercial;

import com.kwai.adclient.kscommerciallogger.model.BusinessType;
import com.kwai.adclient.kscommerciallogger.model.SubBusinessType;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public double aJO = 0.01d;
    public double aJP = 1.0d;
    public double aJQ = 0.001d;
    public BusinessType aJR = BusinessType.OTHER;
    public SubBusinessType aJS = SubBusinessType.OTHER;
    public com.kwai.adclient.kscommerciallogger.model.d aJT;
    public String category;
    public String eventId;
    public JSONObject msg;
    public String primaryKey;
    public String tag;

    private d() {
    }

    public static d Iz() {
        return new d();
    }

    public final d g(double d) {
        this.aJO = d;
        return this;
    }

    public final d h(double d) {
        this.aJP = d;
        return this;
    }

    public final d i(double d) {
        this.aJQ = 0.001d;
        return this;
    }

    public final d dm(String str) {
        this.category = str;
        return this;
    }

    public final d P(String str, String str2) {
        this.eventId = str;
        this.primaryKey = str2;
        return this;
    }

    public final d b(BusinessType businessType) {
        this.aJR = businessType;
        return this;
    }

    public final d a(SubBusinessType subBusinessType) {
        this.aJS = subBusinessType;
        return this;
    }

    public final d dn(String str) {
        this.tag = str;
        return this;
    }

    @Deprecated
    public final d i(JSONObject jSONObject) {
        this.msg = jSONObject;
        return this;
    }

    public final d A(com.kwad.sdk.commercial.c.a aVar) {
        this.msg = aVar.toJson();
        return this;
    }

    public final d a(com.kwai.adclient.kscommerciallogger.model.d dVar) {
        this.aJT = dVar;
        return this;
    }

    public final String toString() {
        return "ReportItem{category='" + this.category + "', eventId='" + this.eventId + "', bizType='" + this.aJR + "', primaryKey='" + this.primaryKey + "', msg=" + this.msg + '}';
    }
}
