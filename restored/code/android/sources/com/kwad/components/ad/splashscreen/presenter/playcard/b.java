package com.kwad.components.ad.splashscreen.presenter.playcard;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.ad.splashscreen.presenter.e;
import com.kwad.components.ad.splashscreen.presenter.t;
import com.kwad.components.core.webview.tachikoma.f.g;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends e {
    private com.kwad.components.core.offline.a.f.b Kb;
    private long Kc;
    private volatile boolean Kd = false;
    private g mM = new g() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.b.1
        @Override // com.kwad.components.core.webview.tachikoma.f.b
        public final void v(String str) {
            b.this.Hu.bY = true;
            if ("tk_splash".equals(str)) {
                b.this.nD();
            }
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.g
        public final void a(String str, long j, long j2, long j3) {
            if (TextUtils.isEmpty(str) || !str.equals(com.kwad.sdk.core.response.helper.b.eh(b.this.Hu.mAdTemplate))) {
                return;
            }
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.a(b.this.Hu.mAdTemplate, b.this.Hu.GG, b.this.Hu.GP, b.this.Hu.GR, b.this.Hu.GQ, b.this.Hu.GS, j, j2, j3, SystemClock.elapsedRealtime() - b.this.Kc);
            b.this.Hu.GT = j;
            b.this.Hu.GU = j2;
            b.this.Hu.GV = j3;
            by.b(b.this.Ke);
        }
    };
    private final Runnable Ke = new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.b.2
        @Override // java.lang.Runnable
        public final void run() {
            if (b.this.Kd) {
                b.this.Hu.bY = true;
                b.this.nD();
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.c(b.this.Hu.mAdTemplate, b.this.Hu.GG);
                return;
            }
            b.this.nC();
        }
    };
    private com.kwad.components.core.offline.a.f.a Kf = new com.kwad.components.core.offline.a.f.a() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.b.3
        @Override // com.kwad.components.core.offline.a.f.a
        public final void a(int i, int i2, long j, long j2) {
            b.this.Hu.GP = i;
            b.this.Hu.GQ = i2;
            b.this.Hu.GR = j;
            b.this.Hu.GS = j2;
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.g(b.this.Hu.mAdTemplate, SystemClock.elapsedRealtime() - b.this.Kc);
            b.this.nC();
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
        if (nE()) {
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.a(this.Hu.mAdTemplate, this.Hu.GG);
            this.Hu.GO = this.Kc;
            by.runOnUiThreadDelay(this.Ke, com.kwad.sdk.core.response.helper.b.dT(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate)));
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(this.mM);
        }
        if (com.kwad.sdk.core.config.e.JX()) {
            nB();
        } else {
            nD();
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.core.offline.a.f.b bVar = this.Kb;
        if (bVar != null) {
            bVar.b(this.Kf);
        }
        if (nE()) {
            by.b(this.Ke);
            com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.mM);
        }
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
        if (nE()) {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.b.4
                @Override // java.lang.Runnable
                public final void run() {
                    b.this.a(new d(), true);
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void nD() {
        if (!com.kwad.sdk.core.response.helper.b.ek(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate)) || this.Hu.GM) {
            return;
        }
        this.Hu.GM = true;
        by.postOnUiThread(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.b.5
            @Override // java.lang.Runnable
            public final void run() {
                b.this.a(new t(), true);
            }
        });
    }

    private boolean nE() {
        if (com.kwad.sdk.core.config.e.JX()) {
            return com.kwad.sdk.core.response.helper.b.dO(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        }
        return false;
    }
}
