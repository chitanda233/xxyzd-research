package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;

/* JADX INFO: loaded from: classes4.dex */
public final class Cygnus implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Dorado f3843a;

    public Cygnus(Dorado dorado) {
        this.f3843a = dorado;
    }

    @Override // java.lang.Runnable
    public final void run() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        if (!Carambola.b(context)) {
            return;
        }
        int i = 0;
        while (true) {
            String[] strArr = this.f3843a.f3846a;
            if (i >= strArr.length) {
                return;
            }
            try {
                Ginkgo ginkgo = new Ginkgo(strArr[i]);
                ginkgo.c = 10000;
                ginkgo.d = 10000;
                Eridanus.a(new Gooseberry(ginkgo));
                this.f3843a.b = i;
                return;
            } catch (Throwable unused) {
                i++;
            }
        }
    }
}
