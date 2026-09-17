package com.kwad.sdk.core.a;

import com.kwad.sdk.components.DevelopMangerComponents;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private static h aSF;

    public static void h(Map<String, String> map) {
        qQ().h(map);
    }

    public static String av(String str) {
        return qQ().av(str);
    }

    public static String getResponseData(String str) {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return qQ().getResponseData(str);
    }

    public static void a(String str, Map<String, String> map, String str2) {
        qQ().a(str, map, str2);
    }

    private static h qQ() {
        h hVar = aSF;
        if (hVar != null) {
            return hVar;
        }
        com.kwad.sdk.components.h hVar2 = (com.kwad.sdk.components.h) com.kwad.sdk.components.d.f(com.kwad.sdk.components.h.class);
        if (hVar2 != null) {
            hVar2.qQ();
            aSF = hVar2.qQ();
        } else {
            aSF = new a();
        }
        return aSF;
    }
}
