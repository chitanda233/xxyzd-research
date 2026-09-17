package com.byazt.aas;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 131, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO})
public class zb<K, V> extends HashMap<K, V> {
    /* JADX WARN: Multi-variable type inference failed */
    public zb<String, Object> c(K k, V v) {
        put(k, v);
        return this;
    }

    /* JADX WARN: Multi-variable type inference failed */
    public zb<String, Object> c(Map<? extends K, ? extends V> map) {
        putAll(map);
        return this;
    }
}
