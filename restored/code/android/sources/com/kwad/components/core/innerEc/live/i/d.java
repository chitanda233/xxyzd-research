package com.kwad.components.core.innerEc.live.i;

import com.kwad.components.core.innerEc.live.config.net.g;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public static void a(com.kwad.components.core.innerEc.live.b.a.b bVar, g gVar, boolean z) {
        bVar.UV = gVar;
        if (z) {
            e.e(bVar.mAdTemplate, gVar.Uz.Up.liveStreamId);
            bVar.UQ.updateStartPlayData(gVar.UC);
        }
    }
}
