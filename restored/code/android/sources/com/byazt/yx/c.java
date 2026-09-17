package com.byazt.yx;

import com.byazt.eg.gt;
import com.byazt.eg.h;
import com.byazt.eg.p;
import com.byazt.eg.rl;
import com.byazt.eg.u;
import com.byazt.eg.yv;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.sigmob.sdk.base.e;
import java.io.IOException;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_HW_DEC_DROP_NON_REF, 20})
public final class c implements gt {
    public final u c;

    public c(u uVar) {
        this.c = uVar;
    }

    @Override // com.byazt.eg.gt
    public h c(gt.c cVar) throws IOException {
        yv yvVarC = cVar.c();
        yv.c cVarA = yvVarC.a();
        p pVarUj = yvVarC.uj();
        if (pVarUj != null) {
            rl rlVarC = pVarUj.c();
            if (rlVarC != null) {
                cVarA.c("Content-Type", rlVarC.toString());
            }
            long jTt = pVarUj.tt();
            if (jTt != -1) {
                cVarA.c(com.sigmob.sdk.downloader.core.c.e, Long.toString(jTt));
                cVarA.tt(com.sigmob.sdk.downloader.core.c.h);
            } else {
                cVarA.c(com.sigmob.sdk.downloader.core.c.h, "chunked");
                cVarA.tt(com.sigmob.sdk.downloader.core.c.e);
            }
        }
        boolean z = false;
        if (yvVarC.c("Host") == null) {
            cVarA.c("Host", com.byazt.kh.ve.c(yvVarC.c(), false));
        }
        if (yvVarC.c("Connection") == null) {
            cVarA.c("Connection", "Keep-Alive");
        }
        if (yvVarC.c("Accept-Encoding") == null && yvVarC.c(com.sigmob.sdk.downloader.core.c.b) == null) {
            cVarA.c("Accept-Encoding", "gzip");
            z = true;
        }
        List<com.byazt.eg.t> listC = this.c.c(yvVarC.c());
        if (!listC.isEmpty()) {
            cVarA.c(e.f3213a, c(listC));
        }
        if (yvVarC.c("User-Agent") == null) {
            cVarA.c("User-Agent", com.byazt.kh.uj.c());
        }
        h hVarC = cVar.c(cVarA.c());
        n.c(this.c, yvVarC.c(), hVarC.sp());
        h.c cVarC = hVarC.i().c(yvVarC);
        if (z && "gzip".equalsIgnoreCase(hVarC.c("Content-Encoding")) && n.ve(hVarC)) {
            com.byazt.mk.da daVar = new com.byazt.mk.da(hVarC.x().ve());
            cVarC.c(hVarC.sp().tt().tt("Content-Encoding").tt(com.sigmob.sdk.downloader.core.c.e).c());
            cVarC.c(new x(hVarC.c("Content-Type"), -1L, com.byazt.mk.t.c(daVar)));
        }
        return cVarC.c();
    }

    private String c(List<com.byazt.eg.t> list) {
        StringBuilder sb = new StringBuilder();
        int size = list.size();
        for (int i = 0; i < size; i++) {
            if (i > 0) {
                sb.append("; ");
            }
            com.byazt.eg.t tVar = list.get(i);
            sb.append(tVar.c()).append(com.alipay.sdk.m.p.a.h).append(tVar.tt());
        }
        return sb.toString();
    }
}
