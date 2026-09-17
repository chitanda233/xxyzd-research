package com.baidu.oauth.sdkbqt.view;

/* JADX INFO: loaded from: classes.dex */
class f implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ e f605a;

    f(e eVar) {
        this.f605a = eVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        this.f605a.f604a.setVisibility(4);
        this.f605a.b.oauthWebView.reload();
    }
}
