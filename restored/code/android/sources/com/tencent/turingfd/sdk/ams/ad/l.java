package com.tencent.turingfd.sdk.ams.ad;

import android.util.Log;
import java.util.HashMap;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public final class l extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicBoolean f3943a;
    public final /* synthetic */ HashMap b;
    public final /* synthetic */ ITuringDeviceInfoProvider c;
    public final /* synthetic */ Object d;

    public l(AtomicBoolean atomicBoolean, HashMap map, ITuringDeviceInfoProvider iTuringDeviceInfoProvider, Object obj) {
        this.f3943a = atomicBoolean;
        this.b = map;
        this.c = iTuringDeviceInfoProvider;
        this.d = obj;
    }

    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        super.run();
        if (this.f3943a.get()) {
            return;
        }
        try {
            HashMap map = this.b;
            String imei = this.c.getImei();
            if (imei == null) {
                imei = "";
            }
            map.put("274", imei);
            HashMap map2 = this.b;
            String imsi = this.c.getImsi();
            if (imsi == null) {
                imsi = "";
            }
            map2.put("276", imsi);
            HashMap map3 = this.b;
            String androidId = this.c.getAndroidId();
            if (androidId == null) {
                androidId = "";
            }
            map3.put("275", androidId);
        } catch (Throwable unused) {
            Log.w("Turing", "invoke info impl exception");
        }
        synchronized (this.d) {
            this.d.notify();
        }
    }
}
