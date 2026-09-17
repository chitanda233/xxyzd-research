package com.kwad.components.core.webview.jsPublicBridge;

import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import android.webkit.WebView;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.core.webview.c.a;
import com.kwad.sdk.core.webview.c.b;
import com.kwad.sdk.core.webview.c.d;
import com.kwad.sdk.core.webview.c.e;
import com.kwad.sdk.core.webview.c.f;
import com.kwad.sdk.utils.ce;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class KSAdPublicJSBridge {
    private WebView adg;
    private final Map<String, a> aow = new ConcurrentHashMap(32);
    private a aox = new d();
    private boolean aoy;

    public KSAdPublicJSBridge(WebView webView) {
        this.adg = webView;
        yB();
    }

    private void yB() {
        a(new com.kwad.components.core.webview.jsPublicBridge.a.a());
    }

    private void a(a aVar) {
        if (!TextUtils.isEmpty(aVar.getKey())) {
            if (this.aow.containsKey(aVar.getKey())) {
                c.e("KSAdPublicJSBridge", "cannot register handler again, handler: " + aVar.getKey());
            }
            this.aow.put(aVar.getKey(), aVar);
            return;
        }
        c.e("KSAdPublicJSBridge", "handler and handler'key cannot be null");
    }

    @JavascriptInterface
    public void callAdBridge(String str) {
        com.kwad.sdk.core.webview.c.c cVar;
        c.d("KSAdPublicJSBridge", "callAdBridge ==" + str);
        try {
            final b bVar = new b();
            bVar.parseJson(new JSONObject(str));
            a aVar = this.aow.get(bVar.bcX);
            if (aVar == null) {
                aVar = this.aox;
            }
            WebView webView = this.adg;
            if (webView != null && (webView instanceof KsAdWebView)) {
                KsAdWebView ksAdWebView = (KsAdWebView) webView;
                com.kwad.sdk.core.webview.b.c.b.a(ksAdWebView.getLoadUrl(), ksAdWebView.getUniqueId(), bVar.bcX, bVar.data);
            }
            if (aVar != null) {
                if (!TextUtils.isEmpty(bVar.bcY)) {
                    cVar = new com.kwad.sdk.core.webview.c.c() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdPublicJSBridge.1
                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void b(com.kwad.sdk.core.b bVar2) {
                            KSAdPublicJSBridge.this.p(bVar.bcY, new f(bVar2).toJson().toString());
                        }

                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void onError(int i, String str2) {
                            KSAdPublicJSBridge.this.p(bVar.bcY, new e(i, str2).toJson().toString());
                        }
                    };
                } else {
                    cVar = new com.kwad.sdk.core.webview.c.c() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdPublicJSBridge.2
                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void b(com.kwad.sdk.core.b bVar2) {
                        }

                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void onError(int i, String str2) {
                        }
                    };
                }
                aVar.a(bVar.data, cVar);
                return;
            }
            c.e("KSAdPublicJSBridge", "bridgeHandler is null");
        } catch (JSONException e) {
            c.printStackTraceOnly(e);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void p(String str, String str2) {
        if (this.aoy) {
            c.d("KSAdPublicJSBridge", "callJS after destroy jsInterface, " + str2);
            return;
        }
        if (TextUtils.isEmpty(str)) {
            c.d("KSAdPublicJSBridge", "callJS callback is empty");
            return;
        }
        c.d("KSAdPublicJSBridge", "callJS callback:+ " + str + "--params: " + str2);
        WebView webView = this.adg;
        if (webView == null) {
            return;
        }
        ce.a(webView, str, str2);
    }

    public final void destroy() {
        c.i("KSAdPublicJSBridge", "destroy jsInterface");
        Iterator<Map.Entry<String, a>> it = this.aow.entrySet().iterator();
        while (it.hasNext()) {
            a value = it.next().getValue();
            if (value != null) {
                value.onDestroy();
            }
        }
        this.aoy = true;
    }
}
