package com.kwad.sdk.utils;

import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class t {
    private static boolean boP;
    private static boolean boQ;

    public static synchronized void ct(boolean z) {
        if (boQ) {
            return;
        }
        boQ = true;
        boP = true;
        GlobalThreadPools.Or().execute(new bi() { // from class: com.kwad.sdk.utils.t.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ((com.kwad.sdk.service.a.b) ServiceProvider.get(com.kwad.sdk.service.a.b.class)).FC();
            }
        });
    }

    public static boolean UP() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(2L)) & boP;
    }

    public static boolean UQ() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(4L)) & boP;
    }

    public static boolean UR() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(2048L)) & boP;
    }

    public static boolean US() {
        return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FS() && boP;
    }

    public static boolean UT() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(16L)) & boP;
    }

    public static boolean UU() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(4096L)) & boP;
    }

    public static boolean UV() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(1L)) & boP;
    }

    public static boolean UW() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(128L)) & boP;
    }

    public static boolean UX() {
        return (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(128L)) & boP;
    }
}
