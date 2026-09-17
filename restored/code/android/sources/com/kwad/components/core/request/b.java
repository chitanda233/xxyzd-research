package com.kwad.components.core.request;

import com.kwad.sdk.service.ServiceProvider;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final List<a> ajG;

    public interface a {
        void we();
    }

    /* synthetic */ b(byte b) {
        this();
    }

    /* JADX INFO: renamed from: com.kwad.components.core.request.b$b, reason: collision with other inner class name */
    static class C0458b {
        private static final b ajH = new b(0);
    }

    public static b wc() {
        return C0458b.ajH;
    }

    private b() {
        this.ajG = new CopyOnWriteArrayList();
    }

    public final void a(a aVar) {
        this.ajG.add(aVar);
    }

    public final void b(a aVar) {
        this.ajG.remove(aVar);
    }

    public final void wd() {
        for (a aVar : this.ajG) {
            if (aVar != null) {
                try {
                    aVar.we();
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        }
    }
}
