package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;

/* JADX INFO: loaded from: classes2.dex */
public final class h extends b<com.bytedance.ads.convert.flat.j.c> {

    public class a implements o.b<com.bytedance.ads.convert.flat.j.c, String> {
        public a(h hVar) {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.c a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.c.a.f1712a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.c)) ? new com.bytedance.ads.convert.flat.j.c.a.C0329a(iBinder) : (com.bytedance.ads.convert.flat.j.c) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.c cVar) {
            com.bytedance.ads.convert.flat.j.c cVar2 = cVar;
            if (cVar2 == null) {
                return null;
            }
            return cVar2.a();
        }
    }

    public h() {
        super("com.zui.deviceidservice");
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.c, String> a() {
        return new a(this);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setClassName("com.zui.deviceidservice", "com.zui.deviceidservice.DeviceidService");
        return intent;
    }
}
