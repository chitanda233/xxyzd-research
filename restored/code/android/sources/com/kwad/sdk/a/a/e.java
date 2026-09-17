package com.kwad.sdk.a.a;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.util.Log;
import android.util.Property;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.view.ViewCompat;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements View.OnClickListener {
    private final boolean aHq;
    private final boolean aHr;
    private View aHs;
    private ImageView aHt;
    private TextView aHu;
    private Button aHv;
    private int aHw;
    private int aHx;
    private boolean aHy;
    private final AdInfo mAdInfo;
    private final AdTemplate mAdTemplate;
    private final Context mContext;
    private View mRootView = HF();

    public e(Context context, AdTemplate adTemplate, boolean z, boolean z2, boolean z3) {
        this.mContext = context;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.aHq = z;
        this.aHr = z2;
        this.aHy = z3;
        nX();
    }

    private View HF() {
        if (this.aHq && this.aHr) {
            this.mRootView = m.inflate(this.mContext, R.layout.ksad_install_tips_bottom, null);
        } else {
            this.mRootView = m.inflate(this.mContext, R.layout.ksad_install_tips, null);
        }
        ViewCompat.setElevation(this.mRootView, this.mContext.getResources().getDimension(R.dimen.ksad_install_tips_card_elevation));
        this.aHs = this.mRootView.findViewById(R.id.ksad_install_tips_close);
        this.aHt = (ImageView) this.mRootView.findViewById(R.id.ksad_install_tips_icon);
        this.aHu = (TextView) this.mRootView.findViewById(R.id.ksad_install_tips_content);
        this.aHv = (Button) this.mRootView.findViewById(R.id.ksad_install_tips_install);
        return this.mRootView;
    }

    private void nX() {
        this.aHv.setText(this.aHq ? "安装" : "打开");
        this.aHs.setOnClickListener(this);
        this.aHv.setOnClickListener(this);
        KSImageLoader.loadAppIcon(this.aHt, com.kwad.sdk.core.response.helper.a.cv(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)), this.mAdTemplate, 8);
        String strAB = com.kwad.sdk.core.response.helper.a.aB(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
        if (strAB.length() >= 8) {
            strAB = strAB.substring(0, 7) + "...";
        }
        this.aHu.setText(this.mContext.getString(this.aHq ? R.string.ksad_install_tips : R.string.ksad_launch_tips, strAB));
    }

    public final void b(FrameLayout frameLayout) {
        if (this.mRootView.getParent() != null) {
            return;
        }
        if (this.aHq && this.aHr) {
            d(frameLayout);
        } else {
            c(frameLayout);
        }
        this.mRootView.postDelayed(new bi() { // from class: com.kwad.sdk.a.a.e.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                e.this.dismiss();
            }
        }, ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT);
    }

    private void c(FrameLayout frameLayout) {
        FrameLayout.LayoutParams layoutParams;
        int dimensionPixelSize = this.mContext.getResources().getDimensionPixelSize(R.dimen.ksad_install_tips_card_height);
        int dimensionPixelSize2 = this.mContext.getResources().getDimensionPixelSize(R.dimen.ksad_install_tips_card_margin);
        this.aHw = dimensionPixelSize + dimensionPixelSize2;
        ViewGroup.LayoutParams layoutParams2 = this.mRootView.getLayoutParams();
        if (layoutParams2 instanceof FrameLayout.LayoutParams) {
            layoutParams = (FrameLayout.LayoutParams) layoutParams2;
        } else {
            layoutParams = new FrameLayout.LayoutParams(-1, dimensionPixelSize);
        }
        layoutParams.gravity = 48;
        layoutParams.leftMargin = dimensionPixelSize2;
        layoutParams.rightMargin = dimensionPixelSize2;
        layoutParams.topMargin = dimensionPixelSize2;
        this.mRootView.setTranslationY(-this.aHw);
        frameLayout.addView(this.mRootView, layoutParams);
        show();
    }

    private void d(FrameLayout frameLayout) {
        FrameLayout.LayoutParams layoutParams;
        int screenWidth = bt.getScreenWidth(this.mContext);
        int dimensionPixelSize = this.mContext.getResources().getDimensionPixelSize(R.dimen.ksad_install_tips_bottom_margin_left);
        int dimensionPixelSize2 = this.mContext.getResources().getDimensionPixelSize(R.dimen.ksad_install_tips_bottom_margin_bottom);
        int dimensionPixelOffset = this.mContext.getResources().getDimensionPixelOffset(R.dimen.ksad_install_tips_bottom_height);
        this.aHx = screenWidth - dimensionPixelSize;
        ViewGroup.LayoutParams layoutParams2 = this.mRootView.getLayoutParams();
        if (layoutParams2 instanceof FrameLayout.LayoutParams) {
            layoutParams = (FrameLayout.LayoutParams) layoutParams2;
        } else {
            layoutParams = new FrameLayout.LayoutParams(-1, dimensionPixelOffset);
        }
        layoutParams.gravity = 80;
        layoutParams.leftMargin = dimensionPixelSize;
        layoutParams.rightMargin = 0;
        layoutParams.bottomMargin = dimensionPixelSize2;
        this.mRootView.setTranslationX(this.aHx);
        frameLayout.addView(this.mRootView, layoutParams);
        show();
    }

    public final void dismiss() {
        if (this.mRootView.getParent() == null) {
            return;
        }
        final ViewGroup viewGroup = (ViewGroup) this.mRootView.getParent();
        Animator animatorI = I(this.mRootView);
        animatorI.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.sdk.a.a.e.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                viewGroup.removeView(e.this.mRootView);
            }
        });
        animatorI.start();
        c.Hx().HC();
    }

    private Animator I(View view) {
        ObjectAnimator objectAnimatorOfFloat;
        if (this.aHq && this.aHr) {
            objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, (Property<View, Float>) View.TRANSLATION_X, 0.0f, this.aHx);
        } else {
            objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, (Property<View, Float>) View.TRANSLATION_Y, 0.0f, -this.aHw);
        }
        objectAnimatorOfFloat.setInterpolator(PathInterpolatorCompat.create(0.0f, 0.42f, 0.85f, 0.64f));
        objectAnimatorOfFloat.setDuration(260L);
        return objectAnimatorOfFloat;
    }

    private void show() {
        ObjectAnimator objectAnimatorOfFloat;
        if (this.aHq && this.aHr) {
            objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.mRootView, (Property<View, Float>) View.TRANSLATION_X, this.aHx, 0.0f);
        } else {
            objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.mRootView, (Property<View, Float>) View.TRANSLATION_Y, -this.aHw, 0.0f);
        }
        objectAnimatorOfFloat.setInterpolator(PathInterpolatorCompat.create(0.25f, 0.1f, 0.27f, 0.87f));
        objectAnimatorOfFloat.setDuration(300L);
        objectAnimatorOfFloat.start();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        dismiss();
        if (view.getId() == R.id.ksad_install_tips_install) {
            if (this.aHq) {
                if (this.aHy) {
                    com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                    bVar.dU(29);
                    bVar.eb(23);
                    com.kwad.sdk.core.adlog.c.e(this.mAdTemplate, null, bVar);
                } else {
                    com.kwad.sdk.core.adlog.c.r(this.mAdTemplate, 45);
                }
                au.a(com.kwad.sdk.core.response.helper.a.J(this.mAdInfo), new au.a() { // from class: com.kwad.sdk.a.a.e.3
                    @Override // com.kwad.sdk.utils.au.a
                    public final void qC() {
                        com.kwad.sdk.core.adlog.c.k(e.this.mAdTemplate, 1);
                        com.kwad.sdk.commercial.a.a.bC(e.this.mAdTemplate);
                    }

                    @Override // com.kwad.sdk.utils.au.a
                    public final void d(Throwable th) {
                        com.kwad.sdk.commercial.a.a.j(e.this.mAdTemplate, 100003, Log.getStackTraceString(th));
                    }
                });
                return;
            }
            if (au.az(this.mContext, com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo))) {
                com.kwad.sdk.core.adlog.c.cm(this.mAdTemplate);
            }
            com.kwad.sdk.core.adlog.c.q(this.mAdTemplate, 47);
            return;
        }
        if (view.getId() == R.id.ksad_install_tips_close) {
            if (this.aHq) {
                if (this.aHy) {
                    com.kwad.sdk.core.adlog.c.b bVar2 = new com.kwad.sdk.core.adlog.c.b();
                    bVar2.dU(69);
                    bVar2.eb(23);
                    bVar2.ef(1);
                    com.kwad.sdk.core.adlog.c.e(this.mAdTemplate, null, bVar2);
                    return;
                }
                com.kwad.sdk.core.adlog.c.r(this.mAdTemplate, 46);
                return;
            }
            com.kwad.sdk.core.adlog.c.q(this.mAdTemplate, 48);
        }
    }
}
