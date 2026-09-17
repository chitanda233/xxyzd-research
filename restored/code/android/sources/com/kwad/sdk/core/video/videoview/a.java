package com.kwad.sdk.core.video.videoview;

import android.content.Context;
import android.graphics.SurfaceTexture;
import android.media.AudioManager;
import android.util.AttributeSet;
import android.view.Surface;
import android.view.TextureView;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.internal.view.SupportMenu;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.video.a.f;
import com.kwad.sdk.core.view.AdBasePvFrameLayout;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.i;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
@Deprecated
public final class a extends AdBasePvFrameLayout implements TextureView.SurfaceTextureListener, c {
    private static AtomicBoolean aZC = new AtomicBoolean(false);
    private int Vt;
    private b aZA;
    private boolean aZB;
    private boolean aZD;
    private boolean aZE;
    private ImageView aZF;
    private boolean aZG;
    private AudioManager aZy;
    private com.kwad.sdk.core.video.a aZz;
    private com.kwad.sdk.core.video.a.c amA;
    private int amB;
    private long amC;
    private com.kwad.sdk.contentalliance.a.a.b amE;
    private com.kwad.sdk.core.video.a.c.e amP;
    private com.kwad.sdk.core.video.a.c.i amQ;
    private com.kwad.sdk.core.video.a.c.b amR;
    private com.kwad.sdk.core.video.a.c.InterfaceC0518c amS;
    private com.kwad.sdk.core.video.a.c.d amT;
    private com.kwad.sdk.core.video.a.c.a amU;
    private SurfaceTexture anc;
    private TextView and;
    private Surface ane;
    private InterfaceC0519a cK;
    private FrameLayout dz;
    private com.kwad.sdk.contentalliance.a.a.a ft;
    private Context mContext;
    private Map<String, String> mHeaders;
    private String mUrl;
    private final long maxTimeOut;

