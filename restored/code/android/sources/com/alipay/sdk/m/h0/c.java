package com.alipay.sdk.m.h0;

/* JADX INFO: loaded from: classes.dex */
public class c implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ b f293a;

    public c(b bVar) {
        this.f293a = bVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        try {
            this.f293a.a();
        } catch (Exception e) {
            d.a(e);
        }
    }
}
