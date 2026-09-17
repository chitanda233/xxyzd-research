package com.kwad.components.core.proxy.launchdialog;

import com.kwad.components.core.proxy.n;
import com.kwad.sdk.utils.by;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements n {
    private static long ajb = 7000;
    private DetectEventType ajc;
    private WeakReference<com.kwad.components.core.proxy.a> ajd;
    private List<g> aje = new ArrayList();
    private a ajf = new a(this, 0);
    private boolean started = false;

    public c(DetectEventType detectEventType, com.kwad.components.core.proxy.a aVar, g... gVarArr) {
        this.ajc = detectEventType;
        this.ajd = new WeakReference<>(aVar);
        this.aje.addAll(Arrays.asList(gVarArr));
    }

    public final void a(f fVar) {
        this.ajf.ajh = fVar;
    }

    public final boolean b(DetectEventType detectEventType) {
        return detectEventType != null && detectEventType.equals(this.ajc);
    }

    public final void start() {
        this.started = true;
        com.kwad.sdk.core.d.c.d("LifecycleSequence", "start call: " + this.ajc);
        by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.core.proxy.launchdialog.c.1
            @Override // java.lang.Runnable
            public final void run() {
                c.this.ajf.l(c.this.vR());
                com.kwad.sdk.core.d.c.d("LifecycleSequence", "DETECT_TIMEOUT call: " + c.this.ajc);
                c.this.stop();
            }
        }, ajb);
        d dVarVN = vN();
        com.kwad.sdk.core.d.c.d("LifecycleSequence", "start call current: " + dVarVN + this.ajc);
        a(dVarVN);
    }

    public final void stop() {
        com.kwad.sdk.core.d.c.d("LifecycleSequence", "stop call: " + this.ajc);
        this.ajf.stop();
        this.started = false;
    }

    private d vN() {
        com.kwad.components.core.proxy.a aVar;
        WeakReference<com.kwad.components.core.proxy.a> weakReference = this.ajd;
        if (weakReference == null || weakReference.get() == null || (aVar = this.ajd.get()) == null) {
            return null;
        }
        return aVar.vN();
    }

    private void a(d dVar) {
        com.kwad.sdk.core.d.c.d("LifecycleSequence", "checkMatch event: " + dVar);
        WeakReference<com.kwad.components.core.proxy.a> weakReference = this.ajd;
        if (weakReference == null || weakReference.get() == null) {
            return;
        }
        if (this.aje.size() == 0) {
            this.ajf.k(vR());
            return;
        }
        g gVar = this.aje.get(0);
        if (gVar instanceof g.a) {
            if (this.aje.size() < 2) {
                this.ajf.m(vR());
                return;
            }
            g gVar2 = this.aje.get(1);
            if (!(gVar2 instanceof g.b)) {
                this.ajf.m(vR());
                return;
            }
            d dVarVM = this.ajd.get().vM();
            g.b bVar = (g.b) gVar2;
            long jVU = dVarVM.vU();
            com.kwad.sdk.core.d.c.d("LifecycleSequence", "checkMatch last: " + dVarVM);
            g.a aVar = (g.a) gVar;
            if (aVar.N(jVU) && bVar.b(dVar.vT())) {
                this.aje.remove(gVar);
                this.aje.remove(gVar2);
                com.kwad.sdk.core.d.c.d("LifecycleSequence", "DurationMoreThanItem remove first: " + gVar + this.ajc);
                com.kwad.sdk.core.d.c.d("LifecycleSequence", "DurationMoreThanItem remove second: " + gVar2 + this.ajc);
                if (vQ()) {
                    return;
                }
                this.ajf.j(vR());
                return;
            }
            com.kwad.sdk.core.d.c.d("LifecycleSequence", "DurationMoreThanItem not match two: " + aVar.N(jVU) + ", " + bVar.b(dVar.vT()));
            this.ajf.m(vR());
            return;
        }
        if (gVar instanceof g.b) {
            if (((g.b) gVar).b(dVar.vT())) {
                this.aje.remove(gVar);
                com.kwad.sdk.core.d.c.d("LifecycleSequence", "PageEventItem remove: " + gVar);
                if (vQ()) {
                    return;
                }
                this.ajf.j(vR());
                return;
            }
            this.ajf.m(vR());
        }
    }

    private boolean vQ() {
        if (this.aje.size() != 0) {
            return false;
        }
        this.ajf.k(vR());
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.proxy.a vR() {
        WeakReference<com.kwad.components.core.proxy.a> weakReference = this.ajd;
        if (weakReference == null) {
            return null;
        }
        return weakReference.get();
    }

    @Override // com.kwad.components.core.proxy.k
    public final void a(com.kwad.components.core.proxy.a aVar) {
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.k
    public final void b(com.kwad.components.core.proxy.a aVar) {
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.k
    public final void c(com.kwad.components.core.proxy.a aVar) {
        com.kwad.sdk.core.d.c.d("LifecycleSequence", "LifecycleSequence onResume: " + aVar.getPageName() + " , type:" + this.ajc);
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.k
    public final void d(com.kwad.components.core.proxy.a aVar) {
        com.kwad.sdk.core.d.c.d("LifecycleSequence", this.started + " LifecycleSequence onPause: " + aVar.getPageName() + " , type:" + this.ajc);
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.k
    public final void e(com.kwad.components.core.proxy.a aVar) {
        com.kwad.sdk.core.d.c.d("LifecycleSequence", this.started + " LifecycleSequence onStop: " + aVar.getPageName() + " , type:" + this.ajc);
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.k
    public final void f(com.kwad.components.core.proxy.a aVar) {
        if (this.started) {
            a(vN());
        }
    }

    @Override // com.kwad.components.core.proxy.n
    public final boolean g(com.kwad.components.core.proxy.a aVar) {
        WeakReference<com.kwad.components.core.proxy.a> weakReference;
        if (aVar == null || (weakReference = this.ajd) == null || weakReference.get() == null) {
            return false;
        }
        return this.ajd.get().equals(aVar);
    }

    class a implements f {
        private f ajh;
        private boolean aji;

        private a() {
            this.aji = false;
        }

        /* synthetic */ a(c cVar, byte b) {
            this();
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void stop() {
            vS();
            this.ajh = null;
        }

        private void vS() {
            this.aji = true;
        }

        @Override // com.kwad.components.core.proxy.launchdialog.f
        public final void j(com.kwad.components.core.proxy.a aVar) {
            f fVar = this.ajh;
            if (fVar == null) {
                return;
            }
            fVar.j(aVar);
        }

        @Override // com.kwad.components.core.proxy.launchdialog.f
        public final void k(com.kwad.components.core.proxy.a aVar) {
            f fVar;
            if (this.aji || (fVar = this.ajh) == null) {
                return;
            }
            fVar.k(aVar);
            vS();
        }

        @Override // com.kwad.components.core.proxy.launchdialog.f
        public final void l(com.kwad.components.core.proxy.a aVar) {
            f fVar;
            if (this.aji || (fVar = this.ajh) == null) {
                return;
            }
            fVar.l(aVar);
            vS();
        }

        @Override // com.kwad.components.core.proxy.launchdialog.f
        public final void m(com.kwad.components.core.proxy.a aVar) {
            f fVar;
            if (this.aji || (fVar = this.ajh) == null) {
                return;
            }
            fVar.m(aVar);
            vS();
        }
    }
}
