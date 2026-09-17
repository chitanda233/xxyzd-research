package com.kwad.components.core.webview.a;

import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import android.webkit.WebView;
import com.kwad.components.core.e.d.d;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.ce;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private d QK;
    private WebView adg;
    private boolean aoy;
    private KsAppDownloadListener apj;
    private int apk = -100;
    private int apl = 0;
    private com.kwad.sdk.core.webview.b fc;
    private AdTemplate mAdTemplate;

    /* JADX INFO: renamed from: com.kwad.components.core.webview.a.a$a, reason: collision with other inner class name */
    public static final class C0461a extends com.kwad.sdk.core.response.a.a {
        public String packageName;
        public String url;
    }

    public static final class b extends com.kwad.sdk.core.response.a.a {
        public int progress;
        public int status;
    }

    public a(WebView webView, com.kwad.sdk.core.webview.b bVar) {
        this.adg = webView;
        this.mAdTemplate = bVar.getAdTemplate();
        this.fc = bVar;
    }

    private synchronized void q(String str, String str2) {
        this.QK = new d(this.mAdTemplate, null, str, str2);
        if (this.apj == null) {
            KsAppDownloadListener ksAppDownloadListenerYD = yD();
            this.apj = ksAppDownloadListenerYD;
            this.QK.b(ksAppDownloadListenerYD);
        }
    }

    @JavascriptInterface
    public final int getDownLoadStatus(String str, String str2) {
        if (r(str, str2)) {
            return 0;
        }
        if (this.QK == null) {
            q(str, str2);
        }
        return this.QK.qm();
    }

    @JavascriptInterface
    public final int getProgress(String str, String str2) {
        if (r(str, str2)) {
            return 0;
        }
        if (this.QK == null) {
            q(str, str2);
        }
        return this.apl;
    }

    @JavascriptInterface
    public final void handleAdClick(final String str) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.a.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.by(str);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void by(String str) {
        try {
            C0461a c0461a = new C0461a();
            c0461a.parseJson(new JSONObject(str));
            if (r(c0461a.url, c0461a.packageName)) {
                return;
            }
            if (this.QK == null) {
                q(c0461a.url, c0461a.packageName);
            }
            com.kwad.components.core.e.d.a.C0428a c0428aAv = new com.kwad.components.core.e.d.a.C0428a(this.fc.adg.getContext()).as(true).at(false).aF(this.mAdTemplate).av(false);
            if (this.QK.w(c0428aAv)) {
                return;
            }
            this.QK.d(this.apj);
            this.QK.v(c0428aAv);
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    private static boolean r(String str, String str2) {
        return TextUtils.isEmpty(str) || TextUtils.isEmpty(str2);
    }

    private KsAppDownloadListener yD() {
        return new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.webview.a.a.2
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                a.this.s(0, 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                if (i == 0) {
                    a.this.s(1, 0);
                } else {
                    a.this.s(2, i);
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                a.this.s(8, 100);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                a.this.s(0, 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                a.this.s(12, 100);
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                a.this.s(4, i);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void s(int i, int i2) {
        this.apl = i2;
        if (this.apk != i) {
            this.apk = i;
            p("onDownLoadStatusCallback", new StringBuilder().append(i).toString());
        }
    }

    private void p(String str, String str2) {
        WebView webView;
        if (this.aoy || TextUtils.isEmpty(str) || (webView = this.adg) == null) {
            return;
        }
        ce.a(webView, str, str2);
    }

    public final void destroy() {
        this.aoy = true;
        d dVar = this.QK;
        if (dVar != null) {
            dVar.c(this.apj);
        }
    }
}
