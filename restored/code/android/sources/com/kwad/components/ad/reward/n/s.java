package com.kwad.components.ad.reward.n;

import android.view.ViewGroup;
import android.view.ViewStub;

/* JADX INFO: loaded from: classes3.dex */
public abstract class s extends d {
    protected ViewGroup wL;

    public final void a(ViewGroup viewGroup, int i, int i2) {
        if (this.wL != null) {
            return;
        }
        ViewStub viewStub = (ViewStub) viewGroup.findViewById(i);
        if (viewStub != null) {
            this.wL = (ViewGroup) viewStub.inflate();
        } else {
            this.wL = (ViewGroup) viewGroup.findViewById(i2);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public ViewGroup hZ() {
        return this.wL;
    }
}
