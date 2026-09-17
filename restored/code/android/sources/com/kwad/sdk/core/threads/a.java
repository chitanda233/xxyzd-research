package com.kwad.sdk.core.threads;

import android.os.Handler;
import android.os.HandlerThread;
import android.text.TextUtils;
import java.lang.ref.WeakReference;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static Map<String, WeakReference<C0517a>> aYp = new ConcurrentHashMap();

    public static synchronized Handler Oa() {
        return fn("reportHT").getHandler();
    }

    private static C0517a fn(String str) {
        WeakReference<C0517a> weakReference = aYp.get(str);
        if (weakReference == null || weakReference.get() == null) {
            C0517a c0517a = new C0517a(str);
            aYp.put(str, new WeakReference<>(c0517a));
            return c0517a;
        }
        return weakReference.get();
    }

    /* JADX INFO: renamed from: com.kwad.sdk.core.threads.a$a, reason: collision with other inner class name */
    public static class C0517a {
        private HandlerThread aYq;
        private Handler jc;

        public C0517a(String str) {
            HandlerThread handlerThread = new HandlerThread(TextUtils.isEmpty(str) ? "ksad-HT" : "ksad-" + str);
            this.aYq = handlerThread;
            handlerThread.start();
            this.jc = new Handler(this.aYq.getLooper());
        }

        public final Handler getHandler() {
            return this.jc;
        }
    }
}
