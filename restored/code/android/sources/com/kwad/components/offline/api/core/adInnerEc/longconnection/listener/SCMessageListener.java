package com.kwad.components.offline.api.core.adInnerEc.longconnection.listener;

/* JADX INFO: loaded from: classes3.dex */
public interface SCMessageListener {
    int getPayloadType();

    boolean isSticky();

    void onMessageReceived(byte[] bArr);
}
