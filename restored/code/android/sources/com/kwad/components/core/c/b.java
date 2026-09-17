package com.kwad.components.core.c;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ae;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static void b(e eVar) {
        ag("使用缓存策略: " + eVar.oN());
    }

    private static void ag(String str) {
        if (oI() && com.kwad.sdk.o.GE().FJ()) {
            ae.V(ServiceProvider.getContext(), str);
        }
    }

    public static boolean oI() {
        return false;
    }
}
