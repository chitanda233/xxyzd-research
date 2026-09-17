package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public interface ITuringDID {
    String getAIDCode();

    String getAIDTicket();

    int getErrorCode();

    long getExpiredTimestamp();

    String getOpenIdTicket();

    String getTAIDTicket();
}
