package com.kwad.components.core.webview.a;

import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public class c extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
    public String Pu;
    public String apo;
    public String app;
    public int apq;

    public final AdInfo.SmallAppJumpInfo bz(String str) {
        AdInfo.SmallAppJumpInfo smallAppJumpInfo = new AdInfo.SmallAppJumpInfo();
        smallAppJumpInfo.mediaSmallAppId = str;
        smallAppJumpInfo.originId = this.apo;
        smallAppJumpInfo.smallAppJumpUrl = this.app;
        return smallAppJumpInfo;
    }
}
