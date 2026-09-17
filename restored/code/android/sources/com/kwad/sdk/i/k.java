package com.kwad.sdk.i;

import java.util.Iterator;
import java.util.UUID;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
final class k implements b {
    public JSONObject biP = new JSONObject();
    public String actionId = UUID.randomUUID().toString();

    public k(String str, String str2, i iVar) {
        JSONObject jSONObjectRV = h.RZ().Sd().RV();
        Iterator<String> itKeys = jSONObjectRV.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            c.a(jSONObjectRV, next, jSONObjectRV.opt(next));
        }
        c.putValue(this.biP, "customKey", str);
        c.putValue(this.biP, "customValue", str2);
        c.putValue(this.biP, com.alipay.sdk.m.x.a.k, iVar.biM);
        c.putValue(this.biP, "actionId", this.actionId);
    }

    @Override // com.kwad.sdk.i.b
    public final JSONObject toJson() {
        return this.biP;
    }

    public final String toString() {
        return this.biP.toString();
    }
}
