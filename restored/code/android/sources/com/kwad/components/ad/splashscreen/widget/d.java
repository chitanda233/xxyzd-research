package com.kwad.components.ad.splashscreen.widget;

import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.PorterDuff;
import android.graphics.PorterDuffXfermode;
import android.graphics.Rect;
import android.graphics.RectF;
import android.graphics.drawable.AnimationDrawable;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends AnimationDrawable {
    private int MA;
    private Bitmap Mc;
    private Bitmap Md;
    private Bitmap Me;
    private Bitmap Mf;
    private Bitmap Mg;
    private Bitmap Mh;
    private int Mi;
    private RectF Mj;
    private Paint Mk;
    private Paint Ml;
    private PorterDuffXfermode Mm;
    private final int Mn;
    private final int Mo;
    private float Mp;
    private float Mq;
    private RectF Mr;
    private Paint Ms;
    private int Mt;
    private int Mu;
    private ValueAnimator Mv;
    private final float Mw = 6.0f;
    private final float Mx = 11.0f;
    private float My;
    private float Mz;
    private Context mContext;

    @Override // android.graphics.drawable.DrawableContainer, android.graphics.drawable.Drawable
    public final int getOpacity() {
        return -2;
    }

    public d(Context context, int i) {
        this.mContext = context;
        this.Mn = com.kwad.sdk.c.a.a.a(context, 51.0f);
        this.Mo = com.kwad.sdk.c.a.a.a(context, 61.0f);
        this.MA = i;
        init();
    }

    private void init() {
        this.Mc = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_hand);
        this.Md = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_hand_lt);
        this.Me = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_hand_lb);
        this.Mf = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_hand_rt);
        this.Mg = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_hand_rb);
        Bitmap bitmapDecodeResource = BitmapFactory.decodeResource(this.mContext.getResources(), R.drawable.ksad_splash_side_bg);
        int i = this.MA;
        if (i == 0) {
            this.Mh = bitmapDecodeResource;
        } else if (i == 1) {
            Matrix matrix = new Matrix();
            matrix.postRotate(270.0f);
            this.Mh = Bitmap.createBitmap(bitmapDecodeResource, 0, 0, bitmapDecodeResource.getWidth(), bitmapDecodeResource.getHeight(), matrix, true);
        } else if (i == 2) {
            Matrix matrix2 = new Matrix();
            matrix2.postRotate(90.0f);
            this.Mh = Bitmap.createBitmap(bitmapDecodeResource, 0, 0, bitmapDecodeResource.getWidth(), bitmapDecodeResource.getHeight(), matrix2, true);
        }
        this.Mi = com.kwad.sdk.c.a.a.a(this.mContext, 10.0f);
        this.Ms = new Paint(1);
        int i2 = this.MA;
        if (i2 == 0) {
            this.Mu = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgh);
            int dimension = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgw);
            this.Mt = dimension;
            this.Mp = (-this.Mo) * 0.22f;
            this.Mq = dimension * 0.08f;
        } else if (i2 == 1) {
            this.Mu = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgw);
            this.Mt = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgh);
            this.Mp = this.Mu * 0.09f;
            this.Mq = (-this.Mn) * 0.2f;
        } else if (i2 == 2) {
            this.Mu = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgw);
            this.Mt = (int) this.mContext.getResources().getDimension(R.dimen.ksad_splash_hand_bgh);
            this.Mp = this.Mu * 0.09f;
            this.Mq = (-this.Mn) * 0.5f;
        }
        this.Mr = new RectF(0.0f, 0.0f, this.Mt, this.Mu);
        this.Mk = new Paint(3);
        Paint paint = new Paint(3);
        this.Ml = paint;
        paint.setDither(true);
        this.Mj = new RectF(this.Mr.right - this.Mn, 0.0f, this.Mr.right, this.Mo);
        this.Mm = new PorterDuffXfermode(PorterDuff.Mode.DST_OUT);
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 6.0f, 11.0f);
        this.Mv = valueAnimatorOfFloat;
        valueAnimatorOfFloat.setDuration(1100L);
        this.Mv.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.splashscreen.widget.d.1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                d.this.My = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                d dVar = d.this;
                dVar.e(dVar.My);
                d.this.invalidateSelf();
            }
        });
        this.Mv.setRepeatCount(-1);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(float f) {
        if (f <= 6.0f) {
            float f2 = f / 6.0f;
            int i = this.MA;
            if (i == 0) {
                this.Mr.top = this.Mu * (1.0f - f2);
                this.Mj.offsetTo(this.Mr.left + this.Mq, this.Mr.top + this.Mp);
                this.Mz = (f2 * 30.0f) + 290.0f;
                return;
            }
            if (i == 1) {
                float f3 = 1.0f - f2;
                this.Mr.left = this.Mt * f3;
                this.Mj.offsetTo(this.Mr.left + this.Mq, this.Mr.top + this.Mp);
                this.Mz = f3 * 30.0f;
                return;
            }
            if (i != 2) {
                return;
            }
            this.Mr.right = this.Mt * f2;
            this.Mj.offsetTo(this.Mr.right + this.Mq, this.Mr.top + this.Mp);
            this.Mz = (f2 * 30.0f) + 330.0f;
        }
    }

    @Override // android.graphics.drawable.DrawableContainer, android.graphics.drawable.Drawable
    public final int getIntrinsicWidth() {
        return this.Mt + this.Mn;
    }

    @Override // android.graphics.drawable.DrawableContainer, android.graphics.drawable.Drawable
    public final int getIntrinsicHeight() {
        return this.Mu + this.Mo + this.Mi;
    }

    @Override // android.graphics.drawable.DrawableContainer, android.graphics.drawable.Drawable
    public final void draw(Canvas canvas) {
        if (this.Mr == null) {
            return;
        }
        canvas.save();
        canvas.translate((getIntrinsicWidth() - this.Mt) / 2, (getIntrinsicHeight() - this.Mu) / 2);
        float f = this.My;
        if (f <= 6.0f) {
            this.Ms.setAlpha((int) ((f * 255.0f) / 6.0f));
            this.Ml.setAlpha(255);
        } else {
            int i = (int) ((1.0f - ((f - 6.0f) / 5.0f)) * 255.0f);
            this.Ms.setAlpha(i);
            this.Ml.setAlpha(i);
        }
        int iSave = canvas.save();
        int iSaveLayer = canvas.saveLayer(this.Mr, this.Ms, 31);
        try {
            canvas.drawBitmap(this.Mh, (Rect) null, this.Mr, this.Ms);
        } catch (Throwable unused) {
        }
        canvas.rotate(this.Mz, this.Mj.centerX(), this.Mj.centerY());
        this.Mk.setXfermode(this.Mm);
        int i2 = this.MA;
        if (i2 == 0) {
            canvas.drawBitmap(this.Mf, (Rect) null, this.Mj, this.Mk);
            canvas.drawBitmap(this.Mg, (Rect) null, this.Mj, this.Mk);
        } else if (i2 == 1) {
            canvas.drawBitmap(this.Md, (Rect) null, this.Mj, this.Mk);
            canvas.drawBitmap(this.Me, (Rect) null, this.Mj, this.Mk);
        }
        canvas.drawBitmap(this.Mc, (Rect) null, this.Mj, this.Mk);
        canvas.restoreToCount(iSaveLayer);
        canvas.rotate(this.Mz, this.Mj.centerX(), this.Mj.centerY());
        canvas.drawBitmap(this.Mc, (Rect) null, this.Mj, this.Ml);
        canvas.restoreToCount(iSave);
        canvas.restore();
    }

    @Override // android.graphics.drawable.AnimationDrawable, android.graphics.drawable.Animatable
    public final void start() {
        ValueAnimator valueAnimator = this.Mv;
        if (valueAnimator != null) {
            valueAnimator.start();
        }
    }

    @Override // android.graphics.drawable.AnimationDrawable, android.graphics.drawable.Animatable
    public final void stop() {
        ValueAnimator valueAnimator = this.Mv;
        if (valueAnimator != null) {
            valueAnimator.cancel();
        }
    }

    @Override // android.graphics.drawable.AnimationDrawable, android.graphics.drawable.Animatable
    public final boolean isRunning() {
        ValueAnimator valueAnimator = this.Mv;
        if (valueAnimator != null) {
            return valueAnimator.isRunning();
        }
        return false;
    }
}
