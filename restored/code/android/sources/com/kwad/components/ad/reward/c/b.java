package com.kwad.components.ad.reward.c;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public static int STATUS_NONE = 2;
    public static int uY = 1;
    public static int uZ = 3;
    public int va;
    public int vb;

    public b() {
        this.va = STATUS_NONE;
    }

    public b(int i) {
        this.va = 1;
    }

    public final int getType() {
        return this.va;
    }

    public final int ii() {
        return this.vb;
    }

    public final void aa(int i) {
        this.vb = i;
    }
}
