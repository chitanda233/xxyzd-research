package com.byazt.tjo;

import android.os.Bundle;
import android.util.SparseArray;
import com.byazt.omf.md;
import com.byazt.omf.p;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_FILE_FORMAT, 13})
public class tt {
    public static String uj() {
        return "7.6.1.1";
    }

    public static int c() {
        return p.uj;
    }

    public static md tt() {
        return DispatchAdSdkInitializerHolder.getCsjManger();
    }

    public static String ve() {
        return p.n;
    }

    public static boolean n() {
        return DispatchAdSdkInitializerHolder.isInitSuccess();
    }

    public static void c(int i) {
        md mdVarTt = tt();
        if (mdVarTt != null) {
            mdVarTt.setThemeStatus(i);
        }
    }

    public static void c(boolean z) {
        md mdVarTt = tt();
        if (mdVarTt == null) {
            return;
        }
        Bundle bundle = new Bundle();
        bundle.putBoolean("is_paid", z);
        if (bundle.keySet().isEmpty()) {
            return;
        }
        mdVarTt.getExtra(SparseArray.class, bundle);
    }
}
