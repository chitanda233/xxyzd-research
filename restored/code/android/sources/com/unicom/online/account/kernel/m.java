package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import java.util.concurrent.CountDownLatch;

/* JADX INFO: loaded from: classes4.dex */
public final class m implements Runnable {
    public final /* synthetic */ String b;
    public final /* synthetic */ int c;
    public final /* synthetic */ Network d;
    public final /* synthetic */ String e;
    public final /* synthetic */ q f;

    public m(q qVar, Context context, String str, int i, Network network, String str2) {
        this.f = qVar;
        this.b = str;
        this.c = i;
        this.d = network;
        this.e = str2;
    }

    @Override // java.lang.Runnable
    public final void run() {
        CountDownLatch countDownLatch;
        try {
            try {
                q qVar = this.f;
                String str = this.b;
                int i = this.c;
                Network network = this.d;
                qVar.getClass();
                p pVarB = q.b(str, i, network);
                if (pVarB != null) {
                    this.f.c.put(this.e, pVarB);
                    this.f.d.put(this.e, o.CONNECTED);
                } else {
                    this.f.d.put(this.e, o.FAILED);
                    ao.v = "域名 " + this.b + " 端口 " + this.c + " 预连接失败";
                }
                countDownLatch = (CountDownLatch) this.f.e.get(this.e);
                if (countDownLatch == null) {
                    return;
                }
            } catch (Exception e) {
                this.f.d.put(this.e, o.FAILED);
                e.getMessage();
                ao.v = "域名 " + this.b + " 端口 " + this.c + " 预连接异常: " + e.getMessage();
                as.b(e);
                countDownLatch = (CountDownLatch) this.f.e.get(this.e);
                if (countDownLatch == null) {
                    return;
                }
            }
            countDownLatch.countDown();
        } catch (Throwable th) {
            CountDownLatch countDownLatch2 = (CountDownLatch) this.f.e.get(this.e);
            if (countDownLatch2 != null) {
                countDownLatch2.countDown();
            }
            throw th;
        }
    }
}
