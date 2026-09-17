package com.byazt.ete;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.sigmob.sdk.base.mta.PointParamKey;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_BARRAGE_MASK})
public class sv {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f890a;
    public String c;
    public c da;
    public tt i;
    public String n;
    public JSONArray sp;
    public boolean tt;
    public String uj;
    public boolean ve;
    public int x;

    public static sv c(JSONObject jSONObject) {
        if (jSONObject == null) {
            return null;
        }
        sv svVar = new sv();
        svVar.c = jSONObject.optString("promotion_id");
        svVar.tt = jSONObject.optBoolean("is_silent_auth", false);
        svVar.ve = jSONObject.optBoolean("enable_playable_auth", false);
        svVar.uj = jSONObject.optString("aweme_agreements");
        svVar.n = jSONObject.optString("aweme_privacy");
        svVar.f890a = jSONObject.optString("live_csj_libra_param");
        svVar.sp = jSONObject.optJSONArray("tasks");
        svVar.x = jSONObject.optInt("live_playable");
        svVar.da = c.c(jSONObject.optJSONObject("product"));
        svVar.i = tt.c(jSONObject.optJSONObject("coupon"));
        return svVar;
    }

    public JSONObject c() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("promotion_id", this.c);
            jSONObject.put("is_silent_auth", this.tt);
            jSONObject.put("enable_playable_auth", this.ve);
            jSONObject.put("aweme_agreements", this.uj);
            jSONObject.put("aweme_privacy", this.n);
            jSONObject.put("live_csj_libra_param", this.f890a);
            jSONObject.put("tasks", this.sp);
            jSONObject.put("live_playable", this.x);
            c cVar = this.da;
            if (cVar != null) {
                jSONObject.put("product", cVar.n());
            }
            tt ttVar = this.i;
            if (ttVar != null) {
                jSONObject.put("coupon", ttVar.ve());
            }
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
        return jSONObject;
    }

    public String tt() {
        return this.c;
    }

    public boolean ve() {
        return this.tt;
    }

    public boolean uj() {
        return this.ve;
    }

    public String n() {
        return this.uj;
    }

    public String a() {
        return this.n;
    }

    public String sp() {
        return this.f890a;
    }

    public JSONArray x() {
        return this.sp;
    }

    public boolean i() {
        return this.x == 2 && this.ve;
    }

    public tt da() {
        return this.i;
    }

    public c sl() {
        return this.da;
    }

    @com.byazt.zqa.c(c = {0, 1, 8, 1626})
    public static class tt {
        public int c;
        public int tt;

        public static tt c(JSONObject jSONObject) {
            if (jSONObject == null) {
                return null;
            }
            tt ttVar = new tt();
            ttVar.c = jSONObject.optInt("amount");
            ttVar.tt = jSONObject.optInt("threshold");
            return ttVar;
        }

        public int c() {
            return this.c;
        }

        public int tt() {
            return this.tt;
        }

        public JSONObject ve() {
            JSONObject jSONObject = new JSONObject();
            try {
                jSONObject.put("amount", this.c);
                jSONObject.put("threshold", this.tt);
            } catch (JSONException unused) {
            }
            return jSONObject;
        }
    }

    @com.byazt.zqa.c(c = {0, 1, 8, 1639})
    public static class c {
        public String c;
        public String tt;
        public double uj;
        public double ve;

        public static c c(JSONObject jSONObject) {
            if (jSONObject == null) {
                return null;
            }
            c cVar = new c();
            cVar.c = jSONObject.optString(com.alipay.sdk.m.c0.d.w);
            cVar.tt = jSONObject.optString("image");
            cVar.uj = jSONObject.optDouble("price");
            cVar.ve = jSONObject.optDouble(PointParamKey.ORIGIN_PRICE);
            return cVar;
        }

        public String c() {
            return this.c;
        }

        public String tt() {
            return this.tt;
        }

        public double ve() {
            return this.ve;
        }

        public double uj() {
            return this.uj;
        }

        public JSONObject n() {
            JSONObject jSONObject = new JSONObject();
            try {
                jSONObject.put(com.alipay.sdk.m.c0.d.w, this.c);
                jSONObject.put("image", this.tt);
                jSONObject.put("price", this.uj);
                jSONObject.put(PointParamKey.ORIGIN_PRICE, this.ve);
            } catch (JSONException unused) {
            }
            return jSONObject;
        }
    }
}
