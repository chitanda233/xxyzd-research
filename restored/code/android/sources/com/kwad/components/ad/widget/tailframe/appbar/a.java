package com.kwad.components.ad.widget.tailframe.appbar;

import android.animation.ValueAnimator;
import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.widget.AppScoreView;
import com.kwad.components.ad.widget.KsAppTagsView;
import com.kwad.components.core.page.widget.TextProgressBar;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.d;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends LinearLayout {
    protected View CJ;
    protected Button CK;
    protected Button CL;
    protected KsAppTagsView CR;
    protected com.kwad.components.ad.j.a CV;
    private Runnable CW;
    protected AppScoreView FD;
    protected TextProgressBar FT;
    protected View HS;
    protected TextView Op;
    protected TextView gK;
    protected ValueAnimator mf;
    protected ImageView nM;
    protected TextView nN;

    public abstract int getLayoutId();

    public a(Context context) {
        this(context, null);
    }

    public a(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public a(Context context, AttributeSet attributeSet, int i) {
        super(m.wrapContextIfNeed(context), attributeSet, i);
        initView();
    }

    private void initView() {
        this.HS = m.inflate(getContext(), getLayoutId(), this);
        this.nM = (ImageView) findViewById(R.id.ksad_app_icon);
        this.nN = (TextView) findViewById(R.id.ksad_app_name);
        this.FD = (AppScoreView) findViewById(R.id.ksad_app_score);
        this.gK = (TextView) findViewById(R.id.ksad_app_download_count);
        this.Op = (TextView) findViewById(R.id.ksad_app_introduce);
        TextProgressBar textProgressBar = (TextProgressBar) findViewById(R.id.ksad_download_bar);
        this.FT = textProgressBar;
        textProgressBar.setTextDimen(com.kwad.sdk.c.a.a.a(getContext(), 16.0f));
        this.FT.setTextColor(-1);
        this.CR = (KsAppTagsView) findViewById(R.id.ksad_reward_apk_info_tags);
        this.CK = (Button) findViewById(R.id.ksad_reward_apk_info_install_action);
        this.CL = (Button) findViewById(R.id.ksad_reward_apk_info_install_start);
        this.CJ = findViewById(R.id.ksad_reward_apk_info_install_container);
        this.CV = new com.kwad.components.ad.j.a(this.HS);
    }

    public void j(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        if (e.O(adTemplate)) {
            KSImageLoader.loadAppIcon(this.nM, com.kwad.sdk.core.response.helper.a.cV(adInfoEM), adTemplate, 12);
        } else {
            KSImageLoader.loadAppIcon(this.nM, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), adTemplate, 12);
        }
        this.nN.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
        if (!e.O(adTemplate)) {
            float fAG = com.kwad.sdk.core.response.helper.a.aG(adInfoEM);
            if (fAG >= 3.0f) {
                this.FD.setScore(fAG);
                this.FD.setVisibility(0);
            } else {
                this.FD.setVisibility(8);
            }
            String strAF = com.kwad.sdk.core.response.helper.a.aF(adInfoEM);
            if (!TextUtils.isEmpty(strAF)) {
                this.gK.setText(strAF);
                this.gK.setVisibility(0);
            } else {
                this.gK.setVisibility(8);
            }
        }
        this.Op.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        if (e.O(adTemplate)) {
            this.FT.setVisibility(8);
            this.CJ.setVisibility(0);
            this.CL.setText("查看详情");
            this.CK.setText(String.format("浏览详情页%s秒，领取奖励", new StringBuilder().append(com.kwad.sdk.core.config.e.Kj()).toString()));
            if (!adTemplate.mRewardVerifyCalled) {
                if (this.CW == null) {
                    this.CW = new Runnable() { // from class: com.kwad.components.ad.widget.tailframe.appbar.a.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            a.this.CV.jo();
                        }
                    };
                }
                this.CJ.postDelayed(this.CW, 1600L);
            }
        } else {
            this.FT.setVisibility(0);
            this.CJ.setVisibility(8);
            Runnable runnable = this.CW;
            if (runnable != null) {
                this.CJ.removeCallbacks(runnable);
                this.CW = null;
            }
            E(e.eM(adTemplate));
        }
        if (e.O(adTemplate)) {
            List<String> listED = d.eD(adTemplate);
            if (listED.size() > 0) {
                this.CR.setVisibility(0);
            } else {
                this.CR.setVisibility(8);
            }
            this.CR.setAppTags(listED);
        }
    }

    public TextProgressBar getTextProgressBar() {
        return this.FT;
    }

    public View getBtnInstallContainer() {
        return this.CJ;
    }

    public final void E(AdInfo adInfo) {
        int i = adInfo.status;
        if (i == 1 || i == 2 || i == 3) {
            lP();
        } else {
            oz();
        }
    }

    public final void lP() {
        ValueAnimator valueAnimator = this.mf;
        if (valueAnimator != null && valueAnimator.isRunning()) {
            this.mf.cancel();
            this.mf.end();
        }
        Runnable runnable = this.CW;
        if (runnable != null) {
            this.CJ.removeCallbacks(runnable);
            this.CW = null;
        }
        this.CV.oh();
    }

    private void oz() {
        ValueAnimator valueAnimator = this.mf;
        if (valueAnimator == null || !valueAnimator.isRunning()) {
            ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(1.0f, 1.2f, 1.0f);
            this.mf = valueAnimatorOfFloat;
            valueAnimatorOfFloat.setDuration(1200L);
            this.mf.setRepeatCount(-1);
            this.mf.setRepeatMode(1);
            this.mf.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.widget.tailframe.appbar.a.2
                @Override // android.animation.ValueAnimator.AnimatorUpdateListener
                public final void onAnimationUpdate(ValueAnimator valueAnimator2) {
                    float fFloatValue = ((Float) valueAnimator2.getAnimatedValue()).floatValue();
                    a.this.FT.setScaleY(fFloatValue);
                    a.this.FT.setScaleX(fFloatValue);
                }
            });
            this.mf.start();
        }
    }
}
