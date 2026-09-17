package com.kwad.components.core.webview;

import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import android.webkit.WebView;
import com.kwad.components.core.webview.jshandler.ab;
import com.kwad.sdk.core.webview.KsAdWebView;
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
public final class a {
    private WebView adg;
    private final Map<String, com.kwad.sdk.core.webview.c.a> aow = new ConcurrentHashMap(32);
    private com.kwad.sdk.core.webview.c.a aox = new d();
    private boolean aoy;

    public a(WebView webView) {
        this.adg = webView;
        yl();
    }

    private void yl() {
        a(new com.kwad.sdk.core.webview.d.a());
        a(new com.kwad.sdk.core.webview.d.b());
        a(new ab());
    }

    @JavascriptInterface
    public final void callAdBridge(String str) {
        com.kwad.sdk.core.webview.c.c cVar;
        com.kwad.sdk.core.d.c.d("KSAdJSBridge", "callAdBridge ==" + str);
        try {
            final com.kwad.sdk.core.webview.c.b bVar = new com.kwad.sdk.core.webview.c.b();
            bVar.parseJson(new JSONObject(str));
            com.kwad.sdk.core.webview.c.a aVar = this.aow.get(bVar.bcX);
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
                    cVar = new com.kwad.sdk.core.webview.c.c() { // from class: com.kwad.components.core.webview.a.1
                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void b(com.kwad.sdk.core.b bVar2) {
                            a.this.p(bVar.bcY, new f(bVar2).toJson().toString());
                        }

                        @Override // com.kwad.sdk.core.webview.c.c
                        public final void onError(int i, String str2) {
                            a.this.p(bVar.bcY, new e(i, str2).toJson().toString());
                        }
                    };
                } else {
                    cVar = new com.kwad.sdk.core.webview.c.c() { // from class: com.kwad.components.core.webview.a.2
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
            com.kwad.sdk.core.d.c.e("KSAdJSBridge", "bridgeHandler is null");
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            com.kwad.sdk.core.d.c.e("KSAdJSBridge", "callAdBridge JSONException:" + e);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void p(String str, String str2) {
        if (this.aoy) {
            com.kwad.sdk.core.d.c.d("KSAdJSBridge", "callJS after destroy jsInterface, " + str2);
            return;
        }
        if (TextUtils.isEmpty(str)) {
            com.kwad.sdk.core.d.c.d("KSAdJSBridge", "callJS callback is empty");
            return;
        }
        com.kwad.sdk.core.d.c.d("KSAdJSBridge", "callJS callback:+ " + str + "--params: " + str2);
        WebView webView = this.adg;
        if (webView == null) {
            return;
        }
        ce.a(webView, str, str2);
    }

    public final void a(com.kwad.sdk.core.webview.c.a aVar) {
        if (aVar != null && !TextUtils.isEmpty(aVar.getKey())) {
            if (this.aow.containsKey(aVar.getKey())) {
                com.kwad.sdk.core.d.c.e("KSAdJSBridge", "cannot register handler again, handler: " + aVar.getKey());
            }
            this.aow.put(aVar.getKey(), aVar);
            return;
        }
        com.kwad.sdk.core.d.c.e("KSAdJSBridge", "handler and handler'key cannot be null");
    }

    public final void b(com.kwad.sdk.core.webview.c.a aVar) {
        if (!TextUtils.isEmpty(aVar.getKey())) {
            this.aow.put(aVar.getKey(), aVar);
        } else {
            com.kwad.sdk.core.d.c.e("KSAdJSBridge", "handler and handler'key cannot be null");
        }
    }

    public final void destroy() {
        com.kwad.sdk.core.d.c.i("KSAdJSBridge", "destroy jsInterface");
        Iterator<Map.Entry<String, com.kwad.sdk.core.webview.c.a>> it = this.aow.entrySet().iterator();
        while (it.hasNext()) {
            com.kwad.sdk.core.webview.c.a value = it.next().getValue();
            if (value != null) {
                value.onDestroy();
            }
        }
        this.aoy = true;
    }
}
