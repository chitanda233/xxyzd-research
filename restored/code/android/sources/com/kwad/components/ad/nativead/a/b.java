package com.kwad.components.ad.nativead.a;

import com.kwad.components.core.e.d.d;
import com.kwad.sdk.api.KsNativeAd;
import com.kwad.sdk.core.view.AdBasePvFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.mvp.a {
    public d mApkDownloadHelper;
    public AdBasePvFrameLayout pJ;
    public com.kwad.components.ad.nativead.d.a pP;
    public boolean pU = false;
    public boolean pV = false;
    public KsNativeAd.VideoPlayListener pn;
    public com.kwad.components.ad.nativead.d.a pv;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.clear();
        }
        this.pP.release();
    }
}
