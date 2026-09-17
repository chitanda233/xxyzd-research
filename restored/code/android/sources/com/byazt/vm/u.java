package com.byazt.vm;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, 67})
public final class u extends ve<com.byazt.fp.ve> {
    public u() {
        super("com.zui.deviceidservice");
    }

    @Override // com.byazt.vm.ve
    public zm.tt<com.byazt.fp.ve, String> c() {
        return new zm.tt<com.byazt.fp.ve, String>() { // from class: com.byazt.vm.u.1
            @Override // com.byazt.vm.zm.tt
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public com.byazt.fp.ve tt(IBinder iBinder) {
                return com.byazt.fp.ve.c.c(iBinder);
            }

            @Override // com.byazt.vm.zm.tt
            public String c(com.byazt.fp.ve veVar) throws Exception {
                if (veVar == null) {
                    return null;
                }
                return veVar.c();
            }
        };
    }

    @Override // com.byazt.vm.ve
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setClassName("com.zui.deviceidservice", "com.zui.deviceidservice.DeviceidService");
        return intent;
    }
}
