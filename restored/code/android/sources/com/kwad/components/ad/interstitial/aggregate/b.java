package com.kwad.components.ad.interstitial.aggregate;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import androidx.viewpager.widget.ViewPager;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.core.j.d;
import com.kwad.sdk.core.response.model.AdGlobalConfigInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.wrapper.m;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.interstitial.h.a {
    private final com.kwad.sdk.core.j.c fA;
    private com.kwad.components.core.widget.a.c fs;
    private ValueAnimator lA;
    private boolean lB;
    private int lC;
    private int lD;
    private boolean lE;
    private final ViewPager.OnPageChangeListener lF;
    protected KsInterstitialAd.AdInteractionListener lk;
    private TransViewPager lx;
    private a ly;
    private ViewPagerIndicator lz;
    protected AdResultData mAdResultData;
    private final List<AdTemplate> mAdTemplateList;
    private final View mRootView;

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void dF() {
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void dG() {
    }

    public b(Context context) {
        this(context, null);
    }

    private b(Context context, AttributeSet attributeSet) {
        super(context, null);
        this.mAdTemplateList = new ArrayList();
        this.lC = 10;
        this.lD = 0;
        this.fA = new d() { // from class: com.kwad.components.ad.interstitial.aggregate.b.8
            @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
            public final void bv() {
                super.bv();
                if (b.this.lB) {
                    if (b.this.lz != null) {
                        b.this.lz.dL();
                    }
                    if (b.this.lA != null) {
                        b.this.lA.resume();
                    }
                    b.this.lB = false;
                }
            }

            @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
            public final void bw() {
                super.bw();
                if (b.this.lB) {
                    return;
                }
                if (b.this.lz != null) {
                    b.this.lz.dK();
                }
                if (b.this.lA != null) {
                    b.this.lA.pause();
                }
                b.this.lB = true;
            }
        };
        this.lF = new ViewPager.SimpleOnPageChangeListener() { // from class: com.kwad.components.ad.interstitial.aggregate.b.9
            private int lI = 0;

            @Override // androidx.viewpager.widget.ViewPager.SimpleOnPageChangeListener, androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageScrolled(int i, float f, int i2) {
            }

            @Override // androidx.viewpager.widget.ViewPager.SimpleOnPageChangeListener, androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageSelected(int i) {
                com.kwad.components.ad.interstitial.h.c cVarJ = b.this.lx.J(i);
                if (cVarJ != null) {
                    cVarJ.ff();
                }
                if (this.lI != i) {
                    com.kwad.sdk.core.adlog.c.a((AdTemplate) b.this.mAdTemplateList.get(this.lI), -1L, (JSONObject) null);
                    com.kwad.components.ad.interstitial.h.c cVarJ2 = b.this.lx.J(this.lI);
                    if (cVarJ2 != null) {
                        cVarJ2.fg();
                    }
                }
                this.lI = i;
            }
        };
        this.mContext = context;
        this.mRootView = m.inflate(context, R.layout.ksad_interstitial_multi_ad, this);
        initView();
    }

    private void initView() {
        this.lx = (TransViewPager) this.mRootView.findViewById(R.id.ksad_multi_ad_container);
        this.lz = (ViewPagerIndicator) this.mRootView.findViewById(R.id.ksad_multi_ad_indicator);
        this.fs = new com.kwad.components.core.widget.a.c(this.mRootView, 100);
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void a(AdResultData adResultData, com.kwad.components.ad.interstitial.d dVar, KsAdVideoPlayConfig ksAdVideoPlayConfig, KsInterstitialAd.AdInteractionListener adInteractionListener, int i) {
        this.mAdResultData = adResultData;
        this.lC = g(adResultData);
        this.mAdTemplateList.clear();
        this.mAdTemplateList.addAll(this.mAdResultData.getAdTemplateList());
        this.lD = this.mAdTemplateList.size();
        this.lk = adInteractionListener;
        a aVar = new a(this.mAdResultData, dVar, ksAdVideoPlayConfig, adInteractionListener);
        this.ly = aVar;
        aVar.a(new a.b() { // from class: com.kwad.components.ad.interstitial.aggregate.b.1
            @Override // com.kwad.components.ad.interstitial.aggregate.a.b
            public final void a(com.kwad.components.ad.interstitial.h.c cVar, int i2) {
                b.this.lx.a(i2, cVar);
            }
        });
        this.ly.a(new a.InterfaceC0373a() { // from class: com.kwad.components.ad.interstitial.aggregate.b.2
            @Override // com.kwad.components.ad.interstitial.aggregate.a.InterfaceC0373a
            public final void dE() {
                if (b.this.lA != null) {
                    b.this.lA.cancel();
                }
                b.this.lz.setPlayProgressListener(null);
                b.this.lz.setVisibility(8);
            }
        });
        this.lx.setAdapter(this.ly);
        this.lx.setScrollable(false);
        this.lx.setOffscreenPageLimit(this.mAdTemplateList.size() - 1);
        this.lx.addOnPageChangeListener(this.lF);
        this.ly.d(this.mAdTemplateList);
        this.ly.notifyDataSetChanged();
        this.fs.a(this.fA);
        this.fs.Am();
        if (this.lz == null) {
            return;
        }
        dH();
        ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) this.lz.getLayoutParams();
        if (marginLayoutParams != null) {
            this.lE = as.VV();
            marginLayoutParams.bottomMargin = com.kwad.sdk.c.a.a.a(this.mContext, this.lE ? 12.0f : 6.0f);
            this.lz.setLayoutParams(marginLayoutParams);
        }
        this.lz.setAdShowTime(this.lC);
        this.lz.setVisibility(0);
        this.lz.setViewPager(this.lx);
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void a(AdResultData adResultData, com.kwad.components.ad.interstitial.d dVar, KsAdVideoPlayConfig ksAdVideoPlayConfig, KsInterstitialAd.AdInteractionListener adInteractionListener, int i, boolean z) {
        this.mAdResultData = adResultData;
        this.lC = g(adResultData);
        this.mAdTemplateList.clear();
        this.mAdTemplateList.addAll(this.mAdResultData.getAdTemplateList());
        this.lD = this.mAdTemplateList.size();
        this.lk = adInteractionListener;
        a aVar = new a(this.mAdResultData, dVar, ksAdVideoPlayConfig, adInteractionListener, z);
        this.ly = aVar;
        aVar.a(new a.b() { // from class: com.kwad.components.ad.interstitial.aggregate.b.3
            @Override // com.kwad.components.ad.interstitial.aggregate.a.b
            public final void a(com.kwad.components.ad.interstitial.h.c cVar, int i2) {
                b.this.lx.a(i2, cVar);
            }
        });
        this.ly.a(new a.InterfaceC0373a() { // from class: com.kwad.components.ad.interstitial.aggregate.b.4
            @Override // com.kwad.components.ad.interstitial.aggregate.a.InterfaceC0373a
            public final void dE() {
                if (b.this.lA != null) {
                    b.this.lA.cancel();
                }
                b.this.lz.setPlayProgressListener(null);
                b.this.lz.setVisibility(8);
            }
        });
        this.lx.setAdapter(this.ly);
        this.lx.setScrollable(false);
        this.lx.setOffscreenPageLimit(this.mAdTemplateList.size() - 1);
        this.lx.addOnPageChangeListener(this.lF);
        this.ly.d(this.mAdTemplateList);
        this.ly.notifyDataSetChanged();
        this.fs.a(this.fA);
        this.fs.Am();
        if (this.lz == null) {
            return;
        }
        dH();
        ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) this.lz.getLayoutParams();
        if (marginLayoutParams != null) {
            this.lE = as.VV();
            marginLayoutParams.bottomMargin = com.kwad.sdk.c.a.a.a(this.mContext, this.lE ? 12.0f : 6.0f);
            this.lz.setLayoutParams(marginLayoutParams);
        }
        this.lz.setAdShowTime(this.lC);
        this.lz.setVisibility(0);
        this.lz.setViewPager(this.lx);
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void setAdInteractionListener(KsInterstitialAd.AdInteractionListener adInteractionListener) {
        this.lk = adInteractionListener;
    }

    @Override // android.view.ViewGroup, android.view.View
    protected final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        this.fs.b(this.fA);
        this.fs.An();
        this.mAdTemplateList.clear();
        this.lx.clearOnPageChangeListeners();
    }

    private void dH() {
        this.lz.setPlayProgressListener(new ViewPagerIndicator.a() { // from class: com.kwad.components.ad.interstitial.aggregate.b.5
            @Override // com.kwad.components.ad.interstitial.aggregate.ViewPagerIndicator.a
            public final void I(int i) {
                b.this.H(i);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void H(final int i) {
        final int width = getWidth();
        ValueAnimator valueAnimatorOfInt = ValueAnimator.ofInt(0, width);
        this.lA = valueAnimatorOfInt;
        valueAnimatorOfInt.setDuration(800L);
        this.lA.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.interstitial.aggregate.b.6
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                if (i < b.this.lD - 1) {
                    int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                    b.this.lx.scrollTo((i * width) + iIntValue, 0);
                    b.this.lx.onPageScrolled(i + 1, iIntValue / width, 0);
                }
            }
        });
        this.lA.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.interstitial.aggregate.b.7
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                if (i < b.this.lD - 1) {
                    b.this.lx.setCurrentItem(i + 1);
                }
            }
        });
        this.lA.start();
    }

    private static int g(AdResultData adResultData) {
        AdGlobalConfigInfo.CycleAggregationInfo cycleAggregationInfoT;
        if (adResultData == null || (cycleAggregationInfoT = com.kwad.sdk.core.response.helper.c.t(adResultData)) == null) {
            return 10;
        }
        return cycleAggregationInfoT.cycleAggregationInterval;
    }
}
