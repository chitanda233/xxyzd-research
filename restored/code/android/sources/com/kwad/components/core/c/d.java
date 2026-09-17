package com.kwad.components.core.c;

import android.util.SparseArray;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private static volatile d Pf = null;
    private static boolean Pg = true;
    private final SparseArray<c> Pe;

    static /* synthetic */ boolean a(d dVar) {
        return oK();
    }

    public static d oJ() {
        if (Pf == null) {
            synchronized (d.class) {
                if (Pf == null) {
                    Pf = new d();
                }
            }
        }
        return Pf;
    }

    private d() {
        SparseArray<c> sparseArray = new SparseArray<>();
        this.Pe = sparseArray;
        sparseArray.append(0, new o());
        sparseArray.append(1, new n());
        sparseArray.append(2, new m());
    }

    public final void d(final com.kwad.components.core.request.model.a aVar) {
        GlobalThreadPools.On().submit(new bi() { // from class: com.kwad.components.core.c.d.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                final e eVarX = e.x(aVar.getPosId());
                by.runOnUiThread(new bi() { // from class: com.kwad.components.core.c.d.1.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        b.b(eVarX);
                    }
                });
                c cVar = (d.a(d.this) || !(eVarX.isDefault() || eVarX.isEnable())) ? (c) d.this.Pe.get(0) : (c) d.this.Pe.get(eVarX.oN());
                if (cVar == null) {
                    cVar = (c) d.this.Pe.get(1);
                }
                com.kwad.components.core.request.j jVarWn = aVar.wn();
                if (jVarWn != null) {
                    cVar.getName();
                    jVarWn.ak();
                }
                d dVar = d.this;
                d.a(aVar, cVar);
                com.kwad.sdk.commercial.convert.e.c(aVar.abv.adScene, aVar.wo());
                cVar.d(aVar);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(com.kwad.components.core.request.model.a aVar, c cVar) {
        String name = cVar.getName();
        name.hashCode();
        if (name.equals("StrategyNetworkFirst")) {
            aVar.bg("network_first");
        } else if (name.equals("StrategyLocalCacheFirst")) {
            aVar.bg("cache_first");
        } else {
            aVar.bg("network_only");
        }
    }

    private static boolean oK() {
        if (!Pg) {
            return false;
        }
        try {
            if (com.kwad.sdk.components.g.dN("KEY_ENABLE_FORCE_ENABLE_AD_CACHE")) {
                return false;
            }
            Class.forName("com.kwad.devTools.PosConfigFetcher");
            Pg = true;
        } catch (ClassNotFoundException unused) {
            Pg = false;
        }
        return Pg;
    }
}
