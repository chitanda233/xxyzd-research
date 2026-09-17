package com.baidu.oauth.sdkbqt.auth;

import android.os.Handler;
import android.os.Message;

/* JADX INFO: loaded from: classes.dex */
class j extends Handler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f576a;

    j(i iVar) {
        this.f576a = iVar;
    }

    @Override // android.os.Handler
    public void handleMessage(Message message) {
        if (message.what == 1) {
            this.f576a.h();
        }
    }
}
