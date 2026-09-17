package com.kwad.components.core.page.d.a;

import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.core.page.d.a.a {
    private boolean aeD;
    private com.kwad.components.core.b.a mTitleBarHelper;

    public interface a {
        void bn(int i);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.core.page.d.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.aeD = TextUtils.equals(this.aec.mPageUrl, com.kwad.sdk.core.response.helper.a.aY(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate)));
        ur();
    }

    private String getTitle() {
        if (TextUtils.isEmpty(this.aec.mPageTitle)) {
            return (this.aec.mAdTemplate.adInfoList == null || this.aec.mAdTemplate.adInfoList.size() <= 0 || this.aec.mAdTemplate.adInfoList.get(0) == null) ? "详情页面" : com.kwad.sdk.core.response.helper.a.cs(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate));
        }
        return this.aec.mPageTitle;
    }

    private void ur() {
        com.kwad.components.core.b.a aVar = new com.kwad.components.core.b.a(this.aec.mRootContainer);
        this.mTitleBarHelper = aVar;
        aVar.a(new com.kwad.components.core.b.b(getTitle()));
        this.mTitleBarHelper.ak(true);
        this.mTitleBarHelper.a(new com.kwad.components.core.b.a.InterfaceC0417a() { // from class: com.kwad.components.core.page.d.a.f.1
            @Override // com.kwad.components.core.b.a.InterfaceC0417a
            public final void w(View view) {
                f.this.B(view);
            }

            @Override // com.kwad.components.core.b.a.InterfaceC0417a
            public final void x(View view) {
                f.this.C(view);
            }
        });
        ViewGroup viewGroupHZ = this.mTitleBarHelper.hZ();
        int i = 0;
        if (!this.aec.mAdTemplate.mIsForceJumpLandingPage && !com.kwad.sdk.core.response.helper.a.cG(this.aec.mAdTemplate) && !com.kwad.sdk.core.response.helper.b.dP(com.kwad.sdk.core.response.helper.e.eM(this.aec.mAdTemplate))) {
            i = 8;
        }
        viewGroupHZ.setVisibility(i);
        this.aec.a(new a() { // from class: com.kwad.components.core.page.d.a.f.2
            @Override // com.kwad.components.core.page.d.a.f.a
            public final void bn(int i2) {
                f.this.mTitleBarHelper.hZ().setVisibility(i2 == 1 ? 0 : 8);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void B(View view) {
        if (this.aec != null) {
            this.aec.a(this.aeD, view);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void C(View view) {
        if (this.aec.aee != null) {
            this.aec.aee.ud();
        }
    }
}
