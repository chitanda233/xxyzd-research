package com.byazt.ete;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_START_TIME})
public class nu {
    public static volatile String c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f883a;
    public boolean i;
    public JSONObject n;
    public String sp;
    public String tt;
    public int uj;
    public String ve;
    public String x;

    public static void c(String str) {
        c = str;
    }

    public nu() {
        this.sp = "";
        this.x = "";
    }

    public nu(JSONObject jSONObject) {
        this.sp = "";
        this.x = "";
        if (jSONObject == null) {
            return;
        }
        tt(jSONObject.optString("deeplink_url"));
        ve(jSONObject.optString("fallback_url"));
        c(jSONObject.optInt("fallback_type"));
        this.n = jSONObject.optJSONObject("addon_params");
        this.f883a = jSONObject.optInt("fallback_landing");
        this.sp = jSONObject.optString("fallback_landing_ugen_url");
        this.x = jSONObject.optString("fallback_landing_ugen_md5");
    }

    public void c(JSONObject jSONObject) {
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("deeplink_url", tt());
            jSONObject2.put("fallback_url", uj());
            jSONObject2.put("fallback_type", n());
            jSONObject2.put("addon_params", this.n);
            jSONObject2.put("fallback_landing", this.f883a);
            jSONObject2.put("fallback_landing_ugen_url", this.sp);
            jSONObject2.put("fallback_landing_ugen_md5", this.x);
            jSONObject.put("deep_link", jSONObject2);
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
    }

    public boolean c() {
        return this.i;
    }

    public void c(boolean z) {
        this.i = z;
    }

    public String tt() {
        return uj(c);
    }

    public int ve() {
        return this.f883a;
    }

    private String uj(String str) {
        if (this.n != null && !TextUtils.isEmpty(str) && this.tt != null) {
            String strOptString = this.n.optString(str);
            if (!TextUtils.isEmpty(strOptString)) {
                return this.tt + (this.tt.contains("?") ? com.alipay.sdk.m.w.a.p : "?") + strOptString;
            }
        }
        return this.tt;
    }

    public void tt(String str) {
        this.tt = str;
    }

    public String uj() {
        return this.ve;
    }

    public void ve(String str) {
        this.ve = str;
    }

    public int n() {
        return this.uj;
    }

    public void c(int i) {
        this.uj = i;
    }

    public String a() {
        return this.sp;
    }

    public String sp() {
        return this.x;
    }

    public void c(nu nuVar) {
        if (nuVar == null) {
            return;
        }
        if (!TextUtils.isEmpty(nuVar.tt())) {
            tt(nuVar.tt());
        }
        if (!TextUtils.isEmpty(nuVar.uj())) {
            ve(nuVar.uj());
        }
        if (nuVar.n() != 0) {
            c(nuVar.n());
        }
    }
}
