package com.kwad.components.core.innerEc.live.a;

import com.kwad.sdk.core.response.model.LiveDetailReward;
import com.kwad.sdk.service.ServiceProvider;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class j implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.components.core.innerEc.live.base.f TO;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "liveRewardCallback";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public j(com.kwad.components.core.innerEc.live.base.f fVar) {
        this.TO = fVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            com.kwad.sdk.core.d.c.d("JsHandlerLiveTask", "handleJsCall: " + str);
            LiveDetailReward liveDetailReward = new LiveDetailReward();
            liveDetailReward.parseJson(new JSONObject(str));
            com.kwad.components.core.innerEc.live.base.f fVar = this.TO;
            if (fVar != null) {
                fVar.b(liveDetailReward);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
