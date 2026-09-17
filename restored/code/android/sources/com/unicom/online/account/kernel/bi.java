package com.unicom.online.account.kernel;

/* JADX INFO: loaded from: classes4.dex */
public final class bi {
    public static volatile bi f;
    public int b = 500;
    public int c = 1000;
    public int d = 1500;
    public int e = 1800;

    public static bi b() {
        if (f == null) {
            synchronized (bi.class) {
                if (f == null) {
                    f = new bi();
                }
            }
        }
        return f;
    }
}
