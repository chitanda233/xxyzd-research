package com.kwad.components.offline.api.core.adInnerEc.fullAdLive.listener;

import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.info.HostLiveUrlSwitchReason;

/* JADX INFO: loaded from: classes3.dex */
public interface IHostLiveUrlSwitchListener {
    void onUrlSwitchFail(HostLiveUrlSwitchReason hostLiveUrlSwitchReason);

    void onUrlSwitchSuccess(HostLiveUrlSwitchReason hostLiveUrlSwitchReason);
}
