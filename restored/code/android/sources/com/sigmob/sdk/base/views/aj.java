package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.PointF;
import android.util.AttributeSet;
import android.view.View;
import com.czhj.sdk.common.utils.Dips;

/* JADX INFO: loaded from: classes3.dex */
public class aj extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3290a;
    private int b;
    private Paint c;
    private Path d;

    public aj(Context context) {
        super(context);
        a();
    }

    public aj(Context context, AttributeSet attrs) {
        super(context, attrs);
        a();
    }

    public aj(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        a();
    }

    private void a() {
    }

    private void a(Path path, PointF point) {
        float fTan = (float) (((double) point.x) - (((double) this.b) * Math.tan(2.0943951023931953d)));
        float f = point.y + this.b;
        float fTan2 = (float) (((double) point.x) + (((double) this.b) * Math.tan(2.0943951023931953d)));
        float f2 = point.y + this.b;
        path.moveTo(fTan, f);
        path.lineTo(point.x, point.y);
        path.lineTo(fTan2, f2);
    }

    private void b() {
        int width = getWidth();
        int height = getHeight();
        if (width == 0 || height == 0) {
            return;
        }
        this.f3290a = Dips.dipsToIntPixels(5.0f, getContext());
        this.b = height / 2;
        this.d = new Path();
        Paint paint = new Paint(1);
        this.c = paint;
        paint.setStyle(Paint.Style.STROKE);
        this.c.setStrokeWidth(this.f3290a);
        this.c.setColor(-1);
        a(this.d, new PointF(width / 2.0f, this.b));
        invalidate();
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawPath(this.d, this.c);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        b();
    }
}
