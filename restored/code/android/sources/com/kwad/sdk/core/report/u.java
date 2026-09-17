package com.kwad.sdk.core.report;

import android.content.Context;
import com.kwad.sdk.core.network.f;
import com.kwad.sdk.core.report.e;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bt;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.atomic.AtomicLong;

/* JADX INFO: loaded from: classes3.dex */
public final class u<T extends e, R extends com.kwad.sdk.core.network.f> implements Runnable {
    private static AtomicLong aWJ = new AtomicLong(-1);
    protected final l<T> aUU;
    protected final b<T, R> aWK;
    protected final AtomicInteger aWL;
    protected final Context mContext;

    public interface a {
        void Ny();
    }

    public u(Context context, l<T> lVar, b<T, R> bVar, AtomicInteger atomicInteger) {
        this.mContext = context;
        this.aUU = lVar;
        this.aWK = bVar;
        this.aWL = atomicInteger;
    }

    @Override // java.lang.Runnable
    public final void run() {
        if (this.aWL.get() > 0 || !aq.isNetworkConnected(this.mContext)) {
            return;
        }
        Nx();
    }

    protected final void Nx() {
        long jWR = bt.WR();
        if (jWR >= aWJ.get() * 2) {
            try {
                List<T> listEu = this.aUU.eu(200);
                if (listEu.isEmpty()) {
                    return;
                }
                this.aWK.a(listEu, new AtomicBoolean(false), new a() { // from class: com.kwad.sdk.core.report.u.1
                    @Override // com.kwad.sdk.core.report.u.a
                    public final void Ny() {
                        u.this.Nx();
                    }
                });
            } catch (OutOfMemoryError e) {
                aWJ.set(jWR);
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(e);
            } catch (Throwable th) {
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(th);
            }
        }
    }
}
