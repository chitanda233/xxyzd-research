package com.byazt.yv;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 499, 158})
public class sl {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f1597a;
    public final String c;
    public final String n;
    public final String sp;
    public final String[] tt;
    public final String uj;
    public final String[] ve;

    private sl(c cVar) {
        this.c = cVar.c;
        this.tt = cVar.tt;
        this.ve = cVar.ve;
        this.uj = cVar.uj;
        this.n = cVar.n;
        this.f1597a = cVar.f1598a;
        this.sp = cVar.sp;
    }

    @com.byazt.zqa.c(c = {0, 1, 499, MediaPlayer.MEDIA_PLAYER_OPTION_QUIC_VERSION})
    public static class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f1598a;
        public String c;
        public String n;
        public String sp;
        public String[] tt;
        public String uj;
        public String[] ve;

        public c c(String str) {
            this.c = str;
            return this;
        }

        public c c(String[] strArr) {
            this.tt = strArr;
            return this;
        }

        public c tt(String[] strArr) {
            this.ve = strArr;
            return this;
        }

        public c tt(String str) {
            this.uj = str;
            return this;
        }

        public c ve(String str) {
            this.n = str;
            return this;
        }

        public c uj(String str) {
            this.sp = str;
            return this;
        }

        public sl c() {
            return new sl(this);
        }
    }

    public String c() {
        return this.c;
    }

    public String[] tt() {
        return this.tt;
    }

    public String ve() {
        return this.uj;
    }

    public String uj() {
        return this.n;
    }

    public static sl c(int i) {
        return t.c(i);
    }
}
