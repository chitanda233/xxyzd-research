package com.byazt.aas;

import android.text.TextUtils;
import com.alipay.sdk.m.t.e;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 131, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public class yp {
    public static String c(Map<String, String> map) {
        if (map == null || map.isEmpty()) {
            return null;
        }
        String str = e.f;
        if (TextUtils.isEmpty(map.get(e.f))) {
            str = "Content-Type";
        }
        return map.get(str);
    }
}
