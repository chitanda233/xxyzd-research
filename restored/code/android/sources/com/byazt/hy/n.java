package com.byazt.hy;

import android.content.Context;
import com.byazt.ete.cu;
import com.byazt.omf.gt;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_BASEPLAYER_VIDEO_BUFLEN, 46})
public class n {
    public static volatile n c;
    public Context tt;
    public final com.byazt.hm.c uj;
    public com.byazt.re.c ve;

    public static n c() {
        if (c == null) {
            synchronized (n.class) {
                if (c == null) {
                    com.byazt.yr.c.c().c(com.byazt.by.ve.c().a() != 2);
                    c = new n(gt.getContext());
                }
            }
        }
        return c;
    }

    private n(Context context) {
        this.tt = context == null ? gt.getContext() : context.getApplicationContext();
        com.byazt.hm.c cVarC = new com.byazt.hm.c.C0138c().c(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).tt(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).ve(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).c(new c.C0147c()).c(cu.c()).c(cu.tt()).c(true).c();
        this.uj = cVarC;
        com.byazt.gqp.uj ujVarC = cVarC.a().c();
        if (ujVarC != null) {
            ujVarC.c(32);
            ujVarC.tt(com.byazt.by.ve.c().n());
        }
    }

    public com.byazt.hm.c tt() {
        return this.uj;
    }

    public com.byazt.re.c ve() {
        uj();
        return this.ve;
    }

    private void uj() {
        if (this.ve == null) {
            this.ve = new com.byazt.re.c();
        }
    }
}
