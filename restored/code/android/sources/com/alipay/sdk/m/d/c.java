package com.alipay.sdk.m.d;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
public class c implements com.alipay.sdk.m.c.b {
    public static final int d = 1;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.alipay.sdk.m.w0.b f276a;
    public boolean b = false;
    public boolean c = false;

    @Override // com.alipay.sdk.m.c.b
    public String a(Context context) {
        if (context == null) {
            return null;
        }
        if (!this.b) {
            com.alipay.sdk.m.w0.b bVar = new com.alipay.sdk.m.w0.b();
            this.f276a = bVar;
            this.c = bVar.a(context, (com.alipay.sdk.m.w0.b.InterfaceC0055b<String>) null) == 1;
            this.b = true;
        }
        com.alipay.sdk.m.e.a.b("getOAID", "isSupported", Boolean.valueOf(this.c));
        if (this.c && this.f276a.e()) {
            return this.f276a.b();
        }
        return null;
    }
}
