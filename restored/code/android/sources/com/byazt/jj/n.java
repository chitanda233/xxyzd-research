package com.byazt.jj;

import android.util.SparseArray;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.function.Function;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_GET_CACHE_TIMESTAMP, 46})
public class n {
    public static Function<SparseArray<Object>, Object> c;

    public static void c(Function<SparseArray<Object>, Object> function) {
        c = function;
    }

    public static String c() {
        Function<SparseArray<Object>, Object> function = c;
        if (function != null) {
            Object objApply = function.apply(com.byazt.yxi.uj.c().c(AVMDLDataLoader.KeyIsStoIoWriteLimitKBTh1).c(String.class).tt());
            if (objApply instanceof String) {
                return objApply.toString();
            }
        }
        return null;
    }

    public static String tt() {
        Function<SparseArray<Object>, Object> function = c;
        if (function != null) {
            Object objApply = function.apply(com.byazt.yxi.uj.c().c(AVMDLDataLoader.KeyIsStoIoWriteLimitKBTh2).c(String.class).tt());
            if (objApply instanceof String) {
                return objApply.toString();
            }
        }
        return null;
    }

    public static String ve() {
        Function<SparseArray<Object>, Object> function = c;
        if (function != null) {
            Object objApply = function.apply(com.byazt.yxi.uj.c().c(AVMDLDataLoader.KeyIsStoMaxIdleTimeSec).c(String.class).tt());
            if (objApply instanceof String) {
                return objApply.toString();
            }
        }
        return null;
    }
}
