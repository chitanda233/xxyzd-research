package com.kwad.components.ad.reward.n;

import android.view.ViewGroup;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d {
    protected void a(r rVar) {
    }

    protected void ad(boolean z) {
    }

    public abstract ViewGroup hZ();

    public void onUnbind() {
    }

    public final void b(r rVar) {
        a(rVar);
        hZ().getContext();
        ad(as.VV());
    }
}
