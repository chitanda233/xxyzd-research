package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Process;
import android.view.WindowManager;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.function.Consumer;

/* JADX INFO: loaded from: classes4.dex */
public final class Pineapple implements Consumer {
    public static final Persimmon c = new Persimmon();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AtomicInteger f3877a = new AtomicInteger(0);
    public final AtomicBoolean b = new AtomicBoolean(false);

    public final void a() {
        synchronized (this.b) {
            if (this.b.get()) {
                return;
            }
            Context contextA = Ccatch.a();
            if (contextA == null) {
                return;
            }
            if (contextA.checkPermission("android.permission.DETECT_SCREEN_RECORDING", Process.myPid(), Process.myUid()) != 0) {
                return;
            }
            try {
                this.f3877a.set(((WindowManager) contextA.getSystemService("window")).addScreenRecordingCallback(Ara.b, this));
                this.b.set(true);
            } catch (Throwable unused) {
            }
        }
    }

    @Override // java.util.function.Consumer
    public final void accept(Object obj) {
        this.f3877a.set(((Integer) obj).intValue());
    }
}
