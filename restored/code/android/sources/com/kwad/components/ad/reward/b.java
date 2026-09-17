package com.kwad.components.ad.reward;

import android.os.Looper;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final Set<com.kwad.components.ad.reward.e.l> rR;

    /* synthetic */ b(byte b) {
        this();
    }

    private b() {
        this.rR = new HashSet();
    }

    static class a {
        private static final b rT = new b(0);
    }

    public static b gu() {
        return a.rT;
    }

    public final void a(com.kwad.components.ad.reward.e.l lVar) {
        if (lVar != null) {
            this.rR.add(lVar);
        }
    }

    public final void b(com.kwad.components.ad.reward.e.l lVar) {
        this.rR.remove(lVar);
    }

    private static boolean isMainThread() {
        return Looper.getMainLooper() == Looper.myLooper();
    }

    private void gv() {
        if (this.rR.size() == 0) {
            return;
        }
        Iterator<com.kwad.components.ad.reward.e.l> it = this.rR.iterator();
        while (it.hasNext()) {
            it.next().onRewardVerify();
        }
    }

    public final void notifyRewardVerify() {
        if (isMainThread()) {
            gv();
        } else {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.b.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    b.this.notifyRewardVerify();
                }
            });
        }
    }
}
