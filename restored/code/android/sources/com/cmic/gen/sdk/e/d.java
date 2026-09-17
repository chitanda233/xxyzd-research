package com.cmic.gen.sdk.e;

import android.content.Context;
import android.os.IBinder;
import com.hihonor.ads.identifier.AdvertisingIdClient;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: compiled from: HonorOaid.java */
/* JADX INFO: loaded from: classes2.dex */
public class d extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2102a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);

    d(Context context) {
        this.f2102a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    String a() {
        String str = "";
        try {
            AdvertisingIdClient.Info advertisingIdInfo = AdvertisingIdClient.getAdvertisingIdInfo(this.f2102a);
            if (advertisingIdInfo == null) {
                return "";
            }
            str = advertisingIdInfo.id;
            com.cmic.gen.sdk.f.c.b("HonorOaid", "getAdvertisingIdInfo id=" + advertisingIdInfo.id + ", isLimitAdTrackingEnabled=" + advertisingIdInfo.isLimit);
            return str;
        } catch (Exception e) {
            com.cmic.gen.sdk.f.c.a("HonorOaid", "getAdvertisingIdInfo Exception: " + e);
            return str;
        }
    }
}
