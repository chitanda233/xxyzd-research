package com.kwad.sdk.utils;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public abstract class m<T> {
    protected boolean boF = false;
    protected boolean enable;

    protected abstract T cX(Context context);

    public m(boolean z) {
        this.enable = z;
    }

    public final void cs(boolean z) {
        this.enable = z;
    }

    public final T cW(Context context) {
        if (!this.enable || this.boF) {
            return null;
        }
        try {
            return cX(context);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return null;
        }
    }
}
