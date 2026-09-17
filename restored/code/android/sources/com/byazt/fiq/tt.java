package com.byazt.fiq;

import com.baidu.mobads.sdk.internal.bz;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.security.MessageDigest;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_NETWORK_RECONNECT_COUNT, 13})
public class tt {
    public static String c(byte[] bArr) {
        if (bArr == null) {
            return "";
        }
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            messageDigest.update(bArr);
            return x.c(messageDigest.digest());
        } catch (Exception unused) {
            return "";
        }
    }
}
