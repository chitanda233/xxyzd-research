package com.kwad.components.ad.reward.presenter.platdetail.a;

import android.view.View;
import android.widget.ImageView;
import com.kwad.components.ad.reward.g;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.j;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private ImageView kw;
    private ImageView zF;
    private j.a kx = new j.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.d.1
        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeReleased() {
        }

        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeOccupied() {
            if (d.this.kw == null || com.kwad.components.ad.reward.a.b.hM()) {
                return;
            }
            d.this.kw.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.d.1.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    d.this.kw.setSelected(false);
                    d.this.ub.sr.setAudioEnabled(false, false);
                }
            });
        }
    };
    private com.kwad.components.ad.reward.m.c zG = new com.kwad.components.ad.reward.m.c() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.d.2
        @Override // com.kwad.components.ad.reward.m.c
        public final void jL() {
            d.this.jJ();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kw = (ImageView) findViewById(R.id.ksad_video_sound_switch);
        this.zF = (ImageView) findViewById(R.id.ksad_reward_deep_task_sound_switch);
        jK();
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.a(this.zG);
        this.ub.sr.a(this.kx);
        dq();
    }

    private void dq() {
        ImageView imageView;
        int i = 8;
        if (iL()) {
            this.kw.setVisibility(8);
            imageView = this.zF;
        } else {
            this.kw.setVisibility(g.P(this.mAdTemplate) ? 8 : 0);
            imageView = this.zF;
            if (g.P(this.mAdTemplate)) {
                i = 0;
            }
        }
        imageView.setVisibility(i);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jJ() {
        KsVideoPlayConfig ksVideoPlayConfig = this.ub.mVideoPlayConfig;
        boolean zIsVideoSoundEnable = true;
        if (!this.ub.sp && com.kwad.components.core.t.a.aN(getContext()).wP()) {
            this.zF.setSelected(true);
            this.ub.e(false, false);
            zIsVideoSoundEnable = false;
        } else if (ksVideoPlayConfig != null) {
            zIsVideoSoundEnable = ksVideoPlayConfig.isVideoSoundEnable();
            this.zF.setSelected(ksVideoPlayConfig.isVideoSoundEnable());
            this.ub.e(ksVideoPlayConfig.isVideoSoundEnable(), ksVideoPlayConfig.isVideoSoundEnable());
        } else {
            this.zF.setSelected(true);
            this.ub.e(true, true);
        }
        this.kw.setSelected(zIsVideoSoundEnable);
        this.ub.sr.setAudioEnabled(zIsVideoSoundEnable, false);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.kx);
        this.ub.b(this.zG);
    }

    private void jK() {
        this.kw.setOnClickListener(this);
        this.zF.setOnClickListener(this);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.kw) {
            this.ub.sr.setAudioEnabled(!this.kw.isSelected(), true);
            ImageView imageView = this.kw;
            imageView.setSelected(!imageView.isSelected());
        } else if (view == this.zF) {
            this.ub.sr.setAudioEnabled(!this.zF.isSelected(), true);
            ImageView imageView2 = this.zF;
            imageView2.setSelected(!imageView2.isSelected());
        }
    }
}
