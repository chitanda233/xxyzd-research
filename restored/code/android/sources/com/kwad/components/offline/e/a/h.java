package com.kwad.components.offline.e.a;

import com.kwad.components.offline.api.tk.IOfflineTKRenderListener;
import com.kwad.sdk.components.s;

/* JADX INFO: loaded from: classes3.dex */
public final class h implements IOfflineTKRenderListener {
    private final s ayy;

    public h(s sVar) {
        this.ayy = sVar;
    }

    @Override // com.kwad.components.offline.api.tk.IOfflineTKRenderListener
    public final void onSuccess() {
        s sVar = this.ayy;
        if (sVar != null) {
            sVar.onSuccess();
        }
    }

    @Override // com.kwad.components.offline.api.tk.IOfflineTKRenderListener
    public final void onFailed(Throwable th) {
        s sVar = this.ayy;
        if (sVar != null) {
            sVar.onFailed(th);
        }
    }
}
