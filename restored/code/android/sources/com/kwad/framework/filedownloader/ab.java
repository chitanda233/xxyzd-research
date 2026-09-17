package com.kwad.framework.filedownloader;

import android.os.Handler;
import android.util.SparseArray;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
final class ab implements w {
    private final SparseArray<Handler> aAr = new SparseArray<>();

    ab() {
    }

    @Override // com.kwad.framework.filedownloader.w
    public final void BY() {
        for (int i = 0; i < this.aAr.size(); i++) {
            b(this.aAr.get(this.aAr.keyAt(i)));
        }
    }

    @Override // com.kwad.framework.filedownloader.w
    public final void w(List<Integer> list) {
        Iterator<Integer> it = list.iterator();
        while (it.hasNext()) {
            c(this.aAr.get(it.next().intValue()));
        }
    }

    @Override // com.kwad.framework.filedownloader.w
    public final int BZ() {
        return this.aAr.size();
    }

    @Override // com.kwad.framework.filedownloader.w
    public final boolean cp(int i) {
        return this.aAr.get(i) != null;
    }

    private static void b(Handler handler) {
        handler.sendEmptyMessage(2);
    }

    private static void c(Handler handler) {
        handler.sendEmptyMessage(3);
    }
}