    /* JADX INFO: renamed from: com.kwad.sdk.core.video.videoview.a$a, reason: collision with other inner class name */
    public interface InterfaceC0519a {
        com.kwad.sdk.core.video.a.c a(com.kwad.sdk.contentalliance.a.a.b bVar);
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public final boolean onSurfaceTextureDestroyed(SurfaceTexture surfaceTexture) {
        return false;
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public final void onSurfaceTextureSizeChanged(SurfaceTexture surfaceTexture, int i, int i2) {
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public final void onSurfaceTextureUpdated(SurfaceTexture surfaceTexture) {
    }

    public a(Context context) {
        this(context, null);
    }

    private a(Context context, AttributeSet attributeSet) {
        super(context, null);
        this.Vt = 0;
        this.aZB = false;
        this.aZD = false;
        this.aZE = false;
        this.maxTimeOut = ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT;
        this.amP = new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.sdk.core.video.videoview.a.1
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar) {
                try {
                    a.this.Vt = 2;
                    a.this.aZA.onPlayStateChanged(a.this.Vt);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onPrepared ——> STATE_PREPARED");
                    if (a.this.aZG) {
                        a.this.release();
                        return;
                    }
                    cVar.start();
                    if (a.this.aZB) {
                        cVar.seekTo((int) ai.ab(a.this.mContext, a.this.mUrl));
                    }
                    if (a.this.amC != 0) {
                        cVar.seekTo((int) a.this.amC);
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
        this.amQ = new com.kwad.sdk.core.video.a.c.i() { // from class: com.kwad.sdk.core.video.videoview.a.2
            @Override // com.kwad.sdk.core.video.a.c.i
            public final void m(int i, int i2) {
                if (!a.this.aZE || i2 <= i) {
                    a.this.aZz.adaptVideoSize(i, i2);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onVideoSizeChanged ——> width：" + i + "， height：" + i2);
                }
            }
        };
        this.amR = new com.kwad.sdk.core.video.a.c.b() { // from class: com.kwad.sdk.core.video.videoview.a.3
            @Override // com.kwad.sdk.core.video.a.c.b
            public final void tW() {
                if (a.this.Vt != 9) {
                    a.this.Vt = 9;
                    a.this.aZA.onPlayStateChanged(a.this.Vt);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onCompletion ——> STATE_COMPLETED");
                    a.this.dz.setKeepScreenOn(false);
                }
            }
        };
        this.amS = new com.kwad.sdk.core.video.a.c.InterfaceC0518c() { // from class: com.kwad.sdk.core.video.videoview.a.4
            @Override // com.kwad.sdk.core.video.a.c.InterfaceC0518c
            public final boolean n(int i, int i2) {
                if (i == -38) {
                    return true;
                }
                a.this.Vt = -1;
                a.this.aZA.q(i, i2);
                a.this.aZA.onPlayStateChanged(a.this.Vt);
                com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onError ——> STATE_ERROR ———— what：" + i + ", extra: " + i2);
                return true;
            }
        };
        this.amT = new com.kwad.sdk.core.video.a.c.d() { // from class: com.kwad.sdk.core.video.videoview.a.5
            @Override // com.kwad.sdk.core.video.a.c.d
            public final boolean o(int i, int i2) {
                if (i == 3) {
                    a.this.Vt = 4;
                    a.this.aZA.onPlayStateChanged(a.this.Vt);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> MEDIA_INFO_VIDEO_RENDERING_START：STATE_PLAYING");
                    return true;
                }
                if (i == 701) {
                    if (a.this.Vt == 5 || a.this.Vt == 7) {
                        a.this.Vt = 7;
                        com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> MEDIA_INFO_BUFFERING_START：STATE_BUFFERING_PAUSED");
                    } else {
                        a.this.Vt = 6;
                        com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> MEDIA_INFO_BUFFERING_START：STATE_BUFFERING_PLAYING");
                    }
                    a.this.aZA.onPlayStateChanged(a.this.Vt);
                    return true;
                }
                if (i == 702) {
                    if (a.this.Vt == 6) {
                        a.this.Vt = 4;
                        a.this.aZA.onPlayStateChanged(a.this.Vt);
                        com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> MEDIA_INFO_BUFFERING_END： STATE_PLAYING");
                    }
                    if (a.this.Vt != 7) {
                        return true;
                    }
                    a.this.Vt = 5;
                    a.this.aZA.onPlayStateChanged(a.this.Vt);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> MEDIA_INFO_BUFFERING_END： STATE_PAUSED");
                    return true;
                }
                if (i == 10001) {
                    if (a.this.aZz == null) {
                        return true;
                    }
                    a.this.aZz.setRotation(i2);
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "视频旋转角度：" + i2);
                    return true;
                }
                if (i == 801) {
                    com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "视频不能seekTo，为直播视频");
                    return true;
                }
                com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "onInfo ——> what：" + i);
                return true;
            }
        };
        this.amU = new com.kwad.sdk.core.video.a.c.a() { // from class: com.kwad.sdk.core.video.videoview.a.6
            @Override // com.kwad.sdk.core.video.a.c.a
            public final void bh(int i) {
                a.this.amB = i;
            }
        };
        this.mContext = context;
        init();
    }

    private void init() {
        this.aZF = OV();
        this.dz = new FrameLayout(this.mContext);
        addView(this.dz, new FrameLayout.LayoutParams(-1, -1));
    }

    public final void setExternalPlayerListener(InterfaceC0519a interfaceC0519a) {
        this.cK = interfaceC0519a;
    }

    private ImageView OV() {
        ImageView imageView = new ImageView(this.mContext);
        addView(imageView, new FrameLayout.LayoutParams(-1, -1));
        return imageView;
    }

    public final void a(com.kwad.sdk.contentalliance.a.a.b bVar, Map<String, String> map) {
        this.amE = bVar;
        this.mUrl = bVar.videoUrl;
        this.mHeaders = null;
        fl(bVar.adTemplate);
    }

    private void fl(AdTemplate adTemplate) {
        i iVar = (i) ServiceProvider.get(i.class);
        if (iVar != null) {
            iVar.load(this.aZF, e.eQ(adTemplate), adTemplate);
        }
    }

    public final void setVideoSoundEnable(boolean z) {
        this.aZD = z;
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            if (z) {
                cVar.setVolume(1.0f, 1.0f);
            } else {
                cVar.setVolume(0.0f, 0.0f);
            }
        }
    }

    public final void setPortraitFullscreen(boolean z) {
        this.aZE = z;
    }

    public final b getController() {
        return this.aZA;
    }

    public final void setController(b bVar) {
        this.dz.removeView(this.aZA);
        this.aZA = bVar;
        bVar.reset();
        this.dz.addView(this.aZA, new FrameLayout.LayoutParams(-1, -1));
    }

    public final b getVideoController() {
        return this.aZA;
    }

