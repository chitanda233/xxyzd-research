package com.kwad.components.core.offline.b.a;

import com.kwad.components.offline.api.core.api.IFlowUuid;

/* JADX INFO: loaded from: classes3.dex */
public final class f implements IFlowUuid {
    @Override // com.kwad.components.offline.api.core.api.IFlowUuid
    public final String encryptLongToBase64(long j) {
        try {
            return com.kwad.components.core.e.b.a.y(j);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    @Override // com.kwad.components.offline.api.core.api.IFlowUuid
    public final long decryptLongFromBase64(String str) {
        try {
            return com.kwad.components.core.e.b.a.ak(str);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return 0L;
        }
    }
}
