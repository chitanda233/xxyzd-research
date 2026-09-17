package com.baidu.mobads.sdk.internal;

import android.webkit.WebView;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class ai implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ JSONObject f412a;
    final /* synthetic */ WebView b;
    final /* synthetic */ ae c;

    ai(ae aeVar, JSONObject jSONObject, WebView webView) {
        this.c = aeVar;
        this.f412a = jSONObject;
        this.b = webView;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.f412a == null || this.b == null) {
            return;
        }
        this.b.loadUrl("javascript:window.sdkCallback.userInteractCb(\"" + this.f412a.toString().replace("\"", "\\\"") + "\")");
    }
}
