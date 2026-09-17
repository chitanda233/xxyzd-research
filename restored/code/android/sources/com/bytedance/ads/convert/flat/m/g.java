package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.IInterface;

/* JADX INFO: loaded from: classes2.dex */
public class g extends b<com.bytedance.ads.convert.flat.j.f> {
    public final com.bytedance.ads.convert.flat.l.a c;
    public final com.bytedance.ads.convert.flat.l.b d;

    public class a implements o.b<com.bytedance.ads.convert.flat.j.f, String> {
        public a() {
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.f a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.f.a.f1716a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.hihonor.cloudservice.oaid.IOAIDService");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.f)) ? new com.bytedance.ads.convert.flat.j.f.a.C0331a(iBinder) : (com.bytedance.ads.convert.flat.j.f) iInterfaceQueryLocalInterface;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.f fVar) {
            com.bytedance.ads.convert.flat.j.f fVar2 = fVar;
            if (fVar2 == null) {
                return null;
            }
            fVar2.b(g.this.c);
            fVar2.a(g.this.d);
            return "";
        }
    }

    public g() {
        super("com.hihonor.id");
        this.c = new com.bytedance.ads.convert.flat.l.a();
        this.d = new com.bytedance.ads.convert.flat.l.b();
    }

    @Override // com.bytedance.ads.convert.flat.m.b, com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
        try {
            Intent intent = new Intent();
            intent.setAction("com.hihonor.id.HnOaIdService");
            intent.setPackage("com.hihonor.id");
            new o(context, intent, new a()).a();
            aVar.f1727a = this.c.f1730a;
            aVar.b = this.d.f1731a;
            String str = "honor# getOaid " + aVar.f1727a;
            return aVar;
        } catch (Exception e) {
            String str2 = "honor# getOaid error: " + e.getMessage();
            return aVar;
        }
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public o.b<com.bytedance.ads.convert.flat.j.f, String> a() {
        return new a();
    }

    @Override // com.bytedance.ads.convert.flat.m.b
    public Intent c(Context context) {
        Intent intent = new Intent();
        intent.setAction("com.hihonor.id.HnOaIdService");
        intent.setPackage("com.hihonor.id");
        return intent;
    }
}
