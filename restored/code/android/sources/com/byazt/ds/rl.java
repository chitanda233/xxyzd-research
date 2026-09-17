package com.byazt.ds;

import android.content.Context;
import android.telephony.TelephonyManager;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, 117})
public class rl extends ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final x f807a;
    public final Context n;

    public rl(Context context, x xVar) {
        super(true, false);
        this.n = context;
        this.f807a = xVar;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException, SecurityException {
        TelephonyManager telephonyManager = (TelephonyManager) this.n.getSystemService("phone");
        if (telephonyManager != null) {
            try {
                i.c(jSONObject, "carrier", telephonyManager.getNetworkOperatorName());
                i.c(jSONObject, "mcc_mnc", telephonyManager.getNetworkOperator());
                i.c(jSONObject, "udid", this.f807a.aw() ? com.byazt.yv.a.c(telephonyManager) : this.f807a.bx());
                return true;
            } catch (Exception e) {
                com.byazt.yv.da.tt(e);
            }
        }
        return false;
    }
}
