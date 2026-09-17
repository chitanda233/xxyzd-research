package com.kwad.components.ad.splashscreen.presenter.playcard;

import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.utils.am;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private am Ki;
    private am Kj;
    private am Kk;
    private am Kl;
    private am Km;
    private am Kn;
    private float JY = 1.0f;
    private int Ko = 34;
    private int Kp = 19;
    private int Kq = 8;
    private int Kr = 12;

    public static c nF() {
        c cVar = new c();
        cVar.Ki = am.a(MediaPlayer.MEDIA_PLAYER_OPTION_STOP_SOURCE_ASYNC, 0, 0, 0, 0, 0);
        cVar.Kj = am.a(53, 53, 0, 0, 0, 0);
        cVar.Kk = am.a(0, 43, 0, 11, 0, 0);
        cVar.Kl = am.a(MediaPlayer.MEDIA_PLAYER_OPTION_STOP_SOURCE_ASYNC, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_HTTP_RES_FINSIH_TIME, 0, 8, 0, 0);
        cVar.Km = am.a(0, 0, 0, 8, 0, 0);
        cVar.Kn = am.a(0, 0, 0, 10, 0, 0);
        return cVar;
    }

    public static c c(float f) {
        c cVar = new c();
        cVar.Ki = am.a(MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_BITRATE, 0, 0, 0, 0, 0);
        cVar.Kj = am.a(33, 33, 0, 0, 0, 0);
        cVar.Kk = am.a(0, 26, 0, 11, 0, 0);
        cVar.Kl = am.a(MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_BITRATE, MediaPlayer.MEDIA_PLAYER_OPTION_BIT_RATE, 0, 6, 0, 0);
        cVar.Km = am.a(0, 0, 0, 6, 0, 0);
        cVar.Kn = am.a(0, 0, 0, 7, 0, 0);
        cVar.Ko = 21;
        cVar.Kp = 12;
        cVar.Kq = 6;
        cVar.JY = f;
        cVar.Kr = 8;
        return cVar;
    }

    public final am W(Context context) {
        return this.Ki.c(context, this.JY);
    }

    public final am X(Context context) {
        return this.Kj.c(context, this.JY);
    }

    public final am Y(Context context) {
        return this.Kk.c(context, this.JY);
    }

    public final am Z(Context context) {
        return this.Kl.c(context, this.JY);
    }

    public final am aa(Context context) {
        return this.Km.c(context, this.JY);
    }

    public final am ab(Context context) {
        return this.Kn.c(context, this.JY);
    }

    public final int ac(Context context) {
        return (int) (com.kwad.sdk.c.a.a.b(context, this.Ko) * this.JY);
    }

    public final int ad(Context context) {
        return (int) (com.kwad.sdk.c.a.a.b(context, this.Kp) * this.JY);
    }

    public final int ae(Context context) {
        return (int) (com.kwad.sdk.c.a.a.b(context, this.Kq) * this.JY);
    }

    public final int nG() {
        return this.Kr;
    }
}
