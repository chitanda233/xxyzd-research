package com.byazt.nbs;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1871, 91})
public class sp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public List<a> f1193a;
    public String c;
    public int da;
    public double i;
    public c n;
    public double sl;
    public List<x> sp;
    public String tt;
    public x uj;
    public String ve;
    public JSONObject x;

    public double c() {
        return this.i;
    }

    public void c(String str) {
        try {
            this.i = Double.valueOf(str).doubleValue();
        } catch (Throwable unused) {
        }
    }

    public int tt() {
        return this.da;
    }

    public void c(int i) {
        this.da = i;
    }

    public double ve() {
        return this.sl;
    }

    public void tt(String str) {
        try {
            this.sl = Double.valueOf(str).doubleValue();
        } catch (Throwable unused) {
        }
    }

    public List<x> uj() {
        return this.sp;
    }

    public void c(List<x> list) {
        this.sp = list;
    }

    public List<a> n() {
        return this.f1193a;
    }

    public void tt(List<a> list) {
        this.f1193a = list;
    }

    public void ve(String str) {
        this.c = str;
    }

    public void uj(String str) {
        this.tt = str;
    }

    public String a() {
        return this.ve;
    }

    public void n(String str) {
        this.ve = str;
    }

    public void c(x xVar) {
        this.uj = xVar;
    }

    public void c(c cVar) {
        this.n = cVar;
    }

    public void c(JSONObject jSONObject) {
        this.x = jSONObject;
    }

    public JSONObject sp() {
        return this.x;
    }

    public boolean x() {
        c cVar = this.n;
        return (cVar == null || TextUtils.isEmpty(cVar.c)) ? false : true;
    }

    public List<da> i() {
        c cVar = this.n;
        if (cVar == null) {
            return null;
        }
        return cVar.tt;
    }

    @com.byazt.zqa.c(c = {0, 1, 1871, 180})
    public static class c {
        public String c;
        public List<da> tt = new ArrayList();

        public void c(String str) {
            this.c = str;
        }

        public void c(List<da> list) {
            this.tt = list;
        }
    }
}
