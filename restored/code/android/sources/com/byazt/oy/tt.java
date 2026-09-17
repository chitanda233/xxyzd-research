package com.byazt.oy;

import android.content.Context;
import android.text.TextUtils;
import com.byazt.gqp.t;
import com.byazt.nr.m;
import com.byazt.nr.sp;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.File;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DOLBY_MIX_LEVEL, 13})
public class tt {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static int f1303a = 1;
    public static boolean c = false;
    public static t n = null;
    public static Context tt = null;
    public static boolean uj = false;
    public static String ve;

    public static Context getContext() {
        return tt;
    }

    public static String c() {
        if (TextUtils.isEmpty(ve)) {
            try {
                File file = new File(sp.c(getContext(), false, null), "ttad_dir");
                if (!file.exists()) {
                    file.mkdirs();
                }
                ve = file.getAbsolutePath();
            } catch (Throwable th) {
                m.c(th);
            }
        }
        return ve;
    }

    public static void c(Context context, String str) {
        tt = context.getApplicationContext();
        ve = str;
    }

    public static boolean tt() {
        return uj;
    }

    public static void c(boolean z) {
        uj = z;
    }

    public static t ve() {
        if (n == null) {
            n = new t.c("v_config").c(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).tt(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).ve(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).c();
        }
        return n;
    }

    public static void c(t tVar) {
        n = tVar;
    }

    public static boolean uj() {
        return c;
    }

    public static int n() {
        return f1303a;
    }
}
