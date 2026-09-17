package com.kwad.components.offline.a;

import android.content.Context;
import com.kwad.components.offline.api.adInnerEc.IAdInnerEcOfflineCompo;
import com.kwad.components.offline.api.core.adInnerEc.IAdInnerEcExternalModule;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public class a implements com.kwad.components.core.offline.a.a.a {
    private final IAdInnerEcOfflineCompo awJ;

    @Override // com.kwad.sdk.components.b
    public final void init(Context context) {
    }

    public a(IAdInnerEcOfflineCompo iAdInnerEcOfflineCompo) {
        this.awJ = iAdInnerEcOfflineCompo;
    }

    @Override // com.kwad.sdk.components.b
    public final Class getComponentsType() {
        return a.class;
    }

    @Override // com.kwad.sdk.components.b
    public final int priority() {
        return this.awJ.priority();
    }

    @Override // com.kwad.components.core.offline.a.a.a
    public final boolean tD() {
        return this.awJ.getState() == IAdInnerEcOfflineCompo.AdInnerEcState.READY;
    }

    @Override // com.kwad.components.core.offline.a.a.a
    public final IAdInnerEcExternalModule tE() {
        if (!tD()) {
            return null;
        }
        try {
            return this.awJ.getAdInnerEcExternalModule();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
            return null;
        }
    }
}
