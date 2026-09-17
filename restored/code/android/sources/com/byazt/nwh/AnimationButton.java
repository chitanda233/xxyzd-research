package com.byazt.nwh;

import android.content.Context;
import android.graphics.Canvas;
import android.widget.TextView;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 668, 2020})
public class AnimationButton extends TextView implements tt {
    public c c;
    public float n;
    public float tt;
    public float uj;
    public float ve;

    @Override // com.byazt.nwh.tt
    public float getShineValue() {
        return this.ve;
    }

    public void setShineValue(float f) {
        this.ve = f;
        postInvalidate();
    }

    @Override // com.byazt.nwh.tt
    public float getRippleValue() {
        return this.tt;
    }

    public void setRippleValue(float f) {
        this.tt = f;
        postInvalidate();
    }

    @Override // com.byazt.nwh.tt
    public float getMarqueeValue() {
        return this.uj;
    }

    public void setMarqueeValue(float f) {
        this.uj = f;
        postInvalidate();
    }

    public float getStretchValue() {
        return this.n;
    }

    public void setStretchValue(float f) {
        this.n = f;
        this.c.c(this, f);
    }

    public AnimationButton(Context context) {
        super(context);
        this.c = new c();
    }

    @Override // android.widget.TextView, android.view.View
    public void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        this.c.c(canvas, this, this);
    }

    @Override // android.view.View
    public void onSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        this.c.c(this, i, i2);
    }
}
