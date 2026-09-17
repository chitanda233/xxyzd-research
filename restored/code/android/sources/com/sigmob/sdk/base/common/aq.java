package com.sigmob.sdk.base.common;

import android.content.Context;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;
import com.sigmob.sdk.base.models.BaseAdUnit;

/* JADX INFO: loaded from: classes3.dex */
public class aq extends GestureDetector {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final View f3162a;
    private final c b;

    private aq(Context context, View view, c adAlertGestureListener) {
        super(context, adAlertGestureListener);
        this.b = adAlertGestureListener;
        this.f3162a = view;
        setIsLongpressEnabled(false);
    }

    public aq(Context context, View view, BaseAdUnit adUnit) {
        this(context, view, new c(view, adUnit));
    }

    private boolean a(MotionEvent motionEvent, View view) {
        if (motionEvent == null || view == null) {
            return false;
        }
        float x = motionEvent.getX();
        float y = motionEvent.getY();
        return x >= 0.0f && x <= ((float) view.getWidth()) && y >= 0.0f && y <= ((float) view.getHeight());
    }

    void a() {
        this.b.b();
    }

    public void b() {
        this.b.c();
    }

    public boolean c() {
        return this.b.d();
    }

    @Override // android.view.GestureDetector
    public boolean onTouchEvent(MotionEvent motionEvent) {
        boolean zOnTouchEvent = super.onTouchEvent(motionEvent);
        int action = motionEvent.getAction();
        if (action == 1) {
            this.b.a();
        } else if (action == 2 && !a(motionEvent, this.f3162a)) {
            a();
        }
        return zOnTouchEvent;
    }
}
