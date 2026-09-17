package com.tencent.turingfd.sdk.ams.ad;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Coconut implements Equuleus {
    @Override // com.tencent.turingfd.sdk.ams.ad.Equuleus
    public final Bryony a(Context context) {
        AtomicReference atomicReference = new AtomicReference();
        atomicReference.set("");
        try {
            AtomicReference atomicReference2 = new AtomicReference();
            AtomicReference atomicReference3 = new AtomicReference();
            if (a(context, atomicReference2, atomicReference3) == 0) {
                a(context, atomicReference2, atomicReference3, atomicReference);
            }
        } catch (Throwable unused) {
        }
        return new Bryony((String) atomicReference.get());
    }

    public abstract String a(IBinder iBinder);

    public static int a(Context context, AtomicReference atomicReference, AtomicReference atomicReference2) {
        Object obj = new Object();
        Intent intent = new Intent(Cinstanceof.a(Cinstanceof.k));
        intent.setComponent(new ComponentName(Cinstanceof.a(Cinstanceof.g), Cinstanceof.a(Cinstanceof.h)));
        if (!context.bindService(intent, new Cherry(atomicReference, atomicReference2, obj), 1)) {
            return -100;
        }
        if (atomicReference.get() == null) {
            synchronized (obj) {
                try {
                    obj.wait(1000L);
                } catch (Throwable unused) {
                }
            }
        }
        return atomicReference.get() == null ? -105 : 0;
    }

    public final int a(Context context, AtomicReference atomicReference, AtomicReference atomicReference2, AtomicReference atomicReference3) {
        Object obj = new Object();
        AtomicReference atomicReference4 = new AtomicReference(0);
        new Chestnut(this, atomicReference, atomicReference4, atomicReference3, context, atomicReference2, obj).start();
        synchronized (obj) {
            try {
                obj.wait(1000L);
            } catch (Throwable unused) {
            }
        }
        return ((Integer) atomicReference4.get()).intValue();
    }
}
