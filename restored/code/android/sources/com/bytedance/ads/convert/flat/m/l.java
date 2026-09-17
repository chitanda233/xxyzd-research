package com.bytedance.ads.convert.flat.m;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageInfo;
import android.content.pm.Signature;
import android.os.Build;
import android.os.IBinder;
import android.os.IInterface;
import android.text.TextUtils;
import java.security.MessageDigest;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
public final class l implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final com.bytedance.ads.convert.flat.k.c f1738a;
    public com.bytedance.ads.convert.flat.n.c<Boolean> b = new a(this);

    public class a extends com.bytedance.ads.convert.flat.n.c<Boolean> {
        public a(l lVar) {
        }

        @Override // com.bytedance.ads.convert.flat.n.c
        public Boolean a(Object[] objArr) {
            try {
                PackageInfo packageInfo = ((Context) objArr[0]).getPackageManager().getPackageInfo("com.heytap.openid", 0);
                if (packageInfo == null) {
                    return Boolean.FALSE;
                }
                return Boolean.valueOf((Build.VERSION.SDK_INT >= 28 ? packageInfo.getLongVersionCode() : (long) packageInfo.versionCode) >= 1);
            } catch (Exception unused) {
                return Boolean.FALSE;
            }
        }
    }

    public class b implements o.b<com.bytedance.ads.convert.flat.j.g, String> {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final /* synthetic */ Context f1739a;

        public b(Context context) {
            this.f1739a = context;
        }

        @Override // com.bytedance.ads.convert.flat.m.o.b
        public com.bytedance.ads.convert.flat.j.g a(IBinder iBinder) {
            int i = com.bytedance.ads.convert.flat.j.g.a.f1718a;
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.heytap.openid.IOpenID");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof com.bytedance.ads.convert.flat.j.g)) ? new com.bytedance.ads.convert.flat.j.g.a.C0332a(iBinder) : (com.bytedance.ads.convert.flat.j.g) iInterfaceQueryLocalInterface;
        }

        /* JADX WARN: Code duplicated, block: B:26:0x0065  */
        @Override // com.bytedance.ads.convert.flat.m.o.b
        public String a(com.bytedance.ads.convert.flat.j.g gVar) {
            Signature[] signatureArr;
            String string;
            com.bytedance.ads.convert.flat.j.g gVar2 = gVar;
            if (gVar2 == null) {
                return null;
            }
            l lVar = l.this;
            Context context = this.f1739a;
            lVar.getClass();
            try {
                PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 64);
                signatureArr = packageInfo != null ? packageInfo.signatures : null;
            } catch (Exception e) {
                e.printStackTrace();
            }
            if (signatureArr == null || signatureArr.length <= 0) {
                string = null;
            } else {
                byte[] byteArray = signatureArr[0].toByteArray();
                try {
                    MessageDigest messageDigest = MessageDigest.getInstance("SHA1");
                    if (messageDigest != null) {
                        byte[] bArrDigest = messageDigest.digest(byteArray);
                        StringBuilder sb = new StringBuilder();
                        for (byte b : bArrDigest) {
                            sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
                        }
                        string = sb.toString();
                    } else {
                        string = null;
                    }
                } catch (Exception e2) {
                    e2.printStackTrace();
                }
            }
            if (TextUtils.isEmpty(string)) {
                return null;
            }
            return gVar2.a(this.f1739a.getPackageName(), string, "OUID");
        }
    }

    public l(com.bytedance.ads.convert.flat.k.c cVar) {
        this.f1738a = cVar;
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        if (this.f1738a != null && !this.b.b(new Object[0]).booleanValue()) {
            return this.f1738a.a(context);
        }
        Intent intent = new Intent();
        intent.setComponent(new ComponentName("com.heytap.openid", "com.heytap.openid.IdentifyService"));
        intent.setAction("action.com.heytap.openid.OPEN_ID_SERVICE");
        String str = (String) new o(context, intent, new b(context)).a();
        com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
        aVar.f1727a = str;
        return aVar;
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        if (context == null) {
            return false;
        }
        Boolean boolB = this.b.b(context);
        return (this.f1738a == null || boolB.booleanValue()) ? boolB.booleanValue() : this.f1738a.b(context);
    }
}
