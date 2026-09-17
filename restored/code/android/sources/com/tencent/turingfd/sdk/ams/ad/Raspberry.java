package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.text.TextUtils;
import java.io.File;
import java.util.HashMap;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Raspberry {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final HashMap f3885a = new HashMap();
    public static final Object b;

    static {
        new AtomicBoolean(false);
        b = new Object();
        new AtomicReference();
    }

    public static File a() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        return new File(context.getDir("turingfd", 0), f.f);
    }

    public static void a(long j, String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        Rambutan rambutan = new Rambutan(j, str);
        String strValueOf = String.valueOf(Bullace.a(str.getBytes()));
        HashMap map = f3885a;
        synchronized (map) {
            map.put(strValueOf, rambutan);
        }
        Ara.b.submit(new Quarenden(rambutan));
    }
}
