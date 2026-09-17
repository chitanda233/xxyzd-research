package com.kwad.sdk.core.request.model;

import android.content.Context;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.be;
import com.kwad.sdk.utils.bf;

/* JADX INFO: loaded from: classes3.dex */
public class d extends com.kwad.sdk.core.response.a.a {
    public String aXo;
    public String aXp;
    public int aXq;
    public int operatorType;

    public static d ND() {
        d dVar = new d();
        try {
            Context contextUm = ServiceProvider.Um();
            dVar.aXo = bf.dP(contextUm);
            dVar.aXp = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FK();
            dVar.aXq = aq.dA(contextUm);
            dVar.operatorType = aq.e(contextUm, bf.dS(contextUm), be.useNetworkStateDisable());
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return dVar;
    }

    public static d NE() {
        d dVar = new d();
        dVar.aXq = aq.dA(ServiceProvider.getContext());
        return dVar;
    }
}
