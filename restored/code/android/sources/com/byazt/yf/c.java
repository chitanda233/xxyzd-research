package com.byazt.yf;

import com.bykv.vk.openvk.api.proto.PluginValueSet;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 508, 20})
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public t f1578a;
    public String c;
    public Map<String, Object> da;
    public a i;
    public boolean n;
    public boolean sl;
    public x sp;
    public JSONObject t;
    public String tt;
    public Map<String, Object> u;
    public String uj;
    public boolean ve;
    public uj x;
    public PluginValueSet yp;
    public boolean z;

    private c(C0301c c0301c) {
        this.c = c0301c.c;
        this.tt = c0301c.tt;
        this.ve = c0301c.ve;
        this.uj = c0301c.uj;
        this.n = c0301c.n;
        if (c0301c.f1579a == null) {
            this.f1578a = new t.c().c();
        } else {
            this.f1578a = c0301c.f1579a;
        }
        if (c0301c.sp == null) {
            this.sp = new x.c().c();
        } else {
            this.sp = c0301c.sp;
        }
        if (c0301c.x == null) {
            this.x = new uj.c().c();
        } else {
            this.x = c0301c.x;
        }
        if (c0301c.i == null) {
            this.i = new a();
        } else {
            this.i = c0301c.i;
        }
        this.da = c0301c.da;
        this.sl = c0301c.sl;
        this.t = c0301c.t;
        this.u = c0301c.u;
        this.yp = c0301c.yp;
        this.z = c0301c.z;
    }

    /* JADX INFO: renamed from: com.byazt.yf.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, 508, 44})
    public static class C0301c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public t f1579a;
        public String c;
        public Map<String, Object> da;
        public a i;
        public x sp;
        public JSONObject t;
        public String tt;
        public Map<String, Object> u;
        public uj x;
        public PluginValueSet yp;
        public boolean z;
        public boolean ve = false;
        public String uj = "";
        public boolean n = false;
        public boolean sl = false;

        public C0301c c(String str) {
            this.c = str;
            return this;
        }

        public C0301c tt(String str) {
            this.tt = str;
            return this;
        }

        public C0301c c(boolean z) {
            this.ve = z;
            return this;
        }

        public C0301c ve(String str) {
            this.uj = str;
            return this;
        }

        public C0301c tt(boolean z) {
            this.n = z;
            return this;
        }

        public C0301c c(t tVar) {
            this.f1579a = tVar;
            return this;
        }

        public C0301c c(x xVar) {
            this.sp = xVar;
            return this;
        }

        public C0301c c(a aVar) {
            this.i = aVar;
            return this;
        }

        public C0301c c(Map<String, Object> map) {
            if (map != null && !map.isEmpty()) {
                if (this.da == null) {
                    this.da = new HashMap();
                }
                this.da.putAll(map);
            }
            return this;
        }

        public C0301c ve(boolean z) {
            this.sl = z;
            return this;
        }

        public C0301c c(JSONObject jSONObject) {
            this.t = jSONObject;
            return this;
        }

        public C0301c c(PluginValueSet pluginValueSet) {
            this.yp = pluginValueSet;
            return this;
        }

        public C0301c uj(boolean z) {
            this.z = z;
            return this;
        }

        public c c() {
            return new c(this);
        }
    }

    public String c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public boolean ve() {
        return this.ve;
    }

    public String uj() {
        return this.uj;
    }

    public boolean n() {
        return this.n;
    }

    public t a() {
        return this.f1578a;
    }

    public x sp() {
        return this.sp;
    }

    public uj x() {
        return this.x;
    }

    public a i() {
        return this.i;
    }

    public Map<String, Object> da() {
        return this.da;
    }

    public boolean sl() {
        return this.sl;
    }

    public JSONObject t() {
        return this.t;
    }

    public Map<String, Object> u() {
        return this.u;
    }

    public PluginValueSet yp() {
        return this.yp;
    }

    public boolean z() {
        return this.z;
    }
}
