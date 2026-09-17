package com.alipay.sdk.m.j;

/* JADX INFO: loaded from: classes.dex */
public final class c extends b {
    public final String f;

    public c(String str) {
        this.f = str;
    }

    @Override // com.alipay.sdk.m.j.b
    public void a() throws Exception {
        this.f300a = (byte) 1;
        byte[] bytes = this.f.getBytes("UTF-8");
        this.c = bytes;
        this.b = (byte) bytes.length;
    }
}
