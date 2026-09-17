package com.kwad.components.core.r;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a akH;
    private int aey;
    private int akI;
    private boolean akJ;
    private boolean akK;
    private int akL;
    private boolean akM;

    private a() {
    }

    public static a wy() {
        if (akH == null) {
            synchronized (a.class) {
                if (akH == null) {
                    akH = new a();
                }
            }
        }
        return akH;
    }

    public final int wz() {
        return this.akI;
    }

    public final void bK(int i) {
        this.akI = i;
    }

    public final boolean wA() {
        return this.akJ;
    }

    public final void ba(boolean z) {
        this.akJ = true;
    }

    public final boolean wB() {
        return this.akK;
    }

    public final void bb(boolean z) {
        this.akK = z;
    }

    public final boolean wC() {
        int i = this.akL;
        return i == 1 || i == 3;
    }

    public final void bL(int i) {
        this.akL = i;
    }

    public final int wD() {
        return this.akL;
    }

    public final boolean wE() {
        return this.akM;
    }

    public final void bc(boolean z) {
        this.akM = z;
    }

    public final int wF() {
        return this.aey;
    }

    public final void bM(int i) {
        this.aey = i;
    }

    public final void clear() {
        this.akK = false;
        this.akJ = false;
        this.akL = 0;
        this.akM = false;
        this.akI = -1;
        this.aey = 0;
    }
}
