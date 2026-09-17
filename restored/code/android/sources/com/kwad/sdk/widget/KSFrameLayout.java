package com.kwad.sdk.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import android.widget.FrameLayout;
import com.kwad.sdk.R;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import java.util.Arrays;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class KSFrameLayout extends FrameLayout implements com.kwad.sdk.core.view.e, g, k {
    private com.kwad.sdk.core.view.d baK;
    private final al.a baL;
    private i bsW;
    private k bsX;
    private View bsY;
    private final AtomicBoolean cb;
    private float mRatio;
    private j mViewRCHelper;
    private boolean widthBasedRatio;

    private static float[] getRadius(float f, float f2, float f3, float f4) {
        return new float[]{f, f, f2, f2, f3, f3, f4, f4};
    }

    public KSFrameLayout(Context context) {
        super(context);
        this.cb = new AtomicBoolean(true);
        this.mRatio = 0.0f;
        this.baL = new al.a();
        this.baK = new com.kwad.sdk.core.view.d();
        this.widthBasedRatio = true;
        init(context, null);
    }

    public KSFrameLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.cb = new AtomicBoolean(true);
        this.mRatio = 0.0f;
        this.baL = new al.a();
        this.baK = new com.kwad.sdk.core.view.d();
        this.widthBasedRatio = true;
        init(context, attributeSet);
    }

    public KSFrameLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.cb = new AtomicBoolean(true);
        this.mRatio = 0.0f;
        this.baL = new al.a();
        this.baK = new com.kwad.sdk.core.view.d();
        this.widthBasedRatio = true;
        init(context, attributeSet);
    }

    public KSFrameLayout(Context context, View view) {
        super(context);
        this.cb = new AtomicBoolean(true);
        this.mRatio = 0.0f;
        this.baL = new al.a();
        this.baK = new com.kwad.sdk.core.view.d();
        this.widthBasedRatio = true;
        this.bsY = view;
        init(context, null);
    }

    protected void init(Context context, AttributeSet attributeSet) {
        if (attributeSet != null) {
            int i = R.attr.ksad_ratio;
            int[] iArr = {i};
            Arrays.sort(iArr);
            TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, iArr);
            this.mRatio = typedArrayObtainStyledAttributes.getFloat(Arrays.binarySearch(iArr, i), 0.0f);
            typedArrayObtainStyledAttributes.recycle();
        }
        i iVar = new i(getPvView(), this);
        this.bsW = iVar;
        iVar.cG(true);
        j jVar = new j();
        this.mViewRCHelper = jVar;
        jVar.initAttrs(context, attributeSet);
    }

    private View getPvView() {
        View view = this.bsY;
        return view == null ? this : view;
    }

    @Override // android.view.ViewGroup, android.view.View
    @Deprecated
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
        Ab();
    }

    @Override // android.view.View
    public void onFinishTemporaryDetach() {
        super.onFinishTemporaryDetach();
        Ab();
    }

    @Override // android.view.View
    public void onStartTemporaryDetach() {
        super.onStartTemporaryDetach();
        Ac();
    }

    @Override // android.view.ViewGroup, android.view.View
    @Deprecated
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        Ac();
    }

    private void Ab() {
        try {
            if (this.cb.getAndSet(false)) {
                ae();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void Ac() {
        try {
            if (this.cb.getAndSet(true)) {
                return;
            }
            af();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public void setWidthBasedRatio(boolean z) {
        this.widthBasedRatio = z;
    }

    protected void ae() {
        this.bsW.onAttachedToWindow();
    }

    protected void af() {
        this.bsW.onDetachedFromWindow();
    }

    @Override // android.view.View
    protected void onSizeChanged(int i, int i2, int i3, int i4) {
        this.bsW.d(i, i2, i3, i4);
        super.onSizeChanged(i, i2, i3, i4);
        this.bsW.XS();
        this.mViewRCHelper.onSizeChanged(i, i2);
    }

    @Override // android.view.View
    public void draw(Canvas canvas) {
        this.mViewRCHelper.beforeDraw(canvas);
        super.draw(canvas);
        this.mViewRCHelper.afterDraw(canvas);
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void dispatchDraw(Canvas canvas) {
        this.mViewRCHelper.beforeDispatchDraw(canvas);
        try {
            super.dispatchDraw(canvas);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        this.mViewRCHelper.afterDispatchDraw(canvas);
    }

    public void setVisiblePercent(float f) {
        this.bsW.setVisiblePercent(f);
    }

    public void setViewVisibleListener(k kVar) {
        this.bsX = kVar;
    }

    public float getVisiblePercent() {
        return this.bsW.getVisiblePercent();
    }

    public void H(View view) {
        k kVar = this.bsX;
        if (kVar != null) {
            kVar.H(view);
        }
    }

    public void setRadius(float f) {
        this.mViewRCHelper.setRadius(f);
        postInvalidate();
    }

    public void setAllCorner(boolean z) {
        this.mViewRCHelper.getCornerConf().setAllCorner(z);
    }

    public final void setRadius(float f, float f2, float f3, float f4) {
        this.mViewRCHelper.setRadius(getRadius(f, f2, f3, f4));
        postInvalidate();
    }

    @Override // android.widget.FrameLayout, android.view.View
    protected void onMeasure(int i, int i2) {
        if (this.mRatio != 0.0f) {
            if (this.widthBasedRatio) {
                i2 = View.MeasureSpec.makeMeasureSpec((int) (View.MeasureSpec.getSize(i) * this.mRatio), 1073741824);
            } else {
                i = View.MeasureSpec.makeMeasureSpec((int) (View.MeasureSpec.getSize(i2) / this.mRatio), 1073741824);
            }
        }
        super.onMeasure(i, i2);
    }

    public void setRatio(float f) {
        this.mRatio = f;
    }

    @Override // android.view.ViewGroup, android.view.View
    public boolean dispatchTouchEvent(MotionEvent motionEvent) {
        int action = motionEvent.getAction();
        if (action == 0) {
            this.baL.H(getWidth(), getHeight());
            this.baL.j(motionEvent.getX(), motionEvent.getY());
        } else if (action == 1) {
            this.baL.k(motionEvent.getX(), motionEvent.getY());
        }
        com.kwad.sdk.core.e.j(motionEvent);
        return super.dispatchTouchEvent(motionEvent);
    }

    @Override // com.kwad.sdk.widget.g
    public al.a getTouchCoords() {
        return this.baL;
    }

    @Override // android.view.View
    public void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        this.baK.j(this, z);
    }

    @Override // com.kwad.sdk.core.view.e
    public com.kwad.sdk.core.view.d getWindowFocusChangeHelper() {
        return this.baK;
    }
}
