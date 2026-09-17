package com.byazt.ete;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, MediaPlayer.MEDIA_PLAYER_OPTION_MOOV_POS})
public class to {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f891a;
    public int c;
    public int n;
    public int tt;
    public int uj;
    public String ve;

    public to(JSONObject jSONObject) {
        this.f891a = false;
        JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("reward_live");
        if (jSONObjectOptJSONObject != null) {
            this.f891a = true;
            tt(jSONObjectOptJSONObject.optInt("reward_live_type", 1));
            ve(jSONObjectOptJSONObject.optInt("reward_live_style", 1));
            c(jSONObjectOptJSONObject.optString("reward_live_text"));
            c(jSONObjectOptJSONObject.optInt("reward_start_time", 5));
            uj(jSONObjectOptJSONObject.optInt("reward_close_time", 10));
        }
    }

    public void c(JSONObject jSONObject) {
        if (this.f891a) {
            try {
                JSONObject jSONObject2 = new JSONObject();
                jSONObject2.put("reward_live_type", this.c);
                jSONObject2.put("reward_live_style", this.tt);
                jSONObject2.put("reward_live_text", this.ve);
                jSONObject2.put("reward_start_time", this.uj);
                jSONObject2.put("reward_close_time", this.n);
                jSONObject2.put("isValid", this.f891a);
                jSONObject.put("reward_live", jSONObject2);
            } catch (JSONException e) {
                com.byazt.nr.m.c(e);
            }
        }
    }

    public static boolean c(ic icVar) {
        to toVarI = i(icVar);
        if (toVarI == null) {
            return false;
        }
        return toVarI.f891a;
    }

    public boolean c() {
        return this.f891a;
    }

    public static int tt(ic icVar) {
        to toVarI = i(icVar);
        if (toVarI == null) {
            return 1;
        }
        return toVarI.c;
    }

    public static boolean ve(ic icVar) {
        to toVarI = i(icVar);
        return toVarI == null || !toVarI.f891a || toVarI.c == 1;
    }

    public static boolean uj(ic icVar) {
        int i;
        to toVarI = i(icVar);
        return toVarI != null && toVarI.f891a && com.byazt.apd.tt.c().c(icVar) && ((i = toVarI.c) == 3 || i == 4);
    }

    private void tt(int i) {
        if (i != 2 && i != 3 && i != 4 && i != 1) {
            i = 1;
        }
        this.c = i;
    }

    public static int n(ic icVar) {
        to toVarI = i(icVar);
        if (toVarI == null) {
            return 1;
        }
        return toVarI.tt;
    }

    private void ve(int i) {
        if (i != 1 && i != 2 && i != 3) {
            i = 1;
        }
        this.tt = i;
    }

    public static String a(ic icVar) {
        to toVarI = i(icVar);
        return toVarI == null ? "去抖音观看直播\n可提前5s获得奖励哦" : toVarI.ve;
    }

    private void c(String str) {
        if (TextUtils.isEmpty(str)) {
            str = this.tt == 3 ? "5s后将为你自动打开抖音\n在抖音观看直播\n可提前5s获得奖励哦" : "去抖音观看直播\n可提前5s获得奖励哦";
        }
        this.ve = str;
    }

    public static int sp(ic icVar) {
        to toVarI = i(icVar);
        if (toVarI == null) {
            return 5;
        }
        return Math.max(toVarI.uj, 0);
    }

    public void c(int i) {
        this.uj = i;
    }

    public static int x(ic icVar) {
        to toVarI = i(icVar);
        if (toVarI == null) {
            return 10;
        }
        return Math.max(toVarI.n, 3);
    }

    private void uj(int i) {
        if (i <= 3) {
            i = 3;
        }
        this.n = i;
    }

    private static to i(ic icVar) {
        if (icVar == null) {
            return null;
        }
        return icVar.jc();
    }
}
