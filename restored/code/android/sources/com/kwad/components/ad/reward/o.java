package com.kwad.components.ad.reward;

/* JADX INFO: loaded from: classes3.dex */
public final class o {
    public static void a(int i, int i2, g gVar, com.kwad.components.ad.reward.model.c cVar) {
        if (i == 0) {
            com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 1);
            return;
        }
        if (i == 1) {
            if (i2 == 0) {
                if (gVar.tb.lf()) {
                    com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 1);
                    return;
                }
                return;
            } else if (gVar.tb.lf()) {
                com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 5);
                return;
            } else {
                com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 4);
                return;
            }
        }
        if (i != 2) {
            return;
        }
        if (i2 == 0) {
            if (gVar.ta.lf()) {
                com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 1);
            }
        } else if (gVar.ta.lf()) {
            com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 3);
        } else {
            com.kwad.sdk.core.adlog.c.o(cVar.getAdTemplate(), 2);
        }
    }
}
