package com.kwad.components.core.innerEc.live.a;

import com.kwad.sdk.utils.ac;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {

    /* JADX INFO: renamed from: com.kwad.components.core.innerEc.live.a.a$a, reason: collision with other inner class name */
    public static final class C0435a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public String TJ;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getMerchantCookie";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            Map<String, String> mapRi = com.kwad.components.core.innerEc.f.ri();
            C0435a c0435a = new C0435a();
            if (mapRi == null) {
                c0435a.TJ = "";
            } else {
                c0435a.TJ = ac.parseMap2JSON(mapRi).toString();
            }
            cVar.b(c0435a);
        } catch (Exception e) {
            cVar.onError(-1, e.getMessage());
        }
    }
}
