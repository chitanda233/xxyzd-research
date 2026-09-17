package com.kwad.components.core.c;

import com.kwad.sdk.core.response.model.AdResultData;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private Map<Integer, AdResultData> Pn = new ConcurrentHashMap();
    private AtomicInteger Po = new AtomicInteger(0);
    private Map<Integer, h> Pp = new ConcurrentHashMap();
    private AtomicInteger Pq = new AtomicInteger(0);

    static class a {
        static f Pr = new f();
    }

    public static f oR() {
        return a.Pr;
    }

    public final int l(AdResultData adResultData) {
        if (adResultData == null) {
            return 0;
        }
        int iIncrementAndGet = this.Po.incrementAndGet();
        this.Pn.put(Integer.valueOf(iIncrementAndGet), adResultData);
        return iIncrementAndGet;
    }

    public final AdResultData d(int i, boolean z) {
        AdResultData adResultData = this.Pn.get(Integer.valueOf(i));
        this.Pn.remove(Integer.valueOf(i));
        return adResultData;
    }

    public final int a(h hVar) {
        int iIncrementAndGet = this.Pq.incrementAndGet();
        this.Pp.put(Integer.valueOf(iIncrementAndGet), hVar);
        return iIncrementAndGet;
    }

    public final h e(int i, boolean z) {
        h hVar = this.Pp.get(Integer.valueOf(i));
        this.Pp.remove(Integer.valueOf(i));
        return hVar;
    }
}
