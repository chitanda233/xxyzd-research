package com.kwad.components.core.pfmonitor.model;

import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private e ait;
    private final List<d> aiu;
    private List<d> aiv;
    private final long aiw;
    private final int aix;
    private final int aiy;

    public c(List<d> list, List<d> list2) {
        this.aiu = new ArrayList(list);
        this.aiv = list2;
        this.aiw = t(list);
        this.aix = b(list, false);
        this.aiy = b(list, true);
    }

    public final void a(e eVar) {
        this.ait = eVar;
    }

    private static long t(List<d> list) {
        long length = 0;
        for (d dVar : list) {
            if (!dVar.getFile().isDirectory()) {
                length += dVar.getFile().length();
            }
        }
        return length;
    }

    private static int b(List<d> list, boolean z) {
        int i = 0;
        for (d dVar : list) {
            if ((z && dVar.isDirectory()) || (!z && !dVar.isDirectory())) {
                i++;
            }
        }
        return i;
    }

    public final f vF() {
        f fVar = new f();
        fVar.aip = this.ait.vI();
        fVar.aiC = this.ait.vH();
        fVar.aiD = this.aiw;
        return fVar;
    }

    public final List<f> vG() {
        ArrayList arrayList = new ArrayList();
        for (d dVar : this.aiv) {
            try {
                f fVar = new f();
                fVar.aip = dVar.getFileName();
                fVar.aiC = dVar.getFile().getAbsolutePath();
                fVar.aiD = dVar.getFile().length();
                arrayList.add(fVar);
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            }
        }
        return arrayList;
    }

    public final String toString() {
        StringBuilder sbAppend = new StringBuilder("ScanResult{targetPath='").append(this.ait.vH()).append("', totalSize=").append(this.aiw).append(", totalSizeFormat=").append(com.kwad.components.core.pfmonitor.d.M(this.aiw)).append(", fileCount=").append(this.aix).append(", bigFilesCount=");
        List<d> list = this.aiv;
        return sbAppend.append(list == null ? 0 : list.size()).append(", directoryCount=").append(this.aiy).append('}').toString();
    }
}
