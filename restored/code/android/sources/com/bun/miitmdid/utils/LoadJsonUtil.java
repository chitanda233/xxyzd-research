package com.bun.miitmdid.utils;

import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.netease.nis.sdkwrapper.Utils;

/* JADX INFO: loaded from: classes.dex */
public class LoadJsonUtil {
    public static String LoadJsonFromAsset(Context context, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = context;
        objArr[2] = str;
        objArr[3] = Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SET_MAX_FPS);
        objArr[4] = 1594371206410L;
        return (String) Utils.rL(objArr);
    }
}
