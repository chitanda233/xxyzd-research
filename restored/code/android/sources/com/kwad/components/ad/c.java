package com.kwad.components.ad;

import android.util.Log;
import com.kwad.sdk.components.e;
import com.kwad.sdk.f;
import com.kwad.sdk.n;
import com.kwad.sdk.o;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends e {
    protected final void a(final com.kwad.sdk.g.a<Boolean> aVar) {
        boolean zHh = o.GE().Hh();
        Log.w("jkyLoad", "BaseLoadComponents checkInitReady started: " + zHh);
        if (zHh) {
            Log.w("jkyLoad", "BaseLoadComponents checkInitReady with had init");
            aVar.accept(Boolean.TRUE);
        } else {
            f.a(new n() { // from class: com.kwad.components.ad.c.1
                @Override // com.kwad.sdk.n, com.kwad.sdk.m
                public final void M() {
                    Log.w("jkyLoad", "BaseLoadComponents checkInitReady with async init success: ");
                    aVar.accept(Boolean.TRUE);
                }

                @Override // com.kwad.sdk.n, com.kwad.sdk.m
                public final void N() {
                    aVar.accept(Boolean.FALSE);
                }
            });
        }
    }
}
