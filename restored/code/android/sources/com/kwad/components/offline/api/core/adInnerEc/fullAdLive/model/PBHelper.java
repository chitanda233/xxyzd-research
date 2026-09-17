package com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model;

/* JADX INFO: loaded from: classes3.dex */
public interface PBHelper {
    PbClientStat getPbClientStat();

    PbPayloadType getPbPayloadType();

    <T> T parseFrom(byte[] bArr, Class<T> cls);
}
