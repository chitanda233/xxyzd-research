package com.sigmob.sdk.base.common;

import android.os.Handler;
import android.os.HandlerThread;
import java.util.ArrayList;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public class ab {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3140a = "NativeLoadReadyRecordManager";
    private static final ab f = new ab();
    private boolean b = false;
    private int c = 120;
    private HandlerThread d;
    private Handler e;

    private class a implements Runnable {
        private a() {
        }

        @Override // java.lang.Runnable
        public void run() {
            if (ab.this.b) {
                ab.this.d();
                try {
                    HashMap<String, aa> mapA = aa.a();
                    if (com.sigmob.sdk.base.utils.f.b(mapA)) {
                        for (aa aaVar : new ArrayList(mapA.values())) {
                            if (aaVar != null) {
                                ad.a(aaVar);
                                aaVar.b();
                            }
                        }
                    }
                } catch (Throwable unused) {
                }
                if (com.sigmob.sdk.base.utils.v.b(ab.this.e)) {
                    ab.this.e.postDelayed(this, ((long) ab.this.c) * 1000);
                }
            }
        }
    }

    private ab() {
    }

    public static ab a() {
        return f;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d() {
        Handler handler = this.e;
        if (handler == null) {
            return;
        }
        handler.removeCallbacksAndMessages(null);
    }

    public void a(int logIntervalTime) {
        if (logIntervalTime <= 0) {
            c();
            return;
        }
        int iMax = Math.max(logIntervalTime, 10);
        if (this.c == iMax) {
            return;
        }
        this.c = iMax;
        if (!this.b) {
            b();
        } else if (com.sigmob.sdk.base.utils.v.b(this.e)) {
            this.e.removeCallbacksAndMessages(null);
            this.e.postDelayed(new a(), ((long) logIntervalTime) * 1000);
        }
    }

    public synchronized void b() {
        if (this.b) {
            return;
        }
        this.b = true;
        aa.c();
        if (this.d == null) {
            HandlerThread handlerThread = new HandlerThread(f3140a);
            this.d = handlerThread;
            handlerThread.start();
        }
        if (this.e == null) {
            this.e = new Handler(this.d.getLooper());
        }
        this.e.removeCallbacksAndMessages(null);
        this.e.postDelayed(new a(), ((long) this.c) * 1000);
    }

    public void c() {
        this.b = false;
        d();
    }
}
