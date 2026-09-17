package com.qq.gdt.action;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.Build;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import com.byazt.tk.AdBaseConstants;
import com.bykv.vk.component.ttvideo.LiveConfigKey;
import com.bytedance.pangle.provider.ContentProviderManager;
import com.qq.gdt.action.i.h;
import com.qq.gdt.action.i.i;
import com.qq.gdt.action.i.m;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.p;
import com.qq.gdt.action.i.r;
import com.qq.gdt.action.i.t;
import com.qq.gdt.action.i.u;
import com.qq.gdt.action.i.v;
import com.qq.gdt.action.i.x;
import com.qq.gdt.action.i.y;
import java.util.Iterator;
import java.util.List;
import java.util.Locale;
import javax.crypto.SecretKey;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String f3024a;

    public static com.qq.gdt.action.b.a a(String str, JSONObject jSONObject) {
        JSONObject jSONObjectD = d(jSONObject, d.a().g());
        return new com.qq.gdt.action.b.a(d.a().l(), com.qq.gdt.action.i.b.b(str), System.currentTimeMillis(), jSONObjectD, d.a().m());
    }

    public static String a(String str) {
        String strA = u.a(str);
        String strH = d.a().h();
        String strI = d.a().i();
        String strA2 = i.a(d.a().j().getEncoded());
        return r.a(strA + "," + strA2 + "," + u.a(strA + strH + strI + strA2));
    }

    public static String a(JSONObject jSONObject) throws Exception {
        return a(jSONObject, d.a().j());
    }

    public static String a(JSONObject jSONObject, SecretKey secretKey) throws Exception {
        return com.qq.gdt.action.i.a.a(secretKey, y.a(jSONObject.toString().getBytes()));
    }

    public static JSONArray a(List<com.qq.gdt.action.b.a> list) throws JSONException {
        JSONArray jSONArray = new JSONArray();
        Iterator<com.qq.gdt.action.b.a> it = list.iterator();
        while (it.hasNext()) {
            jSONArray.put(a(it.next()));
        }
        return jSONArray;
    }

    public static JSONObject a() throws JSONException {
        JSONObject jSONObject = new JSONObject();
        Context contextG = d.a().g();
        c(jSONObject, contextG);
        b(jSONObject, contextG);
        a(jSONObject, contextG);
        d(jSONObject);
        c(jSONObject);
        b(jSONObject);
        e(jSONObject);
        jSONObject.putOpt("conf_version", b.a(contextG).a());
        x.a(jSONObject, contextG);
        jSONObject.putOpt("ak", d.a().i());
        return jSONObject;
    }

    private static JSONObject a(com.qq.gdt.action.b.a aVar) throws JSONException {
        if (aVar == null) {
            return null;
        }
        if (v.a(aVar.c())) {
            o.b("ActionType must not be empty.");
            return null;
        }
        Context contextG = d.a().g();
        JSONObject jSONObject = new JSONObject();
        jSONObject.putOpt("session_id", aVar.g());
        jSONObject.putOpt("action_time", Long.valueOf(aVar.d() / 1000));
        jSONObject.putOpt("action_time_mills", Long.valueOf(aVar.d()));
        if (aVar.c().equals("TENCENT_INNER_START_APP")) {
            jSONObject.putOpt("action_type", ActionType.START_APP);
            jSONObject.putOpt("is_sdk_auto_track", true);
        } else {
            jSONObject.putOpt("action_type", aVar.c());
        }
        jSONObject.putOpt("revised_action_time", Long.valueOf(aVar.h()));
        jSONObject.putOpt("retry", Boolean.valueOf(aVar.i() == 2));
        jSONObject.putOpt("action_id", aVar.a());
        jSONObject.putOpt("action_log_id", Long.valueOf(aVar.b()));
        JSONObject jSONObjectE = aVar.e();
        if (jSONObjectE != null && jSONObjectE.has(ActionParam.Key.OUTER_ACTION_ID)) {
            jSONObject.putOpt(ActionParam.Key.OUTER_ACTION_ID, jSONObjectE.optString(ActionParam.Key.OUTER_ACTION_ID));
            jSONObjectE.remove(ActionParam.Key.OUTER_ACTION_ID);
        }
        jSONObject.putOpt("action_param", jSONObjectE);
        if (ActionType.START_APP.equals(aVar.c()) || "TENCENT_INNER_START_APP".equals(aVar.c())) {
            JSONObject jSONObject2 = new JSONObject();
            try {
                long jD = t.d(contextG);
                long jE = t.e(contextG);
                long jC = t.c(contextG);
                boolean zA = t.a(contextG);
                boolean zB = t.b(contextG);
                if (jD > 0) {
                    jSONObject2.putOpt("ams_reserved_last_start_time", Long.valueOf(jD));
                }
                if (jE > 0) {
                    jSONObject2.putOpt("ams_reserved_last_revised_start_time", Long.valueOf(jE));
                }
                if (jC > 0) {
                    jSONObject2.putOpt("ams_reserved_last_revised_activate_time", Long.valueOf(jC));
                }
                jSONObject2.putOpt("ams_reserved_last_revised_with_imei", Boolean.valueOf(zA));
                jSONObject2.putOpt("ams_reserved_last_revised_with_oaid", Boolean.valueOf(zB));
            } catch (JSONException e) {
                o.a("JSON exception while add last start time info.", e);
            }
            jSONObject.putOpt("inner_action_param", jSONObject2);
        }
        return jSONObject;
    }

    private static void a(JSONObject jSONObject, Context context) throws JSONException {
        Object objA = h.a();
        Object objC = h.c(context);
        Object objA2 = h.a(context);
        int iB = h.b(context);
        jSONObject.putOpt("pkg_name", objA);
        jSONObject.putOpt(ContentProviderManager.PLUGIN_PROCESS_NAME, d.a().p());
        jSONObject.putOpt("appn", objC);
        jSONObject.putOpt("app_version_name", objA2);
        jSONObject.putOpt("gk", com.qq.gdt.action.i.d.e());
        jSONObject.putOpt("app_version_code", String.valueOf(iB));
        jSONObject.putOpt("channel", d.a().q());
        jSONObject.putOpt("channel_id", d.a().r());
        jSONObject.putOpt("user_unique_id", d.a().s());
        try {
            if (!b.a(context).w()) {
                Object objA3 = com.qq.gdt.action.a.b.a(context);
                String strB = com.qq.gdt.action.a.b.b(context);
                jSONObject.putOpt("channel_id_inner", objA3);
                jSONObject.putOpt(AdBaseConstants.MARKET_OPEN_CLICK_ID, strB);
                jSONObject.putOpt("ad_trace_time", !TextUtils.isEmpty(strB) ? Long.valueOf(t.i(context)) : 0);
            }
            PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
            jSONObject.put("install_time", packageInfo.firstInstallTime);
            jSONObject.put("update_time", packageInfo.lastUpdateTime);
        } catch (PackageManager.NameNotFoundException unused) {
            o.a("getPackageInfo err", new Object[0]);
        }
    }

    private static void b(JSONObject jSONObject) throws JSONException {
        jSONObject.putOpt("install_package_time", new JSONArray());
    }

    private static void b(JSONObject jSONObject, Context context) throws JSONException {
        String strA = com.qq.gdt.action.d.b.a();
        String language = Locale.getDefault().getLanguage();
        String str = Build.VERSION.RELEASE;
        Integer numB = h.b();
        String strA2 = p.a();
        int i = Build.VERSION.SDK_INT;
        m.a(jSONObject);
        jSONObject.putOpt(LiveConfigKey.MEDIUM, strA);
        jSONObject.putOpt("lg", language);
        jSONObject.putOpt("os", Constants.LOG_OS);
        jSONObject.putOpt("osv", str);
        jSONObject.putOpt("op", numB);
        jSONObject.putOpt("apil", Integer.valueOf(i));
        jSONObject.putOpt("dn", strA2);
        jSONObject.putOpt("tz", h.c());
    }

    private static void c(JSONObject jSONObject) throws JSONException {
        Context contextG = d.a().g();
        jSONObject.putOpt("gdt_traceid", t.g(contextG) ? "" : d.a().b(contextG));
        jSONObject.putOpt(AdBaseConstants.MARKET_OPEN_INTENT_OPEN_URL, d.a().z());
    }

    private static void c(JSONObject jSONObject, Context context) throws JSONException {
        jSONObject.putOpt("device_id", d.a().o());
        com.qq.gdt.action.d.d.a aVarE = h.e(context);
        jSONObject.putOpt("hash_android_id", aVarE.j);
        jSONObject.putOpt("uuid_standard", aVarE.k);
        jSONObject.putOpt("ua_standard", d.a().v());
    }

    private static JSONObject d(JSONObject jSONObject, Context context) {
        if (context != null) {
            try {
                if (b.a(context).v()) {
                    if (TextUtils.isEmpty(f3024a)) {
                        JSONObject jSONObjectW = d.a().w();
                        if (n.a(jSONObjectW)) {
                            return jSONObject;
                        }
                        f3024a = jSONObjectW.toString();
                    }
                    if (jSONObject == null) {
                        jSONObject = new JSONObject();
                    }
                    jSONObject.putOpt("ylhExt", f3024a);
                    long jC = t.c(context);
                    if (jC > 0) {
                        jSONObject.put("ams_reserved_last_revised_activate_time", jC);
                    }
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return jSONObject;
    }

    private static void d(JSONObject jSONObject) throws JSONException {
        int iB = e.b();
        jSONObject.putOpt("sdkv", e.a());
        jSONObject.putOpt("sdkvc", Integer.valueOf(iB));
        jSONObject.putOpt("report_session_id", d.a().l());
    }

    private static void e(JSONObject jSONObject) {
        if (jSONObject != null) {
            try {
                jSONObject.putOpt("native_oaid", "");
                jSONObject.putOpt("is_oaid_track_limited", false);
            } catch (Throwable unused) {
                o.a("appendOpenDeviceIdentifier err", new Object[0]);
            }
        }
    }
}
