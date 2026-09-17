package com.kwad.sdk.widget;

import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import androidx.viewpager.widget.ViewPager;

/* JADX INFO: loaded from: classes3.dex */
public class f extends ViewPager {
    private int btu;
    private boolean btv;

    public f(Context context) {
        super(context);
        this.btv = false;
    }

    public f(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.btv = false;
    }

    public void setScrollable(boolean z) {
        this.btv = z;
    }

    @Override // androidx.viewpager.widget.ViewPager, android.view.ViewGroup
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        return this.btv && super.onInterceptTouchEvent(motionEvent);
    }

    @Override // androidx.viewpager.widget.ViewPager, android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        return this.btv && super.onTouchEvent(motionEvent);
    }

    @Override // androidx.viewpager.widget.ViewPager, android.view.View
    public boolean canScrollHorizontally(int i) {
        if (this.btv) {
            return super.canScrollHorizontally(i);
        }
        return false;
    }

    @Override // android.view.ViewGroup, android.view.View
    public boolean dispatchTouchEvent(MotionEvent motionEvent) {
        if (!this.btv) {
            return super.dispatchTouchEvent(motionEvent);
        }
        int x = (int) motionEvent.getX();
        int action = motionEvent.getAction();
        if (action == 0) {
            getParent().requestDisallowInterceptTouchEvent(true);
        } else if (action == 2) {
            int i = x - this.btu;
            if (getCurrentItem() == 0 && i > 0) {
                getParent().requestDisallowInterceptTouchEvent(false);
            }
        }
        this.btu = x;
        return super.dispatchTouchEvent(motionEvent);
    }
}
