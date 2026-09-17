package com.kwad.sdk;

import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.export.proxy.AdHttpProxy;
import java.util.Random;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private static AdHttpProxy aGa;

    public static AdHttpProxy ES() {
        AdHttpProxy adHttpProxy = aGa;
        if (adHttpProxy != null) {
            return adHttpProxy;
        }
        if (com.kwad.framework.a.a.oV.booleanValue()) {
            return ET();
        }
        try {
            if (com.kwad.sdk.core.network.a.c.Mw() != null) {
                aGa = new com.kwad.sdk.core.network.c.b();
            } else {
                aGa = new com.kwad.sdk.core.network.c.a();
            }
        } catch (Throwable unused) {
            aGa = new com.kwad.sdk.core.network.c.a();
        }
        return aGa;
    }

    private static AdHttpProxy ET() {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return new Random().nextInt(5) != 0 ? new com.kwad.sdk.core.network.c.b() : new com.kwad.sdk.core.network.c.a();
    }
}
