package com.byazt.ds;

import android.content.Context;
import android.text.TextUtils;
import com.alipay.sdk.m.n.b;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, 91})
public class sp extends ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final x f808a;
    public final Context n;

    public sp(Context context, x xVar) {
        super(false, false);
        this.n = context;
        this.f808a = xVar;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException {
        jSONObject.put(PluginConstants.KEY_SDK_VERSION, MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_DEVICE_WAIT_START_TIME);
        jSONObject.put("sdk_version_name", "7.5.0.0.baseChina-alpha.3");
        jSONObject.put("channel", this.f808a.sl());
        i.c(jSONObject, "aid", this.f808a.da());
        i.c(jSONObject, "release_build", this.f808a.yv());
        i.c(jSONObject, "app_region", this.f808a.u());
        i.c(jSONObject, "app_language", this.f808a.t());
        i.c(jSONObject, b.b, this.f808a.p());
        i.c(jSONObject, "ab_sdk_version", this.f808a.z());
        i.c(jSONObject, "ab_version", this.f808a.my());
        i.c(jSONObject, "aliyun_uuid", this.f808a.tt());
        String strZm = this.f808a.zm();
        if (!TextUtils.isEmpty(strZm)) {
            try {
                jSONObject.put("app_track", new JSONObject(strZm));
            } catch (Throwable th) {
                com.byazt.yv.da.tt(th);
            }
        }
        String strYp = this.f808a.yp();
        if (strYp != null && strYp.length() > 0) {
            jSONObject.put(MediationConstant.KEY_USE_POLICY_OBJ_CUSTOM, new JSONObject(strYp));
        }
        i.c(jSONObject, "user_unique_id", this.f808a.m());
        return true;
    }
}
