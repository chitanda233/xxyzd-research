package com.kwad.components.core.innerEc.live.g;

import com.kwad.components.core.innerEc.f;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCFeedPush;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends a<PbSCFeedPush> {
    @Override // com.kwad.components.core.innerEc.live.g.a
    final /* synthetic */ PbSCFeedPush e(byte[] bArr) {
        return g(bArr);
    }

    private static PbSCFeedPush g(byte[] bArr) {
        return (PbSCFeedPush) f.rh().parseFrom(bArr, PbSCFeedPush.class);
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.SCMessageListener
    public int getPayloadType() {
        return f.rh().getPbPayloadType().getScFeedPush();
    }
}
