package com.sigmob.sdk.downloader.core.breakpoint;

/* JADX INFO: loaded from: classes3.dex */
class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    long f3393a;
    private final m b;

    n(final m.a agent) {
        this(new m(agent));
    }

    n(final m executor) {
        this.b = executor;
        this.f3393a = 1500L;
    }

    void a() {
        this.b.a();
    }

    boolean a(int id) {
        return !this.b.a(id);
    }

    void b(int id) {
        this.b.e(id);
        this.b.a(id, this.f3393a);
    }

    void c(int id) {
        this.b.e(id);
        try {
            if (this.b.a(id)) {
                return;
            }
            this.b.b(id);
        } finally {
            this.b.d(id);
        }
    }

    void d(int id) {
        this.b.e(id);
        this.b.c(id);
    }
}
