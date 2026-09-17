package com.tencent.turingfd.sdk.ams.ad;

import android.app.Activity;

/* JADX INFO: loaded from: classes4.dex */
public final class Peanut implements Activity.ScreenCaptureCallback {
    public static final Peach[] c = new Peach[0];
    public static final Papaya d = new Papaya();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Triangulum f3873a = new Triangulum(3);
    public volatile String b;

    public final String a() {
        Peach[] peachArr;
        try {
            StringBuilder sb = new StringBuilder();
            synchronized (this.f3873a) {
                peachArr = (Peach[]) this.f3873a.b.toArray(c);
                this.f3873a.b.clear();
            }
            if (peachArr.length == 0) {
                return null;
            }
            for (Peach peach : peachArr) {
                if (peach == null) {
                    break;
                }
                if (sb.length() > 0) {
                    sb.append(",");
                }
                sb.append(Cswitch.a(peach.f3872a) + ":" + peach.b);
            }
            return sb.toString();
        } catch (Throwable unused) {
            return null;
        }
    }

    @Override // android.app.Activity.ScreenCaptureCallback
    public final void onScreenCaptured() {
        synchronized (this.f3873a) {
            this.f3873a.a(new Peach(this.b));
        }
    }
}
