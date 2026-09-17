package com.byazt.pop;

import android.os.Looper;
import com.byazt.bwm.sp;
import com.byazt.omf.rh;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 993, 13})
public class tt extends sp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1329a;
    public String c;
    public String n;
    public com.byazt.pop.c tt;
    public long uj;
    public long ve;

    public tt(String str) {
        super(str);
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.tt == null) {
        }
        String str = this.c;
        str.hashCode();
        switch (str) {
            case "onIdle":
                this.tt.c();
                break;
            case "onInstalled":
                this.tt.c(this.n, this.f1329a);
                break;
            case "onDownloadActive":
                this.tt.c(this.ve, this.uj, this.n, this.f1329a);
                break;
            case "onDownloadFailed":
                this.tt.ve(this.ve, this.uj, this.n, this.f1329a);
                break;
            case "onDownloadPaused":
                this.tt.tt(this.ve, this.uj, this.n, this.f1329a);
                break;
            case "onDownloadFinished":
                this.tt.c(this.ve, this.n, this.f1329a);
                break;
        }
    }

    @com.byazt.zqa.c(c = {0, 1, 993, MediaPlayer.MEDIA_PLAYER_OPTION_JX_CODEC_LOW_LATENCY})
    static class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public com.byazt.pop.c f1330a;
        public String c;
        public String n;
        public long tt;
        public String uj;
        public long ve;

        public c c(String str) {
            this.c = str;
            return this;
        }

        public c c(com.byazt.pop.c cVar) {
            this.f1330a = cVar;
            return this;
        }

        public c c(long j) {
            this.tt = j;
            return this;
        }

        public c tt(long j) {
            this.ve = j;
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

        public void c() {
            tt ttVar = new tt("tt_csj_download_thread");
            ttVar.f1329a = this.n;
            ttVar.n = this.uj;
            ttVar.uj = this.ve;
            ttVar.ve = this.tt;
            ttVar.c = this.c;
            ttVar.tt = this.f1330a;
            tt.tt(ttVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void tt(Runnable runnable) {
        if (Looper.myLooper() != Looper.getMainLooper()) {
            rh.a().post(runnable);
        } else {
            runnable.run();
        }
    }
}
