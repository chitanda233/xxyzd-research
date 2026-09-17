package com.kwad.sdk.pngencrypt.chunk;

/* JADX INFO: loaded from: classes3.dex */
public abstract class PngChunk {
    protected final com.kwad.sdk.pngencrypt.k bkK;
    public final boolean blK;
    public final boolean blL;
    public final boolean blM;
    protected d blN;
    private boolean blO = false;
    protected int blP = -1;
    public final String id;

    protected abstract void a(d dVar);

    public enum ChunkOrderingConstraint {
        NONE,
        BEFORE_PLTE_AND_IDAT,
        AFTER_PLTE_BEFORE_IDAT,
        AFTER_PLTE_BEFORE_IDAT_PLTE_REQUIRED,
        BEFORE_IDAT,
        AFTER_IDAT,
        NA;

        public final boolean mustGoBeforePLTE() {
            return this == BEFORE_PLTE_AND_IDAT;
        }

        public final boolean mustGoBeforeIDAT() {
            return this == BEFORE_IDAT || this == BEFORE_PLTE_AND_IDAT || this == AFTER_PLTE_BEFORE_IDAT;
        }

        public final boolean mustGoAfterPLTE() {
            return this == AFTER_PLTE_BEFORE_IDAT || this == AFTER_PLTE_BEFORE_IDAT_PLTE_REQUIRED;
        }

        public final boolean mustGoAfterIDAT() {
            return this == AFTER_IDAT;
        }

        public final boolean isOk(int i, boolean z) {
            if (this == NONE) {
                return true;
            }
            if (this == BEFORE_IDAT) {
                return i < 4;
            }
            if (this == BEFORE_PLTE_AND_IDAT) {
                return i < 2;
            }
            if (this != AFTER_PLTE_BEFORE_IDAT) {
                return this == AFTER_IDAT && i > 4;
            }
            if (z) {
                return i < 4;
            }
            return i < 4 && i > 2;
        }
    }

    public PngChunk(String str, com.kwad.sdk.pngencrypt.k kVar) {
        this.id = str;
        this.bkK = kVar;
        this.blK = b.ho(str);
        this.blL = b.hp(str);
        this.blM = b.hq(str);
    }

    final void fk(int i) {
        this.blP = i;
    }

    final void b(d dVar) {
        this.blN = dVar;
    }

    private int TA() {
        d dVar = this.blN;
        if (dVar != null) {
            return dVar.len;
        }
        return -1;
    }

    private long Ty() {
        d dVar = this.blN;
        if (dVar != null) {
            return dVar.Ty();
        }
        return -1L;
    }

    public String toString() {
        return "chunk id= " + this.id + " (len=" + TA() + " offset=" + Ty() + ")";
    }
}
