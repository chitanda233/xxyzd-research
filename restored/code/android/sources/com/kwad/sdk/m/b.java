package com.kwad.sdk.m;

import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.q;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    public static final String TAG = "Ranger_b";
    private List<com.kwad.sdk.m.a.a> bmI;

    static class a {
        private static final b bmM = new b();
    }

    public static b TM() {
        return a.bmM;
    }

    public final void b(d dVar) {
        List<com.kwad.sdk.m.a.a> list = dVar.bmI;
        if (list == null || list.isEmpty()) {
            return;
        }
        this.bmI = list;
    }

    public final void start() {
        TN();
        List<com.kwad.sdk.m.a.a> list = this.bmI;
        if (list == null) {
            com.kwad.sdk.core.d.c.w(TAG, "aggregationCheckConfigList is null");
            return;
        }
        for (com.kwad.sdk.m.a.a aVar : list) {
            try {
                if (T(aVar.bna)) {
                    ft(aVar.bmZ);
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.w(TAG, Log.getStackTraceString(e));
            }
            try {
                if (aVar.bnb != null) {
                    a(aVar);
                }
            } catch (Exception e2) {
                com.kwad.sdk.core.d.c.w(TAG, Log.getStackTraceString(e2));
            }
        }
    }

    private void a(com.kwad.sdk.m.a.a aVar) {
        String strA = c.TR().a(aVar.bnb);
        if (TextUtils.isEmpty(strA)) {
            return;
        }
        D(aVar.bmZ, strA);
    }

    private boolean T(List<String> list) {
        if (list == null || list.isEmpty()) {
            return false;
        }
        Iterator<String> it = list.iterator();
        boolean z = true;
        while (it.hasNext()) {
            boolean zHt = false;
            for (String str : hu(it.next())) {
                zHt = ht(str);
                if (zHt) {
                    break;
                }
            }
            z &= zHt;
        }
        return z;
    }

    private static boolean ht(String str) {
        try {
            Class.forName(str);
            return true;
        } catch (Exception unused) {
            return false;
        }
    }

    private static String[] hu(String str) {
        return str.contains("_") ? str.split("_") : new String[]{str};
    }

    public final void hv(final String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        GlobalThreadPools.Og().execute(new Runnable() { // from class: com.kwad.sdk.m.b.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (b.this.bmI != null && !b.this.bmI.isEmpty()) {
                        for (com.kwad.sdk.m.a.a aVar : b.this.bmI) {
                            if (b.b(str, aVar.bnc)) {
                                b.fx(aVar.bmZ);
                            }
                        }
                    }
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.w(b.TAG, Log.getStackTraceString(e));
                }
            }
        });
    }

    public final void c(final StackTraceElement[] stackTraceElementArr) {
        if (stackTraceElementArr == null || stackTraceElementArr.length == 0) {
            return;
        }
        GlobalThreadPools.Og().execute(new Runnable() { // from class: com.kwad.sdk.m.b.2
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (b.this.bmI != null && !b.this.bmI.isEmpty()) {
                        for (com.kwad.sdk.m.a.a aVar : b.this.bmI) {
                            if (b.a(stackTraceElementArr, aVar.bnd)) {
                                b.fz(aVar.bmZ);
                            }
                        }
                    }
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.w(b.TAG, Log.getStackTraceString(e));
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean a(StackTraceElement[] stackTraceElementArr, List<String> list) {
        boolean z;
        if (list == null || list.isEmpty()) {
            return false;
        }
        Iterator<String> it = list.iterator();
        do {
            z = true;
            if (!it.hasNext()) {
                return true;
            }
            String next = it.next();
            int length = stackTraceElementArr.length;
            int i = 0;
            while (true) {
                if (i >= length) {
                    z = false;
                    break;
                }
                if (q.a(stackTraceElementArr[i]).contains(next)) {
                    break;
                }
                i++;
            }
        } while (z);
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean b(String str, List<String> list) {
        if (list == null || list.isEmpty()) {
            return false;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (!str.contains(it.next())) {
                return false;
            }
        }
        return true;
    }

    private void TN() {
        long jUM = q.UM();
        if (jUM <= 0) {
            return;
        }
        aX(jUM);
    }

    public final void TO() {
        boolean z = false;
        for (int i = 0; i < this.bmI.size(); i++) {
            com.kwad.sdk.m.a.a aVar = this.bmI.get(i);
            if (fu(aVar.bmZ)) {
                com.kwad.sdk.commercial.c.v(fv(aVar.bmZ));
                z = true;
            }
        }
        if (z) {
            return;
        }
        com.kwad.sdk.commercial.c.v(fv(-1));
    }

    public final void clearAll() {
        for (int i = 0; i < this.bmI.size(); i++) {
            fw(i);
            fy(i);
            fA(i);
            TP();
            fB(i);
        }
    }

    private static void ft(int i) {
        ai.a("ksadsdk_perf_ranger_v2", "aggregation_sdk" + ("_" + i), 1);
    }

    private static boolean fu(int i) {
        return ai.b("ksadsdk_perf_ranger_v2", new StringBuilder("aggregation_sdk").append(new StringBuilder("_").append(i).toString()).toString(), -1) == 1;
    }

    private static com.kwad.sdk.m.b.a.a fv(int i) {
        com.kwad.sdk.m.b.a.a aVar = new com.kwad.sdk.m.b.a.a();
        String str = "_" + i;
        aVar.fD(i);
        aVar.hx(ai.i("ksadsdk_perf_ranger_v2", "aggregation_version" + str, ""));
        aVar.fE(ai.b("ksadsdk_perf_ranger_v2", "crash_times" + str, 0));
        aVar.fF(ai.b("ksadsdk_perf_ranger_v2", "call_ks_union_times" + str, 0));
        aVar.aY(ai.b("ksadsdk_perf_ranger_v2", "ks_launch_delay", -1L));
        aVar.aZ(ai.b("ksadsdk_perf_ranger_v2", "aggregation_launch_delay" + str, -1L));
        return aVar;
    }

    private static void D(int i, String str) {
        ai.h("ksadsdk_perf_ranger_v2", "aggregation_version" + ("_" + i), str);
    }

    private static void fw(int i) {
        ai.h("ksadsdk_perf_ranger_v2", "aggregation_version" + ("_" + i), "");
    }

    public static void fx(int i) {
        String str = "_" + i;
        ai.a("ksadsdk_perf_ranger_v2", "crash_times" + str, ai.b("ksadsdk_perf_ranger_v2", "crash_times" + str, -1) + 1);
    }

    private static void fy(int i) {
        ai.a("ksadsdk_perf_ranger_v2", "crash_times" + ("_" + i), 0);
    }

    public static void fz(int i) {
        String str = "_" + i;
        ai.a("ksadsdk_perf_ranger_v2", "call_ks_union_times" + str, ai.b("ksadsdk_perf_ranger_v2", "call_ks_union_times" + str, -1) + 1);
    }

    private static void fA(int i) {
        ai.a("ksadsdk_perf_ranger_v2", "call_ks_union_times" + ("_" + i), 0);
    }

    private static void aX(long j) {
        ai.a("ksadsdk_perf_ranger_v2", "ks_launch_delay", j);
    }

    private static void TP() {
        ai.a("ksadsdk_perf_ranger_v2", "ks_launch_delay", 0L);
    }

    private static void fB(int i) {
        ai.a("ksadsdk_perf_ranger_v2", "aggregation_launch_delay" + ("_" + i), 0L);
    }
}
