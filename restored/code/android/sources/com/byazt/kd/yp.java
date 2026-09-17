package com.byazt.kd;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1714, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public abstract class yp<V, O> implements u<V, O> {
    public final List<com.byazt.vc.c<V>> c;

    public yp(List<com.byazt.vc.c<V>> list) {
        this.c = list;
    }

    @Override // com.byazt.kd.u
    public List<com.byazt.vc.c<V>> ve() {
        return this.c;
    }

    @Override // com.byazt.kd.u
    public boolean tt() {
        return this.c.isEmpty() || (this.c.size() == 1 && this.c.get(0).n());
    }

    public String toString() {
        StringBuilder sb = new StringBuilder();
        if (!this.c.isEmpty()) {
            sb.append("values=").append(Arrays.toString(this.c.toArray()));
        }
        return sb.toString();
    }
}
