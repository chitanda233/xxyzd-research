package com.kwad.components.ad.reward.n;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.graphics.drawable.Drawable;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class l extends s implements View.OnClickListener {
    private ImageView DT;
    private TextView DU;
    private View DV;
    private Set<ImageView> DW = new HashSet();
    private TextView DX;
    private Animator DY;
    private TextView fG;
    private TextView fH;
    private TextView fI;
    private ImageView ix;
    private com.kwad.components.ad.reward.g ub;

    static /* synthetic */ Animator a(l lVar, View view) {
        return s(view);
    }

    static /* synthetic */ Animator a(l lVar, View view, long j, float f) {
        return a(view, 100L, 8.0f);
    }

    public l(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
    }

    public final void j(ViewGroup viewGroup) {
        super.a(viewGroup, R.id.ksad_reward_live_subscribe_stub, R.id.ksad_reward_live_subscribe_root);
        initView();
    }

    private void initView() {
        if (this.wL == null) {
            return;
        }
        this.DU = (TextView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_badge);
        this.DT = (ImageView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_kwai_logo);
        this.ix = (ImageView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_icon);
        this.fG = (TextView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_name);
        this.fH = (TextView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_desc);
        this.fI = (TextView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_btn_follow);
        this.DV = this.wL.findViewById(R.id.ksad_reward_live_subscribe_follower_area);
        ImageView imageView = (ImageView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_follower_icon1);
        ImageView imageView2 = (ImageView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_follower_icon2);
        ImageView imageView3 = (ImageView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_follower_icon3);
        this.DW.add(imageView);
        this.DW.add(imageView2);
        this.DW.add(imageView3);
        this.DX = (TextView) this.wL.findViewById(R.id.ksad_reward_live_subscribe_count);
        this.wL.setOnClickListener(this);
        this.fI.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void a(r rVar) {
        super.a(rVar);
        AdTemplate adTemplate = rVar.getAdTemplate();
        if (adTemplate != null) {
            a(com.kwad.components.ad.reward.model.a.S(adTemplate));
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final void onUnbind() {
        super.onUnbind();
        Animator animator = this.DY;
        if (animator != null) {
            animator.cancel();
            this.DY = null;
        }
    }

    private void a(com.kwad.components.ad.reward.model.a aVar) {
        this.fG.setText(aVar.getTitle());
        this.fH.setText(aVar.iB());
        this.fI.setText(aVar.iy());
        String strHy = aVar.hy();
        Drawable drawable = this.ix.getResources().getDrawable(R.drawable.ksad_ic_default_user_avatar);
        KSImageLoader.loadCircleIcon(this.ix, strHy, drawable);
        String strAG = com.kwad.components.ad.e.b.aG();
        if (!br.isNullString(strAG)) {
            KSImageLoader.loadImage(this.DT, strAG, aVar.is());
        }
        if (aVar.iz()) {
            this.DV.setVisibility(0);
            String strIx = aVar.ix();
            if (!TextUtils.isEmpty(strIx)) {
                this.DX.setText(String.format("%s已预约直播", strIx));
            }
            if (aVar.iA() != null) {
                List<String> listIA = aVar.iA();
                int i = 0;
                for (ImageView imageView : this.DW) {
                    if (i < listIA.size()) {
                        imageView.setVisibility(0);
                        KSImageLoader.loadCircleIcon(imageView, listIA.get(i), drawable);
                    }
                    i++;
                }
                return;
            }
            return;
        }
        this.DV.setVisibility(8);
    }

    public final void lD() {
        lE();
        lF();
    }

    private void lE() {
        this.DU.postDelayed(new bi() { // from class: com.kwad.components.ad.reward.n.l.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                l lVar = l.this;
                lVar.DY = l.a(lVar, lVar.DU, 100L, 8.0f);
                l.this.DY.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.n.l.1.1
                    @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                    public final void onAnimationEnd(Animator animator) {
                        super.onAnimationEnd(animator);
                        if (l.this.DY != null) {
                            l.this.DY.start();
                        }
                    }
                });
                l.this.DY.start();
            }
        }, 500L);
    }

    private void lF() {
        by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.ad.reward.n.l.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                l lVar = l.this;
                l.a(lVar, lVar.DV).start();
            }
        }, 2000L);
    }

    private static Animator a(View view, long j, float f) {
        if (view == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.22f, 0.59f, 0.36f, 1.0f);
        view.setPivotX(0.0f);
        view.setPivotY(view.getHeight());
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 1.0f);
        objectAnimatorOfFloat.setDuration(100L);
        ObjectAnimator duration = ObjectAnimator.ofFloat(view, com.sigmob.sdk.base.common.a.B, 0.0f, f).setDuration(j);
        float f2 = -f;
        long j2 = j * 2;
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(view, com.sigmob.sdk.base.common.a.B, f, f2).setDuration(j2);
        duration2.setInterpolator(interpolatorCreate);
        ObjectAnimator duration3 = ObjectAnimator.ofFloat(view, com.sigmob.sdk.base.common.a.B, f2, f).setDuration(j2);
        ObjectAnimator duration4 = ObjectAnimator.ofFloat(view, com.sigmob.sdk.base.common.a.B, f, f2).setDuration(j2);
        duration4.setInterpolator(interpolatorCreate);
        animatorSet.playSequentially(objectAnimatorOfFloat, duration, duration2, duration3, duration4, ObjectAnimator.ofFloat(view, com.sigmob.sdk.base.common.a.B, f2, 0.0f).setDuration(j));
        return animatorSet;
    }

    private static Animator s(View view) {
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
        ObjectAnimator duration = ObjectAnimator.ofFloat(view, "translationY", view.getResources().getDimension(R.dimen.ksad_live_subscribe_card_count_area_trans_y)).setDuration(250L);
        duration.setInterpolator(interpolatorCreate);
        return duration;
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void ad(boolean z) {
        super.ad(z);
        Context context = this.wL.getContext();
        if (as.VV()) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = this.wL.getLayoutParams();
        layoutParams.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_live_subscribe_card_width_horizontal);
        this.wL.setLayoutParams(layoutParams);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.fI)) {
            this.ub.a(1, view.getContext(), 29, 1);
        } else if (view.equals(this.wL)) {
            this.ub.a(1, view.getContext(), 53, 2);
        }
    }
}
