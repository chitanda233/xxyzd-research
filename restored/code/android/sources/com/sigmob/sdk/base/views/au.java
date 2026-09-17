package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;

/* JADX INFO: loaded from: classes3.dex */
public class au extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Paint f3307a;
    private Path b;
    private int c;
    private RectF d;
    private RectF e;
    private RectF f;

    public au(Context context) {
        super(context);
    }

    public au(Context context, AttributeSet attrs) {
        super(context, attrs);
    }

    public au(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
    }

    private void a() {
        this.f3307a = new Paint();
        this.b = new Path();
        float fDipsToIntPixels = Dips.dipsToIntPixels(1.0f, getContext());
        this.f3307a.setStrokeWidth(fDipsToIntPixels);
        this.c = (int) ((getWidth() / (100.0f * fDipsToIntPixels)) * fDipsToIntPixels * 20.0f);
        int width = getWidth() - this.c;
        int height = getHeight();
        this.f3307a.setStyle(Paint.Style.STROKE);
        this.f3307a.setColor(-1);
        this.f3307a.setAntiAlias(true);
        float f = height;
        float f2 = f / 2.2f;
        this.d = new RectF(this.c, f2, width / 2.0f, f - f2);
        this.e = new RectF(this.c, this.d.top, this.d.right, this.d.bottom);
        this.f = new RectF(this.d.right + this.e.width(), this.d.top, this.d.right + this.d.width() + this.e.width(), this.d.bottom);
    }

    private void a(Canvas canvas, RectF rectf) {
        this.b.reset();
        this.f3307a.setColor(-1);
        this.f3307a.setStyle(Paint.Style.STROKE);
        this.b.addArc(this.e, 90.0f, 180.0f);
        canvas.drawPath(this.b, this.f3307a);
    }

    private void b(Canvas canvas, RectF rectf) {
        this.b.reset();
        this.f3307a.setColor(-1);
        this.f3307a.setStyle(Paint.Style.STROKE);
        this.b.addArc(this.f, 90.0f, -180.0f);
        canvas.drawPath(this.b, this.f3307a);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        a(canvas, this.d);
        b(canvas, this.d);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        a();
    }
}
