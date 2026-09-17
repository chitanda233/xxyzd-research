package com.tencent.turingfd.sdk.ams.ad;

import java.util.ArrayList;
import java.util.Collection;

/* JADX INFO: loaded from: classes4.dex */
public final class a extends Pyxis {
    public static ArrayList e;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f3909a = 0;
    public int b = 0;
    public ArrayList c = null;
    public int d = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(0, this.f3909a);
        phoenix.a(this.b, 1);
        phoenix.a((Collection) this.c, 2);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3909a = perseus.a(this.f3909a, 0, true);
        this.b = perseus.a(this.b, 1, true);
        if (e == null) {
            ArrayList arrayList = new ArrayList();
            e = arrayList;
            arrayList.add(new b());
        }
        this.c = (ArrayList) perseus.a((Object) e, 2, true);
    }
}
