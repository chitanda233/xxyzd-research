package com.kwad.sdk.utils;

/* JADX INFO: loaded from: classes3.dex */
public class bo {
    protected final int mHeight;
    protected final int mWidth;

    public bo(int i, int i2) {
        this.mWidth = i;
        this.mHeight = i2;
    }

    public final int getWidth() {
        return this.mWidth;
    }

    public final int getHeight() {
        return this.mHeight;
    }

    public final float WF() {
        return this.mWidth;
    }

    public final float WG() {
        return this.mHeight;
    }

    public boolean equals(Object obj) {
        if (obj == null) {
            return false;
        }
        if (this == obj) {
            return true;
        }
        if (obj instanceof bo) {
            bo boVar = (bo) obj;
            if (this.mWidth == boVar.mWidth && this.mHeight == boVar.mHeight) {
                return true;
            }
        }
        return false;
    }

    public String toString() {
        return this.mWidth + "x" + this.mHeight;
    }

    public int hashCode() {
        int i = this.mHeight;
        int i2 = this.mWidth;
        return i ^ ((i2 >>> 16) | (i2 << 16));
    }
}
