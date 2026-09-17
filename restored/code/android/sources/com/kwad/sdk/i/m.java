package com.kwad.sdk.i;

import com.kwai.adclient.kscommerciallogger.model.BusinessType;
import com.kwai.adclient.kscommerciallogger.model.SubBusinessType;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
final class m {
    private static final Map<String, k> biR = new ConcurrentHashMap();
    private static long biS;

    static synchronized void a(i iVar, boolean z) {
        Map<String, k> map = biR;
        if (map.size() > 200) {
            j.am("LogRequestManger", "enqueueAction fail size limit");
        } else {
            k kVarB = b(iVar, z);
            map.put(kVarB.actionId, kVarB);
        }
        Sm();
    }

    static void Sm() {
        long jCurrentTimeMillis = System.currentTimeMillis() - biS;
        if (biR.size() <= 0 || jCurrentTimeMillis <= h.RZ().Sf()) {
            return;
        }
        biS = System.currentTimeMillis();
        final List<k> actionList = getActionList();
        actionList.size();
        j.Sk();
        l.a(actionList, new l.a() { // from class: com.kwad.sdk.i.m.1
            @Override // com.kwad.sdk.i.l.a
            public final void onSuccess() {
                j.Sk();
                m.H(actionList);
            }
        });
    }

    private static synchronized List<k> getActionList() {
        ArrayList arrayList;
        Map<String, k> map = biR;
        arrayList = new ArrayList(map.size());
        Iterator<Map.Entry<String, k>> it = map.entrySet().iterator();
        while (it.hasNext()) {
            arrayList.add(it.next().getValue());
        }
        return arrayList;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static synchronized void H(List<k> list) {
        if (list != null) {
            Iterator<k> it = list.iterator();
            while (it.hasNext()) {
                biR.remove(it.next().actionId);
            }
        }
    }

    private static k b(i iVar, boolean z) {
        com.kwai.adclient.kscommerciallogger.model.c.a aVarYv;
        if (z) {
            aVarYv = com.kwai.adclient.kscommerciallogger.model.c.a.Yu();
        } else {
            aVarYv = com.kwai.adclient.kscommerciallogger.model.c.a.Yv();
        }
        com.kwai.adclient.kscommerciallogger.model.c cVarYw = aVarYv.c(BusinessType.OTHER).b(SubBusinessType.OTHER).iE("ad_sdk_local_log").iD(iVar.biK).B(iVar.toJson()).Yw();
        return new k(cVarYw.Yo(), cVarYw.toString(), iVar);
    }
}
