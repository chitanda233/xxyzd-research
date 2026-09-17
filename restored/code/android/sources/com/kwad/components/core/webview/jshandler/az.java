package com.kwad.components.core.webview.jshandler;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class az extends com.kwad.components.core.webview.tachikoma.b.w {
    private boolean arx;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerLifecycleListener";
    }

    public az() {
        this(false);
    }

    private az(boolean z) {
        this.arx = false;
    }

    public final void bm(boolean z) {
        this.arx = true;
    }

    public final void yJ() {
        aE("showStart");
    }

    public final void yK() {
        aE("showEnd");
    }

    public final void yL() {
        aE("hideStart");
    }

    public final void yM() {
        aE("hideEnd");
    }

    public final void yN() {
        aE("pageVisiable");
    }

    public final void yO() {
        aE("pageInvisiable");
    }

    private void aE(String str) {
        a aVar = new a();
        aVar.ary = str;
        a(aVar);
    }

    @Override // com.kwad.components.core.webview.tachikoma.b.w
    public final void a(com.kwad.sdk.core.b bVar) {
        if (this.arx) {
            if (this.atZ != null) {
                this.atZ.b(bVar);
                return;
            } else {
                this.aua.add(bVar);
                return;
            }
        }
        super.a(bVar);
    }

    public static final class a implements com.kwad.sdk.core.b {
        private String ary;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, "lifeStatus", this.ary);
            return jSONObject;
        }
    }
}
