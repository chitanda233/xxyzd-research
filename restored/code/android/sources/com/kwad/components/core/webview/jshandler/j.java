package com.kwad.components.core.webview.jshandler;

import com.kwad.components.core.playable.PlayableSource;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class j implements com.kwad.sdk.core.webview.c.a {
    private p apD;
    private com.kwad.sdk.core.webview.c.c apz;

    public static class b extends com.kwad.sdk.core.response.a.a {
        public int abd;
        public int apF;
        public int apG;
        public String apH;
        public int convertCount;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getNativeData";
    }

    public j(p pVar) {
        this.apD = pVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
        try {
            a aVar = new a();
            aVar.parseJson(new JSONObject(str));
            String target = aVar.getTarget();
            p pVar = this.apD;
            if (pVar != null) {
                pVar.a(this, target);
            }
        } catch (Exception unused) {
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void f(PlayableSource playableSource) {
        if (playableSource == null) {
            return;
        }
        b bVar = new b();
        bVar.apF = playableSource.getCode();
        a(bVar);
    }

    public final void bS(int i) {
        b bVar = new b();
        bVar.abd = i;
        a(bVar);
    }

    public final void bk(boolean z) {
        b bVar = new b();
        bVar.apG = z ? 1 : 0;
        a(bVar);
    }

    public final void S(long j) {
        b bVar = new b();
        bVar.apH = Long.toString(j);
        a(bVar);
    }

    public final void bT(int i) {
        b bVar = new b();
        bVar.convertCount = i;
        a(bVar);
    }

    public final void a(com.kwad.sdk.core.response.a.a aVar) {
        com.kwad.sdk.core.webview.c.c cVar = this.apz;
        if (cVar == null || aVar == null) {
            return;
        }
        cVar.b(aVar);
    }

    public static class a extends com.kwad.sdk.core.response.a.a {
        public String apE;

        public final String getTarget() {
            return this.apE;
        }
    }
}
