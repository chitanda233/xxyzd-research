package com.kwad.components.core.j;

import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private Object abe;
    private AdTemplate abf;

    public static List<AdTemplate> q(List<c> list) {
        ArrayList arrayList = new ArrayList();
        Iterator<c> it = list.iterator();
        while (it.hasNext()) {
            arrayList.add(it.next().getAdTemplate());
        }
        return arrayList;
    }

    public c(AdTemplate adTemplate, int i) {
        this.abe = null;
        try {
            this.abe = new b(adTemplate, i);
        } catch (Throwable unused) {
            this.abf = adTemplate;
        }
    }

    public final Object getHost() {
        return this.abe;
    }

    public final AdTemplate getAdTemplate() {
        AdTemplate adTemplate;
        Object obj = this.abe;
        if (obj != null) {
            try {
                adTemplate = ((b) obj).getAdTemplate();
            } catch (Exception unused) {
                adTemplate = null;
            }
        } else {
            adTemplate = null;
        }
        return adTemplate == null ? this.abf : adTemplate;
    }
}
