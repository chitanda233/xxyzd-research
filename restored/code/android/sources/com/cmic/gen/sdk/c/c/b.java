package com.cmic.gen.sdk.c.c;

import com.cmic.gen.sdk.c.b.e;
import com.cmic.gen.sdk.f.q;

/* JADX INFO: compiled from: HttpGetPrephoneRequest.java */
/* JADX INFO: loaded from: classes2.dex */
public class b extends c {
    private final e b;
    private boolean c;

    b(String str, e eVar, String str2, String str3) {
        super(str, eVar, str2, str3);
        this.c = false;
        this.b = eVar;
    }

    public void a(com.cmic.gen.sdk.a aVar) {
        String[] strArrA;
        com.cmic.gen.sdk.c.b.a aVarC = this.b.c();
        aVarC.u(aVar.b("socketip"));
        com.cmic.gen.sdk.f.c.b("GetPrePhonescripParam", "socket socketip = " + aVar.b("socketip"));
        if (!this.c) {
            if (aVar.b("isCloseIpv4", false)) {
                strArrA = null;
            } else {
                strArrA = q.a(true);
                aVarC.q(strArrA[0]);
            }
            if (!aVar.b("isCloseIpv6", false)) {
                if (strArrA == null) {
                    strArrA = q.a(true);
                }
                aVarC.r(strArrA[1]);
            }
            this.c = true;
        }
        aVarC.n(aVarC.y(aVar.b(com.alipay.sdk.m.w.a.t)));
        this.b.a(aVarC);
        this.b.a(true);
        this.f2088a = this.b.b().toString();
    }
}
