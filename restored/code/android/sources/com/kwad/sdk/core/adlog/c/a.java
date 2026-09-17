package com.kwad.sdk.core.adlog.c;

import com.kwad.sdk.core.report.h;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.al;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.core.response.a.a {
    public String QQ;
    public com.kwad.sdk.core.adlog.a.C0502a QR;
    public long Rv;
    public int aKK;
    public int aMA;
    public String aMB;
    public String aMC;
    public int aMD;
    public int aME;
    public long aMF;
    public long aMG;
    public int aMJ;
    public int aMK;
    public String aMM;
    public int aMO;
    public int aMP;
    public int aMQ;
    public int aMR;
    public String aMT;
    public JSONObject aMe;
    public int aMf;
    public int aMg;
    public int aMh;
    public int aMi;
    public String aMj;
    public String aMn;
    public String aMo;
    public String aMp;
    public int aMq;
    public int aMr;
    public int aMt;
    public String aMu;
    public int aMv;
    public int aMw;
    public String aMy;
    public int aMz;
    public AdTemplate adTemplate;
    public int adnMaterialType;
    public String adnMaterialUrl;
    public String adnName;
    public int adnType;
    public int adu;
    public int downloadSource;
    public int ne;
    public al.a ng;
    public double nh;
    public long zN;
    public long aMk = -1;
    public int aMl = -1;
    public long aMm = -1;
    public int aMs = -1;
    public int QS = 0;
    public String aMx = "";
    public int aMH = -1;
    public int aMI = -1;
    public int downloadStatus = 0;
    public int aML = -1;
    public int QP = -1;
    public int aMN = -1;
    public int adxResult = -1;
    public int QT = -1;
    public int aMS = 0;

    public static a Jr() {
        return new a();
    }

    public final void dL(int i) {
        if (i == 0) {
            this.aMP = 1;
        } else if (i == 1) {
            this.aMP = 2;
        } else {
            if (i != 2) {
                return;
            }
            this.aMP = 3;
        }
    }

    public final void a(h hVar) {
        if (hVar != null) {
            this.aMT = hVar.Nl();
        }
    }

    public final void e(AdTemplate adTemplate, String str, String str2) {
        com.kwad.sdk.core.adlog.a.C0502a c0502a = this.QR;
        if (c0502a == null) {
            com.kwad.sdk.core.adlog.a.C0502a c0502a2 = new com.kwad.sdk.core.adlog.a.C0502a();
            this.QR = c0502a2;
            c0502a2.a(adTemplate, null, null, null);
        } else if (c0502a.aLF == null) {
            this.QR.a(adTemplate, null, null, null);
        }
    }

    public final a dM(int i) {
        this.ne = i;
        return this;
    }

    public final a dZ(String str) {
        this.QQ = str;
        return this;
    }

    public final a e(al.a aVar) {
        this.ng = aVar;
        return this;
    }

    public final a dN(int i) {
        this.QS = i;
        return this;
    }

    public final a dO(int i) {
        this.QT = i;
        return this;
    }

    public final a dP(int i) {
        this.QP = i;
        return this;
    }

    public final a a(com.kwad.sdk.core.adlog.a.C0502a c0502a) {
        this.QR = c0502a;
        return this;
    }

    public final a ax(long j) {
        this.zN = j;
        return this;
    }

    public final a ay(long j) {
        this.Rv = j;
        return this;
    }

    public final a dQ(int i) {
        this.adu = i;
        return this;
    }

    public final a dR(int i) {
        this.aMz = i;
        return this;
    }

    public final com.kwad.sdk.core.adlog.a.C0502a Js() {
        return this.QR;
    }
}
