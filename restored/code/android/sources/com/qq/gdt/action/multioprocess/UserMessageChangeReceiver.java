package com.qq.gdt.action.multioprocess;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.os.Handler;
import android.os.HandlerThread;
import com.qq.gdt.action.i.o;

/* JADX INFO: loaded from: classes3.dex */
public class UserMessageChangeReceiver extends BroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static String f3091a = "_gdt.action.USER_MESSAGE_CHANGED";
    public static String b = ".gdt.qq.RECEIVE_PERMISSION";
    public static String c = ".gdt.qq.SEND_PERMISSION";
    private volatile HandlerThread d;
    private volatile Handler e;
    private final Object f = new Object();

    public UserMessageChangeReceiver() {
        Context contextG = com.qq.gdt.action.d.a().g();
        if (contextG != null) {
            f3091a = contextG.getPackageName() + f3091a;
            b = contextG.getPackageName() + b;
            c = contextG.getPackageName() + c;
        }
        a();
    }

    private void a() {
        if (this.d == null || this.e == null) {
            synchronized (this.f) {
                if (this.d == null || this.e == null) {
                    if (this.d == null) {
                        this.d = new HandlerThread("UserMessageReceiver");
                        this.d.start();
                    }
                    if (this.e == null) {
                        this.e = new Handler(this.d.getLooper());
                    }
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, b bVar) {
        try {
            if (!f3091a.equals(str) || bVar == null) {
                return;
            }
            d.a().f3099a = bVar;
        } catch (Throwable th) {
            o.b("processUserMessage error", th);
        }
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        if (this.d == null || this.e == null) {
            a();
        }
        if (this.e != null) {
            this.e.removeCallbacksAndMessages(null);
            final String action = intent.getAction();
            final b bVar = f3091a.equals(action) ? (b) intent.getSerializableExtra("user_message") : null;
            this.e.postDelayed(new Runnable() { // from class: com.qq.gdt.action.multioprocess.UserMessageChangeReceiver.1
                @Override // java.lang.Runnable
                public void run() {
                    UserMessageChangeReceiver.this.a(action, bVar);
                }
            }, 1000L);
        }
    }
}
