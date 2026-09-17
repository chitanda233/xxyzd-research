package com.bytedance.ads.convert.flat.m;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;
import android.provider.Settings;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
public final class d extends b<com.bytedance.ads.convert.flat.j.a> {
    public final Context c;

    public class a implements o.b<com.bytedance.ads.convert.flat.j.a, String> {
        public a() {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.a a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.a.AbstractBinderC0326a.f1708a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.coolpad.deviceidsupport.IDeviceIdManager");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.a)) ? new com.bytedance.ads.convert.flat.j.a.AbstractBinderC0326a.C0327a(iBinder) : (com.bytedance.ads.convert.flat.j.a) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.a aVar) {
            com.bytedance.ads.convert.flat.j.a aVar2 = aVar;
            if (aVar2 == null) {
                return null;
            }
            return aVar2.a(d.this.c.getPackageName());
        }
    }

    public d(Context context) {
        super("com.coolpad.deviceidsupport");
        this.c = context;
    }

    @Override // com.bytedance.ads.convert.flat.m.b, com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        try {
            String string = Settings.Global.getString(context.getContentResolver(), "coolos.oaid");
            if (!TextUtils.isEmpty(string)) {
                com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
                aVar.f1727a = string;
                return aVar;
            }
        } catch (Throwable th) {
            String str = "coolpad getOaid error: " + th.getMessage();
        }
        return super.a(context);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.a, String> a() {
        return new a();
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setComponent(new ComponentName("com.coolpad.deviceidsupport", "com.coolpad.deviceidsupport.DeviceIdService"));
        return intent;
    }
}
