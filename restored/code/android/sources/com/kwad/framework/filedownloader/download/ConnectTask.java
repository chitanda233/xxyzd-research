package com.kwad.framework.filedownloader.download;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class ConnectTask {
    final int aAQ;
    final com.kwad.framework.filedownloader.d.b aAR;
    private com.kwad.framework.filedownloader.download.a aAS;
    private String aAT;
    private Map<String, List<String>> aAU;
    private List<String> aAV;
    final String url;

    /* synthetic */ ConnectTask(com.kwad.framework.filedownloader.download.a aVar, int i, String str, String str2, com.kwad.framework.filedownloader.d.b bVar, byte b) {
        this(aVar, i, str, str2, bVar);
    }

    private ConnectTask(com.kwad.framework.filedownloader.download.a aVar, int i, String str, String str2, com.kwad.framework.filedownloader.d.b bVar) {
        this.aAQ = i;
        this.url = str;
        this.aAT = str2;
        this.aAR = bVar;
        this.aAS = aVar;
    }

    final com.kwad.framework.filedownloader.a.b Ch() {
        com.kwad.framework.filedownloader.a.b bVarBY = b.Cm().bY(this.url);
        a(bVarBY);
        b(bVarBY);
        c(bVarBY);
        this.aAU = bVarBY.Ca();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "%s request header %s", Integer.valueOf(this.aAQ), this.aAU);
        }
        bVarBY.execute();
        ArrayList arrayList = new ArrayList();
        this.aAV = arrayList;
        return com.kwad.framework.filedownloader.a.d.a(this.aAU, bVarBY, arrayList);
    }

    private void a(com.kwad.framework.filedownloader.a.b bVar) {
        HashMap<String, List<String>> mapDi;
        com.kwad.framework.filedownloader.d.b bVar2 = this.aAR;
        if (bVar2 == null || (mapDi = bVar2.Di()) == null) {
            return;
        }
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.e(this, "%d add outside header: %s", Integer.valueOf(this.aAQ), mapDi);
        }
        for (Map.Entry<String, List<String>> entry : mapDi.entrySet()) {
            String key = entry.getKey();
            List<String> value = entry.getValue();
            if (value != null) {
                Iterator<String> it = value.iterator();
                while (it.hasNext()) {
                    bVar.addHeader(key, it.next());
                }
            }
        }
    }

    private void b(com.kwad.framework.filedownloader.a.b bVar) {
        if (!TextUtils.isEmpty(this.aAT)) {
            bVar.addHeader(com.sigmob.sdk.downloader.core.c.c, this.aAT);
        }
        bVar.addHeader(com.sigmob.sdk.downloader.core.c.b, this.aAS.aBa == 0 ? com.kwad.framework.filedownloader.f.f.c("bytes=%d-", Long.valueOf(this.aAS.aAZ)) : com.kwad.framework.filedownloader.f.f.c("bytes=%d-%d", Long.valueOf(this.aAS.aAZ), Long.valueOf(this.aAS.aBa)));
    }

    private void c(com.kwad.framework.filedownloader.a.b bVar) {
        com.kwad.framework.filedownloader.d.b bVar2 = this.aAR;
        if (bVar2 == null || bVar2.Di().get("User-Agent") == null) {
            bVar.addHeader("User-Agent", com.kwad.framework.filedownloader.f.f.DR());
        }
    }

    final boolean Ci() {
        return this.aAS.aAZ > 0;
    }

    final String Cj() {
        List<String> list = this.aAV;
        if (list == null || list.isEmpty()) {
            return null;
        }
        List<String> list2 = this.aAV;
        return list2.get(list2.size() - 1);
    }

    public final Map<String, List<String>> getRequestHeader() {
        return this.aAU;
    }

    public final com.kwad.framework.filedownloader.download.a Ck() {
        return this.aAS;
    }

    class Reconnect extends Throwable {
        private static final long serialVersionUID = 2940866805654257562L;

        Reconnect() {
        }
    }

    static class a {
        private com.kwad.framework.filedownloader.d.b aAR;
        private String aAT;
        private Integer aAW;
        private com.kwad.framework.filedownloader.download.a aAX;
        private String url;

        a() {
        }

        public final a cA(int i) {
            this.aAW = Integer.valueOf(i);
            return this;
        }

        public final a bW(String str) {
            this.url = str;
            return this;
        }

        public final a bX(String str) {
            this.aAT = str;
            return this;
        }

        public final a a(com.kwad.framework.filedownloader.d.b bVar) {
            this.aAR = bVar;
            return this;
        }

        public final a a(com.kwad.framework.filedownloader.download.a aVar) {
            this.aAX = aVar;
            return this;
        }

        final ConnectTask Cl() {
            if (this.aAW == null || this.aAX == null || this.url == null) {
                throw new IllegalArgumentException();
            }
            return new ConnectTask(this.aAX, this.aAW.intValue(), this.url, this.aAT, this.aAR, (byte) 0);
        }
    }
}
