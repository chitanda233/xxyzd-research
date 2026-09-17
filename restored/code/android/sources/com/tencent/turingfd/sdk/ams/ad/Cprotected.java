package com.tencent.turingfd.sdk.ams.ad;

import android.os.Build;
import android.text.TextUtils;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.protected, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cprotected {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final AtomicReference f3954a = new AtomicReference();

    public static String a() {
        String str;
        AtomicReference atomicReference = f3954a;
        String str2 = (String) atomicReference.get();
        if (str2 != null) {
            return str2;
        }
        synchronized (atomicReference) {
            str = (String) atomicReference.get();
            if (str == null) {
                str = Build.MODEL;
                atomicReference.set(str);
            }
        }
        return str;
    }

    public static void b() {
        if (TextUtils.isEmpty(null)) {
            return;
        }
        AtomicReference atomicReference = f3954a;
        synchronized (atomicReference) {
            atomicReference.set(null);
        }
    }
}
