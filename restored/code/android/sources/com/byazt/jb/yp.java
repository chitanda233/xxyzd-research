package com.byazt.jb;

import androidx.core.internal.view.SupportMenu;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Arrays;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 63, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public final class yp {
    public int c;
    public final int[] tt = new int[10];

    public void c() {
        this.c = 0;
        Arrays.fill(this.tt, 0);
    }

    public yp c(int i, int i2) {
        if (i >= 0) {
            int[] iArr = this.tt;
            if (i < iArr.length) {
                this.c = (1 << i) | this.c;
                iArr[i] = i2;
            }
        }
        return this;
    }

    public boolean c(int i) {
        return ((1 << i) & this.c) != 0;
    }

    public int tt(int i) {
        return this.tt[i];
    }

    public int tt() {
        return Integer.bitCount(this.c);
    }

    public int ve() {
        if ((this.c & 2) != 0) {
            return this.tt[1];
        }
        return -1;
    }

    public int ve(int i) {
        return (this.c & 16) != 0 ? this.tt[4] : i;
    }

    public int uj(int i) {
        return (this.c & 32) != 0 ? this.tt[5] : i;
    }

    public int uj() {
        return (this.c & 128) != 0 ? this.tt[7] : SupportMenu.USER_MASK;
    }

    public void c(yp ypVar) {
        for (int i = 0; i < 10; i++) {
            if (ypVar.c(i)) {
                c(i, ypVar.tt(i));
            }
        }
    }
}
