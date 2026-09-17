package com.kwad.components.ad.reward.n;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public class a implements b {
    private Context mContext;
    private com.kwad.components.ad.reward.g ub;

    public a(Context context, com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
        this.mContext = context;
    }

    @Override // com.kwad.components.ad.reward.n.b
    public final void id() {
        this.ub.a(1, this.mContext, 1, 1);
    }

    @Override // com.kwad.components.ad.reward.n.b
    public void jC() {
        this.ub.a(1, this.mContext, 13, 2);
    }

    @Override // com.kwad.components.ad.reward.n.b
    public void jD() {
        this.ub.a(1, this.mContext, 117, 2);
    }
}
