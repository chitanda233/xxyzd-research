package com.kwad.sdk.widget;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.LinearGradient;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.Path;
import android.graphics.Rect;
import android.graphics.RectF;
import android.graphics.Shader;
import android.os.SystemClock;
import android.util.AttributeSet;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public class DownloadProgressBar extends View {
    Paint bsL;
    Paint bsM;
    Paint bsN;
    private String bsO;
    private float bsP;
    private Rect bsQ;
    private LinearGradient bsR;
    private LinearGradient bsS;
    private LinearGradient bsT;
    private Runnable bsU;
    private Matrix mMatrix;
    private Path mPath;
    private RectF mRectF;
    private long mStartTime;

    public DownloadProgressBar(Context context) {
        this(context, null, 0);
    }

    public DownloadProgressBar(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public DownloadProgressBar(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.bsU = new Runnable() { // from class: com.kwad.sdk.widget.DownloadProgressBar.1
            @Override // java.lang.Runnable
            public final void run() {
                DownloadProgressBar.this.invalidate();
                if (DownloadProgressBar.this.getWindowVisibility() == 0) {
                    DownloadProgressBar.this.postDelayed(this, 34L);
                }
            }
        };
        this.bsL = new Paint(1);
        this.bsM = new Paint(1);
        this.mRectF = new RectF();
        Paint paint = new Paint(1);
        this.bsN = paint;
        paint.setTextSize(com.kwad.sdk.c.a.a.a(context, 16.0f));
        this.bsN.setColor(-1);
        this.bsN.setTextAlign(Paint.Align.CENTER);
        this.bsQ = new Rect();
        this.mMatrix = new Matrix();
        this.mPath = new Path();
    }

    public void setText(String str) {
        this.bsO = str;
        invalidate();
    }

    public void setProgress(float f) {
        this.bsP = f;
        invalidate();
        if (f == 0.0f || f == 100.0f) {
            removeCallbacks(this.bsU);
        } else if (getWindowVisibility() == 0 && this.mStartTime == 0) {
            post(this.bsU);
        }
    }

    @Override // android.view.View
    protected void onWindowVisibilityChanged(int i) {
        super.onWindowVisibilityChanged(i);
        if (i == 0) {
            float f = this.bsP;
            if (f <= 0.0f || f >= 100.0f) {
                return;
            }
            this.mStartTime = SystemClock.elapsedRealtime();
            post(this.bsU);
            return;
        }
        removeCallbacks(this.bsU);
    }

    @Override // android.view.View
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        removeCallbacks(this.bsU);
    }

    @Override // android.view.View
    protected void onSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        this.bsR = new LinearGradient(0.0f, 0.0f, getMeasuredWidth(), 0.0f, new int[]{1291525714, 1291569420}, new float[]{0.0f, 1.0f}, Shader.TileMode.CLAMP);
        this.bsS = new LinearGradient(0.0f, 0.0f, getMeasuredWidth(), 0.0f, new int[]{-319918, -276212}, new float[]{0.0f, 1.0f}, Shader.TileMode.CLAMP);
        this.bsL.setShader(this.bsR);
        LinearGradient linearGradient = new LinearGradient(0.0f, 0.0f, getMeasuredWidth(), 0.0f, new int[]{16501004, -276212}, new float[]{0.0f, 1.0f}, Shader.TileMode.CLAMP);
        this.bsT = linearGradient;
        this.bsM.setShader(linearGradient);
        float f = i;
        this.mRectF.set(0.0f, 0.0f, f, i2);
        this.mPath.reset();
        float f2 = f / 2.0f;
        this.mPath.addRoundRect(this.mRectF, f2, f2, Path.Direction.CW);
    }

    @Override // android.view.View
    protected void onVisibilityChanged(View view, int i) {
        super.onVisibilityChanged(view, i);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.clipPath(this.mPath);
        this.bsL.setShader(this.bsR);
        canvas.drawRect(this.mRectF, this.bsL);
        this.bsL.setShader(this.bsS);
        canvas.drawRect(0.0f, 0.0f, (getWidth() * this.bsP) / 100.0f, getHeight(), this.bsL);
        float f = this.bsP;
        float f2 = 0.0f;
        if (f > 0.0f && f < 100.0f) {
            long jElapsedRealtime = (SystemClock.elapsedRealtime() - this.mStartTime) % 2500;
            float f3 = jElapsedRealtime >= 1500 ? 0.0f : jElapsedRealtime / 1500.0f;
            this.mMatrix.reset();
            this.mMatrix.setScale(1.0f, f3);
            this.bsT.setLocalMatrix(this.mMatrix);
            this.bsM.setShader(this.bsT);
            canvas.drawRect(0.0f, 0.0f, ((getWidth() * this.bsP) / 100.0f) * f3, getHeight(), this.bsM);
            if (jElapsedRealtime > 500 && jElapsedRealtime <= 1500) {
                f2 = (jElapsedRealtime - 500) / 1000.0f;
            }
            float width = ((getWidth() * this.bsP) / 100.0f) * f2;
            this.mMatrix.reset();
            this.mMatrix.setScale(1.0f, f3);
            this.bsT.setLocalMatrix(this.mMatrix);
            this.bsM.setShader(this.bsT);
            canvas.drawRect(0.0f, 0.0f, width, getHeight(), this.bsM);
        }
        String str = this.bsO;
        if (str != null) {
            this.bsN.getTextBounds(str, 0, str.length(), this.bsQ);
            canvas.drawText(this.bsO, getWidth() / 2.0f, (getHeight() / 2.0f) - ((this.bsQ.top + this.bsQ.bottom) / 2.0f), this.bsN);
        }
    }
}
