package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.view.ViewGroup;
import android.widget.TextView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.splashscreen.presenter.e {
    private TextView JA;
    private ViewGroup JB;
    private ViewGroup JC;
    private AnimatorSet Jz;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        initView();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        nh();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        AnimatorSet animatorSet = this.Jz;
        if (animatorSet != null) {
            animatorSet.cancel();
        }
    }

    private void nh() {
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.JC, "alpha", 0.0f, 1.0f);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(this.JA, "alpha", 0.0f, 1.0f);
        ObjectAnimator objectAnimatorOfFloat3 = ObjectAnimator.ofFloat(this.JB, "scaleX", 0.8f, 1.0f);
        ObjectAnimator objectAnimatorOfFloat4 = ObjectAnimator.ofFloat(this.JB, "scaleY", 0.8f, 1.0f);
        AnimatorSet animatorSet = new AnimatorSet();
        this.Jz = animatorSet;
        animatorSet.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2, objectAnimatorOfFloat3, objectAnimatorOfFloat4);
        this.Jz.setDuration(300L);
        this.Jz.start();
    }

    private void initView() {
        this.JA = (TextView) findViewById(R.id.ksad_ad_developer_text);
        this.JB = (ViewGroup) findViewById(R.id.ksad_splash_end_card_native_view);
        this.JC = (ViewGroup) findViewById(R.id.ksad_splash_end_card_native_dialog_root);
    }
}
