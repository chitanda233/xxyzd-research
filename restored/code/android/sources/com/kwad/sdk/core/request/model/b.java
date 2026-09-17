package com.kwad.sdk.core.request.model;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.components.h;
import com.kwad.sdk.components.p;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.ao;
import com.kwad.sdk.utils.ba;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.n;
import com.kwad.sdk.utils.t;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    private static boolean aWP;
    private static JSONArray aWQ;
    public String Nh;
    public String Ni;
    public String Nj;
    public String Nk;
    public String Nl;
    public int Sh;
    public int Si;
    public String aQZ;
    public String aRa;
    public String aWR;
    public String aWS;
    public String aWT;
    public String aWU;
    public String aWV;
    public int aWW;
    public int aWX;
    public String aWY;
    public String aWZ;
    public String aXa;
    public String aXb;
    public JSONArray aXc;
    public String aXd;
    public String aXe;
    public String aXg;
    public String aXh;
    public String aXi;

    @Deprecated
    public String aXk;
    public String aXl;
    public int aXm;
    public int apd;
    public int aqA;
    public String aqB;
    public int aqy;
    public String uaid;
    public int aXf = 0;
    public long aXj = 0;

    public static b NB() {
        b bVar = new b();
        try {
            bVar.aRa = bf.getOaid();
            bVar.Nl = bf.getDeviceId();
            bVar.Nh = bt.WT();
            bVar.aqy = 1;
            bVar.aqA = bt.Xg();
            bVar.Nj = bt.getOsVersion();
            bVar.aXb = ai.getEGid();
            if (ai.VA()) {
                bVar.aXd = ai.Vz();
            }
            if (ai.VB() && !TextUtils.isEmpty(ai.Vy())) {
                bVar.uaid = ai.Vy();
            }
            h hVar = (h) com.kwad.sdk.components.d.f(h.class);
            if (hVar != null) {
                bVar.aXa = hVar.qP();
            }
            if (((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)) != null) {
                bVar.aQZ = bf.dN(ServiceProvider.Um());
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return bVar;
    }

    public static b h(boolean z, int i) {
        b bVar = new b();
        try {
            Context contextUm = ServiceProvider.Um();
            bVar.aQZ = bf.dN(contextUm);
            bVar.aWR = bf.dQ(contextUm);
            bVar.aWS = bf.dR(contextUm);
            bVar.aWT = bt.eu(contextUm);
            bVar.aRa = bf.getOaid();
            bVar.Nh = bt.WT();
            bVar.Ni = bt.WV();
            bVar.aqy = 1;
            bVar.aqA = bt.Xg();
            bVar.Nj = bt.getOsVersion();
            bVar.aqB = n.getLanguage();
            bVar.Sh = n.getScreenHeight(contextUm);
            bVar.Si = n.getScreenWidth(contextUm);
            bVar.aWW = n.dc(contextUm);
            bVar.aWX = n.dd(contextUm);
            bVar.aWY = bf.dO(contextUm);
            if (z) {
                bVar.aXc = bZ(contextUm);
            }
            bVar.aXm = ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).Gx();
            bVar.aXe = bt.Xf();
            if (ai.VA()) {
                bVar.aXd = ai.Vz();
            }
            if (ai.VB() && !TextUtils.isEmpty(ai.Vy())) {
                bVar.uaid = ai.Vy();
            }
            bVar.Nl = bf.getDeviceId();
            bVar.aXj = bt.WU();
            bVar.aWZ = bt.Xd();
            bVar.aXb = ai.getEGid();
            h hVar = (h) com.kwad.sdk.components.d.f(h.class);
            if (hVar != null) {
                bVar.aXa = hVar.qP();
            }
            bVar.apd = bt.Xe();
            try {
                com.kwad.sdk.core.d.c.V("DeviceInfo", a((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class), bVar, contextUm));
            } catch (Exception unused) {
            }
            bVar.aXe = bt.Xf();
            bVar.aXf = i;
            if (FY() && com.kwad.sdk.app.b.Ia() != null) {
                bVar.aXg = com.kwad.sdk.app.b.Ia().getVersion(contextUm, "com.smile.gifmaker");
                bVar.aXh = com.kwad.sdk.app.b.Ia().getVersion(contextUm, "com.kuaishou.nebula");
                bVar.aXi = com.kwad.sdk.app.b.Ia().getVersion(contextUm, "com.tencent.mm");
            }
            bVar.Nk = bt.Xb();
            bVar.aWV = ao.dw(contextUm);
            bVar.aXl = bt.ip("/data/data");
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return bVar;
    }

    private static boolean FY() {
        return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FY();
    }

    private static boolean FZ() {
        return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FZ();
    }

    private static String a(com.kwad.sdk.service.a.f fVar, b bVar, Context context) {
        StringBuilder sbAppend = new StringBuilder("i=").append(fVar.getAppId()).append(",n=").append(fVar.getAppName()).append(",external:").append(fVar.FG()).append(",v1:").append(fVar.getApiVersion()).append(",v2:5.3.20.1,d:").append(bVar.Nl).append(",dh:");
        String str = bVar.Nl;
        String string = sbAppend.append(str != null ? Integer.valueOf(str.hashCode()) : "").append(",b:367,p:").append(ba.isInMainProcess(context)).append(",dy:").append(com.kwad.framework.a.a.ayP).toString();
        return !FZ() ? string + ",o:" + bVar.aRa : string;
    }

    private static synchronized JSONArray bZ(Context context) {
        if (!aWP) {
            aWP = true;
            p pVar = (p) com.kwad.sdk.components.d.f(p.class);
            com.kwad.sdk.core.d.c.d("DeviceInfo", "getAppList: OptDataFetchComponent: " + pVar);
            if (pVar != null && t.UT()) {
                pVar.a(context, new com.kwad.sdk.g.a<JSONArray>() { // from class: com.kwad.sdk.core.request.model.b.1
                    @Override // com.kwad.sdk.g.a
                    public final /* synthetic */ void accept(JSONArray jSONArray) {
                        g(jSONArray);
                    }

                    private static void g(JSONArray jSONArray) {
                        JSONArray unused = b.aWQ = jSONArray;
                    }
                });
            }
        }
        JSONArray jSONArray = aWQ;
        if (jSONArray == null) {
            return null;
        }
        aWQ = null;
        return jSONArray;
    }
}
