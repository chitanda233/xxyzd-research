package com.kwad.components.core.e.c;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.sdk.mvp.a {
    public b Qn;
    public b.C0427b Qo;
    public AdTemplate mAdTemplate;
    public com.kwad.components.core.e.d.d mApkDownloadHelper;
    public AdBaseFrameLayout mRootContainer;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.clear();
        }
    }
}
