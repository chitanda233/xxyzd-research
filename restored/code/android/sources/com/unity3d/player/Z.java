package com.unity3d.player;

import android.view.ViewTreeObserver;

/* JADX INFO: loaded from: classes4.dex */
final class Z implements ViewTreeObserver.OnGlobalLayoutListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0706c0 f4024a;

    Z(C0706c0 c0706c0) {
        this.f4024a = c0706c0;
    }

    @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
    public final void onGlobalLayout() {
        this.f4024a.reportSoftInputArea();
        this.f4024a.h.b();
    }
}
