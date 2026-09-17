package com.baidu.oauth.sdkbqt.auth;

import android.content.DialogInterface;
import android.webkit.JsResult;

/* JADX INFO: loaded from: classes.dex */
class v implements DialogInterface.OnClickListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ JsResult f588a;
    final /* synthetic */ u b;

    v(u uVar, JsResult jsResult) {
        this.b = uVar;
        this.f588a = jsResult;
    }

    @Override // android.content.DialogInterface.OnClickListener
    public void onClick(DialogInterface dialogInterface, int i) {
        this.f588a.confirm();
    }
}
