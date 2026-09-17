package com.unity3d.player;

import android.database.ContentObserver;
import android.os.Handler;

/* JADX INFO: renamed from: com.unity3d.player.e0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0710e0 extends ContentObserver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private InterfaceC0708d0 f4036a;

    public C0710e0(Handler handler, InterfaceC0708d0 interfaceC0708d0) {
        super(handler);
        this.f4036a = interfaceC0708d0;
    }

    @Override // android.database.ContentObserver
    public final boolean deliverSelfNotifications() {
        return super.deliverSelfNotifications();
    }

    @Override // android.database.ContentObserver
    public final void onChange(boolean z) {
        InterfaceC0708d0 interfaceC0708d0 = this.f4036a;
        if (interfaceC0708d0 != null) {
            ((OrientationLockListener) interfaceC0708d0).b();
        }
    }
}
