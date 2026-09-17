package com.sigmob.sdk.base.common;

import android.app.ActionBar;
import android.app.Activity;
import android.content.Context;
import android.content.res.Configuration;
import android.net.Uri;
import android.os.Bundle;
import android.util.Base64;
import android.view.MotionEvent;
import android.view.View;
import android.webkit.ConsoleMessage;
import android.webkit.DownloadListener;
import android.webkit.WebChromeClient;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import androidx.core.app.NotificationCompat;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.LinkAction;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.windad.WindAdRequest;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class w extends j {
    private static final String g = "w";
    com.sigmob.sdk.base.views.g f;
    private int h;
    private final BaseAdUnit i;
    private RelativeLayout j;
    private TextView k;
    private ImageView l;
    private String m;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.w$1, reason: invalid class name */
    class AnonymousClass1 extends com.sigmob.sdk.base.l {
        AnonymousClass1() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setUrl(str);
            }
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
            ad.a("h5_error", "landpage", errorCode, failingUrl + " error:" + description, (WindAdRequest) null, (LoadAdRequest) null, w.this.i, (ad.a) null);
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, WebResourceRequest request, WebResourceError error) {
            SigmobLog.i("onReceivedError:" + error.toString());
            ad.a("h5_error", "landpage", 0, request.getUrl() + " error:" + ((Object) error.getDescription()), (WindAdRequest) null, (LoadAdRequest) null, w.this.i, (ad.a) null);
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedHttpError(WebView view, WebResourceRequest request, WebResourceResponse errorResponse) {
            ad.a("h5_error", "landpage", errorResponse.getStatusCode(), request.getUrl().toString(), (WindAdRequest) null, (LoadAdRequest) null, w.this.i, (ad.a) null);
        }

        @Override // android.webkit.WebViewClient
        public boolean shouldOverrideUrlLoading(WebView view, String url) {
            try {
                Context context = view.getContext();
                Uri uri = Uri.parse(url);
                String scheme = uri.getScheme();
                String host = uri.getHost();
                if (StringUtil.scheme().equalsIgnoreCase(scheme) && !com.sigmob.sdk.base.utils.s.a((CharSequence) host) && ("track".equals(host) || "active".equals(host))) {
                    String queryParameter = uri.getQueryParameter("data");
                    String queryParameter2 = uri.getQueryParameter(NotificationCompat.CATEGORY_EVENT);
                    if (!com.sigmob.sdk.base.utils.s.a((CharSequence) queryParameter2) && !com.sigmob.sdk.base.utils.s.a((CharSequence) queryParameter)) {
                        final String str = new String(Base64.decode(queryParameter, 0), "utf-8");
                        ad.a(host, queryParameter2, w.this.i, new ad.a() { // from class: com.sigmob.sdk.base.common.w$1$$ExternalSyntheticLambda0
                            @Override // com.sigmob.sdk.base.common.ad.a
                            public final void onAddExtra(Object obj) {
                                w.AnonymousClass1.a(str, obj);
                            }
                        });
                    }
                    return true;
                }
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) scheme)) {
                    SigmobLog.i("load Url: " + url);
                    view.loadUrl(url);
                } else {
                    LinkAction linkActionA = com.sigmob.sdk.videoplayer.c.a(w.this.i.getAdLinkActions(), uri);
                    if (linkActionA == null) {
                        linkActionA = com.sigmob.sdk.videoplayer.c.a(w.this.i.getSlotAdLinkActions(), uri);
                    }
                    boolean zHasReachedMaxRedirectCount = w.this.i.hasReachedMaxRedirectCount();
                    int quickAppMaxRedirectCount = w.this.i.getQuickAppMaxRedirectCount();
                    if (zHasReachedMaxRedirectCount) {
                        com.sigmob.sdk.base.utils.k.e(w.g, "reach max redirect count(%d).", Integer.valueOf(quickAppMaxRedirectCount));
                        return true;
                    }
                    int redirectCount = w.this.i.getRedirectCount(uri);
                    if (linkActionA != null && linkActionA.redirect_count.intValue() <= redirectCount) {
                        com.sigmob.sdk.base.utils.k.e(w.g, "%s reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                        return true;
                    }
                    if (!com.sigmob.sdk.base.utils.s.a(host, "hapjs.org") || (!scheme.equalsIgnoreCase("http") && !scheme.equalsIgnoreCase("https"))) {
                        w.this.i.addRedirectCount(uri);
                        w.this.i.incrementRedirectCount();
                        com.sigmob.sdk.base.utils.h.a(context, uri, com.sigmob.sdk.base.utils.s.a(host, "hapjs.org") ? com.sigmob.sdk.b.a() : com.sigmob.sdk.base.utils.h.a(context, uri, w.this.i.getMarketPackageNameList()));
                        ad.a(com.sigmob.sdk.base.a.LAND_PAGE, "click", w.this.i, "1", url, w.this.m, 0L, (JSONObject) null);
                        com.sigmob.sdk.base.utils.k.c(w.g, "%s(quick) not reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                        return true;
                    }
                    view.loadUrl(url);
                    com.sigmob.sdk.base.utils.k.c(w.g, "%s(302) not reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                }
                return true;
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.w$4, reason: invalid class name */
    static /* synthetic */ class AnonymousClass4 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3204a;

        static {
            int[] iArr = new int[ConsoleMessage.MessageLevel.values().length];
            f3204a = iArr;
            try {
                iArr[ConsoleMessage.MessageLevel.ERROR.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
        }
    }

    public w(Activity activity, BaseAdUnit baseAdUnit, Bundle intentExtras, Bundle savedInstanceState, String broadcastIdentifier, k controllerListener) {
        super(activity, broadcastIdentifier, controllerListener);
        this.i = baseAdUnit;
        if (baseAdUnit != null) {
            n().requestWindowFeature(8);
        } else {
            a(IntentActions.ACTION_INTERSTITIAL_FAIL);
            k().a();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        k().a();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setCoordinate(str);
        }
    }

    private void a(String subCategory, String cate, BaseAdUnit adUnit, final String coordinate) {
        ad.a(cate, subCategory, adUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.w$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                w.a(coordinate, obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, String str2, String str3, String str4, long j) {
        q.a(str, this.i);
        ad.a(com.sigmob.sdk.base.a.LAND_PAGE, "click", this.i, "0", str, this.m, 0L, (JSONObject) null);
        SigmobLog.d("onDownloadStart() called with: url = [" + str + "], userAgent = [" + str2 + "], contentDisposition = [" + str3 + "], mimetype = [" + str4 + "], contentLength = [" + j + "]");
    }

    private void p() {
        if (this.f == null) {
            try {
                com.sigmob.sdk.base.views.g gVar = new com.sigmob.sdk.base.views.g(n());
                this.f = gVar;
                gVar.setScrollBarStyle(0);
                this.f.setAdUnit(this.i);
                this.f.setWebViewClient(new AnonymousClass1());
                this.f.setWebChromeClient(new WebChromeClient() { // from class: com.sigmob.sdk.base.common.w.2
                    @Override // android.webkit.WebChromeClient
                    public boolean onConsoleMessage(ConsoleMessage consoleMessage) {
                        if (AnonymousClass4.f3204a[consoleMessage.messageLevel().ordinal()] != 1) {
                            return false;
                        }
                        SigmobLog.e("onConsoleMessage " + consoleMessage.message());
                        ad.a("h5_error", "landpage", 0, consoleMessage.message(), (WindAdRequest) null, (LoadAdRequest) null, w.this.i, (ad.a) null);
                        return false;
                    }

                    @Override // android.webkit.WebChromeClient
                    public void onReceivedTitle(WebView view, String title) {
                        if (title == null || title.isEmpty() || title.startsWith("http") || title.length() > 10) {
                            if (w.this.k != null) {
                                w.this.k.setVisibility(8);
                            }
                        } else if (w.this.k != null) {
                            w.this.k.setVisibility(0);
                            w.this.k.setText(title);
                        }
                    }
                });
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
                this.d.a();
            }
        }
        LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(-1, -1);
        LinearLayout linearLayout = new LinearLayout(n());
        linearLayout.addView(this.f, 0, layoutParams);
        this.d.onSetContentView(linearLayout);
        if (!this.i.isDisable_download_listener()) {
            this.f.setDownloadListener(new DownloadListener() { // from class: com.sigmob.sdk.base.common.w$$ExternalSyntheticLambda0
                @Override // android.webkit.DownloadListener
                public final void onDownloadStart(String str, String str2, String str3, String str4, long j) {
                    this.f$0.a(str, str2, str3, str4, j);
                }
            });
        }
        this.f.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.base.common.w.3

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            MotionEvent f3203a = null;

            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View v, MotionEvent event) {
                SigmobLog.d(event.toString());
                if (event.getAction() == 0) {
                    this.f3203a = MotionEvent.obtain(event);
                    return false;
                }
                if (event.getAction() != 1) {
                    return false;
                }
                MotionEvent motionEvent = this.f3203a;
                if (motionEvent == null) {
                    w.this.m = SigMacroCommon.getCoordinate(event, event, true);
                    return false;
                }
                w.this.m = SigMacroCommon.getCoordinate(motionEvent, event, true);
                return false;
            }
        });
    }

    private void q() {
        if (this.j == null) {
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
            layoutParams.addRule(13);
            int iDipsToIntPixels = Dips.dipsToIntPixels(20.0f, this.f3184a);
            RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
            layoutParams2.addRule(15);
            layoutParams2.addRule(9);
            int i = iDipsToIntPixels / 2;
            layoutParams2.setMargins(i, i, 0, 0);
            ImageView imageView = new ImageView(this.f3184a);
            this.l = imageView;
            imageView.setImageBitmap(com.sigmob.sdk.base.views.s.BACK.a());
            this.l.setScaleType(ImageView.ScaleType.CENTER_CROP);
            this.l.setClickable(true);
            this.l.setId(ClientMetadata.generateViewId());
            this.l.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.base.common.w$$ExternalSyntheticLambda1
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    this.f$0.a(view);
                }
            });
            RelativeLayout relativeLayout = new RelativeLayout(l());
            this.j = relativeLayout;
            relativeLayout.setLayoutParams(layoutParams);
            this.j.setBackgroundColor(-1);
            this.j.addView(this.l, layoutParams2);
            TextView textView = new TextView(this.f3184a);
            this.k = textView;
            textView.setTextColor(-16777216);
            this.k.setTextSize(18.0f);
            this.k.setVisibility(8);
            RelativeLayout.LayoutParams layoutParams3 = new RelativeLayout.LayoutParams(-2, -2);
            layoutParams3.addRule(13);
            this.j.addView(this.k, layoutParams3);
        }
    }

    private void r() {
        ActionBar.LayoutParams layoutParams = new ActionBar.LayoutParams(-1, -1, 17);
        ActionBar actionBar = n().getActionBar();
        if (actionBar == null) {
            return;
        }
        q();
        actionBar.setCustomView(this.j, layoutParams);
        actionBar.setDisplayOptions(16);
        actionBar.setDisplayShowCustomEnabled(true);
        actionBar.setDisplayShowHomeEnabled(false);
        actionBar.setDisplayShowTitleEnabled(false);
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Configuration configuration) {
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Bundle outState) {
    }

    @Override // com.sigmob.sdk.base.common.j
    public void e() {
        int iC = com.sigmob.sdk.base.k.c();
        if (iC > 0) {
            n().getTheme().applyStyle(iC, true);
        }
        n().getWindow().addFlags(1024);
        r();
        p();
        String strMacroProcess = this.i.getMacroCommon().macroProcess(this.i.getMaterial().landing_page);
        String landUrl = this.i.getLandUrl();
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) landUrl)) {
            this.f.loadUrl(strMacroProcess);
        } else {
            this.f.loadUrl(landUrl);
        }
        a(IntentActions.ACTION_LANDPAGE_SHOW);
    }

    @Override // com.sigmob.sdk.base.common.j
    public void f() {
    }

    @Override // com.sigmob.sdk.base.common.j
    public void g() {
        com.sigmob.sdk.base.views.g gVar = this.f;
        if (gVar != null) {
            gVar.resumeTimers();
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public void h() {
        a(IntentActions.ACTION_LANDPAGE_DISMISS);
        ImageView imageView = this.l;
        if (imageView != null) {
            imageView.setOnClickListener(null);
            this.l = null;
        }
        com.sigmob.sdk.base.views.g gVar = this.f;
        if (gVar != null) {
            gVar.destroy();
            this.f = null;
        }
        super.h();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void i() {
        if (j()) {
            k().a();
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public boolean j() {
        if (!this.f.canGoBack()) {
            return true;
        }
        this.f.goBack();
        return false;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void o() {
    }
}
