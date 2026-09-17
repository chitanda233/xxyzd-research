package com.kwad.components.core.page.widget.b;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.page.f;
import com.kwad.components.core.proxy.j;
import com.kwad.components.offline.api.core.adInnerEc.ExternalExitListener;
import com.kwad.sdk.R;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends j {
    private ExternalExitListener adF;
    private View aig;
    private String aih;
    private KSFrameLayout aii;

    public static a bc(String str) {
        a aVar = new a();
        aVar.aih = str;
        Bundle bundle = new Bundle();
        bundle.putString("h5_url", str);
        aVar.setArguments(bundle);
        return aVar;
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public final void onDestroyView() {
        try {
            super.onDestroyView();
        } catch (Throwable th) {
            c.e("KwaiYodaWebViewFragment", "destroy view failed:" + th);
        }
        KSFrameLayout kSFrameLayout = this.aii;
        if (kSFrameLayout != null && (kSFrameLayout.getParent() instanceof ViewGroup)) {
            ((ViewGroup) this.aii.getParent()).removeView(this.aii);
            this.aii = null;
        }
        this.adF = null;
    }

    @Override // com.kwad.components.core.proxy.j
    public final View a(LayoutInflater layoutInflater, ViewGroup viewGroup) {
        if (this.aii == null) {
            this.aii = (KSFrameLayout) layoutInflater.inflate(R.layout.ksad_yoda_web_container, viewGroup, false);
        }
        this.aih = getArguments().getString("h5_url");
        if (getContext() != null) {
            AdWebViewActivityProxy.a aVarUm = new AdWebViewActivityProxy.a.C0449a().aW("").aX(this.aih).um();
            f fVar = new f(getContext());
            fVar.c(getContext(), aVarUm);
            fVar.setExternalExitListener(this.adF);
            fVar.b(getActivity());
            this.aig = fVar;
            this.aii.addView(fVar);
        }
        return this.aii;
    }

    public final void setExternalExitListener(ExternalExitListener externalExitListener) {
        this.adF = externalExitListener;
    }
}
