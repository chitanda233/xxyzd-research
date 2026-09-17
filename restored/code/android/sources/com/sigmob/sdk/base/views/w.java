package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.util.TypedValue;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes3.dex */
public class w extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Paint f3361a;
    private RectF b;
    private Paint c;
    private int d;
    private int e;
    private String f;

    public w(Context context) {
        super(context);
        this.f = "";
        a(context);
    }

    public w(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.f = "";
        a(context);
    }

    public w(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.f = "";
        a(context);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        if (this.f3361a == null) {
            Paint paint = new Paint();
            this.f3361a = paint;
            paint.setStyle(Paint.Style.STROKE);
            this.f3361a.setColor(-1);
            int iAsIntPixels = Dips.asIntPixels(1.0f, getContext());
            this.e = iAsIntPixels;
            this.f3361a.setStrokeWidth(iAsIntPixels);
            this.f3361a.setAlpha(WorkQueueKt.MASK);
            Paint paint2 = new Paint();
            this.c = paint2;
            paint2.setColor(-1);
            this.c.setStyle(Paint.Style.FILL);
            this.c.setTextSize(TypedValue.applyDimension(2, 12.0f, getResources().getDisplayMetrics()));
            this.d = Dips.asIntPixels(10.0f, getContext());
        }
        int i = this.e;
        this.b = new RectF(i, i, getWidth() - this.e, getHeight() - this.e);
    }

    private void a(Context context) {
        com.sigmob.sdk.base.utils.w.a(this, new Runnable() { // from class: com.sigmob.sdk.base.views.w.1
            @Override // java.lang.Runnable
            public void run() {
                w.this.a();
            }
        });
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        Paint paint = this.f3361a;
        if (paint == null) {
            return;
        }
        paint.setStyle(Paint.Style.FILL);
        this.f3361a.setColor(-16777216);
        this.f3361a.setAlpha(102);
        RectF rectF = this.b;
        canvas.drawRoundRect(rectF, rectF.right / 2.0f, this.b.right / 2.0f, this.f3361a);
        this.f3361a.setStyle(Paint.Style.STROKE);
        this.f3361a.setColor(-1);
        this.f3361a.setAlpha(76);
        RectF rectF2 = this.b;
        canvas.drawRoundRect(rectF2, rectF2.right / 2.0f, this.b.right / 2.0f, this.f3361a);
        canvas.drawText(this.f, (getWidth() - this.c.measureText(this.f)) / 2.0f, ((this.b.bottom / 2.0f) + ((this.c.getFontMetrics().bottom - this.c.getFontMetrics().top) / 2.0f)) - this.c.getFontMetrics().bottom, this.c);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        a();
    }

    public void setText(String text) {
        this.f = text;
        invalidate();
    }
}
