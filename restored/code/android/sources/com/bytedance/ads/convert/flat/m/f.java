package com.bytedance.ads.convert.flat.m;

import android.os.IBinder;
import android.os.IInterface;
import android.util.Pair;

/* JADX INFO: loaded from: classes2.dex */
public final class f implements o.b<com.bytedance.ads.convert.flat.j.i, Pair<String, Boolean>> {
    @Override // com.bytedance.ads.convert.flat.m.o.b
    public com.bytedance.ads.convert.flat.j.i a(IBinder iBinder) {
        int i = com.bytedance.ads.convert.flat.j.i.a.f1722a;
        if (iBinder == null) {
            return null;
        }
        IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(com.alipay.sdk.m.d.b.f273a);
        return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.i)) ? new com.bytedance.ads.convert.flat.j.i.a.C0334a(iBinder) : (com.bytedance.ads.convert.flat.j.i) iInterfaceQueryLocalInterface;
    }

    @Override // com.bytedance.ads.convert.flat.m.o.b
    public Pair<String, Boolean> a(com.bytedance.ads.convert.flat.j.i iVar) {
        com.bytedance.ads.convert.flat.j.i iVar2 = iVar;
        if (iVar2 == null) {
            return null;
        }
        return new Pair<>(iVar2.c(), Boolean.valueOf(iVar2.b()));
    }
}
