package com.cmic.gen.sdk.e;

import android.content.Context;

/* JADX INFO: compiled from: XiaoMiOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class o extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2115a;

    o(Context context) {
        this.f2115a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        try {
            Class<?> cls = Class.forName("com.android.id.impl.IdProviderImpl");
            return (String) cls.getMethod("getOAID", Context.class).invoke(cls.newInstance(), this.f2115a);
        } catch (Exception unused) {
            return "";
        }
    }
}
