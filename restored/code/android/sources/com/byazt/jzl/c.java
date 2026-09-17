package com.byazt.jzl;

import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1574, 20})
public class c {
    public String c;
    public String tt;
    public int x;
    public long ve = -2147483648L;
    public int uj = Integer.MIN_VALUE;
    public long n = -2147483648L;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public double f1092a = -2.147483648E9d;
    public double sp = -2.147483648E9d;

    public JSONObject c() {
        try {
            JSONObject jSONObject = new JSONObject();
            if (!TextUtils.isEmpty(this.tt)) {
                jSONObject.putOpt("audio_url", this.tt);
            }
            if (!TextUtils.isEmpty(this.c)) {
                jSONObject.putOpt("file_hash", this.c);
            }
            long j = this.ve;
            if (j > 0) {
                jSONObject.put("size", j);
            }
            int i = this.uj;
            if (i >= 0) {
                jSONObject.put("reward_audio_cached_type", i);
            }
            long j2 = this.n;
            if (j2 >= 0) {
                jSONObject.put("audio_preload_size", j2);
            }
            double d = this.f1092a;
            if (d > 0.0d) {
                jSONObject.put("audio_duration", d);
            }
            double d2 = this.sp;
            if (d2 > 0.0d) {
                jSONObject.put("start", d2);
            }
            int i2 = this.x;
            if (i2 > 0) {
                jSONObject.put("repeat_count", i2);
            }
            return jSONObject;
        } catch (Exception e) {
            e.getMessage();
            return null;
        }
    }

    public String tt() {
        return this.c;
    }

    public void c(String str) {
        this.c = str;
    }

    public long ve() {
        return this.ve;
    }

    public void c(long j) {
        this.ve = j;
    }

    public void c(int i) {
        this.uj = i;
    }

    public double uj() {
        return this.sp;
    }

    public void c(double d) {
        this.sp = d;
    }

    public void tt(long j) {
        this.n = j;
    }

    public String n() {
        return this.tt;
    }

    public void tt(String str) {
        this.tt = str;
    }

    public double a() {
        return this.f1092a;
    }

    public void tt(double d) {
        this.f1092a = d;
    }

    public void tt(int i) {
        if (i < 0) {
            i = 0;
        }
        this.x = i;
    }

    public int sp() {
        return this.x;
    }
}
