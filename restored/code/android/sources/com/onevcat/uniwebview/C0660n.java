package com.onevcat.uniwebview;

import android.view.View;
import android.view.animation.Animation;
import android.view.animation.Transformation;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.n, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0660n extends Animation {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final View f2914a;
    public final int b;
    public final int c;
    public final int d;
    public final int e;
    public final int f;
    public final int g;

    public C0660n(X view, int i, int i2, int i3, int i4) {
        Intrinsics.checkNotNullParameter(view, "view");
        this.f2914a = view;
        this.b = i;
        this.c = i3;
        this.d = i2 - i;
        this.e = i4 - i3;
        this.f = view.getWidth();
        this.g = view.getHeight();
    }

    @Override // android.view.animation.Animation
    public final void applyTransformation(float f, Transformation transformation) {
        if (f != 1.0f || isFillEnabled()) {
            if (this.e != 0) {
                this.f2914a.getLayoutParams().height = (int) ((this.e * f) + this.c);
            }
            if (this.d != 0) {
                this.f2914a.getLayoutParams().width = (int) ((this.d * f) + this.b);
            }
        } else {
            this.f2914a.getLayoutParams().height = this.g;
            this.f2914a.getLayoutParams().width = this.f;
        }
        this.f2914a.requestLayout();
    }
}
