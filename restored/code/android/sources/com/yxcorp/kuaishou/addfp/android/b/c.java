package com.yxcorp.kuaishou.addfp.android.b;

import android.text.TextUtils;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    boolean f4082a;
    int b;
    boolean c;
    String d;

    c(String str) {
        this.f4082a = true;
        if (TextUtils.isEmpty(str)) {
            this.f4082a = false;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            this.b = jSONObject.optInt(MediationConstant.KEY_ERROR_CODE, 2);
            this.c = jSONObject.optBoolean("userSet", true);
            this.d = jSONObject.optString("value", "KWE_OTHER");
        } catch (JSONException e) {
            this.f4082a = false;
            e.printStackTrace();
        }
    }

    public String a(boolean z) {
        if (!this.f4082a) {
            return "KWE_OTHER";
        }
        if (z != this.c) {
            return "KWE_NPN";
        }
        int i = this.b;
        if (i == 0) {
            return !TextUtils.isEmpty(this.d) ? this.d : "KWE_N";
        }
        if (i == 1) {
            return "KWE_PN";
        }
        if (i == 2) {
            return "KWE_PE";
        }
        if (i != 3) {
            return i != 4 ? "KWE_OTHER" : "KWE_NS";
        }
        return "KWE_N";
    }
}
