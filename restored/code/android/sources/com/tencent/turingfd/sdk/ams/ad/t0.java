package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.os.Handler;
import android.text.TextUtils;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class t0 {
    public static boolean a(String str, String str2) {
        int iIndexOf;
        if (str2 == null || (iIndexOf = str2.indexOf(47)) == -1) {
            return false;
        }
        String strTrim = str2.substring(iIndexOf).trim();
        if (!strTrim.startsWith("/data/") || strTrim.startsWith("/data/data/" + str + "/")) {
            return false;
        }
        boolean zEndsWith = strTrim.endsWith(".so");
        return (zEndsWith || (!zEndsWith && strTrim.endsWith(".jar"))) && str2.contains(Cinstanceof.a(Cinstanceof.m));
    }

    public static int b(Context context) {
        boolean z;
        boolean z2;
        String[] strArrSplit;
        Context context2;
        PackageInfo packageInfo;
        System.currentTimeMillis();
        boolean z3 = true;
        if (context.getPackageManager() == null) {
            z = false;
        } else {
            String strA = Cinstanceof.a(Cinstanceof.l);
            try {
                if (!TextUtils.isEmpty(strA)) {
                    synchronized (Ccatch.class) {
                        context2 = Ccatch.f3917a;
                    }
                    if (context2 != null && (packageInfo = context2.getPackageManager().getPackageInfo(strA, 0)) != null && strA.equals(packageInfo.packageName)) {
                        z = true;
                    }
                }
            } catch (Throwable unused) {
            }
            z = false;
        }
        int iA = Cthrow.a(0, 0, z);
        System.currentTimeMillis();
        try {
            String str = new String(CanisMinor.a(Cinstanceof.a(Cinstanceof.n)));
            if (!TextUtils.isEmpty(str) && (strArrSplit = str.split("\\n")) != null && strArrSplit.length != 0) {
                String packageName = context.getPackageName();
                int length = strArrSplit.length;
                int i = 0;
                while (true) {
                    if (i >= length) {
                        z2 = false;
                        break;
                    }
                    if (a(packageName, strArrSplit[i])) {
                        z2 = true;
                        break;
                    }
                    i++;
                }
            } else {
                z2 = false;
                break;
            }
        } catch (Throwable unused2) {
        }
        int iA2 = Cthrow.a(iA, 1, z2);
        System.currentTimeMillis();
        int iA3 = Cthrow.a(iA2, 2, a(context));
        System.currentTimeMillis();
        try {
            ClassLoader.getSystemClassLoader().loadClass(Cinstanceof.a(Cinstanceof.C0));
        } catch (Throwable unused3) {
            z3 = false;
        }
        return Cthrow.a(iA3, 3, z3);
    }

    public static boolean a(Context context) {
        Object obj = new Object();
        AtomicReference atomicReference = new AtomicReference();
        AtomicBoolean atomicBoolean = new AtomicBoolean(false);
        atomicReference.set(Boolean.FALSE);
        Handler handler = new Handler(context.getMainLooper());
        System.currentTimeMillis();
        handler.post(new s0(atomicBoolean, atomicReference, obj));
        synchronized (obj) {
            try {
                obj.wait(100L);
            } catch (InterruptedException unused) {
            }
        }
        atomicBoolean.set(true);
        return ((Boolean) atomicReference.get()).booleanValue();
    }
}
