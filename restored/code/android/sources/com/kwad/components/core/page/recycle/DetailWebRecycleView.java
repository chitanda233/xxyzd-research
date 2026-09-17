package com.kwad.components.core.page.recycle;

import android.app.Activity;
import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import androidx.core.view.ViewCompat;
import com.kwad.components.core.t.y;
import com.kwad.sdk.utils.ab;

/* JADX INFO: loaded from: classes3.dex */
public class DetailWebRecycleView extends b {
    private int afb;
    private boolean afc;
    private boolean afd;
    private int afe;
    private int aff;
    private boolean afg;
    a afh;
    private Runnable afi;
    private y afj;
    private int oY;

    public interface a {
        boolean uW();
    }

    public boolean onStartNestedScroll(View view, View view2, int i) {
        return (i & 2) != 0;
    }

    public DetailWebRecycleView(Context context) {
        this(context, null);
    }

    public DetailWebRecycleView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public DetailWebRecycleView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.afb = 1000;
        this.afc = false;
        this.afd = false;
        this.afi = new Runnable() { // from class: com.kwad.components.core.page.recycle.DetailWebRecycleView.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    Object field = ab.getField(DetailWebRecycleView.this, "mGapWorker");
                    if (field != null) {
                        ab.callMethod(field, "postFromTraversal", DetailWebRecycleView.this, 0, Integer.valueOf(DetailWebRecycleView.this.afb));
                    }
                } catch (RuntimeException e) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                }
            }
        };
        this.afj = new y(this.afi);
        if (context instanceof Activity) {
            this.oY = com.kwad.sdk.c.a.a.k((Activity) context);
        } else {
            this.oY = com.kwad.sdk.c.a.a.getScreenHeight(context);
        }
    }

    public void setTopViewHeight(int i) {
        this.afe = i;
    }

    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
        postDelayed(this.afj, 50L);
    }

    @Override // com.kwad.components.core.page.recycle.b
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        removeCallbacks(this.afj);
    }

    public void setInterceptRequestFocusForWeb(boolean z) {
        this.afc = z;
    }

    public void setInterceptRequestFocusForWebFiredOnce(boolean z) {
        this.afd = z;
    }

    public void requestChildFocus(View view, View view2) {
        if (this.afd) {
            this.afd = false;
        } else {
            if (this.afc) {
                return;
            }
            super.requestChildFocus(view, view2);
        }
    }

    @Override // com.kwad.components.core.page.recycle.b
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        a aVar = this.afh;
        if (aVar != null && aVar.uW()) {
            return true;
        }
        this.aff = computeVerticalScrollOffset();
        if (motionEvent.getY() <= this.afe - this.aff) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        return false;
    }

    public void onNestedPreScroll(View view, int i, int i2, int[] iArr) {
        int iComputeVerticalScrollOffset = computeVerticalScrollOffset();
        this.aff = iComputeVerticalScrollOffset;
        if ((i2 > 0 && iComputeVerticalScrollOffset < this.afe) && !this.afg && iComputeVerticalScrollOffset < this.oY) {
            scrollBy(0, i2);
            iArr[1] = i2;
        }
        if (i2 < 0 && this.aff > 0 && !ViewCompat.canScrollVertically(view, -1)) {
            scrollBy(0, i2);
            iArr[1] = i2;
        }
    }

    public boolean onNestedPreFling(View view, float f, float f2) {
        int iComputeVerticalScrollOffset = computeVerticalScrollOffset();
        this.aff = iComputeVerticalScrollOffset;
        if (iComputeVerticalScrollOffset >= this.afe) {
            return false;
        }
        fling((int) f, (int) f2);
        return true;
    }

    public void onScrollStateChanged(int i) {
        super.onScrollStateChanged(i);
        if (i == 0) {
            View childAt = getLayoutManager().getChildAt(getLayoutManager().getChildCount() - 1);
            if (childAt != null) {
                int bottom = childAt.getBottom();
                int bottom2 = getBottom() - getPaddingBottom();
                int position = getLayoutManager().getPosition(childAt);
                if (bottom == bottom2 && position == getLayoutManager().getItemCount() - 1) {
                    this.afg = true;
                    return;
                }
            }
            this.afg = false;
        }
    }

    public void setInterceptTouchListener(a aVar) {
        this.afh = aVar;
    }
}
