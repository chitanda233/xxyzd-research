package com.kwad.sdk.collector;

import android.content.Context;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aa;
import com.kwad.sdk.utils.aw;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    public static JSONArray Im() {
        Context context = ServiceProvider.getContext();
        List<g> listBF = bF(context);
        listBF.add(bE(context));
        return g.C(listBF);
    }

    private static g bE(Context context) {
        boolean zDJ = aw.dJ(context);
        com.kwad.sdk.core.d.c.d("InfoCollector", "queryAccessibilityServicePermission result: " + zDJ);
        return new g(com.kuaishou.weapon.p0.g.k, zDJ ? g.PERMISSION_GRANTED : g.PERMISSION_DENIED);
    }

    private static List<g> bF(Context context) {
        String[] strArrDh;
        int i;
        CopyOnWriteArrayList copyOnWriteArrayList = new CopyOnWriteArrayList();
        if (context != null && (strArrDh = aa.dh(context)) != null) {
            for (String str : strArrDh) {
                int iAA = aw.aA(context, str);
                if (iAA == 0) {
                    i = g.PERMISSION_GRANTED;
                } else if (iAA == -1) {
                    i = g.PERMISSION_DENIED;
                } else {
                    i = g.aJh;
                }
                copyOnWriteArrayList.add(new g(str, i));
            }
        }
        return copyOnWriteArrayList;
    }
}
