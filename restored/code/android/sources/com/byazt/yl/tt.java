package com.byazt.yl;

import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import com.byazt.vx.eo;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_MODULE_NAME, 13})
public class tt {
    public static final String c = eo.uj();
    public static boolean tt = true;

    public static int c() {
        return Integer.parseInt(tt().replace(TRouterMap.DOT, ""));
    }

    public static String tt() {
        return com.byazt.tjo.tt.ve();
    }

    public static String ve() {
        if (TextUtils.isEmpty(tt())) {
            return "";
        }
        String[] strArrSplit = tt().split("\\.");
        if (strArrSplit.length < 4) {
            return "";
        }
        return strArrSplit[0] + TRouterMap.DOT + strArrSplit[1] + TRouterMap.DOT + strArrSplit[2];
    }

    public static String uj() {
        return com.byazt.tjo.tt.uj();
    }
}
