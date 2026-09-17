package com.kwai.adclient.kscommerciallogger.snapshot;

import java.util.LinkedHashMap;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private final String buZ;
    private final LinkedHashMap<String, String> bva = new LinkedHashMap<>();
    private final long time = System.nanoTime();

    d(String str) {
        this.buZ = str;
    }

    synchronized JSONObject Yx() {
        JSONObject jSONObject;
        jSONObject = new JSONObject();
        try {
            for (Map.Entry<String, String> entry : this.bva.entrySet()) {
                jSONObject.put(entry.getKey(), entry.getValue());
            }
            jSONObject.put("time", this.time);
            jSONObject.put("span_name", this.buZ);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }
}
