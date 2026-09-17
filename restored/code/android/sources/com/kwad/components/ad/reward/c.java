package com.kwad.components.ad.reward;

import com.kwad.components.core.webview.tachikoma.c.r;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private final Set<com.kwad.components.ad.reward.e.m> rU;

    /* synthetic */ c(byte b) {
        this();
    }

    private c() {
        this.rU = new HashSet();
    }

    static class a {
        private static final c rX = new c(0);
    }

    public static c gx() {
        return a.rX;
    }

    public final void a(com.kwad.components.ad.reward.e.m mVar) {
        if (mVar != null) {
            this.rU.add(mVar);
        }
    }

    public final void b(com.kwad.components.ad.reward.e.m mVar) {
        this.rU.remove(mVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(r rVar) {
        if (this.rU.size() == 0) {
            return;
        }
        Iterator<com.kwad.components.ad.reward.e.m> it = this.rU.iterator();
        while (it.hasNext()) {
            it.next().a(rVar);
        }
    }

    public final void c(final r rVar) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                c.this.b(rVar);
            }
        });
    }
}
