package com.kwad.components.core.g;

import android.app.KeyguardManager;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.util.Pair;
import android.view.WindowManager;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.k.a.d;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.SystemUtil;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.be;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.s;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.commercial.c.a {
    public int RT;
    public boolean RU;
    public boolean RV;
    public boolean RX;
    public String RY;
    public boolean RZ;
    public long Sb;
    public double Sc;
    public boolean Sd;
    public List<String> Se;
    public double Sf;
    public int Sg;
    public int Sh;
    public int Si;
    public int Sj;
    public int defaultType;
    public int RW = -1;
    public int Sa = -1;
    private boolean Sk = false;
    private boolean Sl = false;
    private boolean Sm = false;
    private Context mContext = ServiceProvider.Um();

    private b() {
    }

    public static b qU() {
        b bVar = new b();
        bVar.RT = bt.er(bVar.mContext);
        bVar.RY = ap(bVar.mContext);
        bVar.RW = as(bVar.mContext);
        bVar.RZ = qV();
        bVar.Sa = SystemUtil.eq(bVar.mContext);
        bVar.Sb = bt.es(bVar.mContext);
        bVar.Sc = SystemUtil.ep(bVar.mContext);
        bVar.Sj = aq(bVar.mContext);
        bVar.Sh = getScreenHeight(bVar.mContext);
        bVar.Si = getScreenWidth(bVar.mContext);
        a(bVar);
        bVar.defaultType = 1;
        return bVar;
    }

    private static void a(b bVar) {
        try {
            String strKZ = e.KZ();
            if (TextUtils.isEmpty(strKZ)) {
                return;
            }
            JSONObject jSONObject = new JSONObject(strKZ);
            if (jSONObject.optBoolean("enableSlidingTrajectory", false)) {
                Pair<List<String>, Double> pairIV = com.kwad.sdk.core.e.IV();
                bVar.Se = (List) pairIV.first;
                bVar.Sf = ((Double) pairIV.second).doubleValue();
                bVar.Sk = true;
            }
            if (jSONObject.optBoolean("enableAccessibility", false)) {
                bVar.RU = ((Boolean) bt.eE(bVar.mContext).first).booleanValue();
                bVar.RV = ((Boolean) bt.eE(bVar.mContext).second).booleanValue();
                bVar.Sl = true;
            }
            if (jSONObject.optBoolean("enableKeyguardSecure", false)) {
                bVar.Sd = ar(bVar.mContext);
                bVar.Sm = true;
            }
        } catch (Throwable th) {
            c.printStackTrace(th);
        }
    }

    private static String ap(Context context) {
        int iE = aq.e(context, bf.dS(context), be.useNetworkStateDisable());
        if (iE == 1) {
            return "CMCC";
        }
        if (iE != 2) {
            return iE != 3 ? "unknown" : "CUCC";
        }
        return "CTCC";
    }

    private static int getScreenWidth(Context context) {
        if (context == null) {
            return 0;
        }
        WindowManager windowManager = (WindowManager) context.getSystemService("window");
        DisplayMetrics displayMetrics = new DisplayMetrics();
        windowManager.getDefaultDisplay().getMetrics(displayMetrics);
        return displayMetrics.widthPixels;
    }

    private static int getScreenHeight(Context context) {
        if (context == null) {
            return 0;
        }
        WindowManager windowManager = (WindowManager) context.getSystemService("window");
        DisplayMetrics displayMetrics = new DisplayMetrics();
        windowManager.getDefaultDisplay().getRealMetrics(displayMetrics);
        return displayMetrics.heightPixels;
    }

    private static int aq(Context context) {
        if (context == null) {
            return -1;
        }
        return context.getResources().getDisplayMetrics().densityDpi;
    }

    private static boolean ar(Context context) {
        try {
            KeyguardManager keyguardManager = (KeyguardManager) context.getSystemService("keyguard");
            if (keyguardManager != null) {
                return keyguardManager.isKeyguardSecure();
            }
            return false;
        } catch (Throwable th) {
            c.printStackTrace(th);
            return false;
        }
    }

    private static boolean qV() {
        d dVarUN = s.UN();
        return dVarUN != null && dVarUN.bmw == 1;
    }

    public final b aI(boolean z) {
        this.RX = z;
        return this;
    }

    public final b aK(int i) {
        this.Sg = i;
        return this;
    }

    private static int as(Context context) {
        if (e.al(512L)) {
            return -1;
        }
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction("android.intent.action.ACTION_POWER_CONNECTED");
        intentFilter.addAction("android.intent.action.ACTION_POWER_DISCONNECTED");
        intentFilter.addAction("android.intent.action.BATTERY_CHANGED");
        try {
            Intent intentRegisterReceiver = context.registerReceiver(null, intentFilter);
            if (intentRegisterReceiver == null) {
                return -1;
            }
            int intExtra = intentRegisterReceiver.getIntExtra("plugged", -1);
            int i = 2;
            if (intExtra != 2) {
                i = 1;
                if (intExtra != 1) {
                    i = 4;
                    if (intExtra != 4) {
                        return intExtra == 0 ? 0 : -1;
                    }
                }
            }
            return i;
        } catch (Exception e) {
            c.printStackTrace(e);
            return -1;
        }
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        return b(this);
    }

    private static JSONObject b(b bVar) {
        JSONObject jSONObject = new JSONObject();
        try {
            ac.putValue(jSONObject, "c_batterylevel", bVar.RT);
            ac.putValue(jSONObject, "c_charging", bVar.RW);
            ac.putValue(jSONObject, "is_cheat_user", bVar.RX);
            ac.putValue(jSONObject, "c_operator", bVar.RY);
            ac.putValue(jSONObject, "t_root", bVar.RZ);
            ac.putValue(jSONObject, "c_screenlight", bVar.Sa);
            ac.putValue(jSONObject, "c_total_memory", bVar.Sb);
            ac.putValue(jSONObject, "c_volume", bVar.Sc);
            ac.putValue(jSONObject, "c_screen_height", bVar.Sh);
            ac.putValue(jSONObject, "c_screen_width", bVar.Si);
            ac.putValue(jSONObject, "density_dpi", bVar.Sj);
            ac.putValue(jSONObject, "default_type", bVar.defaultType);
            if (bVar.Sk) {
                if (!bVar.Se.isEmpty()) {
                    ac.putValue(jSONObject, "s_origin_points", bVar.Se);
                }
                double d = bVar.Sf;
                if (d != 0.0d) {
                    ac.putValue(jSONObject, "s_swipe_max_curvature", d);
                }
            }
            if (bVar.Sl) {
                ac.putValue(jSONObject, "t_accessibility_enabled", bVar.RU);
                ac.putValue(jSONObject, "t_accessibility_service_existed", bVar.RV);
            }
            if (bVar.Sm) {
                ac.putValue(jSONObject, "t_is_keyguard_secure", bVar.Sd);
            }
        } catch (Throwable th) {
            c.printStackTrace(th);
        }
        return jSONObject;
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        a(this, jSONObject);
    }

    private static void a(b bVar, JSONObject jSONObject) {
        if (jSONObject != null) {
            try {
                bVar.RT = jSONObject.optInt("c_batterylevel");
                bVar.RU = jSONObject.optBoolean("t_accessibility_enabled");
                bVar.RV = jSONObject.optBoolean("t_accessibility_service_existed");
                bVar.RW = jSONObject.optInt("c_charging");
                bVar.RX = jSONObject.optBoolean("is_cheat_user");
                bVar.RY = jSONObject.optString("c_operator");
                bVar.RZ = jSONObject.optBoolean("t_root");
                bVar.Sa = jSONObject.optInt("c_screenlight");
                bVar.Sb = jSONObject.optLong("c_total_memory");
                bVar.Sc = jSONObject.optDouble("c_volume");
                bVar.Sd = jSONObject.optBoolean("t_is_keyguard_secure");
                bVar.Se = ac.h(jSONObject.optJSONArray("s_origin_points"));
                bVar.Sf = jSONObject.optDouble("s_swipe_max_curvature");
                bVar.Sj = jSONObject.optInt("density_dpi");
                bVar.Sh = jSONObject.optInt("c_screen_height");
                bVar.Si = jSONObject.optInt("c_screen_width");
                bVar.defaultType = jSONObject.optInt("default_type");
            } catch (Throwable th) {
                c.printStackTrace(th);
            }
        }
    }
}
