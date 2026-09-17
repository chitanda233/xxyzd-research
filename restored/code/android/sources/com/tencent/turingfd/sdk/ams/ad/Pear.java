package com.tencent.turingfd.sdk.ams.ad;

import android.view.Window;
import android.view.WindowManager;
import java.lang.ref.WeakReference;
import java.util.WeakHashMap;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Pear {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final WeakHashMap f3874a = new WeakHashMap();
    public static final AtomicBoolean b = new AtomicBoolean(false);
    public static WeakReference c = null;

    public static boolean a(Window window) {
        WeakHashMap weakHashMap = f3874a;
        synchronized (weakHashMap) {
            if (!weakHashMap.containsKey(window)) {
                return true;
            }
            try {
                window.clearFlags(8192);
                synchronized (weakHashMap) {
                    weakHashMap.remove(window);
                }
                return true;
            } catch (Throwable unused) {
                return false;
            }
        }
    }

    public static boolean b(Window window) {
        WindowManager.LayoutParams attributes = window.getAttributes();
        if (attributes == null) {
            return false;
        }
        if ((attributes.flags & 8192) != 0) {
            return true;
        }
        try {
            window.addFlags(8192);
            WeakHashMap weakHashMap = f3874a;
            synchronized (weakHashMap) {
                weakHashMap.put(window, null);
            }
            return true;
        } catch (Throwable unused) {
            return false;
        }
    }
}
