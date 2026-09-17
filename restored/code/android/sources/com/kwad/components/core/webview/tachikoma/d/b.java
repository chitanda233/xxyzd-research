package com.kwad.components.core.webview.tachikoma.d;

import android.app.Activity;
import com.kwad.components.core.webview.tachikoma.k;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.sdk.components.l;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.widget.g;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.mvp.a {
    public String BV;
    public long Cb;
    public com.kwad.components.core.webview.tachikoma.f.c akN;
    public StyleTemplate akP;
    public e asz;
    public g auF;
    public l auG;
    public k auH;
    public boolean auI;
    public e.a auJ;
    public Activity mActivity;
    public AdResultData mAdResultData;

    public final void a(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    @Override // com.kwad.sdk.mvp.a
    public void release() {
        this.asz = null;
        this.mActivity = null;
        this.auF = null;
    }
}
