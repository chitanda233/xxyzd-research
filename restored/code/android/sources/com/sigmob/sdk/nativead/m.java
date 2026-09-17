package com.sigmob.sdk.nativead;

import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.widget.RelativeLayout;

/* JADX INFO: loaded from: classes4.dex */
public class m extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3578a = 0;
    public static final int b = 1;
    public static final int c = 2;
    protected j d;

    public m(Context context) {
        super(context);
    }

    public m(Context context, AttributeSet attrs) {
        super(context, attrs);
    }

    public m(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
    }

    boolean a(MotionEvent event) {
        return false;
    }

    public boolean b() {
        return false;
    }

    public void c() {
    }

    public void d() {
    }

    public t getSigVideoAdController() {
        return null;
    }
}
