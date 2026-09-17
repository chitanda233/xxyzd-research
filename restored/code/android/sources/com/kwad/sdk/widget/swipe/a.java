package com.kwad.sdk.widget.swipe;

import android.view.MotionEvent;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a {
    private boolean btF;

    protected abstract boolean XX();

    protected abstract boolean XY();

    public final boolean b(View view, MotionEvent motionEvent) {
        return !this.btF && XX();
    }

    public final boolean c(View view, MotionEvent motionEvent) {
        return !this.btF && XY();
    }
}
