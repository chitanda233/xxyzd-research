package com.onevcat.uniwebview;

import android.view.animation.Animation;

/* JADX INFO: loaded from: classes3.dex */
public final class K implements Animation.AnimationListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ N f2841a;
    public final /* synthetic */ int b;
    public final /* synthetic */ int c;
    public final /* synthetic */ int d;
    public final /* synthetic */ int e;
    public final /* synthetic */ String f;

    public K(N n, int i, int i2, int i3, int i4, String str) {
        this.f2841a = n;
        this.b = i;
        this.c = i2;
        this.d = i3;
        this.e = i4;
        this.f = str;
    }

    @Override // android.view.animation.Animation.AnimationListener
    public final void onAnimationEnd(Animation animation) {
        N n = this.f2841a;
        n.j = null;
        n.a(this.b, this.c, this.d, this.e);
        N n2 = this.f2841a;
        n2.c.a(n2.p.getName(), d2.AnimateToFinished, this.f);
    }

    @Override // android.view.animation.Animation.AnimationListener
    public final void onAnimationRepeat(Animation animation) {
    }

    @Override // android.view.animation.Animation.AnimationListener
    public final void onAnimationStart(Animation animation) {
    }
}
