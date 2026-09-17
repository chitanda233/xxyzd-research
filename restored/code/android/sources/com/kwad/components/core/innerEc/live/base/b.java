package com.kwad.components.core.innerEc.live.base;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public int TB;
    public long TC;
    public String authorId;
    public String content;
    public String kwaiUserId;
    public String liveStreamId;

    public static b rH() {
        return new b();
    }

    public final b aA(String str) {
        this.authorId = str;
        return this;
    }

    public final b aB(String str) {
        this.liveStreamId = str;
        return this;
    }

    public final b aC(String str) {
        this.kwaiUserId = str;
        return this;
    }

    public final b aD(String str) {
        this.content = str;
        return this;
    }

    public final b aL(int i) {
        this.TB = i;
        return this;
    }

    public final b F(long j) {
        this.TC = 1L;
        return this;
    }
}
