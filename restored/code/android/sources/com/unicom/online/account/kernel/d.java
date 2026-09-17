package com.unicom.online.account.kernel;

/* JADX INFO: loaded from: classes4.dex */
public final class d {
    public int b;
    public long c;
    public String d;
    public int e;
    public bg f;
    public bg g;
    public bg h;
    public bg i;

    public final void b(bg bgVar) {
        int i = this.e;
        if (i < 10) {
            this.e = i + 1;
        } else {
            this.e = 10;
        }
        int i2 = this.e;
        if (i2 == 1) {
            this.f = bgVar;
            return;
        }
        if (i2 == 2) {
            this.g = bgVar;
        } else if (i2 == 3) {
            this.h = bgVar;
        } else {
            if (i2 != 4) {
                return;
            }
            this.i = bgVar;
        }
    }

    public final String toString() {
        return "{ifProtal:" + this.b + ", step1:" + this.f + ", step2:" + this.g + ", step3:" + this.h + ", step4:" + this.i + '}';
    }
}
