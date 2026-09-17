package com.kwad.sdk.core.webview.a;

import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.net.Uri;
import android.net.http.SslError;
import android.text.TextUtils;
import android.webkit.RenderProcessGoneDetail;
import android.webkit.SslErrorHandler;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public class c extends com.kwad.sdk.core.webview.a.a {
    private a ND;
    private boolean bcm = false;
    private boolean bcn = false;
    private boolean bco = false;
    private boolean bcp = false;
    private boolean aeL = false;

    public final void Q(String str) {
        this.mUniqueId = str;
    }

    @Override // android.webkit.WebViewClient
    public boolean onRenderProcessGone(WebView webView, RenderProcessGoneDetail renderProcessGoneDetail) {
        return (renderProcessGoneDetail != null && renderProcessGoneDetail.didCrash()) || super.onRenderProcessGone(webView, renderProcessGoneDetail);
    }

    @Override // android.webkit.WebViewClient
    public void onReceivedError(WebView webView, int i, String str, String str2) {
        super.onReceivedError(webView, i, str, str2);
        com.kwad.sdk.core.d.c.d("KsAdWebViewClient", "onReceivedError " + i);
        a aVar = this.ND;
        if (aVar != null && aVar.jE() != null) {
            this.ND.jE().onReceivedHttpError(i, str, str2);
        }
        com.kwad.sdk.core.webview.b.c.b.ai(str2, str);
    }

    @Override // android.webkit.WebViewClient
    public void onReceivedHttpError(WebView webView, WebResourceRequest webResourceRequest, WebResourceResponse webResourceResponse) {
        super.onReceivedHttpError(webView, webResourceRequest, webResourceResponse);
        try {
            String string = webResourceRequest.getUrl().toString();
            int statusCode = webResourceResponse.getStatusCode();
            a aVar = this.ND;
            if (aVar == null || aVar.jE() == null) {
                return;
            }
            this.ND.jE().onReceivedHttpError(statusCode, "http errorCode: " + statusCode, string);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // android.webkit.WebViewClient
    public void onReceivedSslError(WebView webView, SslErrorHandler sslErrorHandler, SslError sslError) {
        super.onReceivedSslError(webView, sslErrorHandler, sslError);
        try {
            String url = sslError.getUrl();
            int primaryError = sslError.getPrimaryError();
            a aVar = this.ND;
            if (aVar == null || aVar.jE() == null) {
                return;
            }
            this.ND.jE().onReceivedHttpError(primaryError, "SSL errorCode: " + primaryError, url);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // android.webkit.WebViewClient
    public void onPageStarted(WebView webView, String str, Bitmap bitmap) {
        super.onPageStarted(webView, str, bitmap);
        com.kwad.sdk.core.webview.b.c.b.ag(this.mUniqueId, "onPageStart");
        a aVar = this.ND;
        if (aVar == null || aVar.jE() == null) {
            return;
        }
        this.ND.jE().onPageStart();
    }

    @Override // android.webkit.WebViewClient
    public void onPageFinished(WebView webView, String str) {
        super.onPageFinished(webView, str);
        com.kwad.sdk.core.webview.b.c.b.ag(this.mUniqueId, "onPageFinished");
        a aVar = this.ND;
        if (aVar == null || aVar.jE() == null) {
            return;
        }
        this.ND.jE().onPageFinished();
    }

    @Override // android.webkit.WebViewClient
    public boolean shouldOverrideUrlLoading(WebView webView, String str) {
        com.kwad.sdk.core.d.c.w("KsAdWebViewClient", "shouldOverrideUrlLoading url=" + str);
        com.kwad.sdk.core.webview.b.c.b.ag(this.mUniqueId, "shouldOverrideUrlLoading");
        a aVar = this.ND;
        if (aVar == null || !aVar.PN() || ((this.ND.PF() != null && this.ND.PF().shouldOverrideUrlLoading(webView, str)) || fF(str))) {
            return true;
        }
        return super.shouldOverrideUrlLoading(webView, str);
    }

    private boolean fF(String str) {
        int iBS;
        try {
            if (!str.startsWith("http") && !str.startsWith("https")) {
                if (!str.startsWith("tel:") && !str.startsWith("sms:")) {
                    a aVar = this.ND;
                    if (aVar != null) {
                        try {
                            iBS = com.kwad.sdk.core.response.helper.a.bS(e.eM(aVar.getAdTemplate()));
                        } catch (Throwable unused) {
                            iBS = -1000;
                        }
                        if (!this.ND.PI() && !this.bcm) {
                            this.bcm = true;
                            com.kwad.sdk.core.adlog.c.u(this.ND.getAdTemplate(), iBS);
                        }
                        if (this.ND.PH()) {
                            eI(iBS);
                            a(this.ND, str);
                            return true;
                        }
                        if (fG(str)) {
                            eJ(iBS);
                            return true;
                        }
                        eJ(iBS);
                    }
                    return false;
                }
                Intent intent = new Intent("android.intent.action.VIEW", Uri.parse(str));
                a aVar2 = this.ND;
                if (aVar2 != null) {
                    aVar2.getContext().startActivity(intent);
                }
                return true;
            }
            return false;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    private void eI(int i) {
        if (this.ND.PI()) {
            if (this.bcp) {
                return;
            }
            this.bcp = true;
            com.kwad.sdk.core.adlog.c.cx(this.ND.getAdTemplate());
            return;
        }
        if (this.bco) {
            return;
        }
        this.bco = true;
        if (this.ND.PJ()) {
            com.kwad.sdk.core.adlog.c.j(this.ND.getAdTemplate(), i, 2);
        } else if (i == 0) {
            com.kwad.sdk.core.adlog.c.j(this.ND.getAdTemplate(), i, 1);
        } else {
            com.kwad.sdk.core.adlog.c.j(this.ND.getAdTemplate(), i, 0);
        }
    }

    private void eJ(int i) {
        if (this.bcn) {
            return;
        }
        this.bcn = true;
        if (!this.ND.PI()) {
            if (i < 0 && i != -1000) {
                com.kwad.sdk.core.adlog.c.k(this.ND.getAdTemplate(), i, 1);
                return;
            } else if (!this.ND.PJ() && i > 0) {
                com.kwad.sdk.core.adlog.c.k(this.ND.getAdTemplate(), i, 2);
                return;
            }
        }
        com.kwad.sdk.core.adlog.c.k(this.ND.getAdTemplate(), i, 0);
    }

    private int a(a aVar, String str) {
        boolean zCr;
        int I;
        try {
            zCr = com.kwad.sdk.core.response.helper.a.cr(e.eM(aVar.getAdTemplate()));
        } catch (Throwable unused) {
            zCr = false;
        }
        com.kwad.sdk.core.adlog.c.a aVar2 = new com.kwad.sdk.core.adlog.c.a();
        if (zCr) {
            if (aVar2.QR == null) {
                aVar2.QR = new com.kwad.sdk.core.adlog.a.C0502a();
            }
            aVar2.QR.aLr = true;
            I = com.kwad.sdk.core.download.a.b.a(aVar.getContext(), str, new com.kwad.sdk.core.download.a.b.a() { // from class: com.kwad.sdk.core.webview.a.c.1
                @Override // com.kwad.sdk.core.download.a.b.a
                public final void aJ(int i) {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onError(Throwable th) {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onPreStart() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onStart() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void onSuccess() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final void qF() {
                }

                @Override // com.kwad.sdk.core.download.a.b.a
                public final boolean qG() {
                    return true;
                }
            });
        } else {
            I = com.kwad.sdk.core.download.a.b.I(aVar.getContext(), str);
        }
        if (I == 1) {
            if (aVar.on() != null) {
                aVar.on().onSuccess();
            }
            com.kwad.sdk.core.adlog.c.c(aVar.getAdTemplate(), "", 2, aVar2);
            com.kwad.sdk.core.adlog.c.l(aVar.getAdTemplate(), zCr);
        } else {
            if (aVar.on() != null) {
                aVar.on().onFailed();
            }
            if (I == -1 && !this.aeL) {
                this.aeL = true;
                com.kwad.sdk.core.adlog.c.d(aVar.getAdTemplate(), "", 2, aVar2);
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 0);
            } else if (I == 0 && TextUtils.isEmpty(str)) {
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 3);
            } else if (I == 0 && aVar.getContext() == null) {
                com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), zCr, 4);
            }
        }
        return I;
    }

    private static boolean fG(String str) {
        if (TextUtils.isEmpty(str)) {
            return false;
        }
        return str.startsWith("hwfastapp://") || str.startsWith("hap://app") || str.startsWith("intent://hapjs.org/") || str.startsWith("intent://");
    }

    public final void setClientConfig(a aVar) {
        this.ND = aVar;
        setNeedHybridLoad(aVar.PK());
    }

    public final a getClientConfig() {
        return this.ND;
    }

    public final void destroy() {
        a aVar = this.ND;
        if (aVar != null) {
            aVar.release();
            this.ND = null;
        }
    }

    public static class a {
        private int adu;
        private KsAdWebView.c aef;
        private KsAdWebView.b ati;
        private KsAdWebView.e bcr;
        private KsAdWebView.d bcs;
        private boolean bct;
        private boolean bcy;
        private AdTemplate mAdTemplate;
        private Context mContext;
        private boolean bcu = true;
        private boolean bcv = true;
        private boolean bcw = false;
        private boolean bcx = false;
        private boolean bcl = true;
        private boolean bcz = false;
        private long bcA = 600;
        private long bcB = 0;

        public a(Context context) {
            this.mContext = context;
        }

        public final void release() {
            this.ati = null;
            this.bcs = null;
            this.aef = null;
            this.bcr = null;
            this.mContext = null;
            this.mAdTemplate = null;
        }

        public final a fm(AdTemplate adTemplate) {
            this.mAdTemplate = adTemplate;
            return this;
        }

        public final AdTemplate getAdTemplate() {
            return this.mAdTemplate;
        }

        public final Context getContext() {
            return this.mContext;
        }

        public final KsAdWebView.e jE() {
            return this.bcr;
        }

        public final KsAdWebView.d PF() {
            return this.bcs;
        }

        public final a b(KsAdWebView.e eVar) {
            this.bcr = eVar;
            return this;
        }

        public final a a(KsAdWebView.d dVar) {
            this.bcs = dVar;
            return this;
        }

        public final KsAdWebView.b on() {
            return this.ati;
        }

        public final a a(KsAdWebView.b bVar) {
            this.ati = bVar;
            return this;
        }

        private boolean PG() {
            return this.bcz;
        }

        public final a bP(boolean z) {
            this.bcz = true;
            return this;
        }

        public final com.kwad.sdk.core.adlog.c.a pZ() {
            return com.kwad.sdk.core.adlog.c.a.Jr().dQ(this.adu).dR(this.bct ? 1 : 0);
        }

        public final a bQ(boolean z) {
            this.bct = true;
            return this;
        }

        public final a eK(int i) {
            this.adu = i;
            return this;
        }

        public final boolean PH() {
            return this.bcv;
        }

        public final a bR(boolean z) {
            this.bcv = z;
            return this;
        }

        public final boolean PI() {
            return this.bcw;
        }

        public final a bS(boolean z) {
            this.bcw = true;
            return this;
        }

        public final boolean PJ() {
            return this.bcx;
        }

        public final a bT(boolean z) {
            this.bcx = true;
            return this;
        }

        public final boolean PK() {
            return this.bcl;
        }

        public final boolean PL() {
            return this.bcu;
        }

        public final a bU(boolean z) {
            this.bcu = z;
            return this;
        }

        public final KsAdWebView.c uF() {
            return this.aef;
        }

        public final a c(KsAdWebView.c cVar) {
            this.aef = cVar;
            return this;
        }

        public final boolean PM() {
            return this.bcy;
        }

        public final a bV(boolean z) {
            this.bcy = true;
            return this;
        }

        public final void aO(long j) {
            this.bcB = j;
        }

        public final boolean PN() {
            if (!PG()) {
                return true;
            }
            long jCurrentTimeMillis = System.currentTimeMillis();
            long j = this.bcB;
            return j > 0 && jCurrentTimeMillis - j <= this.bcA;
        }

        public final boolean PO() {
            AdTemplate adTemplate = this.mAdTemplate;
            if (adTemplate == null) {
                return false;
            }
            return com.kwad.sdk.core.response.helper.a.dE(e.eM(adTemplate));
        }

        public final boolean PP() {
            AdTemplate adTemplate = this.mAdTemplate;
            if (adTemplate == null) {
                return false;
            }
            return com.kwad.sdk.core.response.helper.a.dF(e.eM(adTemplate));
        }
    }
}
