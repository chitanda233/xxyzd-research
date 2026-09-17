package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.widget.Toast;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.c, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0597c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Handler f1964a;

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.c$a */
    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Context f1965a;
        final /* synthetic */ String b;

        a(Context context, String str) {
            this.f1965a = context;
            this.b = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            Toast.makeText(this.f1965a, this.b, 0).show();
        }
    }

    public static int a(Context context, float f) {
        return (int) ((f * context.getResources().getDisplayMetrics().density) + 0.5f);
    }

    public static void a(Context context, String str) {
        f1964a = new Handler(Looper.getMainLooper());
        a(new a(context, str));
    }

    private static void a(Runnable runnable) {
        if (Looper.getMainLooper() == Looper.myLooper()) {
            runnable.run();
        } else {
            f1964a.post(runnable);
        }
    }
}
