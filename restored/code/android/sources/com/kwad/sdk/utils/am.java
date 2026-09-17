package com.kwad.sdk.utils;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;

/* JADX INFO: loaded from: classes3.dex */
public final class am extends bo {
    private int bpA;
    private int bpB;
    private int bpC;
    private int bpz;

    public static am a(int i, int i2, int i3, int i4, int i5, int i6) {
        am amVar = new am(i, i2);
        amVar.fQ(0);
        amVar.fR(0);
        amVar.fO(i4);
        amVar.fP(0);
        return amVar;
    }

    public final am c(Context context, float f) {
        am amVar = new am(com.kwad.sdk.c.a.a.a(context, this.mWidth * f), com.kwad.sdk.c.a.a.a(context, this.mHeight * f));
        amVar.bpB = com.kwad.sdk.c.a.a.a(context, this.bpB * f);
        amVar.bpA = com.kwad.sdk.c.a.a.a(context, this.bpA * f);
        amVar.bpC = com.kwad.sdk.c.a.a.a(context, this.bpC * f);
        amVar.bpz = com.kwad.sdk.c.a.a.a(context, this.bpz * f);
        return amVar;
    }

    public am(int i, int i2) {
        super(i, i2);
    }

    private int VR() {
        return this.bpz;
    }

    public final void fO(int i) {
        this.bpz = i;
    }

    private int VS() {
        return this.bpA;
    }

    private void fP(int i) {
        this.bpA = i;
    }

    private int VT() {
        return this.bpB;
    }

    public final void fQ(int i) {
        this.bpB = i;
    }

    private int VU() {
        return this.bpC;
    }

    public final void fR(int i) {
        this.bpC = i;
    }

    public static void a(View view, am amVar) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        if (amVar.getHeight() > 0) {
            layoutParams.height = amVar.getHeight();
        }
        if (amVar.getWidth() > 0) {
            layoutParams.width = amVar.getWidth();
        }
        if (layoutParams instanceof ViewGroup.MarginLayoutParams) {
            ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) layoutParams;
            if (amVar.VT() > 0) {
                marginLayoutParams.leftMargin = amVar.VT();
            }
            if (amVar.VS() > 0) {
                marginLayoutParams.bottomMargin = amVar.VS();
            }
            if (amVar.VU() > 0) {
                marginLayoutParams.rightMargin = amVar.VU();
            }
            if (amVar.VR() > 0) {
                marginLayoutParams.topMargin = amVar.VR();
            }
        }
        view.setLayoutParams(layoutParams);
    }
}
