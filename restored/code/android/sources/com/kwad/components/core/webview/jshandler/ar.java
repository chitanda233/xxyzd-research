package com.kwad.components.core.webview.jshandler;

import android.content.Context;
import com.kwad.sdk.commercial.smallApp.JumpFrom;
import com.kwad.sdk.core.response.model.AdTemplate;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ar implements com.kwad.sdk.core.webview.c.a {
    private AdTemplate mAdTemplate;
    private Context mContext;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "openWechatMiniProgram";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public ar(Context context, AdTemplate adTemplate) {
        this.mContext = context;
        this.mAdTemplate = adTemplate;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        com.kwad.components.core.webview.a.c cVar2 = new com.kwad.components.core.webview.a.c();
        if (this.mContext == null) {
            com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, 2);
            cVar.onError(-1, "context为空");
            return;
        }
        AdTemplate adTemplate = null;
        try {
            cVar2.parseJson(new JSONObject(str));
            AdTemplate adTemplateA = this.mAdTemplate;
            try {
                if (cVar2.apq > 0) {
                    adTemplateA = com.kwad.sdk.core.response.helper.c.a(com.kwad.components.core.offline.a.f.a.a.bf(cVar2.apq), cVar2.Pu);
                }
                if (adTemplateA == null) {
                    com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, 2);
                    cVar.onError(-1, "adTemplate为空：" + cVar2.apq);
                    return;
                }
                if (com.kwad.components.core.e.d.f.a(this.mContext, cVar2.bz(com.kwad.sdk.core.response.helper.a.du(com.kwad.sdk.core.response.helper.e.eM(adTemplateA))), JumpFrom.H5, adTemplateA) == 1) {
                    cVar.b(null);
                } else {
                    cVar.onError(-1, "跳转失败");
                }
            } catch (Exception e) {
                e = e;
                adTemplate = adTemplateA;
                com.kwad.sdk.core.adlog.c.m(adTemplate, 2);
                cVar.onError(-1, "解析失败");
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        } catch (Exception e2) {
            e = e2;
        }
    }
}
