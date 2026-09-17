package com.byazt.yp;

import android.content.Context;
import android.text.TextUtils;
import com.byazt.jj.uj;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY, 13})
public class tt {
    public static volatile tt c;
    public Context tt;
    public final com.byazt.hm.c ve;

    public static tt c() {
        if (c == null) {
            synchronized (tt.class) {
                if (c == null) {
                    c = new tt(com.byazt.bp.tt.getContext());
                }
            }
        }
        return c;
    }

    private tt(Context context) {
        this.tt = context == null ? com.byazt.bp.tt.getContext() : context.getApplicationContext();
        com.byazt.hm.c.C0138c c0138cC = new com.byazt.hm.c.C0138c().c(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).tt(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).ve(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).c(true);
        if (uj.c() && uj.c != null) {
            Object obj = uj.c.get("case_id");
            if ((obj instanceof String) && !TextUtils.isEmpty((String) obj)) {
                c0138cC.c(new uj.c());
            }
        }
        com.byazt.hm.c cVarC = c0138cC.c();
        this.ve = cVarC;
        com.byazt.gqp.uj ujVarC = cVarC.a().c();
        if (ujVarC != null) {
            ujVarC.c(16);
        }
    }

    public com.byazt.hm.c tt() {
        return this.ve;
    }
}
