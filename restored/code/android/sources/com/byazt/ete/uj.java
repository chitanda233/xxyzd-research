package com.byazt.ete;

import android.text.TextUtils;
import com.byazt.quv.AbsServerManager;
import com.qq.e.ads.nativ.NativeUnifiedADAppInfoImpl;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, 15})
public class uj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f893a;
    public String c;
    public String da;
    public String i;
    public String n;
    public JSONArray sl;
    public String sp;
    public String t;
    public String tt;
    public JSONObject u;
    public List<c> uj;
    public String ve;
    public float x;

    public uj(JSONObject jSONObject) {
        try {
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject(AbsServerManager.PACKAGE_QUERY_BINDER);
            this.c = jSONObjectOptJSONObject.optString("app_name");
            this.tt = jSONObjectOptJSONObject.optString(NativeUnifiedADAppInfoImpl.Keys.VERSION_NAME);
            this.ve = jSONObjectOptJSONObject.optString("developer_name");
            this.uj = new ArrayList();
            JSONArray jSONArrayOptJSONArray = jSONObjectOptJSONObject.optJSONArray("permissions");
            if (jSONArrayOptJSONArray != null) {
                for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                    this.uj.add(new c(jSONArrayOptJSONArray.optJSONObject(i)));
                }
            }
            this.n = jSONObjectOptJSONObject.optString("policy_url");
            String strOptString = jSONObjectOptJSONObject.optString(AbsServerManager.PACKAGE_QUERY_BINDER);
            this.f893a = strOptString;
            if (TextUtils.isEmpty(strOptString)) {
                this.f893a = jSONObjectOptJSONObject.optString(com.sigmob.sdk.base.n.p);
            }
            this.sp = jSONObjectOptJSONObject.optString("icon_url");
            this.i = jSONObjectOptJSONObject.optString("desc_url");
            this.da = jSONObjectOptJSONObject.optString("reg_number");
            this.t = jSONObjectOptJSONObject.optString("reg_url");
            this.u = jSONObjectOptJSONObject.optJSONObject("reg_info");
        } catch (Throwable unused) {
        }
    }

    public String c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public String ve() {
        return this.ve;
    }

    public String uj() {
        return this.sp;
    }

    public void c(float f) {
        this.x = f;
    }

    public void c(JSONArray jSONArray) {
        this.sl = jSONArray;
    }

    public String n() {
        return this.i;
    }

    public String a() {
        return this.t;
    }

    public boolean sp() {
        List<c> list;
        return (TextUtils.isEmpty(this.c) || TextUtils.isEmpty(this.tt) || TextUtils.isEmpty(ve()) || (list = this.uj) == null || list.size() == 0 || TextUtils.isEmpty(this.n) || TextUtils.isEmpty(this.i)) ? false : true;
    }

    public String x() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("app_name", this.c);
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
        try {
            jSONObject.put(com.sigmob.sdk.base.n.r, this.tt);
        } catch (JSONException e2) {
            com.byazt.nr.m.c(e2);
        }
        try {
            jSONObject.put("developer_name", this.ve);
        } catch (JSONException e3) {
            com.byazt.nr.m.c(e3);
        }
        try {
            jSONObject.put(com.sigmob.sdk.base.n.p, this.f893a);
        } catch (JSONException e4) {
            com.byazt.nr.m.c(e4);
        }
        JSONArray jSONArray = new JSONArray();
        Iterator<c> it = this.uj.iterator();
        while (it.hasNext()) {
            jSONArray.put(it.next().c());
        }
        try {
            jSONObject.put("permissions", jSONArray);
        } catch (JSONException e5) {
            com.byazt.nr.m.c(e5);
        }
        try {
            jSONObject.put("privacy_policy_url", this.n);
        } catch (JSONException e6) {
            com.byazt.nr.m.c(e6);
        }
        try {
            jSONObject.put("score", this.x);
        } catch (JSONException e7) {
            com.byazt.nr.m.c(e7);
        }
        try {
            jSONObject.put("creative_tags", this.sl);
        } catch (JSONException e8) {
            com.byazt.nr.m.c(e8);
        }
        try {
            jSONObject.put("desc_url", this.i);
        } catch (JSONException e9) {
            com.byazt.nr.m.c(e9);
        }
        try {
            jSONObject.put("reg_number", this.da);
        } catch (JSONException e10) {
            com.byazt.nr.m.c(e10);
        }
        try {
            jSONObject.put("icon_url", this.sp);
        } catch (JSONException e11) {
            com.byazt.nr.m.c(e11);
        }
        try {
            jSONObject.put("reg_url", this.t);
        } catch (JSONException e12) {
            com.byazt.nr.m.c(e12);
        }
        try {
            jSONObject.put("reg_info", this.u);
        } catch (JSONException e13) {
            com.byazt.nr.m.c(e13);
        }
        return jSONObject.toString();
    }

    @com.byazt.zqa.c(c = {0, 1, 8, 123})
    private static class c {
        public final String c;
        public final String tt;

        public c(JSONObject jSONObject) {
            this.c = jSONObject.optString("permission_name");
            this.tt = jSONObject.optString("permission_desc");
        }

        /* JADX INFO: Access modifiers changed from: private */
        public JSONObject c() {
            JSONObject jSONObject = new JSONObject();
            try {
                jSONObject.put("permission_desc", this.tt);
            } catch (JSONException e) {
                com.byazt.nr.m.c(e);
            }
            try {
                jSONObject.put("permission_name", this.c);
            } catch (JSONException e2) {
                com.byazt.nr.m.c(e2);
            }
            return jSONObject;
        }
    }
}
