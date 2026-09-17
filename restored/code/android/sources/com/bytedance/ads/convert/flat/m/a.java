package com.bytedance.ads.convert.flat.m;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;
import com.asus.msa.SupplementaryDID.IDidAidlInterface;

/* JADX INFO: loaded from: classes2.dex */
public final class a extends b<com.bytedance.ads.convert.flat.j.d> {

    /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.m.a$a, reason: collision with other inner class name */
    public class C0335a implements o.b<com.bytedance.ads.convert.flat.j.d, String> {
        public C0335a(a aVar) {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.d a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.d.a.f1714a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(IDidAidlInterface.Stub.DESCRIPTOR);
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.d)) ? new com.bytedance.ads.convert.flat.j.d.a.C0330a(iBinder) : (com.bytedance.ads.convert.flat.j.d) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.d dVar) {
            com.bytedance.ads.convert.flat.j.d dVar2 = dVar;
            if (dVar2 == null) {
                return null;
            }
            return dVar2.a();
        }
    }

    public a() {
        super("com.asus.msa.SupplementaryDID");
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.d, String> a() {
        return new C0335a(this);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setAction("com.asus.msa.action.ACCESS_DID");
        intent.setComponent(new ComponentName("com.asus.msa.SupplementaryDID", "com.asus.msa.SupplementaryDID.SupplementaryDIDService"));
        return intent;
    }
}
