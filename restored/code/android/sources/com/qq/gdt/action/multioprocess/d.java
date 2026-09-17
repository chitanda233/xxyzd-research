package com.qq.gdt.action.multioprocess;

import android.content.Context;
import android.content.Intent;
import android.os.Handler;
import android.os.HandlerThread;
import android.text.TextUtils;
import com.qq.gdt.action.ChannelType;
import com.qq.gdt.action.i.g;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.v;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private static volatile d b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public b f3099a;
    private HandlerThread c;
    private Handler d;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        b f3100a;

        a(b bVar) {
            this.f3100a = bVar;
        }

        @Override // java.lang.Runnable
        public void run() {
            o.a("BroadSendRunnable run", new Object[0]);
            Intent intent = new Intent();
            intent.setAction(UserMessageChangeReceiver.f3091a);
            intent.putExtra("user_message", this.f3100a);
            Context contextG = com.qq.gdt.action.d.a().g();
            if (contextG == null || TextUtils.isEmpty(contextG.getPackageName())) {
                o.b("Context is null, cannot send broadcast");
                return;
            }
            intent.setPackage(contextG.getPackageName());
            try {
                contextG.sendBroadcast(intent, UserMessageChangeReceiver.c);
            } catch (Exception e) {
                o.b("sendBroadcast failed", e);
            }
        }
    }

    public static d a() {
        if (b == null) {
            synchronized (d.class) {
                if (b == null) {
                    b = new d();
                }
            }
        }
        return b;
    }

    private void a(b bVar) {
        o.a("notifyAllProcess BroadSendRunnable, userMessage = " + bVar, new Object[0]);
        if (this.c == null) {
            HandlerThread handlerThread = new HandlerThread("send HandlerThread");
            this.c = handlerThread;
            handlerThread.start();
        }
        if (this.d == null) {
            this.d = new Handler(this.c.getLooper());
        }
        this.d.removeCallbacksAndMessages(null);
        this.d.postDelayed(new a(bVar), 1000L);
    }

    private synchronized void g() {
        if (this.f3099a == null) {
            b bVarB = b();
            this.f3099a = bVarB;
            if (bVarB == null) {
                this.f3099a = new b();
            }
        }
    }

    private synchronized com.qq.gdt.action.multioprocess.b.a h() {
        b bVar;
        bVar = this.f3099a;
        return (bVar == null || bVar.o() == null) ? null : this.f3099a.o();
    }

    private synchronized void i() {
        if (TextUtils.isEmpty(this.f3099a.b())) {
            com.qq.gdt.action.g.a.a(2308, this.f3099a);
        } else {
            this.f3099a.b().equals(this.f3099a.h());
        }
        if (TextUtils.isEmpty(this.f3099a.c())) {
            com.qq.gdt.action.g.a.a(2309);
        } else {
            this.f3099a.c().equals(this.f3099a.i());
        }
        if (!TextUtils.isEmpty(this.f3099a.d()) && !TextUtils.isEmpty(this.f3099a.j())) {
            this.f3099a.d().equals(this.f3099a.j());
        }
    }

    public b a(String str, String str2, ChannelType channelType, String str3, String str4, boolean z) {
        o.a("updateRemoteMessage enter", new Object[0]);
        g();
        if (channelType == null) {
            channelType = ChannelType.CHANNEL_TENCENT;
        }
        this.f3099a.e(str).f(str2).b(channelType).g(str3).h(str4);
        if (z) {
            com.qq.gdt.action.multioprocess.a.a().a(this.f3099a);
        }
        i();
        a(this.f3099a);
        return this.f3099a;
    }

    public b a(String str, String str2, ChannelType channelType, String str3, boolean z) {
        g();
        this.f3099a.a(str).b(str2).a(channelType).c(str3);
        o.a("updateUserSetMessage needSaveUserSetInfo = " + z, new Object[0]);
        if (z) {
            com.qq.gdt.action.multioprocess.a.a().a(this.f3099a);
        }
        o.a("update UserMessage-> updateUserSetMessage = " + this.f3099a, new Object[0]);
        i();
        a(this.f3099a);
        return this.f3099a;
    }

    public synchronized void a(com.qq.gdt.action.multioprocess.b.a aVar) {
        g();
        this.f3099a.a(aVar);
        com.qq.gdt.action.multioprocess.a.a().a(this.f3099a);
        o.a("update UserMessage-> updateDeviceMessage = " + this.f3099a, new Object[0]);
        a(this.f3099a);
    }

    public synchronized void a(String str) {
        g();
        this.f3099a.d(str);
        com.qq.gdt.action.multioprocess.a.a().a(this.f3099a);
        o.a("update UserMessage-> updateUniqueIdMessage = " + this.f3099a, new Object[0]);
        a(this.f3099a);
    }

    public synchronized b b() {
        b bVarC = c();
        this.f3099a = bVarC;
        if (bVarC == null) {
            this.f3099a = com.qq.gdt.action.multioprocess.a.a().b();
        }
        return this.f3099a;
    }

    public synchronized b c() {
        return this.f3099a;
    }

    public synchronized String d() {
        String strF = f();
        if (com.qq.gdt.action.d.a().g() == null) {
            o.a("getUserUniqueId context is null，no allow ipc getUserUniqueId", new Object[0]);
        } else if (TextUtils.isEmpty(strF)) {
            if (g.a().b()) {
                return strF;
            }
            this.f3099a = com.qq.gdt.action.multioprocess.a.a().b();
            strF = f();
        }
        return strF;
    }

    public synchronized com.qq.gdt.action.multioprocess.b.a e() {
        com.qq.gdt.action.multioprocess.b.a aVarH = h();
        if (com.qq.gdt.action.d.a().g() == null) {
            o.a("getPrivacyStatus context is null，no allow ipc getPrivacyStatus", new Object[0]);
        } else if (aVarH == null) {
            if (g.a().b()) {
                return null;
            }
            this.f3099a = com.qq.gdt.action.multioprocess.a.a().b();
            aVarH = h();
        }
        return aVarH;
    }

    public synchronized String f() {
        String strF;
        strF = "";
        b bVar = this.f3099a;
        if (bVar != null && !v.a(bVar.b())) {
            strF = this.f3099a.f();
        }
        return strF;
    }
}
