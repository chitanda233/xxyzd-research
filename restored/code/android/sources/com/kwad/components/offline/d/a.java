package com.kwad.components.offline.d;

import android.content.Context;
import com.kwad.components.offline.api.obiwan.IObiwanLogcat;
import com.kwad.components.offline.api.obiwan.IObiwanOfflineCompo;

/* JADX INFO: loaded from: classes3.dex */
public class a implements com.kwad.components.core.offline.a.e.a {
    private final IObiwanOfflineCompo axO;

    @Override // com.kwad.sdk.components.b
    public final void init(Context context) {
    }

    public a(IObiwanOfflineCompo iObiwanOfflineCompo) {
        this.axO = iObiwanOfflineCompo;
    }

    @Override // com.kwad.sdk.components.b
    public final Class getComponentsType() {
        return a.class;
    }

    @Override // com.kwad.sdk.components.b
    public final int priority() {
        return this.axO.priority();
    }

    public final void updateConfigs() {
        this.axO.updateConfigs();
    }

    public final IObiwanLogcat getLog() {
        return this.axO.getLog();
    }
}
