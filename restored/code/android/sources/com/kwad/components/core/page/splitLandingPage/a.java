package com.kwad.components.core.page.splitLandingPage;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.page.d.b;
import com.kwad.components.core.page.splitLandingPage.view.SplitScrollWebView;
import com.kwad.components.core.proxy.h;
import com.kwad.components.core.t.x;
import com.kwad.components.core.widget.FeedVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bi;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends h {
    private FeedVideoView adh;
    private LinearLayout adi;
    private com.kwad.components.core.page.splitLandingPage.view.a afA;
    private b afB;
    private boolean afC;
    private SplitScrollWebView afy;
    private Presenter afz;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.afC = false;
        return false;
    }

    public static a aV(AdTemplate adTemplate) {
        a aVar = new a();
        Bundle bundle = new Bundle();
        bundle.putString("key_photo", adTemplate.toJson().toString());
        bundle.putBoolean("key_report", adTemplate.mPvReported);
        aVar.setArguments(bundle);
        return aVar;
    }

    @Override // com.kwad.components.core.proxy.h, com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        String string = getArguments().getString("key_photo");
        AdTemplate adTemplate = new AdTemplate();
        if (string != null) {
            try {
                adTemplate.parseJson(new JSONObject(string));
            } catch (JSONException e) {
                c.printStackTrace(e);
            }
        }
        this.mAdTemplate = adTemplate;
        adTemplate.mPvReported = getArguments().getBoolean("key_report", false);
        this.mAdTemplate.mAdWebVideoPageShowing = true;
    }

    @Override // com.kwad.components.core.proxy.h, com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onDestroy() {
        super.onDestroy();
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate != null) {
            adTemplate.mAdWebVideoPageShowing = false;
        }
    }

    private void A(View view) {
        this.adi = (LinearLayout) view.findViewById(R.id.ksad_web_tip_bar);
        TextView textView = (TextView) view.findViewById(R.id.ksad_web_tip_bar_textview);
        ((ImageView) view.findViewById(R.id.ksad_web_tip_close_btn)).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.page.splitLandingPage.a.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view2) {
                a.this.adi.setVisibility(8);
            }
        });
        AdInfo adInfoEM = e.eM(this.mAdTemplate);
        boolean zBF = com.kwad.sdk.core.response.helper.a.bF(adInfoEM);
        String strBB = com.kwad.sdk.core.response.helper.a.bB(adInfoEM);
        if (zBF) {
            this.adi.setVisibility(0);
            textView.setText(strBB);
            textView.setSelected(true);
            return;
        }
        this.adi.setVisibility(8);
    }

    public final void setApkDownloadHelper(d dVar) {
        this.mApkDownloadHelper = dVar;
    }

    @Override // com.kwad.components.core.proxy.h, com.kwad.sdk.l.a.b
    public final boolean onBackPressed() {
        SplitScrollWebView splitScrollWebView = this.afy;
        if (splitScrollWebView != null && splitScrollWebView.canGoBack()) {
            this.afy.goBack();
            return true;
        }
        if (uZ()) {
            return true;
        }
        FeedVideoView feedVideoView = this.adh;
        if (feedVideoView != null) {
            return feedVideoView.Ag();
        }
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean uZ() {
        SplitScrollWebView splitScrollWebView = this.afy;
        if (splitScrollWebView == null || splitScrollWebView.getTranslationY() != 0.0f || this.afC) {
            return false;
        }
        this.afy.setDisableAnimation(false);
        this.afC = true;
        SplitScrollWebView splitScrollWebView2 = this.afy;
        Animator animatorA = x.a((View) splitScrollWebView2, (Interpolator) null, 0.0f, splitScrollWebView2.getTranslationY() + this.adh.getHeight());
        AnimatorSet animatorSet = new AnimatorSet();
        if (com.kwad.sdk.core.config.e.Jw() == 2 && this.afA.isVisible()) {
            this.afA.vb();
            animatorSet.playSequentially(this.afA.aV(false), animatorA);
        } else {
            animatorSet.play(animatorA);
        }
        animatorSet.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.core.page.splitLandingPage.a.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                a.this.va();
                a.this.adh.vf();
                a.a(a.this, false);
            }
        });
        animatorSet.start();
        return true;
    }

    private void l(ViewGroup viewGroup) {
        Presenter presenter = new Presenter();
        this.afz = presenter;
        presenter.N(viewGroup);
        com.kwad.components.core.page.d.c cVar = new com.kwad.components.core.page.d.c();
        cVar.N(this.afy);
        b bVar = new b();
        this.afB = bVar;
        bVar.N(this.adh);
        this.afz.a(cVar);
        this.afz.a(this.afB);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void va() {
        this.afB.ob();
        this.afB.N(this.adh);
        this.afB.q(new com.kwad.components.core.page.recycle.e(this.mAdTemplate, this.mApkDownloadHelper, null));
    }

    public final void vb() {
        this.adh.vb();
    }

    @Override // com.kwad.components.core.proxy.h
    public final int rU() {
        return R.layout.ksad_split_land_page;
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onViewCreated(View view, Bundle bundle) {
        super.onViewCreated(view, bundle);
        this.adh = (FeedVideoView) findViewById(R.id.ksad_split_land_ad_feed_video);
        this.afy = (SplitScrollWebView) findViewById(R.id.ksad_video_webView);
        A(view);
        l(this.ou);
        initView();
    }

    private void initView() {
        com.kwad.components.core.page.recycle.e eVar = new com.kwad.components.core.page.recycle.e(this.mAdTemplate, this.mApkDownloadHelper, null);
        this.afz.q(eVar);
        com.kwad.components.core.page.splitLandingPage.view.a aVar = new com.kwad.components.core.page.splitLandingPage.view.a(this.mContext, new com.kwad.components.core.page.splitLandingPage.a.a(eVar.adTemplate, eVar.QK));
        this.afA = aVar;
        aVar.a(new com.kwad.components.core.page.splitLandingPage.view.a.InterfaceC0452a() { // from class: com.kwad.components.core.page.splitLandingPage.a.3
            @Override // com.kwad.components.core.page.splitLandingPage.view.a.InterfaceC0452a
            public final boolean vc() {
                return a.this.uZ();
            }
        });
        this.adh.post(new bi() { // from class: com.kwad.components.core.page.splitLandingPage.a.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.afy.setTranslationY(a.this.afy.getTranslationY() + a.this.adh.getHeight());
            }
        });
        this.afy.setSplitScrollWebViewListener(new SplitScrollWebView.a() { // from class: com.kwad.components.core.page.splitLandingPage.a.5
            @Override // com.kwad.components.core.page.splitLandingPage.view.SplitScrollWebView.a
            public final boolean vd() {
                if (!a.this.afA.ve() && com.kwad.sdk.core.config.e.Jw() == 2) {
                    return false;
                }
                AnimatorSet animatorSet = new AnimatorSet();
                Animator animatorA = x.a(a.this.afy, (Interpolator) null, a.this.afy.getTranslationY(), 0.0f);
                if (com.kwad.sdk.core.config.e.Jw() == 2) {
                    if (!a.this.adh.isComplete()) {
                        animatorSet.playSequentially(animatorA, a.this.afA.aV(true));
                    } else {
                        animatorSet.playTogether(animatorA);
                    }
                } else if (com.kwad.sdk.core.config.e.Jw() == 1) {
                    animatorSet.playTogether(animatorA);
                }
                animatorSet.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.core.page.splitLandingPage.a.5.1
                    @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                    public final void onAnimationEnd(Animator animator) {
                        super.onAnimationEnd(animator);
                        a.this.adh.vb();
                        if (com.kwad.sdk.core.config.e.Jw() != 2 || a.this.adh.isComplete()) {
                            return;
                        }
                        a.this.afA.vf();
                    }
                });
                animatorSet.start();
                return true;
            }

            @Override // com.kwad.components.core.page.splitLandingPage.view.SplitScrollWebView.a
            public final void g(float f) {
                a.this.afy.setTranslationY(a.this.afy.getTranslationY() - f);
            }
        });
    }
}
