package com.baidu.oauth.sdkbqt.view;

import android.view.View;

/* JADX INFO: loaded from: classes.dex */
class e implements View.OnClickListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ View f604a;
    final /* synthetic */ a b;

    e(a aVar, View view) {
        this.b = aVar;
        this.f604a = view;
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        this.b.runOnUiThread(new f(this));
    }
}
