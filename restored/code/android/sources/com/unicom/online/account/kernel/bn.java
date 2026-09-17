package com.unicom.online.account.kernel;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import com.unicom.online.account.shield.ResultListener;
import com.unicom.online.account.shield.UniAccountHelper;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class bn {
    public final /* synthetic */ int b;
    public final /* synthetic */ String c;
    public final /* synthetic */ int d;
    public final /* synthetic */ ResultListener e;
    public final /* synthetic */ UniAccountHelper f;

    public bn(UniAccountHelper uniAccountHelper, int i, String str, int i2, ResultListener resultListener) {
        this.f = uniAccountHelper;
        this.b = i;
        this.c = str;
        this.d = i2;
        this.e = resultListener;
    }

    public final void b(String str) {
        String strB;
        bp.e().getClass();
        boolean z = ap.b;
        try {
            try {
                JSONObject jSONObject = new JSONObject(str);
                String strOptString = jSONObject.optString("seq");
                int i = jSONObject.getInt("resultCode");
                String string = jSONObject.getString("resultMsg");
                String str2 = "";
                if (i != 100) {
                    if (z) {
                        int i2 = i == 410000 ? 2 : 3;
                        bp bpVarE = bp.e();
                        int i3 = this.d;
                        bpVarE.getClass();
                        strB = bp.b(1, i2, strOptString, i, i3, i, string);
                        str2 = strB;
                    }
                }
                JSONObject jSONObject2 = jSONObject.getJSONObject("resultData");
                jSONObject2.optString("fakeMobile");
                jSONObject2.optString("accessCode");
                jSONObject2.getLong("exp");
                System.currentTimeMillis();
                TextUtils.isEmpty(jSONObject.optString("operator"));
                int i4 = this.b;
                if (4 == i4 || 5 == i4) {
                    jSONObject2.put("fakeMobile", (Object) null);
                }
                if (this.f.getUseCacheFlag()) {
                    bp bpVarE2 = bp.e();
                    Context contextC = l.c();
                    int i5 = this.b;
                    bpVarE2.getClass();
                    String str3 = (i5 == 2 || i5 == 3 || i5 == 4 || i5 == 5) ? "T" + i5 : "";
                    if (contextC != null) {
                        be.b(contextC, "AC_" + str3 + "_Token__isOk_");
                    }
                    bp bpVarE3 = bp.e();
                    Context contextC2 = l.c();
                    int i6 = this.b;
                    String str4 = this.c;
                    String string2 = jSONObject.toString();
                    bpVarE3.getClass();
                    bp.b(i6, contextC2, str4, string2);
                }
                if (z) {
                    bp bpVarE4 = bp.e();
                    int i7 = this.d;
                    bpVarE4.getClass();
                    strB = bp.b(0, 0, strOptString, i, i7, i, string);
                    str2 = strB;
                }
                ar.b(jSONObject.toString());
                if (ap.f) {
                    new Handler(Looper.getMainLooper()).post(new bm(this, jSONObject));
                } else {
                    this.e.onResult(jSONObject.toString());
                }
                if (z) {
                    bp.e().getClass();
                    an.b(bp.b(), str2);
                }
            } catch (JSONException e) {
                if (ar.b) {
                    e.printStackTrace();
                }
            }
        } finally {
            l.b();
        }
    }
}
