package com.kwad.components.core.innerEc.live.c;

import android.app.Activity;
import android.text.TextUtils;
import com.kwad.components.core.innerEc.f;
import com.kwad.components.core.innerEc.live.end.LiveAudienceEndReason;
import com.kwad.components.core.innerEc.live.video.a.b;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PBHelper;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.ServerException;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private final b UR;
    private final com.kwad.components.core.innerEc.live.b.a.b Uj;
    private boolean Xj;
    private boolean Xk;
    private Runnable Xl;
    private boolean Xm;
    private final com.kwad.components.core.innerEc.live.video.a.a Xn = new com.kwad.components.core.innerEc.live.video.a.a() { // from class: com.kwad.components.core.innerEc.live.c.a.1
        @Override // com.kwad.components.offline.api.core.adInnerEc.fullAdLive.listener.IHostLivePlayerCompleteListener
        public final void onLiveComplete() {
            a.a(a.this, true);
            a.this.sR();
        }
    };
    private final Activity mActivity;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.Xm = true;
        return true;
    }

    public a(Activity activity, com.kwad.components.core.innerEc.live.b.a.b bVar) {
        this.mActivity = activity;
        this.Uj = bVar;
        this.UR = bVar.UR;
        init();
    }

    private void init() {
        this.Uj.UR.a(this.Xn);
        this.Xm = false;
    }

    public final void destroy() {
        by.t(this);
        this.Uj.UR.b(this.Xn);
    }

    public final void h(Throwable th) {
        i(th);
    }

    private boolean sQ() {
        return this.Xj;
    }

    private void i(Throwable th) {
        Activity activity = this.mActivity;
        if (activity == null || activity.isFinishing()) {
            return;
        }
        j(th);
    }

    private void j(Throwable th) {
        ServerException serverExceptionL = com.kwad.components.core.innerEc.live.i.a.l(th);
        int i = serverExceptionL.errorCode;
        c.i("LiveExceptionService", "handleServerException errorCode: " + i + ", subCode" + serverExceptionL.subCode);
        PBHelper pBHelperRh = f.rh();
        if (i == 601) {
            if (serverExceptionL.subCode == 611) {
                c.d("LiveExceptionService", "LIVE_NEW_ONE_OPENED");
                return;
            }
            this.Xj = true;
            c.i("LiveExceptionService", "LIVE_AUDIENCE_END handleServerException");
            sR();
            return;
        }
        if (i == 603) {
            this.Xj = true;
            if (this.Uj.UK.isAdded()) {
                this.Uj.UR.setPlayerReleaseReason(pBHelperRh.getPbClientStat().getLiveEndByAdmin());
                this.Uj.UT.a(LiveAudienceEndReason.LIVE_BANNED);
                return;
            }
            return;
        }
        if (i == 607) {
            this.Xk = true;
            c.i("LiveExceptionService", "LIVE_KICKED_OUT_ROOM" + serverExceptionL.errorMessage);
            this.UR.setPlayerReleaseReason(pBHelperRh.getPbClientStat().getBannedByAnchor());
            aK(serverExceptionL.errorMessage);
            return;
        }
        if (i == 80216) {
            c.i("LiveExceptionService", "LIVE_START_PLAY_OVER_LOAD" + serverExceptionL.errorMessage);
            aK(serverExceptionL.errorMessage);
        } else {
            if (i < 600 || i == 608 || TextUtils.isEmpty(serverExceptionL.errorMessage)) {
                return;
            }
            c.i("LiveExceptionService", "LIVE_START_PLAY_OVER_LOAD" + serverExceptionL.errorMessage);
        }
    }

    public final void sR() {
        if (this.Uj.UK.isAdded() && this.Uj.US.sQ()) {
            if (this.Xm || this.UR.isBuffering() || !this.UR.isPlaying()) {
                sT();
                this.UR.setPlayerReleaseReason(f.rh().getPbClientStat().getLiveEndByAnchor());
                this.Uj.UT.a(LiveAudienceEndReason.ANCHOR_CLOSE);
                return;
            }
            sS();
        }
    }

    private void sS() {
        if (this.Xl == null) {
            bi biVar = new bi() { // from class: com.kwad.components.core.innerEc.live.c.a.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    a.a(a.this, true);
                    a.this.sR();
                }
            };
            this.Xl = biVar;
            by.a(biVar, this, 5000L);
        }
    }

    private void sT() {
        Runnable runnable = this.Xl;
        if (runnable != null) {
            by.b(runnable);
            this.Xl = null;
        }
    }

    private void aK(final String str) {
        if (com.kwad.components.core.innerEc.live.b.Tz != null) {
            com.kwad.components.core.innerEc.live.b.Tz.rF();
        }
        by.runOnUiThread(new Runnable() { // from class: com.kwad.components.core.innerEc.live.c.a.3
            @Override // java.lang.Runnable
            public final void run() {
                ae.V(a.this.mActivity, str);
                a.this.mActivity.finish();
            }
        });
    }
}
