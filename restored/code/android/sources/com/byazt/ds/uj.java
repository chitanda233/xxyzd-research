package com.byazt.ds;

import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, 15})
public class uj extends ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final x f810a;
    public final Context n;

    public uj(Context context, x xVar) {
        super(true, false);
        this.n = context;
        this.f810a = xVar;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException, SecurityException {
        jSONObject.put("os", Constants.LOG_OS);
        jSONObject.put("os_version", Build.VERSION.RELEASE);
        jSONObject.put("os_api", Build.VERSION.SDK_INT);
        jSONObject.put("device_model", com.byazt.yv.c.n());
        jSONObject.put("device_brand", Build.BRAND);
        jSONObject.put("device_manufacturer", com.byazt.yv.c.a());
        jSONObject.put("cpu_abi", Build.CPU_ABI);
        jSONObject.put("build_serial", this.f810a.aw() ? c(this.n) : this.f810a.sv());
        return true;
    }

    private static String c(Context context) {
        String serial = null;
        if (context == null) {
            return null;
        }
        if (context.getApplicationInfo().targetSdkVersion >= 26) {
            try {
                serial = Build.getSerial();
            } catch (Throwable unused) {
            }
        }
        if (TextUtils.isEmpty(serial) || TextUtils.equals(serial, "unknown")) {
            serial = Build.SERIAL;
        }
        return (TextUtils.isEmpty(serial) || TextUtils.equals(serial, "unknown")) ? "" : serial;
    }
}
