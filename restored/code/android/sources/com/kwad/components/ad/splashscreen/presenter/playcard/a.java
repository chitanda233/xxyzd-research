package com.kwad.components.ad.splashscreen.presenter.playcard;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.ad.splashscreen.presenter.e;
import com.kwad.components.ad.splashscreen.presenter.j;
import com.kwad.components.core.webview.tachikoma.f.g;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends e {
    private com.kwad.components.core.offline.a.f.b Kb;
    private long Kc;
    private volatile boolean Kd = false;
    private g mM = new g() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.a.1
        @Override // com.kwad.components.core.webview.tachikoma.f.b
        public final void v(String str) {
            a.this.Hu.bY = true;
            if ("tk_splash".equals(str)) {
                a.this.aX();
            }
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.g
        public final void a(String str, long j, long j2, long j3) {
            try {
                if (a.this.Hu.mStartRenderTime > 0 && !TextUtils.isEmpty(str) && str.equals(com.kwad.sdk.core.response.helper.b.eh(a.this.Hu.mAdTemplate))) {
                    com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(a.this.Hu.mAdTemplate), 2, SystemClock.elapsedRealtime() - a.this.Hu.mStartRenderTime);
                }
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
            if (TextUtils.isEmpty(str) || !str.equals(com.kwad.sdk.core.response.helper.b.eh(a.this.Hu.mAdTemplate))) {
                return;
            }
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.a(a.this.Hu.mAdTemplate, a.this.Hu.GG, a.this.Hu.GP, a.this.Hu.GR, a.this.Hu.GQ, a.this.Hu.GS, j, j2, j3, SystemClock.elapsedRealtime() - a.this.Kc);
            a.this.Hu.GT = j;
            a.this.Hu.GU = j2;
            a.this.Hu.GV = j3;
            by.b(a.this.Ke);
        }
    };
    private final Runnable Ke = new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.a.2
        @Override // java.lang.Runnable
        public final void run() {
            if (a.this.Kd) {
                a.this.Hu.bY = true;
                a.this.aX();
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.c(a.this.Hu.mAdTemplate, a.this.Hu.GG);
                return;
            }
            a.this.nC();
        }
    };
    private com.kwad.components.core.offline.a.f.a Kf = new com.kwad.components.core.offline.a.f.a() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.a.3
        @Override // com.kwad.components.core.offline.a.f.a
        public final void a(int i, int i2, long j, long j2) {
            a.this.Hu.GP = i;
            a.this.Hu.GQ = i2;
            a.this.Hu.GR = j;
            a.this.Hu.GS = j2;
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.g(a.this.Hu.mAdTemplate, SystemClock.elapsedRealtime() - a.this.Kc);
            a.this.nC();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Kc = SystemClock.elapsedRealtime();
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.a(this.Hu.mAdTemplate, this.Hu.GG);
        this.Hu.GO = this.Kc;
        by.runOnUiThreadDelay(this.Ke, com.kwad.sdk.core.response.helper.b.dS(this.Hu.mAdTemplate));
        com.kwad.components.core.webview.tachikoma.e.c.zS().a(this.mM);
        nB();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.core.offline.a.f.b bVar = this.Kb;
        if (bVar != null) {
            bVar.b(this.Kf);
        }
        by.b(this.Ke);
        com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.mM);
    }

    private void nB() {
        com.kwad.components.core.offline.a.f.b bVar = (com.kwad.components.core.offline.a.f.b) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.f.b.class);
        this.Kb = bVar;
        if (bVar != null) {
            bVar.a(this.Kf);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void nC() {
        if (this.Kd) {
            return;
        }
        this.Kd = true;
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.a.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.a(new com.kwad.components.ad.splashscreen.presenter.a.a(), true);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aX() {
        if (this.Hu.GN) {
            return;
        }
        this.Hu.GN = true;
        this.Hu.GM = true;
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.a.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.a(new j(), true);
            }
        });
    }
}
