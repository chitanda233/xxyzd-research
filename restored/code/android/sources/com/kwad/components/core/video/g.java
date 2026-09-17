package com.kwad.components.core.video;

import android.content.Context;
import android.net.Uri;
import android.text.TextUtils;
import android.view.Surface;
import android.view.SurfaceHolder;
import com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.sigmob.sdk.base.n;
import java.io.FileDescriptor;
import java.lang.ref.WeakReference;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.sdk.core.video.a.a {
    private static AtomicBoolean anF = new AtomicBoolean(false);
    private String anB;
    private com.kwad.components.core.offline.a.b.a anD;
    private IAdWaynePlayerPlayModule anE;
    private AdTemplate mAdTemplate;
    private final String TAG = "KwaiWaynePlayer";
    private final Object anA = new Object();
    private boolean anG = false;
    private boolean anH = false;
    private boolean anI = false;
    private final a anC = new a(this, "KwaiWaynePlayer");

    @Override // com.kwad.sdk.core.video.a.c
    public final int getMediaPlayerType() {
        return 3;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setDataSource(Context context, Uri uri) {
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setDataSource(Context context, Uri uri, Map<String, String> map) {
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setDataSource(FileDescriptor fileDescriptor) {
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setScreenOnWhilePlaying(boolean z) {
    }

    static /* synthetic */ boolean a(g gVar, boolean z) {
        gVar.anI = true;
        return true;
    }

    public g(com.kwad.sdk.contentalliance.a.a.b bVar, AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        com.kwad.components.core.offline.a.b.a aVar = (com.kwad.components.core.offline.a.b.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.b.a.class);
        this.anD = aVar;
        if (aVar == null || !aVar.tF()) {
            return;
        }
        if (!TextUtils.isEmpty(bVar.manifest)) {
            this.anB = bVar.manifest;
            this.anE = this.anD.getAdWaynePlayerPlayModule(bVar.manifest, true);
        } else {
            this.anB = bVar.videoUrl;
            this.anE = this.anD.getAdWaynePlayerPlayModule(bVar.videoUrl, false);
        }
        if (this.anE != null) {
            anF.set(true);
            this.anE.setLooping(false);
            xW();
        }
    }

    public static boolean isWaynePlayerReady() {
        return anF.get();
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setDisplay(SurfaceHolder surfaceHolder) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule;
        synchronized (this.anA) {
            if (!this.anG && (iAdWaynePlayerPlayModule = this.anE) != null) {
                iAdWaynePlayerPlayModule.setDisplay(surfaceHolder);
            }
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setDataSource(String str) {
        if (this.anE != null) {
            this.anB = str;
            Uri uri = Uri.parse(str);
            String scheme = uri.getScheme();
            if (!TextUtils.isEmpty(scheme) && scheme.equalsIgnoreCase(n.z)) {
                this.anE.setDataSource(uri.getPath(), false);
            } else {
                this.anE.setDataSource(str, false);
            }
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void b(com.kwad.sdk.contentalliance.a.a.b bVar) {
        if (this.anE != null) {
            if (!TextUtils.isEmpty(bVar.manifest)) {
                this.anB = bVar.manifest;
                this.anE.setDataSource(bVar.manifest, true);
            } else {
                this.anB = bVar.videoUrl;
                this.anE.setDataSource(bVar.videoUrl, false);
            }
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final String getDataSource() {
        return this.anB;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final boolean prepareAsync() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule;
        if (!this.anH && (iAdWaynePlayerPlayModule = this.anE) != null) {
            try {
                this.anH = true;
                boolean zPrepareAsync = iAdWaynePlayerPlayModule.prepareAsync();
                OO();
                com.kwad.sdk.core.d.c.i("KwaiWaynePlayer", "prepareAsync result: " + zPrepareAsync);
                return zPrepareAsync;
            } catch (IllegalStateException e) {
                com.kwad.sdk.core.d.c.e("KwaiWaynePlayer", "prepareAsync failed ", e);
            }
        }
        return false;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void start() {
        if (this.anE != null) {
            com.kwad.sdk.core.d.c.i("KwaiWaynePlayer", "start");
            this.anE.start();
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final boolean xV() {
        return prepareAsync();
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void stop() {
        if (this.anE != null) {
            com.kwad.sdk.core.d.c.i("KwaiWaynePlayer", "stop");
            this.anE.stop();
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void pause() {
        if (this.anE != null) {
            com.kwad.sdk.core.d.c.i("KwaiWaynePlayer", com.sigmob.sdk.base.common.a.j);
            this.anE.pause();
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final int getVideoWidth() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.getVideoWidth();
        }
        return 0;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final int getVideoHeight() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.getVideoHeight();
        }
        return 0;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final String getCurrentPlayingUrl() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        return iAdWaynePlayerPlayModule != null ? iAdWaynePlayerPlayModule.getCurrentPlayingUrl() : "";
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final boolean isPlaying() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.isPlaying();
        }
        return false;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void seekTo(long j) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.seekTo(j);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final long getCurrentPosition() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.getCurrentPosition();
        }
        return 0L;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final long getDuration() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.getDuration();
        }
        return 0L;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void release() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            this.anG = true;
            iAdWaynePlayerPlayModule.release();
            try {
                resetListeners();
                xX();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void reset() {
        this.anH = false;
        try {
            IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
            if (iAdWaynePlayerPlayModule != null) {
                iAdWaynePlayerPlayModule.reset();
                resetListeners();
                xW();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setVolume(float f, float f2) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setVolume(f, f2);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setSpeed(float f) {
        try {
            IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
            if (iAdWaynePlayerPlayModule != null) {
                iAdWaynePlayerPlayModule.setSpeed(f);
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final int getAudioSessionId() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.getAudioSessionId();
        }
        return 0;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setLooping(boolean z) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setLooping(z);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final boolean isLooping() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            return iAdWaynePlayerPlayModule.isLooping();
        }
        return false;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setSurface(Surface surface) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setSurface(surface);
        }
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void setAudioStreamType(int i) {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setAudioStreamType(i);
        }
    }

    private void xW() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setOnPreparedListener(this.anC);
            this.anE.setOnCompletionListener(this.anC);
            this.anE.setOnBufferingUpdateListener(this.anC);
            this.anE.setOnSeekCompleteListener(this.anC);
            this.anE.setOnVideoSizeChangedListener(this.anC);
            this.anE.setOnErrorListener(this.anC);
            this.anE.setOnInfoListener(this.anC);
            this.anE.setOnVseReportListener(this.anC);
        }
    }

    private void xX() {
        IAdWaynePlayerPlayModule iAdWaynePlayerPlayModule = this.anE;
        if (iAdWaynePlayerPlayModule != null) {
            iAdWaynePlayerPlayModule.setOnPreparedListener(null);
            this.anE.setOnCompletionListener(null);
            this.anE.setOnBufferingUpdateListener(null);
            this.anE.setOnSeekCompleteListener(null);
            this.anE.setOnVideoSizeChangedListener(null);
            this.anE.setOnErrorListener(null);
            this.anE.setOnInfoListener(null);
            this.anE.setOnVseReportListener(null);
        }
    }

    public final void o(String str, String str2) {
        final com.kwad.components.core.video.a.e eVar = new com.kwad.components.core.video.a.e();
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate != null) {
            eVar.setAdTemplate(adTemplate);
        }
        eVar.bp(str);
        eVar.bq(str2);
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.components.core.video.g.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.w(eVar);
            }
        });
    }

    static class a implements IAdWaynePlayerPlayModule.OnBufferingUpdateListener, IAdWaynePlayerPlayModule.OnCompletionListener, IAdWaynePlayerPlayModule.OnErrorListener, IAdWaynePlayerPlayModule.OnInfoListener, IAdWaynePlayerPlayModule.OnPreparedListener, IAdWaynePlayerPlayModule.OnSeekCompleteListener, IAdWaynePlayerPlayModule.OnVideoSizeChangedListener, IAdWaynePlayerPlayModule.OnVseReportListener {
        final String TAG;
        final WeakReference<g> mWeakMediaPlayer;

        a(g gVar, String str) {
            this.mWeakMediaPlayer = new WeakReference<>(gVar);
            this.TAG = str;
        }

        private g xY() {
            return this.mWeakMediaPlayer.get();
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnPreparedListener
        public final void onPrepared() {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.notifyOnPrepared();
            }
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnInfoListener
        public final boolean onInfo(int i, int i2) {
            g gVarXY = xY();
            if (gVarXY == null) {
                return false;
            }
            if (i == 3) {
                if (gVarXY.anI) {
                    return false;
                }
                g.a(gVarXY, true);
                return gVarXY.notifyOnInfo(i, i2);
            }
            return gVarXY.notifyOnInfo(i, i2);
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnErrorListener
        public final boolean onError(int i, int i2) {
            g gVarXY = xY();
            if (gVarXY != null) {
                return gVarXY.notifyOnError(i, i2);
            }
            return false;
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnVideoSizeChangedListener
        public final void onVideoSizeChanged(int i, int i2) {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.D(i, i2);
            }
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnSeekCompleteListener
        public final void onSeekComplete() {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.notifyOnSeekComplete();
            }
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnBufferingUpdateListener
        public final void onBufferingUpdate(int i) {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.notifyOnBufferingUpdate(i);
            }
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnCompletionListener
        public final void onCompletion() {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.notifyOnCompletion();
            }
        }

        @Override // com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule.OnVseReportListener
        public final void onVseReport(String str, String str2) {
            g gVarXY = xY();
            if (gVarXY != null) {
                gVarXY.o(str, str2);
            }
        }
    }
}
