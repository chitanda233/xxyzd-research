package com.kwad.components.core.c;

import com.kwad.sdk.core.response.model.AdTemplate;
import java.lang.ref.WeakReference;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class g {
    private static volatile g Pt;
    private ConcurrentHashMap<String, WeakReference<Object>> Ps = new ConcurrentHashMap<>();

    public static g oS() {
        if (Pt == null) {
            synchronized (g.class) {
                if (Pt == null) {
                    Pt = new g();
                }
            }
        }
        return Pt;
    }

    public final boolean a(i iVar) {
        String strB = b(iVar);
        com.kwad.sdk.core.d.c.d("AdMemCachePool", "contains key: " + strB);
        boolean z = false;
        if (!this.Ps.containsKey(strB)) {
            return false;
        }
        WeakReference<Object> weakReference = this.Ps.get(strB);
        if (weakReference != null && weakReference.get() != null) {
            z = true;
        }
        if (z) {
            com.kwad.sdk.core.d.c.d("AdMemCachePool", "contains ad: " + weakReference.get());
        }
        return z;
    }

    public final void add(Object obj) {
        if (obj instanceof com.kwad.components.core.internal.api.a) {
            this.Ps.put(az(((com.kwad.components.core.internal.api.a) obj).getAdTemplate()), new WeakReference<>(obj));
        }
    }

    public final void ay(AdTemplate adTemplate) {
        this.Ps.remove(az(adTemplate));
    }

    private static String b(i iVar) {
        return iVar.oM() + "-" + iVar.pb();
    }

    private static String az(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.e.eF(adTemplate) + "-" + com.kwad.sdk.core.response.helper.e.eW(adTemplate);
    }
}
