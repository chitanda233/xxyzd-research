package com.byazt.qx;

import com.baidu.mobads.sdk.internal.cb;
import com.byazt.el.SSWebView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 512})
public class d extends com.byazt.pct.n<JSONObject, JSONObject> {
    public WeakReference<SSWebView> c;

    public static void c(com.byazt.pct.nu nuVar, SSWebView sSWebView) {
        nuVar.c("preventTouchEvent", (com.byazt.pct.n<?, ?>) new d(sSWebView));
    }

    public d(SSWebView sSWebView) {
        this.c = new WeakReference<>(sSWebView);
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        JSONObject jSONObject2 = new JSONObject();
        try {
            boolean zOptBoolean = jSONObject.optBoolean("isPrevent", false);
            SSWebView sSWebView = this.c.get();
            if (sSWebView != null) {
                sSWebView.setIsPreventTouchEvent(zOptBoolean);
                jSONObject2.put(cb.o, true);
            } else {
                jSONObject2.put(cb.o, false);
            }
        } catch (Throwable unused) {
            jSONObject2.put(cb.o, false);
        }
        return jSONObject2;
    }
}
