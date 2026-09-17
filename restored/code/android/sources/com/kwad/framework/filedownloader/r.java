package com.kwad.framework.filedownloader;

import android.content.Context;
import android.text.TextUtils;
import java.io.File;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class r {
    private static final Object aAl = new Object();
    private static final Object aAn = new Object();
    private w aAm;
    private volatile v aAo;

    public static void aW(Context context) {
        com.kwad.framework.filedownloader.f.c.aX(context.getApplicationContext());
    }

    public static void a(Context context, com.kwad.framework.filedownloader.services.c.b bVar) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(r.class, "init Downloader with params: %s %s", context, bVar);
        }
        if (context == null) {
            throw new IllegalArgumentException("the provided context must not be null!");
        }
        com.kwad.framework.filedownloader.f.c.aX(context.getApplicationContext());
        com.kwad.framework.filedownloader.download.b.Cm().a(bVar);
    }

    static final class a {
        private static final r aAp = new r();
    }

    public static r BS() {
        return a.aAp;
    }

    public static com.kwad.framework.filedownloader.a bT(String str) {
        return new c(str);
    }

    private int co(int i) {
        List<com.kwad.framework.filedownloader.a.InterfaceC0481a> listCj = h.Bz().cj(i);
        if (listCj.isEmpty()) {
            com.kwad.framework.filedownloader.f.d.d(this, "request pause but not exist %d", Integer.valueOf(i));
            return 0;
        }
        Iterator<com.kwad.framework.filedownloader.a.InterfaceC0481a> it = listCj.iterator();
        while (it.hasNext()) {
            it.next().Bb().pause();
        }
        return listCj.size();
    }

    public final boolean u(int i, String str) {
        co(i);
        if (!n.BK().cn(i)) {
            return false;
        }
        if (TextUtils.isEmpty(str)) {
            return true;
        }
        File file = new File(com.kwad.framework.filedownloader.f.f.ck(str));
        if (file.exists()) {
            file.delete();
        }
        File file2 = new File(str);
        if (file2.exists()) {
            file2.delete();
        }
        return true;
    }

    public final void BT() {
        if (BU()) {
            return;
        }
        n.BK().aV(com.kwad.framework.filedownloader.f.c.DJ());
    }

    public static boolean BU() {
        return n.BK().isConnected();
    }

    private static void a(e eVar) {
        f.Bx().a("event.service.connect.changed", eVar);
    }

    final w BV() {
        if (this.aAm == null) {
            synchronized (aAl) {
                if (this.aAm == null) {
                    this.aAm = new ab();
                }
            }
        }
        return this.aAm;
    }

    final v BW() {
        if (this.aAo == null) {
            synchronized (aAn) {
                if (this.aAo == null) {
                    this.aAo = new z();
                    a((e) this.aAo);
                }
            }
        }
        return this.aAo;
    }
}
