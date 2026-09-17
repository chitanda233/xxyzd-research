package com.czhj.sdk.common.network;

/* JADX INFO: loaded from: classes2.dex */
public enum ResponseHeader {
    LOCATION("Location"),
    USER_AGENT("User-Agent"),
    ACCEPT_LANGUAGE("Accept-Language");

    private final String key;

    ResponseHeader(String str) {
        this.key = str;
    }

    public String getKey() {
        return this.key;
    }
}
