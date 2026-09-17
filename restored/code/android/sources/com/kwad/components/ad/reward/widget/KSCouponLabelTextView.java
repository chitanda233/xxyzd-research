package com.kwad.components.ad.reward.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.Rect;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.widget.TextView;
import com.kwad.components.core.widget.d;
import com.kwad.components.core.widget.e;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class KSCouponLabelTextView extends TextView implements d {
    private final Rect EP;
    private final RectF EQ;
    private final RectF ET;
    private float EV;
    private float EW;
    private float EX;
    private final RectF EY;
    private final RectF EZ;
    private final Path Fa;
    private Path Fb;
    private Path Fc;
    private boolean Fd;
    private final Paint mPaint;
    private int strokeColor;

    public KSCouponLabelTextView(Context context) {
        super(context);
        this.mPaint = new Paint();
        this.EP = new Rect();
        this.EQ = new RectF();
        this.EY = new RectF();
        this.EZ = new RectF();
        this.Fa = new Path();
        this.ET = new RectF();
        this.Fd = true;
        a(context, null, 0);
    }

    public KSCouponLabelTextView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.mPaint = new Paint();
        this.EP = new Rect();
        this.EQ = new RectF();
        this.EY = new RectF();
        this.EZ = new RectF();
        this.Fa = new Path();
        this.ET = new RectF();
        this.Fd = true;
        a(context, attributeSet, 0);
    }

    public KSCouponLabelTextView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mPaint = new Paint();
        this.EP = new Rect();
        this.EQ = new RectF();
        this.EY = new RectF();
        this.EZ = new RectF();
        this.Fa = new Path();
        this.ET = new RectF();
        this.Fd = true;
        a(context, attributeSet, i);
    }

    private void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KSCouponLabelTextView, i, 0);
        int color = context.getResources().getColor(R.color.ksad_reward_main_color);
        this.EV = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSCouponLabelTextView_ksad_labelRadius, 8.0f);
        this.EW = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSCouponLabelTextView_ksad_strokeSize, 2.0f);
        this.strokeColor = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_KSCouponLabelTextView_ksad_strokeColor, color);
        this.EX = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_KSCouponLabelTextView_ksad_sideRadius, 16.0f);
        typedArrayObtainStyledAttributes.recycle();
        lG();
    }

    private void lG() {
        this.mPaint.setColor(this.strokeColor);
        this.mPaint.setStrokeWidth(this.EW);
        this.mPaint.setStyle(Paint.Style.STROKE);
        this.mPaint.setAntiAlias(true);
    }

    @Override // android.widget.TextView, android.view.View
    protected void onMeasure(int i, int i2) {
        super.onMeasure(i, i2);
        if (this.Fd) {
            if (((float) (getPaddingLeft() + getPaddingRight())) + getPaint().measureText(getText().toString()) <= ((float) getMeasuredWidth())) {
                return;
            }
            setVisibility(8);
        }
    }

    @Override // android.widget.TextView, android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        this.EP.setEmpty();
        getDrawingRect(this.EP);
        float f = this.EW / 2.0f;
        this.EQ.set(this.EP);
        this.EQ.left += f;
        this.EQ.top += f;
        this.EQ.right -= f;
        this.EQ.bottom -= f;
        a(this.EQ, this.EY);
        b(this.EQ, this.EZ);
        Path path = this.Fb;
        if (path == null) {
            this.Fb = new Path();
        } else {
            path.reset();
        }
        Path path2 = this.Fc;
        if (path2 == null) {
            this.Fc = new Path();
        } else {
            path2.reset();
        }
        a(this.Fa, this.Fb, this.Fc, this.EQ, this.EY, this.EZ);
        canvas.drawPath(this.Fa, this.mPaint);
    }

    private void a(Path path, Path path2, Path path3, RectF rectF, RectF rectF2, RectF rectF3) {
        path.reset();
        float f = this.EV;
        path.addRoundRect(rectF, f, f, Path.Direction.CW);
        path2.addArc(rectF2, 90.0f, -180.0f);
        path3.addArc(rectF3, 90.0f, 180.0f);
        path.op(this.Fb, Path.Op.DIFFERENCE);
        path.op(this.Fc, Path.Op.DIFFERENCE);
    }

    private void b(Path path, RectF rectF, RectF rectF2, RectF rectF3) {
        path.reset();
        path.moveTo(rectF.left, rectF.top + this.EV);
        this.ET.set(rectF);
        RectF rectF4 = this.ET;
        rectF4.bottom = rectF4.top + (this.EV * 2.0f);
        RectF rectF5 = this.ET;
        rectF5.right = rectF5.left + (this.EV * 2.0f);
        path.arcTo(this.ET, 180.0f, 90.0f);
        path.lineTo(rectF.width() - this.EV, rectF.top);
        this.ET.set(rectF);
        RectF rectF6 = this.ET;
        rectF6.left = rectF6.right - (this.EV * 2.0f);
        RectF rectF7 = this.ET;
        rectF7.bottom = rectF7.top + (this.EV * 2.0f);
        path.arcTo(this.ET, 270.0f, 90.0f);
        path.lineTo(rectF.right, rectF3.top);
        path.arcTo(rectF3, 270.0f, -180.0f);
        path.lineTo(rectF.right, rectF.bottom - this.EV);
        this.ET.set(rectF);
        RectF rectF8 = this.ET;
        rectF8.left = rectF8.right - (this.EV * 2.0f);
        RectF rectF9 = this.ET;
        rectF9.top = rectF9.bottom - (this.EV * 2.0f);
        path.arcTo(this.ET, 0.0f, 90.0f);
        path.lineTo(rectF.left + this.EV, rectF.bottom);
        this.ET.set(rectF);
        RectF rectF10 = this.ET;
        rectF10.right = rectF10.left + (this.EV * 2.0f);
        RectF rectF11 = this.ET;
        rectF11.top = rectF11.bottom - (this.EV * 2.0f);
        path.arcTo(this.ET, 90.0f, 90.0f);
        path.lineTo(rectF.left, rectF2.bottom);
        path.arcTo(rectF2, 90.0f, -180.0f);
        path.close();
    }

    private void a(RectF rectF, RectF rectF2) {
        rectF2.set(rectF);
        rectF2.left -= this.EX;
        rectF2.right = rectF2.left + (this.EX * 2.0f);
        rectF2.top += (rectF.height() - (this.EX * 2.0f)) / 2.0f;
        rectF2.bottom = rectF2.top + (this.EX * 2.0f);
    }

    private void b(RectF rectF, RectF rectF2) {
        rectF2.set(rectF);
        rectF2.right += this.EX;
        rectF2.left = rectF2.right - (this.EX * 2.0f);
        rectF2.top += (rectF.height() - (this.EX * 2.0f)) / 2.0f;
        rectF2.bottom = rectF2.top + (this.EX * 2.0f);
    }

    @Override // com.kwad.components.core.widget.d
    public final void a(e eVar) {
        int color = getResources().getColor(R.color.ksad_reward_main_color);
        this.strokeColor = color;
        setTextColor(color);
        lG();
        invalidate();
    }
}
