package com.byazt.rx;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CLOCK_DIFF, 71})
public final class x {
    public SharedPreferences c;

    public x(Context context) {
        this.c = com.byazt.nys.tt.tt(context, "npth", 0);
    }

    public void c(String str) {
        this.c.edit().putString("device_id", str).apply();
    }

    public String c() {
        String strN = com.byazt.uy.x.c().n();
        return (TextUtils.isEmpty(strN) || "0".equals(strN)) ? this.c.getString("device_id", "0") : strN;
    }
}
