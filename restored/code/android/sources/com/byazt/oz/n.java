package com.byazt.oz;

import com.byazt.yj.d;
import com.byazt.yj.eo;
import com.byazt.yj.my;
import com.byazt.yj.qp;
import com.byazt.yj.rh;
import com.byazt.yj.zb;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 213, 46})
public final class n implements my {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.byazt.yj.uj f1305a;
    public rh c;
    public qp i;
    public zb n;
    public d sp;
    public ExecutorService tt;
    public eo uj;
    public com.byazt.yj.n ve;
    public com.byazt.yj.tt x;

    private n(c cVar) {
        this.c = cVar.c;
        this.tt = cVar.tt;
        this.ve = cVar.ve;
        this.uj = cVar.uj;
        this.n = cVar.n;
        this.f1305a = cVar.f1306a;
        this.x = cVar.x;
        this.sp = cVar.sp;
        this.i = cVar.i;
    }

    @Override // com.byazt.yj.my
    public rh c() {
        return this.c;
    }

    @Override // com.byazt.yj.my
    public ExecutorService tt() {
        return this.tt;
    }

    @Override // com.byazt.yj.my
    public com.byazt.yj.n uj() {
        return this.ve;
    }

    @Override // com.byazt.yj.my
    public eo n() {
        return this.uj;
    }

    @Override // com.byazt.yj.my
    public zb a() {
        return this.n;
    }

    @Override // com.byazt.yj.my
    public com.byazt.yj.uj sp() {
        return this.f1305a;
    }

    @Override // com.byazt.yj.my
    public d x() {
        return this.sp;
    }

    @Override // com.byazt.yj.my
    public qp ve() {
        return this.i;
    }

    @Override // com.byazt.yj.my
    public com.byazt.yj.tt i() {
        return this.x;
    }

    public static n da() {
        return new c().c();
    }

    @com.byazt.zqa.c(c = {0, 1, 213, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS})
    public static class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public com.byazt.yj.uj f1306a;
        public rh c;
        public qp i;
        public zb n;
        public d sp;
        public ExecutorService tt;
        public eo uj;
        public com.byazt.yj.n ve;
        public com.byazt.yj.tt x;

        public c c(com.byazt.yj.tt ttVar) {
            this.x = ttVar;
            return this;
        }

        public c c(ExecutorService executorService) {
            this.tt = executorService;
            return this;
        }

        public c c(com.byazt.yj.n nVar) {
            this.ve = nVar;
            return this;
        }

        public n c() {
            return new n(this);
        }
    }
}
