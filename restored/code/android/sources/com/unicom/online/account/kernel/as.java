package com.unicom.online.account.kernel;

import android.util.Log;

/* JADX INFO: loaded from: classes4.dex */
public abstract class as {
    public static boolean b = false;
    public static long c;
    public static int d;
    public static int e;
    public static final StringBuilder f = new StringBuilder();
    public static final StringBuilder g = new StringBuilder();
    public static final StringBuilder h = new StringBuilder();
    public static final StringBuilder i = new StringBuilder();

    public static void b(String str, int i2) {
        if (b) {
            if (i2 == 3) {
                if (e < 1000) {
                    StringBuilder sb = new StringBuilder("【");
                    int i3 = e;
                    e = i3 + 1;
                    String string = sb.append(i3).append("】:").append(str).append("\n").toString();
                    if (b) {
                        if (i2 == 0) {
                            g.append(string);
                        } else if (i2 == 2) {
                            h.append(string);
                        } else if (i2 == 3) {
                            i.append(string);
                        }
                        f.append(string);
                    }
                }
                i2 = 1;
            }
            if (d > 1000) {
                d = 0;
            }
            StringBuilder sb2 = new StringBuilder("【");
            int i4 = d;
            d = i4 + 1;
            String string2 = sb2.append(i4).append("】\n时间戳:").append(System.currentTimeMillis()).append("\n时间差:").append(System.currentTimeMillis() - c).append("\n数据:\n").append(str).append("\n\n").toString();
            if (b) {
                if (i2 == 0) {
                    g.append(string2);
                } else if (i2 == 2) {
                    h.append(string2);
                } else if (i2 == 3) {
                    i.append(string2);
                }
                f.append(string2);
            }
            c = System.currentTimeMillis();
        }
    }

    public static void b(String str) {
        if (b) {
            StringBuilder sb = new StringBuilder("6.3.3CR001B1208 ");
            boolean z = ap.b;
            Log.d("UniAccount", sb.append(str).toString());
            b(str, 0);
        }
    }

    public static void b(Exception exc) {
        if (b) {
            exc.printStackTrace();
        }
    }
}
