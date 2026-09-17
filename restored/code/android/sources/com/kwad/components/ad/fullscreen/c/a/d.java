package com.kwad.components.ad.fullscreen.c.a;

import android.animation.ValueAnimator;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private ImageView kA;
    private TextView kB;
    private View kC = null;
    private com.kwad.components.ad.reward.e.e kD = new com.kwad.components.ad.reward.e.e() { // from class: com.kwad.components.ad.fullscreen.c.a.d.1
        @Override // com.kwad.components.ad.reward.e.e
        public final void du() {
            d.this.dt();
        }
    };
    private m jX = new m() { // from class: com.kwad.components.ad.fullscreen.c.a.d.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            d.this.k(j2);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kA = (ImageView) findViewById(R.id.ksad_skip_icon);
        this.kB = (TextView) findViewById(R.id.ksad_top_toolbar_close_tip);
        if (!TextUtils.isEmpty(com.kwad.components.ad.fullscreen.a.b.db())) {
            this.kB.setText(com.kwad.components.ad.fullscreen.a.b.db());
            this.kA.setVisibility(8);
            this.kC = this.kB;
        } else {
            if (com.kwad.components.ad.fullscreen.a.b.da() == 0) {
                this.kA.setImageResource(R.drawable.ksad_page_close);
            } else {
                this.kA.setImageResource(R.drawable.ksad_video_skip_icon);
            }
            this.kB.setVisibility(8);
            this.kC = this.kA;
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.ub.sr.a(this.jX);
        this.ub.sB.add(this.kD);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sB.remove(this.kD);
        this.ub.sr.b(this.jX);
    }

    public final void k(long j) {
        if (j >= com.kwad.sdk.core.response.helper.a.ap(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            dt();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void dt() {
        if (this.kC.getVisibility() == 0) {
            return;
        }
        this.kC.setAlpha(0.0f);
        this.kC.setVisibility(0);
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.fullscreen.c.a.d.3
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                d.this.kC.setAlpha(((Float) valueAnimator.getAnimatedValue()).floatValue());
            }
        });
        valueAnimatorOfFloat.start();
        this.kC.setOnClickListener(this);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.kC) {
            com.kwad.components.ad.reward.presenter.f.a(this.ub, false);
        }
    }
}
