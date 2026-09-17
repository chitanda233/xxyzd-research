package com.baidu.oauth.sdkbqt.auth;

import android.app.Activity;

/* JADX INFO: loaded from: classes.dex */
class q implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f583a;

    q(i iVar) {
        this.f583a = iVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.f583a.p != null) {
            com.baidu.oauth.sdkbqt.a.h.a((Activity) this.f583a.getContext());
            this.f583a.p.a();
        }
    }
}
