package com.byazt.pct;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 124, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public final class m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f1315a;
    public final int c;
    public final String n;
    public final String sp;
    public final String tt;
    public final String uj;
    public final String ve;
    public final String x;

    public static c c() {
        return new c();
    }

    public static m c(String str, int i) {
        return new m(str, i);
    }

    private m(String str, int i) {
        this.tt = null;
        this.ve = null;
        this.uj = null;
        this.n = null;
        this.f1315a = str;
        this.sp = null;
        this.c = i;
        this.x = null;
    }

    private m(c cVar) {
        this.tt = cVar.c;
        this.ve = cVar.tt;
        this.uj = cVar.ve;
        this.n = cVar.uj;
        this.f1315a = cVar.n;
        this.sp = cVar.f1316a;
        this.c = 1;
        this.x = cVar.sp;
    }

    public static boolean c(m mVar) {
        return mVar == null || mVar.c != 1 || TextUtils.isEmpty(mVar.uj) || TextUtils.isEmpty(mVar.n);
    }

    public String toString() {
        return "methodName: " + this.uj + ", params: " + this.n + ", callbackId: " + this.f1315a + ", type: " + this.ve + ", version: " + this.tt + ", ";
    }

    @com.byazt.zqa.c(c = {0, 1, 124, 600})
    public static final class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f1316a;
        public String c;
        public String n;
        public String sp;
        public String tt;
        public String uj;
        public String ve;

        private c() {
        }

        public c c(String str) {
            this.c = str;
            return this;
        }

        public c tt(String str) {
            this.tt = str;
            return this;
        }

        public c ve(String str) {
            this.ve = str;
            return this;
        }

        public c uj(String str) {
            this.uj = str;
            return this;
        }

        public c n(String str) {
            this.n = str;
            return this;
        }

        public c a(String str) {
            this.f1316a = str;
            return this;
        }

        public c sp(String str) {
            this.sp = str;
            return this;
        }

        public m c() {
            return new m(this);
        }
    }
}
