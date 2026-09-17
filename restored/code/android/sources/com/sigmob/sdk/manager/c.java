package com.sigmob.sdk.manager;

import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends ThreadPoolExecutor {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile c f3470a;

    public c() {
        super(0, Integer.MAX_VALUE, 30L, TimeUnit.SECONDS, new SynchronousQueue());
    }

    public static c a() {
        if (f3470a == null) {
            synchronized (c.class) {
                if (f3470a == null) {
                    f3470a = new c();
                }
            }
        }
        return f3470a;
    }
}
