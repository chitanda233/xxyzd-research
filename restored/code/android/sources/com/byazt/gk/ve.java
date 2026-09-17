package com.byazt.gk;

import android.os.Looper;
import android.util.SparseArray;
import com.byazt.omf.rh;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.function.Function;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_EANABLE_DROPPING_DTS_ROLLBACK, 54})
public class ve extends com.byazt.nh.c implements tt {
    public long c;

    public ve(Function<SparseArray<Object>, Object> function) {
        super(function);
        this.c = System.currentTimeMillis();
    }

    @Override // com.byazt.nh.c
    public void c(final com.byazt.nc.tt ttVar) {
        if (com.byazt.cc.a.ve()) {
            super.c(ttVar);
        } else {
            com.byazt.bzd.x.c(new Runnable() { // from class: com.byazt.gk.ve.1
                @Override // java.lang.Runnable
                public void run() {
                    ve.super.c(ttVar);
                }
            });
        }
    }

    @Override // com.byazt.nh.c
    public void c(final com.byazt.nc.c cVar) {
        if (Looper.myLooper() == Looper.getMainLooper()) {
            super.c(cVar);
        } else {
            rh.a().post(new Runnable() { // from class: com.byazt.gk.ve.2
                @Override // java.lang.Runnable
                public void run() {
                    ve.super.c(cVar);
                }
            });
        }
    }

    @Override // com.byazt.nh.c
    public void tt(final com.byazt.nc.tt ttVar) {
        if (Looper.myLooper() == Looper.getMainLooper()) {
            super.tt(ttVar);
        } else {
            rh.a().post(new Runnable() { // from class: com.byazt.gk.ve.3
                @Override // java.lang.Runnable
                public void run() {
                    ve.super.tt(ttVar);
                }
            });
        }
    }

    @Override // com.byazt.nh.c
    public void c(final com.byazt.nc.tt ttVar, final com.byazt.nc.c cVar) {
        if (Looper.myLooper() == Looper.getMainLooper()) {
            super.c(ttVar, cVar);
        } else {
            rh.a().post(new Runnable() { // from class: com.byazt.gk.ve.4
                @Override // java.lang.Runnable
                public void run() {
                    ve.super.c(ttVar, cVar);
                }
            });
        }
    }

    @Override // com.byazt.gk.tt
    public long tt() {
        return this.c;
    }
}
