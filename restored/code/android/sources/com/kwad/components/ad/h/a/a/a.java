package com.kwad.components.ad.h.a.a;

import com.kwad.sdk.core.webview.c.c;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {
    private c qW;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerPlayStateResetListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, c cVar) {
        this.qW = cVar;
    }

    public final void fY() {
        c cVar = this.qW;
        if (cVar != null) {
            cVar.b(null);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.qW = null;
    }
}
