package com.byazt.bl;

import android.graphics.Bitmap;
import com.byazt.yj.eo;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_LOW_THRESHOLD, 15})
public class uj implements eo {
    public final eo c;
    public final com.byazt.ep.tt tt;

    public uj(eo eoVar) {
        this(eoVar, null);
    }

    public uj(eo eoVar, com.byazt.ep.tt ttVar) {
        this.c = eoVar;
        this.tt = ttVar;
    }

    @Override // com.byazt.yj.c
    public boolean c(String str, Bitmap bitmap) {
        boolean zC = this.c.c(str, bitmap);
        if (this.tt != null) {
            Boolean.valueOf(zC);
        }
        return zC;
    }

    @Override // com.byazt.yj.c
    public Bitmap c(String str) {
        return this.c.c(str);
    }

    @Override // com.byazt.yj.c
    public void c() {
        this.c.c();
    }

    @Override // com.byazt.yj.c
    public boolean tt(String str) {
        return this.c.tt(str);
    }

    @Override // com.byazt.yj.c
    public void c(double d) {
        this.c.c(d);
    }
}
