package com.kwad.components.core.page.widget.a;

import android.os.Parcel;
import android.os.Parcelable;
import android.view.MotionEvent;
import android.view.VelocityTracker;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import androidx.core.math.MathUtils;
import androidx.core.view.ViewCompat;
import androidx.customview.view.AbsSavedState;
import com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout;
import java.lang.ref.WeakReference;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class c<V extends View> extends KSCoordinatorLayout.Behavior<V> {
    private float agO;
    private int agP;
    private boolean agQ;
    private int agR;
    protected int agS;
    private int agT;
    private int agU;
    protected int agV;
    private float agW;
    private boolean agX;
    private boolean agY;
    protected i agZ;
    private boolean aha;
    private boolean ahb;
    private int ahc;
    private boolean ahd;
    private int ahe;
    private WeakReference<V> ahf;
    protected WeakReference<View> ahg;
    private a ahh;
    protected int ahi;
    private boolean ahj;
    private Map<View, Integer> ahk;
    protected boolean ahp;
    private c<V>.RunnableC0455c ahq;
    private int mActivePointerId;
    private VelocityTracker mVelocityTracker;
    private boolean agN = true;
    private int mState = 4;
    protected float ahl = 1.0f;
    protected float ahm = 1.0f;
    protected float ahn = 0.5f;
    protected float aho = 0.5f;
    private final i.a ahr = new i.a() { // from class: com.kwad.components.core.page.widget.a.c.2
        @Override // com.kwad.components.core.page.widget.a.i.a
        public final boolean tryCaptureView(View view, int i) {
            View view2;
            if (c.this.mState == 1 || c.this.ahj) {
                return false;
            }
            return ((c.this.mState == 3 && c.this.mActivePointerId == i && (view2 = c.this.ahg.get()) != null && view2.canScrollVertically(-1)) || c.this.ahf == null || c.this.ahf.get() != view) ? false : true;
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final void bx(int i) {
            c.this.bw(i);
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final void onViewDragStateChanged(int i) {
            if (i == 1) {
                c.this.bu(1);
            }
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final void onViewReleased(View view, float f, float f2) {
            int iVx = 0;
            int i = 6;
            if (f2 < 0.0f) {
                if (!c.this.agN) {
                    if (view.getTop() > c.this.agU) {
                        iVx = c.this.agU;
                    }
                } else if (c.this.e(view, f2)) {
                    iVx = c.this.agT;
                } else {
                    iVx = c.this.agV;
                    i = 4;
                }
                i = 3;
            } else if (c.this.agX && c.this.d(view, f2) && (view.getTop() > c.this.agV || Math.abs(f) < Math.abs(f2))) {
                iVx = c.this.ahe;
                i = 5;
            } else if (f2 == 0.0f || Math.abs(f) > Math.abs(f2)) {
                int top = view.getTop();
                if (!c.this.agN) {
                    if (top < c.this.agU) {
                        if (top < Math.abs(top - c.this.agV)) {
                            i = 3;
                        } else {
                            iVx = c.this.agU;
                        }
                    } else if (Math.abs(top - c.this.agU) < Math.abs(top - c.this.agV)) {
                        iVx = c.this.agU;
                    } else {
                        iVx = c.this.agV;
                        i = 4;
                    }
                } else if (c.this.e(view, f2)) {
                    iVx = c.this.agT;
                    i = 3;
                } else {
                    iVx = c.this.agV;
                    i = 4;
                }
            } else if (c.this.e(view, f2)) {
                iVx = c.this.vx();
                i = 3;
            } else {
                iVx = c.this.agV;
                i = 4;
            }
            if (c.this.agZ.settleCapturedViewAt(view.getLeft(), iVx)) {
                c.this.bu(2);
                c.this.ahq = new RunnableC0455c(view, i);
                ViewCompat.postOnAnimation(view, c.this.ahq);
                return;
            }
            c.this.bu(i);
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final int by(int i) {
            return MathUtils.clamp(i, c.this.vx(), c.this.agX ? c.this.ahe : c.this.agV);
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final int E(View view) {
            return view.getLeft();
        }

        @Override // com.kwad.components.core.page.widget.a.i.a
        public final int vy() {
            if (c.this.agX) {
                return c.this.ahe;
            }
            return c.this.agV;
        }
    };

    public interface a {
        void bq(int i);

        void i(float f);
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final Parcelable onSaveInstanceState(KSCoordinatorLayout kSCoordinatorLayout, V v) {
        return new b(super.onSaveInstanceState(kSCoordinatorLayout, v), this.mState);
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final void onRestoreInstanceState(KSCoordinatorLayout kSCoordinatorLayout, V v, Parcelable parcelable) {
        b bVar = (b) parcelable;
        super.onRestoreInstanceState(kSCoordinatorLayout, v, bVar.getSuperState());
        if (bVar.mState == 1 || bVar.mState == 2) {
            this.mState = 4;
        } else {
            this.mState = bVar.mState;
        }
        bv(this.mState);
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final boolean onLayoutChild(KSCoordinatorLayout kSCoordinatorLayout, V v, int i) {
        if (ViewCompat.getFitsSystemWindows(kSCoordinatorLayout) && !ViewCompat.getFitsSystemWindows(v)) {
            v.setFitsSystemWindows(true);
        }
        int top = v.getTop();
        kSCoordinatorLayout.onLayoutChild(v, i);
        int height = kSCoordinatorLayout.getHeight();
        this.ahe = height;
        if (this.agQ) {
            if (this.agR == 0) {
                this.agR = 64;
            }
            this.agS = Math.max(this.agR, height - ((kSCoordinatorLayout.getWidth() * 9) / 16));
        } else {
            this.agS = this.agP;
        }
        this.agT = Math.max(0, this.ahe - v.getHeight());
        this.agU = this.ahe / 2;
        vw();
        v.getTop();
        int i2 = this.mState;
        if (i2 == 3) {
            ViewCompat.offsetTopAndBottom(v, vx());
        } else if (i2 == 6) {
            ViewCompat.offsetTopAndBottom(v, this.agU);
        } else if (this.agX && i2 == 5) {
            ViewCompat.offsetTopAndBottom(v, this.ahe);
        } else if (i2 == 4) {
            ViewCompat.offsetTopAndBottom(v, this.agV);
        } else if (i2 == 1 || i2 == 2) {
            ViewCompat.offsetTopAndBottom(v, top - v.getTop());
        }
        if (this.agZ == null) {
            this.agZ = i.a(kSCoordinatorLayout, this.ahr);
        }
        this.ahf = new WeakReference<>(v);
        this.ahg = new WeakReference<>(D(v));
        return true;
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final boolean onInterceptTouchEvent(KSCoordinatorLayout kSCoordinatorLayout, V v, MotionEvent motionEvent) {
        i iVar;
        if (!v.isShown()) {
            this.aha = true;
            return false;
        }
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked == 0) {
            reset();
        }
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        if (actionMasked == 0) {
            int x = (int) motionEvent.getX();
            this.ahi = (int) motionEvent.getY();
            WeakReference<View> weakReference = this.ahg;
            View view = weakReference != null ? weakReference.get() : null;
            if (view != null && kSCoordinatorLayout.isPointInChildBounds(view, x, this.ahi)) {
                this.mActivePointerId = motionEvent.getPointerId(motionEvent.getActionIndex());
                this.ahj = true;
            }
            this.aha = (this.ahb || this.mActivePointerId != -1 || kSCoordinatorLayout.isPointInChildBounds(v, x, this.ahi)) ? false : true;
        } else if (actionMasked == 1 || actionMasked == 3) {
            this.ahj = false;
            this.mActivePointerId = -1;
            if (this.aha) {
                this.aha = false;
                return false;
            }
        }
        if (!this.aha && (iVar = this.agZ) != null && iVar.shouldInterceptTouchEvent(motionEvent)) {
            return true;
        }
        WeakReference<View> weakReference2 = this.ahg;
        View view2 = weakReference2 != null ? weakReference2.get() : null;
        return (actionMasked != 2 || view2 == null || this.aha || this.mState == 1 || kSCoordinatorLayout.isPointInChildBounds(view2, (int) motionEvent.getX(), (int) motionEvent.getY()) || this.agZ == null || Math.abs(((float) this.ahi) - motionEvent.getY()) <= ((float) this.agZ.getTouchSlop())) ? false : true;
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final boolean onTouchEvent(KSCoordinatorLayout kSCoordinatorLayout, V v, MotionEvent motionEvent) {
        if (!v.isShown()) {
            return false;
        }
        int actionMasked = motionEvent.getActionMasked();
        if (this.mState == 1 && actionMasked == 0) {
            return true;
        }
        i iVar = this.agZ;
        if (iVar != null) {
            iVar.processTouchEvent(motionEvent);
        }
        if (actionMasked == 0) {
            reset();
        }
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        if (actionMasked == 2 && !this.aha && this.agZ != null && Math.abs(this.ahi - motionEvent.getY()) > this.agZ.getTouchSlop()) {
            this.agZ.captureChildView(v, motionEvent.getPointerId(motionEvent.getActionIndex()));
        }
        return !this.aha;
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final boolean onStartNestedScroll(KSCoordinatorLayout kSCoordinatorLayout, V v, View view, View view2, int i, int i2) {
        this.ahc = 0;
        this.ahd = false;
        return (i & 2) != 0;
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final void onNestedPreScroll(KSCoordinatorLayout kSCoordinatorLayout, V v, View view, int i, int i2, int[] iArr, int i3) {
        if (i3 != 1 && view == this.ahg.get()) {
            int top = v.getTop();
            int i4 = top - i2;
            if (i2 > 0) {
                if (i4 < vx()) {
                    int iVx = top - vx();
                    iArr[1] = iVx;
                    ViewCompat.offsetTopAndBottom(v, -iVx);
                    bu(3);
                } else {
                    iArr[1] = i2;
                    ViewCompat.offsetTopAndBottom(v, -i2);
                    bu(1);
                }
            } else if (i2 < 0 && !view.canScrollVertically(-1)) {
                int i5 = this.agV;
                if (i4 <= i5 || this.agX) {
                    iArr[1] = i2;
                    ViewCompat.offsetTopAndBottom(v, -i2);
                    bu(1);
                } else {
                    int i6 = top - i5;
                    iArr[1] = i6;
                    ViewCompat.offsetTopAndBottom(v, -i6);
                    bu(4);
                }
            }
            bw(v.getTop());
            this.ahc = i2;
            this.ahd = true;
        }
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final void onStopNestedScroll(KSCoordinatorLayout kSCoordinatorLayout, V v, View view, int i) {
        int iVx;
        int i2 = 3;
        if (v.getTop() == vx()) {
            bu(3);
            return;
        }
        if (this.ahh != null) {
            this.ahg.get();
        }
        if (view == this.ahg.get() && this.ahd) {
            if (this.ahc > 0) {
                if (e(v, getYVelocity())) {
                    iVx = vx();
                } else {
                    iVx = this.agV;
                    i2 = 4;
                }
            } else if (this.agX && d(v, getYVelocity())) {
                iVx = this.ahe;
                i2 = 5;
            } else if (this.ahc == 0) {
                int top = v.getTop();
                if (this.agN) {
                    if (e(v, getYVelocity())) {
                        iVx = this.agT;
                    } else {
                        iVx = this.agV;
                        i2 = 4;
                    }
                } else {
                    int i3 = this.agU;
                    if (top < i3) {
                        if (top < Math.abs(top - this.agV)) {
                            iVx = 0;
                        } else {
                            iVx = this.agU;
                        }
                    } else if (Math.abs(top - i3) < Math.abs(top - this.agV)) {
                        iVx = this.agU;
                    } else {
                        iVx = this.agV;
                        i2 = 4;
                    }
                    i2 = 6;
                }
            } else if (e(v, getYVelocity())) {
                iVx = vx();
            } else {
                iVx = this.agV;
                i2 = 4;
            }
            if (this.agZ.smoothSlideViewTo(v, v.getLeft(), iVx)) {
                bu(2);
                ViewCompat.postOnAnimation(v, new RunnableC0455c(v, i2));
            } else {
                bu(i2);
            }
            this.ahd = false;
        }
    }

    @Override // com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout.Behavior
    public final boolean onNestedPreFling(KSCoordinatorLayout kSCoordinatorLayout, V v, View view, float f, float f2) {
        if (view == this.ahg.get()) {
            return this.mState != 3 || super.onNestedPreFling(kSCoordinatorLayout, v, view, f, f2);
        }
        return false;
    }

    /* JADX WARN: Code duplicated, block: B:12:0x0015  */
    public final void bt(int i) {
        WeakReference<V> weakReference;
        V v;
        boolean z = true;
        if (i == -1) {
            if (this.agQ) {
                z = false;
            } else {
                this.agQ = true;
            }
        } else if (this.agQ || this.agP != i) {
            this.agQ = false;
            this.agP = Math.max(0, i);
            this.agV = this.ahe - i;
        } else {
            z = false;
        }
        if (!z || this.mState != 4 || (weakReference = this.ahf) == null || (v = weakReference.get()) == null) {
            return;
        }
        v.requestLayout();
    }

    public final void aW(boolean z) {
        this.agX = true;
    }

    public final void a(a aVar) {
        this.ahh = aVar;
    }

    public final void setState(final int i) {
        if (i == this.mState) {
            return;
        }
        WeakReference<V> weakReference = this.ahf;
        if (weakReference == null) {
            if (i == 4 || i == 3 || i == 6 || (this.agX && i == 5)) {
                this.mState = i;
                bv(i);
                return;
            }
            return;
        }
        final V v = weakReference.get();
        if (v == null) {
            return;
        }
        ViewParent parent = v.getParent();
        if (parent != null && parent.isLayoutRequested() && ViewCompat.isAttachedToWindow(v)) {
            v.post(new Runnable() { // from class: com.kwad.components.core.page.widget.a.c.1
                @Override // java.lang.Runnable
                public final void run() {
                    c.this.l(v, i);
                }
            });
        } else {
            l(v, i);
        }
    }

    final void bu(int i) {
        a aVar;
        if (this.mState == i) {
            return;
        }
        this.mState = i;
        bv(i);
        if (i == 6 || i == 3) {
            aX(true);
        } else if (i == 5 || i == 4) {
            aX(false);
        }
        if (this.ahf.get() == null || (aVar = this.ahh) == null) {
            return;
        }
        aVar.bq(i);
    }

    private void vw() {
        if (this.agN) {
            this.agV = Math.max(this.ahe - this.agS, this.agT);
        } else {
            this.agV = this.ahe - this.agS;
        }
    }

    private void reset() {
        this.mActivePointerId = -1;
        VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker != null) {
            velocityTracker.recycle();
            this.mVelocityTracker = null;
        }
    }

    protected final boolean d(View view, float f) {
        if (this.agY) {
            return true;
        }
        return view.getTop() >= this.agV && Math.abs((((float) view.getTop()) + (f * 0.1f)) - ((float) this.agV)) / ((float) this.agP) > this.aho;
    }

    protected final boolean e(View view, float f) {
        if (view.getTop() > this.agV) {
            return false;
        }
        int iVx = vx();
        float f2 = iVx;
        float fMax = Math.max(f2, view.getTop() + (f * (this.ahp ? this.ahm : this.ahl)));
        if (fMax == f2) {
            return true;
        }
        int i = this.agV;
        int i2 = i - iVx;
        if (!this.ahp) {
            f2 = i;
        }
        float fAbs = Math.abs(fMax - f2) / i2;
        if (this.ahp) {
            return fAbs <= this.aho;
        }
        return fAbs >= this.ahn;
    }

    private void bv(int i) {
        if (i == 3) {
            this.ahp = true;
        } else if (i == 4 || i == 5 || i == 6) {
            this.ahp = false;
        }
    }

    private View D(View view) {
        if (ViewCompat.isNestedScrollingEnabled(view)) {
            if (view.getVisibility() == 0) {
                return view;
            }
            return null;
        }
        if (view instanceof ViewGroup) {
            ViewGroup viewGroup = (ViewGroup) view;
            int childCount = viewGroup.getChildCount();
            for (int i = 0; i < childCount; i++) {
                View viewD = D(viewGroup.getChildAt(i));
                if (viewD != null) {
                    return viewD;
                }
            }
        }
        return null;
    }

    private float getYVelocity() {
        VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker == null) {
            return 0.0f;
        }
        velocityTracker.computeCurrentVelocity(1000, this.agO);
        return this.mVelocityTracker.getYVelocity(this.mActivePointerId);
    }

    public final int vx() {
        if (this.agN) {
            return this.agT;
        }
        return 0;
    }

    final void l(View view, int i) {
        int iVx;
        int i2;
        if (i == 4) {
            iVx = this.agV;
        } else if (i == 6) {
            iVx = this.agU;
            if (this.agN && iVx <= (i2 = this.agT)) {
                i = 3;
                iVx = i2;
            }
        } else if (i == 3) {
            iVx = vx();
        } else if (this.agX && i == 5) {
            iVx = this.ahe;
        } else {
            throw new IllegalArgumentException("Illegal mState argument: " + i);
        }
        if (this.agZ.smoothSlideViewTo(view, view.getLeft(), iVx)) {
            bu(2);
            ViewCompat.postOnAnimation(view, new RunnableC0455c(view, i));
        } else {
            bu(i);
        }
    }

    final void bw(int i) {
        int iVx;
        if (this.ahf.get() == null || this.ahh == null) {
            return;
        }
        int i2 = this.agV;
        if (i > i2) {
            iVx = this.ahe - i2;
        } else {
            iVx = i2 - vx();
        }
        if (iVx != 0) {
            this.agW = (this.agV - i) / iVx;
        }
        this.ahh.i(this.agW);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.page.widget.a.c$c, reason: collision with other inner class name */
    class RunnableC0455c implements Runnable {
        private final int ahv;
        private final View mView;

        RunnableC0455c(View view, int i) {
            this.mView = view;
            this.ahv = i;
        }

        @Override // java.lang.Runnable
        public final void run() {
            if (c.this.agZ != null && c.this.agZ.continueSettling(true)) {
                ViewCompat.postOnAnimation(this.mView, this);
                return;
            }
            c.this.bu(this.ahv);
            if (c.this.ahq == this) {
                c.this.ahq = null;
            }
        }
    }

    protected static class b extends AbsSavedState {
        public static final Parcelable.Creator<b> CREATOR = new Parcelable.ClassLoaderCreator<b>() { // from class: com.kwad.components.core.page.widget.a.c.b.1
            @Override // android.os.Parcelable.Creator
            public final /* synthetic */ Object createFromParcel(Parcel parcel) {
                return a(parcel);
            }

            @Override // android.os.Parcelable.ClassLoaderCreator
            public final /* synthetic */ b createFromParcel(Parcel parcel, ClassLoader classLoader) {
                return a(parcel, classLoader);
            }

            @Override // android.os.Parcelable.Creator
            public final /* synthetic */ Object[] newArray(int i) {
                return bz(i);
            }

            private static b a(Parcel parcel, ClassLoader classLoader) {
                return new b(parcel, classLoader);
            }

            private static b a(Parcel parcel) {
                return new b(parcel, (ClassLoader) null);
            }

            private static b[] bz(int i) {
                return new b[i];
            }
        };
        final int mState;

        public b(Parcel parcel, ClassLoader classLoader) {
            super(parcel, classLoader);
            this.mState = parcel.readInt();
        }

        public b(Parcelable parcelable, int i) {
            super(parcelable);
            this.mState = i;
        }

        @Override // androidx.customview.view.AbsSavedState, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.mState);
        }
    }

    private void aX(boolean z) {
        WeakReference<V> weakReference = this.ahf;
        if (weakReference == null) {
            return;
        }
        ViewParent parent = weakReference.get().getParent();
        if (parent instanceof KSCoordinatorLayout) {
            KSCoordinatorLayout kSCoordinatorLayout = (KSCoordinatorLayout) parent;
            int childCount = kSCoordinatorLayout.getChildCount();
            if (z) {
                if (this.ahk != null) {
                    return;
                } else {
                    this.ahk = new HashMap(childCount);
                }
            }
            for (int i = 0; i < childCount; i++) {
                View childAt = kSCoordinatorLayout.getChildAt(i);
                if (childAt != this.ahf.get()) {
                    if (!z) {
                        Map<View, Integer> map = this.ahk;
                        if (map != null && map.containsKey(childAt)) {
                            ViewCompat.setImportantForAccessibility(childAt, this.ahk.get(childAt).intValue());
                        }
                    } else {
                        this.ahk.put(childAt, Integer.valueOf(childAt.getImportantForAccessibility()));
                        ViewCompat.setImportantForAccessibility(childAt, 4);
                    }
                }
            }
            if (z) {
                return;
            }
            this.ahk = null;
        }
    }

    public final void k(float f) {
        this.aho = 0.8f;
    }
}
