package com.kwad.components.core.e.c;

import android.content.Context;
import android.content.res.Configuration;
import android.view.LayoutInflater;
import android.view.View;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends KSFrameLayout {
    private final b Qn;
    private final b.C0427b Qo;
    private d Qp;
    private InterfaceC0426a Qq;
    private final AdTemplate mAdTemplate;
    private final Context mContext;
    private Presenter mPresenter;
    private final AdBaseFrameLayout mRootContainer;

    /* JADX INFO: renamed from: com.kwad.components.core.e.c.a$a, reason: collision with other inner class name */
    public interface InterfaceC0426a {
        void pE();
    }

    public a(Context context, b bVar, b.C0427b c0427b) {
        super(context);
        this.mContext = context;
        this.Qn = bVar;
        this.Qo = c0427b;
        this.mAdTemplate = c0427b.adTemplate;
        m.inflate(context, R.layout.ksad_download_dialog_layout, this);
        AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
        this.mRootContainer = adBaseFrameLayout;
        b(adBaseFrameLayout, "rootView is null");
        b((KsAdWebView) adBaseFrameLayout.findViewById(R.id.ksad_download_tips_web_card_webView), "webView is null");
    }

    private void b(View view, String str) {
        if (view == null) {
            throw new RuntimeException("inflateView fail " + str + "\n--viewCount:" + getChildCount() + "\n--context:" + this.mContext.getClass().getName() + "\n--LayoutInflater context: " + LayoutInflater.from(this.mContext).getContext().getClass().getName() + "\n--classloader:" + getClass().getClassLoader().getClass().getName());
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        this.Qp = pD();
        Presenter presenterBF = bF();
        this.mPresenter = presenterBF;
        presenterBF.N(this.mRootContainer);
        this.mPresenter.q(this.Qp);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        d dVar = this.Qp;
        if (dVar != null) {
            dVar.release();
        }
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
        }
    }

    private d pD() {
        d dVar = new d();
        dVar.Qn = this.Qn;
        dVar.Qo = this.Qo;
        dVar.mAdTemplate = this.mAdTemplate;
        dVar.mRootContainer = this.mRootContainer;
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            dVar.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        }
        return dVar;
    }

    private static Presenter bF() {
        Presenter presenter = new Presenter();
        presenter.a(new e());
        return presenter;
    }

    @Override // android.view.View
    protected final void onConfigurationChanged(Configuration configuration) {
        super.onConfigurationChanged(configuration);
        InterfaceC0426a interfaceC0426a = this.Qq;
        if (interfaceC0426a != null) {
            interfaceC0426a.pE();
        }
    }

    public final void setChangeListener(InterfaceC0426a interfaceC0426a) {
        this.Qq = interfaceC0426a;
    }
}
