package com.kwad.components.ad;

import android.content.Context;
import com.kwad.components.core.c.d;
import com.kwad.components.core.c.g;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.core.network.e;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class KsAdLoadManager {
    private volatile boolean bC;

    /* synthetic */ KsAdLoadManager(byte b) {
        this();
    }

    private KsAdLoadManager() {
        this.bC = false;
    }

    enum Holder {
        INSTANCE;

        private final KsAdLoadManager mInstance = new KsAdLoadManager(0);

        Holder() {
        }
    }

    public static KsAdLoadManager O() {
        return Holder.INSTANCE.mInstance;
    }

    public final void a(com.kwad.components.core.request.model.a aVar) {
        if (!o.GE().Hh()) {
            com.kwad.components.core.request.model.a.a(aVar, e.aTb.errorCode, e.aTb.msg, true);
            return;
        }
        if (com.kwad.components.ad.adbit.e.c(aVar) || b(aVar)) {
            return;
        }
        if (!this.bC) {
            P();
            this.bC = true;
        }
        d.oJ().d(aVar);
    }

    private static void P() {
        boolean zLa = com.kwad.sdk.core.config.e.La();
        com.kwad.sdk.core.d.c.d("AdLoadManager", "reportInstallerCheckRecord isInstallerCheckEnable: " + zLa);
        if (zLa) {
            Context context = ServiceProvider.getContext();
            try {
                com.kwad.components.ad.j.b.ak(context);
                com.kwad.components.ad.j.b.al(context);
            } catch (Throwable th) {
                com.kwad.sdk.crash.b.u(th);
            }
        }
    }

    private static boolean b(com.kwad.components.core.request.model.a aVar) {
        try {
            com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
            return false;
        } catch (Exception e) {
            ServiceProvider.reportSdkCaughtException(e);
            return false;
        }
    }

    public final synchronized <T> void b(List<T> list) {
        Iterator<T> it = list.iterator();
        while (it.hasNext()) {
            g.oS().add(it.next());
        }
    }

    public final synchronized <T> void a(T t) {
        g.oS().add(t);
    }
}
