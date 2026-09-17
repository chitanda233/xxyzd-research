package com.kwad.components.core.page.recycle;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Rect;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import androidx.recyclerview.widget.RecyclerView;

/* JADX INFO: loaded from: classes3.dex */
public class b extends g {
    private Rect aeT;
    private int aeU;
    private int aeV;
    private boolean aeW;
    private int aeX;
    private a aeY;
    private boolean aeZ;
    private boolean afa;

    public interface a {
        boolean uV();
    }

    public b(Context context) {
        this(context, null);
    }

    public b(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public b(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.aeX = Integer.MIN_VALUE;
        this.afa = false;
    }

    public void onDraw(Canvas canvas) {
        if (this.aeU != 0) {
            uT();
            Rect rect = this.aeT;
            if (rect != null && !rect.isEmpty()) {
                canvas.save();
                canvas.clipRect(this.aeT);
                canvas.drawColor(this.aeU);
                canvas.restore();
            }
        }
        super.onDraw(canvas);
    }

    public void setIgnoreTouchSwipeHandler(a aVar) {
        this.aeY = aVar;
    }

    public void setUseCustomScrollToPosition(boolean z) {
        this.aeW = z;
    }

    public void setDisableScroll(boolean z) {
        this.aeZ = z;
    }

    public void setUnderneathColor(int i) {
        this.aeU = i;
        uT();
        invalidate();
    }

    private void uT() {
        Rect rect = this.aeT;
        if (rect == null) {
            this.aeT = new Rect();
        } else {
            rect.setEmpty();
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            View childAt = getChildAt(i);
            if (childAt.getVisibility() == 0) {
                this.aeT.union(childAt.getLeft(), childAt.getTop(), childAt.getRight(), childAt.getBottom());
            }
        }
    }

    public void scrollToPosition(int i) {
        if (this.aeW) {
            scrollToPositionWithOffset(i, 0);
        } else {
            super.scrollToPosition(i);
        }
    }

    private void scrollToPositionWithOffset(int i, int i2) {
        a(i, getHeight(), 0);
    }

    private void a(int i, int i2, int i3) {
        while (true) {
            if (this.aeX == Integer.MIN_VALUE) {
                int[] iArr = new int[2];
                getLocationOnScreen(iArr);
                this.aeX = iArr[1];
            }
            int iFindFirstVisibleItemPosition = f.b(this).findFirstVisibleItemPosition();
            int iFindLastVisibleItemPosition = f.b(this).findLastVisibleItemPosition();
            if (iFindFirstVisibleItemPosition == -1 || iFindLastVisibleItemPosition == -1) {
                return;
            }
            if (i >= iFindFirstVisibleItemPosition && i <= iFindLastVisibleItemPosition) {
                int i4 = i - iFindFirstVisibleItemPosition;
                if (getChildCount() > i4) {
                    int[] iArr2 = new int[2];
                    getChildAt(i4).getLocationOnScreen(iArr2);
                    scrollBy(0, (iArr2[1] - this.aeX) - i3);
                    return;
                }
                return;
            }
            if (i > iFindLastVisibleItemPosition) {
                scrollBy(0, i2);
                a(i, i2, i3);
                return;
            }
            scrollBy(0, -i2);
        }
    }

    public void setDownStop(boolean z) {
        this.afa = z;
    }

    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        if (this.aeZ) {
            return false;
        }
        if (motionEvent.getAction() == 0 && this.afa) {
            stopScroll();
        }
        a aVar = this.aeY;
        if (aVar == null || !aVar.uV()) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        return false;
    }

    public boolean onTouchEvent(MotionEvent motionEvent) {
        if (this.aeZ) {
            return false;
        }
        return super.onTouchEvent(motionEvent);
    }

    protected void onMeasure(int i, int i2) {
        int size = View.MeasureSpec.getSize(i2);
        int i3 = this.aeV;
        if (i3 > 0 && i3 < size) {
            i2 = View.MeasureSpec.makeMeasureSpec(this.aeV, View.MeasureSpec.getMode(i2));
        }
        super.onMeasure(i, i2);
    }

    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        uU();
    }

    private void uU() {
        RecyclerView.Adapter adapter = getAdapter();
        if (adapter instanceof d) {
            ((d) adapter).uY();
        }
    }
}
