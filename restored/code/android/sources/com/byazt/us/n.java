package com.byazt.us;

import com.byazt.gq.t;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_PROCESSOR_ADDR, 46})
public class n implements com.byazt.g.c.InterfaceC0125c {
    public long c;

    @Override // com.byazt.g.c.InterfaceC0125c
    public void ve() {
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_PROCESSOR_ADDR, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS})
    private static class c {
        public static n c = new n();
    }

    public static n c() {
        return c.c;
    }

    private n() {
        this.c = 0L;
        com.byazt.g.c.c().c(this);
    }

    @Override // com.byazt.g.c.InterfaceC0125c
    public void tt() {
        this.c = System.currentTimeMillis();
    }

    public void c(final uj ujVar, final long j) {
        if (ujVar == null) {
            return;
        }
        com.byazt.di.n.c().c(new Runnable() { // from class: com.byazt.us.n.1
            @Override // java.lang.Runnable
            public void run() {
                if (!com.byazt.g.c.c().ve() || System.currentTimeMillis() - n.this.c <= j) {
                    ujVar.c(true);
                } else {
                    ujVar.c(false);
                }
            }
        }, j);
    }

    public void c(uj ujVar) {
        c(ujVar, 5000L);
    }

    public void tt(uj ujVar) {
        if (ujVar == null) {
            return;
        }
        int iOptInt = t.i().optInt("check_an_result_delay", 1200);
        c(ujVar, iOptInt > 0 ? iOptInt : 1200);
    }
}
