package com.kwad.components.core.video;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.view.Surface;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static boolean amy = false;
    private static final AtomicInteger amz = new AtomicInteger(0);
    private final String TAG;
    private final int UG;
    private volatile int Vt;
    private com.kwad.sdk.core.video.a.c amA;
    private int amB;
    private long amC;
    private Runnable amD;
    private com.kwad.sdk.contentalliance.a.a.b amE;
    private int amF;
    private List<com.kwad.sdk.core.video.a.c.d> amG;
    private final AtomicBoolean amH;
    private boolean amI;
    private boolean amJ;
    private boolean amK;
    private volatile List<l> amL;
    private volatile List<com.kwad.components.core.video.a.c> amM;
    private volatile List<com.kwad.sdk.core.video.a.c.e> amN;
    private final com.kwad.sdk.core.video.a.c.f amO;
    private com.kwad.sdk.core.video.a.c.e amP;
    private com.kwad.sdk.core.video.a.c.i amQ;
    private com.kwad.sdk.core.video.a.c.b amR;
    private com.kwad.sdk.core.video.a.c.InterfaceC0518c amS;
    private com.kwad.sdk.core.video.a.c.d amT;
    private com.kwad.sdk.core.video.a.c.a amU;
    private int amg;
    private int amh;
    private Handler jc;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private DetailVideoView mDetailVideoView;
    private float mSpeed;
    private long mStartTime;

    public interface a {
        void onReleaseSuccess();
    }

    public static String getStateString(int i) {
        switch (i) {
            case -1:
                return "STATE_ERROR";
            case 0:
                return "STATE_IDLE";
            case 1:
                return "STATE_PREPARING";
            case 2:
                return "STATE_PREPARED";
            case 3:
                return "STATE_STARTED";
            case 4:
                return "STATE_PLAYING";
            case 5:
                return "STATE_PAUSED";
            case 6:
                return "STATE_BUFFERING_PLAYING";
            case 7:
                return "STATE_BUFFERING_PAUSED";
            case 8:
                return "PLAYER_STATE_STOPPED";
            case 9:
                return "STATE_COMPLETED";
            default:
                return "STATE_UNKNOWN";
        }
    }

    public b(DetailVideoView detailVideoView) {
        this(detailVideoView, 0);
    }

    private b(DetailVideoView detailVideoView, int i) {
        this.Vt = 0;
        this.jc = new Handler(Looper.getMainLooper());
        this.mStartTime = 0L;
        this.amF = 0;
        this.amG = new CopyOnWriteArrayList();
        this.amH = new AtomicBoolean(false);
        this.amI = false;
        this.amJ = false;
        this.amK = false;
        this.mSpeed = 1.0f;
        this.amL = new CopyOnWriteArrayList();
        this.amM = new CopyOnWriteArrayList();
        this.amN = new CopyOnWriteArrayList();
        this.amO = new com.kwad.sdk.core.video.a.c.f() { // from class: com.kwad.components.core.video.b.1
            @Override // com.kwad.sdk.core.video.a.c.f
            public final void xF() {
                b.this.Vt = 1;
                b bVar = b.this;
                bVar.onPlayStateChanged(bVar.Vt);
            }
        };
        this.amP = new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.components.core.video.b.4
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar) {
                try {
                    com.kwad.sdk.core.d.c.i(b.this.TAG, "onPrepared:" + b.getStateString(b.this.Vt) + "->STATE_PREPARED");
                    b.this.Vt = 2;
                    b bVar = b.this;
                    bVar.onPlayStateChanged(bVar.Vt);
                    Iterator it = b.this.amN.iterator();
                    while (it.hasNext()) {
                        ((com.kwad.sdk.core.video.a.c.e) it.next()).a(b.this.amA);
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
        this.amQ = new com.kwad.sdk.core.video.a.c.i() { // from class: com.kwad.components.core.video.b.5
            @Override // com.kwad.sdk.core.video.a.c.i
            public final void m(int i2, int i3) {
                if (b.this.mDetailVideoView != null) {
                    b.this.mDetailVideoView.adaptVideoSize(i2, i3);
                }
                com.kwad.sdk.core.d.c.i(b.this.TAG, "onVideoSizeChanged ——> width：" + i2 + "， height：" + i3);
            }
        };
        this.amR = new com.kwad.sdk.core.video.a.c.b() { // from class: com.kwad.components.core.video.b.6
            @Override // com.kwad.sdk.core.video.a.c.b
            public final void tW() {
                b.this.Vt = 9;
                b bVar = b.this;
                bVar.onPlayStateChanged(bVar.Vt);
                com.kwad.sdk.core.video.a.a.a.fq("videoFinishPlay");
            }
        };
        this.amS = new com.kwad.sdk.core.video.a.c.InterfaceC0518c() { // from class: com.kwad.components.core.video.b.7
            @Override // com.kwad.sdk.core.video.a.c.InterfaceC0518c
            public final boolean n(int i2, int i3) {
                if (i2 == -38) {
                    return true;
                }
                b.this.Vt = -1;
                b.this.amg = i2;
                b.this.amh = i3;
                b bVar = b.this;
                bVar.onPlayStateChanged(bVar.Vt);
                com.kwad.sdk.core.d.c.i(b.this.TAG, "onError ——> STATE_ERROR ———— what：" + i2 + ", extra: " + i3);
                return true;
            }
        };
        this.amT = new com.kwad.sdk.core.video.a.c.d() { // from class: com.kwad.components.core.video.b.8
            @Override // com.kwad.sdk.core.video.a.c.d
            public final boolean o(int i2, int i3) {
                if (i2 == 3) {
                    b.this.Vt = 4;
                    b bVar = b.this;
                    bVar.onPlayStateChanged(bVar.Vt);
                    com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo:" + b.getStateString(b.this.Vt) + "->STATE_PLAYING, time: " + (System.currentTimeMillis() - b.this.mStartTime));
                } else if (i2 == 701) {
                    if (b.this.Vt == 5 || b.this.Vt == 7) {
                        b.this.Vt = 7;
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo ——> MEDIA_INFO_BUFFERING_START：STATE_BUFFERING_PAUSED");
                    } else {
                        b.this.Vt = 6;
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo ——> MEDIA_INFO_BUFFERING_START：STATE_BUFFERING_PLAYING");
                    }
                    b bVar2 = b.this;
                    bVar2.onPlayStateChanged(bVar2.Vt);
                } else if (i2 == 702) {
                    if (b.this.Vt == 6) {
                        b.this.Vt = 4;
                        b bVar3 = b.this;
                        bVar3.onPlayStateChanged(bVar3.Vt);
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo ——> MEDIA_INFO_BUFFERING_END： STATE_PLAYING");
                    }
                    if (b.this.Vt == 7) {
                        b.this.Vt = 5;
                        b bVar4 = b.this;
                        bVar4.onPlayStateChanged(bVar4.Vt);
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo ——> MEDIA_INFO_BUFFERING_END： STATE_PAUSED");
                    }
                } else if (i2 != 10001) {
                    if (i2 == 801) {
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "视频不能seekTo，为直播视频");
                    } else {
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "onInfo ——> what：" + i2);
                    }
                }
                b bVar5 = b.this;
                bVar5.a(bVar5.amA, i2, i3);
                return true;
            }
        };
        this.amU = new com.kwad.sdk.core.video.a.c.a() { // from class: com.kwad.components.core.video.b.9
            @Override // com.kwad.sdk.core.video.a.c.a
            public final void bh(int i2) {
                b.this.amB = i2;
            }
        };
        this.mDetailVideoView = detailVideoView;
        if (detailVideoView != null) {
            this.mContext = detailVideoView.getContext().getApplicationContext();
        }
        this.UG = 0;
        this.TAG = "DetailMediaPlayerImpl[0]";
        com.kwad.sdk.core.d.c.i("DetailMediaPlayerImpl[0]", "create DetailMediaPlayerImpl");
    }

    public b(DetailVideoView detailVideoView, AdTemplate adTemplate) {
        this(detailVideoView);
        this.mAdTemplate = adTemplate;
    }

    public final void setRadius(float f, float f2, float f3, float f4) {
        this.mDetailVideoView.setRadius(f, f2, f3, f4);
    }

    public final com.kwad.sdk.core.video.a.c xy() {
        return this.amA;
    }

    public final void setSurface(Surface surface) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.setSurface(surface);
        }
    }

    public final void a(com.kwad.sdk.contentalliance.a.a.b bVar, DetailVideoView detailVideoView) {
        a(bVar, true, true, detailVideoView);
    }

    public final void a(com.kwad.sdk.contentalliance.a.a.b bVar, boolean z, boolean z2, DetailVideoView detailVideoView) {
        Throwable th;
        g gVar;
        com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer enablePreLoad:" + z);
        if (bVar == null || detailVideoView == null) {
            return;
        }
        com.kwad.sdk.core.config.e.FE();
        com.kwad.sdk.core.video.a.c cVarA = null;
        if (xE()) {
            try {
                gVar = new g(bVar, this.mAdTemplate);
                if (g.isWaynePlayerReady()) {
                    try {
                        com.kwad.sdk.core.d.c.i(this.TAG, "constructPlayer KwaiWaynePlayer");
                    } catch (Throwable th2) {
                        th = th2;
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                    cVarA = gVar;
                }
            } catch (Throwable th3) {
                th = th3;
                gVar = null;
            }
        }
        if (cVarA == null) {
            cVarA = com.kwad.sdk.core.video.a.e.a(this.mContext, z, com.kwad.sdk.core.config.e.FE(), com.kwad.sdk.core.config.e.FF(), this.UG);
        }
        if (cVarA != null) {
            try {
                DetailVideoView detailVideoView2 = this.mDetailVideoView;
                if (detailVideoView2 != null) {
                    detailVideoView2.bQ(cVarA.getMediaPlayerType());
                }
                com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer " + cVarA.getClass().getName());
            } catch (Throwable th4) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th4);
            }
        }
        cVarA.setLooping(false);
        a(bVar, z2, detailVideoView, cVarA);
    }

    private void a(com.kwad.sdk.contentalliance.a.a.b bVar, boolean z, DetailVideoView detailVideoView, com.kwad.sdk.core.video.a.c cVar) {
        com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer " + this.amA);
        if (bVar == null || detailVideoView == null || cVar == null) {
            return;
        }
        if (this.mContext == null) {
            this.mContext = detailVideoView.getContext().getApplicationContext();
        }
        this.amI = z;
        this.amE = bVar;
        com.kwad.components.core.video.a.a aVarA = com.kwad.components.core.video.a.d.a(bVar.adTemplate, this.mAdTemplate, bVar.videoUrl, cVar.getMediaPlayerType(), this.amK);
        c(aVarA);
        a(aVarA);
        DetailVideoView detailVideoView2 = this.mDetailVideoView;
        if (detailVideoView2 != detailVideoView) {
            com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer videoView changed");
            if (detailVideoView2 != null) {
                detailVideoView2.setMediaPlayer(null);
                detailVideoView.setKeepScreenOn(detailVideoView2.getKeepScreenOn());
                detailVideoView2.setKeepScreenOn(false);
            }
            this.mDetailVideoView = detailVideoView;
        }
        detailVideoView.setMediaPlayer(this);
        if (this.amA != cVar) {
            com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer mediaPlayer changed");
            com.kwad.sdk.core.video.a.c cVar2 = this.amA;
            if (cVar2 != null) {
                cVar.setLooping(cVar2.isLooping());
                xA();
                this.amA.release();
            }
            this.amA = cVar;
            reset();
            xz();
            cVar.setAudioStreamType(3);
        } else {
            com.kwad.sdk.core.d.c.i(this.TAG, "initMediaPlayer mediaPlayer not changed");
            reset();
            xA();
            xz();
        }
        this.amA.setSurface(detailVideoView.ane);
    }

    public final int getMediaPlayerType() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getMediaPlayerType();
        }
        return 0;
    }

    private void xz() {
        this.amA.a(this.amO);
        this.amA.b(this.amP);
        this.amA.a(this.amQ);
        this.amA.a(this.amR);
        this.amA.a(this.amS);
        this.amA.c(this.amT);
        this.amA.a(this.amU);
    }

    private void xA() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar == null) {
            return;
        }
        cVar.a((com.kwad.sdk.core.video.a.c.InterfaceC0518c) null);
        this.amA.a((com.kwad.sdk.core.video.a.c.b) null);
        this.amA.b((com.kwad.sdk.core.video.a.c.e) null);
        this.amA.a((com.kwad.sdk.core.video.a.c.i) null);
        this.amA.c(null);
        this.amA.a((com.kwad.sdk.core.video.a.c.g) null);
        this.amA.a((com.kwad.sdk.core.video.a.c.a) null);
    }

    public final void a(com.kwad.sdk.core.video.a.c.e eVar) {
        this.amN.add(eVar);
    }

    public final void a(com.kwad.sdk.core.video.a.c.d dVar) {
        if (dVar == null) {
            return;
        }
        this.amG.add(dVar);
    }

    public final void b(com.kwad.sdk.core.video.a.c.d dVar) {
        if (dVar == null) {
            return;
        }
        this.amG.remove(dVar);
    }

    public final void a(com.kwad.sdk.core.video.a.c cVar, int i, int i2) {
        Iterator<com.kwad.sdk.core.video.a.c.d> it = this.amG.iterator();
        while (it.hasNext()) {
            com.kwad.sdk.core.video.a.c.d next = it.next();
            if (next == null) {
                it.remove();
            } else {
                next.o(i, i2);
            }
        }
    }

    @Deprecated
    public final boolean isPreparing() {
        return this.Vt == 1;
    }

    @Deprecated
    public final boolean isPrepared() {
        return this.Vt == 2 || this.Vt == 3 || this.Vt == 5 || this.Vt == 8 || this.Vt == 9;
    }

    public final void b(com.kwad.sdk.contentalliance.a.a.b bVar) {
        try {
            if (!TextUtils.isEmpty(bVar.videoUrl)) {
                com.kwad.sdk.core.d.c.d(this.TAG, "videoUrl=" + bVar.videoUrl);
                this.amA.b(bVar);
            } else {
                com.kwad.sdk.core.d.c.e(this.TAG, "videoUrl is null");
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    public final void prepareAsync() {
        bf(false);
    }

    private void bf(final boolean z) {
        if (this.amA == null) {
            return;
        }
        com.kwad.sdk.core.d.c.i(this.TAG, "start prepareAsync");
        if (this.amI) {
            if (this.amH.compareAndSet(false, true)) {
                com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.components.core.video.b.10
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        com.kwad.sdk.core.d.c.i(b.this.TAG, "prepareAsync now:" + b.getStateString(b.this.Vt));
                        if (b.this.amA == null) {
                            return;
                        }
                        try {
                            synchronized (b.this.amA) {
                                try {
                                    b.this.bg(z);
                                } catch (Throwable th) {
                                    throw th;
                                }
                            }
                        } catch (Throwable th2) {
                            try {
                                com.kwad.sdk.core.d.c.e(b.this.TAG, "prepareAsync Exception:" + b.getStateString(b.this.Vt), th2);
                            } catch (Throwable th3) {
                                b.this.amH.set(false);
                                throw th3;
                            }
                        }
                        b.this.amH.set(false);
                        try {
                            synchronized (b.this.amH) {
                                try {
                                    b.this.amH.notifyAll();
                                } catch (Throwable th4) {
                                    throw th4;
                                }
                            }
                        } catch (Exception e) {
                            com.kwad.sdk.core.d.c.printStackTrace(e);
                        }
                    }
                });
                return;
            }
            return;
        }
        try {
            bg(z);
        } catch (Throwable th) {
            if (getMediaPlayerType() != 2) {
                int i = this.amF;
                this.amF = i + 1;
                if (i <= 4) {
                    xB();
                }
            }
            com.kwad.sdk.core.d.c.i(this.TAG, "prepareAsync Exception:" + getStateString(this.Vt));
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bg(boolean z) {
        boolean zPrepareAsync;
        b(this.amE);
        if (z) {
            zPrepareAsync = this.amA.xV();
        } else {
            zPrepareAsync = this.amA.prepareAsync();
        }
        com.kwad.sdk.core.d.c.i(this.TAG, "prepareAsync forcePrepare: " + z + ", result: " + zPrepareAsync);
    }

    public final void start() {
        try {
            if (this.amA == null) {
                return;
            }
            com.kwad.sdk.core.d.c.i(this.TAG, "start state: " + getStateString(this.Vt));
            bP(0);
            if (this.Vt == 0) {
                com.kwad.sdk.core.d.c.i(this.TAG, "start still not prepared well forcePrepare");
                bf(true);
                return;
            }
            if (this.Vt != 2 && this.Vt != 9) {
                if (this.Vt == 3) {
                    this.amA.start();
                    return;
                } else {
                    if (this.Vt == 5) {
                        resume();
                        return;
                    }
                    return;
                }
            }
            this.mStartTime = System.currentTimeMillis();
            long j = this.amC;
            if (j != 0) {
                this.amA.seekTo((int) j);
            }
            this.amA.start();
            com.kwad.sdk.core.video.a.a.a.fq("videoStartPlay");
            com.kwad.sdk.core.d.c.i(this.TAG, "start:" + getStateString(this.Vt) + "->STATE_STARTED");
            com.kwad.sdk.contentalliance.a.a.b bVar = this.amE;
            if (bVar != null && bVar.videoPlayerStatus != null) {
                if (this.Vt == 2) {
                    if (this.amE.videoPlayerStatus.mVideoPlayerType == 0) {
                        setPlayType(1);
                    } else {
                        setPlayType(3);
                    }
                } else if (this.Vt == 9) {
                    setPlayType(3);
                }
            }
            this.Vt = 3;
            onPlayStateChanged(this.Vt);
            xC();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void start(long j) {
        this.amC = j;
        start();
    }

    private void setPlayType(int i) {
        com.kwad.sdk.contentalliance.a.a.b bVar = this.amE;
        if (bVar == null || bVar.videoPlayerStatus == null) {
            return;
        }
        this.amE.videoPlayerStatus.mVideoPlayerType = i;
    }

    public final void restart() {
        if (this.amA != null && this.Vt == 9) {
            start();
        }
        setPlayType(3);
    }

    public final void complete() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.pause();
            this.amA.seekTo(0L);
        }
        if (this.Vt != 9) {
            this.Vt = 9;
            onPlayStateChanged(this.Vt);
            com.kwad.sdk.core.video.a.a.a.fq("videoFinishPlay");
        }
    }

    public final void xB() {
        if (this.amA == null) {
            com.kwad.sdk.core.d.c.w("resetAndPlay", "mMediaPlayer is null");
            return;
        }
        if (this.Vt == 2 || this.Vt == 3 || this.Vt == 4 || this.Vt == 5) {
            com.kwad.sdk.core.d.c.w("resetAndPlay", "can not resetAndPlay in state:");
            return;
        }
        reset();
        xA();
        xz();
        prepareAsync();
    }

    public final void resume() {
        try {
            if (this.amA == null) {
                com.kwad.sdk.core.d.c.e(this.TAG, "resume but mMediaPlayer is null");
                return;
            }
            com.kwad.sdk.core.d.c.i(this.TAG, "resume state: " + getStateString(this.Vt));
            if (this.Vt != 2 && this.Vt != 3 && this.Vt != 0) {
                if (this.Vt == 5) {
                    this.amA.start();
                    com.kwad.sdk.core.d.c.i(this.TAG, "resume:" + getStateString(this.Vt) + "->STATE_PLAYING");
                    this.Vt = 4;
                    onPlayStateChanged(this.Vt);
                    setPlayType(2);
                    com.kwad.sdk.core.video.a.a.a.fq("videoResumePlay");
                    return;
                }
                if (this.Vt == 7) {
                    this.amA.start();
                    com.kwad.sdk.core.d.c.i(this.TAG, "resume:" + getStateString(this.Vt) + "->STATE_BUFFERING_PLAYING");
                    this.Vt = 6;
                    onPlayStateChanged(this.Vt);
                    return;
                }
                if (this.Vt == 9) {
                    start();
                    return;
                } else {
                    if (this.Vt != 1) {
                        com.kwad.sdk.core.d.c.w(this.TAG, "resume: " + getStateString(this.Vt) + " 此时不能调用resume()方法.");
                        return;
                    }
                    return;
                }
            }
            com.kwad.sdk.core.d.c.i(this.TAG, "resume:" + getStateString(this.Vt) + "->start()");
            start();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void stopAndPrepareAsync() {
        com.kwad.sdk.core.d.c.i(this.TAG, "stopAndPrepareAsync state: " + getStateString(this.Vt));
        if (this.Vt == 1 || this.Vt == 2) {
            return;
        }
        if (this.Vt == 3 || this.Vt == 4 || this.Vt == 5 || this.Vt == 6 || this.Vt == 7 || this.Vt == 8 || this.Vt == 9) {
            try {
                this.amA.stop();
                this.Vt = 8;
                onPlayStateChanged(this.Vt);
                prepareAsync();
                return;
            } catch (Exception unused) {
            }
        }
        release();
    }

    private void reset() {
        com.kwad.sdk.core.d.c.i(this.TAG, "reset:" + getStateString(this.Vt) + "->STATE_IDLE");
        bP(1);
        this.amA.reset();
        this.Vt = 0;
    }

    public final boolean isPlaying() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.isPlaying();
        }
        return false;
    }

    public final boolean pause() {
        boolean z;
        com.kwad.sdk.core.d.c.i(this.TAG, "pause mCurrentState: " + getStateString(this.Vt));
        if (this.Vt == 4) {
            this.amA.pause();
            com.kwad.sdk.core.d.c.i(this.TAG, "pause STATE_PLAYING->STATE_PAUSED");
            this.Vt = 5;
            onPlayStateChanged(this.Vt);
            com.kwad.sdk.core.video.a.a.a.fq("videoPausePlay");
            z = true;
        } else {
            z = false;
        }
        if (this.Vt == 6) {
            this.amA.pause();
            com.kwad.sdk.core.d.c.i(this.TAG, "pause STATE_BUFFERING_PLAYING->STATE_PAUSED");
            this.Vt = 7;
            onPlayStateChanged(this.Vt);
            z = true;
        }
        if (this.Vt == 3) {
            this.amA.pause();
            com.kwad.sdk.core.d.c.i(this.TAG, "pause STATE_STARTED->STATE_PAUSED");
            this.Vt = 5;
            onPlayStateChanged(this.Vt);
            com.kwad.sdk.core.video.a.a.a.fq("videoPausePlay");
            z = true;
        }
        if (this.Vt != 9 || !this.amA.isLooping()) {
            return z;
        }
        this.amA.pause();
        com.kwad.sdk.core.d.c.i(this.TAG, "pause " + getStateString(this.Vt) + "->STATE_PAUSED");
        this.Vt = 5;
        onPlayStateChanged(this.Vt);
        return true;
    }

    public final void a(final a aVar, boolean z) {
        if (this.amA == null) {
            return;
        }
        com.kwad.sdk.core.d.c.i(this.TAG, "release:" + getStateString(this.Vt) + "->STATE_IDLE");
        setKeepScreenOn(false);
        this.jc.removeCallbacksAndMessages(null);
        xD();
        xA();
        this.mDetailVideoView = null;
        final com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            if (z) {
                com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.components.core.video.b.11
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        b.this.a(cVar, aVar);
                    }
                });
            } else {
                a(cVar, aVar);
            }
            this.amA = null;
        }
        this.Vt = 0;
        this.amF = 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(com.kwad.sdk.core.video.a.c cVar, a aVar) {
        if (cVar == null) {
            return;
        }
        com.kwad.sdk.core.d.c.i(this.TAG, "releaseMediaPlayer:" + getStateString(this.Vt) + "->STATE_IDLE");
        try {
            bP(2);
            cVar.release();
            if (aVar != null) {
                aVar.onReleaseSuccess();
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }

    public final void a(a aVar) {
        a(aVar, true);
    }

    public final void release() {
        a((a) null);
    }

    public final void releaseAsync() {
        a((a) null, true);
    }

    public final void seekTo(long j) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            cVar.seekTo(j);
        }
    }

    public final void setVolume(float f, float f2) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar == null) {
            return;
        }
        try {
            cVar.setVolume(f, f2);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    public final void setAudioEnabled(boolean z) {
        if (z) {
            setVolume(1.0f, 1.0f);
        } else {
            setVolume(0.0f, 0.0f);
        }
    }

    public final void setSpeed(float f) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar == null) {
            return;
        }
        if (f > 0.0f) {
            this.mSpeed = f;
        }
        cVar.setSpeed(f);
    }

    public final int getVideoWidth() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getVideoWidth();
        }
        return 0;
    }

    public final int getVideoHeight() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getVideoHeight();
        }
        return 0;
    }

    public final long getDuration() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getDuration();
        }
        return 0L;
    }

    public final long getPlayDuration() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getCurrentPosition();
        }
        return 0L;
    }

    public final long getCurrentPosition() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar.getCurrentPosition();
        }
        return 0L;
    }

    public final int getBufferPercentage() {
        return this.amB;
    }

    public final void c(l lVar) {
        this.amL.add(lVar);
    }

    private void a(com.kwad.components.core.video.a.c cVar) {
        this.amM.add(cVar);
    }

    public final void d(l lVar) {
        this.amL.remove(lVar);
    }

    public final void clear() {
        this.amL.clear();
        this.amM.clear();
    }

    public final void onPlayStateChanged(final int i) {
        if (this.amL == null) {
            return;
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.video.b.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                for (l lVar : b.this.amL) {
                    switch (i) {
                        case -1:
                            b.this.setKeepScreenOn(false);
                            b.this.xD();
                            lVar.onMediaPlayError(b.this.amg, b.this.amh);
                            break;
                        case 1:
                            lVar.onMediaPreparing();
                            break;
                        case 2:
                            lVar.onMediaPrepared();
                            break;
                        case 3:
                            b.this.setKeepScreenOn(true);
                            lVar.onMediaPlayStart();
                            break;
                        case 4:
                            b.this.setKeepScreenOn(true);
                            lVar.onMediaPlaying();
                            break;
                        case 5:
                            b.this.setKeepScreenOn(false);
                            lVar.onMediaPlayPaused();
                            break;
                        case 6:
                            lVar.onVideoPlayBufferingPlaying();
                            break;
                        case 7:
                            lVar.onVideoPlayBufferingPaused();
                            break;
                        case 9:
                            if (b.this.amA != null && !b.this.amA.isLooping()) {
                                b.this.setKeepScreenOn(false);
                                b.this.xD();
                            }
                            lVar.onMediaPlayCompleted();
                            break;
                    }
                }
            }
        });
    }

    private void bP(int i) {
        for (com.kwad.components.core.video.a.c cVar : this.amM) {
            if (i == 0) {
                cVar.onStart();
            } else if (i == 1) {
                cVar.onReset();
            } else if (i == 2) {
                try {
                    cVar.onRelease();
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.printStackTrace(e);
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void setKeepScreenOn(boolean z) {
        DetailVideoView detailVideoView = this.mDetailVideoView;
        if (detailVideoView != null) {
            detailVideoView.setKeepScreenOn(z);
        }
    }

    private void xC() {
        xD();
        if (this.amD == null) {
            this.amD = new bi() { // from class: com.kwad.components.core.video.b.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    b.this.xw();
                    if (b.this.amD != null) {
                        b.this.jc.postDelayed(b.this.amD, (long) (500.0f / b.this.mSpeed));
                    }
                }
            };
        }
        this.jc.post(this.amD);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void xD() {
        Runnable runnable = this.amD;
        if (runnable != null) {
            this.jc.removeCallbacks(runnable);
            this.amD = null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void xw() {
        long currentPosition = getCurrentPosition();
        long duration = getDuration();
        if (this.amL != null) {
            Iterator<l> it = this.amL.iterator();
            while (it.hasNext()) {
                it.next().onMediaPlayProgress(duration, currentPosition);
            }
        }
    }

    public final void a(com.kwad.sdk.contentalliance.a.a.a aVar) {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar instanceof com.kwad.sdk.core.video.a.d) {
            ((com.kwad.sdk.core.video.a.d) cVar).a(aVar);
        }
    }

    public final String getCurrentPlayingUrl() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        return cVar == null ? "" : cVar.getCurrentPlayingUrl();
    }

    public final void setIsAlphaVideoPlayer(boolean z) {
        DetailVideoView detailVideoView = this.mDetailVideoView;
        if (detailVideoView != null) {
            detailVideoView.setIsAlphaVideoView(z);
        }
        this.amJ = z;
    }

    public final boolean getAlphaVideoValid() {
        com.kwad.sdk.core.video.a.c cVar = this.amA;
        if (cVar != null) {
            return cVar instanceof g;
        }
        return false;
    }

    private boolean xE() {
        if (this.amJ && ((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue()) {
            return true;
        }
        return ((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() && ((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue();
    }

    public final void setTKPlayer() {
        this.amK = true;
    }
}
