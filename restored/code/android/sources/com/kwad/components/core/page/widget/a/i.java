package com.kwad.components.core.page.widget.a;

import android.content.Context;
import android.util.Log;
import android.view.MotionEvent;
import android.view.VelocityTracker;
import android.view.View;
import android.view.ViewConfiguration;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import androidx.core.view.MotionEventCompat;
import androidx.core.view.VelocityTrackerCompat;
import androidx.core.view.ViewCompat;
import androidx.core.widget.ScrollerCompat;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    private static final Interpolator ahL = new Interpolator() { // from class: com.kwad.components.core.page.widget.a.i.1
        @Override // android.animation.TimeInterpolator
        public final float getInterpolation(float f) {
            float f2 = f - 1.0f;
            return (f2 * f2 * f2 * f2 * f2) + 1.0f;
        }
    };
    private final a ahM;
    private final ViewGroup ahN;
    private int ahO;
    private float[] ahP;
    private float[] ahQ;
    private float[] ahR;
    private float[] ahS;
    private int[] ahT;
    private int[] ahU;
    private int[] ahV;
    private int ahW;
    private float ahX;
    private float ahY;
    private int ahZ;
    private int aia;
    private ScrollerCompat aib;
    private View aic;
    private boolean aie;
    private int mTouchSlop;
    private VelocityTracker mVelocityTracker;
    private int duration = 0;
    private int mActivePointerId = -1;
    private final Runnable aid = new Runnable() { // from class: com.kwad.components.core.page.widget.a.i.2
        @Override // java.lang.Runnable
        public final void run() {
            i.this.bD(0);
        }
    };

    public static abstract class a {
        public static int getOrderedChildIndex(int i) {
            return i;
        }

        public int E(View view) {
            return 0;
        }

        public void bx(int i) {
        }

        public int by(int i) {
            return 0;
        }

        public void onViewDragStateChanged(int i) {
        }

        public void onViewReleased(View view, float f, float f2) {
        }

        public abstract boolean tryCaptureView(View view, int i);

        public int vy() {
            return 0;
        }
    }

    private i(Context context, ViewGroup viewGroup, a aVar) {
        if (viewGroup == null) {
            throw new IllegalArgumentException("Parent view may not be null");
        }
        if (aVar == null) {
            throw new IllegalArgumentException("Callback may not be null");
        }
        this.ahN = viewGroup;
        this.ahM = aVar;
        ViewConfiguration viewConfiguration = ViewConfiguration.get(context);
        this.ahZ = (int) ((context.getResources().getDisplayMetrics().density * 20.0f) + 0.5f);
        this.mTouchSlop = viewConfiguration.getScaledTouchSlop();
        this.ahX = viewConfiguration.getScaledMaximumFlingVelocity();
        this.ahY = viewConfiguration.getScaledMinimumFlingVelocity();
        this.aib = ScrollerCompat.create(context, ahL);
    }

    public static i a(ViewGroup viewGroup, a aVar) {
        return new i(viewGroup.getContext(), viewGroup, aVar);
    }

    public final void captureChildView(View view, int i) {
        if (view.getParent() != this.ahN) {
            throw new IllegalArgumentException("captureChildView: parameter must be a descendant of the ViewDragHelper's tracked parent view (" + this.ahN + ")");
        }
        this.aic = view;
        this.mActivePointerId = i;
        bD(1);
    }

    public final int getTouchSlop() {
        return this.mTouchSlop;
    }

    private void cancel() {
        this.mActivePointerId = -1;
        vB();
        VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker != null) {
            velocityTracker.recycle();
            this.mVelocityTracker = null;
        }
    }

    public final boolean smoothSlideViewTo(View view, int i, int i2) {
        this.aic = view;
        this.mActivePointerId = -1;
        boolean zA = a(i, i2, 0, 0);
        if (!zA && this.ahO == 0 && this.aic != null) {
            this.aic = null;
        }
        return zA;
    }

    public final boolean settleCapturedViewAt(int i, int i2) {
        if (!this.aie) {
            throw new IllegalStateException("Cannot settleCapturedViewAt outside of a call to Callback#onViewReleased");
        }
        return a(i, i2, (int) VelocityTrackerCompat.getXVelocity(this.mVelocityTracker, this.mActivePointerId), (int) VelocityTrackerCompat.getYVelocity(this.mVelocityTracker, this.mActivePointerId));
    }

    private boolean a(int i, int i2, int i3, int i4) {
        int left = this.aic.getLeft();
        int top = this.aic.getTop();
        int i5 = i - left;
        int i6 = i2 - top;
        if (i5 == 0 && i6 == 0) {
            this.aib.abortAnimation();
            bD(0);
            return false;
        }
        int i7 = this.duration;
        this.aib.startScroll(left, top, i5, i6, i7 == 0 ? b(this.aic, i5, i6, i3, i4) : i7);
        bD(2);
        return true;
    }

    private int b(View view, int i, int i2, int i3, int i4) {
        float f;
        float f2;
        float f3;
        float f4;
        int iC = c(i3, (int) this.ahY, (int) this.ahX);
        int iC2 = c(i4, (int) this.ahY, (int) this.ahX);
        int iAbs = Math.abs(i);
        int iAbs2 = Math.abs(i2);
        int iAbs3 = Math.abs(iC);
        int iAbs4 = Math.abs(iC2);
        int i5 = iAbs3 + iAbs4;
        int i6 = iAbs + iAbs2;
        if (iC != 0) {
            f = iAbs3;
            f2 = i5;
        } else {
            f = iAbs;
            f2 = i6;
        }
        float f5 = f / f2;
        if (iC2 != 0) {
            f3 = iAbs4;
            f4 = i5;
        } else {
            f3 = iAbs2;
            f4 = i6;
        }
        return (int) ((b(i, iC, 0) * f5) + (b(i2, iC2, this.ahM.vy()) * (f3 / f4)));
    }

    private int b(int i, int i2, int i3) {
        int iAbs;
        if (i == 0) {
            return 0;
        }
        int width = this.ahN.getWidth();
        float f = width / 2;
        float fL = f + (l(Math.min(1.0f, Math.abs(i) / width)) * f);
        int iAbs2 = Math.abs(i2);
        if (iAbs2 > 0) {
            iAbs = Math.round(Math.abs(fL / iAbs2) * 1000.0f) * 4;
        } else {
            iAbs = (int) (((Math.abs(i) / i3) + 1.0f) * 256.0f);
        }
        return Math.min(iAbs, 600);
    }

    private static int c(int i, int i2, int i3) {
        int iAbs = Math.abs(i);
        if (iAbs < i2) {
            return 0;
        }
        if (iAbs > i3) {
            return i > 0 ? i3 : -i3;
        }
        return i;
    }

    private static float a(float f, float f2, float f3) {
        float fAbs = Math.abs(f);
        if (fAbs < f2) {
            return 0.0f;
        }
        if (fAbs > f3) {
            return f > 0.0f ? f3 : -f3;
        }
        return f;
    }

    private static float l(float f) {
        return (float) Math.sin((float) (((double) (f - 0.5f)) * 0.4712389167638204d));
    }

    public final boolean continueSettling(boolean z) {
        if (this.ahO == 2) {
            boolean zComputeScrollOffset = this.aib.computeScrollOffset();
            int currX = this.aib.getCurrX();
            int currY = this.aib.getCurrY();
            int left = currX - this.aic.getLeft();
            int top = currY - this.aic.getTop();
            if (left != 0) {
                ViewCompat.offsetLeftAndRight(this.aic, left);
            }
            if (top != 0) {
                ViewCompat.offsetTopAndBottom(this.aic, top);
            }
            if (left != 0 || top != 0) {
                this.ahM.bx(currY);
            }
            if (zComputeScrollOffset && currX == this.aib.getFinalX() && currY == this.aib.getFinalY()) {
                this.aib.abortAnimation();
                zComputeScrollOffset = false;
            }
            if (!zComputeScrollOffset) {
                this.ahN.post(this.aid);
            }
        }
        return this.ahO == 2;
    }

    private void g(float f, float f2) {
        this.aie = true;
        this.ahM.onViewReleased(this.aic, f, f2);
        this.aie = false;
        if (this.ahO == 1) {
            bD(0);
        }
    }

    private void vB() {
        float[] fArr = this.ahP;
        if (fArr == null) {
            return;
        }
        Arrays.fill(fArr, 0.0f);
        Arrays.fill(this.ahQ, 0.0f);
        Arrays.fill(this.ahR, 0.0f);
        Arrays.fill(this.ahS, 0.0f);
        Arrays.fill(this.ahT, 0);
        Arrays.fill(this.ahU, 0);
        Arrays.fill(this.ahV, 0);
        this.ahW = 0;
    }

    private void bB(int i) {
        float[] fArr = this.ahP;
        if (fArr == null) {
            return;
        }
        fArr[i] = 0.0f;
        this.ahQ[i] = 0.0f;
        this.ahR[i] = 0.0f;
        this.ahS[i] = 0.0f;
        this.ahT[i] = 0;
        this.ahU[i] = 0;
        this.ahV[i] = 0;
        this.ahW = (~(1 << i)) & this.ahW;
    }

    private void bC(int i) {
        float[] fArr = this.ahP;
        if (fArr == null || fArr.length <= i) {
            int i2 = i + 1;
            float[] fArr2 = new float[i2];
            float[] fArr3 = new float[i2];
            float[] fArr4 = new float[i2];
            float[] fArr5 = new float[i2];
            int[] iArr = new int[i2];
            int[] iArr2 = new int[i2];
            int[] iArr3 = new int[i2];
            if (fArr != null) {
                System.arraycopy(fArr, 0, fArr2, 0, fArr.length);
                float[] fArr6 = this.ahQ;
                System.arraycopy(fArr6, 0, fArr3, 0, fArr6.length);
                float[] fArr7 = this.ahR;
                System.arraycopy(fArr7, 0, fArr4, 0, fArr7.length);
                float[] fArr8 = this.ahS;
                System.arraycopy(fArr8, 0, fArr5, 0, fArr8.length);
                int[] iArr4 = this.ahT;
                System.arraycopy(iArr4, 0, iArr, 0, iArr4.length);
                int[] iArr5 = this.ahU;
                System.arraycopy(iArr5, 0, iArr2, 0, iArr5.length);
                int[] iArr6 = this.ahV;
                System.arraycopy(iArr6, 0, iArr3, 0, iArr6.length);
            }
            this.ahP = fArr2;
            this.ahQ = fArr3;
            this.ahR = fArr4;
            this.ahS = fArr5;
            this.ahT = iArr;
            this.ahU = iArr2;
            this.ahV = iArr3;
        }
    }

    private void a(float f, float f2, int i) {
        bC(i);
        float[] fArr = this.ahP;
        this.ahR[i] = f;
        fArr[i] = f;
        float[] fArr2 = this.ahQ;
        this.ahS[i] = f2;
        fArr2[i] = f2;
        this.ahT[i] = p((int) f, (int) f2);
        this.ahW |= 1 << i;
    }

    private void i(MotionEvent motionEvent) {
        int pointerCount = MotionEventCompat.getPointerCount(motionEvent);
        for (int i = 0; i < pointerCount; i++) {
            int pointerId = MotionEventCompat.getPointerId(motionEvent, i);
            float x = MotionEventCompat.getX(motionEvent, i);
            float y = MotionEventCompat.getY(motionEvent, i);
            this.ahR[pointerId] = x;
            this.ahS[pointerId] = y;
        }
    }

    private boolean isPointerDown(int i) {
        return ((1 << i) & this.ahW) != 0;
    }

    final void bD(int i) {
        this.ahN.removeCallbacks(this.aid);
        if (this.ahO != i) {
            this.ahO = i;
            this.ahM.onViewDragStateChanged(i);
            if (this.ahO == 0) {
                this.aic = null;
            }
        }
    }

    private boolean m(View view, int i) {
        if (view == this.aic && this.mActivePointerId == i) {
            return true;
        }
        if (view == null || !this.ahM.tryCaptureView(view, i)) {
            return false;
        }
        this.mActivePointerId = i;
        captureChildView(view, i);
        return true;
    }

    /* JADX WARN: Code duplicated, block: B:45:0x00bd  */
    /* JADX WARN: Code duplicated, block: B:52:0x00d3  */
    public final boolean shouldInterceptTouchEvent(MotionEvent motionEvent) {
        View viewFindTopChildUnder;
        int actionMasked = MotionEventCompat.getActionMasked(motionEvent);
        int actionIndex = MotionEventCompat.getActionIndex(motionEvent);
        if (actionMasked == 0) {
            cancel();
        }
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        if (actionMasked == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            int pointerId = MotionEventCompat.getPointerId(motionEvent, 0);
            a(x, y, pointerId);
            View viewFindTopChildUnder2 = findTopChildUnder((int) x, (int) y);
            if (viewFindTopChildUnder2 == this.aic && this.ahO == 2) {
                m(viewFindTopChildUnder2, pointerId);
            }
            int i = this.ahT[pointerId];
        } else if (actionMasked == 1) {
            cancel();
        } else if (actionMasked != 2) {
            if (actionMasked == 3) {
                cancel();
            } else if (actionMasked == 5) {
                int pointerId2 = MotionEventCompat.getPointerId(motionEvent, actionIndex);
                float x2 = MotionEventCompat.getX(motionEvent, actionIndex);
                float y2 = MotionEventCompat.getY(motionEvent, actionIndex);
                a(x2, y2, pointerId2);
                int i2 = this.ahO;
                if (i2 != 0 && i2 == 2 && (viewFindTopChildUnder = findTopChildUnder((int) x2, (int) y2)) == this.aic) {
                    m(viewFindTopChildUnder, pointerId2);
                }
            } else if (actionMasked == 6) {
                bB(MotionEventCompat.getPointerId(motionEvent, actionIndex));
            }
        } else if (this.ahP != null && this.ahQ != null) {
            int pointerCount = MotionEventCompat.getPointerCount(motionEvent);
            for (int i3 = 0; i3 < pointerCount; i3++) {
                int pointerId3 = MotionEventCompat.getPointerId(motionEvent, i3);
                if (bE(pointerId3)) {
                    float x3 = MotionEventCompat.getX(motionEvent, i3);
                    float y3 = MotionEventCompat.getY(motionEvent, i3);
                    float f = x3 - this.ahP[pointerId3];
                    float f2 = y3 - this.ahQ[pointerId3];
                    View viewFindTopChildUnder3 = findTopChildUnder((int) x3, (int) y3);
                    boolean z = viewFindTopChildUnder3 != null && a(viewFindTopChildUnder3, f, f2);
                    if (z) {
                        viewFindTopChildUnder3.getLeft();
                        this.ahM.E(viewFindTopChildUnder3);
                        int top = viewFindTopChildUnder3.getTop();
                        int iBy = this.ahM.by(((int) f2) + top);
                        int iVy = this.ahM.vy();
                        if (iVy == 0 || (iVy > 0 && iBy == top)) {
                            break;
                        }
                        b(f, f2, pointerId3);
                        if (this.ahO == 1 || (z && m(viewFindTopChildUnder3, pointerId3))) {
                            break;
                        }
                    } else {
                        b(f, f2, pointerId3);
                        if (this.ahO == 1) {
                            break;
                        }
                        break;
                        break;
                    }
                }
            }
            i(motionEvent);
        }
        return this.ahO == 1;
    }

    public final void processTouchEvent(MotionEvent motionEvent) {
        float x;
        int i;
        int actionMasked = MotionEventCompat.getActionMasked(motionEvent);
        int actionIndex = MotionEventCompat.getActionIndex(motionEvent);
        if (actionMasked == 0) {
            cancel();
        }
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        int i2 = 0;
        if (actionMasked == 0) {
            float x2 = motionEvent.getX();
            float y = motionEvent.getY();
            int pointerId = MotionEventCompat.getPointerId(motionEvent, 0);
            View viewFindTopChildUnder = findTopChildUnder((int) x2, (int) y);
            a(x2, y, pointerId);
            m(viewFindTopChildUnder, pointerId);
            int i3 = this.ahT[pointerId];
            return;
        }
        if (actionMasked == 1) {
            if (this.ahO == 1) {
                vC();
            }
            cancel();
            return;
        }
        float y2 = 0.0f;
        if (actionMasked == 2) {
            if (this.ahO == 1) {
                if (bE(this.mActivePointerId)) {
                    int iFindPointerIndex = MotionEventCompat.findPointerIndex(motionEvent, this.mActivePointerId);
                    try {
                        x = MotionEventCompat.getX(motionEvent, iFindPointerIndex);
                        try {
                            y2 = MotionEventCompat.getY(motionEvent, iFindPointerIndex);
                        } catch (IllegalArgumentException unused) {
                        }
                    } catch (IllegalArgumentException unused2) {
                        x = 0.0f;
                    }
                    float[] fArr = this.ahR;
                    int i4 = this.mActivePointerId;
                    int i5 = (int) (x - fArr[i4]);
                    int i6 = (int) (y2 - this.ahS[i4]);
                    b(this.aic.getLeft() + i5, this.aic.getTop() + i6, i5, i6);
                    i(motionEvent);
                    return;
                }
                return;
            }
            int pointerCount = MotionEventCompat.getPointerCount(motionEvent);
            while (i2 < pointerCount) {
                int pointerId2 = MotionEventCompat.getPointerId(motionEvent, i2);
                if (bE(pointerId2)) {
                    float x3 = MotionEventCompat.getX(motionEvent, i2);
                    float y3 = MotionEventCompat.getY(motionEvent, i2);
                    float f = x3 - this.ahP[pointerId2];
                    float f2 = y3 - this.ahQ[pointerId2];
                    b(f, f2, pointerId2);
                    if (this.ahO == 1) {
                        break;
                    }
                    View viewFindTopChildUnder2 = findTopChildUnder((int) x3, (int) y3);
                    if (a(viewFindTopChildUnder2, f, f2) && m(viewFindTopChildUnder2, pointerId2)) {
                        break;
                    }
                }
                i2++;
            }
            i(motionEvent);
            return;
        }
        if (actionMasked == 3) {
            if (this.ahO == 1) {
                g(0.0f, 0.0f);
            }
            cancel();
            return;
        }
        if (actionMasked == 5) {
            int pointerId3 = MotionEventCompat.getPointerId(motionEvent, actionIndex);
            float x4 = MotionEventCompat.getX(motionEvent, actionIndex);
            float y4 = MotionEventCompat.getY(motionEvent, actionIndex);
            a(x4, y4, pointerId3);
            if (this.ahO == 0) {
                m(findTopChildUnder((int) x4, (int) y4), pointerId3);
                return;
            } else {
                if (isCapturedViewUnder((int) x4, (int) y4)) {
                    m(this.aic, pointerId3);
                    return;
                }
                return;
            }
        }
        if (actionMasked != 6) {
            return;
        }
        int pointerId4 = MotionEventCompat.getPointerId(motionEvent, actionIndex);
        if (this.ahO == 1 && pointerId4 == this.mActivePointerId) {
            int pointerCount2 = MotionEventCompat.getPointerCount(motionEvent);
            while (true) {
                if (i2 >= pointerCount2) {
                    i = -1;
                    break;
                }
                int pointerId5 = MotionEventCompat.getPointerId(motionEvent, i2);
                if (pointerId5 != this.mActivePointerId) {
                    View viewFindTopChildUnder3 = findTopChildUnder((int) MotionEventCompat.getX(motionEvent, i2), (int) MotionEventCompat.getY(motionEvent, i2));
                    View view = this.aic;
                    if (viewFindTopChildUnder3 == view && m(view, pointerId5)) {
                        i = this.mActivePointerId;
                        break;
                    }
                }
                i2++;
            }
            if (i == -1) {
                vC();
            }
        }
        bB(pointerId4);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v11 */
    /* JADX WARN: Type inference failed for: r0v12 */
    /* JADX WARN: Type inference failed for: r0v13 */
    /* JADX WARN: Type inference failed for: r0v14 */
    /* JADX WARN: Type inference failed for: r0v15 */
    /* JADX WARN: Type inference failed for: r0v16 */
    /* JADX WARN: Type inference failed for: r0v2 */
    /* JADX WARN: Type inference failed for: r0v3 */
    /* JADX WARN: Type inference failed for: r0v4 */
    /* JADX WARN: Type inference failed for: r4v2 */
    private void b(float f, float f2, int i) {
        int i2;
        boolean zA = a(f, f2, i, 1);
        ?? r0 = zA;
        if (a(f2, f, i, 4)) {
            r0 = (zA ? 1 : 0) | 4;
        }
        ?? r1 = r0;
        if (a(f, f2, i, 2)) {
            r1 = (r0 == true ? 1 : 0) | 2;
        }
        ?? r2 = r1;
        if (a(f2, f, i, 8)) {
            i2 = (r1 == true ? 1 : 0) | 8;
        }
        if (r2 == 0) {
            r2 = i2;
            return;
        }
        r2 = i2;
        int[] iArr = this.ahU;
        iArr[i] = (iArr[i] | r2) == true ? 1 : 0;
    }

    private boolean a(float f, float f2, int i, int i2) {
        float fAbs = Math.abs(f);
        float fAbs2 = Math.abs(f2);
        if ((this.ahT[i] & i2) == i2 && (this.aia & i2) != 0 && (this.ahV[i] & i2) != i2) {
            int i3 = this.ahU[i];
            if ((i3 & i2) != i2) {
                int i4 = this.mTouchSlop;
                if ((fAbs > i4 || fAbs2 > i4) && (i3 & i2) == 0 && fAbs > i4) {
                    return true;
                }
            }
        }
        return false;
    }

    private boolean a(View view, float f, float f2) {
        if (view == null) {
            return false;
        }
        return (this.ahM.vy() > 0) && Math.abs(f2) > ((float) this.mTouchSlop);
    }

    private void vC() {
        this.mVelocityTracker.computeCurrentVelocity(1000, this.ahX);
        g(a(VelocityTrackerCompat.getXVelocity(this.mVelocityTracker, this.mActivePointerId), this.ahY, this.ahX), a(VelocityTrackerCompat.getYVelocity(this.mVelocityTracker, this.mActivePointerId), this.ahY, this.ahX));
    }

    private void b(int i, int i2, int i3, int i4) {
        int left = this.aic.getLeft();
        int top = this.aic.getTop();
        if (i3 != 0) {
            ViewCompat.offsetLeftAndRight(this.aic, this.ahM.E(this.aic) - left);
        }
        if (i4 != 0) {
            i2 = this.ahM.by(i2);
            ViewCompat.offsetTopAndBottom(this.aic, i2 - top);
        }
        if (i3 == 0 && i4 == 0) {
            return;
        }
        this.ahM.bx(i2);
    }

    private boolean isCapturedViewUnder(int i, int i2) {
        return isViewUnder(this.aic, i, i2);
    }

    private static boolean isViewUnder(View view, int i, int i2) {
        return view != null && i >= view.getLeft() && i < view.getRight() && i2 >= view.getTop() && i2 < view.getBottom();
    }

    private View findTopChildUnder(int i, int i2) {
        for (int childCount = this.ahN.getChildCount() - 1; childCount >= 0; childCount--) {
            View childAt = this.ahN.getChildAt(a.getOrderedChildIndex(childCount));
            if (i >= childAt.getLeft() && i < childAt.getRight() && i2 >= childAt.getTop() && i2 < childAt.getBottom()) {
                return childAt;
            }
        }
        return null;
    }

    private int p(int i, int i2) {
        int i3 = i < this.ahN.getLeft() + this.ahZ ? 1 : 0;
        if (i2 < this.ahN.getTop() + this.ahZ) {
            i3 |= 4;
        }
        if (i > this.ahN.getRight() - this.ahZ) {
            i3 |= 2;
        }
        return i2 > this.ahN.getBottom() - this.ahZ ? i3 | 8 : i3;
    }

    private boolean bE(int i) {
        if (isPointerDown(i)) {
            return true;
        }
        Log.e("ViewDragHelper", "Ignoring pointerId=" + i + " because ACTION_DOWN was not received for this pointer before ACTION_MOVE. It likely happened because  ViewDragHelper did not receive all the events in the event stream.");
        return false;
    }
}
