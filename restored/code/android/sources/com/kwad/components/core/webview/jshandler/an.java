package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import com.kwad.sdk.core.response.model.AdTemplate;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class an implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;
    private final b aqU;
    private final Handler aqf;

    public static final class a extends com.kwad.sdk.core.response.a.a {
        public boolean ara;
        public String arb;
        public int arc;
        public com.kwad.sdk.core.webview.d.b.d ard;
    }

    public interface b {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "clickAction";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        final com.kwad.components.core.e.d.d dVar;
        final a aVar = new a();
        final AdTemplate adTemplate = new AdTemplate();
        try {
            aVar.parseJson(new JSONObject(str));
            adTemplate.parseJson(new JSONObject(aVar.arb));
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
        if (com.kwad.sdk.core.response.helper.e.eE(adTemplate)) {
            if (this.apL.bbW != null) {
                dVar = (com.kwad.components.core.e.d.d) this.apL.bbW.hP(com.kwad.sdk.core.response.helper.e.eM(adTemplate).downloadId);
            } else {
                dVar = null;
            }
            if (this.apL.bbX) {
                this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.an.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(an.this.apL.adZ.getContext()).aF(adTemplate).b(dVar).aD(aVar.arc).as(true).ao(aVar.ard.QQ).au(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.core.webview.jshandler.an.1.1
                            @Override // com.kwad.components.core.e.d.a.b
                            public final void onAdClicked() {
                            }
                        }));
                    }
                });
            } else if (this.aqU != null) {
                this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.an.2
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                    }
                });
            }
            cVar.b(null);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.aqf.removeCallbacksAndMessages(null);
    }
}
