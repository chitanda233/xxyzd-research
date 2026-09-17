package com.sigmob.sdk.nativead;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes4.dex */
public class ad extends Handler {
    static final int b = 87108;
    long c;
    boolean d;

    public ad() {
        this.c = 100L;
        this.d = true;
    }

    public ad(Looper looper) {
        super(looper);
        this.c = 100L;
        this.d = true;
    }

    public void a() {
        sendEmptyMessageDelayed(b, this.c);
    }

    public void a(boolean stopped) {
        this.d = stopped;
    }

    public boolean b() {
        return this.d;
    }
}
