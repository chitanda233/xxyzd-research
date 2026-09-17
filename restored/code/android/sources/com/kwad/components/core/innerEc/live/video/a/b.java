package com.kwad.components.core.innerEc.live.video.a;

import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.IHostLivePlayer;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final IHostLivePlayer XY;

    public b(IHostLivePlayer iHostLivePlayer) {
        this.XY = iHostLivePlayer;
        com.kwad.sdk.core.d.c.d("LivePlayerController", "LivePlayerController create instance:" + iHostLivePlayer);
    }

    public final void a(a aVar) {
        this.XY.addOnCompletionListener(aVar);
    }

    public final void b(a aVar) {
        this.XY.removeOnCompletionListener(aVar);
    }

    public final void a(c cVar) {
        this.XY.addStateChangeListener(cVar);
    }

    public final boolean isBuffering() {
        com.kwad.sdk.core.d.c.d("LivePlayerController", "isBuffering:" + this.XY);
        IHostLivePlayer iHostLivePlayer = this.XY;
        if (iHostLivePlayer == null) {
            return false;
        }
        try {
            return iHostLivePlayer.isBuffering();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return false;
        }
    }

    public final boolean isPlaying() {
        com.kwad.sdk.core.d.c.d("LivePlayerController", "isPlaying:" + this.XY);
        IHostLivePlayer iHostLivePlayer = this.XY;
        if (iHostLivePlayer == null) {
            return false;
        }
        try {
            return iHostLivePlayer.isPlaying();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return false;
        }
    }

    public final void setPlayerReleaseReason(int i) {
        try {
            this.XY.setPlayerReleaseReason(i);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    public final void b(c cVar) {
        try {
            this.XY.removeStateChangeListener(cVar);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    public final void destroy() {
        try {
            this.XY.stopPlay();
            this.XY.destroy();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }
}
