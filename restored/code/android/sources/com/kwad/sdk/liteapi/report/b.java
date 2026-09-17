package com.kwad.sdk.liteapi.report;

import android.os.Build;
import com.kwad.sdk.liteapi.LiteApiLogger;
import com.kwad.sdk.liteapi.LiteOAIDHelper;
import java.util.Locale;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
final class b {
    public String Nh;
    public String Ni;
    public String Nj;
    public String aRa;
    public String aWZ;
    public int aqA;
    public String aqB;
    public int aqy;

    b() {
    }

    public static b RR() {
        b bVar = new b();
        try {
            bVar.aRa = LiteOAIDHelper.obtainCurrent();
            bVar.aqA = Build.VERSION.SDK_INT;
            bVar.Nj = Build.VERSION.RELEASE;
            bVar.aqy = 1;
            bVar.aqB = Locale.getDefault().getLanguage();
            bVar.aWZ = Build.MANUFACTURER;
            bVar.Nh = Build.MODEL;
            bVar.Ni = Build.BRAND;
        } catch (Throwable unused) {
        }
        return bVar;
    }

    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt("oaid", this.aRa);
        } catch (JSONException e) {
            LiteApiLogger.printStackTrace(e);
        }
        return jSONObject;
    }
}
