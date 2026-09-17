package com.kwad.components.ad.splashscreen.widget;

import android.content.Context;
import com.kwad.sdk.utils.am;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private float JY;
    private int Ll;
    private int Lm;
    private int Ln;
    private int Lo;
    private int Lp;
    private int Lq;
    private Context mContext;

    public static a ai(Context context) {
        return new a(context);
    }

    public static a aj(Context context) {
        return new a(context, 17, 10, 12, 8, 4, 3);
    }

    private a(Context context) {
        this.Ll = 24;
        this.Lm = 12;
        this.Ln = 16;
        this.Lo = 12;
        this.Lp = 6;
        this.Lq = 4;
        this.JY = 1.0f;
        this.mContext = context;
    }

    private a(Context context, int i, int i2, int i3, int i4, int i5, int i6) {
        this.JY = 1.0f;
        this.mContext = context;
        this.Ll = 17;
        this.Lm = 10;
        this.Ln = 12;
        this.Lo = 8;
        this.Lp = 4;
        this.Lq = 3;
    }

    public final void d(float f) {
        this.JY = f;
    }

    public final int nR() {
        return (int) (((this.Ll - this.Ln) / 2) * this.JY);
    }

    public final int nS() {
        return (int) (this.Lo * this.JY);
    }

    public final am nu() {
        return new am(0, (int) (com.kwad.sdk.c.a.a.a(this.mContext, this.Ll) * this.JY));
    }

    public final am nT() {
        int iA = (int) (com.kwad.sdk.c.a.a.a(this.mContext, this.Lp) * this.JY);
        int iA2 = (int) (com.kwad.sdk.c.a.a.a(this.mContext, this.Lq) * this.JY);
        am amVar = new am(0, 0);
        amVar.fQ(iA);
        amVar.fR(iA2);
        return amVar;
    }

    public final int nU() {
        return (int) (com.kwad.sdk.c.a.a.b(this.mContext, this.Lm) * this.JY);
    }

    public final float nV() {
        return (com.kwad.sdk.c.a.a.a(this.mContext, this.Ll) * this.JY) / 2.0f;
    }

    public final am nW() {
        int iA = (int) (com.kwad.sdk.c.a.a.a(this.mContext, this.Ln) * this.JY);
        return new am(iA, iA);
    }
}
