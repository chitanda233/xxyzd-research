package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;

/* JADX INFO: loaded from: classes4.dex */
public final class m extends Handler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Context f3945a;
    public final /* synthetic */ n b;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public m(n nVar, Looper looper, Context context) {
        super(looper);
        this.b = nVar;
        this.f3945a = context;
    }

    @Override // android.os.Handler
    public final void handleMessage(Message message) {
        System.currentTimeMillis();
        int i = message.what;
        if (i == 1) {
            this.b.a(this.f3945a, true, 3);
            return;
        }
        if (i != 2) {
            return;
        }
        this.b.a(this.b.b(this.f3945a, false, ((Integer) message.obj).intValue()), false);
        synchronized (this.b.g) {
            this.b.g.set(Boolean.FALSE);
            this.b.g.notifyAll();
        }
    }
}
