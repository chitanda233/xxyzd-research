package com.byazt.ij;

import android.view.MotionEvent;
import android.view.View;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1432, 71})
public class x implements View.OnTouchListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public float f1032a;
    public final com.byazt.nk.x c;
    public float n;
    public float sp;
    public final boolean tt;
    public float uj;
    public final int ve = 10;

    public x(com.byazt.nk.x xVar, boolean z) {
        this.c = xVar;
        this.tt = z;
    }

    @Override // android.view.View.OnTouchListener
    public boolean onTouch(View view, MotionEvent motionEvent) {
        com.byazt.nk.x xVar;
        com.byazt.nk.x xVar2;
        int action = motionEvent.getAction();
        if (action == 0) {
            this.uj = motionEvent.getX();
            this.n = motionEvent.getY();
            Object[] objArr = new Object[3];
            Float.valueOf(this.uj);
            String str = ", mStartY: " + this.n;
        } else if (action == 1) {
            this.f1032a = motionEvent.getX();
            this.sp = motionEvent.getY();
            Object[] objArr2 = new Object[3];
            Float.valueOf(this.f1032a);
            String str2 = ", mEndY: " + this.sp;
            if (!this.tt && (xVar2 = this.c) != null) {
                xVar2.c();
            } else {
                float f = this.f1032a - this.uj;
                float f2 = this.sp - this.n;
                float fSqrt = (float) Math.sqrt((f * f) + (f2 * f2));
                Object[] objArr3 = new Object[2];
                Float.valueOf(fSqrt);
                float fTt = com.byazt.or.x.tt(com.byazt.sr.uj.getContext(), Math.abs(fSqrt));
                Object[] objArr4 = new Object[5];
                Float.valueOf(fTt);
                Integer.valueOf(10);
                if (fTt > 10.0f && (xVar = this.c) != null) {
                    xVar.c();
                }
            }
        }
        return true;
    }
}
