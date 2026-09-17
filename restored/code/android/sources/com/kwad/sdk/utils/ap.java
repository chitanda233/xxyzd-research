package com.kwad.sdk.utils;

import java.util.Iterator;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class ap {
    private Map<String, com.kwad.sdk.core.webview.a> bpF;
    private Map<String, com.kwad.sdk.core.webview.c.c> bpG;

    public final void a(String str, com.kwad.sdk.core.webview.a aVar) {
        this.bpF.put(str, aVar);
    }

    public final com.kwad.sdk.core.webview.a hP(String str) {
        return this.bpF.get(str);
    }

    public final void b(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.bpG.put(str, cVar);
    }

    public final com.kwad.sdk.core.webview.c.c hQ(String str) {
        return this.bpG.get(str);
    }

    public final void release() {
        Iterator<com.kwad.sdk.core.webview.a> it = this.bpF.values().iterator();
        while (it.hasNext()) {
            it.next().qB();
        }
        this.bpF.clear();
        this.bpG.clear();
    }
}
