package com.kwad.components.ad.adbit;

import android.os.SystemClock;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public static void a(boolean z, boolean z2) {
        int i = z2 ? 1 : 2;
        try {
            d dVarR = d.R();
            dVarR.bG = i;
            dVarR.bI = z ? com.alipay.sdk.m.c0.c.c : com.alipay.sdk.m.c0.c.d;
            a(dVarR);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(long j, boolean z, boolean z2) {
        int i = z2 ? 1 : 2;
        try {
            d dVarS = d.S();
            dVarS.bG = i;
            dVarS.bH = SystemClock.elapsedRealtime() - j;
            dVarS.bI = z ? com.alipay.sdk.m.c0.c.c : com.alipay.sdk.m.c0.c.d;
            a(dVarS);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static void a(final d dVar) {
        GlobalThreadPools.Or().execute(new bi() { // from class: com.kwad.components.ad.adbit.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.z(dVar);
            }
        });
    }
}
