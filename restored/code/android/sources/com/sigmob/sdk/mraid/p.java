package com.sigmob.sdk.mraid;

/* JADX INFO: loaded from: classes3.dex */
public enum p {
    PORTRAIT(1),
    LANDSCAPE(0),
    NONE(-1);

    private final int d;

    p(final int activityInfoOrientation) {
        this.d = activityInfoOrientation;
    }

    public int a() {
        return this.d;
    }
}
