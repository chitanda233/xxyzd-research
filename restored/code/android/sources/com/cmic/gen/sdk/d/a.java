package com.cmic.gen.sdk.d;

import android.content.Context;
import android.text.TextUtils;
import com.cmic.gen.sdk.f.g;
import com.cmic.gen.sdk.f.n;
import com.cmic.gen.sdk.f.o;
import com.cmic.gen.sdk.f.p;
import java.util.HashMap;
import org.json.JSONObject;

/* JADX INFO: compiled from: EventUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static C0347a<String, String> f2092a = new C0347a<>();

    public static void a() {
        String strValueOf = String.valueOf(0);
        f2092a.put("authPageIn", strValueOf);
        f2092a.put("authPageOut", strValueOf);
        f2092a.put("authClickFailed", strValueOf);
        f2092a.put("authClickSuccess", strValueOf);
        f2092a.put("timeOnAuthPage", strValueOf);
        f2092a.put("PrivacyNotSelectedToast", strValueOf);
        f2092a.put("PrivacyNotSelectedPopup", strValueOf);
        f2092a.put("PrivacyNotSelectedCustom", strValueOf);
        f2092a.put("PrivacyNotSelectedShake", strValueOf);
    }

    public static void a(String str) {
        try {
            String str2 = f2092a.get(str);
            f2092a.put(str, String.valueOf((!TextUtils.isEmpty(str2) ? Integer.parseInt(str2) : 0) + 1));
            f2092a.put(str + "Time", p.a());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void a(String str, String str2) {
        f2092a.put(str, str2);
    }

    public static void a(Context context, final com.cmic.gen.sdk.a aVar) {
        try {
            if (aVar.b().k()) {
                return;
            }
            com.cmic.gen.sdk.view.a aVar2 = new com.cmic.gen.sdk.view.a();
            String strValueOf = String.valueOf(0);
            aVar2.j(!f2092a.a("authPageIn", strValueOf).equals(strValueOf) ? f2092a.get("authPageIn") : null);
            aVar2.k(!f2092a.a("authPageOut", strValueOf).equals(strValueOf) ? f2092a.get("authPageOut") : null);
            aVar2.c(!f2092a.a("authClickSuccess", strValueOf).equals(strValueOf) ? f2092a.get("authClickSuccess") : null);
            aVar2.b(!f2092a.a("authClickFailed", strValueOf).equals(strValueOf) ? f2092a.get("authClickFailed") : null);
            aVar2.d(!f2092a.a("timeOnAuthPage", strValueOf).equals(strValueOf) ? f2092a.get("timeOnAuthPage") : null);
            aVar2.e(!f2092a.a("PrivacyNotSelectedToast", strValueOf).equals(strValueOf) ? f2092a.get("PrivacyNotSelectedToast") : null);
            aVar2.f(!f2092a.a("PrivacyNotSelectedPopup", strValueOf).equals(strValueOf) ? f2092a.get("PrivacyNotSelectedPopup") : null);
            aVar2.g(!f2092a.a("PrivacyNotSelectedShake", strValueOf).equals(strValueOf) ? f2092a.get("PrivacyNotSelectedShake") : null);
            aVar2.h(f2092a.a("PrivacyNotSelectedCustom", strValueOf).equals(strValueOf) ? null : f2092a.get("PrivacyNotSelectedCustom"));
            aVar2.a(f2092a.a("authPrivacyState", strValueOf));
            aVar2.i(aVar.b("displayLogo"));
            JSONObject jSONObjectA = aVar2.a();
            final c cVar = new c();
            cVar.b(aVar.b("appid", ""));
            cVar.r(aVar.b("traceId"));
            cVar.b(aVar.b("appid"));
            cVar.i(g.a(context));
            cVar.j(g.b(context));
            cVar.k(aVar.b("timeOut"));
            cVar.s(f2092a.a("authPageInTime", ""));
            cVar.t(f2092a.a("authPageOutTime", ""));
            cVar.u("eventTracking5");
            cVar.n(aVar.b("operatortype", ""));
            cVar.v(aVar.b("networktype", 0) + "");
            cVar.e(n.a());
            cVar.o(n.b());
            cVar.p(n.c());
            cVar.m(aVar.b("simCardNum"));
            cVar.a(jSONObjectA);
            cVar.c(aVar.b("imsiState", "0"));
            cVar.l((System.currentTimeMillis() - aVar.b("methodTimes", 0L)) + "");
            o.a(new o.a() { // from class: com.cmic.gen.sdk.d.a.1
                @Override // com.cmic.gen.sdk.f.o.a
                protected void a() {
                    new d().a(cVar.b(), aVar);
                }
            });
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX INFO: renamed from: com.cmic.gen.sdk.d.a$a, reason: collision with other inner class name */
    /* JADX INFO: compiled from: EventUtils.java */
    private static class C0347a<K, V> extends HashMap<K, V> {
        private C0347a() {
        }

        public V a(Object obj, V v) {
            return (!containsKey(obj) || get(obj) == null) ? v : get(obj);
        }
    }
}
