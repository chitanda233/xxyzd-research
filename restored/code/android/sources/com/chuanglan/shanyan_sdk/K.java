package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
public class K implements c0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Class f1944a = null;
    private String b;

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean a(Context context) {
        try {
            this.f1944a = Class.forName("com.android.id.impl.IdProviderImpl");
            return true;
        } catch (Throwable unused) {
            return false;
        }
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean b(Context context) {
        return true;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public String c(Context context) {
        if (TextUtils.isEmpty(this.b)) {
            try {
                this.b = String.valueOf(this.f1944a.getMethod("getOAID", Context.class).invoke(this.f1944a.newInstance(), context));
            } catch (Throwable unused) {
                this.b = null;
            }
        }
        return this.b;
    }
}
