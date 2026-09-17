package com.byazt.aas;

import com.sigmob.sdk.base.mta.PointCategory;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 131, 67})
public class u {
    public static boolean c() {
        long jCurrentTimeMillis = System.currentTimeMillis();
        JSONObject jSONObjectGx = com.byazt.omf.gt.tt().gx();
        if (jSONObjectGx == null) {
            return false;
        }
        return jCurrentTimeMillis >= jSONObjectGx.optLong("start", 1707480000000L) && jCurrentTimeMillis <= jSONObjectGx.optLong(PointCategory.END, 1707498000000L);
    }

    public static boolean tt() {
        JSONObject jSONObjectGx = com.byazt.omf.gt.tt().gx();
        return jSONObjectGx != null && c() && jSONObjectGx.optInt("force_drop", 0) == 1;
    }
}
