package com.kwad.components.offline.e.a;

import com.kwad.components.offline.api.tk.IOfflineTKCallHandler;
import com.kwad.sdk.components.q;

/* JADX INFO: loaded from: classes3.dex */
public final class g implements IOfflineTKCallHandler {
    private final q ayx;

    public g(q qVar) {
        this.ayx = qVar;
    }

    @Override // com.kwad.components.offline.api.tk.IOfflineTKCallHandler
    public final void callJS(String str) {
        q qVar = this.ayx;
        if (qVar != null) {
            qVar.callJS(str);
        }
    }
}
