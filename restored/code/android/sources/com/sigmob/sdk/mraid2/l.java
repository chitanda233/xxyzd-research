package com.sigmob.sdk.mraid2;

import android.content.Context;
import android.util.AttributeSet;
import android.util.Log;
import android.view.ViewGroup;
import android.widget.HorizontalScrollView;

/* JADX INFO: loaded from: classes3.dex */
public class l extends HorizontalScrollView implements o {
    public static final float c = 1000.0f;
    private static final String d = "PageScrollView";
    private static final int e = 1000;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3542a;
    public final int b;
    private int f;
    private long g;
    private u h;
    private int i;

    public l(Context context) {
        this(context, null);
    }

    public l(Context context, AttributeSet attrs) {
        this(context, attrs, 0);
    }

    public l(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        int i = getResources().getDisplayMetrics().widthPixels;
        this.f3542a = i;
        this.b = i / 2;
        this.i = 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(boolean z, int i, int i2, c cVar) {
        int i3;
        if (z) {
            int i4 = this.i;
            if (i > 0) {
                int i5 = this.f3542a;
                if (i4 + i5 < i2) {
                    this.i = i4 + i5;
                }
                i3 = 1;
            } else {
                if (i4 > 0) {
                    this.i = i4 - this.f3542a;
                }
                i3 = 2;
            }
            u uVar = this.h;
            if (uVar != null) {
                uVar.onPageChanged(cVar, i3, this.i / this.f3542a);
            }
        }
        smoothScrollTo(this.i, 0);
    }

    private boolean a(int d2) {
        int i = this.f3542a;
        int i2 = d2 % i;
        Log.d(d, i2 + ":-----goPage------:" + (d2 / i));
        float fCurrentTimeMillis = (d2 * 1000) / (System.currentTimeMillis() - this.g);
        return fCurrentTimeMillis >= 1000.0f || fCurrentTimeMillis <= -1000.0f || i2 >= this.b;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(int i, int i2) {
        if (i > 0) {
            int i3 = this.i;
            if (this.f3542a + i3 < i2) {
                scrollTo(i3 + Math.abs(i), 0);
                return;
            }
            return;
        }
        int i4 = this.i;
        if (i4 > 0) {
            scrollTo(i4 - Math.abs(i), 0);
        }
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void a(int x, int y) {
        this.f = x;
        this.g = System.currentTimeMillis();
        Log.d(d, this.i + "--------onTouchStart--------" + this.f);
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void a(final c view, int x, int y) {
        final int i = this.f - x;
        Log.d(d, this.i + "-----------onTouchEnd--------:" + i);
        final boolean zA = a(i);
        final int width = getChildAt(0).getWidth();
        Log.d(d, width + "------是否翻页----" + zA);
        post(new Runnable() { // from class: com.sigmob.sdk.mraid2.l$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(zA, i, width, view);
            }
        });
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void b(int x, int y) {
        final int i = this.f - x;
        final int width = getChildAt(0).getWidth();
        post(new Runnable() { // from class: com.sigmob.sdk.mraid2.l$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.c(i, width);
            }
        });
    }

    @Override // android.widget.HorizontalScrollView
    public void fling(int velocityX) {
        super.fling(0);
    }

    @Override // com.sigmob.sdk.mraid2.o
    public ViewGroup getView() {
        return this;
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void setPageChangedListener(u pageChangedListener) {
        this.h = pageChangedListener;
    }
}
