package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.provider.Settings;
import android.text.TextUtils;
import android.util.Pair;
import com.huawei.hms.ads.identifier.AdvertisingIdClient;

/* JADX INFO: loaded from: classes2.dex */
public final class e implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final com.bytedance.ads.convert.flat.n.c<Boolean> f1734a = new a();

    public static class a extends com.bytedance.ads.convert.flat.n.c<Boolean> {
        @Override // com.bytedance.ads.convert.flat.n.c
        public Boolean a(Object[] objArr) {
            boolean z = false;
            try {
                if (((Context) objArr[0]).getPackageManager().getPackageInfo("com.huawei.hwid", 128) != null) {
                    z = true;
                }
            } catch (Throwable unused) {
            }
            return Boolean.valueOf(z);
        }
    }

    public static class b extends com.bytedance.ads.convert.flat.k.c.a {
        public long c = 0;
    }

    public static boolean c(Context context) {
        if (context == null) {
            return false;
        }
        return f1734a.b(context).booleanValue();
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        b bVar = new b();
        try {
            String string = Settings.Global.getString(context.getContentResolver(), AdvertisingIdClient.SETTINGS_AD_ID);
            String string2 = Settings.Global.getString(context.getContentResolver(), AdvertisingIdClient.SETTINGS_TRACK_LIMIT);
            if (TextUtils.isEmpty(string)) {
                Pair pair = (Pair) new o(context, new Intent("com.uodis.opendevice.OPENIDS_SERVICE").setPackage("com.huawei.hwid"), new f()).a();
                if (pair != null) {
                    bVar.f1727a = (String) pair.first;
                    bVar.b = ((Boolean) pair.second).booleanValue();
                    int i = 0;
                    try {
                        PackageInfo packageInfo = context.getPackageManager().getPackageInfo("com.huawei.hwid", 0);
                        if (packageInfo != null) {
                            i = packageInfo.versionCode;
                        }
                    } catch (PackageManager.NameNotFoundException e) {
                        String str = "hw getHwIdVersionCode error " + e.getMessage();
                    }
                    bVar.c = i;
                }
            } else {
                bVar.f1727a = string;
                bVar.b = Boolean.parseBoolean(string2);
                bVar.c = 202003021704L;
            }
        } catch (Throwable th) {
            String str2 = "hw get oaid error " + th.getMessage();
        }
        return bVar;
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        return c(context);
    }
}
