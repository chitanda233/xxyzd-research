package com.tencent.turingfd.sdk.ams.ad;

import java.util.ArrayList;
import java.util.Collection;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.public, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cpublic extends Pyxis {
    public static final Pomegranate e = new Pomegranate();
    public static final ArrayList f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3955a = 0;
    public int b = 0;
    public Pomegranate c = null;
    public ArrayList d = null;

    static {
        ArrayList arrayList = new ArrayList();
        f = arrayList;
        arrayList.add(new Cimport());
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        int i = this.f3955a;
        if (i != 0) {
            phoenix.a(i, 0);
        }
        int i2 = this.b;
        if (i2 != 0) {
            phoenix.a(i2, 1);
        }
        Pomegranate pomegranate = this.c;
        if (pomegranate != null) {
            phoenix.a((Pyxis) pomegranate, 2);
        }
        ArrayList arrayList = this.d;
        if (arrayList != null) {
            phoenix.a((Collection) arrayList, 3);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3955a = perseus.a(this.f3955a, 0, false);
        this.b = perseus.a(this.b, 1, false);
        this.c = (Pomegranate) perseus.a((Pyxis) e, 2, false);
        this.d = (ArrayList) perseus.a((Object) f, 3, false);
    }
}
