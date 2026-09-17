package com.cmic.gen.sdk.c.a;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import com.cmic.gen.sdk.f.o;
import com.cmic.gen.sdk.f.s;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: compiled from: WifiChangeInterceptor.java */
/* JADX INFO: loaded from: classes2.dex */
public class d implements b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private b f2071a;

    @Override // com.cmic.gen.sdk.c.a.b
    public void a(final com.cmic.gen.sdk.c.c.c cVar, final com.cmic.gen.sdk.c.d.c cVar2, final com.cmic.gen.sdk.a aVar) {
        if (!cVar.b()) {
            b(cVar, cVar2, aVar);
        } else {
            final s sVarA = s.a((Context) null);
            sVarA.a(new s.a() { // from class: com.cmic.gen.sdk.c.a.d.1
                private final AtomicBoolean f = new AtomicBoolean(false);

                @Override // com.cmic.gen.sdk.f.s.a
                public void a(final Network network, final ConnectivityManager.NetworkCallback networkCallback) {
                    if (this.f.getAndSet(true)) {
                        return;
                    }
                    o.a(new o.a(null, aVar) { // from class: com.cmic.gen.sdk.c.a.d.1.1
                        @Override // com.cmic.gen.sdk.f.o.a
                        protected void a() {
                            if (network != null) {
                                com.cmic.gen.sdk.f.c.b("WifiChangeInterceptor", "onAvailable");
                                cVar.a(network);
                                d.this.b(cVar, cVar2, aVar);
                            } else {
                                cVar2.a(com.cmic.gen.sdk.c.d.a.a(102508));
                            }
                            sVarA.a(networkCallback);
                        }
                    });
                }
            });
        }
    }

    public void b(com.cmic.gen.sdk.c.c.c cVar, final com.cmic.gen.sdk.c.d.c cVar2, com.cmic.gen.sdk.a aVar) {
        b bVar = this.f2071a;
        if (bVar != null) {
            bVar.a(cVar, new com.cmic.gen.sdk.c.d.c() { // from class: com.cmic.gen.sdk.c.a.d.2
                @Override // com.cmic.gen.sdk.c.d.c
                public void a(com.cmic.gen.sdk.c.d.b bVar2) {
                    cVar2.a(bVar2);
                }

                @Override // com.cmic.gen.sdk.c.d.c
                public void a(com.cmic.gen.sdk.c.d.a aVar2) {
                    cVar2.a(aVar2);
                }
            }, aVar);
        }
    }

    public void a(b bVar) {
        this.f2071a = bVar;
    }
}
