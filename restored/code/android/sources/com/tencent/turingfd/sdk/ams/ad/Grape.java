package com.tencent.turingfd.sdk.ams.ad;

import java.io.PrintStream;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class Grape extends Pyxis {
    public static byte[] k = null;
    public static HashMap l = null;
    public static final /* synthetic */ boolean m = true;
    public byte[] g;
    public Map i;
    public Map j;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public short f3853a = 0;
    public byte b = 0;
    public int c = 0;
    public int d = 0;
    public String e = null;
    public String f = null;
    public int h = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3853a, 1);
        phoenix.a(this.b, 2);
        phoenix.a(this.c, 3);
        phoenix.a(this.d, 4);
        phoenix.a(this.e, 5);
        phoenix.a(this.f, 6);
        phoenix.a(7, this.g);
        phoenix.a(this.h, 8);
        phoenix.a(this.i, 9);
        phoenix.a(this.j, 10);
    }

    public final Object clone() {
        try {
            return super.clone();
        } catch (CloneNotSupportedException unused) {
            if (m) {
                return null;
            }
            throw new AssertionError();
        }
    }

    public final boolean equals(Object obj) {
        Grape grape = (Grape) obj;
        short s = grape.f3853a;
        int i = Scorpius.f3887a;
        Integer num = 1;
        return 1 == s && 1 == grape.b && 1 == grape.c && 1 == grape.d && num.equals(grape.e) && num.equals(grape.f) && num.equals(grape.g) && 1 == grape.h && num.equals(grape.i) && num.equals(grape.j);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        String str;
        try {
            this.f3853a = perseus.a(this.f3853a, 1, true);
            this.b = perseus.a(this.b, 2, true);
            this.c = perseus.a(this.c, 3, true);
            this.d = perseus.a(this.d, 4, true);
            this.e = perseus.b(5, true);
            this.f = perseus.b(6, true);
            if (k == null) {
                k = new byte[]{0};
            }
            this.g = perseus.a(7, true);
            this.h = perseus.a(this.h, 8, true);
            if (l == null) {
                HashMap map = new HashMap();
                l = map;
                map.put("", "");
            }
            this.i = (Map) perseus.a((Object) l, 9, true);
            if (l == null) {
                HashMap map2 = new HashMap();
                l = map2;
                map2.put("", "");
            }
            this.j = (Map) perseus.a((Object) l, 10, true);
        } catch (Exception e) {
            e.printStackTrace();
            PrintStream printStream = System.out;
            StringBuilder sb = new StringBuilder("RequestPacket decode error ");
            byte[] bArr = this.g;
            if (bArr == null || bArr.length == 0) {
                str = null;
            } else {
                char[] cArr = new char[bArr.length * 2];
                for (int i = 0; i < bArr.length; i++) {
                    byte b = bArr[i];
                    int i2 = i * 2;
                    char[] cArr2 = p0.f3953a;
                    cArr[i2 + 1] = cArr2[b & 15];
                    cArr[i2] = cArr2[((byte) (b >>> 4)) & 15];
                }
                str = new String(cArr);
            }
            printStream.println(sb.append(str).toString());
            throw new RuntimeException(e);
        }
    }
}
