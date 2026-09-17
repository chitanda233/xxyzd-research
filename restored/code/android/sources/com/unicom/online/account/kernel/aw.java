package com.unicom.online.account.kernel;

import java.util.concurrent.CountDownLatch;

/* JADX INFO: loaded from: classes4.dex */
public final class aw implements z {
    public final /* synthetic */ Object[] b;
    public final /* synthetic */ CountDownLatch c;

    public aw(Object[] objArr, CountDownLatch countDownLatch) {
        this.b = objArr;
        this.c = countDownLatch;
    }

    @Override // com.unicom.online.account.kernel.z
    public final void b(Object obj, boolean z) {
        if (z && obj != null) {
            this.b[0] = obj;
        }
        this.c.countDown();
    }
}
