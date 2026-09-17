package com.kwad.components.ad.reward.presenter;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.R;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class o extends b implements View.OnClickListener, com.kwad.components.ad.reward.presenter.platdetail.actionbar.a {
    private static long wK = 300;
    private ImageView ix;
    private ViewGroup wL;
    private TextView wM;
    private boolean wN;
    private float wO;
    private WeakReference<View> wP;
    private r wQ;
    private boolean wR = false;
    private com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.o.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            o.this.hide();
        }
    };

    public o(r rVar) {
        this.wQ = rVar;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wO = com.kwad.components.ad.reward.a.b.hP();
        this.wN = !com.kwad.components.ad.reward.a.b.hR() && com.kwad.components.ad.reward.a.b.hQ();
    }

    private void initView() {
        ViewGroup viewGroup = this.wL;
        if (viewGroup == null) {
            return;
        }
        ImageView imageView = (ImageView) viewGroup.findViewById(R.id.ksad_playabel_pre_tips_icon);
        this.ix = imageView;
        imageView.setBackgroundColor(getContext().getResources().getColor(R.color.ksad_playable_pre_tips_icon_bg));
        this.wM = (TextView) this.wL.findViewById(R.id.ksad_playabel_pre_tips_text);
        this.wL.setOnClickListener(this);
    }

    private synchronized void iS() {
        if (this.wR) {
            return;
        }
        com.kwad.sdk.core.adlog.c.d(this.ub.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_SET_KSY_FRAME_WAIT).az(this.ub.sr.getPlayDuration()));
        this.wR = true;
    }

    public final void J(boolean z) {
        ViewGroup viewGroup = this.wL;
        if (viewGroup == null || viewGroup.getVisibility() == 0) {
            return;
        }
        iS();
        WeakReference<View> weakReference = this.wP;
        if (weakReference != null && weakReference.get() != null) {
            a(this.wP.get().getLayoutParams());
        }
        this.wL.setVisibility(0);
        if (z) {
            this.wL.postDelayed(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.o.2
                @Override // java.lang.Runnable
                public final void run() {
                    o.this.iT().start();
                }
            }, 2000L);
        }
    }

    public final void hide() {
        ViewGroup viewGroup = this.wL;
        if (viewGroup == null) {
            return;
        }
        viewGroup.setVisibility(8);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.wL == null) {
            ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_playable_pre_tips_stub);
            if (viewStub != null) {
                this.wL = (ViewGroup) viewStub.inflate();
            } else {
                this.wL = (ViewGroup) findViewById(R.id.ksad_playable_pre_tips_root);
            }
            initView();
        }
        if (this.ub.gY()) {
            a(new ViewGroup.LayoutParams(-1, this.wL.getResources().getDimensionPixelSize(R.dimen.ksad_reward_js_actionbar_height)));
        } else {
            this.ub.st.a(this);
        }
        this.ub.b(this.mPlayEndPageListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this.mPlayEndPageListener);
        this.ub.st.b(this);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Animator iT() {
        ValueAnimator valueAnimatorOfArgb;
        AnimatorSet animatorSet = new AnimatorSet();
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.wL, "translationX", getContext().getResources().getDimension(R.dimen.ksad_reward_playable_pre_tips_transx));
        Drawable background = this.ix.getBackground();
        if (background instanceof ColorDrawable) {
            final ColorDrawable colorDrawable = (ColorDrawable) background;
            valueAnimatorOfArgb = com.kwad.sdk.widget.a.ofArgb(getContext().getResources().getColor(R.color.ksad_playable_pre_tips_icon_bg), getContext().getResources().getColor(R.color.ksad_reward_main_color));
            valueAnimatorOfArgb.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.o.3
                @Override // android.animation.ValueAnimator.AnimatorUpdateListener
                public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                    colorDrawable.setColor(((Integer) valueAnimator.getAnimatedValue()).intValue());
                }
            });
        } else {
            valueAnimatorOfArgb = null;
        }
        animatorSet.playTogether(objectAnimatorOfFloat, valueAnimatorOfArgb, ObjectAnimator.ofFloat(this.wM, "alpha", 0.0f, 1.0f));
        animatorSet.setDuration(wK);
        return animatorSet;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        ViewGroup viewGroup = this.wL;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
        com.kwad.components.ad.reward.a.gq().a(PlayableSource.PENDANT_CLICK_NOT_AUTO);
        com.kwad.sdk.core.adlog.c.e(this.ub.mAdTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_SET_KSY_FRAME_WAIT).az(this.ub.sr.getPlayDuration()));
    }

    @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.a
    public final void a(RewardActionBarControl.ShowActionBarResult showActionBarResult, View view) {
        this.wP = new WeakReference<>(view);
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        com.kwad.sdk.core.d.c.d("RewardPlayablePreTips", "onActionBarShown: type: " + showActionBarResult + ", params.height: " + layoutParams.height + ", params.width: " + layoutParams.width);
        a(layoutParams);
    }

    private void a(ViewGroup.LayoutParams layoutParams) {
        if (layoutParams == null) {
            return;
        }
        ViewGroup.LayoutParams layoutParams2 = this.wL.getLayoutParams();
        if (layoutParams2 instanceof ViewGroup.MarginLayoutParams) {
            ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) layoutParams2;
            if (layoutParams.height == -1) {
                marginLayoutParams.bottomMargin = this.wL.getResources().getDimensionPixelSize(R.dimen.ksad_reward_playable_pre_tips_margin_bottom_without_actionbar);
            } else {
                int dimensionPixelSize = this.wL.getResources().getDimensionPixelSize(R.dimen.ksad_reward_playable_pre_tips_margin_bottom);
                if (layoutParams instanceof ViewGroup.MarginLayoutParams) {
                    ViewGroup.MarginLayoutParams marginLayoutParams2 = (ViewGroup.MarginLayoutParams) layoutParams;
                    WeakReference<View> weakReference = this.wP;
                    View view = weakReference != null ? weakReference.get() : null;
                    int height = marginLayoutParams2.height;
                    if (height <= 0 && view != null) {
                        height = view.getHeight();
                    }
                    marginLayoutParams.bottomMargin = height + marginLayoutParams2.bottomMargin + dimensionPixelSize;
                } else {
                    marginLayoutParams.bottomMargin = layoutParams.height + dimensionPixelSize;
                }
            }
            this.wL.setLayoutParams(marginLayoutParams);
        }
    }
}
