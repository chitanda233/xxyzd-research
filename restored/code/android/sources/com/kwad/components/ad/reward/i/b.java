package com.kwad.components.ad.reward.i;

import android.content.Context;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.bk;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends bk implements bk.a {
    private PlayableSource wm;

    public b(Context context, AdTemplate adTemplate, PlayableSource playableSource) {
        super(context, adTemplate);
        this.wm = playableSource;
        a(this);
    }

    @Override // com.kwad.components.core.webview.jshandler.bk.a
    public final boolean eR() {
        com.kwad.components.ad.reward.a.gq().c(this.wm, new a(this.mContext));
        return false;
    }
}
