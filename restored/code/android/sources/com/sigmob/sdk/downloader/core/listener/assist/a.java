package com.sigmob.sdk.downloader.core.listener.assist;

import com.sigmob.sdk.downloader.f;
import java.util.concurrent.atomic.AtomicLong;

/* JADX INFO: loaded from: classes3.dex */
public class a implements d, e.b<b> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final e<b> f3444a;
    private InterfaceC0564a b;

    /* JADX INFO: renamed from: com.sigmob.sdk.downloader.core.listener.assist.a$a, reason: collision with other inner class name */
    public interface InterfaceC0564a {
        void a(f task, int blockCount, long currentOffset, long totalLength);

        void a(f task, long currentOffset, long totalLength);

        void a(f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause, b model);

        void a(f task, com.sigmob.sdk.downloader.core.cause.b cause);

        void a(f task, b model);
    }

    public static class b implements e.a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final int f3445a;
        Boolean b;
        Boolean c;
        volatile Boolean d;
        int e;
        long f;
        final AtomicLong g = new AtomicLong();

        b(int id) {
            this.f3445a = id;
        }

        public long a() {
            return this.f;
        }

        @Override // com.sigmob.sdk.downloader.core.listener.assist.e.a
        public void a(com.sigmob.sdk.downloader.core.breakpoint.c info) {
            this.e = info.g();
            this.f = info.j();
            this.g.set(info.i());
            if (this.b == null) {
                this.b = false;
            }
            if (this.c == null) {
                this.c = Boolean.valueOf(this.g.get() > 0);
            }
            if (this.d == null) {
                this.d = true;
            }
        }

        @Override // com.sigmob.sdk.downloader.core.listener.assist.e.a
        public int b() {
            return this.f3445a;
        }
    }

    public a() {
        this.f3444a = new e<>(this);
    }

    a(e<b> handler) {
        this.f3444a = handler;
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.e.b
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public b b(int id) {
        return new b(id);
    }

    public void a(InterfaceC0564a callback) {
        this.b = callback;
    }

    public void a(f task) {
        b bVar = (b) this.f3444a.a(task, null);
        InterfaceC0564a interfaceC0564a = this.b;
        if (interfaceC0564a != null) {
            interfaceC0564a.a(task, bVar);
        }
    }

    public void a(f task, long increaseBytes) {
        b bVar = (b) this.f3444a.b(task, task.y());
        if (bVar == null) {
            return;
        }
        bVar.g.addAndGet(increaseBytes);
        InterfaceC0564a interfaceC0564a = this.b;
        if (interfaceC0564a != null) {
            interfaceC0564a.a(task, bVar.g.get(), bVar.f);
        }
    }

    public void a(f task, com.sigmob.sdk.downloader.core.breakpoint.c info) {
        b bVar = (b) this.f3444a.b(task, info);
        if (bVar == null) {
            return;
        }
        bVar.a(info);
        bVar.b = true;
        bVar.c = true;
        bVar.d = true;
    }

    public void a(f task, com.sigmob.sdk.downloader.core.breakpoint.c info, com.sigmob.sdk.downloader.core.cause.b cause) {
        InterfaceC0564a interfaceC0564a;
        b bVar = (b) this.f3444a.b(task, info);
        if (bVar == null) {
            return;
        }
        bVar.a(info);
        if (bVar.b.booleanValue() && (interfaceC0564a = this.b) != null) {
            interfaceC0564a.a(task, cause);
        }
        bVar.b = true;
        bVar.c = false;
        bVar.d = true;
    }

    public void a(f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause) {
        b bVar = (b) this.f3444a.c(task, task.y());
        InterfaceC0564a interfaceC0564a = this.b;
        if (interfaceC0564a != null) {
            interfaceC0564a.a(task, cause, realCause, bVar);
        }
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void a(boolean isAlwaysRecoverAssistModel) {
        this.f3444a.a(isAlwaysRecoverAssistModel);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public boolean a() {
        return this.f3444a.a();
    }

    public void b(f task) {
        b bVar = (b) this.f3444a.b(task, task.y());
        if (bVar == null) {
            return;
        }
        if (Boolean.TRUE.equals(bVar.c) && Boolean.TRUE.equals(bVar.d)) {
            bVar.d = false;
        }
        InterfaceC0564a interfaceC0564a = this.b;
        if (interfaceC0564a != null) {
            interfaceC0564a.a(task, bVar.e, bVar.g.get(), bVar.f);
        }
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void b(boolean isAlwaysRecoverAssistModel) {
        this.f3444a.b(isAlwaysRecoverAssistModel);
    }
}
