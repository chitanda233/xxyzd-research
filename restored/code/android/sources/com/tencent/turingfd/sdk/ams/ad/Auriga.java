package com.tencent.turingfd.sdk.ams.ad;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class Auriga extends Pyxis implements Cloneable {
    public static final HashMap h;
    public static final HashMap i;
    public static final HashMap j;
    public static final /* synthetic */ boolean k = true;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f3821a = 0;
    public boolean b = true;
    public long c = 0;
    public Map d = null;
    public Map e = null;
    public long f = 0;
    public Map g = null;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(0, this.f3821a);
        phoenix.a(this.b ? (byte) 1 : (byte) 0, 1);
        phoenix.a(2, this.c);
        phoenix.a(this.d, 3);
        phoenix.a(this.e, 4);
        phoenix.a(5, this.f);
        Map map = this.g;
        if (map != null) {
            phoenix.a(map, 6);
        }
    }

    public final Object clone() {
        try {
            return super.clone();
        } catch (CloneNotSupportedException unused) {
            if (k) {
                return null;
            }
            throw new AssertionError();
        }
    }

    public final boolean equals(Object obj) {
        if (obj == null) {
            return false;
        }
        Auriga auriga = (Auriga) obj;
        long j2 = this.f3821a;
        long j3 = auriga.f3821a;
        int i2 = Scorpius.f3887a;
        return j2 == j3 && this.b == auriga.b && this.c == auriga.c && this.d.equals(auriga.d) && this.e.equals(auriga.e) && this.f == auriga.f && this.g.equals(auriga.g);
    }

    public final int hashCode() {
        try {
            throw new Exception("");
        } catch (Exception e) {
            e.printStackTrace();
            return 0;
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3821a = perseus.a(this.f3821a, 0, true);
        this.b = perseus.a(this.b, 1, true);
        this.c = perseus.a(this.c, 2, true);
        this.d = (Map) perseus.a((Object) h, 3, true);
        this.e = (Map) perseus.a((Object) i, 4, true);
        this.f = perseus.a(this.f, 5, true);
        this.g = (Map) perseus.a((Object) j, 6, false);
    }

    static {
        HashMap map = new HashMap();
        h = map;
        map.put("", "");
        HashMap map2 = new HashMap();
        i = map2;
        map2.put(0, 0);
        HashMap map3 = new HashMap();
        j = map3;
        map3.put("", "");
    }
}
