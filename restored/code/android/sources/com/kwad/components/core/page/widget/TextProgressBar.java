package com.kwad.components.core.page.widget;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.LinearGradient;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.Rect;
import android.graphics.RectF;
import android.graphics.Shader;
import android.graphics.drawable.Drawable;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.util.TypedValue;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ProgressBar;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class TextProgressBar extends ProgressBar {
    private String afZ;
    private LinearGradient aga;
    private Matrix agb;
    private boolean agc;
    private boolean agd;
    private boolean age;
    private int agf;
    private int agg;
    private Drawable agh;
    private int agi;
    private Rect agj;
    private int[] agk;
    private int agl;
    private int agm;
    private boolean agn;
    private Paint mPaint;
    private RectF mRectF;

    public TextProgressBar(Context context) {
        this(context, null);
    }

    public TextProgressBar(Context context, AttributeSet attributeSet) {
        super(m.wrapContextIfNeed(context), attributeSet);
        this.agd = false;
        this.age = true;
        this.agj = new Rect();
        vh();
    }

    @Override // android.widget.ProgressBar
    public void setProgress(int i) {
        if (this.age) {
            super.setProgress(i);
        } else {
            super.setProgress(0);
        }
    }

    @Override // android.widget.ProgressBar, android.view.View
    protected synchronized void onDraw(Canvas canvas) {
        int width;
        if (this.agd) {
            canvas.save();
            canvas.rotate(90.0f);
            canvas.translate(0.0f, -getWidth());
            super.onDraw(canvas);
            canvas.restore();
        } else {
            super.onDraw(canvas);
        }
        if (!TextUtils.isEmpty(this.afZ)) {
            Paint paint = this.mPaint;
            String str = this.afZ;
            paint.getTextBounds(str, 0, str.length(), this.agj);
        }
        int height = (getHeight() / 2) - this.agj.centerY();
        Drawable drawable = this.agh;
        if (drawable != null) {
            int intrinsicWidth = drawable.getIntrinsicWidth();
            int intrinsicHeight = this.agh.getIntrinsicHeight();
            int width2 = (((getWidth() - this.agj.width()) - intrinsicWidth) - this.agi) / 2;
            int i = intrinsicWidth + width2;
            this.agh.setBounds(width2, (getHeight() - intrinsicHeight) / 2, i, (getHeight() + intrinsicHeight) / 2);
            this.agh.draw(canvas);
            width = i + this.agi;
        } else {
            width = (getWidth() / 2) - this.agj.centerX();
        }
        if (this.agk != null) {
            float progress = ((getProgress() * 1.0f) / getMax()) * getWidth();
            float f = width;
            if (progress >= f) {
                if (this.aga == null) {
                    this.aga = new LinearGradient(f, 0.0f, width + this.agj.width(), 0.0f, this.agk, (float[]) null, Shader.TileMode.CLAMP);
                    Matrix matrix = new Matrix();
                    this.agb = matrix;
                    this.aga.setLocalMatrix(matrix);
                }
                this.mPaint.setShader(this.aga);
                this.agb.setScale(((progress - f) * 1.0f) / this.agj.width(), 1.0f, f, 0.0f);
                this.aga.setLocalMatrix(this.agb);
            } else {
                this.mPaint.setShader(null);
            }
            canvas.drawText(this.afZ, f, height, this.mPaint);
            return;
        }
        if (!isIndeterminate() && !this.agn) {
            this.mPaint.setColor(this.agl);
            String str2 = this.afZ;
            if (str2 != null) {
                canvas.drawText(str2, width, height, this.mPaint);
            }
            return;
        }
        float width3 = (getWidth() * getProgress()) / getMax();
        int iSave = canvas.save();
        this.mRectF.set(width3, 0.0f, getWidth(), getHeight());
        canvas.clipRect(this.mRectF);
        this.mPaint.setColor(this.agm);
        String str3 = this.afZ;
        if (str3 != null) {
            canvas.drawText(str3, width, height, this.mPaint);
        }
        canvas.restoreToCount(iSave);
        int iSave2 = canvas.save();
        this.mRectF.set(0.0f, 0.0f, width3, getHeight());
        canvas.clipRect(this.mRectF);
        this.mPaint.setColor(this.agl);
        String str4 = this.afZ;
        if (str4 != null) {
            canvas.drawText(str4, width, height, this.mPaint);
        }
        canvas.restoreToCount(iSave2);
    }

    @Override // android.widget.ProgressBar, android.view.View
    protected synchronized void onMeasure(int i, int i2) {
        ViewGroup.LayoutParams layoutParams = getLayoutParams();
        if (layoutParams != null && !TextUtils.isEmpty(this.afZ)) {
            Rect rect = new Rect();
            Paint paint = this.mPaint;
            String str = this.afZ;
            paint.getTextBounds(str, 0, str.length(), rect);
            if (layoutParams.width == -2) {
                layoutParams.width = rect.width() + this.agf + this.agg;
                i = View.MeasureSpec.makeMeasureSpec(layoutParams.width, 1073741824);
            }
            if (layoutParams.height == -2) {
                layoutParams.height = rect.height();
                i2 = View.MeasureSpec.makeMeasureSpec(layoutParams.height, 1073741824);
            }
        }
        if (this.agd) {
            super.onMeasure(i2, i);
            setMeasuredDimension(getMeasuredHeight(), getMeasuredWidth());
        } else {
            super.onMeasure(i, i2);
        }
    }

    @Override // android.widget.ProgressBar, android.view.View
    protected void onSizeChanged(int i, int i2, int i3, int i4) {
        if (this.agd) {
            super.onSizeChanged(i2, i, i3, i4);
        } else {
            super.onSizeChanged(i, i2, i3, i4);
        }
    }

    private void vh() {
        Paint paint = new Paint();
        this.mPaint = paint;
        paint.setAntiAlias(true);
        this.mPaint.setColor(-1);
        this.mPaint.setTextSize(com.kwad.sdk.c.a.a.a(getContext(), 12.0f));
        this.agi = com.kwad.sdk.c.a.a.a(getContext(), 2.0f);
        this.mRectF = new RectF();
        this.agl = -1;
        this.agm = -117146;
    }

    private void setProgressText(int i) {
        this.afZ = String.valueOf((int) (((i * 1.0f) / getMax()) * 100.0f)) + "%";
    }

    public final void e(String str, int i) {
        this.afZ = str;
        this.agc = true;
        setProgress(i);
        invalidate();
    }

    public void setTextDimenSp(int i) {
        this.mPaint.setTextSize(TypedValue.applyDimension(2, i, getResources().getDisplayMetrics()));
    }

    public void setTextDimen(float f) {
        this.mPaint.setTextSize(f);
    }

    public void setTextColor(int i) {
        this.agn = false;
        this.agl = i;
        postInvalidate();
    }

    public final void setTextColor(int i, int i2) {
        this.agn = true;
        this.agl = i;
        this.agm = i2;
        postInvalidate();
    }

    public void setVertical(boolean z) {
        this.agd = z;
    }

    public void setHasProgress(boolean z) {
        this.age = z;
    }

    @Override // android.view.View
    public void setPadding(int i, int i2, int i3, int i4) {
        this.agf = i;
        this.agg = i3;
    }

    public void setDrawableLeft(Drawable drawable) {
        this.agh = drawable;
    }

    public void setDrawablePadding(int i) {
        this.agi = i;
    }
}
