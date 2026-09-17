package com.kwad.components.ad.reward.presenter.platdetail.a;

import android.animation.ValueAnimator;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.reward.presenter.f;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private AdInfo mAdInfo;
    private TextView zA;
    private ImageView zz;
    private boolean zB = false;
    private View zC = null;
    private long zD = -1;
    private final m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.c.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            if (c.this.zD >= 0) {
                if (j2 > Math.min(Math.min(c.this.zD, com.kwad.sdk.core.response.helper.a.ak(c.this.mAdInfo)), j)) {
                    c.this.jI();
                }
            }
        }
    };
    private final com.kwad.components.ad.reward.e.e kD = new com.kwad.components.ad.reward.e.e() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.c.2
        @Override // com.kwad.components.ad.reward.e.e
        public final void du() {
            c.a(c.this, true);
            c.this.jI();
        }
    };

    static /* synthetic */ boolean a(c cVar, boolean z) {
        cVar.zB = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.zz = (ImageView) findViewById(R.id.ksad_detail_close_btn);
        this.zA = (TextView) findViewById(R.id.ksad_top_toolbar_close_tip);
        if (!TextUtils.isEmpty(com.kwad.components.ad.reward.a.b.hK())) {
            this.zA.setText(com.kwad.components.ad.reward.a.b.hK());
            this.zC = this.zA;
        } else {
            if (com.kwad.components.ad.reward.a.b.hJ() == 0) {
                this.zz.setImageResource(R.drawable.ksad_page_close);
            } else {
                this.zz.setImageResource(R.drawable.ksad_video_skip_icon);
            }
            this.zC = this.zz;
        }
        this.zC.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        this.ub.sr.a(this.jX);
        this.ub.sB.add(this.kD);
        long jAj = com.kwad.sdk.core.response.helper.a.aj(this.mAdInfo);
        this.zD = jAj;
        if (jAj == 0) {
            this.zC.setVisibility(0);
        } else {
            this.zC.setVisibility(8);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        this.ub.sB.remove(this.kD);
        this.zC.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jI() {
        if (this.zC.getVisibility() == 0) {
            return;
        }
        this.zC.setAlpha(0.0f);
        this.zC.setVisibility(0);
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.c.3
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                c.this.zC.setAlpha(((Float) valueAnimator.getAnimatedValue()).floatValue());
            }
        });
        valueAnimatorOfFloat.start();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.zC) {
            f.a(this.ub, this.zB);
        }
    }
}
