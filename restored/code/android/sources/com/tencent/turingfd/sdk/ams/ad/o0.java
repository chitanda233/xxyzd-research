package com.tencent.turingfd.sdk.ams.ad;

import android.view.MotionEvent;
import android.view.Window;

/* JADX INFO: loaded from: classes4.dex */
public final class o0 extends Cnew {
    public final String b;
    public final Cdefault c;

    public o0(Window.Callback callback, String str, Cdefault cdefault) {
        super(callback);
        this.b = str;
        this.c = cdefault;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Cnew, android.view.Window.Callback
    public final boolean dispatchTouchEvent(MotionEvent motionEvent) {
        Cdefault cdefault = this.c;
        String str = this.b;
        if (!cdefault.f3922a.get()) {
            Bilberry bilberryA = Bilberry.a(str, motionEvent);
            cdefault.b.obtainMessage(2, bilberryA).sendToTarget();
            if (Cassiopeia.d.get() && bilberryA.e == 0) {
                return true;
            }
        }
        return super.dispatchTouchEvent(motionEvent);
    }
}
