package com.byazt.ete;

import com.byazt.bv.BaseConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.tencent.mm.opensdk.constants.ConstantsAPI;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public class yp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f902a;
    public long c;
    public long da;
    public String i;
    public String m;
    public boolean n;
    public String nu;
    public String rh;
    public long sl;
    public int sp;
    public int t;
    public String tt;
    public long u;
    public long uj;
    public String ve;
    public long x;
    public String yp;
    public String z;

    public static yp c(JSONObject jSONObject) {
        if (jSONObject == null) {
            return null;
        }
        yp ypVar = new yp();
        ypVar.c = jSONObject.optLong("user_id");
        ypVar.tt = jSONObject.optString("coupon_meta_id");
        ypVar.ve = jSONObject.optString("unique_id");
        ypVar.uj = jSONObject.optLong("device_id");
        ypVar.n = jSONObject.optBoolean("has_coupon");
        ypVar.f902a = jSONObject.optInt("coupon_scene");
        ypVar.sp = jSONObject.optInt("type");
        ypVar.x = jSONObject.optLong("threshold");
        ypVar.i = jSONObject.optString("scene_key");
        ypVar.da = jSONObject.optLong(ConstantsAPI.WXWebPage.KEY_ACTIVITY_ID);
        ypVar.sl = jSONObject.optLong("amount");
        ypVar.t = jSONObject.optInt("action");
        ypVar.u = jSONObject.optLong("style");
        ypVar.yp = jSONObject.optString("start_time");
        ypVar.z = jSONObject.optString("expire_time");
        ypVar.m = jSONObject.optString("button_text");
        ypVar.nu = jSONObject.optString(BaseConstants.EVENT_LABEL_EXTRA);
        ypVar.rh = jSONObject.optString("toast");
        return ypVar;
    }

    public JSONObject c() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("user_id", this.c);
            jSONObject.put("coupon_meta_id", this.tt);
            jSONObject.put("unique_id", this.ve);
            jSONObject.put("device_id", this.uj);
            jSONObject.put("has_coupon", this.n);
            jSONObject.put("coupon_scene", this.f902a);
            jSONObject.put("type", this.sp);
            jSONObject.put("threshold", this.x);
            jSONObject.put("scene_key", this.i);
            jSONObject.put(ConstantsAPI.WXWebPage.KEY_ACTIVITY_ID, this.da);
            jSONObject.put("amount", this.sl);
            jSONObject.put("action", this.t);
            jSONObject.put("style", this.u);
            jSONObject.put("start_time", this.yp);
            jSONObject.put("expire_time", this.z);
            jSONObject.put("button_text", this.m);
            jSONObject.put(BaseConstants.EVENT_LABEL_EXTRA, this.nu);
            jSONObject.put("toast", this.rh);
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
        return jSONObject;
    }

    public JSONObject tt() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("user_id", this.c);
            jSONObject.put("coupon_meta_id", this.tt);
            jSONObject.put("unique_id", this.ve);
            jSONObject.put("device_id", this.uj);
            jSONObject.put("type", this.sp);
            jSONObject.put("scene_key", this.i);
            jSONObject.put(ConstantsAPI.WXWebPage.KEY_ACTIVITY_ID, this.da);
            jSONObject.put("value", this.sl);
            jSONObject.put("threshold", this.x);
            jSONObject.put(BaseConstants.EVENT_LABEL_EXTRA, this.nu);
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
        return jSONObject;
    }

    public void c(String str) {
        this.rh = str;
    }

    public int ve() {
        return this.f902a;
    }

    public void c(boolean z) {
        this.n = z;
    }

    public void c(int i) {
        this.f902a = i;
    }

    public void c(long j) {
        this.sl = j;
    }

    public int getType() {
        return this.sp;
    }

    public String uj() {
        return this.rh;
    }

    public boolean tt(boolean z) {
        int i;
        boolean z2 = this.n && this.sl > 0;
        if (z) {
            if (z2 && ((i = this.f902a) == 0 || i == 5)) {
                return true;
            }
        } else if (z2 && this.f902a == 5) {
            return true;
        }
        return false;
    }
}
