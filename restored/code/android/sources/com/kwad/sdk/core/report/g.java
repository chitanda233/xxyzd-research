package com.kwad.sdk.core.report;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public class g extends b<n, f> {
    private static volatile boolean aVk = false;
    private static volatile g aVl;
    private static r<n, f> aVm;

    private g() {
    }

    private static g Nj() {
        if (aVl == null) {
            synchronized (g.class) {
                if (aVl == null) {
                    aVl = new g();
                }
            }
        }
        aVl.checkInit();
        return aVl;
    }

    public static void a(n nVar) {
        a(nVar, false);
    }

    public static void a(n nVar, boolean z) {
        Nj().b(nVar, z);
    }

    private void b(final n nVar, boolean z) {
        if (nVar == null || !aVk) {
            return;
        }
        if (z || ak(nVar.actionType)) {
            aVl.b(new k<n>() { // from class: com.kwad.sdk.core.report.g.1
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.core.report.k
                /* JADX INFO: renamed from: Nk, reason: merged with bridge method [inline-methods] */
                public n Nf() {
                    return nVar.Nm();
                }
            });
        } else {
            aVl.a(new k<n>() { // from class: com.kwad.sdk.core.report.g.2
                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.sdk.core.report.k
                /* JADX INFO: renamed from: Nk, reason: merged with bridge method [inline-methods] */
                public n Nf() {
                    return nVar.Nm();
                }
            });
        }
    }

    private static boolean ak(long j) {
        s sVar = (s) ServiceProvider.get(s.class);
        return sVar != null && sVar.ak(j);
    }

    private synchronized void checkInit() {
        if (aVk) {
            return;
        }
        com.kwad.sdk.service.a.f fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class);
        if (fVar == null) {
            return;
        }
        com.kwad.sdk.service.a.h hVar = (com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class);
        if (hVar == null) {
            return;
        }
        Context context = fVar.getContext();
        if (context == null) {
            return;
        }
        int iBe = hVar.be(context);
        j(context, iBe);
        t.init(context);
        t.Ns();
        com.kwad.sdk.core.d.c.d("BatchReporter", "cache type = " + iBe);
        if (iBe == 2) {
            a(q.bX(context));
        }
        aVk = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.report.b
    /* JADX INFO: renamed from: b, reason: merged with bridge method [inline-methods] */
    public f a(n nVar) {
        r<n, f> rVar = aVm;
        if (rVar != null) {
            return (f) rVar.Nq();
        }
        return (f) super.a(nVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.report.b
    /* JADX INFO: renamed from: I, reason: merged with bridge method [inline-methods] */
    public f G(List<n> list) {
        r<n, f> rVar = aVm;
        if (rVar != null) {
            return (f) rVar.Nr();
        }
        String strJ = J(list);
        if (!TextUtils.isEmpty(strJ)) {
            return new f(strJ);
        }
        return new f(list);
    }

    private static String J(List<n> list) {
        if (list.get(0) == null || TextUtils.isEmpty(list.get(0).aWA)) {
            return "";
        }
        StringBuilder sb = new StringBuilder(",\"actionList\":[");
        Iterator<n> it = list.iterator();
        while (it.hasNext()) {
            sb.append(it.next().aWA).append(',');
        }
        int length = sb.length();
        sb.replace(length - 1, length, "]");
        return sb.toString();
    }

    @Override // com.kwad.sdk.core.report.b
    protected final Runnable a(Context context, l<n> lVar, AtomicInteger atomicInteger) {
        Runnable runnableNp;
        r<n, f> rVar = aVm;
        return (rVar == null || (runnableNp = rVar.Np()) == null) ? super.a(context, lVar, atomicInteger) : runnableNp;
    }
}
