package com.alipay.apmobilesecuritysdk.f;

import android.os.Process;

/* JADX INFO: loaded from: classes.dex */
class c implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ b f208a;

    public c(b bVar) {
        this.f208a = bVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        try {
            Process.setThreadPriority(0);
            while (!this.f208a.c.isEmpty()) {
                Runnable runnable = (Runnable) this.f208a.c.get(0);
                this.f208a.c.remove(0);
                if (runnable != null) {
                    runnable.run();
                }
            }
        } catch (Exception unused) {
        } catch (Throwable th) {
            this.f208a.b = null;
            throw th;
        }
        this.f208a.b = null;
    }
}
