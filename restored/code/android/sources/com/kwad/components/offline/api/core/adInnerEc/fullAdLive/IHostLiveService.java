package com.kwad.components.offline.api.core.adInnerEc.fullAdLive;

/* JADX INFO: loaded from: classes3.dex */
public interface IHostLiveService {
    ILiveBindOwner createLiveBindOwner(String str, String str2);

    IHostLivePlayer createLivePlayer();

    IHostLivePlayer createLivePlayer(String str);

    void initService();
}
