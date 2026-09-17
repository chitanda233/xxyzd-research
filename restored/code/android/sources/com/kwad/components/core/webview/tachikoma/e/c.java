package com.kwad.components.core.webview.tachikoma.e;

import com.kwad.components.core.webview.tachikoma.f.g;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;
import java.util.concurrent.CopyOnWriteArraySet;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private final Set<g> ave;

    /* synthetic */ c(byte b) {
        this();
    }

    private c() {
        this.ave = new CopyOnWriteArraySet();
    }

    static class a {
        private static final c avk = new c(0);
    }

    public static c zS() {
        return a.avk;
    }

    public final void a(g gVar) {
        if (gVar != null) {
            this.ave.add(gVar);
        }
    }

    public final void b(g gVar) {
        this.ave.remove(gVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void t(String str, String str2) {
        if (this.ave.size() == 0) {
            return;
        }
        Iterator it = new HashSet(this.ave).iterator();
        while (it.hasNext()) {
            ((g) it.next()).v(str2);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(String str, long j, long j2, long j3) {
        if (this.ave.size() == 0) {
            return;
        }
        Iterator it = new HashSet(this.ave).iterator();
        while (it.hasNext()) {
            ((g) it.next()).a(str, j, j2, j3);
        }
    }

    public final void u(final String str, final String str2) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.e.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                c.this.t(str, str2);
            }
        });
    }

    public final void c(final String str, final long j, final long j2, final long j3) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.e.c.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                c.this.b(str, j, j2, j3);
            }
        });
    }

    public final void zT() {
        this.ave.clear();
    }
}
