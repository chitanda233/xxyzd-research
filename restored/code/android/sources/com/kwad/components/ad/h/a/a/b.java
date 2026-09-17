package com.kwad.components.ad.h.a.a;

import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.sdk.core.webview.c.a {
    public static int qX = 1;
    public static int qY = 2;
    private com.kwad.sdk.core.webview.c.c qW;
    private int qZ;
    private int ra;
    private InterfaceC0371b rc;
    private c rb = new c(this, 0);
    private Runnable rd = null;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int rf;
        public int rg;
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.h.a.a.b$b, reason: collision with other inner class name */
    public interface InterfaceC0371b {
        void Q(int i);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerTimerListener";
    }

    private b(int i, int i2) {
        this.qZ = i;
        this.ra = i2;
    }

    public static b I(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        if (!(!com.kwad.sdk.core.response.helper.a.bi(adInfoEM))) {
            return null;
        }
        if (com.kwad.sdk.core.response.helper.a.bQ(adInfoEM)) {
            return new b(qY, f(adInfoEM));
        }
        if (adInfoEM.adInsertScreenInfo.autoCloseTime > 0) {
            return new b(qX, adInfoEM.adInsertScreenInfo.autoCloseTime);
        }
        return null;
    }

    private static int f(AdInfo adInfo) {
        int iB = com.kwad.components.ad.interstitial.b.b.b(adInfo);
        if (iB <= 0) {
            iB = 60;
        }
        int i = adInfo.adInsertScreenInfo.autoCloseTime;
        return i > 0 ? Math.min(iB, i) : iB;
    }

    public final void a(InterfaceC0371b interfaceC0371b) {
        this.rc = interfaceC0371b;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.qW = cVar;
        Runnable runnable = this.rd;
        if (runnable != null) {
            runnable.run();
            this.rd = null;
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.qW = null;
    }

    public final void aw() {
        com.kwad.sdk.core.d.c.d("RegisterTimer", "startTimer: mCallBackFunction: " + this.qW);
        if (this.qW == null) {
            this.rd = new Runnable() { // from class: com.kwad.components.ad.h.a.a.b.1
                @Override // java.lang.Runnable
                public final void run() {
                    b.this.aw();
                }
            };
        } else {
            this.rb.X(this.ra);
            by.runOnUiThread(this.rb);
        }
    }

    public final void fZ() {
        this.rb.z(true);
    }

    public final void ga() {
        this.rb.z(false);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void W(int i) {
        com.kwad.sdk.core.d.c.d("RegisterTimer", "updateTimer: " + i + ", mCallBackFunction: " + this.qW);
        if (i >= 0 && this.qW != null) {
            InterfaceC0371b interfaceC0371b = this.rc;
            if (interfaceC0371b != null && i == 0) {
                interfaceC0371b.Q(this.qZ);
            }
            a aVar = new a();
            aVar.rg = i;
            aVar.rf = this.qZ;
            com.kwad.sdk.core.webview.c.c cVar = this.qW;
            if (cVar != null) {
                cVar.b(aVar);
            }
        }
    }

    class c implements Runnable {
        private boolean rh;
        private int ri;

        private c() {
            this.rh = false;
            this.ri = -1;
        }

        /* synthetic */ c(b bVar, byte b) {
            this();
        }

        @Override // java.lang.Runnable
        public final void run() {
            com.kwad.sdk.core.d.c.d("RegisterTimer", "TimerRunnable run timerPaused:  " + this.rh + ", currentTime: " + this.ri);
            if (this.rh) {
                by.a(this, null, 1000L);
                return;
            }
            int i = this.ri;
            if (i < 0) {
                return;
            }
            b.this.W(i);
            this.ri--;
            by.a(this, null, 1000L);
        }

        public final void X(int i) {
            this.ri = i;
        }

        public final void z(boolean z) {
            this.rh = z;
        }
    }
}
