package com.kwad.components.ad.splashscreen.presenter;

import android.os.SystemClock;
import android.view.View;
import android.view.ViewTreeObserver;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.cb;

/* JADX INFO: loaded from: classes3.dex */
public final class k extends e implements com.kwad.sdk.core.j.c {
    private View HR;
    private View HS;
    private ViewTreeObserver.OnGlobalLayoutListener qw;
    private boolean HQ = false;
    private boolean HT = false;

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
    }

    static /* synthetic */ boolean a(k kVar, View view) {
        return u(view);
    }

    static /* synthetic */ boolean a(k kVar, boolean z) {
        kVar.HQ = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Hu.mAdTemplate.addStartTime = SystemClock.elapsedRealtime();
        this.Hu.GH.a(this);
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.f(this.Hu.mAdTemplate, SystemClock.elapsedRealtime() - this.Hu.mAdTemplate.showStartTime);
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.as(this.Hu.mAdTemplate);
        if (com.kwad.sdk.core.response.helper.a.cM(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            this.Hu.U(getContext());
        }
        try {
            this.HS = getRootView();
            this.qw = new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.kwad.components.ad.splashscreen.presenter.k.1
                @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
                public final void onGlobalLayout() {
                    try {
                        if (k.this.HR == null || k.this.HS == null || k.this.HR.getVisibility() != 0 || k.this.HQ) {
                            return;
                        }
                        k.a(k.this, true);
                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                        com.kwad.components.ad.splashscreen.monitor.b.am(k.this.Hu.mAdTemplate);
                        k.this.HS.postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.k.1.1
                            @Override // com.kwad.sdk.utils.bi
                            public final void doTask() {
                                if (k.this.HS.getVisibility() == 0) {
                                    if (k.this.Hu.mAdTemplate.mPvReported) {
                                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                                        com.kwad.components.ad.splashscreen.monitor.b.an(k.this.Hu.mAdTemplate);
                                        return;
                                    }
                                    if (!k.this.Hu.GH.Aq()) {
                                        boolean zA = k.a(k.this, k.this.HS);
                                        boolean z = false;
                                        if (k.this.HR != null && k.this.HR.getVisibility() == 0) {
                                            z = true;
                                        }
                                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                                        com.kwad.components.ad.splashscreen.monitor.b.a(k.this.Hu.mAdTemplate, zA, z, k.this.HT);
                                        return;
                                    }
                                    com.kwad.components.ad.splashscreen.monitor.b.mt();
                                    com.kwad.components.ad.splashscreen.monitor.b.ao(k.this.Hu.mAdTemplate);
                                    return;
                                }
                                com.kwad.components.ad.splashscreen.monitor.b.mt();
                                com.kwad.components.ad.splashscreen.monitor.b.ap(k.this.Hu.mAdTemplate);
                            }
                        }, 1000L);
                    } catch (Throwable unused) {
                    }
                }
            };
            if (this.HS != null && getRootView().getParent() != null && (getRootView().getParent() instanceof View)) {
                View view = (View) getRootView().getParent();
                this.HR = view;
                if (view.getViewTreeObserver() != null) {
                    this.HR.getViewTreeObserver().addOnGlobalLayoutListener(this.qw);
                    return;
                }
                return;
            }
            if (this.HS == null) {
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.aq(this.Hu.mAdTemplate);
            } else {
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.ar(this.Hu.mAdTemplate);
            }
        } catch (Exception e) {
            ServiceProvider.reportSdkCaughtException(e);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.HT = true;
        this.Hu.GH.b(this);
        View view = this.HR;
        if (view != null && view.getViewTreeObserver() != null && this.qw != null) {
            this.HR.getViewTreeObserver().removeOnGlobalLayoutListener(this.qw);
        }
        this.HR = null;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        this.Hu.U(getContext());
    }

    private static boolean u(View view) {
        if (view == null) {
            return false;
        }
        com.kwad.sdk.core.c.b.Mh();
        if (com.kwad.sdk.core.c.b.isEnable()) {
            com.kwad.sdk.core.c.b.Mh();
            return com.kwad.sdk.core.c.b.isAppOnForeground() && cb.a(view, 70, true);
        }
        return cb.a(view, 70, true);
    }
}
