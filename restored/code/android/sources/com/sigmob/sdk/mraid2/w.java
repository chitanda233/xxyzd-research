package com.sigmob.sdk.mraid2;

import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public class w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final View f3555a;

    public w(View target) {
        this.f3555a = target;
    }

    public int a() {
        return this.f3555a.getLayoutParams().height;
    }

    public void a(int height) {
        this.f3555a.getLayoutParams().height = height;
        this.f3555a.requestLayout();
    }

    public int b() {
        return this.f3555a.getLayoutParams().width;
    }

    public void b(int width) {
        this.f3555a.getLayoutParams().width = width;
        this.f3555a.requestLayout();
    }
}
