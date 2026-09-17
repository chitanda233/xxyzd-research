package com.kwad.components.core.webview.jshandler.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.core.webview.jshandler.e {

    /* JADX INFO: renamed from: com.kwad.components.core.webview.jshandler.a.a$a, reason: collision with other inner class name */
    public static class C0465a extends com.kwad.sdk.core.response.a.a {
        public String arZ;
    }

    @Override // com.kwad.components.core.webview.jshandler.e, com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "checkAppInstalled";
    }

    @Override // com.kwad.components.core.webview.jshandler.e
    public final String bA(String str) {
        try {
            C0465a c0465a = new C0465a();
            c0465a.parseJson(new JSONObject(str));
            return c0465a.arZ;
        } catch (Throwable unused) {
            return null;
        }
    }
}
