package com.sigmob.sdk.base.views;

import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.PointF;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.util.Log;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;

/* JADX INFO: loaded from: classes3.dex */
public class al extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Paint f3292a;
    private Paint b;
    private RectF c;
    private RectF d;
    private float e;
    private float f;
    private Paint g;
    private float h;
    private PointF i;
    private Path j;
    private Paint k;
    private int l;
    private int m;
    private float n;
    private float o;
    private float p;
    private PointF q;
    private float r;

    public al(Context context) {
        super(context);
        this.e = 0.0f;
        this.f = 1.0f;
    }

    public al(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.e = 0.0f;
        this.f = 1.0f;
    }

    public al(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.e = 0.0f;
        this.f = 1.0f;
    }

    private void a() {
        Paint paint = new Paint(1);
        this.f3292a = paint;
        paint.setColor(-1);
        this.f3292a.setStyle(Paint.Style.STROKE);
        float fDipsToIntPixels = Dips.dipsToIntPixels(1.0f, getContext());
        this.f = fDipsToIntPixels;
        this.f3292a.setStrokeWidth((this.l / (100.0f * fDipsToIntPixels)) * 3.0f * fDipsToIntPixels);
        Paint paint2 = new Paint(1);
        this.b = paint2;
        paint2.setColor(Color.parseColor("#B7B7B7"));
        this.b.setStyle(Paint.Style.FILL);
        Paint paint3 = new Paint(1);
        this.g = paint3;
        paint3.setColor(-1);
        this.g.setStyle(Paint.Style.FILL);
        int iDipsToIntPixels = Dips.dipsToIntPixels(92.0f, getContext());
        int i = this.l;
        this.r = (i * 1.0f) / iDipsToIntPixels;
        this.h = i * 0.1f;
        this.c = new RectF();
        this.d = new RectF();
        float f = this.l * 0.2f;
        this.i = new PointF(getWidth() / 2.0f, f);
        this.q = new PointF(getWidth() / 2.0f, f + this.h);
        this.j = new Path();
        Paint paint4 = new Paint(1);
        this.k = paint4;
        paint4.setStyle(Paint.Style.FILL);
        this.k.setColor(-1);
        float f2 = this.l * 0.3f;
        this.n = f2;
        this.o = f2 * 0.9f;
        this.p = this.f * 2.0f;
    }

    private void a(Path path, PointF point) {
        float fTan = (float) (((double) point.x) - (((double) this.h) * Math.tan(0.7853981633974483d)));
        float f = point.y + this.h;
        float fTan2 = (float) (((double) point.x) + (((double) this.h) * Math.tan(0.7853981633974483d)));
        float f2 = point.y + this.h;
        path.moveTo(fTan, f);
        path.lineTo(point.x, point.y);
        path.lineTo(fTan2, f2);
        path.lineTo(point.x, point.y + (this.h / 2.0f));
        path.close();
    }

    private void b() {
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.sigmob.sdk.base.views.al.1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public void onAnimationUpdate(ValueAnimator valueAnimator) {
                al.this.a(((Float) valueAnimator.getAnimatedValue()).floatValue());
            }
        });
        valueAnimatorOfFloat.setRepeatCount(-1);
        valueAnimatorOfFloat.setRepeatMode(2);
        valueAnimatorOfFloat.setDuration(2000L);
        valueAnimatorOfFloat.start();
    }

    public void a(float absoluteZ) {
        if (this.k == null) {
            return;
        }
        float fMax = Math.max(0.0f, absoluteZ);
        this.e = fMax;
        float fMin = Math.min(1.0f, fMax);
        this.e = fMin;
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this, "rotationX", fMin * 40.0f, absoluteZ * 40.0f);
        objectAnimatorOfFloat.setDuration(50L);
        objectAnimatorOfFloat.start();
        this.k.setAlpha((int) (this.e * 255.0f));
        invalidate();
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        float f;
        super.onDraw(canvas);
        if (this.f3292a == null) {
            return;
        }
        this.j.reset();
        a(this.j, this.i);
        canvas.drawPath(this.j, this.k);
        this.j.reset();
        a(this.j, this.q);
        canvas.drawPath(this.j, this.k);
        int i = this.l;
        float f2 = this.m;
        float f3 = this.o;
        float f4 = (f2 - f3) / 2.0f;
        float f5 = this.n;
        float f6 = (i - f5) - (i * 0.2f);
        RectF rectF = this.c;
        float f7 = this.p;
        rectF.set(f4 + f7, f6, (f3 + f4) - f7, f5 + f6 + this.f);
        RectF rectF2 = this.c;
        float f8 = this.p;
        canvas.drawRoundRect(rectF2, f8, f8, this.f3292a);
        float f9 = this.e;
        if (f9 > 0.98f) {
            f = this.f;
        } else {
            f = this.f + ((1.0f - f9) * this.n);
        }
        Log.d("", "onDraw: " + f);
        float f10 = f + f6;
        float f11 = this.c.bottom;
        float f12 = this.f;
        if (f10 >= f11 - f12) {
            f10 = f11 - f12;
        }
        this.d.set(this.p + f4, f10, (f4 + this.o) - (f12 * 2.0f), f11);
        canvas.drawRect(this.d, this.b);
        float fMin = Math.min(this.r * Dips.dipsToIntPixels(3.0f, getContext()), this.f * 2.0f);
        float f13 = this.o;
        float f14 = f13 > 0.0f ? f13 / 5.0f : this.f * 3.0f;
        float f15 = (this.m - f14) / 2.0f;
        float f16 = this.n;
        float f17 = (f6 + f16) - (f16 / 4.0f);
        canvas.drawRect(f15, f17, f15 + f14, f17 + fMin, this.g);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        this.l = h;
        this.m = w;
        a();
    }
}
