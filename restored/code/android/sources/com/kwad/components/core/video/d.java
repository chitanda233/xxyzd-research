package com.kwad.components.core.video;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private boolean ans = false;
    private boolean ant = false;
    private boolean anu = false;
    private boolean anv = false;
    private boolean anw = false;
    private int anx = -1;

    public final boolean xI() {
        return this.anx > 0;
    }

    public final void bR(int i) {
        this.anx = i;
    }

    public final int xJ() {
        return this.anx;
    }

    public final boolean xK() {
        return this.ans;
    }

    public final void setForce(boolean z) {
        this.ans = z;
    }

    public final boolean xL() {
        return this.ant;
    }

    public final void setAd(boolean z) {
        this.ant = z;
    }

    public final boolean xM() {
        return this.anu;
    }

    public final void bh(boolean z) {
        this.anu = z;
    }

    public final boolean xN() {
        return this.anv;
    }

    public final void setHorizontalVideo(boolean z) {
        this.anv = z;
    }

    public final boolean xO() {
        return this.anw;
    }

    public final void setFillXY(boolean z) {
        this.anw = z;
    }
}
