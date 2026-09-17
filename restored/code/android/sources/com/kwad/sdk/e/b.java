package com.kwad.sdk.e;

import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.util.HashMap;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b implements a {
    private static volatile b bgt;
    private static c bgu;

    private b() {
    }

    public static synchronized b Rh() {
        if (bgt == null) {
            synchronized (b.class) {
                if (bgt == null) {
                    bgt = new b();
                }
            }
        }
        return bgt;
    }

    public static void a(c cVar) {
        bgu = cVar;
    }

    @Override // com.kwad.sdk.e.a
    public final String getIMEI() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getIMEI();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getOaid() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getOaid();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String QX() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.QX();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getMac() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getMac();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String QY() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.QY();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String QZ() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.QZ();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Ra() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Ra();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getIccId() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getIccId();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Rb() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Rb();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Rc() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Rc();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Rd() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Rd();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getDeviceId() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getDeviceId();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getIp() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getIp();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Re() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Re();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getLocation() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getLocation();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Rf() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Rf();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String Rg() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.Rg();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getSdkVersion() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getSdkVersion();
        }
        return Ri();
    }

    @Override // com.kwad.sdk.e.a
    public final String getAppId() {
        c cVar = bgu;
        if (cVar != null) {
            return cVar.getAppId();
        }
        return Ri();
    }

    private static String Ri() {
        return a(false, "", 2);
    }

    public static String a(boolean z, Object obj, int i) {
        HashMap map = new HashMap();
        map.put("userSet", String.valueOf(z));
        map.put("value", obj);
        map.put(MediationConstant.KEY_ERROR_CODE, String.valueOf(i));
        return new JSONObject(map).toString();
    }
}
