package com.kwad.components.ad.nativead;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.lang.ref.WeakReference;
import java.util.Iterator;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static long hr;
    private com.kwad.sdk.core.g.d hm;
    private com.kwad.sdk.core.g.c hn;
    private CopyOnWriteArrayList<d> oW = new CopyOnWriteArrayList<>();
    private CopyOnWriteArrayList<C0385b> oX = new CopyOnWriteArrayList<>();
    private int oY;

    public interface c {
        boolean s(String str);
    }

    public interface e {
        boolean b(double d);
    }

    static final class a {
        private static final b pb = new b();
    }

    public static b fr() {
        return a.pb;
    }

    public static class d {
        private final e pe;
        private final WeakReference<View> pf;

        public d(e eVar, View view) {
            this.pf = new WeakReference<>(view);
            this.pe = eVar;
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.nativead.b$b, reason: collision with other inner class name */
    public static class C0385b {
        private Context mContext;
        private c pd;

        public C0385b(c cVar, Context context) {
            this.pd = cVar;
            this.mContext = context;
        }
    }

    public final void a(boolean z, float f, View view, e eVar, boolean z2) {
        if (view == null || view.getContext() == null) {
            return;
        }
        if (this.hm == null) {
            this.oY = com.kwad.sdk.c.a.a.bz(view.getContext());
            a(z, f, view.getContext(), z2);
        }
        this.oW.add(new d(eVar, view));
    }

    public final void a(e eVar) {
        for (d dVar : this.oW) {
            if (dVar.pe == eVar) {
                this.oW.remove(dVar);
            }
        }
        com.kwad.sdk.core.d.c.d("KSNativeAdRotateAndShakeManager", "sShakeItems size " + this.oW.size());
    }

    private void a(boolean z, float f, Context context, boolean z2) {
        this.hm = new com.kwad.sdk.core.g.d(z, f);
        this.oW = new CopyOnWriteArrayList<>();
        this.hm.bG(z2);
        this.hm.a(new com.kwad.sdk.core.g.b() { // from class: com.kwad.components.ad.nativead.b.1
            @Override // com.kwad.sdk.core.g.b
            public final void cf() {
            }

            @Override // com.kwad.sdk.core.g.b
            public final void a(double d2) {
                d dVar;
                if (b.this.oW != null) {
                    Iterator it = b.this.oW.iterator();
                    while (it.hasNext() && ((dVar = (d) it.next()) == null || dVar.pe == null || !dVar.pe.b(d2))) {
                    }
                    by.a(new bi() { // from class: com.kwad.components.ad.nativead.b.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            com.kwad.sdk.core.d.c.d("KSNativeAdRotateAndShakeManager", "onShakeEvent openGate2");
                            if (b.this.hm != null) {
                                b.this.hm.NS();
                            }
                        }
                    }, null, 500L);
                }
            }
        });
        this.hm.m(f);
        this.hm.ca(context);
    }

    public final void a(AdMatrixInfo.RotateInfo rotateInfo, Context context, c cVar) {
        com.kwad.sdk.core.g.c cVar2 = this.hn;
        if (cVar2 == null) {
            a(rotateInfo, context);
        } else {
            cVar2.a(rotateInfo);
        }
        this.oX.add(new C0385b(cVar, context));
    }

    public final void a(c cVar) {
        for (C0385b c0385b : this.oX) {
            if (c0385b != null && c0385b.pd == cVar) {
                this.oX.remove(c0385b);
            }
        }
        com.kwad.sdk.core.d.c.d("KSNativeAdRotateAndShakeManager", "sRotateItems size " + this.oX.size());
    }

    private void a(AdMatrixInfo.RotateInfo rotateInfo, Context context) {
        com.kwad.sdk.core.g.c cVar = new com.kwad.sdk.core.g.c(rotateInfo);
        this.hn = cVar;
        cVar.a(new com.kwad.sdk.core.g.a() { // from class: com.kwad.components.ad.nativead.b.2
            @Override // com.kwad.sdk.core.g.a
            public final void cg() {
            }

            @Override // com.kwad.sdk.core.g.a
            public final void r(String str) {
                if (b.this.oX != null) {
                    for (C0385b c0385b : b.this.oX) {
                        if (c0385b != null && c0385b.pd != null && c0385b.pd.s(str)) {
                            return;
                        }
                    }
                }
            }
        });
        this.hn.ca(context);
    }

    public final void N(Context context) {
        try {
            com.kwad.sdk.core.g.c cVar = this.hn;
            if (cVar != null) {
                cVar.ca(context);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void D(Context context) {
        try {
            com.kwad.sdk.core.g.c cVar = this.hn;
            if (cVar != null) {
                cVar.cb(context);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static synchronized boolean ca() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (!(jElapsedRealtime - hr > 500)) {
            return false;
        }
        hr = jElapsedRealtime;
        return true;
    }
}
