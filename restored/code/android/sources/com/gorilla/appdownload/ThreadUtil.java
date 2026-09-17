package com.gorilla.appdownload;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes3.dex */
final class ThreadUtil {
    private ThreadUtil() {
    }

    static void runOnUiThread(Runnable runnable) {
        if (runnable == null) {
            return;
        }
        if (Looper.myLooper() == Looper.getMainLooper()) {
            runnable.run();
        } else {
            new Handler(Looper.getMainLooper()).post(runnable);
        }
    }
}
