package com.kwad.components.ad.reward;

import android.os.Looper;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private final Set<com.kwad.components.ad.reward.e.j> rM;

    /* synthetic */ a(byte b) {
        this();
    }

    private a() {
        this.rM = new HashSet();
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.reward.a$a, reason: collision with other inner class name */
    static class C0388a {
        private static final a rQ = new a(0);
    }

    public static a gq() {
        return C0388a.rQ;
    }

    public final void a(com.kwad.components.ad.reward.e.j jVar) {
        if (jVar != null) {
            this.rM.add(jVar);
        }
    }

    public final void b(com.kwad.components.ad.reward.e.j jVar) {
        this.rM.remove(jVar);
    }

    private static boolean isMainThread() {
        return Looper.getMainLooper() == Looper.myLooper();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(PlayableSource playableSource, com.kwad.components.ad.reward.e.n nVar) {
        if (this.rM.size() == 0) {
            return;
        }
        Iterator<com.kwad.components.ad.reward.e.j> it = this.rM.iterator();
        while (it.hasNext()) {
            it.next().a(playableSource, nVar);
        }
    }

    public final void a(PlayableSource playableSource) {
        c(playableSource, null);
    }

    public final void c(final PlayableSource playableSource, final com.kwad.components.ad.reward.e.n nVar) {
        if (isMainThread()) {
            b(playableSource, nVar);
        } else {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.a.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    a.this.b(playableSource, nVar);
                }
            });
        }
    }

    public final void gr() {
        if (isMainThread()) {
            gs();
        } else {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.a.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    a.this.gr();
                }
            });
        }
    }

    public final void b(final PlayableSource playableSource) {
        if (isMainThread()) {
            c(playableSource);
        } else {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.a.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    a.this.c(playableSource);
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(PlayableSource playableSource) {
        if (this.rM.size() == 0) {
            return;
        }
        Iterator<com.kwad.components.ad.reward.e.j> it = this.rM.iterator();
        while (it.hasNext()) {
            it.next().dp();
        }
    }

    private void gs() {
        if (this.rM.size() == 0) {
            return;
        }
        Iterator<com.kwad.components.ad.reward.e.j> it = this.rM.iterator();
        while (it.hasNext()) {
            it.next().mo174do();
        }
    }
}
