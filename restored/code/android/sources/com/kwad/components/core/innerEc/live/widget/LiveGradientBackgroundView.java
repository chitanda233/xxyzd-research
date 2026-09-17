package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.LinearGradient;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.RectF;
import android.graphics.Shader;
import android.util.AttributeSet;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public class LiveGradientBackgroundView extends View {
    private static final float[] ZW = {0.0f, 1.0f};
    private Path ZX;
    private LinearGradient ZY;
    private int[] ZZ;
    private float[] aaa;
    private Paint aab;
    private float aac;
    private LinearGradient aad;
    private int[] aae;
    private float[] aaf;
    private float aag;
    private com.kwad.sdk.g.b<RectF, RectF> aah;
    private Paint mPaint;

    public LiveGradientBackgroundView(Context context) {
        this(context, null);
    }

    public LiveGradientBackgroundView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public LiveGradientBackgroundView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.aac = com.kwad.sdk.c.a.a.a(getContext(), 1.0f) + 0.0f;
        this.aag = 100.0f;
        this.aah = new com.kwad.sdk.g.b<RectF, RectF>() { // from class: com.kwad.components.core.innerEc.live.widget.LiveGradientBackgroundView.1
            private static RectF a(RectF rectF) {
                return rectF;
            }

            @Override // com.kwad.sdk.g.b
            public final /* synthetic */ RectF apply(RectF rectF) {
                return a(rectF);
            }
        };
        init();
    }

    private void init() {
        this.mPaint = new Paint();
        this.aab = new Paint();
        this.mPaint.setAntiAlias(true);
        this.aab.setAntiAlias(true);
        this.ZZ = new int[]{1716650237, 859570429};
        this.aaa = ZW;
    }

    public void setBackgroundCornerRadius(float f) {
        this.aag = f;
        tq();
    }

    public void setGradientRectFMapper(com.kwad.sdk.g.b<RectF, RectF> bVar) {
        this.aah = bVar;
        tq();
    }

    public void setBorderWidth(float f) {
        this.aac = f;
        tq();
    }

    @Override // android.view.View
    protected void onSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        tq();
    }

    private void tq() {
        this.ZX = null;
        postInvalidateDelayed(20L);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        if (this.ZX == null) {
            tr();
        }
        canvas.save();
        this.mPaint.setShader(this.ZY);
        this.mPaint.setStyle(Paint.Style.FILL);
        canvas.clipPath(this.ZX);
        canvas.drawPath(this.ZX, this.mPaint);
        LinearGradient linearGradient = this.aad;
        if (linearGradient != null) {
            this.aab.setShader(linearGradient);
            this.aab.setStyle(Paint.Style.STROKE);
            this.aab.setStrokeWidth(this.aac);
            canvas.drawPath(this.ZX, this.aab);
        }
        canvas.restore();
    }

    private void tr() {
        int width = getWidth();
        int height = getHeight();
        int paddingLeft = (width - getPaddingLeft()) - getPaddingRight();
        int paddingTop = (height - getPaddingTop()) - getPaddingBottom();
        if (this.ZX == null) {
            RectF rectF = new RectF(0.0f, 0.0f, paddingLeft + 0, paddingTop + 0);
            Path path = new Path();
            this.ZX = path;
            float f = this.aag;
            path.addRoundRect(rectF, f, f, Path.Direction.CCW);
            RectF rectFApply = this.aah.apply(rectF);
            this.ZY = new LinearGradient(rectFApply.left, rectFApply.top, rectFApply.right, rectFApply.bottom, this.ZZ, this.aaa, Shader.TileMode.CLAMP);
            if (this.aae != null && this.aaf != null) {
                this.aad = new LinearGradient(rectFApply.left, rectFApply.top, rectFApply.right, rectFApply.bottom, this.aae, this.aaf, Shader.TileMode.CLAMP);
            } else {
                this.aad = null;
            }
        }
    }
}
