package com.kwad.components.core.pfmonitor;

import android.content.Context;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private static volatile boolean ain = false;

    static /* synthetic */ boolean access$002(boolean z) {
        ain = true;
        return true;
    }

    public static void aE(final Context context) {
        int iLg = e.Lg();
        com.kwad.sdk.core.d.c.d("DiskScanner", "startByConfig delay: " + iLg + "ms, context: " + context);
        if (iLg <= 0) {
            return;
        }
        by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.core.pfmonitor.d.1
            @Override // java.lang.Runnable
            public final void run() {
                d.aF(context);
            }
        }, iLg);
    }

    public static void aF(final Context context) {
        String strLh = e.Lh();
        com.kwad.sdk.core.d.c.d("DiskScanner", "startByConfig confStr: " + strLh);
        final com.kwad.components.core.pfmonitor.model.b bVarBd = com.kwad.components.core.pfmonitor.model.b.bd(strLh);
        GlobalThreadPools.Oe().submit(new Runnable() { // from class: com.kwad.components.core.pfmonitor.d.2
            @Override // java.lang.Runnable
            public final void run() {
                com.kwad.sdk.core.d.c.d("DiskScanner", "startByConfig run call hadStarted: " + d.ain);
                if (d.ain) {
                    return;
                }
                d.access$002(true);
                ArrayList<com.kwad.components.core.pfmonitor.model.c> arrayList = new ArrayList();
                com.kwad.components.core.pfmonitor.model.b bVar = bVarBd;
                if (bVar != null) {
                    for (com.kwad.components.core.pfmonitor.model.a aVar : bVar.vE()) {
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        com.kwad.components.core.pfmonitor.model.c cVarA = d.a(context, aVar, bVarBd.air);
                        int iCurrentTimeMillis = (int) (System.currentTimeMillis() - jCurrentTimeMillis);
                        if (cVarA != null) {
                            arrayList.add(cVarA);
                            com.kwad.sdk.core.d.c.d("DiskScanner", "startByConfig result: " + cVarA + " , duration: " + iCurrentTimeMillis);
                        }
                    }
                }
                ArrayList arrayList2 = new ArrayList();
                ArrayList arrayList3 = new ArrayList();
                for (com.kwad.components.core.pfmonitor.model.c cVar : arrayList) {
                    arrayList2.add(cVar.vF());
                    arrayList3.addAll(cVar.vG());
                }
                c.r(arrayList2);
                c.s(arrayList3);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static com.kwad.components.core.pfmonitor.model.c a(Context context, com.kwad.components.core.pfmonitor.model.a aVar, int i) {
        com.kwad.components.core.pfmonitor.model.e eVarJ = com.kwad.components.core.pfmonitor.model.e.j(context, aVar.aip);
        if (eVarJ != null) {
            a aVar2 = new a(eVarJ, i);
            aVar2.run();
            if (aVar2.getStatus() == 2) {
                return aVar2.vD();
            }
        }
        return null;
    }

    public static String M(long j) {
        if (j < 1024) {
            return j + " B";
        }
        if (j < 1048576) {
            return String.format("%.1f KB", Double.valueOf(j / 1024.0d));
        }
        return j < 1073741824 ? String.format("%.1f MB", Double.valueOf(j / 1048576.0d)) : String.format("%.1f GB", Double.valueOf(j / 1.073741824E9d));
    }
}
