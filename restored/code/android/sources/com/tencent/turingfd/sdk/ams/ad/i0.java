package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Process;
import android.util.Log;
import java.io.File;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public abstract class i0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3935a = Cinstanceof.a(Cinstanceof.y0);
    public static final String b = Cinstanceof.a(Cinstanceof.z0);
    public static final AtomicBoolean c = new AtomicBoolean(false);

    public static void a() {
        Context context;
        if (c.getAndSet(true)) {
            return;
        }
        try {
            p pVar = new p(null);
            synchronized (Ccatch.class) {
                context = Ccatch.f3917a;
            }
            long jA = p.a(context, "502");
            int iMyUid = Process.myUid();
            if (jA == 0) {
                pVar.b(iMyUid);
            } else {
                if (iMyUid == jA) {
                    return;
                }
                p.a(jA);
                b();
            }
        } catch (Throwable th) {
            Log.w("Turing", th);
        }
    }

    public static void b() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        File dir = context.getDir(f3935a, 0);
        if (dir == null || !dir.exists()) {
            return;
        }
        File file = new File(new File(dir, "1"), b);
        if (file.exists()) {
            file.delete();
            File file2 = new File(new File(dir, "log"), ".t.log");
            if (file2.exists()) {
                file2.delete();
            }
        }
    }
}
