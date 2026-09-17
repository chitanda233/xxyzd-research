package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;

/* JADX INFO: loaded from: classes4.dex */
public final class c0 extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ u f3915a;
    public final /* synthetic */ Context b;

    public c0(u uVar, Context context) {
        this.f3915a = uVar;
        this.b = context;
    }

    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        this.f3915a.f3968a.onResult(new v(n.l.a(this.b, false, 1)));
    }
}
