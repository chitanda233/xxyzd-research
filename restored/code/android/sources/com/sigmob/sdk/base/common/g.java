package com.sigmob.sdk.base.common;

import android.os.Parcel;

/* JADX INFO: loaded from: classes3.dex */
public class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3169a;
    private int b;

    public g(int width, int height) {
        this.f3169a = width;
        this.b = height;
    }

    protected g(Parcel in) {
        this.f3169a = in.readInt();
        this.b = in.readInt();
    }

    public int a() {
        return this.f3169a;
    }

    public void a(int width) {
        this.f3169a = width;
    }

    public int b() {
        return this.b;
    }

    public void b(int height) {
        this.b = height;
    }
}
