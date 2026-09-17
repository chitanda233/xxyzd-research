package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.os.Handler;
import android.os.Message;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.VelocityTracker;
import android.view.ViewConfiguration;
import com.kwad.sdk.utils.az;
import com.kwad.sdk.utils.cc;

/* JADX INFO: loaded from: classes3.dex */
public class d extends GestureDetector implements cc.a {
    private static final int Yu = ViewConfiguration.getLongPressTimeout();
    private static final int Yv = ViewConfiguration.getTapTimeout();
    public static final int Yw = ViewConfiguration.getDoubleTapTimeout();
    private boolean YA;
    private boolean YB;
    private boolean YC;
    private boolean YD;
    private boolean YE;
    private boolean YF;
    private MotionEvent YG;
    private MotionEvent YH;
    private boolean YI;
    private float YJ;
    private float YK;
    private float YL;
    private float YM;
    private boolean YN;
    private long YO;
    private int Yp;
    private int Yq;
    private int Yr;
    private int Ys;
    private int Yt;
    private final GestureDetector.OnGestureListener Yx;
    private GestureDetector.OnDoubleTapListener Yy;
    private boolean Yz;
    private final Handler jc;
    private VelocityTracker mVelocityTracker;

    public d(Context context, GestureDetector.OnGestureListener onGestureListener) {
        this(context, onGestureListener, null);
    }

    private d(Context context, GestureDetector.OnGestureListener onGestureListener, Handler handler) {
        super(context, onGestureListener, null);
        this.YO = Yw;
        this.jc = new cc(this);
        this.Yx = onGestureListener;
        if (onGestureListener instanceof GestureDetector.OnDoubleTapListener) {
            setOnDoubleTapListener((GestureDetector.OnDoubleTapListener) onGestureListener);
        }
        init(context);
    }

    private void init(Context context) {
        int scaledDoubleTapSlop;
        int touchSlop;
        az.checkNotNull(this.Yx);
        this.YN = true;
        int i = 300;
        if (context == null) {
            touchSlop = ViewConfiguration.getTouchSlop();
            this.Ys = ViewConfiguration.getMinimumFlingVelocity();
            this.Yt = ViewConfiguration.getMaximumFlingVelocity();
            scaledDoubleTapSlop = 300;
            i = touchSlop;
        } else {
            ViewConfiguration viewConfiguration = ViewConfiguration.get(context);
            int scaledTouchSlop = viewConfiguration.getScaledTouchSlop();
            scaledDoubleTapSlop = viewConfiguration.getScaledDoubleTapSlop();
            this.Ys = viewConfiguration.getScaledMinimumFlingVelocity();
            this.Yt = viewConfiguration.getScaledMaximumFlingVelocity();
            touchSlop = scaledTouchSlop;
        }
        this.Yp = touchSlop * touchSlop;
        this.Yq = i * i;
        this.Yr = scaledDoubleTapSlop * scaledDoubleTapSlop;
    }

    @Override // android.view.GestureDetector
    public void setOnDoubleTapListener(GestureDetector.OnDoubleTapListener onDoubleTapListener) {
        this.Yy = onDoubleTapListener;
    }

    @Override // android.view.GestureDetector
    public void setIsLongpressEnabled(boolean z) {
        this.YN = z;
    }

    @Override // android.view.GestureDetector
    public boolean isLongpressEnabled() {
        return this.YN;
    }

