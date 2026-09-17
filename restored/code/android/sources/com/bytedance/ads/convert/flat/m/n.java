package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;

/* JADX INFO: loaded from: classes2.dex */
public final class n extends b<com.bytedance.ads.convert.flat.j.b> {

    public class a implements o.b<com.bytedance.ads.convert.flat.j.b, String> {
        public a(n nVar) {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.b a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.b.a.f1710a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.samsung.android.deviceidservice.IDeviceIdService");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.b)) ? new com.bytedance.ads.convert.flat.j.b.a.C0328a(iBinder) : (com.bytedance.ads.convert.flat.j.b) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.b bVar) {
            return bVar.a();
        }
    }

    public n() {
        super("com.samsung.android.deviceidservice");
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.b, String> a() {
        return new a(this);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setClassName("com.samsung.android.deviceidservice", "com.samsung.android.deviceidservice.DeviceIdService");
        return intent;
    }
}
