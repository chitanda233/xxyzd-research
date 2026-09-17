package com.byazt.ji;

import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_DECODER_ERROR, 54})
public class ve extends tt implements com.byazt.vt.uj {
    public com.byazt.vt.ve sl;

    public ve(Context context) {
        super(context);
    }

    @Override // com.byazt.ji.tt
    public boolean c(Object... objArr) {
        com.byazt.vt.c cVarBx = this.tt.bx();
        if (cVarBx == null) {
            return false;
        }
        com.byazt.vt.ve veVarC = cVarBx.c(this.f1076a);
        this.sl = veVarC;
        if (veVarC != null) {
            veVarC.c(this);
            return false;
        }
        cVarBx.c(this.f1076a, new com.byazt.vt.tt());
        return false;
    }

    @Override // com.byazt.vt.uj
    public void c(String str) {
        this.c.c(this.tt, this.f1076a, this.ve.tt(), this.ve);
    }
}
