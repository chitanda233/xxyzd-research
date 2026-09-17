package com.kwad.components.core.webview.tachikoma;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.ConcurrentSkipListMap;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private final Map<String, HashMap<Integer, String>> asu = new ConcurrentHashMap();
    private Map<String, Integer> asv = new ConcurrentSkipListMap();
    private int asw = 0;

    static class a {
        private static final h asx = new h();
    }

    public static h yW() {
        return a.asx;
    }

    public final void b(String str, int i, String str2) {
        if (TextUtils.isEmpty(str2) || com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPX) == 0) {
            return;
        }
        if (this.asu.containsKey(str)) {
            HashMap<Integer, String> map = this.asu.get(str);
            if (map != null && map.containsKey(Integer.valueOf(i))) {
                return;
            } else {
                this.asu.remove(str);
            }
        }
        bW(bH(str2));
        HashMap<Integer, String> map2 = new HashMap<>();
        map2.put(Integer.valueOf(i), str2);
        this.asu.put(str, map2);
        s(str, str2);
    }

    public final String o(String str, int i) {
        HashMap<Integer, String> map;
        return (com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPX) != 0 && this.asu.containsKey(str) && (map = this.asu.get(str)) != null && map.containsKey(Integer.valueOf(i))) ? map.get(Integer.valueOf(i)) : "";
    }

    private static int bH(String str) {
        return ((((str.length() * 2) + 12) + 16) + 16) / 1024;
    }

    private void s(String str, String str2) {
        int iBH = bH(str2);
        this.asw += iBH;
        this.asv.put(str, Integer.valueOf(iBH));
    }

    private void bW(int i) {
        try {
            if (this.asw + i > com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPX)) {
                ArrayList arrayList = new ArrayList();
                Iterator<Map.Entry<String, Integer>> it = this.asv.entrySet().iterator();
                while (it.hasNext()) {
                    Map.Entry<String, Integer> next = it.next();
                    arrayList.add(next.getKey());
                    this.asw -= next.getValue().intValue();
                    it.remove();
                    if (this.asw <= com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPX) - i) {
                        break;
                    }
                }
                Iterator it2 = arrayList.iterator();
                while (it2.hasNext()) {
                    this.asu.remove((String) it2.next());
                }
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }
}
