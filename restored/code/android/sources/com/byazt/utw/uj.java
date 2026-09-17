package com.byazt.utw;

import android.content.Context;
import com.byazt.nr.m;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Set;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_CMAF_MPD_SOCKET_CONNECT_TIME, 15})
public final class uj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static volatile boolean f1491a = false;
    public static volatile com.byazt.byh.tt c = null;
    public static volatile com.byazt.emg.ve da = null;
    public static volatile Context sl = null;
    public static volatile com.byazt.byh.ve tt = null;
    public static volatile Integer uj = null;
    public static volatile int ve = 3;
    public static volatile boolean x;
    public static final boolean n = m.ve();
    public static volatile boolean sp = true;
    public static volatile int i = 0;

    public static Context getContext() {
        return sl;
    }

    public static void c(boolean z) {
        x = z;
    }

    public static void c(int i2) {
        i = i2;
    }

    public static void c(com.byazt.byh.ve veVar, Context context) {
        if (veVar == null || context == null) {
            throw new IllegalArgumentException("DiskLruCache and Context can't be null !!!");
        }
        sl = context.getApplicationContext();
        if (tt != null) {
            return;
        }
        com.byazt.byh.tt ttVar = c;
        if (ttVar != null && ttVar.c.getAbsolutePath().equals(veVar.c.getAbsolutePath())) {
            throw new IllegalArgumentException("DiskLruCache and DiskCache can't use the same dir");
        }
        tt = veVar;
        da = com.byazt.emg.ve.c(context);
        tt.c(new com.byazt.byh.ve.c() { // from class: com.byazt.utw.uj.1
            @Override // com.byazt.byh.ve.c
            public void c(String str) {
                if (uj.n) {
                    m.c("TAG_PROXY_DiskLruCache", "new cache created: ".concat(String.valueOf(str)));
                }
            }

            @Override // com.byazt.byh.ve.c
            public void c(Set<String> set) {
                uj.da.c(set, 0);
                if (uj.n) {
                    m.c("TAG_PROXY_DiskLruCache", "cache file removed, ".concat(String.valueOf(set)));
                }
            }
        });
        ve veVarC = ve.c();
        veVarC.c(veVar);
        veVarC.c(da);
    }

    public static com.byazt.byh.ve c() {
        return tt;
    }

    public static com.byazt.byh.tt tt() {
        return c;
    }
}
