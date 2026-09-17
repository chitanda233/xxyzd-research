package com.kwad.components.core.innerEc.a;

import com.kwad.components.core.webview.jshandler.az;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.sdk.mvp.a {
    public com.kwad.components.core.widget.a.c PR;
    public b SZ;
    public e Ta;
    public az ff;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
    }

    public final void ro() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yJ();
            this.ff.yK();
        }
    }

    public final void rp() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yL();
            this.ff.yM();
        }
    }
}
