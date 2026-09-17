package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;
import com.bun.lib.MsaIdInterface;
import com.bun.miitmdid.content.StringValues;

/* JADX INFO: loaded from: classes2.dex */
public final class c extends b<com.bytedance.ads.convert.flat.j.h> {

    public class a implements o.b<com.bytedance.ads.convert.flat.j.h, String> {
        public a(c cVar) {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.h a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.h.a.f1720a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(MsaIdInterface.Stub.DESCRIPTOR);
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.h)) ? new com.bytedance.ads.convert.flat.j.h.a.C0333a(iBinder) : (com.bytedance.ads.convert.flat.j.h) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.h hVar) {
            com.bytedance.ads.convert.flat.j.h hVar2 = hVar;
            if (hVar2 == null) {
                return null;
            }
            return hVar2.a();
        }
    }

    public c() {
        super("com.mdid.msa");
    }

    @Override // com.bytedance.ads.convert.flat.m.b, com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        String packageName = context.getPackageName();
        Intent intent = new Intent();
        intent.setClassName("com.mdid.msa", "com.mdid.msa.service.MsaKlService");
        intent.setAction(StringValues.ACTION_START_MSASERVICE);
        intent.putExtra(StringValues.PARAM_BIND_PKGNAME, packageName);
        try {
            intent.putExtra("com.bun.msa.param.runinset", true);
            context.startService(intent);
        } catch (Exception e) {
            String str = "Common startMsaklServer error: " + e.getMessage();
        }
        return super.a(context);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.h, String> a() {
        return new a(this);
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setClassName("com.mdid.msa", "com.mdid.msa.service.MsaIdService");
        intent.setAction(StringValues.ACTION_BINDTO_MSASERVICE);
        intent.putExtra(StringValues.PARAM_BIND_PKGNAME, context.getPackageName());
        return intent;
    }
}
