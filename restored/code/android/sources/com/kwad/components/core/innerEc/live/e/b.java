package com.kwad.components.core.innerEc.live.e;

import com.kwad.components.offline.api.core.adInnerEc.longconnection.ILiveLongConnection;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.LiveLongConnectionServerException;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.LongConnectStatusListener;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final ILiveLongConnection UQ;
    private final c Xx;
    private boolean Xy = true;
    private final LongConnectStatusListener Xz;

    static /* synthetic */ boolean a(b bVar, boolean z) {
        bVar.Xy = false;
        return false;
    }

    public b(ILiveLongConnection iLiveLongConnection, c cVar) {
        d dVar = new d() { // from class: com.kwad.components.core.innerEc.live.e.b.1
            @Override // com.kwad.components.core.innerEc.live.e.d, com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.LongConnectStatusListener
            public final void onServerException(LiveLongConnectionServerException liveLongConnectionServerException) {
                com.kwad.sdk.core.d.c.e("LiveLongConnectHelper", "onServerException errorCode: " + liveLongConnectionServerException.errorCode + " ,subCode:" + liveLongConnectionServerException.subCode + " ,errorMessage:" + liveLongConnectionServerException.errorMessage);
                if (b.this.Xx.sb()) {
                    if (a.aQ(liveLongConnectionServerException.errorCode) || a.aR(liveLongConnectionServerException.errorCode)) {
                        b.a(b.this, false);
                    } else {
                        com.kwad.sdk.core.d.c.e("LiveLongConnectHelper", "onServerException", liveLongConnectionServerException);
                    }
                    b.this.Xx.a(liveLongConnectionServerException);
                }
            }
        };
        this.Xz = dVar;
        this.UQ = iLiveLongConnection;
        this.Xx = cVar;
        iLiveLongConnection.registerLongConnectStatusListener(dVar);
    }

    public final void destroy() {
        this.UQ.unregisterLongConnectStatusListener(this.Xz);
        this.Xy = true;
    }
}
