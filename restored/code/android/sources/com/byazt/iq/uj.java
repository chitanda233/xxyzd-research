package com.byazt.iq;

import com.byazt.eg.eo;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.LinkedHashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_PROBE_COUNT, 15})
public final class uj {
    public final Set<eo> c = new LinkedHashSet();

    public synchronized void c(eo eoVar) {
        this.c.add(eoVar);
    }

    public synchronized void tt(eo eoVar) {
        this.c.remove(eoVar);
    }

    public synchronized boolean ve(eo eoVar) {
        return this.c.contains(eoVar);
    }
}
