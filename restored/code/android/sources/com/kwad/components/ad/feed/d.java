package com.kwad.components.ad.feed;

import android.content.Context;
import android.os.SystemClock;
import android.os.Vibrator;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private static com.kwad.sdk.core.g.d hm;
    private static com.kwad.sdk.core.g.c hn;
    private static Vibrator ho;
    private static List<c> hp = new CopyOnWriteArrayList();
    private static List<a> hq = new CopyOnWriteArrayList();
    private static long hr;

    public interface b {
        boolean s(String str);
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.feed.d$d, reason: collision with other inner class name */
    public interface InterfaceC0364d {
        boolean b(double d);
    }

    public static class c {
        private InterfaceC0364d hv;
        private Context mContext;

        public c(InterfaceC0364d interfaceC0364d, Context context) {
            this.hv = interfaceC0364d;
            this.mContext = context;
        }
    }

    public static class a {
        private b hu;
        private Context mContext;

        public a(b bVar, Context context) {
            this.hu = bVar;
            this.mContext = context;
        }
    }

    public static void a(boolean z, float f, Context context, InterfaceC0364d interfaceC0364d, boolean z2) {
        if (hm == null) {
            a(z, f, context, z2);
        }
        hp.add(new c(interfaceC0364d, context));
    }

    public static void a(InterfaceC0364d interfaceC0364d) {
        for (c cVar : hp) {
            if (cVar != null && cVar.hv == interfaceC0364d) {
                hp.remove(cVar);
            }
        }
        com.kwad.sdk.core.d.c.d("KSFeedRotateAndShakeManager", "sShakeItems size " + hp.size());
    }

    private static void a(boolean z, float f, Context context, boolean z2) {
        hm = new com.kwad.sdk.core.g.d(z, f);
        hp = new CopyOnWriteArrayList();
        hm.bG(z2);
        hm.a(new com.kwad.sdk.core.g.b() { // from class: com.kwad.components.ad.feed.d.1
            @Override // com.kwad.sdk.core.g.b
            public final void cf() {
            }

            @Override // com.kwad.sdk.core.g.b
            public final void a(double d) {
                if (d.hp != null) {
                    for (c cVar : d.hp) {
                        if (cVar != null && cVar.hv != null && cVar.hv.b(d)) {
                            by.a(cVar.mContext, d.F(cVar.mContext));
                            break;
                        }
                    }
                    by.a(new bi() { // from class: com.kwad.components.ad.feed.d.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            com.kwad.sdk.core.d.c.d("KSFeedRotateAndShakeManager", "onShakeEvent openGate2");
                            if (d.hm != null) {
                                d.hm.NS();
                            }
                        }
                    }, null, 500L);
                }
            }
        });
        hm.m(f);
        hm.ca(context);
    }

    public static void a(AdMatrixInfo.RotateInfo rotateInfo, Context context, b bVar) {
        com.kwad.sdk.core.g.c cVar = hn;
        if (cVar == null) {
            a(rotateInfo, context);
        } else {
            cVar.a(rotateInfo);
        }
        hq.add(new a(bVar, context));
    }

    public static void a(b bVar) {
        for (a aVar : hq) {
            if (aVar != null && aVar.hu == bVar) {
                hq.remove(aVar);
            }
        }
        com.kwad.sdk.core.d.c.d("KSFeedRotateAndShakeManager", "sRotateItems size " + hq.size());
    }

    private static void a(AdMatrixInfo.RotateInfo rotateInfo, Context context) {
        com.kwad.sdk.core.g.c cVar = new com.kwad.sdk.core.g.c(rotateInfo);
        hn = cVar;
        cVar.a(new com.kwad.sdk.core.g.a() { // from class: com.kwad.components.ad.feed.d.2
            @Override // com.kwad.sdk.core.g.a
            public final void cg() {
            }

            @Override // com.kwad.sdk.core.g.a
            public final void r(String str) {
                a aVar;
                if (d.hq != null) {
                    Iterator it = d.hq.iterator();
                    while (it.hasNext() && ((aVar = (a) it.next()) == null || aVar.hu == null || !aVar.hu.s(str))) {
                    }
                    by.a(new bi() { // from class: com.kwad.components.ad.feed.d.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            com.kwad.sdk.core.d.c.d("KSFeedRotateAndShakeManager", "onRotateEvent openGate2");
                            if (d.hn != null) {
                                d.hn.NS();
                            }
                        }
                    }, null, 1000L);
                }
            }
        });
        hn.ca(context);
    }

    public static void D(Context context) {
        try {
            com.kwad.sdk.core.g.c cVar = hn;
            if (cVar != null) {
                cVar.cb(context);
                hn = null;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void E(Context context) {
        try {
            com.kwad.sdk.core.g.d dVar = hm;
            if (dVar != null) {
                dVar.cb(context);
                hm = null;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static Vibrator F(Context context) {
        if (ho == null) {
            ho = (Vibrator) context.getSystemService("vibrator");
        }
        return ho;
    }

    public static synchronized boolean ca() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (!(jElapsedRealtime - hr > 500)) {
            return false;
        }
        hr = jElapsedRealtime;
        return true;
    }
}
