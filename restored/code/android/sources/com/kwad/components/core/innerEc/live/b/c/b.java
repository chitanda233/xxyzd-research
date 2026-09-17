package com.kwad.components.core.innerEc.live.b.c;

import com.kwad.components.offline.api.core.adInnerEc.longconnection.ILiveLongConnection;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.ServerException;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.innerEc.live.b.a.a {
    private ILiveLongConnection UQ;
    private com.kwad.components.core.innerEc.live.config.b Vd;
    private com.kwad.components.core.innerEc.live.e.b Vf;
    private boolean Ve = false;
    private final com.kwad.components.core.innerEc.live.config.a Vg = new com.kwad.components.core.innerEc.live.config.a() { // from class: com.kwad.components.core.innerEc.live.b.c.b.2
        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void a(com.kwad.components.core.innerEc.live.config.net.g gVar) {
        }

        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void b(com.kwad.components.core.innerEc.live.config.net.g gVar) {
            b.this.sa();
        }
    };

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.UQ = this.Uj.UQ;
        this.Vd = this.Uj.UN;
        rX();
        this.Vd.a(this.Vg);
        rY();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        rZ();
        this.Vd.b(this.Vg);
        aI("onUnbind");
    }

    private void rX() {
        this.Vf = new com.kwad.components.core.innerEc.live.e.b(this.UQ, new com.kwad.components.core.innerEc.live.e.c() { // from class: com.kwad.components.core.innerEc.live.b.c.b.1
            @Override // com.kwad.components.core.innerEc.live.e.c
            public final void a(ServerException serverException) {
                b.this.Uj.US.h(serverException);
            }

            @Override // com.kwad.components.core.innerEc.live.e.c
            public final boolean sb() {
                return b.this.Uj.UK.isAdded();
            }
        });
    }

    private void rY() {
        ILiveLongConnection iLiveLongConnection = this.UQ;
        if (iLiveLongConnection != null) {
            iLiveLongConnection.attached();
        }
    }

    private void rZ() {
        ILiveLongConnection iLiveLongConnection = this.UQ;
        if (iLiveLongConnection != null) {
            iLiveLongConnection.detached();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sa() {
        ILiveLongConnection iLiveLongConnection = this.UQ;
        if (iLiveLongConnection != null) {
            iLiveLongConnection.resume();
            this.Ve = false;
        }
    }

    private void aI(String str) {
        if (this.Ve) {
            return;
        }
        this.Ve = true;
        com.kwad.sdk.core.d.c.i("LiveAudienceLongConnectionPresenter", "destroyConnection , reason" + str);
        ILiveLongConnection iLiveLongConnection = this.UQ;
        if (iLiveLongConnection != null) {
            iLiveLongConnection.release();
        }
        com.kwad.components.core.innerEc.live.e.b bVar = this.Vf;
        if (bVar != null) {
            bVar.destroy();
        }
    }
}
