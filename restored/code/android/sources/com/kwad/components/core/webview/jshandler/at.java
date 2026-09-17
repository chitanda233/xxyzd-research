package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class at implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;
    private a arn = new a();

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerAnimationListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void bU(int i) {
        v(1, 2);
    }

    private void v(int i, int i2) {
        if (this.apz != null) {
            this.arn.id = i;
            this.arn.status = 2;
            this.apz.b(this.arn);
        }
    }

    public class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public int id;
        public int status;

        public a() {
        }
    }
}
