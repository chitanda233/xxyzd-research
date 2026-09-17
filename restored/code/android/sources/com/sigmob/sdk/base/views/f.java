package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewTreeObserver;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.czhj.sdk.common.utils.Dips;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes3.dex */
public class f extends View {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Path f3320a;
    private Path b;
    private Paint c;

    public f(Context context) {
        super(context);
        this.f3320a = new Path();
        this.b = new Path();
        Paint paint = new Paint();
        this.c = paint;
        paint.setStyle(Paint.Style.STROKE);
        this.c.setColor(-1);
        this.c.setAntiAlias(true);
        this.c.setAlpha(MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
        a();
    }

    public f(Context context, AttributeSet attrs) {
        super(context, attrs);
        a();
    }

    public f(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        a();
    }

    private void a() {
        getViewTreeObserver().addOnGlobalLayoutListener(new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.sigmob.sdk.base.views.f.1
            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public void onGlobalLayout() {
                f.this.getViewTreeObserver().removeOnGlobalLayoutListener(this);
                f.this.b();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b() {
        int width = getWidth();
        int width2 = getWidth();
        if (width <= 0 || width2 <= 0) {
            return;
        }
        int iMin = Math.min(width, width2);
        this.c.reset();
        this.f3320a.reset();
        this.b.reset();
        this.c.setStrokeWidth(Dips.dipsToIntPixels(1.0f, getContext()));
        float f = iMin;
        float f2 = width / 2.0f;
        float f3 = width2 / 2.0f;
        this.f3320a.addCircle(f2, f3, 0.45f * f, Path.Direction.CCW);
        this.b.addCircle(f2, f3, f * 0.35f, Path.Direction.CCW);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        this.c.setColor(-16777216);
        this.c.setAlpha(102);
        this.c.setStyle(Paint.Style.FILL);
        canvas.drawPath(this.f3320a, this.c);
        this.c.setColor(-1);
        this.c.setAlpha(76);
        this.c.setStyle(Paint.Style.STROKE);
        canvas.drawPath(this.f3320a, this.c);
        this.c.setAlpha(WorkQueueKt.MASK);
        canvas.drawPath(this.b, this.c);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        b();
    }
}
