package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.os.Environment;
import android.os.Process;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Cranberry {
    public static int a(Context context, String str) {
        return context.checkPermission(str, Process.myPid(), Process.myUid());
    }

    public static boolean a() {
        Context context;
        int i = Build.VERSION.SDK_INT;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        if (context.checkPermission(com.kuaishou.weapon.p0.g.i, Process.myPid(), Process.myUid()) != 0) {
            return false;
        }
        if (i >= 29) {
            return Environment.isExternalStorageLegacy();
        }
        return true;
    }
}
