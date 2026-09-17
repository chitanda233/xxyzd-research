package com.kwad.sdk.pngencrypt;

import java.util.Arrays;
import java.util.zip.Inflater;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends DeflatedChunksSet {
    protected final e bjO;
    protected byte[] bkI;
    protected byte[] bkJ;
    protected final k bkK;
    final p bkL;
    protected int[] bkM;

    public j(String str, boolean z, k kVar, e eVar) {
        this(str, z, kVar, eVar, null, null);
    }

    private j(String str, boolean z, k kVar, e eVar, Inflater inflater, byte[] bArr) {
        super(str, z, (eVar != null ? eVar.Tk() : kVar.bkW) + 1, kVar.bkW + 1, null, null);
        this.bkM = new int[5];
        this.bkK = kVar;
        this.bjO = eVar;
        this.bkL = new p(kVar, eVar);
    }

    private void Tl() {
        fe(this.bkL.bls);
    }

    private void fe(int i) {
        byte[] bArr = this.bkI;
        if (bArr == null || bArr.length < this.bkh.length) {
            this.bkI = new byte[this.bkh.length];
            this.bkJ = new byte[this.bkh.length];
        }
        if (this.bkL.blp == 0) {
            Arrays.fill(this.bkI, (byte) 0);
        }
        byte[] bArr2 = this.bkI;
        this.bkI = this.bkJ;
        this.bkJ = bArr2;
        byte b = this.bkh[0];
        if (!FilterType.isValidStandard(b)) {
            throw new PngjException("Filter type " + ((int) b) + " invalid");
        }
        FilterType byVal = FilterType.getByVal(b);
        int[] iArr = this.bkM;
        iArr[b] = iArr[b] + 1;
        this.bkI[0] = this.bkh[0];
        int i2 = AnonymousClass1.bkN[byVal.ordinal()];
        if (i2 == 1) {
            fg(i);
            return;
        }
        if (i2 == 2) {
            fi(i);
            return;
        }
        if (i2 == 3) {
            fj(i);
        } else if (i2 == 4) {
            ff(i);
        } else {
            if (i2 == 5) {
                fh(i);
                return;
            }
            throw new PngjException("Filter type " + ((int) b) + " not implemented");
        }
    }

    /* JADX INFO: renamed from: com.kwad.sdk.pngencrypt.j$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {
        static final /* synthetic */ int[] bkN;

        static {
            int[] iArr = new int[FilterType.values().length];
            bkN = iArr;
            try {
                iArr[FilterType.FILTER_NONE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                bkN[FilterType.FILTER_SUB.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                bkN[FilterType.FILTER_UP.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                bkN[FilterType.FILTER_AVERAGE.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                bkN[FilterType.FILTER_PAETH.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
        }
    }

    private void ff(int i) {
        int i2 = 1;
        int i3 = 1 - this.bkK.bkV;
        while (i2 <= i) {
            this.bkI[i2] = (byte) (this.bkh[i2] + (((i3 > 0 ? this.bkI[i3] & UByte.MAX_VALUE : 0) + (this.bkJ[i2] & UByte.MAX_VALUE)) / 2));
            i2++;
            i3++;
        }
    }

    private void fg(int i) {
        for (int i2 = 1; i2 <= i; i2++) {
            this.bkI[i2] = this.bkh[i2];
        }
    }

    private void fh(int i) {
        int i2 = 1;
        int i3 = 1 - this.bkK.bkV;
        while (i2 <= i) {
            int i4 = 0;
            int i5 = i3 > 0 ? this.bkI[i3] & UByte.MAX_VALUE : 0;
            if (i3 > 0) {
                i4 = this.bkJ[i3] & UByte.MAX_VALUE;
            }
            this.bkI[i2] = (byte) (this.bkh[i2] + n.d(i5, this.bkJ[i2] & UByte.MAX_VALUE, i4));
            i2++;
            i3++;
        }
    }

    private void fi(int i) {
        for (int i2 = 1; i2 <= this.bkK.bkV; i2++) {
            this.bkI[i2] = this.bkh[i2];
        }
        int i3 = this.bkK.bkV + 1;
        int i4 = 1;
        while (i3 <= i) {
            this.bkI[i3] = (byte) (this.bkh[i3] + this.bkI[i4]);
            i3++;
            i4++;
        }
    }

    private void fj(int i) {
        for (int i2 = 1; i2 <= i; i2++) {
            this.bkI[i2] = (byte) (this.bkh[i2] + this.bkJ[i2]);
        }
    }

    @Override // com.kwad.sdk.pngencrypt.DeflatedChunksSet
    protected final void Ta() {
        super.Ta();
        this.bkL.update(Tc());
        Tl();
        p pVar = this.bkL;
        pVar.h(this.bkI, pVar.bls + 1);
    }

    @Override // com.kwad.sdk.pngencrypt.DeflatedChunksSet
    protected final int Tb() {
        return Tm();
    }

    private int Tm() {
        int iTk;
        e eVar = this.bjO;
        int i = 0;
        if (eVar == null) {
            if (Tc() < this.bkK.bkv - 1) {
                iTk = this.bkK.bkW;
                i = iTk + 1;
            }
        } else if (eVar.Td()) {
            iTk = this.bjO.Tk();
            i = iTk + 1;
        }
        if (!this.bjR) {
            fa(i);
        }
        return i;
    }

    @Override // com.kwad.sdk.pngencrypt.DeflatedChunksSet
    public final void close() {
        super.close();
        this.bkI = null;
        this.bkJ = null;
    }
}
