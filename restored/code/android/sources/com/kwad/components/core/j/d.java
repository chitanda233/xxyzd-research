package com.kwad.components.core.j;

import com.kwad.sdk.api.KsInnerAd;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private Object abe;

    public d(Object obj) {
        this.abe = obj;
    }

    public final void c(c cVar) {
        if (this.abe == null || cVar == null || cVar.getHost() == null) {
            return;
        }
        try {
            ((KsInnerAd.KsInnerAdInteractionListener) this.abe).onAdClicked((KsInnerAd) cVar.getHost());
        } catch (Exception unused) {
        }
    }

    public final void d(c cVar) {
        if (this.abe == null || cVar == null || cVar.getHost() == null) {
            return;
        }
        try {
            ((KsInnerAd.KsInnerAdInteractionListener) this.abe).onAdShow((KsInnerAd) cVar.getHost());
        } catch (Exception unused) {
        }
    }

    public final void destroy() {
        this.abe = null;
    }
}
