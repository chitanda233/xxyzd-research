package com.kwad.sdk.core.adlog.c;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.track.AdTrackLog;
import com.kwad.sdk.utils.al;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final a aMU = new a();

    public final a Jt() {
        return this.aMU;
    }

    public final b b(com.kwad.sdk.core.adlog.a.C0502a c0502a) {
        this.aMU.QR = c0502a;
        return this;
    }

    public final b z(int i, int i2) {
        this.aMU.aMj = i + "," + i2;
        return this;
    }

    public final b dS(int i) {
        this.aMU.ne = i;
        return this;
    }

    public final b dT(int i) {
        this.aMU.aMh = i;
        return this;
    }

    public final b dU(int i) {
        this.aMU.aMi = i;
        return this;
    }

    public final b f(al.a aVar) {
        this.aMU.ng = aVar;
        return this;
    }

    public final b ea(String str) {
        this.aMU.QQ = str;
        return this;
    }

    public final b dV(int i) {
        this.aMU.downloadSource = i;
        return this;
    }

    public final b dW(int i) {
        this.aMU.aMA = i;
        return this;
    }

    public final b eb(String str) {
        this.aMU.aMB = str;
        return this;
    }

    public final b ec(String str) {
        this.aMU.aMC = str;
        return this;
    }

    public final b dX(int i) {
        this.aMU.aMD = i;
        return this;
    }

    public final b dY(int i) {
        this.aMU.aME = i;
        return this;
    }

    public final b dZ(int i) {
        this.aMU.aMs = i;
        return this;
    }

    public final b az(long j) {
        this.aMU.zN = j;
        return this;
    }

    public final b ea(int i) {
        this.aMU.aMK = i;
        return this;
    }

    public final b j(double d) {
        this.aMU.nh = d;
        return this;
    }

    public final b ed(String str) {
        this.aMU.aMM = str;
        return this;
    }

    public final b eb(int i) {
        this.aMU.aMO = i;
        return this;
    }

    public final b ec(int i) {
        this.aMU.dL(i);
        return this;
    }

    public final b ed(int i) {
        this.aMU.aMQ = i;
        return this;
    }

    public final b ee(int i) {
        this.aMU.QT = i;
        return this;
    }

    public final b ef(int i) {
        this.aMU.aMS = i;
        return this;
    }

    public final b eg(int i) {
        this.aMU.QS = i;
        return this;
    }

    public final b eh(int i) {
        this.aMU.aMv = i;
        return this;
    }

    public final b b(AdTemplate adTemplate, String str, String str2, com.kwad.sdk.g.a<AdTrackLog> aVar) {
        if (this.aMU.QR == null) {
            this.aMU.QR = new com.kwad.sdk.core.adlog.a.C0502a();
        }
        this.aMU.QR.a(adTemplate, str, str2, aVar);
        return this;
    }
}