    private void setPlayType(int i) {
        com.kwad.sdk.contentalliance.a.a.b bVar = this.amE;
        if (bVar == null || bVar.videoPlayerStatus == null) {
            return;
        }
        this.amE.videoPlayerStatus.mVideoPlayerType = i;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final void start() {
        if (this.Vt == 0) {
            OY();
            xG();
            OZ();
            Pa();
            com.kwad.sdk.contentalliance.a.a.b bVar = this.amE;
            if (bVar != null && bVar.videoPlayerStatus != null) {
                if (this.amE.videoPlayerStatus.mVideoPlayerType == 0) {
                    setPlayType(1);
                } else {
                    setPlayType(3);
                }
            }
            com.kwad.sdk.core.video.a.a.a.fq("videoStartPlay");
            return;
        }
        com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "KSVideoPlayer只有在状态为STATE_IDLE时才能调用start方法.");
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final void restart() {
        int i = this.Vt;
        if (i == 5) {
            this.amA.start();
            com.kwad.sdk.core.video.a.a.a.fq("videoResumePlay");
            this.Vt = 4;
            this.aZA.onPlayStateChanged(4);
            setPlayType(2);
            com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "STATE_PLAYING");
            return;
        }
        if (i == 7) {
            this.amA.start();
            com.kwad.sdk.core.video.a.a.a.fq("videoResumePlay");
            this.Vt = 6;
            this.aZA.onPlayStateChanged(6);
            com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "STATE_BUFFERING_PLAYING");
            return;
        }
        if (i == 9 || i == -1) {
            this.amA.reset();
            Pb();
            setPlayType(3);
            return;
        }
        com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "KSVideoPlayer在状态为 " + this.Vt + " 时不能调用restart()方法.");
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final void pause() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar == null) {
            return;
        }
        int i = this.Vt;
        if (i == 4) {
            cVar.pause();
            com.kwad.sdk.core.video.a.a.a.fq("videoPausePlay");
            this.Vt = 5;
            this.aZA.onPlayStateChanged(5);
            com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "STATE_PAUSED");
            return;
        }
        if (i == 6) {
            cVar.pause();
            com.kwad.sdk.core.video.a.a.a.fq("videoPausePlay");
            this.Vt = 7;
            this.aZA.onPlayStateChanged(7);
            com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "STATE_BUFFERING_PAUSED");
        }
    }

    public final void seekTo(int i) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.seekTo(i);
        }
    }

    public final void setVolume(int i) {
        AudioManager audioManager = this.aZy;
        if (audioManager != null) {
            audioManager.setStreamVolume(3, i, 0);
        }
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final boolean isIdle() {
        return this.Vt == 0;
    }

    private boolean isPreparing() {
        return this.Vt == 1;
    }

    private boolean OW() {
        return this.Vt == 6;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final boolean OX() {
        return this.Vt == 7;
    }

    public final boolean isPlaying() {
        return this.Vt == 4;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final boolean isPaused() {
        return this.Vt == 5;
    }

    public final boolean isCompleted() {
        return this.Vt == 9;
    }

    public final void setLooping(boolean z) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.setLooping(z);
        }
    }

    public final int getMaxVolume() {
        AudioManager audioManager = this.aZy;
        if (audioManager != null) {
            return audioManager.getStreamMaxVolume(3);
        }
        return 0;
    }

    public final int getVolume() {
        AudioManager audioManager = this.aZy;
        if (audioManager != null) {
            return audioManager.getStreamVolume(3);
        }
        return 0;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final long getDuration() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getDuration();
        }
        return 0L;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final long getCurrentPosition() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getCurrentPosition();
        }
        return 0L;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final int getBufferPercentage() {
        return this.amB;
    }

    private void OY() {
        if (this.amA == null) {
            f fVar = (f) ServiceProvider.get(f.class);
            boolean z = fVar != null && fVar.FE();
            boolean z2 = fVar != null && fVar.FF();
            InterfaceC0519a interfaceC0519a = this.cK;
            com.kwad.sdk.core.video.a.c cVarA = interfaceC0519a != null ? interfaceC0519a.a(this.amE) : null;
            if ((!z || !com.kwad.sdk.core.video.a.e.Il() || !com.kwad.sdk.core.video.a.e.OU()) && cVarA != null) {
                this.amA = cVarA;
            } else {
                this.amA = com.kwad.sdk.core.video.a.e.a(this.mContext, false, z, z2, 0);
            }
            this.amA.setAudioStreamType(3);
            if (this.aZD) {
                return;
            }
            this.amA.setVolume(0.0f, 0.0f);
        }
    }

    private void xG() {
        if (this.aZz == null) {
            com.kwad.sdk.core.video.a aVar = new com.kwad.sdk.core.video.a(this.mContext);
            this.aZz = aVar;
            aVar.setSurfaceTextureListener(this);
        }
    }

    private void OZ() {
        this.dz.removeView(this.aZz);
        this.dz.addView(this.aZz, 0, new FrameLayout.LayoutParams(-1, -1, 17));
    }

    private void Pa() {
        if (!com.kwad.framework.c.a.oV.booleanValue() || this.amA == null || this.dz == null) {
            return;
        }
        if (this.and == null) {
            this.and = new TextView(this.mContext);
        }
        this.dz.removeView(this.and);
        this.and.setText(String.valueOf(this.amA.getMediaPlayerType()));
        this.and.setTextColor(SupportMenu.CATEGORY_MASK);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
        layoutParams.gravity = 53;
        FrameLayout frameLayout = this.dz;
        frameLayout.addView(this.and, frameLayout.getChildCount() - 1, layoutParams);
    }

    @Override // android.view.TextureView.SurfaceTextureListener
    public final void onSurfaceTextureAvailable(SurfaceTexture surfaceTexture, int i, int i2) {
        SurfaceTexture surfaceTexture2 = this.anc;
        if (surfaceTexture2 == null) {
            this.anc = surfaceTexture;
            Pb();
        } else {
            this.aZz.setSurfaceTexture(surfaceTexture2);
        }
    }

    private void Pb() {
        com.kwad.sdk.contentalliance.a.a.a aVar;
        this.dz.setKeepScreenOn(true);
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar == null) {
            com.kwad.sdk.core.d.c.w("KSVideoPlayerViewView", "mMediaPlayer is null");
            return;
        }
        cVar.b(this.amP);
        this.amA.a(this.amQ);
        this.amA.a(this.amR);
        this.amA.a(this.amS);
        this.amA.c(this.amT);
        this.amA.a(this.amU);
        try {
            com.kwad.sdk.contentalliance.a.a.b bVar = this.amE;
            if (bVar != null && (aVar = this.ft) != null) {
                bVar.aKM = aVar;
            }
            this.amA.b(this.amE);
            if (this.ane == null) {
                this.ane = new Surface(this.anc);
            }
            this.amA.setSurface(this.ane);
            if (this.amA.prepareAsync()) {
                this.Vt = 1;
                this.aZA.onPlayStateChanged(1);
                com.kwad.sdk.core.d.c.i("KSVideoPlayerViewView", "STATE_PREPARING");
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.core.d.c.e("KSVideoPlayerViewView", "打开播放器发生错误", e);
        }
    }

    private void Pc() {
        AudioManager audioManager = this.aZy;
        if (audioManager != null) {
            audioManager.abandonAudioFocus(null);
            this.aZy = null;
        }
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.release();
            this.amA = null;
            com.kwad.sdk.core.video.a.a.a.fq("videoFinishPlay");
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.sdk.core.video.videoview.a.7
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.dz.removeView(a.this.aZz);
            }
        });
        Surface surface = this.ane;
        if (surface != null) {
            surface.release();
            this.ane = null;
        }
        SurfaceTexture surfaceTexture = this.anc;
        if (surfaceTexture != null) {
            surfaceTexture.release();
            this.anc = null;
        }
        this.Vt = 0;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final void release() {
        if (isPreparing()) {
            this.aZG = true;
            postDelayed(new bi() { // from class: com.kwad.sdk.core.video.videoview.a.8
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (a.this.aZG) {
                        a.this.Pd();
                    }
                }
            }, ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT);
            return;
        }
        if (this.aZB) {
            if (isPlaying() || OW() || OX() || isPaused()) {
                ai.e(this.mContext, this.mUrl, getCurrentPosition());
            } else if (isCompleted()) {
                ai.e(this.mContext, this.mUrl, 0L);
            }
        }
        Pc();
        b bVar = this.aZA;
        if (bVar != null) {
            bVar.reset();
        }
        this.aZG = false;
    }

    public final void Pd() {
        if (this.aZB) {
            if (isPlaying() || OW() || OX() || isPaused()) {
                ai.e(this.mContext, this.mUrl, getCurrentPosition());
            } else if (isCompleted()) {
                ai.e(this.mContext, this.mUrl, 0L);
            }
        }
        Pc();
        b bVar = this.aZA;
        if (bVar != null) {
            bVar.reset();
        }
        this.aZG = false;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final void setKsPlayLogParam(com.kwad.sdk.contentalliance.a.a.a aVar) {
        this.ft = aVar;
    }

    @Override // com.kwad.sdk.core.video.videoview.c
    public final int getMediaPlayerType() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getMediaPlayerType();
        }
        return 0;
    }
}
