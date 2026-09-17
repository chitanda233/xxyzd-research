package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.Vibrator;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public abstract class i extends e implements com.kwad.sdk.core.j.c {
    private static long nW = 400;
    private com.kwad.components.ad.splashscreen.e.a HN;
    private Vibrator ho;

    protected abstract void fW();

    protected abstract void i(int i, String str);

    protected abstract void initView();

    protected abstract void mH();

    protected abstract void mI();

    protected abstract void mJ();

    protected abstract void mK();

    protected abstract void mL();

    @Override // com.kwad.sdk.mvp.Presenter
    public void onCreate() {
        super.onCreate();
        initView();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        if (this.Hu == null) {
            return;
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        mJ();
        mH();
        if (com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            mM();
        }
        mI();
        fW();
        this.Hu.GH.a(this);
    }

    private void mM() {
        if (this.Hu != null) {
            com.kwad.components.ad.splashscreen.e.a aVar = this.HN;
            if (aVar == null) {
                this.HN = new com.kwad.components.ad.splashscreen.e.a(getContext(), this.Hu.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.presenter.i.1
                    {
                        super(adTemplate);
                    }

                    @Override // com.kwad.components.ad.splashscreen.e.a
                    public final void j(int i, String str) {
                        i.this.i(i, str);
                    }
                };
            } else {
                aVar.setAdTemplate(this.Hu.mAdTemplate);
            }
            com.kwad.components.core.e.d.d dVar = this.Hu.mApkDownloadHelper;
            if (dVar != null) {
                dVar.b(this.HN);
            }
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onUnbind() {
        super.onUnbind();
        if (this.Hu != null && this.Hu.GH != null) {
            this.Hu.GH.b(this);
        }
        mL();
        by.b(getContext(), this.ho);
    }

    protected final void mN() {
        Context context = getContext();
        if (context != null) {
            this.ho = (Vibrator) context.getSystemService("vibrator");
        }
        by.a(getContext(), this.ho);
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        if (this.Hu.GK) {
            return;
        }
        mK();
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        mL();
    }
}
