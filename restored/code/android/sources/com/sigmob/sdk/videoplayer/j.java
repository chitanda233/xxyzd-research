package com.sigmob.sdk.videoplayer;

import android.graphics.SurfaceTexture;
import android.media.MediaPlayer;
import android.media.PlaybackParams;
import android.os.Handler;
import android.view.Surface;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.logger.SigmobLog;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class j extends i implements MediaPlayer.OnBufferingUpdateListener, MediaPlayer.OnCompletionListener, MediaPlayer.OnErrorListener, MediaPlayer.OnInfoListener, MediaPlayer.OnPreparedListener, MediaPlayer.OnSeekCompleteListener, MediaPlayer.OnVideoSizeChangedListener {
    private static final String f = "VideoPlayerMediaSystem";
    public MediaPlayer e;
    private boolean g;

    public j(h videoPlayerListener) {
        super(videoPlayerListener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(int i) {
        if (this.d == null) {
            return;
        }
        this.d.setBufferProgress(i);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(int i, int i2) {
        if (this.d == null) {
            return;
        }
        this.d.c(i, i2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(MediaPlayer mediaPlayer) {
        mediaPlayer.reset();
        mediaPlayer.setSurface(null);
        mediaPlayer.release();
        this.b = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(int i, int i2) {
        if (this.d == null) {
            return;
        }
        this.d.b(i, i2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(long j) {
        try {
            MediaPlayer mediaPlayer = this.e;
            if (mediaPlayer == null) {
                return;
            }
            mediaPlayer.seekTo((int) j);
        } catch (IllegalStateException e) {
            e.printStackTrace();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(float f2) {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setVolume(f2, f2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(int i, int i2) {
        if (this.d == null) {
            return;
        }
        this.d.a(i, i2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void k() {
        if (this.d == null) {
            return;
        }
        this.d.q();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void l() {
        if (this.d == null) {
            return;
        }
        this.d.p();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void m() {
        if (this.d == null) {
            return;
        }
        SigmobLog.d("VideoPlayerMediaSystem mediaPlayer onPrepared [" + hashCode() + "] ");
        this.d.o();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void n() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.pause();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void o() {
        if (this.e == null) {
            return;
        }
        SigmobLog.d("VideoPlayerMediaSystem mediaPlayer start [" + hashCode() + "] ");
        this.e.start();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void p() {
        try {
            g videoPlayerDataSource = this.d.getVideoPlayerDataSource();
            MediaPlayer mediaPlayer = new MediaPlayer();
            this.e = mediaPlayer;
            mediaPlayer.setAudioStreamType(3);
            this.e.setLooping(videoPlayerDataSource.e);
            this.e.setOnPreparedListener(this);
            this.e.setOnCompletionListener(this);
            this.e.setOnBufferingUpdateListener(this);
            this.e.setScreenOnWhilePlaying(true);
            this.e.setOnSeekCompleteListener(this);
            this.e.setOnErrorListener(this);
            this.e.setOnInfoListener(this);
            this.e.setOnVideoSizeChangedListener(this);
            MediaPlayer.class.getDeclaredMethod("setDataSource", String.class, Map.class).invoke(this.e, videoPlayerDataSource.a().toString(), videoPlayerDataSource.d);
            this.e.prepareAsync();
            if (this.f3697a != null) {
                this.g = false;
                this.e.setSurface(new Surface(this.f3697a));
            }
        } catch (Exception e) {
            e.printStackTrace();
            this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda12
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.q();
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void q() {
        if (this.d == null) {
            return;
        }
        this.d.a(0, 0);
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void a() {
        if (this.b == null) {
            return;
        }
        this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda5
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.o();
            }
        });
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void a(final float leftVolume) {
        if (this.b == null) {
            return;
        }
        this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda8
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.c(leftVolume);
            }
        });
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void a(final long time) {
        if (this.b == null) {
            return;
        }
        this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(time);
            }
        });
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void a(Surface surface) {
        SigmobLog.d("setSurface() called with: surface = [" + surface + "]");
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setSurface(surface);
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void a(boolean loop) {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setLooping(loop);
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void b() {
        c();
        this.g = true;
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void b(float speed) {
        if (this.e == null) {
            return;
        }
        PlaybackParams playbackParams = this.e.getPlaybackParams();
        playbackParams.setSpeed(speed);
        this.e.setPlaybackParams(playbackParams);
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void c() {
        if (this.g && this.e != null && this.f3697a != null) {
            this.g = false;
            this.e.setSurface(new Surface(this.f3697a));
        } else {
            f();
            this.c = new Handler();
            this.b = ThreadPoolFactory.BackgroundThreadPool.getInstance().getIOHandler();
            this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda3
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.p();
                }
            });
        }
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void d() {
        if (this.b == null || this.e == null) {
            return;
        }
        this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda7
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.n();
            }
        });
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public boolean e() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return false;
        }
        return mediaPlayer.isPlaying();
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public void f() {
        final MediaPlayer mediaPlayer;
        if (this.b == null || (mediaPlayer = this.e) == null) {
            return;
        }
        this.b.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda6
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(mediaPlayer);
            }
        });
        this.e = null;
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public long g() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return 0L;
        }
        return mediaPlayer.getCurrentPosition();
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public int h() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return 0;
        }
        mediaPlayer.getVideoWidth();
        return 0;
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public int i() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return 0;
        }
        mediaPlayer.getVideoHeight();
        return 0;
    }

    @Override // com.sigmob.sdk.videoplayer.i
    public long j() {
        MediaPlayer mediaPlayer = this.e;
        if (mediaPlayer == null) {
            return 0L;
        }
        return mediaPlayer.getDuration();
    }

    @Override // android.media.MediaPlayer.OnBufferingUpdateListener
    public void onBufferingUpdate(MediaPlayer mediaPlayer, final int percent) {
        if (this.c == null) {
            return;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda4
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(percent);
            }
        });
    }

    @Override // android.media.MediaPlayer.OnCompletionListener
    public void onCompletion(MediaPlayer mediaPlayer) {
        if (this.c == null) {
            return;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda9
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.l();
            }
        });
    }

    @Override // android.media.MediaPlayer.OnErrorListener
    public boolean onError(MediaPlayer mediaPlayer, final int what, final int extra) {
        if (this.c == null) {
            return false;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda10
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.c(what, extra);
            }
        });
        return true;
    }

    @Override // android.media.MediaPlayer.OnInfoListener
    public boolean onInfo(MediaPlayer mediaPlayer, final int what, final int extra) {
        if (this.c != null && this.d != null) {
            this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b(what, extra);
                }
            });
        }
        return false;
    }

    @Override // android.media.MediaPlayer.OnPreparedListener
    public void onPrepared(MediaPlayer mediaPlayer) {
        if (this.c == null) {
            return;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.m();
            }
        });
    }

    @Override // android.media.MediaPlayer.OnSeekCompleteListener
    public void onSeekComplete(MediaPlayer mediaPlayer) {
        if (this.c == null) {
            return;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda11
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.k();
            }
        });
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public void onSurfaceTextureAvailable(SurfaceTexture surface, int width, int height) {
        if (this.d == null) {
            return;
        }
        SigmobLog.d("onSurfaceTextureAvailable() called with: surface = [" + surface + "], width = [" + width + "], height = [" + height + "]");
        if (this.f3697a != null) {
            this.d.setSurfaceTexture(this.f3697a);
        } else {
            this.f3697a = surface;
            c();
        }
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public boolean onSurfaceTextureDestroyed(SurfaceTexture surface) {
        SigmobLog.d("onSurfaceTextureDestroyed() called with: surface = [" + surface + "]");
        return false;
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public void onSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height) {
        SigmobLog.d("onSurfaceTextureSizeChanged() called with: surface = [" + surface + "], width = [" + width + "], height = [" + height + "]");
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public void onSurfaceTextureUpdated(SurfaceTexture surface) {
    }

    @Override // android.media.MediaPlayer.OnVideoSizeChangedListener
    public void onVideoSizeChanged(MediaPlayer mediaPlayer, final int width, final int height) {
        if (this.c == null) {
            return;
        }
        this.c.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.j$$ExternalSyntheticLambda13
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(width, height);
            }
        });
    }
}
