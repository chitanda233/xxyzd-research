package com.kuaishou.weapon.p0;

import android.content.Context;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class cf {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2673a;
    private int b;

    public cf(Context context, int i) {
        this.f2673a = context;
        this.b = i;
    }

    public JSONObject a() {
        try {
            JSONObject jSONObject = new JSONObject();
            if (h.a(this.f2673a, "re_po_rt").b(dd.y, 1) != 1) {
                return null;
            }
            try {
                JSONArray jSONArrayA = new x().a(this.f2673a);
                if (jSONArrayA != null && jSONArrayA.length() > 0) {
                    jSONObject.put("10000", jSONArrayA);
                    jSONObject.put("11301", bf.c(com.kwad.sdk.e.b.Rh().Rg()));
                    jSONObject.put("11302", bf.c(com.kwad.sdk.e.b.Rh().getSdkVersion()));
                    jSONObject.put("11303", bf.c(com.kwad.sdk.e.b.Rh().getAppId()));
                }
            } catch (Throwable unused) {
            }
            return jSONObject;
        } catch (Throwable unused2) {
            return null;
        }
    }

    public String a(String str) {
        JSONObject jSONObjectA;
        try {
            JSONObject jSONObjectA2 = new ck(str, ci.j).a(this.f2673a);
            if (jSONObjectA2 != null && (jSONObjectA = a()) != null && jSONObjectA.length() != 0) {
                jSONObjectA2.put("module_section", jSONObjectA);
                return jSONObjectA2.toString();
            }
        } catch (Throwable unused) {
        }
        return null;
    }
}
