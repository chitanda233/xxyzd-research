package com.chuanglan.shanyan_sdk;

import java.io.UnsupportedEncodingException;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.e, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0599e extends AbstractC0607m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f1967a;

    public AbstractC0599e() {
        this("utf-8");
    }

    protected abstract void a(String str);

    @Override // com.chuanglan.shanyan_sdk.AbstractC0607m
    public void a(byte[] bArr) {
        try {
            a(new String(bArr, this.f1967a));
        } catch (UnsupportedEncodingException e) {
            a(e.toString(), e.getClass().getSimpleName());
        }
    }

    private AbstractC0599e(String str) {
        this.f1967a = str;
    }
}
