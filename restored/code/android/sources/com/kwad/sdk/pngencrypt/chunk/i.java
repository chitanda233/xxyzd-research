package com.kwad.sdk.pngencrypt.chunk;

import com.kwad.sdk.pngencrypt.PngjException;
import java.io.ByteArrayInputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class i extends p {
    private int bkv;
    private int bkw;
    private int blQ;
    private int blR;
    private int blS;
    private int blT;
    private int blU;

    public i(com.kwad.sdk.pngencrypt.k kVar) {
        super("IHDR", kVar);
        if (kVar != null) {
            TF();
        }
    }

    @Override // com.kwad.sdk.pngencrypt.chunk.PngChunk
    public final void a(d dVar) {
        if (dVar.len != 13) {
            throw new PngjException("Bad IDHR len " + dVar.len);
        }
        ByteArrayInputStream byteArrayInputStreamTx = dVar.Tx();
        this.bkw = com.kwad.sdk.pngencrypt.n.f(byteArrayInputStreamTx);
        this.bkv = com.kwad.sdk.pngencrypt.n.f(byteArrayInputStreamTx);
        this.blQ = com.kwad.sdk.pngencrypt.n.e(byteArrayInputStreamTx);
        this.blR = com.kwad.sdk.pngencrypt.n.e(byteArrayInputStreamTx);
        this.blS = com.kwad.sdk.pngencrypt.n.e(byteArrayInputStreamTx);
        this.blT = com.kwad.sdk.pngencrypt.n.e(byteArrayInputStreamTx);
        this.blU = com.kwad.sdk.pngencrypt.n.e(byteArrayInputStreamTx);
    }

    private int Ti() {
        return this.bkw;
    }

    private void fl(int i) {
        this.bkw = i;
    }

    private int Th() {
        return this.bkv;
    }

    private void fm(int i) {
        this.bkv = i;
    }

    private int TB() {
        return this.blQ;
    }

    private void fn(int i) {
        this.blQ = i;
    }

    private int TC() {
        return this.blR;
    }

    private void fo(int i) {
        this.blR = i;
    }

    private void fp(int i) {
        this.blS = 0;
    }

    private void fq(int i) {
        this.blT = 0;
    }

    private int TD() {
        return this.blU;
    }

    private void fr(int i) {
        this.blU = 0;
    }

    public final boolean TE() {
        return TD() == 1;
    }

    private void TF() {
        fl(this.bkK.bkw);
        fm(this.bkK.bkv);
        fn(this.bkK.bkO);
        int i = this.bkK.bkQ ? 4 : 0;
        if (this.bkK.bkS) {
            i++;
        }
        if (!this.bkK.bkR) {
            i += 2;
        }
        fo(i);
        fp(0);
        fq(0);
        fr(0);
    }

    public final com.kwad.sdk.pngencrypt.k TG() {
        TH();
        return new com.kwad.sdk.pngencrypt.k(Ti(), Th(), TB(), (TC() & 4) != 0, TC() == 0 || TC() == 4, (TC() & 1) != 0);
    }

    private void TH() {
        if (this.bkw <= 0 || this.bkv <= 0 || this.blS != 0 || this.blT != 0) {
            throw new PngjException("bad IHDR: col/row/compmethod/filmethod invalid");
        }
        int i = this.blQ;
        if (i != 1 && i != 2 && i != 4 && i != 8 && i != 16) {
            throw new PngjException("bad IHDR: bitdepth invalid");
        }
        int i2 = this.blU;
        if (i2 < 0 || i2 > 1) {
            throw new PngjException("bad IHDR: interlace invalid");
        }
        int i3 = this.blR;
        if (i3 != 0) {
            if (i3 != 6 && i3 != 2) {
                if (i3 == 3) {
                    if (i == 16) {
                        throw new PngjException("bad IHDR: bitdepth invalid");
                    }
                    return;
                } else if (i3 != 4) {
                    throw new PngjException("bad IHDR: invalid colormodel");
                }
            }
            if (i != 8 && i != 16) {
                throw new PngjException("bad IHDR: bitdepth invalid");
            }
        }
    }
}
