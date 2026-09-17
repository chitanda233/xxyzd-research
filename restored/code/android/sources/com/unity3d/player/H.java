package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class H implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ String[] f3986a;
    final /* synthetic */ PermissionFragment b;

    H(PermissionFragment permissionFragment, String[] strArr) {
        this.b = permissionFragment;
        this.f3986a = strArr;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.b.reportAllDenied(this.f3986a);
    }
}
