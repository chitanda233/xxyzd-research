package com.kwai.adclient.kscommerciallogger;

import com.kwai.adclient.kscommerciallogger.model.c;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private com.kwai.adclient.kscommerciallogger.a.a btZ;
    private com.kwai.adclient.kscommerciallogger.a.b bua;
    private JSONObject bub;
    private boolean buc;
    private boolean isDebug;

    /* synthetic */ a(byte b) {
        this();
    }

    private a() {
        this.isDebug = false;
        this.buc = false;
    }

    public static a Yl() {
        return C0542a.Yl();
    }

    public final void a(com.kwai.adclient.kscommerciallogger.a.a aVar, com.kwai.adclient.kscommerciallogger.a.b bVar, JSONObject jSONObject, boolean z, boolean z2) {
        this.btZ = aVar;
        this.bua = bVar;
        this.bub = jSONObject;
        this.isDebug = z;
        this.buc = z2;
    }

    public final JSONObject Ym() {
        return this.bub;
    }

    public final boolean isDebug() {
        return this.isDebug;
    }

    public final boolean Yn() {
        return this.buc;
    }

    public final void a(c cVar) {
        if (cVar == null) {
            return;
        }
        b(cVar);
        com.kwai.adclient.kscommerciallogger.a.b bVar = this.bua;
        if (bVar != null) {
            bVar.N(cVar.Yo(), cVar.toString());
        }
    }

    private void b(c cVar) {
        if (this.btZ != null) {
            Object[] objArr = new Object[5];
            if (cVar.Yp() != null) {
                String str = cVar.Yp().value;
            }
            if (cVar.Yq() != null) {
                cVar.Yq().getValue();
            }
            cVar.Yt();
            b.A(cVar.Yr());
            b.A(cVar.Ys());
        }
    }

    /* JADX INFO: renamed from: com.kwai.adclient.kscommerciallogger.a$a, reason: collision with other inner class name */
    static final class C0542a {
        private static a bud;

        public static a Yl() {
            if (bud == null) {
                bud = new a((byte) 0);
            }
            return bud;
        }
    }
}
