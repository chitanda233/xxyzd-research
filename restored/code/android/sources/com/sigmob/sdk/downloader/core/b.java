package com.sigmob.sdk.downloader.core;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected final String f3378a;

    public b(String name) {
        this.f3378a = name;
    }

    protected abstract void a() throws InterruptedException;

    protected abstract void a(InterruptedException e);

    protected abstract void b();

    @Override // java.lang.Runnable
    public final void run() {
        String name = Thread.currentThread().getName();
        Thread.currentThread().setName(this.f3378a);
        try {
            try {
                a();
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
                a(e);
            }
        } finally {
            Thread.currentThread().setName(name);
            b();
        }
    }
}
