package com.unicom.online.account.kernel;

import android.text.TextUtils;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class av {
    public bn b = null;

    public final void b(String str, String str2, String str3) {
        try {
            if (this.b == null) {
                return;
            }
            if (bh.b(str3).booleanValue()) {
                str3 = bp.c();
            }
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("resultCode", 100);
            jSONObject.put("resultMsg", str);
            jSONObject.put("seq", str3);
            if (TextUtils.isEmpty(str2)) {
                jSONObject.put("resultData", "");
            } else {
                try {
                    jSONObject.put("resultData", new JSONObject(str2));
                } catch (JSONException unused) {
                    jSONObject.put("resultData", str2);
                }
            }
            this.b.b(jSONObject.toString());
            this.b = null;
        } catch (Exception e) {
            as.b(e);
        }
    }

    public final void b(int i, int i2, String str, String str2, String str3) {
        try {
            if (this.b == null) {
                return;
            }
            if (bh.b(str3).booleanValue()) {
                str3 = bp.c();
            }
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("resultCode", i2);
            jSONObject.put("resultMsg", str);
            jSONObject.put("resultData", str2);
            jSONObject.put("seq", str3);
            this.b.b(jSONObject.toString());
            this.b = null;
        } catch (Exception e) {
            as.b(e);
        }
    }
}
