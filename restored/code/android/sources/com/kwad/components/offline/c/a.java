package com.kwad.components.offline.c;

import android.content.Context;
import com.kwad.components.offline.api.adWaynePlayer.IAdWaynePlayerOfflineCompo;
import com.kwad.components.offline.api.core.adWaynePlayer.IAdWaynePlayerPlayModule;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public class a implements com.kwad.components.core.offline.a.b.a {
    private final IAdWaynePlayerOfflineCompo axx;

    @Override // com.kwad.sdk.components.b
    public final void init(Context context) {
    }

    public a(IAdWaynePlayerOfflineCompo iAdWaynePlayerOfflineCompo) {
        this.axx = iAdWaynePlayerOfflineCompo;
    }

    @Override // com.kwad.sdk.components.b
    public final Class<a> getComponentsType() {
        return a.class;
    }

    @Override // com.kwad.sdk.components.b
    public final int priority() {
        return this.axx.priority();
    }

    @Override // com.kwad.components.core.offline.a.b.a
    public final boolean tF() {
        return this.axx.getState() == IAdWaynePlayerOfflineCompo.AdWaynePlayerState.READY;
    }

    @Override // com.kwad.components.core.offline.a.b.a
    public final IAdWaynePlayerPlayModule getAdWaynePlayerPlayModule(String str, boolean z) {
        if (!tF()) {
            return null;
        }
        try {
            return this.axx.getAdWaynePlayerPlayModule(str, z);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
            return null;
        }
    }
}
