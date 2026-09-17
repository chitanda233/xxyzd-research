package com.kwad.sdk.widget.swipe;

import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.ViewConfiguration;
import android.widget.FrameLayout;
import com.kwad.sdk.core.d.c;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public class HorizontalSwipeLayout extends FrameLayout {
    private int ahO;
    private com.kwad.sdk.widget.swipe.a btD;
    private List<a> btE;
    private float hI;
    private float hJ;
    private int mTouchSlop;

    public interface a {
        void st();

        void su();
    }

    public HorizontalSwipeLayout(Context context) {
        super(context);
        this.ahO = 0;
        this.btE = new CopyOnWriteArrayList();
        init(context);
    }

    public HorizontalSwipeLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.ahO = 0;
        this.btE = new CopyOnWriteArrayList();
        init(context);
    }

    public HorizontalSwipeLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.ahO = 0;
        this.btE = new CopyOnWriteArrayList();
        init(context);
    }

    private void init(Context context) {
        this.mTouchSlop = ViewConfiguration.get(context).getScaledPagingTouchSlop();
    }

    public void setTouchDetector(com.kwad.sdk.widget.swipe.a aVar) {
        this.btD = aVar;
    }

    public final synchronized void a(a aVar) {
        this.btE.add(aVar);
    }

    public synchronized List<a> getOnSwipedListeners() {
        return this.btE;
    }

    public final synchronized void b(a aVar) {
        this.btE.remove(aVar);
    }

    @Override // android.view.ViewGroup, android.view.View
    public boolean dispatchTouchEvent(MotionEvent motionEvent) {
        List<a> list = this.btE;
        if (list != null && !list.isEmpty()) {
            int action = motionEvent.getAction();
            if (action == 0) {
                getParent().requestDisallowInterceptTouchEvent(true);
            } else if (action == 1 || action == 3) {
                getParent().requestDisallowInterceptTouchEvent(false);
            }
        }
        return super.dispatchTouchEvent(motionEvent);
    }

    @Override // android.view.ViewGroup
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        com.kwad.sdk.widget.swipe.a aVar = this.btD;
        if (aVar != null && aVar.b(this, motionEvent)) {
            c.d("HorizontalSwipeLayout", "onInterceptTouchEvent true");
            return true;
        }
        List<a> list = this.btE;
        if (list == null || list.isEmpty() || !k(motionEvent)) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        return true;
    }

    @Override // android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        com.kwad.sdk.widget.swipe.a aVar = this.btD;
        if (aVar != null && aVar.c(this, motionEvent)) {
            c.d("HorizontalSwipeLayout", "handlerTouchEvent true");
            return true;
        }
        List<a> list = this.btE;
        if (list == null || list.isEmpty() || !l(motionEvent)) {
            return super.onTouchEvent(motionEvent);
        }
        return true;
    }

    private boolean k(MotionEvent motionEvent) {
        int action = motionEvent.getAction();
        if (action == 0) {
            this.hI = motionEvent.getX();
            this.hJ = motionEvent.getY();
            this.ahO = 0;
            c.d("HorizontalSwipeLayout", "onInterceptTouchEvent ACTION_DOWN mInitialMotionX=" + this.hI);
        } else if (action == 1) {
            this.ahO = 0;
            c.d("HorizontalSwipeLayout", "onInterceptTouchEvent ACTION_UP");
        } else if (action == 2) {
            float x = motionEvent.getX() - this.hI;
            float fAbs = Math.abs(x);
            float fAbs2 = Math.abs(motionEvent.getY() - this.hJ);
            if (fAbs > this.mTouchSlop && fAbs > fAbs2) {
                if (x > 0.0f) {
                    this.ahO = 1;
                } else {
                    this.ahO = 2;
                }
            }
            c.d("HorizontalSwipeLayout", "onInterceptTouchEvent ACTION_MOVE mDragState=" + this.ahO + "--dx=" + x);
        } else if (action == 3) {
            this.ahO = 0;
        }
        return this.ahO != 0;
    }

    private boolean l(MotionEvent motionEvent) {
        int i;
        int action = motionEvent.getAction();
        if (action == 0) {
            c.d("HorizontalSwipeLayout", "onTouchEvent ACTION_DOWN mInitialMotionX=" + this.hI);
        } else if (action == 1) {
            c.d("HorizontalSwipeLayout", "onTouchEvent ACTION_UP mDragState=" + this.ahO);
            List<a> list = this.btE;
            if (list != null && !list.isEmpty() && (i = this.ahO) != 0) {
                if (i == 1) {
                    XW();
                } else if (i == 2) {
                    XV();
                }
            }
            this.ahO = 0;
        } else if (action == 2) {
            float x = motionEvent.getX() - this.hI;
            float fAbs = Math.abs(x);
            float fAbs2 = Math.abs(motionEvent.getY() - this.hJ);
            if (this.ahO == 0 && fAbs > this.mTouchSlop && fAbs > fAbs2) {
                if (x > 0.0f) {
                    this.ahO = 1;
                } else {
                    this.ahO = 2;
                }
            }
            c.d("HorizontalSwipeLayout", "onTouchEvent ACTION_MOVE mDragState=" + this.ahO + "--dx=" + x);
        } else if (action == 3) {
            this.ahO = 0;
        }
        return this.ahO != 0;
    }

    private synchronized void XV() {
        Iterator<a> it = this.btE.iterator();
        while (it.hasNext()) {
            it.next().su();
        }
    }

    private synchronized void XW() {
        Iterator<a> it = this.btE.iterator();
        while (it.hasNext()) {
            it.next().st();
        }
    }
}
