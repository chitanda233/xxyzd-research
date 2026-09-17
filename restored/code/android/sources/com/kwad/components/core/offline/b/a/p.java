package com.kwad.components.core.offline.b.a;

import com.kwad.components.offline.api.core.network.IIdc;

/* JADX INFO: loaded from: classes3.dex */
public final class p implements IIdc {
    @Override // com.kwad.components.offline.api.core.network.IIdc
    public final String hostForAPI(String str) {
        if (str.equals("api")) {
            return com.kwad.sdk.i.EU();
        }
        return "https://" + com.kwad.sdk.core.network.idc.a.My().Y(str, null);
    }
}
