package com.cmic.gen.sdk.d;

import androidx.core.app.NotificationCompat;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: LogBeanEx.java */
/* JADX INFO: loaded from: classes2.dex */
public class c extends b {
    public static ArrayList<Throwable> b = new ArrayList<>();
    private JSONObject c = null;
    private JSONArray d;

    public void a(JSONObject jSONObject) {
        this.c = jSONObject;
    }

    @Override // com.cmic.gen.sdk.d.b
    public void a(JSONArray jSONArray) {
        this.d = jSONArray;
    }

    @Override // com.cmic.gen.sdk.d.b, com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObjectB = super.b();
        try {
            jSONObjectB.put(NotificationCompat.CATEGORY_EVENT, this.c);
            jSONObjectB.put("exceptionStackTrace", this.d);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObjectB;
    }
}
