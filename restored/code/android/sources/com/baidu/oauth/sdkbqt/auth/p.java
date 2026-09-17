package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class p implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ String f582a;
    final /* synthetic */ i b;

    p(i iVar, String str) {
        this.b = iVar;
        this.f582a = str;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.b.i) {
            return;
        }
        super/*android.webkit.WebView*/.loadUrl(this.f582a);
    }
}
