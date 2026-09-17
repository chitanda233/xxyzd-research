package com.byazt.ete;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, 577})
public class pf {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f887a;
    public String c;
    public String n;
    public String tt;
    public String uj;
    public String ve;

    public pf() {
    }

    public pf(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c(jSONObject.optString("reward_live_deep_link_user_id"));
        n(jSONObject.optString("reward_live_deep_link_request_id"));
        tt(jSONObject.optString("reward_live_deep_link_room_id"));
        ve(jSONObject.optString("reawrd_live_short_touch_params"));
        uj(jSONObject.optString("reawrd_live_extra_pangle_scheme_params"));
        c(jSONObject.optLong("reward_live_last_time"));
    }

    public String c() {
        return this.tt;
    }

    public void c(String str) {
        this.tt = str;
    }

    public String tt() {
        return this.ve;
    }

    public void tt(String str) {
        this.ve = str;
    }

    public String ve() {
        return this.uj;
    }

    public void ve(String str) {
        this.uj = str;
    }

    public String uj() {
        return this.n;
    }

    public void uj(String str) {
        this.n = str;
    }

    public long n() {
        return this.f887a;
    }

    public void c(long j) {
        this.f887a = j;
    }

    public String a() {
        return this.c;
    }

    public void n(String str) {
        this.c = str;
    }
}
