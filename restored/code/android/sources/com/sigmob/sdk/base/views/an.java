package com.sigmob.sdk.base.views;

import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.PointF;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.util.Log;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;

/* JADX INFO: loaded from: classes3.dex */
public class an extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Paint f3295a;
    private Paint b;
    private RectF c;
    private RectF d;
    private float e;
    private Float f;
    private float g;
    private Paint h;
    private float i;
    private PointF j;
    private Path k;
    private Paint l;
    private int m;
    private int n;
    private float o;
    private float p;
    private PointF q;
    private float r;

    public an(Context context) {
        super(context);
        this.e = 0.0f;
        this.g = 3.0f;
        a(context);
    }

    public an(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.e = 0.0f;
        this.g = 3.0f;
        a(context);
    }

    public an(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.e = 0.0f;
        this.g = 3.0f;
        a(context);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        if (this.f3295a == null) {
            Paint paint = new Paint(1);
            this.f3295a = paint;
            paint.setColor(-1);
            this.f3295a.setStyle(Paint.Style.STROKE);
            float fDipsToIntPixels = Dips.dipsToIntPixels(this.g, getContext());
            this.g = fDipsToIntPixels;
            this.f3295a.setStrokeWidth(fDipsToIntPixels);
            Paint paint2 = new Paint(1);
            this.b = paint2;
            paint2.setColor(-3355444);
            this.b.setStyle(Paint.Style.FILL);
            Paint paint3 = new Paint(1);
            this.h = paint3;
            paint3.setColor(-1);
            this.h.setStyle(Paint.Style.FILL);
            float fDipsToIntPixels2 = (this.m * 1.0f) / Dips.dipsToIntPixels(92.0f, getContext());
            this.r = fDipsToIntPixels2;
            this.i = fDipsToIntPixels2 * Dips.dipsToIntPixels(11.0f, getContext());
            this.c = new RectF();
            this.d = new RectF();
            this.j = new PointF(getWidth() / 2.0f, 0.0f);
            this.q = new PointF(getWidth() / 2.0f, this.i);
            this.k = new Path();
            Paint paint4 = new Paint(1);
            this.l = paint4;
            paint4.setStyle(Paint.Style.FILL);
            this.l.setColor(-1);
            this.o = this.m - (this.i * 3.0f);
            this.p = this.g / 2.0f;
        }
    }

    private void a(Context context) {
        com.sigmob.sdk.base.utils.w.a(this, new Runnable() { // from class: com.sigmob.sdk.base.views.an$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a();
            }
        });
    }

    private void a(Path path, PointF point) {
        float fTan = (float) (((double) point.x) - (((double) this.i) * Math.tan(0.7853981633974483d)));
        float f = point.y + this.i;
        float fTan2 = (float) (((double) point.x) + (((double) this.i) * Math.tan(0.7853981633974483d)));
        float f2 = point.y + this.i;
        path.moveTo(fTan, f);
        path.lineTo(point.x, point.y);
        path.lineTo(fTan2, f2);
        path.lineTo(point.x, point.y + (this.i / 2.0f));
        path.close();
    }

    private void b() {
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.sigmob.sdk.base.views.an.1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public void onAnimationUpdate(ValueAnimator valueAnimator) {
                an.this.a(((Float) valueAnimator.getAnimatedValue()).floatValue());
            }
        });
        valueAnimatorOfFloat.setRepeatCount(-1);
        valueAnimatorOfFloat.setRepeatMode(2);
        valueAnimatorOfFloat.setDuration(2000L);
        valueAnimatorOfFloat.start();
    }

    public void a(float absoluteZ) {
        if (this.l == null) {
            return;
        }
        float fMax = Math.max(0.2f, absoluteZ);
        this.e = fMax;
        float fMin = Math.min(1.0f, fMax);
        this.e = fMin;
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this, "rotationX", fMin * 40.0f, absoluteZ * 40.0f);
        objectAnimatorOfFloat.setDuration(50L);
        objectAnimatorOfFloat.start();
        this.l.setAlpha((int) (this.e * 255.0f));
        invalidate();
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        float f;
        super.onDraw(canvas);
        if (this.l == null) {
            return;
        }
        this.k.reset();
        a(this.k, this.j);
        canvas.drawPath(this.k, this.l);
        this.k.reset();
        a(this.k, this.q);
        canvas.drawPath(this.k, this.l);
        float f2 = this.g;
        float f3 = this.m;
        float f4 = this.o;
        float f5 = this.p;
        float f6 = (f3 - f4) - f5;
        this.c.set(f2, f6, this.n - f2, (f4 + f6) - (f5 * 2.0f));
        RectF rectF = this.c;
        float f7 = this.p;
        canvas.drawRoundRect(rectF, f7, f7, this.f3295a);
        float f8 = this.e;
        if (f8 > 0.98f) {
            f = this.g - this.p;
        } else {
            f = this.g + ((1.0f - f8) * this.o);
        }
        Log.d("", "onDraw: " + f);
        float f9 = f + f6;
        float f10 = this.o;
        float f11 = this.g;
        float f12 = f6 + f10 + f11;
        if (this.e > 0.2f) {
            f12 = (f10 + f6) - f11;
        }
        this.d.set(f2 + this.p, f9, this.n - f11, f12);
        canvas.drawRect(this.d, this.b);
        float fMin = Math.min(this.r * Dips.dipsToIntPixels(3.0f, getContext()), this.g);
        int i = this.n;
        float f13 = i > 0 ? i / 5.0f : this.g;
        float f14 = (i - f13) / 2.0f;
        float f15 = ((f6 + this.o) - fMin) - this.g;
        canvas.drawRect(f14, f15, f14 + f13, f15 + fMin, this.h);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        this.m = h;
        this.n = w;
        a();
    }
}
