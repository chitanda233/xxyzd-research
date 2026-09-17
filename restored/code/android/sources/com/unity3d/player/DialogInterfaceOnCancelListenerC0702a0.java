package com.unity3d.player;

import android.content.DialogInterface;

/* JADX INFO: renamed from: com.unity3d.player.a0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class DialogInterfaceOnCancelListenerC0702a0 implements DialogInterface.OnCancelListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0706c0 f4028a;

    DialogInterfaceOnCancelListenerC0702a0(C0706c0 c0706c0) {
        this.f4028a = c0706c0;
    }

    @Override // android.content.DialogInterface.OnCancelListener
    public final void onCancel(DialogInterface dialogInterface) {
        F f = this.f4028a.f;
        if (f != null) {
            ((C0724l0) f).a();
        }
    }
}
