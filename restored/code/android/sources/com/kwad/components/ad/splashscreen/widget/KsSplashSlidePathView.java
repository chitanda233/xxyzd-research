package com.kwad.components.ad.splashscreen.widget;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.util.AttributeSet;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.widget.ImageView;

/* JADX INFO: loaded from: classes3.dex */
public class KsSplashSlidePathView extends ImageView {
    private Path MD;
    private Paint ME;
    private float MF;
    private float MG;
    private float MH;
    private float MI;
    private int MJ;
    private a MK;
    private GestureDetector ML;

    public interface a {
        void a(float f, float f2, float f3, float f4);

        void c(MotionEvent motionEvent);
    }

    public KsSplashSlidePathView(Context context) {
        super(context);
        this.MJ = Color.parseColor("#66ffffff");
        init();
    }

    public KsSplashSlidePathView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.MJ = Color.parseColor("#66ffffff");
        init();
    }

    private void init() {
        this.MD = new Path();
        Paint paint = new Paint();
        this.ME = paint;
        paint.setStrokeCap(Paint.Cap.ROUND);
        this.ME.setStrokeWidth(com.kwad.sdk.c.a.a.a(getContext(), 15.0f));
        this.ME.setStyle(Paint.Style.STROKE);
        this.ME.setColor(this.MJ);
        this.ME.setDither(true);
        this.ML = new GestureDetector(new GestureDetector.OnGestureListener() { // from class: com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.1
            @Override // android.view.GestureDetector.OnGestureListener
            public final boolean onDown(MotionEvent motionEvent) {
                return false;
            }

            @Override // android.view.GestureDetector.OnGestureListener
            public final boolean onFling(MotionEvent motionEvent, MotionEvent motionEvent2, float f, float f2) {
                return false;
            }

            @Override // android.view.GestureDetector.OnGestureListener
            public final void onLongPress(MotionEvent motionEvent) {
            }

            @Override // android.view.GestureDetector.OnGestureListener
            public final boolean onScroll(MotionEvent motionEvent, MotionEvent motionEvent2, float f, float f2) {
                return false;
            }

            @Override // android.view.GestureDetector.OnGestureListener
            public final void onShowPress(MotionEvent motionEvent) {
            }

            @Override // android.view.GestureDetector.OnGestureListener
            public final boolean onSingleTapUp(MotionEvent motionEvent) {
                if (KsSplashSlidePathView.this.MK == null) {
                    return false;
                }
                KsSplashSlidePathView.this.MK.c(motionEvent);
                return true;
            }
        });
    }

    public void setOnSlideTouchListener(a aVar) {
        this.MK = aVar;
    }

    @Override // android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        f(motionEvent);
        return true;
    }

    private void f(MotionEvent motionEvent) {
        if (this.ML.onTouchEvent(motionEvent)) {
            return;
        }
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked == 0) {
            this.MD.reset();
            this.MF = motionEvent.getX();
            float y = motionEvent.getY();
            this.MG = y;
            float f = this.MF;
            this.MH = f;
            this.MI = y;
            this.MD.moveTo(f, y);
            invalidate();
            return;
        }
        if (actionMasked != 1) {
            if (actionMasked != 2) {
                return;
            }
            b(motionEvent.getX(), motionEvent.getY());
            invalidate();
            return;
        }
        this.MD.reset();
        invalidate();
        a aVar = this.MK;
        if (aVar != null) {
            aVar.a(this.MF, this.MG, motionEvent.getX(), motionEvent.getY());
        }
    }

    private void b(float f, float f2) {
        float fAbs = Math.abs(f - this.MH);
        float fAbs2 = Math.abs(f2 - this.MI);
        if (fAbs >= 3.0f || fAbs2 >= 3.0f) {
            Path path = this.MD;
            float f3 = this.MH;
            float f4 = this.MI;
            path.quadTo(f3, f4, (f + f3) / 2.0f, (f2 + f4) / 2.0f);
            this.MH = f;
            this.MI = f2;
        }
    }

    @Override // android.widget.ImageView, android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawPath(this.MD, this.ME);
    }
}
