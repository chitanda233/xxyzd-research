package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class s implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f585a;

    s(i iVar) {
        this.f585a = iVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.f585a.l != null) {
            this.f585a.l.setVisibility(8);
        }
        if (this.f585a.g != null) {
            this.f585a.g.setVisibility(0);
        }
    }
}
