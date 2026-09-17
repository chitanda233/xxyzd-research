package com.kwad.components.core.page;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.ViewGroup;
import com.bykv.vk.component.ttvideo.player.C;
import com.kwad.sdk.R;
import com.kwad.sdk.api.core.KsAdSdkDynamicImpl;
import com.kwad.sdk.api.proxy.app.PayResultActivity;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
@KsAdSdkDynamicImpl(PayResultActivity.class)
public class PayResultActivityProxy extends com.kwad.components.core.proxy.f {
    private static final String TAG = "PayResultActivityProxy";
    private int mLandingPageType;
    private f mMerchantLandingPageView;
    private String mPageTitle;
    private String mPageUrl;
    private ViewGroup mRootContainer;

    @Override // com.kwad.components.core.proxy.f
    public int getLayoutId() {
        return 0;
    }

    @Override // com.kwad.components.core.proxy.f
    public String getPageName() {
        return "PayResult";
    }

    @Override // com.kwad.components.core.proxy.f
    public boolean needAdaptionScreen() {
        return true;
    }

    @Override // com.kwad.components.core.proxy.f
    public int onSetActivityTheme() {
        return -1;
    }

    public static void launch(Context context, AdWebViewActivityProxy.a aVar) {
        com.kwad.sdk.core.d.c.d(TAG, "launch: pageUrl: " + aVar.uf() + ", context: " + context);
        if (context == null || TextUtils.isEmpty(aVar.uf())) {
            return;
        }
        try {
            com.kwad.sdk.service.c.putComponentProxy(PayResultActivity.class, PayResultActivityProxy.class);
            Intent intent = new Intent(context, (Class<?>) PayResultActivity.class);
            if (!(context instanceof Activity)) {
                intent.setFlags(C.ENCODING_PCM_MU_LAW);
            }
            intent.putExtra(AdWebViewActivityProxy.KEY_PAGE_TITLE, aVar.ue());
            intent.putExtra(AdWebViewActivityProxy.KEY_LANDING_PAGE_TYPE, aVar.ug());
            intent.putExtra(AdWebViewActivityProxy.KEY_PAGE_URL, aVar.uf());
            com.kwad.sdk.core.d.c.d(TAG, "launch: startActivity: " + aVar.uf());
            context.startActivity(intent);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.d(TAG, "launch: startActivity error " + th.getMessage());
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            if (o.GE().FG()) {
                ServiceProvider.reportSdkCaughtException(th);
                return;
            }
            throw th;
        }
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        com.kwad.components.core.t.d.a(getActivity(), 0, true);
    }

    @Override // com.kwad.components.core.proxy.f
    public void initData() {
        this.mPageTitle = getIntent().getStringExtra(AdWebViewActivityProxy.KEY_PAGE_TITLE);
        this.mLandingPageType = getIntent().getIntExtra(AdWebViewActivityProxy.KEY_LANDING_PAGE_TYPE, 0);
        this.mPageUrl = getIntent().getStringExtra(AdWebViewActivityProxy.KEY_PAGE_URL);
    }

    @Override // com.kwad.components.core.proxy.f
    public void initView() {
        setContentView(R.layout.ksad_activity_merchant);
        initContentView();
        getActivity().getWindow().getDecorView().setSystemUiVisibility(0);
    }

    private void initContentView() {
        com.kwad.sdk.core.d.c.d(TAG, "initContentView call mLandingPageType: " + this.mLandingPageType);
        this.mRootContainer = (ViewGroup) findViewById(R.id.ksad_land_page_root);
        AdWebViewActivityProxy.a aVarUm = new AdWebViewActivityProxy.a.C0449a().aW(this.mPageTitle).aX(this.mPageUrl).bl(this.mLandingPageType).um();
        f fVar = new f(this.mContext);
        fVar.c(this.mContext, aVarUm);
        fVar.b(getActivity());
        this.mMerchantLandingPageView = fVar;
        this.mRootContainer.addView(fVar);
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onDestroy() {
        super.onDestroy();
    }
}
