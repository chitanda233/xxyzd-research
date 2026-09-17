package com.kwad.sdk.pngencrypt.chunk;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class w {
    private final e bmq;
    private final boolean bmr;

    public w(e eVar) {
        this.bmq = eVar;
        if (eVar instanceof f) {
            this.bmr = false;
        } else {
            this.bmr = true;
        }
    }

    private List<? extends t> hr(String str) {
        ArrayList arrayList = new ArrayList();
        arrayList.addAll(this.bmq.ao("tEXt", str));
        arrayList.addAll(this.bmq.ao("zTXt", str));
        arrayList.addAll(this.bmq.ao("iTXt", str));
        return arrayList;
    }

    public final String hs(String str) {
        List<? extends t> listHr = hr(str);
        if (listHr.isEmpty()) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        Iterator<? extends t> it = listHr.iterator();
        while (it.hasNext()) {
            sb.append(it.next().TJ()).append("\n");
        }
        return sb.toString().trim();
    }
}
