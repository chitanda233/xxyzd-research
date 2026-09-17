package com.chuanglan.shanyan_sdk;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageInfo;
import android.content.pm.Signature;
import android.os.Build;
import android.text.TextUtils;
import java.security.MessageDigest;
import java.util.concurrent.CountDownLatch;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
public abstract class X implements c0 {
    private static String h = null;
    private static boolean i = false;
    private static boolean j = false;
    private static final CountDownLatch k = new CountDownLatch(1);

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f1960a;
    private String b;
    private String c;
    private String d;
    private Z e;
    private String f;
    private String g;

    public X(String str, String str2, String str3, String str4) {
        this.f1960a = str;
        this.b = str2;
        this.c = str3;
        this.d = str4;
    }

    public String a() {
        return "OUID";
    }

    public int b() {
        return 1;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public String c(Context context) {
        Z z;
        if (!TextUtils.isEmpty(h) || (z = this.e) == null || z.a() == null) {
            return h;
        }
        try {
            String strA = this.e.a().a(d(context), e(context), a(), b());
            h = strA;
            if (!TextUtils.isEmpty(strA)) {
                context.unbindService(this.e);
            }
        } catch (Throwable unused) {
        }
        return h;
    }

    public String d(Context context) {
        if (TextUtils.isEmpty(this.f)) {
            this.f = C0616v.g().c(context);
        }
        return this.f;
    }

    public String e(Context context) {
        if (TextUtils.isEmpty(this.g)) {
            try {
                this.f = d(context);
                Signature[] signatureArr = context.getPackageManager().getPackageInfo(this.f, 64).signatures;
                if (signatureArr != null && signatureArr.length > 0) {
                    byte[] bArrDigest = MessageDigest.getInstance("SHA1").digest(signatureArr[0].toByteArray());
                    StringBuilder sb = new StringBuilder();
                    for (byte b : bArrDigest) {
                        sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
                    }
                    this.g = sb.toString();
                }
            } catch (Throwable unused) {
            }
        }
        return this.g;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean a(Context context) {
        if (j) {
            return i;
        }
        if (context == null || TextUtils.isEmpty(this.f1960a)) {
            i = false;
        } else {
            try {
                PackageInfo packageInfo = context.getPackageManager().getPackageInfo(this.f1960a, 0);
                if (Build.VERSION.SDK_INT >= 28) {
                    return packageInfo != null && packageInfo.getLongVersionCode() >= 1;
                }
                i = packageInfo != null && packageInfo.versionCode >= 1;
            } catch (Throwable unused) {
                return false;
            }
        }
        j = true;
        return i;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean b(Context context) {
        if (context == null || TextUtils.isEmpty(this.f1960a)) {
            return false;
        }
        if (this.e == null) {
            this.e = new Z(this.d, k);
        }
        Intent intent = new Intent();
        if (TextUtils.isEmpty(this.b)) {
            intent.setPackage(this.f1960a);
        } else {
            intent.setComponent(new ComponentName(this.f1960a, this.b));
        }
        if (!TextUtils.isEmpty(this.c)) {
            intent.setAction(this.c);
        }
        return this.e.a(context, intent);
    }
}
