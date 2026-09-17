package com.byazt.whk;

import com.byazt.nys.PluginConstants;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 908, 91})
public class sp {
    public JSONObject c;

    public sp(JSONObject jSONObject) {
        this.c = jSONObject;
    }

    public String toString() {
        JSONObject jSONObject = this.c;
        return jSONObject != null ? jSONObject.toString() : "pitaya error is null";
    }

    public int c() {
        JSONObject jSONObject = this.c;
        if (jSONObject != null) {
            return jSONObject.optInt(PluginConstants.KEY_ERROR_CODE, -1);
        }
        return -1;
    }
}
