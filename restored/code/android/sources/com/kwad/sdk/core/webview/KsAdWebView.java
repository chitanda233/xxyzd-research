package com.kwad.sdk.core.webview;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.webkit.DownloadListener;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import com.bykv.vk.component.ttvideo.player.C;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.cd;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class KsAdWebView extends com.kwad.sdk.core.webview.c {
    private long HC;
    private com.kwad.sdk.core.webview.a.c.a ND;
    private com.kwad.sdk.core.webview.a.c bcc;
    private String bcd;
    private boolean bce;
    private com.kwad.sdk.core.webview.d bcf;
    private String mUniqueId;

    public interface b {
        void onFailed();

        void onSuccess();
    }

    public interface c {
        void uG();
    }

    public interface d {
        boolean shouldOverrideUrlLoading(WebView webView, String str);
    }

    public interface e {
        void onPageFinished();

        void onPageStart();

        void onReceivedHttpError(int i, String str, String str2);
    }

    private void setAccessibilityStateDisable(Context context) {
    }

    public KsAdWebView(Context context) {
        super(context);
        this.bce = false;
        init(context);
    }

    public KsAdWebView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.bce = false;
        init(context);
    }

    public KsAdWebView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.bce = false;
        init(context);
    }

    public KsAdWebView(Context context, AttributeSet attributeSet, int i, boolean z) {
        super(context, attributeSet, i, z);
        this.bce = false;
        init(context);
    }

    public void setClientConfig(com.kwad.sdk.core.webview.a.c.a aVar) {
        this.bcc.setClientConfig(aVar);
        com.kwad.sdk.core.webview.a.c.a aVar2 = this.ND;
        if (aVar2 == null || !aVar2.PM()) {
            return;
        }
        this.bcf = new com.kwad.sdk.core.webview.d();
    }

    @Override // android.webkit.WebView, android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        com.kwad.sdk.core.webview.a.c.a aVar;
        if (motionEvent.getAction() == 1 && (aVar = this.ND) != null) {
            aVar.aO(System.currentTimeMillis());
        }
        return super.onTouchEvent(motionEvent);
    }

    public String getUniqueId() {
        return this.mUniqueId;
    }

    public String getLoadUrl() {
        return this.bcd;
    }

    public long getLoadTime() {
        return this.HC;
    }

    public com.kwad.sdk.core.webview.a.c.a getClientConfig() {
        return this.ND;
    }

    @Override // android.webkit.WebView
    public void loadUrl(String str) {
        a(getContext(), getSettings());
        com.kwad.sdk.core.webview.b.c.b.fR(this.mUniqueId);
        this.bcd = str;
        this.HC = System.currentTimeMillis();
        super.loadUrl(str);
    }

    private void init(Context context) {
        com.kwad.sdk.core.d.c.i("KsAdWebView", "init");
        setAccessibilityStateDisable(context);
        WebSettings webSettingsB = cd.b(this);
        webSettingsB.setUseWideViewPort(true);
        webSettingsB.setDomStorageEnabled(true);
        setVerticalScrollBarEnabled(false);
        com.kwad.sdk.core.webview.a.c cVar = new com.kwad.sdk.core.webview.a.c() { // from class: com.kwad.sdk.core.webview.KsAdWebView.1
            @Override // com.kwad.sdk.core.webview.a.c, android.webkit.WebViewClient
            public final void onReceivedError(WebView webView, int i, String str, String str2) {
                super.onReceivedError(webView, i, str, str2);
                if (KsAdWebView.this.bcf != null) {
                    com.kwad.sdk.core.webview.d unused = KsAdWebView.this.bcf;
                    com.kwad.sdk.core.webview.d.d(KsAdWebView.this.ND);
                }
            }

            @Override // com.kwad.sdk.core.webview.a.c, android.webkit.WebViewClient
            public final void onPageFinished(WebView webView, String str) {
                super.onPageFinished(webView, str);
                if (KsAdWebView.this.bcf != null) {
                    KsAdWebView.this.bcf.c(KsAdWebView.this.ND);
                }
                if (KsAdWebView.this.bcf == null || KsAdWebView.this.bce || KsAdWebView.this.getProgress() < 100) {
                    return;
                }
                KsAdWebView.this.bcf.e(KsAdWebView.this.ND);
            }
        };
        this.bcc = cVar;
        cVar.Q(this.mUniqueId);
        setWebViewClient(this.bcc);
        setWebChromeClient(new com.kwad.sdk.core.webview.a.b());
        setDownloadListener(new a(this, (byte) 0));
        this.ND = new com.kwad.sdk.core.webview.a.c.a(getContext());
    }

    private void a(Context context, WebSettings webSettings) {
        boolean zPO;
        boolean zPP;
        String userAgentString = webSettings.getUserAgentString();
        com.kwad.sdk.core.webview.a.c.a aVar = this.ND;
        if (aVar != null) {
            zPO = aVar.PO();
            zPP = this.ND.PP();
        } else {
            zPO = false;
            zPP = false;
        }
        com.kwad.sdk.core.i.c cVarK = com.kwad.sdk.core.i.a.k(zPO, zPP);
        com.kwad.sdk.core.d.c.d("KsAdWebView", "setWebViewUserAgent: uaGetter：" + cVarK);
        String str = userAgentString + cVarK.cd(context);
        com.kwad.sdk.core.d.c.d("KsAdWebView", "setWebViewUserAgent: " + str);
        webSettings.setUserAgentString(str);
    }

    @Override // android.webkit.WebView
    public void setWebViewClient(WebViewClient webViewClient) {
        if (com.kwad.framework.a.a.oV.booleanValue() && !(webViewClient instanceof com.kwad.sdk.core.webview.a.a)) {
            throw new IllegalArgumentException("Not supported set webViewClient, please check it");
        }
        super.setWebViewClient(webViewClient);
    }

    @Override // android.webkit.WebView
    public void setWebChromeClient(WebChromeClient webChromeClient) {
        if (com.kwad.framework.a.a.oV.booleanValue() && !(webChromeClient instanceof com.kwad.sdk.core.webview.a.b)) {
            throw new IllegalArgumentException("client is not instanceof KSWebChromeClient");
        }
        super.setWebChromeClient(webChromeClient);
    }

    @Override // com.kwad.sdk.core.webview.c, android.webkit.WebView
    public void destroy() {
        this.bce = true;
        super.destroy();
        com.kwad.sdk.core.webview.a.c.a aVar = this.ND;
        if (aVar != null) {
            aVar.release();
            this.ND = null;
        }
        com.kwad.sdk.core.webview.a.c cVar = this.bcc;
        if (cVar != null) {
            cVar.destroy();
            this.bcc = null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.sdk.core.webview.a.c.a getReadyClientConfig() {
        com.kwad.sdk.core.webview.a.c cVar = this.bcc;
        if (cVar == null || cVar.getClientConfig() == null) {
            return null;
        }
        return this.bcc.getClientConfig();
    }

    public final void onActivityCreate() {
        com.kwad.sdk.core.webview.d dVar = this.bcf;
        if (dVar != null) {
            dVar.a(this.ND);
        }
    }

    public final void onActivityDestroy() {
        this.bce = true;
        release();
        com.kwad.sdk.core.webview.d dVar = this.bcf;
        if (dVar != null) {
            dVar.b(this.ND);
        }
    }

    class a implements DownloadListener {
        private a() {
        }

        /* synthetic */ a(KsAdWebView ksAdWebView, byte b) {
            this();
        }

        @Override // android.webkit.DownloadListener
        public final void onDownloadStart(String str, String str2, String str3, String str4, long j) {
            boolean zR = cb.r(KsAdWebView.this, 100);
            com.kwad.sdk.core.d.c.d("KsAdWebView", "onDownloadStart: currentVisible " + zR);
            if (zR) {
                if (KsAdWebView.this.ND == null || KsAdWebView.this.ND.PN()) {
                    if (KsAdWebView.this.ND != null && KsAdWebView.this.ND.getAdTemplate() != null && KsAdWebView.this.ND.PL()) {
                        com.kwad.sdk.core.response.helper.e.eM(KsAdWebView.this.ND.getAdTemplate()).adConversionInfo.appDownloadUrl = str;
                        KsAdWebView.this.ND.getAdTemplate().isWebViewDownload = true;
                        com.kwad.sdk.core.webview.a.c.a readyClientConfig = KsAdWebView.this.getReadyClientConfig();
                        if (readyClientConfig != null) {
                            readyClientConfig.fm(KsAdWebView.this.ND.getAdTemplate());
                        }
                        ((com.kwad.sdk.service.a.a) ServiceProvider.get(com.kwad.sdk.service.a.a.class)).k(m.wrapContextIfNeed(KsAdWebView.this.getContext()), KsAdWebView.this.ND.getAdTemplate());
                        return;
                    }
                    try {
                        Intent intent = new Intent("android.intent.action.VIEW", Uri.parse(str));
                        intent.setFlags(C.ENCODING_PCM_MU_LAW);
                        KsAdWebView.this.getContext().startActivity(intent);
                    } catch (Exception e) {
                        com.kwad.sdk.core.d.c.printStackTrace(e);
                    }
                }
            }
        }
    }

    @Override // android.webkit.WebView, android.view.View
    protected void onScrollChanged(int i, int i2, int i3, int i4) {
        super.onScrollChanged(i, i2, i3, i4);
        com.kwad.sdk.core.webview.a.c.a aVar = this.ND;
        if (aVar == null || aVar.uF() == null) {
            return;
        }
        this.ND.uF().uG();
    }
}
