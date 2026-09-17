package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapShader;
import android.graphics.Canvas;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.RectF;
import android.graphics.Shader;
import android.graphics.drawable.BitmapDrawable;
import android.util.AttributeSet;
import android.util.TypedValue;
import android.widget.ImageView;

/* JADX INFO: loaded from: classes3.dex */
public class CircleImageView extends ImageView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected float f3270a;
    protected boolean b;
    private float c;
    private float d;
    private final Paint e;
    private final Matrix f;
    private RectF g;

    public CircleImageView(Context context) {
        this(context, null);
    }

    public CircleImageView(Context context, AttributeSet attrs) {
        this(context, attrs, 0);
    }

    public CircleImageView(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.b = false;
        Paint paint = new Paint();
        this.e = paint;
        paint.setAntiAlias(true);
        this.f = new Matrix();
        this.f3270a = TypedValue.applyDimension(1, 10.0f, context.getResources().getDisplayMetrics());
    }

    private BitmapShader a() {
        Bitmap bitmap;
        BitmapDrawable bitmapDrawable = (BitmapDrawable) getDrawable();
        if (bitmapDrawable == null || (bitmap = bitmapDrawable.getBitmap()) == null) {
            return null;
        }
        BitmapShader bitmapShader = new BitmapShader(bitmap, Shader.TileMode.CLAMP, Shader.TileMode.CLAMP);
        float fMax = Math.max(this.c / bitmap.getWidth(), this.c / bitmap.getHeight());
        this.f.setScale(fMax, fMax);
        bitmapShader.setLocalMatrix(this.f);
        return bitmapShader;
    }

    @Override // android.widget.ImageView, android.view.View
    protected void onDraw(Canvas canvas) {
        BitmapShader bitmapShaderA = a();
        if (bitmapShaderA == null) {
            super.onDraw(canvas);
            return;
        }
        this.e.setShader(bitmapShaderA);
        if (this.b) {
            float f = this.c;
            canvas.drawCircle(f / 2.0f, f / 2.0f, f / 2.0f, this.e);
        } else {
            RectF rectF = this.g;
            float f2 = this.f3270a;
            canvas.drawRoundRect(rectF, f2, f2, this.e);
        }
    }

    @Override // android.widget.ImageView, android.view.View
    protected void onMeasure(int widthMeasureSpec, int heightMeasureSpec) {
        super.onMeasure(widthMeasureSpec, heightMeasureSpec);
        this.c = getMeasuredWidth();
        float measuredHeight = getMeasuredHeight();
        this.d = measuredHeight;
        this.c = Math.min(this.c, measuredHeight);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        this.g = new RectF(0.0f, 0.0f, getHeight(), getHeight());
    }

    public void setCircle(boolean circle) {
        this.b = circle;
    }
}
