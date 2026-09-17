package com.kwad.sdk.utils;

import android.content.Context;
import android.telephony.CellInfo;
import android.telephony.CellLocation;
import android.telephony.CellSignalStrength;
import android.telephony.TelephonyManager;
import android.telephony.cdma.CdmaCellLocation;
import android.telephony.gsm.GsmCellLocation;
import androidx.core.content.ContextCompat;
import com.kwad.sdk.service.ServiceProvider;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class bj {
    private static Context bqe;
    private static Map<String, m> bqf = new HashMap();

    public static void init(Context context) {
        if (context == null) {
            return;
        }
        com.kwad.sdk.service.a.h hVar = (com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class);
        if (hVar == null) {
            com.kwad.sdk.core.d.c.d("SensitiveInfoCollectors", "init sdkConfigProvider is null");
            return;
        }
        if (Ww()) {
            if (bqf.containsKey("baseStationEnable")) {
                boolean zFT = hVar.FT();
                m mVarIa = ia("baseStationEnable");
                if (mVarIa != null) {
                    mVarIa.cs(zFT);
                }
            }
            if (bqf.containsKey("simCardInfoEnable")) {
                boolean zFR = hVar.FR();
                m mVarIa2 = ia("simCardInfoEnable");
                if (mVarIa2 != null) {
                    mVarIa2.cs(zFR);
                    return;
                }
                return;
            }
            return;
        }
        bqe = context.getApplicationContext();
        bqf.put("baseStationEnable", new a(hVar.FT()));
        bqf.put("simCardInfoEnable", new b(hVar.FR()));
    }

    private static <T> m<T> ia(String str) {
        try {
            return bqf.get(str);
        } catch (Exception unused) {
            return null;
        }
    }

    public static com.kwad.sdk.k.a.b TK() {
        if (Ww()) {
            return (com.kwad.sdk.k.a.b) ib("baseStationEnable");
        }
        return null;
    }

    public static com.kwad.sdk.k.a.f TL() {
        if (Ww()) {
            return (com.kwad.sdk.k.a.f) ib("simCardInfoEnable");
        }
        return null;
    }

    private static <T> T ib(String str) {
        m mVarIa = ia(str);
        if (mVarIa != null) {
            return (T) mVarIa.cW(bqe);
        }
        return null;
    }

    private static boolean Ww() {
        return bqe != null;
    }

    static class a extends m<com.kwad.sdk.k.a.b> {
        private static com.kwad.sdk.k.a.b bqg;

        public a(boolean z) {
            super(z);
        }

        /* JADX INFO: Access modifiers changed from: private */
        @Override // com.kwad.sdk.utils.m
        /* JADX INFO: renamed from: ej, reason: merged with bridge method [inline-methods] */
        public com.kwad.sdk.k.a.b cX(Context context) {
            int lac;
            int cid;
            if (be.readLocationDisable() || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(64L)) {
                return bqg;
            }
            com.kwad.sdk.k.a.b bVar = bqg;
            if (bVar != null) {
                return bVar;
            }
            CellInfo cellInfo = null;
            if (context == null || be.readLocationDisable()) {
                return null;
            }
            if (ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == -1) {
                return null;
            }
            if (bt.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == 0) {
                TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                CellLocation cellLocation = telephonyManager.getCellLocation();
                if (cellLocation instanceof CdmaCellLocation) {
                    CdmaCellLocation cdmaCellLocation = (CdmaCellLocation) cellLocation;
                    cid = cdmaCellLocation.getBaseStationId();
                    lac = cdmaCellLocation.getNetworkId();
                } else if (cellLocation instanceof GsmCellLocation) {
                    GsmCellLocation gsmCellLocation = (GsmCellLocation) cellLocation;
                    cid = gsmCellLocation.getCid();
                    lac = gsmCellLocation.getLac();
                } else {
                    lac = -1;
                    cid = -1;
                }
                for (CellInfo cellInfo2 : telephonyManager.getAllCellInfo()) {
                    if (cellInfo2 != null && cellInfo2.isRegistered()) {
                        cellInfo = cellInfo2;
                        break;
                    }
                }
                bqg = new com.kwad.sdk.k.a.b(cid, lac, cellInfo != null ? a(cellInfo) : -1);
            }
            return bqg;
        }

        private static int a(CellInfo cellInfo) {
            if (cellInfo == null) {
                return -1;
            }
            try {
                return ((CellSignalStrength) ab.callMethod(cellInfo, "getCellSignalStrength", new Object[0])).getLevel();
            } catch (Throwable unused) {
                return -1;
            }
        }
    }

    static class b extends m<com.kwad.sdk.k.a.f> {
        @Override // com.kwad.sdk.utils.m
        protected final /* synthetic */ com.kwad.sdk.k.a.f cX(Context context) {
            return ek(context);
        }

        public b(boolean z) {
            super(z);
        }

        private static com.kwad.sdk.k.a.f ek(Context context) {
            com.kwad.sdk.k.a.f fVar = new com.kwad.sdk.k.a.f();
            fVar.bmF = bf.dW(context);
            fVar.bmE = bf.dU(context);
            return fVar;
        }
    }
}
