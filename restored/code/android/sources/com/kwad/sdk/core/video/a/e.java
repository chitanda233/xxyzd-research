package com.kwad.sdk.core.video.a;

import android.content.Context;
import com.kwad.sdk.core.report.g;
import com.kwad.sdk.core.report.n;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ax;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static AtomicBoolean aZt = null;
    private static int aZu = -1;
    private static final AtomicBoolean aZv = new AtomicBoolean(false);
    private static final AtomicBoolean aZw = new AtomicBoolean(false);
    private static int aZx = 0;
    private static boolean amy = false;

    public static int OT() {
        return aZx;
    }

    public static boolean OU() {
        AtomicBoolean atomicBoolean = aZt;
        if (atomicBoolean != null) {
            return atomicBoolean.get();
        }
        AtomicBoolean atomicBoolean2 = new AtomicBoolean(true);
        aZt = atomicBoolean2;
        return atomicBoolean2.get();
    }

    public static boolean Il() {
        return aZw.get() || com.kwad.framework.a.a.Ot.booleanValue();
    }

    public static c a(Context context, boolean z, boolean z2, boolean z3, int i) {
        boolean z4;
        c cVar;
        c cVar2;
        try {
            if (Il() && z2 && OU()) {
                com.kwad.sdk.core.d.c.i("MediaPlayerImpl", "constructPlayer KwaiMediaPlayer");
                d dVar = new d(i);
                aZx = 2;
                dVar.bK(z);
                cVar2 = dVar;
            } else {
                com.kwad.sdk.core.d.c.i("MediaPlayerImpl", "constructPlayer AndroidMediaPlayer");
                b bVar = new b();
                aZx = 1;
                cVar2 = bVar;
            }
            z4 = false;
            cVar = cVar2;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.e("MediaPlayerImpl", "constructPlayer exception, using AndroidMediaPlayer", th);
            if (!amy) {
                amy = true;
                com.kwad.sdk.service.d.gatherException(th);
            }
            b bVar2 = new b();
            aZx = 1;
            z4 = true;
            cVar = bVar2;
        }
        int iA = ax.a(Il(), ServiceProvider.get(com.kwad.sdk.service.a.f.class) != null && ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG(), z2, OU(), z4, z3, cVar.getMediaPlayerType());
        com.kwad.sdk.core.d.c.V("KwaiPlayHelper", "player v=" + Integer.toBinaryString(iA));
        if (aZu != iA) {
            aZu = iA;
            eB(iA);
        }
        return cVar;
    }

    private static void eB(int i) {
        n nVar = new n(10212L);
        nVar.aVZ = i;
        g.a(nVar);
    }
}
