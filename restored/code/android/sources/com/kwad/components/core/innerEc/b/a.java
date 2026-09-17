package com.kwad.components.core.innerEc.b;

import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.network.d;
import com.sigmob.sdk.base.e;
import java.util.ArrayList;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends d {
    private Map<String, String> Ts;

    public a(Map<String, String> map) {
        this.Ts = map;
        rA();
    }

    private void rA() {
        Map<String, String> map = this.Ts;
        if (map != null) {
            addHeader(e.f3213a, d(map));
        } else {
            c.w("BaseLoginStatusRequest", "cookieMap is null" + getUrl());
        }
    }

    private static String d(Map<String, String> map) {
        Set<Map.Entry<String, String>> setEntrySet = map.entrySet();
        ArrayList arrayList = new ArrayList();
        for (Map.Entry<String, String> entry : setEntrySet) {
            arrayList.add(entry.getKey() + "=" + entry.getValue());
        }
        StringBuilder sb = new StringBuilder();
        int size = arrayList.size();
        for (int i = 0; i < size; i++) {
            sb.append((String) arrayList.get(i));
            if (i != size - 1) {
                sb.append("; ");
            }
        }
        return sb.toString();
    }
}
