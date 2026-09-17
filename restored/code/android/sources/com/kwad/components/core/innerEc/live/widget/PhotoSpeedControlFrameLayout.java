package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.util.AttributeSet;
import android.view.GestureDetector;
import android.view.MotionEvent;
import com.kwad.sdk.widget.KSFrameLayout;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class PhotoSpeedControlFrameLayout extends KSFrameLayout {
    private boolean aaH;
    private final List<GestureDetector> aaI;

    public final void a(GestureDetector gestureDetector) {
        if (gestureDetector == null || this.aaI.contains(gestureDetector)) {
            return;
        }
        this.aaI.add(gestureDetector);
    }

    public final void b(GestureDetector gestureDetector) {
        if (gestureDetector != null) {
            this.aaI.remove(gestureDetector);
        }
    }

    public PhotoSpeedControlFrameLayout(Context context) {
        super(context);
        this.aaH = false;
        this.aaI = new ArrayList();
    }

    public PhotoSpeedControlFrameLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.aaH = false;
        this.aaI = new ArrayList();
    }

    public PhotoSpeedControlFrameLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.aaH = false;
        this.aaI = new ArrayList();
    }

    public void setIntercepted(boolean z) {
        this.aaH = z;
    }

    @Override // android.view.ViewGroup
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        if (this.aaH) {
            motionEvent.getAction();
            return true;
        }
        return super.onInterceptTouchEvent(motionEvent);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.ViewGroup, android.view.View
    public boolean dispatchTouchEvent(MotionEvent motionEvent) {
        boolean zDispatchTouchEvent = super.dispatchTouchEvent(motionEvent);
        Iterator<GestureDetector> it = this.aaI.iterator();
        while (it.hasNext()) {
            zDispatchTouchEvent = it.next().onTouchEvent(motionEvent) || zDispatchTouchEvent;
        }
        return zDispatchTouchEvent;
    }
}
