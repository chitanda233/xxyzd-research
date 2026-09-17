package com.kwad.components.core.innerEc;

import com.kwad.sdk.core.request.model.g;
import com.kwad.sdk.i;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.core.network.d {
    public b(String str, String str2) {
        g gVarNG = g.NG();
        gVarNG.fh(str);
        gVarNG.fj(str2);
        putBody("userInfo", gVarNG);
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return i.Fm();
    }
}
