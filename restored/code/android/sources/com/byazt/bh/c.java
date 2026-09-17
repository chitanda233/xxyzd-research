package com.byazt.bh;

import com.baidu.mobads.sdk.internal.cb;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 892, 20})
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f697a;
    public String c;
    public int n;
    public String tt;
    public boolean uj;
    public String ve;
    public final Map<String, String> sp = new HashMap();
    public List<C0068c> x = new ArrayList();
    public final List<C0068c> i = new ArrayList();
    public final List<C0068c> da = new ArrayList();

    public String c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public String ve() {
        return this.ve;
    }

    public boolean uj() {
        return this.uj;
    }

    public int n() {
        return this.n;
    }

    public Map<String, String> a() {
        return this.sp;
    }

    public List<C0068c> sp() {
        return this.x;
    }

    public c(JSONObject jSONObject) {
        c(jSONObject);
    }

    public void c(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        this.c = jSONObject.optString(com.alipay.sdk.m.n.c.e);
        this.f697a = jSONObject.optInt("index");
        this.tt = jSONObject.optString("scheme");
        this.ve = jSONObject.optString("condition");
        this.uj = jSONObject.optBoolean("enableCondition");
        this.n = jSONObject.optInt("priority", Integer.MAX_VALUE);
        JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("params");
        Iterator<String> itKeys = jSONObjectOptJSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            this.sp.put(next, jSONObjectOptJSONObject.optString(next));
        }
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("next");
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                JSONObject jSONObjectOptJSONObject2 = jSONArrayOptJSONArray.optJSONObject(i);
                if (jSONObjectOptJSONObject2 != null) {
                    this.x.add(new C0068c(jSONObjectOptJSONObject2.optString(com.alipay.sdk.m.n.c.e), jSONObjectOptJSONObject2.optString("condition")));
                }
            }
        } else {
            JSONObject jSONObjectOptJSONObject3 = jSONObject.optJSONObject("next");
            if (jSONObjectOptJSONObject3 != null) {
                this.x.add(new C0068c(jSONObjectOptJSONObject3.optString(com.alipay.sdk.m.n.c.e), jSONObjectOptJSONObject3.optString("condition")));
            }
        }
        JSONObject jSONObjectOptJSONObject4 = jSONObject.optJSONObject("callback");
        if (jSONObjectOptJSONObject4 == null) {
            jSONObjectOptJSONObject4 = new JSONObject();
        }
        JSONArray jSONArrayOptJSONArray2 = jSONObjectOptJSONObject4.optJSONArray(cb.o);
        if (jSONArrayOptJSONArray2 == null) {
            jSONArrayOptJSONArray2 = new JSONArray();
        }
        for (int i2 = 0; i2 < jSONArrayOptJSONArray2.length(); i2++) {
            JSONObject jSONObjectOptJSONObject5 = jSONArrayOptJSONArray2.optJSONObject(i2);
            if (jSONObjectOptJSONObject5 != null) {
                this.i.add(new C0068c(jSONObjectOptJSONObject5.optString(com.alipay.sdk.m.n.c.e), jSONObjectOptJSONObject5.optString("condition")));
            }
        }
        JSONArray jSONArrayOptJSONArray3 = jSONObjectOptJSONObject4.optJSONArray("fail");
        if (jSONArrayOptJSONArray3 == null) {
            jSONArrayOptJSONArray3 = new JSONArray();
        }
        for (int i3 = 0; i3 < jSONArrayOptJSONArray3.length(); i3++) {
            JSONObject jSONObjectOptJSONObject6 = jSONArrayOptJSONArray3.optJSONObject(i3);
            if (jSONObjectOptJSONObject6 != null) {
                this.da.add(new C0068c(jSONObjectOptJSONObject6.optString(com.alipay.sdk.m.n.c.e), jSONObjectOptJSONObject6.optString("condition")));
            }
        }
    }

    public List<C0068c> x() {
        return this.i;
    }

    public List<C0068c> i() {
        return this.da;
    }

    /* JADX INFO: renamed from: com.byazt.bh.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, 892, 44})
    public static class C0068c {
        public String c;
        public String tt;

        public String c() {
            return this.c;
        }

        public String tt() {
            return this.tt;
        }

        public C0068c(String str, String str2) {
            this.c = str;
            this.tt = str2;
        }
    }
}
