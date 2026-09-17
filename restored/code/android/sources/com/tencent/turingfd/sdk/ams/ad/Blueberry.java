package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.os.Looper;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Blueberry {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final ConcurrentHashMap f3827a;
    public static final AtomicReference b;
    public static final String c;

    static {
        ConcurrentHashMap concurrentHashMap = new ConcurrentHashMap();
        f3827a = concurrentHashMap;
        b = new AtomicReference();
        concurrentHashMap.put("C892BA2", new Codlin());
        concurrentHashMap.put("43780D5", new Codlin());
        concurrentHashMap.put("7CD3AF2", new Codlin());
        concurrentHashMap.put("22792AF", new Casaba());
        c = "";
        try {
            c = Teazle.a(Berry.a(Build.MANUFACTURER.toLowerCase().getBytes())).substring(0, 7);
        } catch (Throwable unused) {
        }
    }

    public static Bryony a(Context context) {
        AtomicReference atomicReference = b;
        Bryony bryony = (Bryony) atomicReference.get();
        if (bryony != null) {
            return bryony;
        }
        synchronized (atomicReference) {
            Bryony bryony2 = (Bryony) atomicReference.get();
            if (bryony2 != null) {
                return bryony2;
            }
            if (Looper.myLooper() == Looper.getMainLooper()) {
                return new Bryony("");
            }
            Equuleus equuleus = (Equuleus) f3827a.get(c);
            if (equuleus == null) {
                return new Bryony("");
            }
            Bryony bryonyA = equuleus.a(context);
            atomicReference.set(bryonyA);
            return bryonyA;
        }
    }
}
