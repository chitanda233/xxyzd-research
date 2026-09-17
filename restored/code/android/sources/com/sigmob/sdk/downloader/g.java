package com.sigmob.sdk.downloader;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static volatile g f3458a;
    d b;
    private final com.sigmob.sdk.downloader.core.dispatcher.b c;
    private final com.sigmob.sdk.downloader.core.dispatcher.a d;
    private final com.sigmob.sdk.downloader.core.breakpoint.g e;
    private final com.sigmob.sdk.downloader.core.connection.a.b f;
    private final com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a g;
    private final com.sigmob.sdk.downloader.core.file.e h;
    private final com.sigmob.sdk.downloader.core.download.g i;
    private final Context j;

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private com.sigmob.sdk.downloader.core.dispatcher.b f3459a;
        private com.sigmob.sdk.downloader.core.dispatcher.a b;
        private com.sigmob.sdk.downloader.core.breakpoint.j c;
        private com.sigmob.sdk.downloader.core.connection.a.b d;
        private com.sigmob.sdk.downloader.core.file.e e;
        private com.sigmob.sdk.downloader.core.download.g f;
        private com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a g;
        private d h;
        private final Context i;

        public a(Context context) {
            this.i = context.getApplicationContext();
        }

        public a a(com.sigmob.sdk.downloader.core.breakpoint.j downloadStore) {
            this.c = downloadStore;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.connection.a.b connectionFactory) {
            this.d = connectionFactory;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.dispatcher.a callbackDispatcher) {
            this.b = callbackDispatcher;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.dispatcher.b downloadDispatcher) {
            this.f3459a = downloadDispatcher;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.download.g downloadStrategy) {
            this.f = downloadStrategy;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a outputStreamFactory) {
            this.g = outputStreamFactory;
            return this;
        }

        public a a(com.sigmob.sdk.downloader.core.file.e processFileStrategy) {
            this.e = processFileStrategy;
            return this;
        }

        public a a(d monitor) {
            this.h = monitor;
            return this;
        }

        public g a() {
            if (this.f3459a == null) {
                this.f3459a = new com.sigmob.sdk.downloader.core.dispatcher.b();
            }
            if (this.b == null) {
                this.b = new com.sigmob.sdk.downloader.core.dispatcher.a();
            }
            if (this.c == null) {
                this.c = com.sigmob.sdk.downloader.core.c.a(this.i);
            }
            if (this.d == null) {
                this.d = com.sigmob.sdk.downloader.core.c.c();
            }
            if (this.g == null) {
                this.g = new com.sigmob.sdk.downloader.core.file.b.a();
            }
            if (this.e == null) {
                this.e = new com.sigmob.sdk.downloader.core.file.e();
            }
            if (this.f == null) {
                this.f = new com.sigmob.sdk.downloader.core.download.g();
            }
            g gVar = new g(this.i, this.f3459a, this.b, this.c, this.d, this.g, this.e, this.f);
            gVar.a(this.h);
            com.sigmob.sdk.downloader.core.c.b("FileDownload", "downloadStore[" + this.c + "] connectionFactory[" + this.d);
            return gVar;
        }
    }

    g(Context context, com.sigmob.sdk.downloader.core.dispatcher.b downloadDispatcher, com.sigmob.sdk.downloader.core.dispatcher.a callbackDispatcher, com.sigmob.sdk.downloader.core.breakpoint.j store, com.sigmob.sdk.downloader.core.connection.a.b connectionFactory, com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a outputStreamFactory, com.sigmob.sdk.downloader.core.file.e processFileStrategy, com.sigmob.sdk.downloader.core.download.g downloadStrategy) {
        this.j = context;
        this.c = downloadDispatcher;
        this.d = callbackDispatcher;
        this.e = store;
        this.f = connectionFactory;
        this.g = outputStreamFactory;
        this.h = processFileStrategy;
        this.i = downloadStrategy;
        downloadDispatcher.a(com.sigmob.sdk.downloader.core.c.a(store));
    }

    public static void a(g fileDownload) {
        if (f3458a != null) {
            throw new IllegalArgumentException("FileDownload must be null.");
        }
        synchronized (g.class) {
            if (f3458a != null) {
                throw new IllegalArgumentException("FileDownload must be null.");
            }
            f3458a = fileDownload;
        }
    }

    public static g j() {
        if (f3458a == null) {
            synchronized (g.class) {
                if (f3458a == null) {
                    if (com.sigmob.sdk.b.e() == null) {
                        throw new IllegalStateException("context == null");
                    }
                    f3458a = new a(com.sigmob.sdk.b.e()).a();
                }
            }
        }
        return f3458a;
    }

    public com.sigmob.sdk.downloader.core.dispatcher.b a() {
        return this.c;
    }

    public void a(d monitor) {
        this.b = monitor;
    }

    public com.sigmob.sdk.downloader.core.dispatcher.a b() {
        return this.d;
    }

    public com.sigmob.sdk.downloader.core.breakpoint.g c() {
        return this.e;
    }

    public com.sigmob.sdk.downloader.core.connection.a.b d() {
        return this.f;
    }

    public com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a e() {
        return this.g;
    }

    public com.sigmob.sdk.downloader.core.file.e f() {
        return this.h;
    }

    public com.sigmob.sdk.downloader.core.download.g g() {
        return this.i;
    }

    public Context h() {
        return this.j;
    }

    public d i() {
        return this.b;
    }
}
