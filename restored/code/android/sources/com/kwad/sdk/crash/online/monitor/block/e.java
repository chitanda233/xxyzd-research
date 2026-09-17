package com.kwad.sdk.crash.online.monitor.block;

import com.kwad.sdk.service.ServiceProvider;
import java.util.Random;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static com.kwad.sdk.crash.online.monitor.a.a bfi;

    public static void d(com.kwad.sdk.crash.online.monitor.a.a aVar) {
        if (aVar == null) {
            return;
        }
        try {
            if (aVar.QO()) {
                com.kwad.sdk.core.d.c.d("perfMonitor.BlockManager", "allFuncDisable");
                return;
            }
            if (!a.QF()) {
                com.kwad.sdk.core.d.c.d("perfMonitor.BlockManager", "!hasBlockMonitor");
                return;
            }
            a.a(aVar);
            bfi = aVar;
            boolean zBZ = a.bZ(true);
            com.kwad.sdk.core.d.c.d("perfMonitor.BlockManager", "hasTenBlockHook:" + zBZ);
            if (aVar.aJX < new Random().nextFloat()) {
                return;
            }
            b.a(aVar);
            if (aVar.QM() && zBZ) {
                c.b(aVar);
            }
            if (aVar.QN()) {
                com.kwad.sdk.core.d.c.d("perfMonitor.BlockManager", "hasOtherBlockMonitor:" + a.ca(false));
            }
        } catch (Throwable th) {
            try {
                ServiceProvider.reportSdkCaughtException(th);
            } catch (Exception unused) {
            }
        }
    }

    public static com.kwad.sdk.crash.online.monitor.a.a QH() {
        return bfi;
    }

    public static boolean QI() {
        com.kwad.sdk.crash.online.monitor.a.a aVar = bfi;
        return aVar != null && aVar.QL();
    }
}
