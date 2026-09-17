package com.kwad.components.core.request.model;

import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.media.AudioManager;
import android.os.Build;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.kwad.sdk.k.a.d;
import com.kwad.sdk.k.a.e;
import com.kwad.sdk.k.a.f;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.AbiUtil;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bl;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.cf;
import com.kwad.sdk.utils.s;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.sdk.core.b {
    private String Nk;
    private int RT;
    private String ajU;
    private int ajV;
    private String ajW;
    private Long ajX;
    private Long ajY;
    private Long ajZ;
    private Long aka;
    private String akb;
    private String akc;
    private long ake;
    private String akf;
    private long akg;
    private String aki;
    private String akj;
    private boolean akk;
    private List<a> akl;
    private f akm;
    private d akn;
    private com.kwad.sdk.k.a.b ako;
    private List<e> akp;
    private List<cf.a> akd = new CopyOnWriteArrayList();
    private int akh = -1;
    private float screenBrightness = -1.0f;
    private int RW = -1;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    private static Context getContext() {
        return ServiceProvider.Um();
    }

    public static b wq() {
        b bVar = new b();
        bVar.ajV = bt.WS();
        bVar.ajW = AbiUtil.cJ(getContext());
        bVar.RT = bt.er(getContext());
        bVar.ajX = Long.valueOf(bt.es(getContext()));
        bVar.ajY = Long.valueOf(bt.eo(getContext()));
        bVar.ajZ = Long.valueOf(bt.WP());
        bVar.aka = Long.valueOf(bt.WQ());
        bVar.akb = bf.dS(getContext());
        bVar.akc = bf.dT(getContext());
        bVar.akd.addAll(bf.o(getContext(), 15));
        bVar.ake = bt.WX();
        bVar.akg = bt.WY();
        bVar.akj = bt.WZ();
        bVar.aki = bt.Xa();
        bVar.Nk = bt.Xb();
        bVar.akf = bt.Xc();
        Context context = getContext();
        if (context != null) {
            bVar.akh = bt.ez(context);
            bVar.akl = new CopyOnWriteArrayList(a.aM(context));
            bVar.aL(context);
        }
        bVar.akn = s.UN();
        bVar.ako = bf.TK();
        bVar.akp = bl.Wy().Wz();
        bVar.akm = bf.TL();
        try {
            bVar.ajU = Build.HARDWARE;
        } catch (Throwable unused) {
        }
        return bVar;
    }

    private void aL(Context context) {
        if (com.kwad.sdk.core.config.e.al(512L)) {
            return;
        }
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction("android.intent.action.ACTION_POWER_CONNECTED");
        intentFilter.addAction("android.intent.action.ACTION_POWER_DISCONNECTED");
        intentFilter.addAction("android.intent.action.BATTERY_CHANGED");
        try {
            Intent intentRegisterReceiver = context.registerReceiver(null, intentFilter);
            if (intentRegisterReceiver != null) {
                int intExtra = intentRegisterReceiver.getIntExtra("status", -1);
                this.akk = intExtra == 2 || intExtra == 5;
                int intExtra2 = intentRegisterReceiver.getIntExtra("plugged", -1);
                if (intExtra2 == 2) {
                    this.RW = 1;
                    return;
                }
                if (intExtra2 == 1) {
                    this.RW = 2;
                } else if (intExtra2 == 4) {
                    this.RW = 3;
                } else if (intExtra2 == 0) {
                    this.RW = 0;
                }
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "cpuCount", this.ajV);
        ac.putValue(jSONObject, "cpuAbi", this.ajW);
        ac.putValue(jSONObject, "batteryPercent", this.RT);
        ac.putValue(jSONObject, "totalMemorySize", this.ajX.longValue());
        ac.putValue(jSONObject, "availableMemorySize", this.ajY.longValue());
        ac.putValue(jSONObject, "totalDiskSize", this.ajZ.longValue());
        ac.putValue(jSONObject, "availableDiskSize", this.aka.longValue());
        ac.putValue(jSONObject, "imsi", this.akb);
        ac.putValue(jSONObject, "iccid", this.akc);
        ac.putValue(jSONObject, "wifiList", this.akd);
        ac.putValue(jSONObject, "bootTime", this.ake);
        ac.putValue(jSONObject, "romName", this.Nk);
        ac.putValue(jSONObject, "romVersion", this.akf);
        ac.putValue(jSONObject, "romBuildTimestamp", this.akg);
        ac.putValue(jSONObject, "ringerMode", this.akh);
        ac.putValue(jSONObject, "audioStreamInfo", this.akl);
        ac.putValue(jSONObject, "baseBandVersion", this.aki);
        ac.putValue(jSONObject, "fingerPrint", this.akj);
        ac.putValue(jSONObject, "screenBrightness", this.screenBrightness);
        ac.putValue(jSONObject, "isCharging", this.akk);
        ac.putValue(jSONObject, "chargeType", this.RW);
        f fVar = this.akm;
        if (fVar != null) {
            ac.a(jSONObject, "simCardInfo", fVar);
        }
        d dVar = this.akn;
        if (dVar != null) {
            ac.a(jSONObject, "environmentInfo", dVar);
        }
        com.kwad.sdk.k.a.b bVar = this.ako;
        if (bVar != null) {
            ac.a(jSONObject, "baseStationInfo", bVar);
        }
        List<e> list = this.akp;
        if (list != null) {
            ac.putValue(jSONObject, "sensorEventInfoList", list);
        }
        ac.putValue(jSONObject, "machineName", this.ajU);
        return jSONObject;
    }

    public static class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public int akq = -1;
        public int akr = -1;
        public int aks = -1;
        public int streamType;

        private static int bJ(int i) {
            if (i == 0) {
                return 0;
            }
            int i2 = 1;
            if (i != 1) {
                i2 = 2;
                if (i != 2) {
                    i2 = 3;
                    if (i != 3) {
                        i2 = 4;
                        if (i != 4) {
                            i2 = 5;
                            if (i != 5) {
                                return 0;
                            }
                        }
                    }
                }
            }
            return i2;
        }

        private a(int i) {
            this.streamType = i;
        }

        public static List<a> aM(Context context) {
            ArrayList arrayList = new ArrayList();
            if (context == null || com.kwad.sdk.core.config.e.al(256L)) {
                return arrayList;
            }
            try {
                AudioManager audioManager = (AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO);
                if (audioManager == null) {
                    return arrayList;
                }
                for (int i = 0; i <= 5; i++) {
                    a aVar = new a(i);
                    int iBJ = bJ(i);
                    aVar.aks = audioManager.getStreamVolume(iBJ);
                    aVar.akq = audioManager.getStreamMaxVolume(iBJ);
                    if (Build.VERSION.SDK_INT >= 28) {
                        aVar.akr = audioManager.getStreamMinVolume(iBJ);
                    }
                    arrayList.add(aVar);
                }
            } catch (Exception unused) {
            }
            return arrayList;
        }
    }
}
