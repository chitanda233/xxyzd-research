package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class O implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final long f4002a;
    final long b;

    public O(long j, long j2) {
        this.f4002a = j;
        this.b = j2;
    }

    @Override // java.lang.Runnable
    public final void run() {
        if (ReflectionHelper.beginProxyCall(this.f4002a)) {
            try {
                ReflectionHelper.nativeProxyFinalize(this.b);
            } finally {
                ReflectionHelper.endProxyCall();
            }
        }
    }
}
