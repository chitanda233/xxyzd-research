package com.kwad.sdk.pngencrypt;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    int bkA;
    int bkB;
    int bkC;
    final k bkt;
    private int bkv;
    private int bkw;
    int bkx;
    int bky;
    int bkz;
    private int bku = 0;
    private int bkD = -1;
    private int bkE = -1;
    private int bkF = 0;
    private boolean bkH = false;
    int bkG = 0;

    public e(k kVar) {
        this.bkt = kVar;
        fc(1);
        fb(0);
    }

    private void fb(int i) {
        this.bkD = i;
        int i2 = (i * this.bkx) + this.bkz;
        this.bkE = i2;
        if (i2 < 0 || i2 >= this.bkt.bkv) {
            throw new PngjException("bad row - this should not happen");
        }
    }

    final boolean Td() {
        int i;
        while (true) {
            this.bkF++;
            int i2 = this.bkv;
            if (i2 == 0 || (i = this.bkD) >= i2 - 1) {
                int i3 = this.bku;
                if (i3 == 7) {
                    this.bkH = true;
                    return false;
                }
                fc(i3 + 1);
                if (this.bkv == 0) {
                    this.bkF--;
                } else {
                    fb(0);
                    break;
                }
            } else {
                fb(i + 1);
                break;
            }
        }
        return true;
    }

    private void fc(int i) {
        int i2;
        int i3;
        if (this.bku == i) {
            return;
        }
        this.bku = i;
        byte[] bArrFd = fd(i);
        this.bky = bArrFd[0];
        this.bkx = bArrFd[1];
        this.bkA = bArrFd[2];
        this.bkz = bArrFd[3];
        if (this.bkt.bkv > this.bkz) {
            int i4 = this.bkt.bkv;
            int i5 = this.bkx;
            i2 = (((i4 + i5) - 1) - this.bkz) / i5;
        } else {
            i2 = 0;
        }
        this.bkv = i2;
        if (this.bkt.bkw > this.bkA) {
            int i6 = this.bkt.bkw;
            int i7 = this.bky;
            i3 = (((i6 + i7) - 1) - this.bkA) / i7;
        } else {
            i3 = 0;
        }
        this.bkw = i3;
        if (i3 == 0) {
            this.bkv = 0;
        }
        this.bkC = this.bky * this.bkt.bkP;
        this.bkB = this.bkA * this.bkt.bkP;
    }

    private static byte[] fd(int i) {
        switch (i) {
            case 1:
                return new byte[]{8, 8, 0, 0};
            case 2:
                return new byte[]{8, 8, 4, 0};
            case 3:
                return new byte[]{4, 8, 0, 4};
            case 4:
                return new byte[]{4, 4, 2, 0};
            case 5:
                return new byte[]{2, 4, 0, 2};
            case 6:
                return new byte[]{2, 2, 1, 0};
            case 7:
                return new byte[]{1, 2, 0, 1};
            default:
                throw new PngjException("bad interlace pass" + i);
        }
    }

    final int Te() {
        return this.bkD;
    }

    final int Tf() {
        return this.bkE;
    }

    final int Tg() {
        return this.bku;
    }

    final int Th() {
        return this.bkv;
    }

    final int Ti() {
        return this.bkw;
    }

    private int Tj() {
        return Ti();
    }

    public final int Tk() {
        return ((this.bkt.bkU * Tj()) + 7) / 8;
    }
}
