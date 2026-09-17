package com.kwad.components.ad.i;

import android.app.Activity;
import com.kwad.components.core.proxy.f;
import com.kwad.components.core.proxy.l;
import com.kwad.components.core.proxy.m;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.WeakHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class b implements com.kwad.components.core.internal.api.b {
    private static volatile b rk;
    private Set<Integer> rl = new HashSet();
    private List<c> rm = new ArrayList();
    private Map<com.kwad.components.core.internal.api.a, Object> rn = new WeakHashMap();
    private Map<f, Object> ro = new WeakHashMap();
    private m rp = new m() { // from class: com.kwad.components.ad.i.b.1
        @Override // com.kwad.components.core.proxy.m, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: a */
        public final void d(f fVar) {
            super.d(fVar);
            b.this.ro.put(fVar, b.rj);
        }

        @Override // com.kwad.components.core.proxy.m, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: b */
        public final void c(f fVar) {
            super.c(fVar);
            b.this.ro.remove(fVar);
            if (b.this.ro.isEmpty()) {
                b.this.gc();
            }
        }
    };
    private static final Object rj = new Object();
    private static final Map<Activity, Object> rq = new WeakHashMap();
    private static a rr = null;

    public interface a {
    }

    public static b gb() {
        if (rk == null) {
            synchronized (b.class) {
                if (rk == null) {
                    rk = new b();
                }
            }
        }
        return rk;
    }

    private b() {
        l.vO().a(this.rp);
        this.rl.add(2);
        this.rl.add(3);
        this.rl.add(13);
        this.rl.add(6);
    }

    public final void a(com.kwad.components.core.internal.api.a aVar) {
        if (aVar != null) {
            aVar.a(this);
        }
    }

    public final void b(com.kwad.components.core.internal.api.a aVar) {
        if (aVar != null) {
            aVar.b(this);
        }
    }

    public final void a(c cVar) {
        if (cVar != null) {
            this.rm.remove(cVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void gc() {
        boolean zGd = gd();
        com.kwad.sdk.core.d.c.d("KsAdGlobalWatcher", "checkCurrentPage noSDKPage: " + zGd);
        if (zGd) {
            Iterator<c> it = this.rm.iterator();
            while (it.hasNext()) {
                it.next().gh();
            }
        }
    }

    @Override // com.kwad.components.core.internal.api.b
    public final void c(com.kwad.components.core.internal.api.a aVar) {
        e(aVar);
        if (rr != null) {
            if (!this.ro.isEmpty()) {
                Iterator<f> it = this.ro.keySet().iterator();
                while (it.hasNext()) {
                    it.next();
                }
            } else {
                Map<Activity, Object> map = rq;
                if (map.isEmpty()) {
                    return;
                }
                Iterator<Activity> it2 = map.keySet().iterator();
                while (it2.hasNext()) {
                    it2.next();
                }
            }
        }
    }

    @Override // com.kwad.components.core.internal.api.b
    public final void d(com.kwad.components.core.internal.api.a aVar) {
        f(aVar);
        b(aVar);
    }

    private void e(com.kwad.components.core.internal.api.a aVar) {
        this.rn.put(aVar, rj);
        if (g(aVar)) {
            c cVar = new c(aVar);
            cVar.gf();
            this.rm.add(cVar);
        }
    }

    private void f(com.kwad.components.core.internal.api.a aVar) {
        this.rn.remove(aVar);
        Iterator<c> it = this.rm.iterator();
        while (it.hasNext()) {
            it.next().d(aVar);
        }
        if (J(aVar.getAdTemplate())) {
            gc();
        }
    }

    public final synchronized boolean gd() {
        Iterator<com.kwad.components.core.internal.api.a> it = this.rn.keySet().iterator();
        while (it.hasNext()) {
            if (J(it.next().getAdTemplate())) {
                return false;
            }
        }
        return this.ro.isEmpty();
    }

    private boolean J(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return false;
        }
        return this.rl.contains(Integer.valueOf(adTemplate.adStyle));
    }

    private static boolean g(com.kwad.components.core.internal.api.a aVar) {
        if (aVar.supportPushAd()) {
            return com.kwad.sdk.core.response.helper.a.dh(com.kwad.sdk.core.response.helper.e.eM(aVar.getAdTemplate()));
        }
        return false;
    }
}
