package com.kwad.sdk.core.threads;

import android.os.Handler;
import android.os.HandlerThread;
import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.ThreadPoolExecutor;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {
    public static final String TAG = "c";
    private static int aYI;
    private static int aYJ;
    private static int aYK;
    private static final ConcurrentHashMap<ThreadPoolExecutor, Long> aYL = new ConcurrentHashMap<>();
    private static final ConcurrentHashMap<ThreadPoolExecutor, String> aYM = new ConcurrentHashMap<>();
    private static long interval;
    private static long startTime;

    static /* synthetic */ int Oz() {
        int i = aYI;
        aYI = i + 1;
        return i;
    }

    public static void a(ThreadPoolExecutor threadPoolExecutor, String str) {
        aYL.put(threadPoolExecutor, Long.valueOf(threadPoolExecutor.getCompletedTaskCount()));
        aYM.put(threadPoolExecutor, str);
    }

    public static void dA(final String str) {
        i.execute(new bi() { // from class: com.kwad.sdk.core.threads.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                d dVarFp;
                if (TextUtils.isEmpty(str) || (dVarFp = c.fp(str)) == null || dVarFp.aYJ == 0) {
                    return;
                }
                int unused = c.aYJ = dVarFp.aYJ;
                if (Math.random() * ((double) c.aYJ) >= 1.0d) {
                    return;
                }
                c.a(dVarFp);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(d dVar) {
        com.kwad.sdk.core.threads.a.b.aYQ = true;
        com.kwad.sdk.core.threads.a.a.aYQ = true;
        interval = dVar.interval;
        aYK = dVar.aYP;
        HandlerThread handlerThread = new HandlerThread("pollingHT");
        handlerThread.start();
        final Handler handler = new Handler(handlerThread.getLooper());
        startTime = SystemClock.elapsedRealtime();
        handler.post(new bi() { // from class: com.kwad.sdk.core.threads.c.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ExecutorService executorServiceFo;
                for (String str : GlobalThreadPools.Ot()) {
                    if (str != null && !c.aYM.containsValue(str) && (executorServiceFo = GlobalThreadPools.fo(str)) != null && (executorServiceFo instanceof ThreadPoolExecutor) && !c.aYL.containsKey(executorServiceFo)) {
                        c.a((ThreadPoolExecutor) executorServiceFo, str);
                    }
                }
                int poolSize = 0;
                for (ThreadPoolExecutor threadPoolExecutor : c.aYM.keySet()) {
                    String str2 = (String) c.aYM.get(threadPoolExecutor);
                    poolSize += threadPoolExecutor.getPoolSize();
                    b bVarB = c.b(threadPoolExecutor, str2);
                    if (bVarB != null) {
                        com.kwad.sdk.commercial.c.s(bVarB);
                    }
                }
                b bVar = new b();
                bVar.aYy = "total";
                bVar.aYB = poolSize;
                com.kwad.sdk.commercial.c.s(bVar);
                c.Oz();
                if (c.aYI < c.aYK) {
                    handler.postDelayed(this, c.interval);
                }
            }
        });
    }

    /* JADX WARN: Multi-variable type inference failed */
    public static b b(ThreadPoolExecutor threadPoolExecutor, String str) {
        if (threadPoolExecutor == 0) {
            return null;
        }
        b bVar = new b();
        bVar.aYy = str;
        bVar.aYz = threadPoolExecutor.getCorePoolSize();
        bVar.aYA = threadPoolExecutor.getMaximumPoolSize();
        bVar.aYB = threadPoolExecutor.getPoolSize();
        bVar.aYC = threadPoolExecutor.getActiveCount();
        bVar.aYF = threadPoolExecutor.getQueue() == null ? 0 : threadPoolExecutor.getQueue().size();
        ConcurrentHashMap<ThreadPoolExecutor, Long> concurrentHashMap = aYL;
        long jLongValue = (!concurrentHashMap.containsKey(threadPoolExecutor) || concurrentHashMap.get(threadPoolExecutor) == null) ? 0L : concurrentHashMap.get(threadPoolExecutor).longValue();
        long completedTaskCount = threadPoolExecutor.getCompletedTaskCount();
        bVar.aYE = completedTaskCount - jLongValue;
        concurrentHashMap.put(threadPoolExecutor, Long.valueOf(completedTaskCount));
        if (threadPoolExecutor instanceof com.kwad.sdk.core.threads.a.c) {
            bVar.aYD = ((com.kwad.sdk.core.threads.a.c) threadPoolExecutor).OD();
        } else {
            bVar.aYD = 0L;
        }
        bVar.aYG = SystemClock.elapsedRealtime() - startTime;
        bVar.interval = interval;
        bVar.aYH = aYJ;
        return bVar;
    }

    public static d fp(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            d dVar = new d();
            dVar.parseJson(jSONObject);
            return dVar;
        } catch (Exception unused) {
            return null;
        }
    }
}
