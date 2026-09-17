package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Grapefruit {
    public static void a(Cswitch cswitch) {
        int i = cswitch.b;
        if (i == 2 || i == 3) {
            Triangulum triangulum = Guava.b;
            synchronized (triangulum) {
                triangulum.a(cswitch);
            }
            return;
        }
        a aVar = cswitch.c;
        if (aVar != null) {
            long jAbs = Math.abs(aVar.f3909a - Guava.d);
            Guava.d = System.currentTimeMillis();
            if (jAbs < 1000) {
                return;
            }
            Triangulum triangulum2 = Guava.f3854a;
            synchronized (triangulum2) {
                triangulum2.a(cswitch);
            }
        }
    }
}
