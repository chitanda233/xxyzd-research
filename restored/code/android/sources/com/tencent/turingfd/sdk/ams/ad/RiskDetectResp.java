package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public interface RiskDetectResp {
    String getDeviceToken();

    long getErrorCode();

    long getStagePackTimeMillis();

    long getStageReqTimeMillis();

    boolean isDowngrade();
}
