package com.sigmob.sdk.mraid2;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.webkit.JavascriptInterface;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebViewClient;
import android.widget.FrameLayout;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.views.at;
import com.sigmob.sdk.nativead.APKStatusBroadcastReceiver;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class x extends FrameLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static HashMap<String, com.sigmob.sdk.mraid.n> f3556a = new LinkedHashMap();
    private static final String b = "WebAdContainer";
    private final Map<String, APKStatusBroadcastReceiver> c;
    private com.sigmob.sdk.base.views.g d;

    private class a {
        public a() {
        }

        @JavascriptInterface
        public int cancelDownloadTaskByVid(String vid) {
            BaseAdUnit baseAdUnitA = x.this.a(vid);
            com.sigmob.sdk.base.utils.k.c(x.b, "cancelDownloadTaskByVid: vid = " + vid + ", adUnit = " + baseAdUnitA, new Object[0]);
            Context context = x.this.getContext();
            if (context == null || baseAdUnitA == null || baseAdUnitA.getApkDownloadType() == 0) {
                return -1;
            }
            return com.sigmob.sdk.base.common.o.c(context, baseAdUnitA);
        }

        @JavascriptInterface
        public int getApKDownloadProcessId(String vid) {
            BaseAdUnit baseAdUnitA = x.this.a(vid);
            List<BaseAdUnit> adUnitList = x.this.getAdUnitList();
            if (baseAdUnitA == null && com.sigmob.sdk.base.utils.f.b(adUnitList)) {
                baseAdUnitA = adUnitList.get(0);
            }
            com.sigmob.sdk.base.utils.k.c(x.b, "getApKDownloadProcessId: vid = " + vid + ", adUnit = " + baseAdUnitA, new Object[0]);
            Context context = x.this.getContext();
            if (context == null || baseAdUnitA == null) {
                return -1;
            }
            long[] jArrA = baseAdUnitA.getApkDownloadType() == 0 ? com.sigmob.sdk.base.common.q.a(context, baseAdUnitA.getDownloadId()) : com.sigmob.sdk.base.common.o.d(context, baseAdUnitA);
            int i = (int) jArrA[2];
            if (i != 1) {
                if (i != 2) {
                    if (i != 4) {
                        return i != 8 ? -1 : 100;
                    }
                    return -2;
                }
                long j = jArrA[0];
                long j2 = jArrA[1];
                if (j2 != 0 && j != 0) {
                    return (int) ((j * 100) / j2);
                }
            }
            return 0;
        }

        @JavascriptInterface
        public int pauseDownloadByVid(String vid) {
            BaseAdUnit baseAdUnitA = x.this.a(vid);
            com.sigmob.sdk.base.utils.k.c(x.b, "pauseDownloadByVid: vid = " + vid + ", adUnit = " + baseAdUnitA, new Object[0]);
            if (x.this.getContext() == null || baseAdUnitA == null || baseAdUnitA.getApkDownloadType() == 0) {
                return -1;
            }
            return com.sigmob.sdk.base.common.o.a(x.this.getContext(), baseAdUnitA);
        }

        @JavascriptInterface
        public void registerDownloadEvent(String vid) {
            BaseAdUnit baseAdUnitA = x.this.a(vid);
            List<BaseAdUnit> adUnitList = x.this.getAdUnitList();
            if (baseAdUnitA == null && com.sigmob.sdk.base.utils.f.b(adUnitList)) {
                baseAdUnitA = adUnitList.get(0);
            }
            com.sigmob.sdk.base.utils.k.c(x.b, "registerDownloadEvent: vid = " + vid + ", adUnit = " + baseAdUnitA, new Object[0]);
            x.this.a(baseAdUnitA);
        }

        @JavascriptInterface
        public int resumeDownloadByVid(String vid) {
            BaseAdUnit baseAdUnitA = x.this.a(vid);
            com.sigmob.sdk.base.utils.k.c(x.b, "resumeDownloadByVid: vid = " + vid, new Object[0]);
            Context context = x.this.getContext();
            if (context == null || baseAdUnitA == null || baseAdUnitA.getApkDownloadType() == 0) {
                return -1;
            }
            return com.sigmob.sdk.base.common.o.b(context, baseAdUnitA);
        }
    }

    public x(Context context) {
        super(context);
        this.c = new HashMap();
        com.sigmob.sdk.base.views.g gVarA = at.a().a(context);
        this.d = gVarA;
        if (gVarA == null) {
            this.d = new com.sigmob.sdk.base.views.g(context);
        }
        this.d.addJavascriptInterface(new a(), "sigandroidapk");
        addView(this.d, new FrameLayout.LayoutParams(-1, -1));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public BaseAdUnit a(String vid) {
        Ad ad;
        List<BaseAdUnit> adUnitList = getAdUnitList();
        if (!com.sigmob.sdk.base.utils.f.b(adUnitList)) {
            return null;
        }
        for (BaseAdUnit baseAdUnit : adUnitList) {
            if (baseAdUnit != null && (ad = baseAdUnit.getAd()) != null && com.sigmob.sdk.base.utils.s.a((CharSequence) ad.vid, (CharSequence) vid)) {
                return baseAdUnit;
            }
        }
        return null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(String str) {
        a("mraidbridge.notifyApkDownloadStateEvent(\"" + str + "\");", (ValueCallback<String>) null);
    }

    public void a(BaseAdUnit baseAdUnit) {
        if (baseAdUnit == null) {
            return;
        }
        String uuid = baseAdUnit.getUuid();
        if (this.c.get(uuid) == null) {
            APKStatusBroadcastReceiver aPKStatusBroadcastReceiver = new APKStatusBroadcastReceiver(new com.sigmob.sdk.base.common.b() { // from class: com.sigmob.sdk.mraid2.x.1
                @Override // com.sigmob.sdk.base.common.b
                public void a(boolean result) {
                    if (result) {
                        x.this.h();
                    } else {
                        x.this.e();
                    }
                }

                @Override // com.sigmob.sdk.base.common.b
                public void a(boolean result, long downloadId) {
                    if (result) {
                        x.this.d();
                    } else {
                        x.this.e();
                    }
                }

                @Override // com.sigmob.sdk.base.common.b
                public void b(boolean result) {
                    if (result) {
                        x.this.i();
                    } else {
                        x.this.e();
                    }
                }

                @Override // com.sigmob.sdk.base.common.b
                public void b(boolean result, long downloadId) {
                    if (result) {
                        x.this.g();
                    } else {
                        x.this.e();
                    }
                }

                @Override // com.sigmob.sdk.base.common.b
                public void c(boolean result, long downloadId) {
                    x.this.f();
                }
            }, uuid);
            aPKStatusBroadcastReceiver.a(aPKStatusBroadcastReceiver);
            this.c.put(uuid, aPKStatusBroadcastReceiver);
        }
    }

    void a(Object object, String name) {
        this.d.addJavascriptInterface(object, name);
    }

    void a(String javascript, ValueCallback<String> callback) {
        if (this.d == null) {
            return;
        }
        SigmobLog.d("Injecting Javascript into MRAID WebView:\n\t" + javascript);
        this.d.evaluateJavascript(javascript, callback);
    }

    void a(String baseUrl, String data, String mimeType, String encoding, String historyUrl) {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.loadDataWithBaseURL(baseUrl, data, mimeType, encoding, historyUrl);
    }

    void a(boolean enabled) {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.a(enabled);
    }

    public void b() {
        if (com.sigmob.sdk.base.utils.f.b(this.c)) {
            for (APKStatusBroadcastReceiver aPKStatusBroadcastReceiver : this.c.values()) {
                aPKStatusBroadcastReceiver.b(aPKStatusBroadcastReceiver);
            }
            this.c.clear();
        }
        if (com.sigmob.sdk.base.utils.f.b(f3556a)) {
            for (com.sigmob.sdk.mraid.n nVar : f3556a.values()) {
                if (nVar != null) {
                    nVar.b();
                }
            }
            f3556a.clear();
        }
        if (this.d != null) {
            at.a().a(this.d);
            this.d = null;
        }
        removeAllViews();
    }

    public void b(String javascript, ValueCallback callback) {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.evaluateJavascript(javascript, callback);
    }

    public void c(String url) {
        this.d.loadUrl(url);
    }

    void d() {
        d("download_start");
    }

    void d(final String state) {
        post(new Runnable() { // from class: com.sigmob.sdk.mraid2.x$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(state);
            }
        });
    }

    void e() {
        d("download_fail");
    }

    void f() {
        d("download_pause");
    }

    void g() {
        d(PointCategory.DOWNLOAD_END);
    }

    abstract List<BaseAdUnit> getAdUnitList();

    WebSettings getSettings() {
        return this.d.getSettings();
    }

    void h() {
        d(com.sigmob.sdk.base.common.a.E);
    }

    void i() {
        d("install_end");
    }

    public void j() {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.reload();
    }

    public void k() {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.stopLoading();
    }

    public void l() {
        this.d.resumeTimers();
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
    }

    @Override // android.view.View
    public void setBackground(Drawable background) {
        super.setBackground(background);
        this.d.setBackground(background);
    }

    @Override // android.view.View
    public void setBackgroundColor(int color) {
        super.setBackgroundColor(color);
        this.d.setBackgroundColor(color);
    }

    void setWebChromeClient(WebChromeClient webChromeClient) {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.setWebChromeClient(webChromeClient);
    }

    void setWebViewClient(WebViewClient webViewClient) {
        com.sigmob.sdk.base.views.g gVar = this.d;
        if (gVar == null) {
            return;
        }
        gVar.setWebViewClient(webViewClient);
    }
}
