package com.kwad.sdk.core.network.b;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public static b MN() {
        h hVar = (h) ServiceProvider.get(h.class);
        if (hVar != null && hVar.Gb()) {
            return new d();
        }
        return new a();
    }
}
