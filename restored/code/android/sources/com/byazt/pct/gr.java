package com.byazt.pct;

import android.text.TextUtils;
import com.alipay.sdk.m.y.l;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 124, MediaPlayer.MEDIA_PLAYER_OPTION_PRE_DECODE_AUTO_PAUSE})
public final class gr {
    public static boolean c;

    public static String c() {
        return "";
    }

    public static String c(Throwable th) {
        return "{\"code\":" + (th instanceof rh ? ((rh) th).c : 0) + l.d;
    }

    public static String c(String str) {
        if (TextUtils.isEmpty(str)) {
            return "{\"code\":1}";
        }
        String strSubstring = c ? str.substring(1, str.length() - 1) : "";
        String str2 = "{\"code\":1,\"__data\":" + str;
        if (!strSubstring.isEmpty()) {
            return str2 + "," + strSubstring + l.d;
        }
        return str2 + l.d;
    }

    public static void c(boolean z) {
        c = z;
    }
}
