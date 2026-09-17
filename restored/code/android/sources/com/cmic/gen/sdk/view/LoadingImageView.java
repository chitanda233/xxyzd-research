package com.cmic.gen.sdk.view;

import android.content.Context;
import android.util.AttributeSet;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.view.animation.LinearInterpolator;
import android.widget.ImageView;

/* JADX INFO: loaded from: classes2.dex */
public class LoadingImageView extends ImageView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Animation f2157a;
    private LinearInterpolator b;

    public LoadingImageView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.f2157a = null;
        this.b = null;
        a();
    }

    public LoadingImageView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.f2157a = null;
        this.b = null;
        a();
    }

    public LoadingImageView(Context context) {
        super(context);
        this.f2157a = null;
        this.b = null;
        a();
    }

    protected void a() {
        this.f2157a = AnimationUtils.loadAnimation(getContext(), c.c(getContext(), "umcsdk_anim_loading"));
        LinearInterpolator linearInterpolator = new LinearInterpolator();
        this.b = linearInterpolator;
        this.f2157a.setInterpolator(linearInterpolator);
    }
}
