package com.byazt.iq;

import com.byazt.eg.gt;
import com.byazt.eg.gu;
import com.byazt.eg.h;
import com.byazt.eg.yv;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.IOException;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_PROBE_COUNT, 20})
public final class c implements gt {
    public final gu c;

    public c(gu guVar) {
        this.c = guVar;
    }

    @Override // com.byazt.eg.gt
    public h c(gt.c cVar) throws IOException {
        com.byazt.yx.sp spVar = (com.byazt.yx.sp) cVar;
        yv yvVarC = spVar.c();
        if (yvVarC != null && yvVarC.f843a != null) {
            yvVarC.f843a.tt();
        }
        sp spVarA = spVar.a();
        com.byazt.yx.ve veVarC = spVarA.c(this.c, cVar, !yvVarC.tt().equals("GET"));
        ve veVarTt = spVarA.tt();
        if (yvVarC != null && yvVarC.f843a != null) {
            yvVarC.f843a.ve();
        }
        return spVar.c(yvVarC, spVarA, veVarC, veVarTt);
    }
}
