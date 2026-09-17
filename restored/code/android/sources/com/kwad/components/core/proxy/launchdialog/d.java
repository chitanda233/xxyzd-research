package com.kwad.components.core.proxy.launchdialog;

import androidx.lifecycle.Lifecycle;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private final Lifecycle.Event ajj;
    private final long ajk = System.currentTimeMillis();

    public d(Lifecycle.Event event) {
        this.ajj = event;
    }

    public final String toString() {
        return "LifecycleStamp{mEvent=" + this.ajj + ", mEventTimestamp=" + this.ajk + '}';
    }

    public final Lifecycle.Event vT() {
        return this.ajj;
    }

    public final long vU() {
        return this.ajk;
    }
}
