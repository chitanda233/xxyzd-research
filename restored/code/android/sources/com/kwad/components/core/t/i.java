package com.kwad.components.core.t;

import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public abstract class i implements View.OnClickListener {
    private j alA;

    public i() {
        this(false);
    }

    private i(boolean z) {
        this.alA = new j(false);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        this.alA.a(view, this);
    }
}
