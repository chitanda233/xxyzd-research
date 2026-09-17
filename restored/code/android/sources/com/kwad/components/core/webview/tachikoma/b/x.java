package com.kwad.components.core.webview.tachikoma.b;

import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class x implements com.kwad.sdk.core.webview.c.a {
    private OfflineOnAudioConflictListener Cz = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.core.webview.tachikoma.b.x.1
        @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
        public final void onAudioBeOccupied() {
            x.this.bZ(2);
        }

        @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
        public final void onAudioBeReleased() {
            x.this.bZ(3);
        }
    };
    private com.kwad.sdk.core.webview.c.c aqg;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public boolean aue;
        public int auf;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerAudioFocusListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.aqg = cVar;
        com.kwad.components.core.t.a.aN(ServiceProvider.getContext()).a(this.Cz);
        bZ(1);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bZ(int i) {
        a aVar = new a();
        aVar.aue = com.kwad.components.core.t.a.aN(ServiceProvider.getContext()).wP();
        aVar.auf = i;
        com.kwad.sdk.core.webview.c.c cVar = this.aqg;
        if (cVar != null) {
            cVar.b(aVar);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        com.kwad.components.core.t.a.aN(ServiceProvider.getContext()).b(this.Cz);
        this.aqg = null;
    }
}
