package com.kwad.components.core.t;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class k {
    private static final ConcurrentHashMap<Integer, a> alF = new ConcurrentHashMap<>();
    public static final long alG = com.kwad.sdk.core.config.e.KU().longValue() * 1000;
    private static final Map<Integer, bi> alH = new ConcurrentHashMap();
    private static Map<Integer, Long> alI = new HashMap();

    public static void a(Integer num, com.kwad.sdk.components.t tVar, long j, long j2, long j3, long j4) {
        if (tVar == null && (num == null || num.intValue() == 0)) {
            return;
        }
        try {
            e(num);
            ConcurrentHashMap<Integer, a> concurrentHashMap = alF;
            a aVar = concurrentHashMap.get(num);
            if (aVar == null) {
                concurrentHashMap.put(num, new a(tVar, j, j2, j3, j4));
            } else {
                aVar.xe();
            }
        } catch (Exception e) {
            ServiceProvider.reportSdkCaughtException(e);
        }
    }

    public static com.kwad.sdk.components.t a(Integer num) {
        if (num != null && num.intValue() != 0) {
            try {
                e(num);
                a aVar = alF.get(num);
                if (aVar == null) {
                    return null;
                }
                aVar.xe();
                return aVar.alK;
            } catch (Exception e) {
                ServiceProvider.reportSdkCaughtException(e);
            }
        }
        return null;
    }

    public static a b(Integer num) {
        if (num != null && num.intValue() != 0) {
            try {
                e(num);
                a aVar = alF.get(num);
                if (aVar == null) {
                    return null;
                }
                aVar.xe();
                return aVar;
            } catch (Exception e) {
                ServiceProvider.reportSdkCaughtException(e);
            }
        }
        return null;
    }

    public static void c(Integer num) {
        if (num == null || num.intValue() == 0) {
            return;
        }
        try {
            a aVar = alF.get(num);
            if (aVar == null || aVar.xf() != 0) {
                return;
            }
            d(num);
        } catch (Exception e) {
            ServiceProvider.reportSdkCaughtException(e);
        }
    }

    private static void d(final Integer num) {
        if (num == null || num.intValue() == 0) {
            return;
        }
        e(num);
        bi biVar = new bi() { // from class: com.kwad.components.core.t.k.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a aVar = (a) k.alF.get(num);
                if (aVar != null) {
                    aVar.alK.onDestroy();
                }
                k.alI.remove(num);
                k.alF.remove(num);
            }
        };
        alH.put(num, biVar);
        by.runOnUiThreadDelay(biVar, alG);
    }

    private static void e(Integer num) {
        Map<Integer, bi> map = alH;
        bi biVar = map.get(num);
        if (biVar != null) {
            by.b(biVar);
            map.remove(num);
        }
    }

    public static class a {
        private long Kc;
        private final com.kwad.sdk.components.t alK;
        private final AtomicInteger alL;
        private long alM;
        private long alN;
        private long alO;

        public a(com.kwad.sdk.components.t tVar, long j, long j2, long j3, long j4) {
            AtomicInteger atomicInteger = new AtomicInteger(0);
            this.alL = atomicInteger;
            this.alK = tVar;
            atomicInteger.set(1);
            this.alM = j;
            this.Kc = j2;
            this.alN = j3;
            this.alO = j4;
        }

        public final long wZ() {
            return this.alM;
        }

        public final long xa() {
            return this.Kc;
        }

        public final long xb() {
            return this.alN;
        }

        public final long xc() {
            return this.alO;
        }

        public final com.kwad.sdk.components.t xd() {
            return this.alK;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void xe() {
            this.alL.incrementAndGet();
        }

        /* JADX INFO: Access modifiers changed from: private */
        public int xf() {
            return this.alL.decrementAndGet();
        }
    }
}
