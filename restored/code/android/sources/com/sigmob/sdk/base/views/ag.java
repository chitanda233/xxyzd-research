package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.util.TypedValue;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLogger;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes3.dex */
public class ag extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3285a = "ag";
    private Paint b;
    private RectF c;
    private Paint d;
    private int e;
    private int f;
    private int g;

    public ag(Context context) {
        super(context);
        this.f = 15;
    }

    public ag(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.f = 15;
    }

    public ag(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.f = 15;
    }

    private void a() {
        Paint paint = new Paint();
        this.b = paint;
        paint.setStyle(Paint.Style.STROKE);
        this.b.setColor(-1);
        int iAsIntPixels = Dips.asIntPixels(1.0f, getContext());
        this.g = iAsIntPixels;
        this.b.setStrokeWidth(iAsIntPixels);
        this.b.setAlpha(WorkQueueKt.MASK);
        Paint paint2 = new Paint();
        this.d = paint2;
        paint2.setColor(-1);
        this.d.setStyle(Paint.Style.FILL);
        this.d.setTextSize(TypedValue.applyDimension(2, 12.0f, getResources().getDisplayMetrics()));
        this.e = Dips.asIntPixels(10.0f, getContext());
        int i = this.g;
        this.c = new RectF(i, i, getWidth() - this.g, getHeight() - this.g);
    }

    public void a(int countdown) {
        SigmobLogger.d(f3285a, "updateTimer: countdown = " + countdown, new Object[0]);
        this.f = countdown;
        invalidate();
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        String strValueOf;
        float f;
        super.onDraw(canvas);
        this.b.setStyle(Paint.Style.FILL);
        this.b.setColor(-16777216);
        this.b.setAlpha(WorkQueueKt.MASK);
        RectF rectF = this.c;
        canvas.drawRoundRect(rectF, rectF.right / 2.0f, this.c.right / 2.0f, this.b);
        canvas.drawText("跳过", this.e, ((this.c.bottom / 2.0f) + ((this.d.getFontMetrics().bottom - this.d.getFontMetrics().top) / 2.0f)) - this.d.getFontMetrics().bottom, this.d);
        this.b.setStyle(Paint.Style.STROKE);
        this.b.setColor(-1);
        int iAsIntPixels = Dips.asIntPixels(1.0f, getContext());
        this.g = iAsIntPixels;
        this.b.setStrokeWidth(iAsIntPixels);
        this.b.setAlpha(WorkQueueKt.MASK);
        RectF rectF2 = this.c;
        canvas.drawRoundRect(rectF2, rectF2.right / 2.0f, this.c.right / 2.0f, this.b);
        float fMeasureText = this.e + this.d.measureText("跳过") + (this.e / 2.0f);
        int i = this.g;
        canvas.drawLine(fMeasureText + (i * 2), i * 2, fMeasureText + (i * 2), this.c.bottom - (this.g * 2), this.b);
        int i2 = this.f;
        if (i2 > 9) {
            strValueOf = String.valueOf(i2);
            f = this.e / 2.0f;
        } else {
            strValueOf = String.valueOf(i2);
            f = this.e;
        }
        canvas.drawText(strValueOf, fMeasureText + f, ((this.c.bottom / 2.0f) + ((this.d.getFontMetrics().bottom - this.d.getFontMetrics().top) / 2.0f)) - this.d.getFontMetrics().bottom, this.d);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        a();
    }
}
