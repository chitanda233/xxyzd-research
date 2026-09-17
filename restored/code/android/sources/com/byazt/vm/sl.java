package com.byazt.vm;

import android.os.Bundle;
import android.os.RemoteException;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, 158})
public class sl extends com.byazt.kbg.c.AbstractBinderC0163c {
    public volatile boolean c = false;

    @Override // com.byazt.kbg.c
    public void c(int i, long j, boolean z, float f, double d, String str) throws RemoteException {
    }

    @Override // com.byazt.kbg.c
    public void c(int i, Bundle bundle) throws RemoteException {
        if (i != 0 || bundle == null) {
            return;
        }
        this.c = bundle.getBoolean("oa_id_limit_state");
    }

    public boolean c() {
        return this.c;
    }
}
