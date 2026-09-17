package com.kwad.components.core.page;

import android.R;
import android.app.Activity;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import com.bykv.vk.component.ttvideo.player.C;
import com.kwad.components.core.c.h;
import com.kwad.components.core.innerEc.a.k;
import com.kwad.sdk.api.core.KsAdSdkDynamicImpl;
import com.kwad.sdk.api.proxy.app.AdWebViewActivity;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
@KsAdSdkDynamicImpl(AdWebViewActivity.class)
public class AdWebViewActivityProxy extends com.kwad.components.core.proxy.f {
    public static final String KEY_AD_RESULT_CACHE_IDX = "key_ad_result_cache_idx";
    public static final String KEY_AUTH_INNER_EC_CACHE_LISTENER_IDX = "key_auth_inner_ec_cache_listener_idx";
    private static final String KEY_H5_AUTH_URL = "key_h5_auth_url";
    public static final String KEY_IS_AUTO_SHOW = "key_is_auto_show";
    public static final String KEY_IS_HALF_PAGE = "key_is_half_page";
    public static final String KEY_LANDING_PAGE_TYPE = "key_landing_page_type";
    public static final String KEY_PAGE_TITLE = "key_page_title";
    public static final String KEY_PAGE_URL = "key_page_url";
    public static final String KEY_SHOW_PERMISSION = "key_show_permission";
    private static final String KEY_SHOW_TK_CONFIRM_DIALOG = "key_show_tk_confirm_dialog";
    public static final String KEY_TEMPLATE = "key_template_json";
    private static final String TAG = "AdWebViewActivityProxy";
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private h mAuthInnerEcCacheListener;
    private boolean mAutoShow;
    private com.kwad.components.core.r.b mDialogFragment;
    private boolean mDisableShowConfirmDialog;
    private View mFinalLandingView;
    private String mH5AuthUrl;
    private c mH5LoginPageView;
    private boolean mHasShowShowConfirmDialog;
    private boolean mIsHalfPage;
    private Dialog mKsExitInterceptDialog;
    private Dialog mKsExitInterceptDialogV2;
    private int mLandingPageType;
    private d mLandingPageView;
    private f mMerchantLandingPageView;
    private String mPageTitle;
    private String mPageUrl;
    private ViewGroup mRootContainer;
    private boolean mShowPermission;
    private volatile boolean destroyed = false;
    private com.kwad.sdk.core.webview.d.a.b mWebCardCloseListener = new com.kwad.sdk.core.webview.d.a.b() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.4
        @Override // com.kwad.sdk.core.webview.d.a.b
        public final void b(WebCloseStatus webCloseStatus) {
            AdWebViewActivityProxy.this.finish();
        }
    };
    private com.kwad.components.core.page.a.b mLandPageViewListener = new com.kwad.components.core.page.a.b() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.5
        @Override // com.kwad.components.core.page.a.b
        public final void uc() {
            AdWebViewActivityProxy.this.onBackPressed();
        }

        @Override // com.kwad.components.core.page.a.b
        public final void ud() {
            if (AdWebViewActivityProxy.this.mLandingPageView == null || !AdWebViewActivityProxy.this.mLandingPageView.getCanInterceptBackClick()) {
                if (!AdWebViewActivityProxy.this.mDisableShowConfirmDialog) {
                    if (AdWebViewActivityProxy.this.handleMiddlePageDialog()) {
                        return;
                    }
                    if (AdWebViewActivityProxy.this.mAdTemplate == null || !AdWebViewActivityProxy.this.mAdTemplate.mIsForceJumpLandingPage) {
                        if (AdWebViewActivityProxy.this.mAdTemplate == null || !com.kwad.sdk.core.response.helper.a.aU(com.kwad.sdk.core.response.helper.e.eM(AdWebViewActivityProxy.this.mAdTemplate)) || com.kwad.components.core.r.a.wy().wz() != 1 || !com.kwad.components.core.r.a.wy().wE() || com.kwad.components.core.r.a.wy().wB()) {
                            if (AdWebViewActivityProxy.this.isFormAdExitInterceptEnable()) {
                                AdWebViewActivityProxy.this.showDialog();
                                return;
                            } else {
                                AdWebViewActivityProxy.this.finish();
                                return;
                            }
                        }
                        if (com.kwad.components.core.r.a.wy().wA() || !com.kwad.sdk.core.config.e.JX()) {
                            AdWebViewActivityProxy.this.finish();
                            return;
                        }
                        AdWebViewActivityProxy adWebViewActivityProxy = AdWebViewActivityProxy.this;
                        adWebViewActivityProxy.mDialogFragment = adWebViewActivityProxy.getTkDialogFragment();
                        com.kwad.components.core.r.b.a(AdWebViewActivityProxy.this.mDialogFragment, AdWebViewActivityProxy.this.getActivity(), AdWebViewActivityProxy.this.mBaseDialogListener);
                        return;
                    }
                    AdWebViewActivityProxy.this.finish();
                    return;
                }
                AdWebViewActivityProxy.this.finish();
                return;
            }
            AdWebViewActivityProxy.this.mLandingPageView.uo();
        }
    };
    private com.kwad.components.core.webview.tachikoma.f.c mBaseDialogListener = new com.kwad.components.core.webview.tachikoma.f.c() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.6
        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public final void H(boolean z) {
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public final void ht() {
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public final void hk() {
            com.kwad.components.core.r.a.wy().bb(true);
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public final void hs() {
            com.kwad.components.core.r.a.wy().bb(false);
        }
    };

    @Override // com.kwad.components.core.proxy.f
    public int getLayoutId() {
        return 0;
    }

    @Override // com.kwad.components.core.proxy.f
    public String getPageName() {
        return TAG;
    }

    public static void register() {
        com.kwad.sdk.service.c.putComponentProxy(AdWebViewActivity.class, AdWebViewActivityProxy.class);
    }

    public static void launch(Context context, a aVar) {
        com.kwad.sdk.core.d.c.d(TAG, "launch: pageUrl: " + aVar.adq);
        boolean z = TextUtils.isEmpty(aVar.adq) && TextUtils.isEmpty(aVar.adw);
        if (context == null || z) {
            return;
        }
        try {
            com.kwad.sdk.commercial.f.a.k(aVar.getAdTemplate(), aVar.ug(), aVar.uf());
            com.kwad.sdk.service.c.putComponentProxy(AdWebViewActivity.class, AdWebViewActivityProxy.class);
            Intent intent = new Intent(context, (Class<?>) AdWebViewActivity.class);
            if (!(context instanceof Activity)) {
                intent.setFlags(C.ENCODING_PCM_MU_LAW);
            }
            intent.putExtra(KEY_PAGE_TITLE, aVar.adp);
            intent.putExtra(KEY_LANDING_PAGE_TYPE, aVar.adu);
            intent.putExtra(KEY_PAGE_URL, aVar.adq);
            intent.putExtra(KEY_H5_AUTH_URL, aVar.adw);
            intent.putExtra(KEY_IS_HALF_PAGE, aVar.adx);
            intent.putExtra(KEY_IS_AUTO_SHOW, aVar.adt);
            intent.putExtra(KEY_SHOW_PERMISSION, aVar.ads);
            intent.putExtra(KEY_SHOW_TK_CONFIRM_DIALOG, aVar.ui());
            final k kVarUl = aVar.ul();
            if (kVarUl != null) {
                intent.putExtra(KEY_AUTH_INNER_EC_CACHE_LISTENER_IDX, com.kwad.components.core.c.f.oR().a(new h() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.1
                    @Override // com.kwad.components.core.c.h
                    public final void oT() {
                        kVarUl.oT();
                    }

                    @Override // com.kwad.components.core.c.h
                    public final void oU() {
                        kVarUl.oU();
                    }

                    @Override // com.kwad.components.core.c.h
                    public final void k(int i, String str) {
                        kVarUl.k(i, str);
                    }

                    @Override // com.kwad.components.core.c.h
                    public final void oV() {
                        kVarUl.oV();
                    }
                }));
            }
            AdResultData adResultDataEx = aVar.adr;
            if (adResultDataEx == null) {
                adResultDataEx = com.kwad.sdk.core.response.helper.c.ex(aVar.adTemplate);
            }
            intent.putExtra("key_ad_result_cache_idx", com.kwad.components.core.c.f.oR().l(adResultDataEx));
            context.startActivity(intent);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            com.kwad.sdk.commercial.f.a.a(aVar.getAdTemplate(), aVar.ug(), aVar.uf(), by.y(th));
            if (o.GE().FG()) {
                ServiceProvider.reportSdkCaughtException(th);
                return;
            }
            throw th;
        }
    }

    public static void launch(Context context, AdTemplate adTemplate) {
        launch(context, new a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).um());
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onPreCreate(Bundle bundle) {
        super.onPreCreate(bundle);
        try {
            getIntent().removeExtra("key_template");
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        if (isMerchantH5()) {
            e.b(getWindow());
        }
    }

    @Override // com.kwad.components.core.proxy.f
    public void onActivityCreate() {
        super.onActivityCreate();
        if (isMerchantH5()) {
            getActivity().setTheme(R.style.Theme.Light.NoTitleBar);
        }
        com.kwad.sdk.commercial.f.a.l(this.mAdTemplate, this.mLandingPageType, this.mPageUrl);
    }

    @Override // com.kwad.components.core.proxy.f
    public boolean checkIntentData(Intent intent) {
        AdResultData adResultDataD = com.kwad.components.core.c.f.oR().d(getIntent().getIntExtra("key_ad_result_cache_idx", 0), true);
        this.mAdResultData = adResultDataD;
        if (adResultDataD == null) {
            return false;
        }
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultDataD);
        this.mAdTemplate = adTemplateR;
        return adTemplateR != null;
    }

    @Override // com.kwad.components.core.proxy.f
    public int onSetActivityTheme() {
        if (isMerchantH5()) {
            return -1;
        }
        return super.onSetActivityTheme();
    }

    @Override // com.kwad.components.core.proxy.f
    public void initView() {
        int i;
        if (isMerchantH5()) {
            i = com.kwad.sdk.R.layout.ksad_activity_merchant;
        } else {
            i = com.kwad.sdk.R.layout.ksad_activity_landpage;
        }
        setContentView(i);
        initContentView();
        if (isMerchantH5() && this.mRootView != null && isNeedAndroid15Adapt(this.mContext)) {
            this.mRootView.post(new bi() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (com.kwad.sdk.utils.e.r(AdWebViewActivityProxy.this.getActivity())) {
                        AdWebViewActivityProxy.this.mRootView.setPadding(0, 0, 0, com.kwad.sdk.utils.e.q(AdWebViewActivityProxy.this.getActivity()));
                    }
                }
            });
        }
    }

    private boolean isNeedAndroid15Adapt(Context context) {
        try {
            return Build.VERSION.SDK_INT >= 35 && context.getApplicationInfo().targetSdkVersion >= 35;
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.core.proxy.f
    public void initData() {
        this.destroyed = false;
        this.mPageTitle = getIntent().getStringExtra(KEY_PAGE_TITLE);
        this.mLandingPageType = getIntent().getIntExtra(KEY_LANDING_PAGE_TYPE, 0);
        this.mPageUrl = getIntent().getStringExtra(KEY_PAGE_URL);
        this.mAutoShow = getIntent().getBooleanExtra(KEY_IS_AUTO_SHOW, false);
        this.mShowPermission = getIntent().getBooleanExtra(KEY_SHOW_PERMISSION, false);
        this.mDisableShowConfirmDialog = getIntent().getBooleanExtra(KEY_SHOW_TK_CONFIRM_DIALOG, false);
        this.mH5AuthUrl = getIntent().getStringExtra(KEY_H5_AUTH_URL);
        this.mIsHalfPage = getIntent().getBooleanExtra(KEY_IS_HALF_PAGE, false);
        this.mAuthInnerEcCacheListener = com.kwad.components.core.c.f.oR().e(getIntent().getIntExtra(KEY_AUTH_INNER_EC_CACHE_LISTENER_IDX, 0), true);
    }

    private boolean isMerchantH5() {
        int landingPageTypeFromIntent = getLandingPageTypeFromIntent();
        com.kwad.sdk.core.d.c.d(TAG, "isMerchantH5: " + landingPageTypeFromIntent);
        return landingPageTypeFromIntent == 2;
    }

    private int getLandingPageTypeFromIntent() {
        return getIntent().getIntExtra(KEY_LANDING_PAGE_TYPE, 0);
    }

    @Override // com.kwad.components.core.proxy.f
    public boolean needAdaptionScreen() {
        return isMerchantH5();
    }

    private void initContentView() {
        com.kwad.sdk.core.d.c.d(TAG, "initContentView call mLandingPageType: " + this.mLandingPageType);
        this.mRootContainer = (ViewGroup) findViewById(com.kwad.sdk.R.id.ksad_land_page_root);
        int i = this.mLandingPageType;
        boolean z = i == 2 || i == 3;
        a aVarUm = new a.C0449a().aW(this.mPageTitle).aX(this.mPageUrl).aY(this.mH5AuthUrl).aU(this.mAdTemplate).aQ(this.mShowPermission).aR(this.mAutoShow).bl(this.mLandingPageType).aS(this.mDisableShowConfirmDialog).um();
        if (z) {
            f fVar = new f(this.mContext);
            fVar.c(this.mContext, aVarUm);
            fVar.b(getActivity());
            this.mFinalLandingView = fVar;
            this.mMerchantLandingPageView = fVar;
        } else {
            d dVarB = d.b(this.mContext, aVarUm);
            this.mLandingPageView = dVarB;
            dVarB.setLandPageViewListener(this.mLandPageViewListener);
            this.mLandingPageView.setWebCardCloseListener(this.mWebCardCloseListener);
            this.mFinalLandingView = this.mLandingPageView;
        }
        if (this.mLandingPageType == 3) {
            c cVarA = c.a(this.mContext, aVarUm);
            this.mH5LoginPageView = cVarA;
            cVarA.setH5AuthListener(new com.kwad.components.core.page.a.a() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.3
                @Override // com.kwad.components.core.page.a.a
                public final void tZ() {
                    com.kwad.sdk.core.d.c.d(AdWebViewActivityProxy.TAG, "mH5LoginPageView onGetCodeSuccess");
                    if (AdWebViewActivityProxy.this.mAuthInnerEcCacheListener != null) {
                        AdWebViewActivityProxy.this.mAuthInnerEcCacheListener.oT();
                    }
                }

                @Override // com.kwad.components.core.page.a.a
                public final void ua() {
                    com.kwad.sdk.core.d.c.d(AdWebViewActivityProxy.TAG, "mH5LoginPageView onGetUserInfoSuccess");
                    AdWebViewActivityProxy.this.mAdTemplate.isDoAuth = true;
                    if (AdWebViewActivityProxy.this.mAuthInnerEcCacheListener != null) {
                        AdWebViewActivityProxy.this.mAuthInnerEcCacheListener.oU();
                    }
                    if (!TextUtils.isEmpty(AdWebViewActivityProxy.this.mPageUrl)) {
                        AdWebViewActivityProxy.this.mH5LoginPageView.setVisibility(8);
                        AdWebViewActivityProxy.this.mRootContainer.removeView(AdWebViewActivityProxy.this.mH5LoginPageView);
                        com.kwad.sdk.core.d.c.d(AdWebViewActivityProxy.TAG, "after loading auth load landingView :" + AdWebViewActivityProxy.this.mFinalLandingView);
                        AdWebViewActivityProxy adWebViewActivityProxy = AdWebViewActivityProxy.this;
                        adWebViewActivityProxy.addLandingPageView(adWebViewActivityProxy.mFinalLandingView);
                        return;
                    }
                    AdWebViewActivityProxy.this.finish();
                }

                @Override // com.kwad.components.core.page.a.a
                public final void aP(boolean z2) {
                    com.kwad.sdk.core.d.c.d(AdWebViewActivityProxy.TAG, "mH5LoginPageView onGetUserInfoFail");
                    if (AdWebViewActivityProxy.this.mAuthInnerEcCacheListener != null) {
                        AdWebViewActivityProxy.this.mAuthInnerEcCacheListener.k(z2 ? 2001 : 2000, "h5 get code error");
                    }
                }

                @Override // com.kwad.components.core.page.a.a
                public final void ub() {
                    com.kwad.sdk.core.d.c.d(AdWebViewActivityProxy.TAG, "mH5LoginPageView onGetUserInfoCancel");
                    if (AdWebViewActivityProxy.this.mAuthInnerEcCacheListener != null) {
                        AdWebViewActivityProxy.this.mAuthInnerEcCacheListener.oV();
                    }
                }
            });
            this.mRootContainer.addView(this.mH5LoginPageView);
            return;
        }
        com.kwad.sdk.core.d.c.d(TAG, "direct add landingView :" + this.mFinalLandingView);
        addLandingPageView(this.mFinalLandingView);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void addLandingPageView(View view) {
        ViewGroup viewGroup = this.mRootContainer;
        if (viewGroup == null || view == null) {
            return;
        }
        viewGroup.addView(view);
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onResume() {
        super.onResume();
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onPause() {
        super.onPause();
        overridePendingTransition(0, 0);
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onDestroy() {
        try {
            this.destroyed = true;
            com.kwad.components.core.r.b bVar = this.mDialogFragment;
            if (bVar != null) {
                bVar.dismiss();
                this.mDialogFragment = null;
            }
            Dialog dialog = this.mKsExitInterceptDialog;
            if (dialog != null && dialog.isShowing()) {
                this.mKsExitInterceptDialog.dismiss();
            }
            Dialog dialog2 = this.mKsExitInterceptDialogV2;
            if (dialog2 != null && dialog2.isShowing()) {
                this.mKsExitInterceptDialogV2.dismiss();
            }
            super.onDestroy();
            AdTemplate adTemplate = this.mAdTemplate;
            if (adTemplate != null) {
                adTemplate.interactLandingPageShowing = false;
                this.mAdTemplate.mIsForceJumpLandingPage = false;
            }
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onBackPressed() {
        c cVar = this.mH5LoginPageView;
        if (cVar != null && cVar.getVisibility() == 0) {
            finish();
            return;
        }
        int i = this.mLandingPageType;
        if (i == 2 || i == 3) {
            finish();
            return;
        }
        d dVar = this.mLandingPageView;
        if (dVar != null && dVar.getCanInterceptBackClick()) {
            this.mLandingPageView.uo();
            return;
        }
        if (this.mDisableShowConfirmDialog) {
            finish();
            return;
        }
        if (handleMiddlePageDialog()) {
            return;
        }
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate == null || adTemplate.mIsForceJumpLandingPage) {
            super.onBackPressed();
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.aU(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)) && com.kwad.components.core.r.a.wy().wz() == 1 && com.kwad.components.core.r.a.wy().wE() && !com.kwad.components.core.r.a.wy().wB()) {
            if (com.kwad.components.core.r.a.wy().wA() || !com.kwad.sdk.core.config.e.JX()) {
                super.onBackPressed();
                return;
            }
            com.kwad.components.core.r.b tkDialogFragment = getTkDialogFragment();
            this.mDialogFragment = tkDialogFragment;
            com.kwad.components.core.r.b.a(tkDialogFragment, getActivity(), this.mBaseDialogListener);
            return;
        }
        if (isFormAdExitInterceptEnable()) {
            try {
                if (this.mKsExitInterceptDialogV2 == null) {
                    this.mKsExitInterceptDialogV2 = new com.kwad.components.core.page.widget.a(getActivity(), new com.kwad.components.core.page.widget.a.InterfaceC0453a() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.7
                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void a(DialogInterface dialogInterface) {
                            com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 104);
                            dialogInterface.dismiss();
                        }

                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void b(DialogInterface dialogInterface) {
                            if (!AdWebViewActivityProxy.this.destroyed) {
                                try {
                                    AdWebViewActivityProxy.super.onBackPressed();
                                } catch (Throwable th) {
                                    com.kwad.sdk.core.d.c.printStackTrace(th);
                                }
                            }
                            com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 105);
                        }

                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void c(DialogInterface dialogInterface) {
                            com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 106);
                            dialogInterface.dismiss();
                        }
                    });
                }
                com.kwad.sdk.core.adlog.c.b(this.mAdTemplate, 103, (JSONObject) null);
                this.mKsExitInterceptDialogV2.show();
                return;
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
        super.onBackPressed();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean handleMiddlePageDialog() {
        boolean z = false;
        if (this.mAdTemplate == null || !com.kwad.sdk.core.config.e.JX()) {
            return false;
        }
        if (!br.isNullString(com.kwad.sdk.core.response.helper.a.cH(this.mAdTemplate)) && com.kwad.sdk.core.response.helper.a.cG(this.mAdTemplate)) {
            z = true;
            if (this.mHasShowShowConfirmDialog) {
                try {
                    super.onBackPressed();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            } else {
                com.kwad.components.core.r.b tkDialogFragment = getTkDialogFragment();
                this.mDialogFragment = tkDialogFragment;
                com.kwad.components.core.r.b.a(tkDialogFragment, getActivity(), this.mBaseDialogListener);
                this.mHasShowShowConfirmDialog = true;
            }
        }
        return z;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean isFormAdExitInterceptEnable() {
        AdTemplate adTemplate;
        if (this.mShowPermission || (adTemplate = this.mAdTemplate) == null || com.kwad.sdk.core.response.helper.e.O(adTemplate)) {
            return false;
        }
        if (com.kwad.sdk.core.config.e.Kf() && this.mAdTemplate.mIsFromContent) {
            return true;
        }
        return com.kwad.sdk.core.config.e.Kg() && !this.mAdTemplate.mIsFromContent;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void showDialog() {
        if (this.mKsExitInterceptDialog == null) {
            this.mKsExitInterceptDialog = buildDialog();
        }
        com.kwad.sdk.core.adlog.c.b(this.mAdTemplate, 103, (JSONObject) null);
        this.mKsExitInterceptDialog.show();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.r.b getTkDialogFragment() {
        com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
        bVar.a(this.mAdResultData);
        bVar.bN(com.kwad.sdk.core.response.helper.b.en(this.mAdTemplate));
        bVar.bo(false);
        bVar.bp(true);
        return com.kwad.components.core.r.b.a(bVar);
    }

    private com.kwad.components.core.page.widget.a buildDialog() {
        return new com.kwad.components.core.page.widget.a(getActivity(), new com.kwad.components.core.page.widget.a.InterfaceC0453a() { // from class: com.kwad.components.core.page.AdWebViewActivityProxy.8
            @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
            public final void a(DialogInterface dialogInterface) {
                com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 104);
                dialogInterface.dismiss();
            }

            @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
            public final void b(DialogInterface dialogInterface) {
                try {
                    AdWebViewActivityProxy.super.onBackPressed();
                } catch (Throwable unused) {
                }
                com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 105);
            }

            @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
            public final void c(DialogInterface dialogInterface) {
                com.kwad.sdk.core.adlog.c.s(AdWebViewActivityProxy.this.mAdTemplate, 106);
                dialogInterface.dismiss();
            }
        });
    }

    public static class a {
        private AdTemplate adTemplate;
        private String adp;
        private String adq;
        private AdResultData adr;
        private boolean ads;
        private boolean adt;
        private int adu;
        private boolean adv;
        private String adw;
        private boolean adx;
        private k ady;

        /* synthetic */ a(String str, String str2, AdResultData adResultData, boolean z, boolean z2, boolean z3, int i, byte b) {
            this(str, str2, adResultData, z, z2, z3, i);
        }

        /* synthetic */ a(String str, String str2, AdTemplate adTemplate, boolean z, boolean z2, boolean z3, int i, byte b) {
            this(str, str2, adTemplate, z, z2, z3, i);
        }

        private a(String str, String str2, AdTemplate adTemplate, boolean z, boolean z2, boolean z3, int i) {
            this(str, str2, z, z2, z3, i);
            this.adTemplate = adTemplate;
        }

        private a(String str, String str2, AdResultData adResultData, boolean z, boolean z2, boolean z3, int i) {
            this(str, str2, z, z2, z3, i);
            this.adr = adResultData;
            this.adTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
        }

        private a(String str, String str2, boolean z, boolean z2, boolean z3, int i) {
            this.adp = str;
            this.adq = str2;
            this.ads = z;
            this.adt = z2;
            this.adv = z3;
            this.adu = i;
        }

        public final String ue() {
            return this.adp;
        }

        public final String uf() {
            return this.adq;
        }

        public final AdTemplate getAdTemplate() {
            return this.adTemplate;
        }

        public final int ug() {
            return this.adu;
        }

        public final boolean uh() {
            return this.ads;
        }

        public final boolean ui() {
            return this.adv;
        }

        public final boolean uj() {
            return this.adt;
        }

        public final String uk() {
            return this.adw;
        }

        public final k ul() {
            return this.ady;
        }

        public final void a(k kVar) {
            this.ady = kVar;
        }

        /* JADX INFO: renamed from: com.kwad.components.core.page.AdWebViewActivityProxy$a$a, reason: collision with other inner class name */
        public static class C0449a {
            private AdTemplate adTemplate;
            private String adp;
            private String adq;
            private AdResultData adr;
            private boolean adt;
            private int adu = 0;
            private boolean adv;
            private String adw;
            private boolean adx;
            private k ady;
            private boolean adz;

            public final C0449a aQ(boolean z) {
                this.adz = z;
                return this;
            }

            public final C0449a bl(int i) {
                this.adu = i;
                return this;
            }

            public final C0449a aW(String str) {
                this.adp = str;
                return this;
            }

            public final C0449a aX(String str) {
                this.adq = str;
                return this;
            }

            public final C0449a q(AdResultData adResultData) {
                this.adr = adResultData;
                return this;
            }

            public final C0449a aU(AdTemplate adTemplate) {
                this.adTemplate = adTemplate;
                return this;
            }

            public final C0449a aR(boolean z) {
                this.adt = z;
                return this;
            }

            public final C0449a aS(boolean z) {
                this.adv = z;
                return this;
            }

            public final C0449a aY(String str) {
                this.adw = str;
                return this;
            }

            public final C0449a b(k kVar) {
                this.ady = kVar;
                return this;
            }

            public final a um() {
                a aVar;
                if (this.adr != null) {
                    aVar = new a(this.adp, this.adq, this.adr, this.adz, this.adt, this.adv, this.adu, (byte) 0);
                } else {
                    aVar = new a(this.adp, this.adq, this.adTemplate, this.adz, this.adt, this.adv, this.adu, (byte) 0);
                }
                aVar.adw = this.adw;
                aVar.adx = this.adx;
                k kVar = this.ady;
                if (kVar != null) {
                    aVar.a(kVar);
                }
                return aVar;
            }
        }
    }
}
