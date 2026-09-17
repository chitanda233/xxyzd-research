package com.tencent.turingfd.sdk.ams.ad;

import java.util.ArrayList;
import java.util.Collection;

/* JADX INFO: loaded from: classes4.dex */
public final class Melon extends Pyxis {
    public static final ArrayList d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3867a = 0;
    public int b = 0;
    public ArrayList c = null;

    static {
        ArrayList arrayList = new ArrayList();
        d = arrayList;
        arrayList.add(new Mangosteen());
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        int i = this.f3867a;
        if (i != 0) {
            phoenix.a(i, 0);
        }
        int i2 = this.b;
        if (i2 != 0) {
            phoenix.a(i2, 1);
        }
        ArrayList arrayList = this.c;
        if (arrayList != null) {
            phoenix.a((Collection) arrayList, 2);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3867a = perseus.a(this.f3867a, 0, false);
        this.b = perseus.a(this.b, 1, false);
        this.c = (ArrayList) perseus.a((Object) d, 2, false);
    }
}
