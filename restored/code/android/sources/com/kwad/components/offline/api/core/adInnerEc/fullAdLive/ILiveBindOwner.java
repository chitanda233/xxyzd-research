package com.kwad.components.offline.api.core.adInnerEc.fullAdLive;

import com.kwad.components.offline.api.core.adInnerEc.longconnection.ILiveLongConnection;

/* JADX INFO: loaded from: classes3.dex */
public interface ILiveBindOwner {
    IHostLivePlayer getLivePlayer();

    ILiveLongConnection getLongConnection();

    void release();
}
