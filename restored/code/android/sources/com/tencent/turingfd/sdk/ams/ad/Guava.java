package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Guava {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final Triangulum f3854a = new Triangulum(3);
    public static final Triangulum b = new Triangulum(3);
    public static final Cswitch[] c = new Cswitch[0];
    public static long d = 0;
    public static final Grapefruit e = new Grapefruit();

    public static String a() {
        Cswitch[] cswitchArr;
        Cswitch[] cswitchArr2;
        try {
            StringBuilder sb = new StringBuilder();
            Triangulum triangulum = b;
            synchronized (triangulum) {
                cswitchArr = (Cswitch[]) triangulum.b.toArray(c);
                triangulum.b.clear();
            }
            for (Cswitch cswitch : cswitchArr) {
                if (cswitch == null) {
                    break;
                }
                sb.append(cswitch.a());
                sb.append(com.alipay.sdk.m.w.a.p);
            }
            Triangulum triangulum2 = f3854a;
            synchronized (triangulum2) {
                cswitchArr2 = (Cswitch[]) triangulum2.b.toArray(c);
                triangulum2.b.clear();
            }
            for (Cswitch cswitch2 : cswitchArr2) {
                if (cswitch2 == null) {
                    break;
                }
                sb.append(cswitch2.a());
                sb.append(com.alipay.sdk.m.w.a.p);
            }
            return sb.toString();
        } catch (Throwable unused) {
            return "";
        }
    }
}
