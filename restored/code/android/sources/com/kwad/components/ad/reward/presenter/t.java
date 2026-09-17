package com.kwad.components.ad.reward.presenter;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.app.Activity;
import android.content.Context;
import android.content.res.Resources;
import android.graphics.drawable.GradientDrawable;
import android.os.Vibrator;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.t.x;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class t extends b implements View.OnClickListener, com.kwad.components.ad.reward.e.o, com.kwad.sdk.core.g.b {
    private com.kwad.sdk.core.g.d hm;
    private Vibrator ho;
    private ViewGroup kF;
    private TextView kG;
    private TextView kH;
    private ImageView kI;
    private FrameLayout kJ;
    private ImageView kK;
    private FrameLayout kL;
    private TextView kM;
    private Animator kN;
    private com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.t.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            if (t.this.kF != null) {
                t.this.kF.setVisibility(8);
            }
            if (t.this.kL != null) {
                t.this.kL.setVisibility(8);
            }
            if (t.this.hm != null) {
                t.this.hm.cb(t.this.getContext());
            }
            if (t.this.kN != null) {
                t.this.kN.cancel();
                t.this.kN = null;
            }
        }
    };

    @Override // com.kwad.sdk.core.g.b
    public final void cf() {
    }

    @Override // com.kwad.components.ad.reward.e.o
    public final int dv() {
        return com.kwad.sdk.c.a.a.h(getContext(), R.dimen.ksad_reward_shake_tips_title_marginBottom) + com.kwad.sdk.c.a.a.h(getContext(), R.dimen.ksad_reward_shake_tips_height);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        this.ub.a(this);
        this.ub.b(this.mPlayEndPageListener);
        dw();
        initView();
        a(adInfoEM);
        float fEz = com.kwad.sdk.core.response.helper.b.ez(adInfoEM);
        boolean zEu = com.kwad.sdk.core.response.helper.b.eu(adInfoEM);
        boolean zEA = com.kwad.sdk.core.response.helper.b.eA(adInfoEM);
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar == null) {
            com.kwad.sdk.core.g.d dVar2 = new com.kwad.sdk.core.g.d(zEu, fEz);
            this.hm = dVar2;
            dVar2.bG(zEA);
            this.hm.a(this);
        } else {
            dVar.m(fEz);
        }
        this.hm.ca(getContext());
        Context context = getContext();
        if (context != null) {
            this.ho = (Vibrator) context.getSystemService("vibrator");
        }
    }

    private void dw() {
        boolean z;
        final int dimensionPixelSize;
        int dimensionPixelSize2;
        final AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
        ViewGroup viewGroup = (ViewGroup) com.kwad.sdk.wrapper.m.a(getContext(), R.layout.ksad_shake_center, adBaseFrameLayout, false);
        this.kF = viewGroup;
        viewGroup.setVisibility(0);
        Resources resources = this.kF.getResources();
        try {
            z = com.kwad.sdk.core.response.helper.a.bl(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate)) == 8;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
        final int dimensionPixelSize3 = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_icon_marginLeft);
        if (this.ub.mScreenOrientation == 1) {
            dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_icon_marginBottom) + com.kwad.sdk.c.a.a.a(getContext(), 50.0f);
        } else if (z) {
            dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_icon_live_shop_marginBottom);
        } else {
            dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_icon_marginBottom);
        }
        if (this.ub.mScreenOrientation == 1) {
            dimensionPixelSize2 = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_title_marginBottom) + com.kwad.sdk.c.a.a.a(getContext(), 50.0f);
        } else if (z) {
            dimensionPixelSize2 = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_title_live_shop_marginBottom);
        } else {
            dimensionPixelSize2 = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_title_marginBottom);
        }
        int dimensionPixelSize4 = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_height);
        FrameLayout frameLayout = (FrameLayout) com.kwad.sdk.wrapper.m.a(getContext(), R.layout.ksad_shake_tips_title, adBaseFrameLayout, false);
        this.kL = frameLayout;
        this.kM = (TextView) frameLayout.findViewById(R.id.ksad_shake_tips_label);
        this.kL.setVisibility(4);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, dimensionPixelSize4);
        layoutParams.leftMargin = dimensionPixelSize3;
        layoutParams.bottomMargin = dimensionPixelSize2;
        layoutParams.gravity = 83;
        adBaseFrameLayout.addView(this.kL, layoutParams);
        FrameLayout.LayoutParams layoutParams2 = new FrameLayout.LayoutParams(-2, -2);
        layoutParams2.gravity = 17;
        adBaseFrameLayout.addView(this.kF, layoutParams2);
        com.kwad.sdk.core.adlog.c.b(this.ub.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SOLOPLAY, (JSONObject) null);
        this.kF.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.t.6
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int height = adBaseFrameLayout.getHeight();
                t tVar = t.this;
                tVar.kN = tVar.a(dimensionPixelSize3, height - dimensionPixelSize);
                if (t.this.kN != null) {
                    t.this.kN.start();
                }
            }
        });
    }

    private void initView() {
        this.kG = (TextView) this.kF.findViewById(R.id.ksad_shake_center_title);
        this.kH = (TextView) this.kF.findViewById(R.id.ksad_shake_center_sub_title);
        this.kI = (ImageView) this.kF.findViewById(R.id.ksad_shake_center_icon);
        this.kJ = (FrameLayout) this.kF.findViewById(R.id.ksad_shake_center_circle_area);
        this.kK = (ImageView) this.kF.findViewById(R.id.ksad_shake_center_circle_area_bg);
        this.kG.setOnClickListener(this);
        this.kH.setOnClickListener(this);
        this.kJ.setOnClickListener(this);
        this.kM.setOnClickListener(this);
    }

    private void a(AdInfo adInfo) {
        String strEC = com.kwad.sdk.core.response.helper.b.eC(adInfo);
        TextView textView = this.kG;
        if (textView != null) {
            textView.setText(strEC);
        }
        TextView textView2 = this.kM;
        if (textView2 != null) {
            textView2.setText(strEC);
        }
        String strA = a(this.ub, adInfo);
        TextView textView3 = this.kH;
        if (textView3 != null) {
            textView3.setText("或点击" + strA);
        }
    }

    private static String a(com.kwad.components.ad.reward.g gVar, AdInfo adInfo) {
        String strEE = com.kwad.sdk.core.response.helper.b.eE(adInfo);
        com.kwad.components.core.e.d.d dVar = gVar.mApkDownloadHelper;
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfo) || dVar == null) {
            return strEE;
        }
        int iQm = dVar.qm();
        AdMatrixInfo.DownloadTexts downloadTextsEG = com.kwad.sdk.core.response.helper.b.eG(adInfo);
        if (iQm == 8) {
            return downloadTextsEG.installAppLabel;
        }
        if (iQm == 12) {
            return downloadTextsEG.openAppLabel;
        }
        return downloadTextsEG.adActionDescription;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Animator a(float f, float f2) {
        if (this.kF == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        Resources resources = this.kF.getResources();
        Animator animatorA = x.a((View) this.kI, (Interpolator) null, 100L, 16.0f);
        animatorA.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.t.7
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                t.this.kI.setPivotX(t.this.kI.getWidth());
                t.this.kI.setPivotY(t.this.kI.getHeight());
            }
        });
        float left = this.kF.getLeft() + (this.kF.getWidth() / 2.0f);
        float top = this.kF.getTop() + (this.kF.getHeight() / 2.0f);
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.kF, "translationX", f - left);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(this.kF, "translationY", f2 - top);
        float dimension = resources.getDimension(R.dimen.ksad_reward_shake_tips_height);
        final float dimension2 = resources.getDimension(R.dimen.ksad_reward_shake_tips_icon_size);
        float width = this.kJ.getWidth();
        float width2 = this.kI.getWidth();
        if (width == 0.0f || width2 == 0.0f) {
            return null;
        }
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(width, dimension);
        valueAnimatorOfFloat.addUpdateListener(new com.kwad.components.ad.widget.a(this.kK) { // from class: com.kwad.components.ad.reward.presenter.t.8
            @Override // com.kwad.components.ad.widget.a
            public final void a(ViewGroup.LayoutParams layoutParams, Object obj) {
                float fFloatValue = ((Float) obj).floatValue();
                if (layoutParams != null) {
                    int i = (int) fFloatValue;
                    layoutParams.height = i;
                    layoutParams.width = i;
                }
            }
        });
        ValueAnimator valueAnimatorOfFloat2 = ValueAnimator.ofFloat(width2, dimension2);
        valueAnimatorOfFloat2.addUpdateListener(new com.kwad.components.ad.widget.a(this.kI) { // from class: com.kwad.components.ad.reward.presenter.t.9
            @Override // com.kwad.components.ad.widget.a
            public final void a(ViewGroup.LayoutParams layoutParams, Object obj) {
                float fFloatValue = ((Float) obj).floatValue();
                if (layoutParams != null) {
                    int i = (int) fFloatValue;
                    layoutParams.height = i;
                    layoutParams.width = i;
                }
            }
        });
        int color = resources.getColor(R.color.ksad_shake_icon_bg_start_color);
        final int color2 = resources.getColor(R.color.ksad_reward_main_color);
        final int dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_reward_shake_tips_icon_stroke_size);
        ValueAnimator valueAnimatorOfArgb = com.kwad.sdk.widget.a.ofArgb(color, color2);
        valueAnimatorOfArgb.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.t.10
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                    GradientDrawable gradientDrawable = (GradientDrawable) t.this.kK.getBackground();
                    gradientDrawable.mutate();
                    gradientDrawable.setColor(iIntValue);
                    if (iIntValue == color2) {
                        gradientDrawable.setStroke(dimensionPixelSize, -1);
                    }
                    t.this.kK.setBackground(gradientDrawable);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        });
        ValueAnimator valueAnimatorOfFloat3 = ValueAnimator.ofFloat(1.0f, 0.0f);
        valueAnimatorOfFloat3.setDuration(200L);
        valueAnimatorOfFloat3.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.t.11
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    float fFloatValue = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                    t.this.kG.setAlpha(fFloatValue);
                    t.this.kH.setAlpha(fFloatValue);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        });
        ValueAnimator valueAnimatorOfFloat4 = ValueAnimator.ofFloat(this.kG.getHeight(), 0.0f);
        valueAnimatorOfFloat4.addUpdateListener(new com.kwad.components.ad.widget.a(this.kG) { // from class: com.kwad.components.ad.reward.presenter.t.12
            @Override // com.kwad.components.ad.widget.a
            public final void a(ViewGroup.LayoutParams layoutParams, Object obj) {
                layoutParams.height = (int) ((Float) obj).floatValue();
            }
        });
        ValueAnimator valueAnimatorOfFloat5 = ValueAnimator.ofFloat(this.kH.getHeight(), 0.0f);
        valueAnimatorOfFloat5.addUpdateListener(new com.kwad.components.ad.widget.a(this.kH) { // from class: com.kwad.components.ad.reward.presenter.t.13
            @Override // com.kwad.components.ad.widget.a
            public final void a(ViewGroup.LayoutParams layoutParams, Object obj) {
                layoutParams.height = (int) ((Float) obj).floatValue();
            }
        });
        AnimatorSet animatorSet2 = new AnimatorSet();
        animatorSet2.setDuration(500L);
        animatorSet2.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2, valueAnimatorOfFloat, valueAnimatorOfFloat2, valueAnimatorOfArgb, valueAnimatorOfFloat4, valueAnimatorOfFloat5);
        AnimatorSet animatorSet3 = new AnimatorSet();
        final Animator animatorClone = animatorA.clone();
        animatorClone.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.t.2
            private boolean kP = false;

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                t.this.kI.setPivotX(dimension2);
                t.this.kI.setPivotY(dimension2);
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationCancel(Animator animator) {
                super.onAnimationCancel(animator);
                this.kP = true;
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                if (this.kP) {
                    return;
                }
                animatorClone.start();
            }
        });
        final ViewGroup.LayoutParams layoutParams = this.kL.getLayoutParams();
        ValueAnimator duration = ValueAnimator.ofFloat(0.0f, resources.getDimension(R.dimen.ksad_reward_shake_tips_width)).setDuration(500L);
        duration.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.t.3
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    t.this.kL.setVisibility(0);
                    layoutParams.width = (int) ((Float) valueAnimator.getAnimatedValue()).floatValue();
                    t.this.kL.setLayoutParams(layoutParams);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        });
        animatorSet3.playTogether(animatorClone, duration, ObjectAnimator.ofFloat(this.kM, "alpha", 0.0f, 1.0f).setDuration(500L));
        animatorSet.playSequentially(animatorA, animatorA.clone(), animatorA.clone(), valueAnimatorOfFloat3, animatorSet2, animatorSet3);
        return animatorSet;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        ViewGroup viewGroup = this.kF;
        if (viewGroup != null) {
            if (viewGroup.getParent() != null) {
                ((ViewGroup) this.kF.getParent()).removeView(this.kF);
            }
            this.kF = null;
        }
        by.b(getContext(), this.ho);
        this.ho = null;
        Animator animator = this.kN;
        if (animator != null) {
            animator.cancel();
            this.kN = null;
        }
        this.ub.c(this.mPlayEndPageListener);
    }

    @Override // com.kwad.sdk.core.g.b
    public final void a(double d) {
        com.kwad.sdk.core.c.b.Mh();
        Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
        Activity activity = getActivity();
        boolean z = activity != null && activity.equals(currentActivity);
        if (com.kwad.components.core.e.c.b.pF() || !z) {
            by.a(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.t.4
                @Override // java.lang.Runnable
                public final void run() {
                    t.this.hm.NS();
                }
            }, null, 500L);
            return;
        }
        if (this.ub != null && !this.ub.hf()) {
            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
            bVar.j(d);
            this.ub.a(1, getContext(), 157, 1, 0L, false, bVar);
        }
        by.a(new bi() { // from class: com.kwad.components.ad.reward.presenter.t.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.core.d.c.d("RewardShakePresenter", "onShakeEvent openGate2");
                t.this.hm.NS();
            }
        }, null, 500L);
        com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        if (this.ub.hf()) {
            return;
        }
        by.a(getContext(), this.ho);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (com.kwad.sdk.core.response.helper.b.ev(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate))) {
            this.ub.a(1, getContext(), 158, 1);
        }
    }
}
