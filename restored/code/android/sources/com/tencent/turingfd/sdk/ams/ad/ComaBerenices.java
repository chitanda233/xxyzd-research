package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.Intent;
import android.os.Looper;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ComaBerenices {
    public static Centaurus a() {
        Context context;
        if (Looper.myLooper() == Looper.getMainLooper()) {
            return null;
        }
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        try {
            context.getPackageManager().getPackageInfo("com.android.vending", 0);
            Cepheus cepheus = new Cepheus();
            Intent intent = new Intent("com.google.android.gms.ads.identifier.service.START");
            intent.setPackage("com.google.android.gms");
            if (context.bindService(intent, cepheus, 1)) {
                try {
                    Chamaeleon chamaeleon = new Chamaeleon(cepheus.a());
                    return new Centaurus(chamaeleon.a(), chamaeleon.b());
                } catch (Exception unused) {
                } finally {
                    context.unbindService(cepheus);
                }
            }
        } catch (Exception unused2) {
        }
        return null;
    }
}
