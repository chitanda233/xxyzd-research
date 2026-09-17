package com.kwad.components.ad.reward.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.LinearGradient;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.Rect;
import android.graphics.RectF;
import android.graphics.Shader;
import android.util.AttributeSet;
import android.view.View;
import android.widget.LinearLayout;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class JinniuCouponLayout extends LinearLayout {
    private float EO;
    private Rect EP;
    private RectF EQ;
    private RectF ER;
    private RectF ES;
    private RectF ET;
    private Path EU;
    private int endColor;
    private Paint mPaint;
    private float mRadius;
    private int startColor;

    public JinniuCouponLayout(Context context) {
        super(context);
        this.mPaint = new Paint();
        this.EO = 4.0f;
        this.mRadius = 10.0f;
        this.EP = new Rect();
        this.EQ = new RectF();
        this.ER = new RectF();
        this.ES = new RectF();
        this.ET = new RectF();
        this.EU = new Path();
        this.startColor = Color.parseColor("#FFFE3666");
        this.endColor = Color.parseColor("#FFFD7200");
        a(context, null, 0);
    }

    public JinniuCouponLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.mPaint = new Paint();
        this.EO = 4.0f;
        this.mRadius = 10.0f;
        this.EP = new Rect();
        this.EQ = new RectF();
        this.ER = new RectF();
        this.ES = new RectF();
        this.ET = new RectF();
        this.EU = new Path();
        this.startColor = Color.parseColor("#FFFE3666");
        this.endColor = Color.parseColor("#FFFD7200");
        a(context, attributeSet, 0);
    }

    public JinniuCouponLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mPaint = new Paint();
        this.EO = 4.0f;
        this.mRadius = 10.0f;
        this.EP = new Rect();
        this.EQ = new RectF();
        this.ER = new RectF();
        this.ES = new RectF();
        this.ET = new RectF();
        this.EU = new Path();
        this.startColor = Color.parseColor("#FFFE3666");
        this.endColor = Color.parseColor("#FFFD7200");
        a(context, attributeSet, i);
    }

    public JinniuCouponLayout(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.mPaint = new Paint();
        this.EO = 4.0f;
        this.mRadius = 10.0f;
        this.EP = new Rect();
        this.EQ = new RectF();
        this.ER = new RectF();
        this.ES = new RectF();
        this.ET = new RectF();
        this.EU = new Path();
        this.startColor = Color.parseColor("#FFFE3666");
        this.endColor = Color.parseColor("#FFFD7200");
        a(context, attributeSet, i);
    }

    private void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_JinniuCouponLayout, i, 0);
        this.mRadius = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_JinniuCouponLayout_ksad_outerRadius, 4.0f);
        this.EO = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_JinniuCouponLayout_ksad_verticalRadius, 10.0f);
        typedArrayObtainStyledAttributes.recycle();
        this.mPaint.setAntiAlias(true);
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void dispatchDraw(Canvas canvas) {
        this.EP.setEmpty();
        getDrawingRect(this.EP);
        this.EQ.set(this.EP);
        if (getChildCount() > 1) {
            View childAt = getChildAt(0);
            RectF rectF = this.ER;
            if (rectF == null) {
                this.ER = new RectF();
            } else {
                rectF.setEmpty();
            }
            RectF rectF2 = this.ES;
            if (rectF2 == null) {
                this.ES = new RectF();
            } else {
                rectF2.setEmpty();
            }
            float measuredWidth = this.EP.left + childAt.getMeasuredWidth();
            RectF rectF3 = this.ER;
            float f = this.EP.top;
            float f2 = this.EO;
            rectF3.set(measuredWidth, f - f2, (f2 * 2.0f) + measuredWidth, this.EP.top + this.EO);
            this.ES.set(this.ER.left, this.EP.bottom - this.EO, this.ER.right, this.EP.bottom + this.EO);
            a(this.EU, this.EQ, this.ER, this.ES);
            setGradientPaint(this.EQ);
            canvas.drawPath(this.EU, this.mPaint);
        }
        super.dispatchDraw(canvas);
    }

    private void setGradientPaint(RectF rectF) {
        this.mPaint.setShader(new LinearGradient(rectF.left, rectF.top, rectF.right, rectF.bottom, this.startColor, this.endColor, Shader.TileMode.CLAMP));
    }

    private void a(Path path, RectF rectF, RectF rectF2, RectF rectF3) {
        path.reset();
        path.moveTo(this.EQ.left, this.EQ.top + this.mRadius);
        this.ET.set(rectF);
        RectF rectF4 = this.ET;
        rectF4.bottom = rectF4.top + (this.mRadius * 2.0f);
        RectF rectF5 = this.ET;
        rectF5.right = rectF5.left + (this.mRadius * 2.0f);
        path.arcTo(this.ET, 180.0f, 90.0f);
        path.lineTo(rectF2.left, rectF2.top);
        path.arcTo(rectF2, -180.0f, -180.0f);
        path.lineTo(rectF.width() - this.mRadius, rectF.top);
        this.ET.set(rectF);
        RectF rectF6 = this.ET;
        rectF6.left = rectF6.right - (this.mRadius * 2.0f);
        RectF rectF7 = this.ET;
        rectF7.bottom = rectF7.top + (this.mRadius * 2.0f);
        path.arcTo(this.ET, 270.0f, 90.0f);
        this.ET.set(rectF);
        RectF rectF8 = this.ET;
        rectF8.left = rectF8.right - (this.mRadius * 2.0f);
        RectF rectF9 = this.ET;
        rectF9.top = rectF9.bottom - (this.mRadius * 2.0f);
        path.arcTo(this.ET, 0.0f, 90.0f);
        path.lineTo(rectF3.right, rectF3.bottom);
        path.arcTo(rectF3, 0.0f, -180.0f);
        path.lineTo(rectF.left + this.mRadius, rectF.bottom);
        this.ET.set(rectF);
        RectF rectF10 = this.ET;
        rectF10.right = rectF10.left + (this.mRadius * 2.0f);
        RectF rectF11 = this.ET;
        rectF11.top = rectF11.bottom - (this.mRadius * 2.0f);
        path.arcTo(this.ET, 90.0f, 90.0f);
    }
}
