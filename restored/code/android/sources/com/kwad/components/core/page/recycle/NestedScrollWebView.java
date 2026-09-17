package com.kwad.components.core.page.recycle;

import android.app.Activity;
import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.VelocityTracker;
import android.view.View;
import android.view.ViewConfiguration;
import androidx.core.view.MotionEventCompat;
import androidx.core.view.NestedScrollingChild;
import androidx.core.view.NestedScrollingChildHelper;
import androidx.core.view.VelocityTrackerCompat;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public class NestedScrollWebView extends KsAdWebView implements NestedScrollingChild {
    private int afl;
    private final int[] afm;
    private final int[] afn;
    private int afo;
    private boolean afp;
    private int afq;
    private int afr;
    private NestedScrollingChildHelper afs;
    private int aft;
    private int mLastMotionY;
    private VelocityTracker mVelocityTracker;

    public NestedScrollWebView(Context context) {
        super(context);
        this.afm = new int[2];
        this.afn = new int[2];
        uX();
    }

    public NestedScrollWebView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.afm = new int[2];
        this.afn = new int[2];
        uX();
    }

    public NestedScrollWebView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.afm = new int[2];
        this.afn = new int[2];
        uX();
    }

    private void uX() {
        this.aft = 0;
        ViewConfiguration viewConfiguration = ViewConfiguration.get(getContext());
        this.afs = new NestedScrollingChildHelper(this);
        setNestedScrollingEnabled(true);
        this.afr = viewConfiguration.getScaledMaximumFlingVelocity();
        this.afq = viewConfiguration.getScaledMinimumFlingVelocity();
    }

    @Override // android.webkit.WebView, android.widget.AbsoluteLayout, android.view.View
    protected void onMeasure(int i, int i2) {
        int screenHeight;
        if (this.aft != 0) {
            int statusBarHeight = com.kwad.components.core.t.d.wV() ? com.kwad.sdk.c.a.a.getStatusBarHeight(getContext()) : 0;
            if (getContext() instanceof Activity) {
                screenHeight = com.kwad.sdk.c.a.a.k((Activity) getContext());
            } else {
                screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
            }
            i2 = View.MeasureSpec.makeMeasureSpec((screenHeight - statusBarHeight) - this.aft, 1073741824);
        }
        super.onMeasure(i, i2);
    }

    /* JADX WARN: Code duplicated, block: B:37:0x00e0  */
    /* JADX WARN: Code duplicated, block: B:46:0x012d  */
    @Override // com.kwad.sdk.core.webview.KsAdWebView, android.webkit.WebView, android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        boolean zOnTouchEvent;
        float f;
        MotionEvent motionEventObtain = MotionEvent.obtain(motionEvent);
        int actionMasked = MotionEventCompat.getActionMasked(motionEvent);
        boolean z = false;
        if (actionMasked == 0) {
            this.afo = 0;
        }
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        int actionIndex = MotionEventCompat.getActionIndex(motionEvent);
        int y = (int) motionEvent.getY();
        motionEvent.offsetLocation(0.0f, this.afo);
        if (actionMasked == 0) {
            this.mLastMotionY = y;
            this.afl = (int) motionEvent.getX();
            startNestedScroll(2);
            int[] iArr = this.afn;
            iArr[0] = 0;
            iArr[1] = 0;
            int[] iArr2 = this.afm;
            iArr2[0] = 0;
            iArr2[1] = 0;
            zOnTouchEvent = super.onTouchEvent(motionEvent);
            this.afp = false;
        } else if (actionMasked == 1) {
            this.mVelocityTracker.addMovement(motionEvent);
            this.mVelocityTracker.computeCurrentVelocity(1000, this.afr);
            f = -VelocityTrackerCompat.getYVelocity(this.mVelocityTracker, MotionEventCompat.getPointerId(motionEvent, actionIndex));
            if (Math.abs(f) > this.afq && !dispatchNestedPreFling(0.0f, f) && hasNestedScrollingParent()) {
                dispatchNestedFling(0.0f, f, true);
            }
            boolean zOnTouchEvent2 = super.onTouchEvent(motionEvent);
            stopNestedScroll();
            if (Math.abs(motionEvent.getY() - this.mLastMotionY) < 10.0f) {
                Math.abs(motionEvent.getX() - this.afl);
            }
            zOnTouchEvent = zOnTouchEvent2;
            z = true;
        } else if (actionMasked == 2) {
            int i = this.mLastMotionY - y;
            if (dispatchNestedPreScroll(0, i, this.afn, this.afm)) {
                i -= this.afn[1];
                motionEventObtain.offsetLocation(0.0f, this.afm[1]);
                this.afo += this.afm[1];
            }
            int scrollY = getScrollY();
            this.mLastMotionY = y - this.afm[1];
            int iMax = Math.max(0, scrollY + i);
            int i2 = i - (iMax - scrollY);
            if (dispatchNestedScroll(0, iMax - i2, 0, i2, this.afm)) {
                int i3 = this.mLastMotionY;
                int i4 = this.afm[1];
                this.mLastMotionY = i3 - i4;
                motionEventObtain.offsetLocation(0.0f, i4);
                this.afo += this.afm[1];
            }
            if (Math.abs(this.afn[1]) < 5 && Math.abs(this.afm[1]) < 5) {
                if (this.afp) {
                    this.afp = false;
                    zOnTouchEvent = false;
                } else {
                    zOnTouchEvent = super.onTouchEvent(motionEventObtain);
                }
                motionEventObtain.recycle();
            } else {
                if (!this.afp) {
                    this.afp = true;
                    super.onTouchEvent(MotionEvent.obtain(0L, 0L, 3, 0.0f, 0.0f, 0));
                }
                zOnTouchEvent = false;
            }
        } else if (actionMasked == 3) {
            this.mVelocityTracker.addMovement(motionEvent);
            this.mVelocityTracker.computeCurrentVelocity(1000, this.afr);
            f = -VelocityTrackerCompat.getYVelocity(this.mVelocityTracker, MotionEventCompat.getPointerId(motionEvent, actionIndex));
            if (Math.abs(f) > this.afq) {
                dispatchNestedFling(0.0f, f, true);
            }
            boolean zOnTouchEvent3 = super.onTouchEvent(motionEvent);
            stopNestedScroll();
            if (Math.abs(motionEvent.getY() - this.mLastMotionY) < 10.0f) {
                Math.abs(motionEvent.getX() - this.afl);
            }
            zOnTouchEvent = zOnTouchEvent3;
            z = true;
        } else if (actionMasked != 5) {
            zOnTouchEvent = false;
        } else {
            stopNestedScroll();
            zOnTouchEvent = super.onTouchEvent(motionEvent);
        }
        if (!z) {
            this.mVelocityTracker.addMovement(motionEvent);
        }
        return zOnTouchEvent;
    }

    @Override // com.kwad.sdk.core.webview.KsAdWebView, android.webkit.WebView, android.view.View
    public void onScrollChanged(int i, int i2, int i3, int i4) {
        super.onScrollChanged(i, i2, i3, i4);
        if (hasFocus()) {
            return;
        }
        requestFocus();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public void setNestedScrollingEnabled(boolean z) {
        this.afs.setNestedScrollingEnabled(z);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean isNestedScrollingEnabled() {
        return this.afs.isNestedScrollingEnabled();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean startNestedScroll(int i) {
        return this.afs.startNestedScroll(i);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public void stopNestedScroll() {
        this.afs.stopNestedScroll();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean hasNestedScrollingParent() {
        return this.afs.hasNestedScrollingParent();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        return this.afs.dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        return this.afs.dispatchNestedPreScroll(i, i2, iArr, iArr2);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedFling(float f, float f2, boolean z) {
        return this.afs.dispatchNestedFling(f, f2, z);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedPreFling(float f, float f2) {
        return this.afs.dispatchNestedPreFling(f, f2);
    }
}
