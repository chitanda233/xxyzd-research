package com.kwad.components.core.page;

import android.app.Activity;
import android.content.Context;
import android.view.KeyEvent;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebView;
import android.widget.FrameLayout;
import com.kwad.components.offline.api.core.adInnerEc.ExternalExitListener;
import com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.lang.ref.WeakReference;
import java.util.HashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.core.n.d<com.kwad.components.core.page.d.a.b> implements YodaWebPageListener {
    private static final Set<WeakReference<f>> adG = new HashSet();
    private AdWebViewActivityProxy.a adE;
    private ExternalExitListener adF;
    private WebView adg;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private String mPageTitle;
    private String mPageUrl;

    @Override // com.kwad.components.core.n.d
    public final void a(ViewGroup viewGroup) {
    }

    @Override // com.kwad.components.core.n.d
    public final void initData() {
    }

    @Override // com.kwad.components.core.n.d
    public final ViewGroup tC() {
        return this;
    }

    public static void a(WebView webView, com.kwad.components.core.b.b bVar) {
        f fVarA = a(webView);
        if (fVarA != null) {
            fVarA.b(bVar);
        }
    }

    private static f a(WebView webView) {
        f fVar;
        WebView webView2;
        if (webView == null) {
            return null;
        }
        for (WeakReference<f> weakReference : adG) {
            if (weakReference != null && weakReference.get() != null && (fVar = weakReference.get()) != null && (webView2 = fVar.adg) != null && webView.equals(webView2)) {
                return fVar;
            }
        }
        return null;
    }

    public f(Context context) {
        super(context);
    }

    public final void c(Context context, AdWebViewActivityProxy.a aVar) {
        this.adE = aVar;
        this.mContext = context;
        this.mAdTemplate = aVar.getAdTemplate();
        this.mPageUrl = aVar.uf();
        this.mPageTitle = aVar.ue();
    }

    @Override // com.kwad.components.core.n.d
    public final int getLayoutId() {
        return R.layout.ksad_merchant_landing_view;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.core.n.d
    /* JADX INFO: renamed from: un, reason: merged with bridge method [inline-methods] */
    public com.kwad.components.core.page.d.a.b an() {
        com.kwad.components.core.page.d.a.b bVar = new com.kwad.components.core.page.d.a.b();
        bVar.mContext = this.mContext;
        bVar.mAdTemplate = this.mAdTemplate;
        bVar.adE = this.adE;
        bVar.mPageTitle = this.mPageTitle;
        bVar.mPageUrl = this.mPageUrl;
        bVar.mRootContainer = this.ou;
        bVar.aed = this.adg;
        return bVar;
    }

    @Override // com.kwad.components.core.n.d
    public final Presenter onCreatePresenter() {
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.core.page.b.a());
        return presenter;
    }

    private void b(com.kwad.components.core.b.b bVar) {
        if (this.abu == 0 || ((com.kwad.components.core.page.d.a.b) this.abu).aej == null) {
            return;
        }
        ((com.kwad.components.core.page.d.a.b) this.abu).aej.a(bVar);
    }

    public final void b(Activity activity) {
        FrameLayout frameLayout = (FrameLayout) this.ou.findViewById(R.id.ksad_merchant_web_container);
        WebView webViewA = com.kwad.components.core.innerEc.f.a(activity, this, this.adF);
        this.adg = webViewA;
        if (webViewA != null) {
            frameLayout.addView(webViewA, -1, -1);
        }
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onPageFinished() {
        AdTemplate adTemplate = this.mAdTemplate;
        boolean z = false;
        if (adTemplate != null) {
            boolean zDH = com.kwad.sdk.core.response.helper.a.dH(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            if (com.kwad.sdk.core.response.helper.b.et(this.mAdTemplate) && this.mAdTemplate.isDoAuth && !zDH) {
                z = true;
            }
            if (z) {
                by.postOnUiThread(new bi() { // from class: com.kwad.components.core.page.f.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        ae.c(f.this.mContext, com.kwad.sdk.core.response.helper.b.eu(f.this.mAdTemplate), 0);
                        f.this.mAdTemplate.isDoAuth = false;
                    }
                });
            }
        }
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onPageFinished enableInnerEcToast: " + z);
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onReceivedError() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onReceivedError");
        com.kwad.components.core.innerEc.logger.a.m(this.mAdTemplate, this.mPageUrl);
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onPagePause() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onPagePause");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onPageResume() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onPageFinished");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onBackground() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onBackground");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onForeground() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onForeground");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onLeave() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onLeave");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onReentry() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onReentry");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onVisibleChange(boolean z) {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onVisibleChange " + z);
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final void onLoadPage() {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onLoadPage");
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final boolean onKey(View view, int i, KeyEvent keyEvent) {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "onKey " + i + " " + keyEvent.getAction());
        return false;
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener
    public final boolean overrideUrlLoading(WebView webView, String str) {
        com.kwad.sdk.core.d.c.w("MerchantLandingPageView", "overrideUrlLoading url:" + str);
        return true;
    }

    public final void setExternalExitListener(ExternalExitListener externalExitListener) {
        this.adF = externalExitListener;
    }

    @Override // com.kwad.components.core.n.d, com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        WebView webView = this.adg;
        if (webView != null) {
            webView.destroy();
            this.adg = null;
        }
        ((com.kwad.components.core.page.d.a.b) this.abu).aed = null;
        this.mContext = null;
        super.af();
    }
}
