package com.kwad.sdk.widget;

import android.content.Context;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public final class h implements GestureDetector.OnGestureListener, View.OnTouchListener {
    private GestureDetector ML;
    private d iz;
    private View mView;
    private MotionEvent qh;

    @Override // android.view.GestureDetector.OnGestureListener
    public final boolean onDown(MotionEvent motionEvent) {
        return false;
    }

    @Override // android.view.GestureDetector.OnGestureListener
    public final boolean onFling(MotionEvent motionEvent, MotionEvent motionEvent2, float f, float f2) {
        return false;
    }

    @Override // android.view.GestureDetector.OnGestureListener
    public final void onLongPress(MotionEvent motionEvent) {
    }

    @Override // android.view.GestureDetector.OnGestureListener
    public final boolean onScroll(MotionEvent motionEvent, MotionEvent motionEvent2, float f, float f2) {
        return false;
    }

    @Override // android.view.GestureDetector.OnGestureListener
    public final void onShowPress(MotionEvent motionEvent) {
    }

    public h(Context context, View view, d dVar) {
        this.mView = view;
        view.setOnTouchListener(this);
        this.ML = new GestureDetector(context, this);
        this.iz = dVar;
    }

    public h(View view, d dVar) {
        if (view == null) {
            return;
        }
        this.mView = view;
        view.setOnTouchListener(this);
        this.ML = new GestureDetector(view.getContext(), this);
        this.iz = dVar;
    }

    @Override // android.view.View.OnTouchListener
    public final boolean onTouch(View view, MotionEvent motionEvent) {
        if (this.qh != null && motionEvent.getAction() == 1 && b(this.qh, motionEvent)) {
            return a(view, motionEvent);
        }
        boolean zOnTouchEvent = this.ML.onTouchEvent(motionEvent);
        motionEvent.getAction();
        if (zOnTouchEvent) {
            return true;
        }
        return a(view, motionEvent);
    }

    @Override // android.view.GestureDetector.OnGestureListener
    public final boolean onSingleTapUp(MotionEvent motionEvent) {
        d dVar = this.iz;
        if (dVar == null) {
            return false;
        }
        dVar.a(this.mView);
        return true;
    }

    private boolean a(View view, MotionEvent motionEvent) {
        int action = motionEvent.getAction();
        boolean z = false;
        if (action == 0) {
            this.qh = MotionEvent.obtain(motionEvent);
        } else if (action == 1) {
            MotionEvent motionEvent2 = this.qh;
            if (motionEvent2 != null && b(motionEvent2, motionEvent)) {
                d dVar = this.iz;
                if (dVar != null) {
                    dVar.a(view, this.qh.getX(), this.qh.getY(), motionEvent.getX(), motionEvent.getY());
                }
                z = true;
            }
            this.qh = null;
        }
        return z;
    }

    private static boolean b(MotionEvent motionEvent, MotionEvent motionEvent2) {
        return ((Math.abs(motionEvent.getX() - motionEvent2.getX()) > 20.0f ? 1 : (Math.abs(motionEvent.getX() - motionEvent2.getX()) == 20.0f ? 0 : -1)) > 0) || ((Math.abs(motionEvent.getY() - motionEvent2.getY()) > 20.0f ? 1 : (Math.abs(motionEvent.getY() - motionEvent2.getY()) == 20.0f ? 0 : -1)) > 0);
    }
}
