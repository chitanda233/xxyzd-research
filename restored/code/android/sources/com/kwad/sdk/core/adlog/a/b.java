package com.kwad.sdk.core.adlog.a;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.ar;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final c aLR;
    private final List<com.kwad.sdk.core.adlog.a.a> aLS;

    /* synthetic */ b(byte b) {
        this();
    }

    static final class a {
        private static final b aLU = new b(0);
    }

    private b() {
        this.aLS = new CopyOnWriteArrayList();
        this.aLR = (c) ac.b(((h) ServiceProvider.get(h.class)).Gt(), new com.kwad.sdk.core.c<c>() { // from class: com.kwad.sdk.core.adlog.a.b.1
            @Override // com.kwad.sdk.core.c
            public final /* synthetic */ com.kwad.sdk.core.b IM() {
                return Jn();
            }

            private static c Jn() {
                return new c();
            }
        });
    }

    public static b Jh() {
        return a.aLU;
    }

    public final void a(com.kwad.sdk.core.adlog.a.a aVar, String str, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.a aVar2, int i, String str2) {
        try {
            if (Jl()) {
                return;
            }
            if (!Jm() || d(aVar2)) {
                if (aVar == null) {
                    if (aVar2 != null) {
                        com.kwad.sdk.core.adlog.a.C0502a c0502a = aVar2.Js() == null ? new com.kwad.sdk.core.adlog.a.C0502a() : aVar2.Js();
                        c0502a.aLh = 1;
                        aVar2.a(c0502a);
                        ac.putValue(jSONObject, "clientExtData", aVar2.QR.toJson().toString());
                    }
                    aVar = com.kwad.sdk.core.adlog.a.a.Jg().dU(str).j(jSONObject).c(aVar2).av(System.currentTimeMillis());
                }
                aVar.dz(i).dV(str2);
                com.kwad.sdk.core.adlog.b.a.a(aVar, this.aLR, this.aLS.size());
                if (aVar.retryCount >= this.aLR.aLW) {
                    com.kwad.sdk.core.adlog.b.a.c(aVar, this.aLR, this.aLS.size());
                    com.kwad.sdk.core.d.c.i("AdLogCacheManager", "addCache fail limit retryCount: " + aVar.retryCount + ", log: " + aVar);
                    return;
                }
                if (this.aLS.size() >= this.aLR.aLY) {
                    com.kwad.sdk.core.adlog.a.a aVarJj = Jj();
                    com.kwad.sdk.core.d.c.i("AdLogCacheManager", "addCache limit size: " + this.aLS.size() + ", remove log：" + aVarJj);
                    com.kwad.sdk.core.adlog.b.a.e(aVarJj, this.aLR, this.aLS.size());
                }
                a(aVar);
                com.kwad.sdk.core.d.c.i("AdLogCacheManager", "addCache success size: " + this.aLS.size() + ", log: " + aVar);
                com.kwad.sdk.core.adlog.b.a.b(aVar, this.aLR, this.aLS.size());
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void Ji() {
        try {
            if (Jl() || ar.R(this.aLS)) {
                return;
            }
            by.runOnUiThread(new bi() { // from class: com.kwad.sdk.core.adlog.a.b.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    com.kwad.sdk.core.adlog.b.Je();
                }
            });
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private synchronized void a(com.kwad.sdk.core.adlog.a.a aVar) {
        this.aLS.add(aVar);
    }

    private synchronized com.kwad.sdk.core.adlog.a.a Jj() {
        if (ar.R(this.aLS)) {
            return null;
        }
        return this.aLS.remove(0);
    }

    public final com.kwad.sdk.core.adlog.a.a Jk() {
        com.kwad.sdk.core.adlog.a.a aVarJj = Jj();
        if (aVarJj == null) {
            return null;
        }
        com.kwad.sdk.core.adlog.b.a.d(aVarJj, this.aLR, this.aLS.size());
        long jCurrentTimeMillis = System.currentTimeMillis() - aVarJj.aLO;
        if (jCurrentTimeMillis > this.aLR.aLX * 1000) {
            com.kwad.sdk.core.adlog.b.a.b(aVarJj, this.aLR, this.aLS.size(), jCurrentTimeMillis);
            com.kwad.sdk.core.d.c.i("AdLogCacheManager", "getCache fail expired cacheTime: " + jCurrentTimeMillis + ", adLogCache：" + aVarJj);
            return null;
        }
        aVarJj.retryCount++;
        com.kwad.sdk.core.adlog.b.a.a(aVarJj, this.aLR, this.aLS.size(), jCurrentTimeMillis);
        com.kwad.sdk.core.d.c.i("AdLogCacheManager", "getCache success：" + aVarJj);
        return aVarJj;
    }

    private boolean Jl() {
        c cVar = this.aLR;
        return cVar == null || !cVar.aLV;
    }

    private boolean Jm() {
        c cVar = this.aLR;
        return cVar != null && cVar.aLZ;
    }

    private static boolean d(com.kwad.sdk.core.adlog.c.a aVar) {
        if (aVar == null) {
            return false;
        }
        return aVar.aKK == 1 || aVar.aKK == 2;
    }
}
