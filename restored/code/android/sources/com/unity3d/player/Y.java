package com.unity3d.player;

import android.content.DialogInterface;

/* JADX INFO: loaded from: classes4.dex */
final class Y implements DialogInterface.OnDismissListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0706c0 f4023a;

    Y(C0706c0 c0706c0) {
        this.f4023a = c0706c0;
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public final void onDismiss(DialogInterface dialogInterface) {
        this.f4023a.invokeOnClose();
    }
}
