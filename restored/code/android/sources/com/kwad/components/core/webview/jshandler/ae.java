package com.kwad.components.core.webview.jshandler;

import com.bykv.vk.component.ttvideo.player.MediaFormat;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ae implements com.kwad.sdk.core.webview.c.a {
    protected final com.kwad.sdk.core.webview.b apL;
    protected c aqp;
    private d qx;

    public static class b extends a {
        public d aqr;
    }

    public interface c {
        void c(a aVar);
    }

    public interface d {
        void u(int i, int i2);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getContainerLimit";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public ae(com.kwad.sdk.core.webview.b bVar) {
        this.apL = bVar;
    }

    public final void a(c cVar) {
        this.aqp = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, final com.kwad.sdk.core.webview.c.c cVar) {
        b bVar = new b();
        if (this.qx == null) {
            this.qx = new d() { // from class: com.kwad.components.core.webview.jshandler.ae.1
                @Override // com.kwad.components.core.webview.jshandler.ae.d
                public final void u(int i, int i2) {
                    a aVar = new a();
                    aVar.width = i;
                    aVar.height = i2;
                    cVar.b(aVar);
                }
            };
        }
        bVar.aqr = this.qx;
        a aVar = new a();
        c cVar2 = this.aqp;
        if (cVar2 != null) {
            cVar2.c(bVar);
            aVar.height = bVar.height;
            aVar.width = bVar.width;
        } else {
            aVar.width = this.apL.adZ.getWidth();
            aVar.height = this.apL.adZ.getHeight();
        }
        cVar.b(aVar);
    }

    public static class a implements com.kwad.sdk.core.b {
        public int height;
        public int width;

        @Override // com.kwad.sdk.core.b
        public void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediaFormat.KEY_WIDTH, this.width);
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediaFormat.KEY_HEIGHT, this.height);
            return jSONObject;
        }
    }
}
