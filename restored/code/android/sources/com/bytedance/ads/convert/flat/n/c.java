package com.bytedance.ads.convert.flat.n;

import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes2.dex */
public abstract class c<T> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile T f1744a;
    public final AtomicBoolean b = new AtomicBoolean(false);

    public abstract T a(Object... objArr);

    public final T b(Object... objArr) {
        if (!this.b.get() && this.f1744a == null) {
            synchronized (this) {
                if (!this.b.get() && this.f1744a == null) {
                    this.f1744a = a(objArr);
                    this.b.set(true);
                }
            }
        }
        return this.f1744a;
    }
}
