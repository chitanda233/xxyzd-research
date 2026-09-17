package com.tencent.turingfd.sdk.ams.ad;

import android.view.accessibility.AccessibilityEvent;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Cassiopeia {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final AtomicInteger f3834a = new AtomicInteger(0);
    public static final AtomicBoolean b = new AtomicBoolean(false);
    public static final AtomicBoolean c = new AtomicBoolean(false);
    public static final AtomicBoolean d = new AtomicBoolean(false);

    public static void a() {
        AtomicInteger atomicInteger = f3834a;
        synchronized (atomicInteger) {
            atomicInteger.get();
            atomicInteger.set(0);
        }
    }

    public static void b(AccessibilityEvent accessibilityEvent) {
        AccessibilityEvent.obtain(accessibilityEvent);
    }

    public static void a(AccessibilityEvent accessibilityEvent) {
        AccessibilityEvent.obtain(accessibilityEvent);
    }
}
