package com.byazt.ds;

import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public final class yp extends ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final x f812a;
    public final Context n;

    public yp(Context context, x xVar) {
        super(true, false);
        this.n = context;
        this.f812a = xVar;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException, SecurityException {
        Map<String, String> mapC = com.byazt.vm.sp.c(this.n, this.f812a.n());
        if (mapC == null) {
            return !com.byazt.gj.c.tt;
        }
        jSONObject.put("oaid", new JSONObject(mapC));
        return true;
    }
}
