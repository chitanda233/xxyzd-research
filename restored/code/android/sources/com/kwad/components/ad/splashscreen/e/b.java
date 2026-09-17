package com.kwad.components.ad.splashscreen.e;

import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.TextView;
import com.kwad.components.ad.splashscreen.e;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.h;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.sdk.widget.d {
    private a HN;
    private ViewStub KK;
    private ViewGroup KL;
    private View KM;
    private TextView KN;
    private boolean KO;
    private e KP;
    private h KQ;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private ViewGroup mRootContainer;

    public b(ViewGroup viewGroup, ViewStub viewStub, boolean z, com.kwad.components.core.e.d.d dVar) {
        this.mRootContainer = viewGroup;
        this.KK = viewStub;
        this.mApkDownloadHelper = dVar;
        this.KO = z;
    }

    public final void a(e eVar) {
        this.KP = eVar;
    }

    public final void nd() {
        com.kwad.sdk.core.d.c.d("SplashActionBarNativeHelper", "rollBackToNative mRootViewStub: " + this.KK);
        if (this.KL == null) {
            ViewStub viewStub = this.KK;
            if (viewStub != null && viewStub.getParent() != null) {
                this.KL = (ViewGroup) this.KK.inflate();
            } else {
                this.KL = (ViewGroup) this.mRootContainer.findViewById(R.id.ksad_splash_actionbar_native_root);
            }
            i(this.KL);
        }
        ViewGroup viewGroup = this.KL;
        if (viewGroup != null) {
            viewGroup.setVisibility(0);
        }
    }

    private void i(ViewGroup viewGroup) {
        if (viewGroup == null) {
            return;
        }
        this.KM = viewGroup.findViewById(R.id.ksad_splash_actionbar_native);
        this.KN = (TextView) viewGroup.findViewById(R.id.ksad_splash_actionbar_text);
        this.KQ = new h(this.KM.getContext(), this.KM, this);
        a(com.kwad.components.ad.splashscreen.d.a(this.mAdTemplate, this.mAdInfo, this.mApkDownloadHelper, 4));
    }

    private void a(com.kwad.components.ad.splashscreen.d dVar) {
        if (dVar == null) {
            return;
        }
        ad(dVar.lU());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ad(String str) {
        TextView textView = this.KN;
        if (textView == null || str == null) {
            return;
        }
        textView.setText(str);
    }

    private void j(boolean z, boolean z2) {
        e eVar = this.KP;
        if (eVar != null) {
            eVar.i(z, z2);
        }
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        j(true, view.equals(this.KM));
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mAdTemplate, f, f2, f3, f4)) {
            j(false, view.equals(this.KM));
        }
    }

    public final void av(AdTemplate adTemplate) {
        a aVar;
        this.mAdTemplate = adTemplate;
        a aVar2 = this.HN;
        if (aVar2 == null) {
            this.HN = new a(this.mRootContainer.getContext(), this.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.e.b.1
                {
                    super(adTemplate);
                }

                @Override // com.kwad.components.ad.splashscreen.e.a
                protected final void j(int i, String str) {
                    b.this.ad(str);
                }
            };
        } else {
            aVar2.setAdTemplate(adTemplate);
        }
        if (adTemplate != null) {
            this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        }
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || (aVar = this.HN) == null) {
            return;
        }
        dVar.b(aVar);
    }

    public final void onUnbind() {
        a aVar;
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || (aVar = this.HN) == null) {
            return;
        }
        dVar.c(aVar);
    }
}
