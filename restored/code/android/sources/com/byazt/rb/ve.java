package com.byazt.rb;

import java.util.Map;
import java.util.TreeMap;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 23, 54})
public class ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public c f1372a;
    public Map<String, TreeMap<Float, String>> c;
    public JSONObject da;
    public int i = 1;
    public long n;
    public String sp;
    public long tt;
    public String uj;
    public int ve;
    public String x;

    @com.byazt.zqa.c(c = {0, 1, 23, 24})
    public static class c {
        public String c;
        public String tt;
    }

    public JSONObject c() {
        return this.da;
    }

    public void c(JSONObject jSONObject) {
        this.da = jSONObject;
    }

    public Map<String, TreeMap<Float, String>> tt() {
        return this.c;
    }

    public void c(Map<String, TreeMap<Float, String>> map) {
        this.c = map;
    }

    public long ve() {
        return this.tt;
    }

    public void c(long j) {
        this.tt = j;
    }

    public int uj() {
        return this.ve;
    }

    public void c(int i) {
        this.ve = i;
    }

    public String n() {
        return this.uj;
    }

    public void c(String str) {
        this.uj = str;
    }

    public long a() {
        return this.n;
    }

    public void tt(long j) {
        this.n = j;
    }

    public c sp() {
        return this.f1372a;
    }

    public void c(c cVar) {
        this.f1372a = cVar;
    }

    public String x() {
        return this.sp;
    }

    public void tt(String str) {
        this.sp = str;
    }

    public String i() {
        return this.x;
    }

    public void ve(String str) {
        this.x = str;
    }

    public int da() {
        return this.i;
    }

    public void tt(int i) {
        this.i = i;
    }

    public String toString() {
        return "AnimationModel{mKeyFramesMap=" + this.c + ", mDuration=" + this.tt + ", mPlayCount=" + this.ve + ", mPlayDirection=" + this.uj + ", mDelay=" + this.n + ", mName=" + this.x + ", mPlayState=" + this.i + ", mTransformOrigin='" + this.f1372a + "', mTimingFunction='" + this.sp + "'}";
    }
}
