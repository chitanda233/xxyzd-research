package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class r implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f584a;

    r(i iVar) {
        this.f584a = iVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.f584a.l != null) {
            this.f584a.l.setVisibility(8);
        }
        this.f584a.f.f574a = this.f584a.o.b;
        if (this.f584a.h != null) {
            this.f584a.h.setVisibility(0);
        }
    }
}
