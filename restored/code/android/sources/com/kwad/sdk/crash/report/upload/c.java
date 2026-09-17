package com.kwad.sdk.crash.report.upload;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.sdk.core.network.b {
    public final Map<String, String> bfP;

    @Override // com.kwad.sdk.core.network.b
    public final void buildBaseBody() {
    }

    @Override // com.kwad.sdk.core.network.b
    public final void buildBaseHeader() {
    }

    public c(String str, String str2, String str3) {
        HashMap map = new HashMap();
        this.bfP = map;
        map.put("did", str);
        map.put("sid", str2);
        map.put("fileExtend", str3);
        map.put("bizType", "5");
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return "https://" + com.kwad.sdk.core.network.idc.a.My().Y("ulog", "ulog-sdk.gifshow.com") + "/rest/log/sdk/file/token";
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final Map<String, String> getBodyMap() {
        return this.bfP;
    }
}
