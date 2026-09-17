package com.kwad.components.core.video.a;

import android.os.SystemClock;
import com.kwad.components.core.video.j;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.core.video.a.a {
    private String Cu;
    private long anY;
    private long anZ;
    private long aoa;
    private String aob;
    private boolean aoc;
    private boolean aod;
    private boolean aoe;
    private long aof;
    private long aog;
    private long aoh;
    private long aoi;
    private int aoj;
    private boolean aok;
    private int mMediaPlayerType;
    private j yf;

    public static class a extends com.kwad.sdk.commercial.c.a {
        public String aop;
        public int aoq;
        public long authorId;
        public int code;
        public long creativeId;
        public long llsid;
        public String msg;
        public String videoUrl;
    }

    private d(AdTemplate adTemplate, int i, boolean z) {
        this.aoc = false;
        this.aod = false;
        this.aoe = false;
        this.mMediaPlayerType = 0;
        this.aok = false;
        try {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            this.Cu = com.kwad.sdk.core.response.helper.a.M(adInfoEM);
            this.anY = com.kwad.sdk.core.response.helper.e.eJ(adTemplate);
            this.anZ = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
            this.aoa = com.kwad.sdk.core.response.helper.a.cw(adInfoEM);
            this.aob = com.kwad.sdk.core.response.helper.a.cs(adInfoEM);
            this.aoj = com.kwad.sdk.core.response.helper.e.eG(adTemplate);
            this.mMediaPlayerType = i;
            this.aok = z;
            this.yf = new j();
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    private d(String str, int i) {
        this.aoc = false;
        this.aod = false;
        this.aoe = false;
        this.aok = false;
        this.Cu = str;
        this.mMediaPlayerType = i;
        this.yf = new j();
    }

    @Override // com.kwad.components.core.video.a.c
    public final void onStart() {
        if (this.aoc) {
            return;
        }
        this.aof = SystemClock.elapsedRealtime();
        this.aoc = true;
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
    public final void onMediaPlayStart() {
        super.onMediaPlayStart();
        if (this.aod) {
            return;
        }
        this.aog = SystemClock.elapsedRealtime();
        this.aod = true;
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
    public final void onMediaPlaying() {
        super.onMediaPlaying();
        qY();
        this.yf.yd();
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
    public final void onMediaPlayPaused() {
        super.onMediaPlayPaused();
        this.yf.yd();
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
    public final void onMediaPlayError(int i, int i2) {
        super.onMediaPlayError(i, i2);
        this.yf.yd();
        b(false, i, i2);
    }

    @Override // com.kwad.components.core.video.a.c
    public final void onRelease() {
        b(true, 0, 0);
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
    public final void onVideoPlayBufferingPlaying() {
        super.onVideoPlayBufferingPlaying();
        this.yf.yc();
    }

    @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
    public final void onVideoPlayBufferingPaused() {
        super.onVideoPlayBufferingPaused();
        this.yf.yc();
    }

    @Override // com.kwad.components.core.video.a.a
    public final void qY() {
        if (this.aoe) {
            return;
        }
        this.aoh = SystemClock.elapsedRealtime();
        this.aoe = true;
    }

    @Override // com.kwad.components.core.video.a.c
    public final void onReset() {
        b(false, 0, 0);
    }

    private void reset() {
        this.yf.reset();
        this.aof = 0L;
        this.aog = 0L;
        this.aoi = 0L;
        this.aoh = 0L;
        this.aoc = false;
        this.aod = false;
        this.aoe = false;
    }

    private void a(final boolean z, final int i, final int i2) {
        final b bVarClone = yj().clone();
        i.execute(new bi() { // from class: com.kwad.components.core.video.a.d.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (!z) {
                    com.kwad.sdk.commercial.c.u(d.this.r(i, i2));
                } else {
                    com.kwad.sdk.commercial.c.t(bVarClone);
                }
            }
        });
    }

    private void b(boolean z, int i, int i2) {
        if (this.aoe) {
            this.yf.yd();
            this.aoi = SystemClock.elapsedRealtime();
            a(z, i, i2);
            reset();
        }
    }

    private b yj() {
        b bVar = new b();
        bVar.aor = this.aog - this.aof;
        bVar.aos = this.aoh - this.aof;
        bVar.aot = this.yf.yf().yi();
        bVar.videoDuration = this.aoi - this.aof;
        bVar.anW = this.yf.yf().yh();
        bVar.videoUrl = this.Cu;
        bVar.llsid = this.anY;
        bVar.creativeId = this.anZ;
        bVar.authorId = this.aoa;
        bVar.aop = this.aob;
        bVar.adStyle = this.aoj;
        bVar.aoq = this.mMediaPlayerType;
        return bVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public a r(int i, int i2) {
        a aVar = new a();
        aVar.code = i;
        aVar.msg = String.valueOf(i2);
        aVar.videoUrl = this.Cu;
        aVar.llsid = this.anY;
        aVar.creativeId = this.anZ;
        aVar.authorId = this.aoa;
        aVar.aop = this.aob;
        aVar.aoq = this.mMediaPlayerType;
        return aVar;
    }

    public static class b extends com.kwad.sdk.commercial.c.a implements Cloneable {
        public int adStyle;
        public int anW;
        public String aop;
        public int aoq;
        public long aor;
        public long aos;
        public long aot;
        public long authorId;
        public long creativeId;
        public long llsid;
        public long videoDuration;
        public String videoUrl;

        /* JADX INFO: renamed from: yk, reason: merged with bridge method [inline-methods] */
        public final b clone() {
            try {
                return (b) super.clone();
            } catch (CloneNotSupportedException unused) {
                return new b();
            }
        }
    }

    public static com.kwad.components.core.video.a.a a(AdTemplate adTemplate, int i, boolean z) {
        return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPL) ? new d(adTemplate, i, false) : new com.kwad.components.core.video.a.b();
    }

    public static com.kwad.components.core.video.a.a a(AdTemplate adTemplate, AdTemplate adTemplate2, String str, int i, boolean z) {
        if (!com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPL)) {
            return new com.kwad.components.core.video.a.b();
        }
        if (adTemplate != null) {
            return new d(adTemplate, i, z);
        }
        if (adTemplate2 == null) {
            return new d(str, i);
        }
        return new d(adTemplate2, i, z);
    }
}
