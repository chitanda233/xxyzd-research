package com.sigmob.sdk.mraid2;

import android.content.Context;
import android.util.AttributeSet;
import android.util.Log;
import android.view.ViewGroup;
import android.widget.ScrollView;

/* JADX INFO: loaded from: classes3.dex */
public class r extends ScrollView implements o {
    public static final float c = 1000.0f;
    private static final String d = "PageScrollView";
    private static final int e = 1000;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3547a;
    public final int b;
    private int f;
    private long g;
    private u h;
    private int i;

    public r(Context context) {
        this(context, null);
    }

    public r(Context context, AttributeSet attrs) {
        this(context, attrs, 0);
    }

    public r(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        int i = getResources().getDisplayMetrics().heightPixels;
        this.f3547a = i;
        this.b = i / 2;
        this.i = 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(boolean z, int i, int i2, c cVar) {
        int i3;
        if (z) {
            int i4 = this.i;
            if (i > 0) {
                int i5 = this.f3547a;
                if (i4 + i5 < i2) {
                    this.i = i4 + i5;
                }
                i3 = 1;
            } else {
                if (i4 > 0) {
                    this.i = i4 - this.f3547a;
                }
                i3 = 2;
            }
            u uVar = this.h;
            if (uVar != null) {
                uVar.onPageChanged(cVar, i3, this.i / this.f3547a);
            }
        }
        smoothScrollTo(0, this.i);
    }

    private boolean a(int d2) {
        int i = this.f3547a;
        int i2 = d2 % i;
        Log.d(d, i2 + ":-----goPage------:" + (d2 / i));
        float fCurrentTimeMillis = ((d2 * 1000) * 1.0f) / (System.currentTimeMillis() - this.g);
        return fCurrentTimeMillis >= 1000.0f || fCurrentTimeMillis <= -1000.0f || i2 >= this.b;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(int i, int i2) {
        if (i > 0) {
            int i3 = this.i;
            if (this.f3547a + i3 < i2) {
                scrollTo(0, i3 + Math.abs(i));
                return;
            }
            return;
        }
        int i4 = this.i;
        if (i4 > 0) {
            scrollTo(0, i4 - Math.abs(i));
        }
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void a(int x, int y) {
        this.f = y;
        this.g = System.currentTimeMillis();
        Log.d(d, this.i + "--------onTouchStart--------" + this.f);
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void a(final c container, int x, int y) {
        final int i = this.f - y;
        Log.d(d, this.i + "-----------onTouchEnd--------:" + i);
        final boolean zA = a(i);
        final int height = getChildAt(0).getHeight();
        post(new Runnable() { // from class: com.sigmob.sdk.mraid2.r$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(zA, i, height, container);
            }
        });
    }

    @Override // com.sigmob.sdk.mraid2.o
    public void b(int x, int y) {
        final int i = this.f - y;
        final int height = getChildAt(0).getHeight();
        post(new Runnable() { // from class: com.sigmob.sdk.mraid2.r$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.c(i, height);
            }
        });
    }

    @Override // android.widget.ScrollView
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
