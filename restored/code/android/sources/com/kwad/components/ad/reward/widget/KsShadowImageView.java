package com.kwad.components.ad.reward.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.BlurMaskFilter;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Rect;
import android.util.AttributeSet;
import android.widget.ImageView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class KsShadowImageView extends ImageView {
    private Paint Fh;
    private BlurMaskFilter Fi;
    private int Fj;
    private boolean Fk;
    private boolean Fl;
    private boolean Fm;
    private boolean Fn;
    private Rect Fo;
    private int Fp;

    public KsShadowImageView(Context context) {
        super(context);
        this.Fn = true;
        a(context, null, 0);
    }

    public KsShadowImageView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.Fn = true;
        a(context, attributeSet, 0);
    }

    public KsShadowImageView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.Fn = true;
        a(context, attributeSet, i);
    }

    public KsShadowImageView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.Fn = true;
        a(context, attributeSet, i);
    }

    private void a(Context context, AttributeSet attributeSet, int i) {
        this.Fh = new Paint();
        this.Fi = new BlurMaskFilter(50.0f, BlurMaskFilter.Blur.OUTER);
        this.Fo = new Rect();
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KsShadowImageView, i, 0);
        this.Fj = typedArrayObtainStyledAttributes.getDimensionPixelSize(R.styleable.ksad_KsShadowImageView_ksad_shadowSize, 20);
        this.Fp = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_KsShadowImageView_ksad_shadowColor, Color.parseColor("#33000000"));
        this.Fk = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KsShadowImageView_ksad_enableLeftShadow, true);
        this.Fl = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KsShadowImageView_ksad_enableRightShadow, true);
        this.Fm = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KsShadowImageView_ksad_enableTopShadow, true);
        this.Fn = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_KsShadowImageView_ksad_enableBottomShadow, true);
        typedArrayObtainStyledAttributes.recycle();
    }

    @Override // android.widget.ImageView, android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        this.Fh.setMaskFilter(this.Fi);
        this.Fh.setColor(this.Fp);
        this.Fh.setStyle(Paint.Style.FILL);
        int measuredWidth = getMeasuredWidth();
        int measuredHeight = getMeasuredHeight();
        this.Fo.left = this.Fk ? this.Fj : 0;
        this.Fo.top = this.Fm ? this.Fj : 0;
        this.Fo.right = measuredWidth - (this.Fl ? this.Fj : 0);
        this.Fo.bottom = measuredHeight - (this.Fn ? this.Fj : 0);
        canvas.drawRect(this.Fo, this.Fh);
    }
}
