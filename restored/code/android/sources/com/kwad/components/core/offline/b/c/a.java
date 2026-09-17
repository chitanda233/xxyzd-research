package com.kwad.components.core.offline.b.c;

import android.content.Context;
import android.view.Surface;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.components.offline.api.core.video.IKsMediaPlayer;
import com.kwad.components.offline.api.core.video.IKsMediaPlayerView;
import com.kwad.components.offline.api.core.video.IMediaPlayer;
import com.kwad.components.offline.api.core.video.listener.OfflineVideoPlayStateListener;
import com.kwad.components.offline.api.core.video.listener.ReleaseCallback;
import com.kwad.components.offline.api.core.video.listener.VideoMuteStateChangeListener;
import com.kwad.components.offline.api.core.video.mdoel.KsPlayerLogParams;
import com.kwad.components.offline.api.core.video.mdoel.PlayVideoInfo;
import com.kwad.sdk.utils.az;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
final class a implements IKsMediaPlayer {
    private boolean Cw;
    private OfflineOnAudioConflictListener Cz;
    private com.kwad.components.core.video.b acA;
    private c acB;
    private VideoMuteStateChangeListener acC;
    private boolean acD;
    private Context mContext;
    private DetailVideoView mDetailVideoView;
    private boolean qG = true;
    private int acE = -1;

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getMaxVolume() {
        return 0;
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getVolume() {
        return 0;
    }

    a() {
    }

    static /* synthetic */ boolean b(a aVar, boolean z) {
        aVar.qG = false;
        return false;
    }

    public final a a(com.kwad.components.core.video.b bVar) {
        az.checkNotNull(bVar);
        this.acA = bVar;
        return this;
    }

    public final com.kwad.components.core.video.b tS() {
        return this.acA;
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final IMediaPlayer getMediaPlayer() {
        com.kwad.sdk.core.video.a.c cVarXy = this.acA.xy();
        if (cVarXy == null) {
            return null;
        }
        c cVar = this.acB;
        if (cVar == null || cVar.tV() != cVarXy) {
            this.acB = new c().b(cVarXy);
        }
        return this.acB;
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setSurface(Surface surface) {
        this.acA.setSurface(surface);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void initMediaPlayer(PlayVideoInfo playVideoInfo, IKsMediaPlayerView iKsMediaPlayerView) {
        if (!(iKsMediaPlayerView instanceof b)) {
            com.kwad.sdk.core.d.c.e("KsMediaPlayer", "videoView not instanceof KsMediaPlayerView");
            return;
        }
        DetailVideoView detailVideoViewTU = ((b) iKsMediaPlayerView).tU();
        this.mDetailVideoView = detailVideoViewTU;
        this.mContext = detailVideoViewTU.getContext().getApplicationContext();
        this.acA.a(d.a(playVideoInfo), this.mDetailVideoView);
        int i = this.acE;
        if (i != -1) {
            setVideoAdaptStrategy(i);
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void initMediaPlayer(PlayVideoInfo playVideoInfo, boolean z, boolean z2, IKsMediaPlayerView iKsMediaPlayerView) {
        if (!(iKsMediaPlayerView instanceof b)) {
            com.kwad.sdk.core.d.c.e("KsMediaPlayer", "videoView not instanceof KsMediaPlayerView");
        } else {
            this.acA.a(d.a(playVideoInfo), z, z2, ((b) iKsMediaPlayerView).tU());
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getMediaPlayerType() {
        return this.acA.getMediaPlayerType();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void addOnPreparedListener(IMediaPlayer.OnPreparedListener onPreparedListener) {
        this.acA.a(d.a(getMediaPlayer(), onPreparedListener));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void addOnInfoListener(IMediaPlayer.OnInfoListener onInfoListener) {
        this.acA.a(d.a(getMediaPlayer(), onInfoListener));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void removeInfoListener(IMediaPlayer.OnInfoListener onInfoListener) {
        this.acA.b(d.a(getMediaPlayer(), onInfoListener));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void notifyOnInfoListener(IMediaPlayer iMediaPlayer, int i, int i2) {
        if (!(iMediaPlayer instanceof c)) {
            com.kwad.sdk.core.d.c.e("KsMediaPlayer", "videoView not instanceof KsMediaPlayerView");
        } else {
            this.acA.a(((c) iMediaPlayer).tV(), i, i2);
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setRadius(float f, float f2, float f3, float f4) {
        this.acA.setRadius(f, f2, f3, f4);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final boolean isPreparing() {
        return this.acA.isPreparing();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final boolean isPrepared() {
        return this.acA.isPrepared();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final boolean isPlaying() {
        return this.acA.isPlaying();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setDataSource(PlayVideoInfo playVideoInfo) {
        this.acA.b(d.a(playVideoInfo));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void prepareAsync() {
        this.acA.prepareAsync();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void start() {
        this.acA.start();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void start(long j) {
        this.acA.start(j);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void restart() {
        this.acA.restart();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void resetAndPlay(PlayVideoInfo playVideoInfo) {
        com.kwad.components.core.video.b bVar = this.acA;
        d.a(playVideoInfo);
        bVar.xB();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void resume() {
        this.acA.resume();
        if (this.qG || (this.acD && this.Cw)) {
            Context context = this.mContext;
            if (context != null) {
                com.kwad.components.core.t.a.aN(context).bd(this.acD);
            }
            if (this.acD && this.Cw) {
                this.Cw = false;
                setAudioEnabled(true);
                this.qG = true;
            } else if (this.Cw) {
                setAudioEnabled(false);
            }
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void stopAndPrepareAsync() {
        this.acA.stopAndPrepareAsync();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final boolean pause() {
        return this.acA.pause();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void release(ReleaseCallback releaseCallback, boolean z) {
        this.acA.a(d.a(releaseCallback), z);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void release(ReleaseCallback releaseCallback) {
        this.acA.a(d.a(releaseCallback));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void release() {
        this.acA.release();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void releaseAsync() {
        Context context = this.mContext;
        if (context != null) {
            com.kwad.components.core.t.a.aN(context).b(this.Cz);
        }
        this.acA.releaseAsync();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void seekTo(long j) {
        this.acA.seekTo(j);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setVolume(float f, float f2) {
        this.acA.setVolume(f, f2);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setAudioEnabled(final boolean z) {
        Context context;
        if (z && (context = this.mContext) != null) {
            com.kwad.components.core.t.a.aN(context).bd(true);
        }
        if (z == this.qG) {
            com.kwad.sdk.core.video.a.a.a.fq("autoVoice");
        } else {
            this.qG = z;
            by.runOnUiThread(new bi() { // from class: com.kwad.components.core.offline.b.c.a.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    a.this.acA.setAudioEnabled(z);
                    if (a.this.acC != null) {
                        a.this.acC.onMuteStateChanged(!z);
                    }
                }
            });
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setSpeed(float f) {
        this.acA.setSpeed(f);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getVideoWidth() {
        return this.acA.getVideoWidth();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getVideoHeight() {
        return this.acA.getVideoHeight();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final long getDuration() {
        return this.acA.getDuration();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final long getPlayDuration() {
        return this.acA.getPlayDuration();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final long getCurrentPosition() {
        return this.acA.getCurrentPosition();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final int getBufferPercentage() {
        return this.acA.getBufferPercentage();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void registerVideoPlayStateListener(OfflineVideoPlayStateListener offlineVideoPlayStateListener) {
        this.acA.c(d.a(offlineVideoPlayStateListener));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void unRegisterVideoPlayStateListener(OfflineVideoPlayStateListener offlineVideoPlayStateListener) {
        this.acA.d(d.a(offlineVideoPlayStateListener));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void registerVideoMuteStateListener(VideoMuteStateChangeListener videoMuteStateChangeListener) {
        this.acC = videoMuteStateChangeListener;
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void clear() {
        this.acA.clear();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void onPlayStateChanged(int i) {
        this.acA.onPlayStateChanged(i);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final String getStateString(int i) {
        return com.kwad.components.core.video.b.getStateString(i);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void updateKsPlayLogParam(KsPlayerLogParams ksPlayerLogParams) {
        this.acA.a(d.a(ksPlayerLogParams));
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final String getCurrentPlayingUrl() {
        return this.acA.getCurrentPlayingUrl();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setForceGetAudioFocus(boolean z) {
        this.acD = z;
        Context context = this.mContext;
        if (context != null) {
            com.kwad.components.core.t.a.aN(context).a(tT());
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setVideoAdaptStrategy(int i) {
        this.acE = i;
        DetailVideoView detailVideoView = this.mDetailVideoView;
        if (detailVideoView != null) {
            detailVideoView.g(true, i);
        }
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setIsAlphaVideoPlayer(boolean z) {
        this.acA.setIsAlphaVideoPlayer(z);
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final boolean getAlphaVideoValid() {
        return this.acA.getAlphaVideoValid();
    }

    @Override // com.kwad.components.offline.api.core.video.IKsMediaPlayer
    public final void setTKPlayer() {
        this.acA.setTKPlayer();
    }

    private OfflineOnAudioConflictListener tT() {
        if (this.Cz == null) {
            this.Cz = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.core.offline.b.c.a.2
                @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
                public final void onAudioBeOccupied() {
                    if (a.this.qG) {
                        a.this.Cw = true;
                        a.b(a.this, false);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.offline.b.c.a.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            a.this.acA.setAudioEnabled(false);
                            if (a.this.acC != null) {
                                a.this.acC.onMuteStateChanged(true);
                            }
                        }
                    });
                }

                @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
                public final void onAudioBeReleased() {
                    a.this.Cw = false;
                }
            };
        }
        return this.Cz;
    }
}
