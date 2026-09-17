package com.kwad.components.core.innerEc.live.widget;

import android.app.Activity;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewConfiguration;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class j implements View.OnTouchListener {
    private GestureDetector ML;
    private float ZB;
    private boolean ZC;
    private a ZF;
    private final LiveCommentsView Zy;
    private final i Zz;
    private final Activity mActivity;
    private final Set<Object> ZA = new HashSet();
    private boolean ZD = true;
    private boolean ZE = true;
    private Runnable ZG = new Runnable() { // from class: com.kwad.components.core.innerEc.live.widget.j.1
        @Override // java.lang.Runnable
        public final void run() {
            j.this.ZE = true;
        }
    };
    private final int[] ZH = new int[2];
    private int ZI = 0;
    private float ZJ = 0.0f;
    private float ZK = 0.0f;
    private final Runnable ZL = new Runnable() { // from class: com.kwad.components.core.innerEc.live.widget.j.2
        @Override // java.lang.Runnable
        public final void run() {
            j.b(j.this, false);
        }
    };

    static final class a {
    }

    static /* synthetic */ int a(j jVar, float f) {
        int i = (int) (jVar.ZI + f);
        jVar.ZI = i;
        return i;
    }

    static /* synthetic */ boolean b(j jVar, boolean z) {
        jVar.ZC = false;
        return false;
    }

    public final void tj() {
        if (this.ZF != null) {
            Iterator<Object> it = this.ZA.iterator();
            while (it.hasNext()) {
                it.next();
            }
            this.ZF = null;
        }
    }

    public final void tk() {
        if (!this.ZE || this.ZF == null) {
            return;
        }
        Iterator<Object> it = this.ZA.iterator();
        while (it.hasNext()) {
            it.next();
        }
        this.ZF = null;
    }

    public j(i iVar, LiveCommentsView liveCommentsView, Activity activity) {
        this.Zz = iVar;
        this.mActivity = activity;
        this.Zy = liveCommentsView;
        liveCommentsView.setOnTouchListener(this);
        this.ML = new GestureDetector(activity, new GestureDetector.SimpleOnGestureListener() { // from class: com.kwad.components.core.innerEc.live.widget.j.3
            @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnGestureListener
            public final boolean onScroll(MotionEvent motionEvent, MotionEvent motionEvent2, float f, float f2) {
                j.a(j.this, f2);
                return super.onScroll(motionEvent, motionEvent2, f, f2);
            }

            @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnDoubleTapListener
            public final boolean onDoubleTap(MotionEvent motionEvent) {
                if (motionEvent == null) {
                    return true;
                }
                Iterator it = j.this.ZA.iterator();
                while (it.hasNext()) {
                    it.next();
                }
                j.this.ZE = false;
                by.b(j.this.ZG);
                by.a(j.this.ZG, j.this, 1000L);
                return true;
            }

            @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnGestureListener
            public final void onLongPress(MotionEvent motionEvent) {
                super.onLongPress(motionEvent);
                if (!j.this.ML.isLongpressEnabled() || motionEvent.getY() <= j.this.Zy.getCustomFadingEdgeTop()) {
                    return;
                }
                j.this.tj();
            }

            @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnDoubleTapListener
            public final boolean onSingleTapConfirmed(MotionEvent motionEvent) {
                if (j.this.ZD && !j.this.mActivity.isFinishing() && motionEvent.getY() > j.this.Zy.getCustomFadingEdgeTop()) {
                    j.this.tk();
                }
                return true;
            }
        });
    }

    @Override // android.view.View.OnTouchListener
    public final boolean onTouch(View view, MotionEvent motionEvent) {
        if (motionEvent.getAction() == 0) {
            this.ZB = motionEvent.getRawY();
            aN(true);
            aM(true);
            Iterator<Object> it = this.ZA.iterator();
            while (it.hasNext()) {
                it.next();
            }
            this.ZJ = motionEvent.getY();
        } else if (motionEvent.getAction() == 1 || motionEvent.getAction() == 3) {
            aN(false);
            ViewConfiguration.getLongPressTimeout();
            aM(false);
            Iterator<Object> it2 = this.ZA.iterator();
            while (it2.hasNext()) {
                it2.next();
            }
            if (motionEvent.getAction() == 1) {
                tm();
            }
            h(motionEvent);
        } else if (motionEvent.getAction() == 2) {
            if (Math.abs(motionEvent.getRawY() - this.ZB) > 10.0f) {
                aM(false);
            }
            this.ZK = motionEvent.getY() - this.ZJ;
        }
        return this.ML.onTouchEvent(motionEvent);
    }

    public final boolean tl() {
        return this.ZC;
    }

    private void aM(boolean z) {
        this.ML.setIsLongpressEnabled(z);
    }

    private void aN(boolean z) {
        if (z) {
            by.b(this.ZL);
            this.ZC = true;
        } else {
            by.runOnUiThreadDelay(this.ZL, 1000L);
        }
    }

    private void tm() {
        ViewConfiguration viewConfiguration = ViewConfiguration.get(this.mActivity);
        float scaledTouchSlop = viewConfiguration != null ? viewConfiguration.getScaledTouchSlop() : 0.0f;
        int i = this.ZI;
        if (i == 0 || Math.abs(i) <= scaledTouchSlop) {
            return;
        }
        if (this.ZI > 0) {
            int[] iArr = this.ZH;
            iArr[0] = iArr[0] + 1;
        } else {
            int[] iArr2 = this.ZH;
            iArr2[1] = iArr2[1] + 1;
        }
        this.ZI = 0;
    }

    private void h(MotionEvent motionEvent) {
        if (!this.Zz.Zu || motionEvent.getAction() == 1) {
            float f = this.ZK;
            if (f == 0.0f) {
                return;
            }
            if (f < 0.0f) {
                Iterator<Object> it = this.ZA.iterator();
                while (it.hasNext()) {
                    it.next();
                }
            } else {
                Iterator<Object> it2 = this.ZA.iterator();
                while (it2.hasNext()) {
                    it2.next();
                }
            }
        }
    }
}
