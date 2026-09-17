package com.byazt.eg;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 16, MediaPlayer.MEDIA_PLAYER_OPTION_IS_TOO_LARGE_AV_DIFF})
public class md {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f830a;
    public long c = System.currentTimeMillis();
    public long n;
    public long sp;
    public long tt;
    public long uj;
    public long ve;

    public void c() {
        this.ve = System.currentTimeMillis();
    }

    public void tt() {
        this.uj = System.currentTimeMillis();
    }

    public void ve() {
        this.n = System.currentTimeMillis();
    }

    public long uj() {
        return this.c;
    }

    public long n() {
        return this.ve;
    }

    public long a() {
        return this.uj;
    }

    public long sp() {
        return this.n;
    }

    public long x() {
        return this.f830a;
    }

    public void c(long j) {
        this.f830a = j;
    }

    public long i() {
        return this.sp;
    }

    public void tt(long j) {
        this.sp = j;
    }

    public long da() {
        return this.tt;
    }

    public void sl() {
        this.tt = System.currentTimeMillis();
    }

    public String toString() {
        return "RequestHttpTime{requestBuildTs=" + this.c + ", asyncCallExecTs=" + this.tt + ", requestStartExecTs=" + this.ve + ", requestConnectStartTs=" + this.uj + ", requestConnectFinishTs=" + this.n + ", reqCallServerStartTs=" + this.f830a + ", reqCallServerFinishTs=" + this.sp + '}';
    }
}
