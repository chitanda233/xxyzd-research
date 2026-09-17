package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {
    private b apr;

    /* JADX INFO: renamed from: com.kwad.components.core.webview.jshandler.a$a, reason: collision with other inner class name */
    public static class C0464a extends com.kwad.sdk.core.response.a.a {
        public String Pu;
        public String apu;
        public String apv;
    }

    public interface b {
        void c(C0464a c0464a);
    }

    public static class c extends com.kwad.sdk.core.response.a.a {
        public int apw;
        public long apx;
        public boolean apy;
        public int errorCode;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "adOutCallback";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public a(b bVar) {
        this.apr = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            C0464a c0464a = new C0464a();
            c0464a.parseJson(new JSONObject(str));
            b(c0464a);
        } catch (Throwable unused) {
        }
    }

    private void b(final C0464a c0464a) {
        by.postOnUiThread(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (a.this.apr != null) {
                    a.this.apr.c(c0464a);
                }
            }
        });
    }
}
