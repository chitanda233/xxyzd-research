package com.bytedance.ads.convert.flat.k;

import java.util.concurrent.Callable;

/* JADX INFO: loaded from: classes2.dex */
public class a implements Callable<d> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ b f1724a;

    public a(b bVar) {
        this.f1724a = bVar;
    }

    @Override // java.util.concurrent.Callable
    public d call() {
        b bVar = this.f1724a;
        bVar.getClass();
        try {
            d dVarA = bVar.b.a();
            if (dVarA != null) {
                bVar.g = dVarA;
            }
            d dVarA2 = bVar.a(bVar.d, dVarA);
            if (dVarA2 != null) {
                e eVar = bVar.b;
                eVar.getClass();
                eVar.f1729a.edit().putString("oaid", dVarA2.a().toString()).apply();
            }
            if (dVarA2 == null) {
                return dVarA2;
            }
            bVar.g = dVarA2;
            return dVarA2;
        } catch (Exception e) {
            d dVar = bVar.g;
            if (dVar != null) {
                dVar.h = e.getMessage();
            }
            String str = "resolveOaid# error: " + e.getMessage();
            return null;
        }
    }
}