    @Override // android.view.GestureDetector
    public boolean onTouchEvent(MotionEvent motionEvent) {
        boolean zOnDoubleTap;
        MotionEvent motionEvent2;
        boolean zOnFling;
        GestureDetector.OnDoubleTapListener onDoubleTapListener;
        int action = motionEvent.getAction();
        if (this.mVelocityTracker == null) {
            this.mVelocityTracker = VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        int i = action & 255;
        boolean z = i == 6;
        int actionIndex = z ? motionEvent.getActionIndex() : -1;
        boolean z2 = (motionEvent.getFlags() & 8) != 0;
        int pointerCount = motionEvent.getPointerCount();
        float x = 0.0f;
        float y = 0.0f;
        for (int i2 = 0; i2 < pointerCount; i2++) {
            if (actionIndex != i2) {
                x += motionEvent.getX(i2);
                y += motionEvent.getY(i2);
            }
        }
        float f = z ? pointerCount - 1 : pointerCount;
        float f2 = x / f;
        float f3 = y / f;
        if (i == 0) {
            if (this.Yy == null) {
                zOnDoubleTap = false;
            } else {
                boolean zHasMessages = this.jc.hasMessages(3);
                if (zHasMessages) {
                    this.jc.removeMessages(3);
                }
                MotionEvent motionEvent3 = this.YG;
                if (motionEvent3 != null && (motionEvent2 = this.YH) != null && zHasMessages && a(motionEvent3, motionEvent2, motionEvent)) {
                    this.YI = true;
                    zOnDoubleTap = this.Yy.onDoubleTap(this.YG) | false | this.Yy.onDoubleTapEvent(motionEvent);
                } else {
                    this.jc.sendEmptyMessageDelayed(3, this.YO);
                    zOnDoubleTap = false;
                }
            }
            this.YJ = f2;
            this.YL = f2;
            this.YK = f3;
            this.YM = f3;
            MotionEvent motionEvent4 = this.YG;
            if (motionEvent4 != null) {
                motionEvent4.recycle();
            }
            this.YG = MotionEvent.obtain(motionEvent);
            this.YD = true;
            this.YE = true;
            this.Yz = true;
            this.YB = false;
            this.YA = false;
            if (this.YN) {
                this.jc.removeMessages(2);
                this.jc.sendEmptyMessageAtTime(2, this.YG.getDownTime() + ((long) Yu));
            }
            this.jc.sendEmptyMessageAtTime(1, this.YG.getDownTime() + ((long) Yv));
            return zOnDoubleTap | this.Yx.onDown(motionEvent);
        }
        if (i != 1) {
            if (i != 2) {
                if (i == 3) {
                    cancel();
                    return false;
                }
                if (i == 5) {
                    this.YJ = f2;
                    this.YL = f2;
                    this.YK = f3;
                    this.YM = f3;
                    tb();
                    return false;
                }
                if (i != 6) {
                    return false;
                }
                this.YJ = f2;
                this.YL = f2;
                this.YK = f3;
                this.YM = f3;
                this.mVelocityTracker.computeCurrentVelocity(1000, this.Yt);
                int actionIndex2 = motionEvent.getActionIndex();
                int pointerId = motionEvent.getPointerId(actionIndex2);
                float xVelocity = this.mVelocityTracker.getXVelocity(pointerId);
                float yVelocity = this.mVelocityTracker.getYVelocity(pointerId);
                for (int i3 = 0; i3 < pointerCount; i3++) {
                    if (i3 != actionIndex2) {
                        int pointerId2 = motionEvent.getPointerId(i3);
                        if ((this.mVelocityTracker.getXVelocity(pointerId2) * xVelocity) + (this.mVelocityTracker.getYVelocity(pointerId2) * yVelocity) < 0.0f) {
                            this.mVelocityTracker.clear();
                            return false;
                        }
                    }
                }
                return false;
            }
            if (this.YB || this.YC) {
                return false;
            }
            float f4 = this.YJ - f2;
            float f5 = this.YK - f3;
            if (this.YI) {
                return false | this.Yy.onDoubleTapEvent(motionEvent);
            }
            if (!this.YD) {
                if (Math.abs(f4) < 1.0f && Math.abs(f5) < 1.0f) {
                    return false;
                }
                boolean zOnScroll = this.Yx.onScroll(this.YG, motionEvent, f4, f5);
                this.YJ = f2;
                this.YK = f3;
                return zOnScroll;
            }
            int i4 = (int) (f2 - this.YL);
            int i5 = (int) (f3 - this.YM);
            int i6 = (i4 * i4) + (i5 * i5);
            if (i6 > (z2 ? 0 : this.Yp)) {
                zOnFling = this.Yx.onScroll(this.YG, motionEvent, f4, f5);
                this.YJ = f2;
                this.YK = f3;
                this.YD = false;
                this.jc.removeMessages(3);
                this.jc.removeMessages(1);
                this.jc.removeMessages(2);
            } else {
                zOnFling = false;
            }
            if (i6 > (z2 ? 0 : this.Yq)) {
                this.YE = false;
            }
        } else {
            this.Yz = false;
            MotionEvent motionEventObtain = MotionEvent.obtain(motionEvent);
            if (this.YI) {
                zOnFling = this.Yy.onDoubleTapEvent(motionEvent) | false;
            } else {
                if (this.YB) {
                    this.jc.removeMessages(3);
                    this.YB = false;
                } else if (this.YD && !this.YF) {
                    boolean zOnSingleTapUp = this.Yx.onSingleTapUp(motionEvent);
                    if (this.YA && (onDoubleTapListener = this.Yy) != null) {
                        onDoubleTapListener.onSingleTapConfirmed(motionEvent);
                    }
                    zOnFling = zOnSingleTapUp;
                } else if (!this.YF) {
                    VelocityTracker velocityTracker = this.mVelocityTracker;
                    int pointerId3 = motionEvent.getPointerId(0);
                    velocityTracker.computeCurrentVelocity(1000, this.Yt);
                    float yVelocity2 = velocityTracker.getYVelocity(pointerId3);
                    float xVelocity2 = velocityTracker.getXVelocity(pointerId3);
                    if (Math.abs(yVelocity2) > this.Ys || Math.abs(xVelocity2) > this.Ys) {
                        zOnFling = this.Yx.onFling(this.YG, motionEvent, xVelocity2, yVelocity2);
                    }
                }
                zOnFling = false;
            }
            MotionEvent motionEvent5 = this.YH;
            if (motionEvent5 != null) {
                motionEvent5.recycle();
            }
            this.YH = motionEventObtain;
            VelocityTracker velocityTracker2 = this.mVelocityTracker;
            if (velocityTracker2 != null) {
                velocityTracker2.recycle();
                this.mVelocityTracker = null;
            }
            this.YI = false;
            this.YA = false;
            this.YF = false;
            this.jc.removeMessages(1);
            this.jc.removeMessages(2);
        }
        return zOnFling;
    }

    private void cancel() {
        this.jc.removeMessages(1);
        this.jc.removeMessages(2);
        this.jc.removeMessages(3);
        this.mVelocityTracker.recycle();
        this.mVelocityTracker = null;
        this.YI = false;
        this.Yz = false;
        this.YD = false;
        this.YE = false;
        this.YA = false;
        this.YB = false;
        this.YC = false;
        this.YF = false;
    }

    private void tb() {
        this.jc.removeMessages(1);
        this.jc.removeMessages(2);
        this.jc.removeMessages(3);
        this.YI = false;
        this.YD = false;
        this.YE = false;
        this.YA = false;
        this.YB = false;
        this.YC = false;
        this.YF = false;
    }

    private boolean a(MotionEvent motionEvent, MotionEvent motionEvent2, MotionEvent motionEvent3) {
        if (!this.YE) {
            return false;
        }
        long eventTime = motionEvent3.getEventTime() - motionEvent2.getEventTime();
        if (eventTime <= this.YO && eventTime >= 10) {
            int x = ((int) motionEvent.getX()) - ((int) motionEvent3.getX());
            int y = ((int) motionEvent.getY()) - ((int) motionEvent3.getY());
            if ((x * x) + (y * y) < ((motionEvent.getFlags() & 8) != 0 ? 0 : this.Yr)) {
                return true;
            }
        }
        return false;
    }

    private void tc() {
        this.jc.removeMessages(3);
        this.YA = false;
        this.YB = true;
        this.Yx.onLongPress(this.YG);
    }

    public final void G(long j) {
        this.YO = j;
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        GestureDetector.OnDoubleTapListener onDoubleTapListener;
        int i = message.what;
        if (i == 1) {
            this.Yx.onShowPress(this.YG);
            return;
        }
        if (i == 2) {
            tc();
            return;
        }
        if (i == 3 && (onDoubleTapListener = this.Yy) != null) {
            if (!this.Yz) {
                onDoubleTapListener.onSingleTapConfirmed(this.YG);
            } else {
                this.YA = true;
            }
        }
    }
}
