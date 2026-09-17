package com.kwad.components.offline.b;

import android.content.Context;
import com.kwad.components.offline.api.adLive.IAdLiveOfflineCompo;
import com.kwad.components.offline.api.core.adlive.IAdLiveEndRequest;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;

/* JADX INFO: loaded from: classes3.dex */
public class a implements com.kwad.components.core.offline.a.c.a {
    private final IAdLiveOfflineCompo axp;

    @Override // com.kwad.sdk.components.b
    public final void init(Context context) {
    }

    public a(IAdLiveOfflineCompo iAdLiveOfflineCompo) {
        this.axp = iAdLiveOfflineCompo;
    }

    @Override // com.kwad.components.core.offline.a.c.a
    public final boolean tG() {
        return this.axp.getState() == IAdLiveOfflineCompo.AdLiveState.READY;
    }

    @Override // com.kwad.components.core.offline.a.c.a
    public final IAdLiveOfflineView getView(Context context, int i) {
        return this.axp.getView(context, i);
    }

    @Override // com.kwad.components.core.offline.a.c.a
    public final IAdLiveEndRequest getAdLiveEndRequest(String str) {
        return this.axp.getAdLiveEndRequest(str);
    }

    @Override // com.kwad.components.core.offline.a.c.a
    public final IAdLivePlayModule getAdLivePlayModule(IAdLiveOfflineView iAdLiveOfflineView, String str, String str2, String str3, long j, int i) {
        return this.axp.getAdLivePlayModule(iAdLiveOfflineView, str, str2, str3, j, i);
    }

    @Override // com.kwad.sdk.components.b
    public final Class<a> getComponentsType() {
        return a.class;
    }

    @Override // com.kwad.sdk.components.b
    public final int priority() {
        return this.axp.priority();
    }
}
