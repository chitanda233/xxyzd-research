package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class i extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ n f3934a;

    public i(n nVar) {
        this.f3934a = nVar;
    }

    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        try {
            n.a(this.f3934a);
        } catch (Throwable unused) {
        }
    }
}
