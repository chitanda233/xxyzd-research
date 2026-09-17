package com.kwad.framework.filedownloader.a;

import com.kwad.framework.filedownloader.f.f;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private static boolean cq(int i) {
        return i == 301 || i == 302 || i == 303 || i == 300 || i == 307 || i == 308;
    }

    public static b a(Map<String, List<String>> map, b bVar, List<String> list) throws IllegalAccessException {
        int responseCode = bVar.getResponseCode();
        String strBU = bVar.bU("Location");
        ArrayList arrayList = new ArrayList();
        int i = 0;
        while (cq(responseCode)) {
            if (strBU == null) {
                throw new IllegalAccessException(f.c("receive %d (redirect) but the location is null with response [%s]", Integer.valueOf(responseCode), bVar.Cb()));
            }
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(d.class, "redirect to %s with %d, %s", strBU, Integer.valueOf(responseCode), arrayList);
            }
            bVar.Cc();
            bVar = a(map, strBU);
            arrayList.add(strBU);
            bVar.execute();
            responseCode = bVar.getResponseCode();
            strBU = bVar.bU("Location");
            i++;
            if (i >= 10) {
                throw new IllegalAccessException(f.c("redirect too many times! %s", arrayList));
            }
        }
        if (list != null) {
            list.addAll(arrayList);
        }
        return bVar;
    }

    private static b a(Map<String, List<String>> map, String str) {
        b bVarBY = com.kwad.framework.filedownloader.download.b.Cm().bY(str);
        for (Map.Entry<String, List<String>> entry : map.entrySet()) {
            String key = entry.getKey();
            List<String> value = entry.getValue();
            if (value != null) {
                Iterator<String> it = value.iterator();
                while (it.hasNext()) {
                    bVarBY.addHeader(key, it.next());
                }
            }
        }
        return bVarBY;
    }
}
