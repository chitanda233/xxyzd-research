package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.Intent;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
public abstract class b<SERVICE> implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f1732a;
    public final com.bytedance.ads.convert.flat.n.c<Boolean> b = new a();

    public class a extends com.bytedance.ads.convert.flat.n.c<Boolean> {
        public a() {
        }

        @Override // com.bytedance.ads.convert.flat.n.c
        public Boolean a(Object[] objArr) {
            boolean z = false;
            Context context = (Context) objArr[0];
            try {
                if (context.getPackageManager().getPackageInfo(b.this.f1732a, 128) != null) {
                    z = true;
                }
            } catch (Throwable unused) {
            }
            return Boolean.valueOf(z);
        }
    }

    public b(String str) {
        this.f1732a = str;
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        String str = (String) new o(context, c(context), a()).a();
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
        aVar.f1727a = str;
        return aVar;
    }

    public abstract o.b<SERVICE, String> a();

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        if (context == null) {
            return false;
        }
        return this.b.b(context).booleanValue();
    }

    public abstract Intent c(Context context);
}
