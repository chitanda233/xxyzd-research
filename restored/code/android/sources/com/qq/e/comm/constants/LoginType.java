package com.qq.e.comm.constants;

/* JADX INFO: loaded from: classes3.dex */
public enum LoginType {
    Unknow(0),
    WeiXin(1),
    QQ(2);


    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f2989a;

    LoginType(int i) {
        this.f2989a = i;
        ordinal();
    }

    public int getValue() {
        return this.f2989a;
    }
}
