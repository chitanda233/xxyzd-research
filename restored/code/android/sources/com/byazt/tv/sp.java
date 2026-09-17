package com.byazt.tv;

import android.os.Handler;
import android.os.Message;
import android.os.SystemClock;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 239, 91})
public class sp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Handler f1453a;
    public int c;
    public long n;
    public int tt;
    public Object uj;
    public int ve;

    private sp(int i, int i2, int i3, Object obj, long j, Handler handler) {
        this.c = i;
        this.tt = i2;
        this.ve = i3;
        this.uj = obj;
        this.n = j;
        this.f1453a = handler;
    }

    public static sp c(Message message) {
        return new sp(message.what, message.arg1, message.arg2, message.obj, tt(message), message.getTarget());
    }

    public static Message c(Handler handler, sp spVar) {
        Handler handler2 = spVar.f1453a;
        if (handler2 != null) {
            return handler2.obtainMessage(spVar.c, spVar.tt, spVar.ve, spVar.uj);
        }
        return handler.obtainMessage(spVar.c, spVar.tt, spVar.ve, spVar.uj);
    }

    public static long c(sp spVar) {
        return spVar.n;
    }

    private static long tt(Message message) {
        if (message == null) {
            return 0L;
        }
        return Math.max(message.getWhen() - SystemClock.uptimeMillis(), 0L);
    }
}
