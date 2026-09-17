package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes2.dex */
public final class p implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static Object f1742a;
    public static Class<?> b;
    public static Method c;

    static {
        try {
            Class<?> cls = Class.forName("com.android.id.impl.IdProviderImpl");
            b = cls;
            f1742a = cls.newInstance();
            c = b.getMethod("getOAID", Context.class);
        } catch (Exception e) {
            String str = "xiaomi static reflect exception: " + e.getMessage();
        }
    }

    /* JADX WARN: Code duplicated, block: B:11:0x001d  */
    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        String str;
        try {
            com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
            Method method = c;
            Object obj = f1742a;
            if (obj == null || method == null) {
                str = null;
            } else {
                try {
                    Object objInvoke = method.invoke(obj, context);
                    if (objInvoke != null) {
                        str = (String) objInvoke;
                    } else {
                        str = null;
                    }
                } catch (Exception unused) {
                }
            }
            aVar.f1727a = str;
            return aVar;
        } catch (Exception e) {
            String str2 = "Xiaomi get oaid error: " + e.getMessage();
            return null;
        }
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        return (b == null || f1742a == null || c == null) ? false : true;
    }
}
