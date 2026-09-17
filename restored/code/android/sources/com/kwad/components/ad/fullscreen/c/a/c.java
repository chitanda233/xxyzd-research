package com.kwad.components.ad.fullscreen.c.a;

import android.view.View;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.j;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private ImageView kw;
    private j.a kx = new j.a() { // from class: com.kwad.components.ad.fullscreen.c.a.c.1
        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeReleased() {
        }

        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeOccupied() {
            if (c.this.kw == null || com.kwad.components.ad.reward.a.b.hM()) {
                return;
            }
            c.this.kw.post(new bi() { // from class: com.kwad.components.ad.fullscreen.c.a.c.1.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.this.kw.setSelected(false);
                    c.this.ub.sr.setAudioEnabled(false, false);
                }
            });
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        ImageView imageView = (ImageView) findViewById(R.id.ksad_video_sound_switch);
        this.kw = imageView;
        imageView.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.kw.setVisibility(0);
        KsVideoPlayConfig ksVideoPlayConfig = this.ub.mVideoPlayConfig;
        if (!this.ub.sp && com.kwad.components.core.t.a.aN(getContext()).wP()) {
            this.kw.setSelected(false);
            this.ub.e(false, false);
        } else if (ksVideoPlayConfig != null) {
            this.kw.setSelected(ksVideoPlayConfig.isVideoSoundEnable());
            this.ub.e(ksVideoPlayConfig.isVideoSoundEnable(), ksVideoPlayConfig.isVideoSoundEnable());
        } else {
            this.kw.setSelected(true);
            this.ub.e(true, true);
        }
        this.ub.sr.a(this.kx);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.kx);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.kw) {
            this.ub.sr.setAudioEnabled(!this.kw.isSelected(), true);
            ImageView imageView = this.kw;
            imageView.setSelected(!imageView.isSelected());
        }
    }
}
