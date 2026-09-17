package com.kwad.components.ad.reward.widget.tailframe;

import android.animation.ValueAnimator;
import android.content.Context;
import android.util.AttributeSet;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class TailFrameBarH5View extends LinearLayout {
    protected TextView gO;
    protected TextView gP;
    protected ValueAnimator mf;

    public TailFrameBarH5View(Context context) {
        this(context, null, 0);
    }

    public TailFrameBarH5View(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public TailFrameBarH5View(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    private void f(Context context, int i) {
        m.inflate(context, i, this);
        this.gO = (TextView) findViewById(R.id.ksad_tf_h5_ad_desc);
        this.gP = (TextView) findViewById(R.id.ksad_tf_h5_open_btn);
    }

    public final void h(boolean z, boolean z2) {
        int i;
        if (!z) {
            i = R.layout.ksad_video_tf_bar_h5_landscape;
        } else if (z2) {
            i = R.layout.ksad_video_tf_bar_h5_portrait_vertical;
        } else {
            i = R.layout.ksad_video_tf_bar_h5_portrait_horizontal;
        }
        f(getContext(), i);
    }

    public final void j(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        this.gO.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        this.gP.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        lO();
    }

    public TextView getH5OpenBtn() {
        return this.gP;
    }

    private void lO() {
        if (this.mf != null) {
            lP();
            this.mf.start();
        }
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(1.0f, 1.2f, 1.0f);
        this.mf = valueAnimatorOfFloat;
        valueAnimatorOfFloat.setDuration(1200L);
        this.mf.setRepeatCount(-1);
        this.mf.setRepeatMode(1);
        this.mf.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.widget.tailframe.TailFrameBarH5View.1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                float fFloatValue = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                TailFrameBarH5View.this.gP.setScaleY(fFloatValue);
                TailFrameBarH5View.this.gP.setScaleX(fFloatValue);
            }
        });
        this.mf.start();
    }

    public final void lP() {
        ValueAnimator valueAnimator = this.mf;
        if (valueAnimator == null || !valueAnimator.isRunning()) {
            return;
        }
        this.mf.cancel();
        this.mf.end();
    }
}
