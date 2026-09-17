package com.byazt.qh;

import android.content.Context;
import android.os.Environment;
import android.text.TextUtils;
import com.byazt.aas.DeviceUtils;
import com.byazt.aas.rh;
import com.byazt.dna.u;
import com.byazt.nr.a;
import com.byazt.nr.m;
import com.byazt.nr.sp;
import com.byazt.omf.gt;
import com.byazt.omf.p;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kuaishou.weapon.p0.g;
import com.sigmob.sdk.base.mta.PointCategory;
import java.io.File;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_LIVE_STREAM_SESSION_ID, 13})
public class tt {
    public static String c;

    public static void c(JSONObject jSONObject) {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return;
        }
        try {
            com.byazt.fn.c location = ((u) com.byazt.ut.uj.getService("device_info_new")).getLocation(!com.byazt.by.c.tt());
            float longitude = 0.0f;
            float latitude = location == null ? 0.0f : location.getLatitude();
            if (location != null) {
                longitude = location.getLongitude();
            }
            jSONObject.put("latitude", latitude);
            jSONObject.put("longitude", longitude);
        } catch (JSONException e) {
            m.c(e);
        }
    }

    public static void c(com.byazt.dj.uj ujVar, List<String> list) {
        if (p.x.equals(PointCategory.PRIVACY) || !ujVar.isCanUseLocation()) {
            return;
        }
        list.add(g.h);
        list.add(g.g);
    }

    public static void tt(JSONObject jSONObject) {
        com.byazt.fn.c location;
        if (p.x.equals(PointCategory.PRIVACY) || (location = ((u) com.byazt.ut.uj.getService("device_info_new")).getLocation(!com.byazt.by.c.tt())) == null) {
            return;
        }
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("latitude", location.getLatitude());
            jSONObject2.put("longitude", location.getLongitude());
            jSONObject.put("geo", jSONObject2);
        } catch (Exception unused) {
        }
    }

    public static void ve(JSONObject jSONObject) {
        try {
            if (p.x.equals(PointCategory.PRIVACY)) {
                jSONObject.put("imei_md5", tt());
            } else {
                jSONObject.put("imei", DeviceUtils.c((Boolean) null));
            }
        } catch (JSONException e) {
            m.c(e);
        }
    }

    private static String tt() {
        if (TextUtils.isEmpty(c)) {
            String strC = DeviceUtils.c((Boolean) null);
            if (!TextUtils.isEmpty(strC)) {
                c = a.tt(strC);
            }
        }
        return c;
    }

    public static void c(Context context, JSONObject jSONObject) {
        try {
            if (p.x.equals(PointCategory.PRIVACY)) {
                jSONObject.put("udid_md5", tt());
                return;
            }
            u uVar = (u) com.byazt.ut.uj.getService("device_info_new");
            jSONObject.put("udid", DeviceUtils.c((Boolean) null));
            jSONObject.put("mc", uVar.getMacAddress(null));
        } catch (Exception e) {
            m.c(e);
        }
    }

    public static void tt(Context context, JSONObject jSONObject) {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return;
        }
        try {
            JSONArray jSONArrayC = rh.c(context);
            if (jSONArrayC != null) {
                jSONObject.put("app_list", jSONArrayC);
            }
        } catch (JSONException e) {
            m.c(e);
        }
    }

    public static void c() {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return;
        }
        ((u) com.byazt.ut.uj.getService("device_info_new")).getLocation(!com.byazt.by.c.tt());
    }

    public static void c(String str) {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return;
        }
        com.byazt.ogz.ve.tt().c(str);
    }

    public static boolean tt(String str) {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return false;
        }
        return rh.c(str);
    }

    public static void c(Context context) {
        if (p.x.equals(PointCategory.PRIVACY) || (gt.tt().rp() & 8) != 0) {
            return;
        }
        c.c(context);
    }

    public static File tt(Context context) {
        if (p.x.equals(PointCategory.PRIVACY)) {
            return sp.c(context, "Download/Pangolin", false, null);
        }
        return sp.c(context, Environment.DIRECTORY_DOWNLOADS, false, null);
    }
}
