package com.kwad.components.ad.fullscreen.c.a;

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
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.e.o;
import com.kwad.components.core.t.x;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.widget.h;
import com.kwad.sdk.wrapper.m;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.ad.reward.presenter.b implements o, com.kwad.sdk.core.g.b, com.kwad.sdk.widget.d {
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
    private g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.fullscreen.c.a.f.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            if (f.this.kF != null) {
                f.this.kF.setVisibility(8);
            }
            if (f.this.kL != null) {
                f.this.kL.setVisibility(8);
            }
            if (f.this.hm != null) {
                f.this.hm.cb(f.this.getContext());
            }
            if (f.this.kN != null) {
                f.this.kN.cancel();
                f.this.kN = null;
            }
        }
    };

    @Override // com.kwad.sdk.core.g.b
    public final void cf() {
    }

    @Override // com.kwad.components.ad.reward.e.o
    public final int dv() {
        return com.kwad.sdk.c.a.a.h(getContext(), R.dimen.ksad_fullscreen_shake_tips_title_marginBottom) + com.kwad.sdk.c.a.a.h(getContext(), R.dimen.ksad_fullscreen_shake_tips_height);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        if (com.kwad.components.ad.fullscreen.b.a.b(getContext(), this.ub.mAdTemplate)) {
            this.ub.a(this);
            this.ub.b(this.mPlayEndPageListener);
            dw();
            initView();
            a(adInfoEM);
            float fEw = com.kwad.sdk.core.response.helper.b.ew(adInfoEM);
            boolean zEx = com.kwad.sdk.core.response.helper.b.ex(adInfoEM);
            boolean zEy = com.kwad.sdk.core.response.helper.b.ey(adInfoEM);
            com.kwad.sdk.core.g.d dVar = this.hm;
            if (dVar == null) {
                com.kwad.sdk.core.g.d dVar2 = new com.kwad.sdk.core.g.d(zEx, fEw);
                this.hm = dVar2;
                dVar2.bG(zEy);
                this.hm.a(this);
            } else {
                dVar.m(fEw);
            }
            this.hm.ca(getContext());
            Context context = getContext();
            if (context != null) {
                this.ho = (Vibrator) context.getSystemService("vibrator");
            }
            com.kwad.components.ad.fullscreen.b.a.H(getContext());
        }
    }

    private void dw() {
        boolean z;
        final int dimensionPixelSize;
        int dimensionPixelSize2;
        final AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
        ViewGroup viewGroup = (ViewGroup) m.a(getContext(), R.layout.ksad_shake_center, adBaseFrameLayout, false);
        this.kF = viewGroup;
        viewGroup.setVisibility(0);
        Resources resources = this.kF.getResources();
        try {
            z = com.kwad.sdk.core.response.helper.a.bl(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate)) == 8 && this.ub.mScreenOrientation == 0;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
        if (z) {
            dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_icon_live_shop_marginBottom);
        } else {
            dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_icon_marginBottom);
        }
        final int dimensionPixelSize3 = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_icon_marginLeft);
        if (z) {
            dimensionPixelSize2 = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_title_live_shop_marginBottom);
        } else {
            dimensionPixelSize2 = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_title_marginBottom);
        }
        int dimensionPixelSize4 = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_height);
        FrameLayout frameLayout = (FrameLayout) m.a(getContext(), R.layout.ksad_shake_tips_title, adBaseFrameLayout, false);
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
        this.kF.post(new bi() { // from class: com.kwad.components.ad.fullscreen.c.a.f.6
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int height = adBaseFrameLayout.getHeight();
                f fVar = f.this;
                fVar.kN = fVar.a(dimensionPixelSize3, height - dimensionPixelSize);
                if (f.this.kN != null) {
                    f.this.kN.start();
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
        new h(getContext(), this.kF, this);
    }

    private void a(AdInfo adInfo) {
        String strEB = com.kwad.sdk.core.response.helper.b.eB(adInfo);
        TextView textView = this.kG;
        if (textView != null) {
            textView.setText(strEB);
        }
        TextView textView2 = this.kM;
        if (textView2 != null) {
            textView2.setText(strEB);
        }
        String strA = a(this.ub, adInfo);
        TextView textView3 = this.kH;
        if (textView3 != null) {
            textView3.setText("或点击" + strA);
        }
    }

    private static String a(com.kwad.components.ad.reward.g gVar, AdInfo adInfo) {
        String strED = com.kwad.sdk.core.response.helper.b.eD(adInfo);
        com.kwad.components.core.e.d.d dVar = gVar.mApkDownloadHelper;
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfo) || dVar == null) {
            return strED;
        }
        int iQm = dVar.qm();
        AdMatrixInfo.DownloadTexts downloadTextsEF = com.kwad.sdk.core.response.helper.b.eF(adInfo);
        if (iQm == 8) {
            return downloadTextsEF.installAppLabel;
        }
        if (iQm == 12) {
            return downloadTextsEF.openAppLabel;
        }
        return downloadTextsEF.adActionDescription;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Animator a(float f, float f2) {
        if (this.kF == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        Resources resources = this.kF.getResources();
        Animator animatorA = x.a((View) this.kI, (Interpolator) null, 100L, 16.0f);
        animatorA.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.fullscreen.c.a.f.7
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                f.this.kI.setPivotX(f.this.kI.getWidth());
                f.this.kI.setPivotY(f.this.kI.getHeight());
            }
        });
        float left = this.kF.getLeft() + (this.kF.getWidth() / 2.0f);
        float top = this.kF.getTop() + (this.kF.getHeight() / 2.0f);
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.kF, "translationX", f - left);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(this.kF, "translationY", f2 - top);
        float dimension = resources.getDimension(R.dimen.ksad_fullscreen_shake_tips_height);
        final float dimension2 = resources.getDimension(R.dimen.ksad_fullscreen_shake_tips_icon_size);
        float width = this.kJ.getWidth();
        float width2 = this.kI.getWidth();
        if (width == 0.0f || width2 == 0.0f) {
            return null;
        }
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(width, dimension);
        valueAnimatorOfFloat.addUpdateListener(new com.kwad.components.ad.widget.a(this.kK) { // from class: com.kwad.components.ad.fullscreen.c.a.f.8
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
        valueAnimatorOfFloat2.addUpdateListener(new com.kwad.components.ad.widget.a(this.kI) { // from class: com.kwad.components.ad.fullscreen.c.a.f.9
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
        final int dimensionPixelSize = resources.getDimensionPixelSize(R.dimen.ksad_fullscreen_shake_tips_icon_stroke_size);
        ValueAnimator valueAnimatorOfArgb = com.kwad.sdk.widget.a.ofArgb(color, color2);
        valueAnimatorOfArgb.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.fullscreen.c.a.f.10
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                    GradientDrawable gradientDrawable = (GradientDrawable) f.this.kK.getBackground();
                    gradientDrawable.mutate();
                    gradientDrawable.setColor(iIntValue);
                    if (iIntValue == color2) {
                        gradientDrawable.setStroke(dimensionPixelSize, -1);
                    }
                    f.this.kK.setBackground(gradientDrawable);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        });
        ValueAnimator valueAnimatorOfFloat3 = ValueAnimator.ofFloat(1.0f, 0.0f);
        valueAnimatorOfFloat3.setDuration(200L);
        valueAnimatorOfFloat3.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.fullscreen.c.a.f.11
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    float fFloatValue = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                    f.this.kG.setAlpha(fFloatValue);
                    f.this.kH.setAlpha(fFloatValue);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }
        });
        ValueAnimator valueAnimatorOfFloat4 = ValueAnimator.ofFloat(this.kG.getHeight(), 0.0f);
        valueAnimatorOfFloat4.addUpdateListener(new com.kwad.components.ad.widget.a(this.kG) { // from class: com.kwad.components.ad.fullscreen.c.a.f.12
            @Override // com.kwad.components.ad.widget.a
            public final void a(ViewGroup.LayoutParams layoutParams, Object obj) {
                layoutParams.height = (int) ((Float) obj).floatValue();
            }
        });
        ValueAnimator valueAnimatorOfFloat5 = ValueAnimator.ofFloat(this.kH.getHeight(), 0.0f);
        valueAnimatorOfFloat5.addUpdateListener(new com.kwad.components.ad.widget.a(this.kH) { // from class: com.kwad.components.ad.fullscreen.c.a.f.13
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
        animatorClone.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.fullscreen.c.a.f.2
            private boolean kP = false;

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                f.this.kI.setPivotX(dimension2);
                f.this.kI.setPivotY(dimension2);
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
        ValueAnimator duration = ValueAnimator.ofFloat(0.0f, resources.getDimension(R.dimen.ksad_fullscreen_shake_tips_width)).setDuration(500L);
        duration.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.fullscreen.c.a.f.3
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                try {
                    f.this.kL.setVisibility(0);
                    layoutParams.width = (int) ((Float) valueAnimator.getAnimatedValue()).floatValue();
                    f.this.kL.setLayoutParams(layoutParams);
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
            by.a(new Runnable() { // from class: com.kwad.components.ad.fullscreen.c.a.f.4
                @Override // java.lang.Runnable
                public final void run() {
                    f.this.hm.NS();
                }
            }, null, 500L);
            return;
        }
        if (this.ub != null) {
            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
            bVar.j(d);
            this.ub.a(1, getContext(), 157, 1, 0L, false, bVar);
        }
        by.a(new bi() { // from class: com.kwad.components.ad.fullscreen.c.a.f.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.core.d.c.d("ShakePresenter", "onShakeEvent openGate2");
                f.this.hm.NS();
            }
        }, null, 500L);
        by.a(getContext(), this.ho);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        this.ub.a(1, getContext(), 158, 1);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.ub.mAdTemplate, f, f2, f3, f4)) {
            this.ub.a(1, getContext(), 158, 1);
        }
    }
}
