package com.unicom.online.account.kernel;

import android.content.Context;
import java.util.concurrent.CountDownLatch;

/* JADX INFO: loaded from: classes4.dex */
public final class g implements z {
    public final /* synthetic */ CountDownLatch b;
    public final /* synthetic */ Context c;
    public final /* synthetic */ int d;
    public final /* synthetic */ f e;
    public final /* synthetic */ i f;

    public g(i iVar, CountDownLatch countDownLatch, long j, Context context, int i, f fVar) {
        this.f = iVar;
        this.b = countDownLatch;
        this.c = context;
        this.d = i;
        this.e = fVar;
    }

    @Override // com.unicom.online.account.kernel.z
    public final void b(Object obj, boolean z) {
        this.b.countDown();
        System.currentTimeMillis();
        Thread.currentThread().getName();
        if (!z) {
            this.e.b(this.d, 410003, "无法切换至数据网络");
        } else {
            u.b().getClass();
            this.f.b(this.c, this.d, obj, this.e);
        }
    }
}
