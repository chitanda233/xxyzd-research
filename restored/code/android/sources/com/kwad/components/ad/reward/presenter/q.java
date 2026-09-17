package com.kwad.components.ad.reward.presenter;

import android.view.View;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.widget.KsToastView;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class q extends b {
    private float wO;
    private r wQ;
    private KsToastView wX;
    private Runnable xa;
    private boolean wY = false;
    private boolean wZ = false;
    private boolean xb = false;
    private boolean wR = false;
    private com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.q.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            q.this.wX.setVisibility(8);
        }
    };

    static /* synthetic */ boolean a(q qVar, boolean z) {
        qVar.xb = true;
        return true;
    }

    public q(r rVar) {
        this.wQ = rVar;
    }

    public final void iV() {
        if (this.wZ) {
            return;
        }
        iS();
        this.wZ = true;
        this.wX.setVisibility(0);
        this.wX.ak(3);
        iX();
        by.a(this.xa, null, com.alipay.sdk.m.y.c.f378a);
    }

    public final void iW() {
        this.wZ = false;
        this.wX.setVisibility(8);
    }

    private synchronized void iS() {
        if (this.wR) {
            return;
        }
        com.kwad.sdk.core.adlog.c.d(this.ub.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_SET_KSY_FRAME_WAIT).az(this.ub.sr.getPlayDuration()));
        this.wR = true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wO = com.kwad.components.ad.reward.a.b.hP();
        this.wY = com.kwad.components.ad.reward.a.b.hQ() && com.kwad.components.ad.reward.a.b.hR();
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.wX == null) {
            KsToastView ksToastView = (KsToastView) findViewById(R.id.ksad_toast_view);
            this.wX = ksToastView;
            ksToastView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.presenter.q.2
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    q.a(q.this, true);
                    q.this.wX.setVisibility(8);
                    com.kwad.components.ad.reward.a.gq().a(PlayableSource.PENDANT_CLICK_AUTO);
                }
            });
        }
        this.ub.b(this.mPlayEndPageListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        iY();
        this.ub.c(this.mPlayEndPageListener);
    }

    private void iX() {
        this.xa = new Runnable() { // from class: com.kwad.components.ad.reward.presenter.q.3
            @Override // java.lang.Runnable
            public final void run() {
                if (q.this.xb) {
                    return;
                }
                if (q.this.wX != null) {
                    q.this.wX.setVisibility(8);
                }
                com.kwad.components.ad.reward.a.gq().a(PlayableSource.PENDANT_AUTO);
            }
        };
    }

    private void iY() {
        by.b(this.xa);
        this.xa = null;
    }
}
