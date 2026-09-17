package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;

/* JADX INFO: loaded from: classes4.dex */
public final class Blackberry implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Context f3826a;

    public Blackberry(Context context) {
        this.f3826a = context;
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            Blueberry.a(this.f3826a);
        } catch (Throwable unused) {
        }
    }
}
