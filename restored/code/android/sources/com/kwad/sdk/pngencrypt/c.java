package com.kwad.sdk.pngencrypt;

import com.kwad.sdk.pngencrypt.chunk.ChunkLoadBehaviour;
import java.util.HashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends b {
    protected k bjM;
    protected k bjN;
    protected e bjO;
    protected int bjP = -1;
    protected com.kwad.sdk.pngencrypt.chunk.e bjQ = null;
    private long bjS = 0;
    private boolean bjT = true;
    private boolean bjU = false;
    private Set<String> bjV = new HashSet();
    private long bjW = 0;
    private long bjX = 0;
    private long bjY = 0;
    private ChunkLoadBehaviour bka = ChunkLoadBehaviour.LOAD_CHUNK_ALWAYS;
    protected final boolean bjR = false;
    private g bjZ = new com.kwad.sdk.pngencrypt.chunk.a();

    public c(boolean z) {
    }

    private void hk(String str) {
        if (str.equals("IHDR")) {
            if (this.bjP < 0) {
                this.bjP = 0;
                return;
            } else {
                new PngjException("unexpected chunk " + str);
                return;
            }
        }
        if (str.equals("PLTE")) {
            int i = this.bjP;
            if (i == 0 || i == 1) {
                this.bjP = 2;
                return;
            } else {
                new PngjException("unexpected chunk here " + str);
                return;
            }
        }
        if (str.equals("IDAT")) {
            int i2 = this.bjP;
            if (i2 >= 0 && i2 <= 4) {
                this.bjP = 4;
                return;
            } else {
                new PngjException("unexpected chunk " + str);
                return;
            }
        }
        if (str.equals("IEND")) {
            if (this.bjP >= 4) {
                this.bjP = 6;
                return;
            } else {
                new PngjException("unexpected chunk " + str);
                return;
            }
        }
        int i3 = this.bjP;
        if (i3 <= 1) {
            this.bjP = 1;
        } else if (i3 <= 3) {
            this.bjP = 3;
        } else {
            this.bjP = 5;
        }
    }

    @Override // com.kwad.sdk.pngencrypt.b
    public final boolean C(int i, String str) {
        if (super.C(i, str)) {
            return true;
        }
        if (this.bjW > 0 && ((long) i) + SP() > this.bjW) {
            new PngjException("Maximum total bytes to read exceeeded: " + this.bjW + " offset:" + SP() + " len=" + i);
        }
        if (this.bjV.contains(str)) {
            return true;
        }
        if (com.kwad.sdk.pngencrypt.chunk.b.ho(str)) {
            return false;
        }
        long j = this.bjX;
        if (j > 0 && i > j) {
            return true;
        }
        long j2 = this.bjY;
        if (j2 > 0 && i > j2 - this.bjS) {
            return true;
        }
        int i2 = AnonymousClass1.bkb[this.bka.ordinal()];
        if (i2 != 1) {
            if (i2 == 2) {
                return true;
            }
        } else if (!com.kwad.sdk.pngencrypt.chunk.b.hq(str)) {
            return true;
        }
        return false;
    }

    /* JADX INFO: renamed from: com.kwad.sdk.pngencrypt.c$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {
        static final /* synthetic */ int[] bkb;

        static {
            int[] iArr = new int[ChunkLoadBehaviour.values().length];
            bkb = iArr;
            try {
                iArr[ChunkLoadBehaviour.LOAD_CHUNK_IF_SAFE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                bkb[ChunkLoadBehaviour.LOAD_CHUNK_NEVER.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
        }
    }

    private int ST() {
        return this.bjP;
    }

    public final boolean SU() {
        return ST() < 4;
    }

    @Override // com.kwad.sdk.pngencrypt.b
    protected final void a(ChunkReader chunkReader) {
        super.a(chunkReader);
        if (chunkReader.SM().id.equals("IHDR")) {
            com.kwad.sdk.pngencrypt.chunk.i iVar = new com.kwad.sdk.pngencrypt.chunk.i(null);
            iVar.a(chunkReader.SM());
            k kVarTG = iVar.TG();
            this.bjM = kVarTG;
            this.bjN = kVarTG;
            if (iVar.TE()) {
                this.bjO = new e(this.bjN);
            }
            this.bjQ = new com.kwad.sdk.pngencrypt.chunk.e(this.bjM);
        }
        if (chunkReader.bjt == ChunkReader.ChunkReaderMode.BUFFER && hl(chunkReader.SM().id)) {
            this.bjS += (long) chunkReader.SM().len;
        }
        if (chunkReader.bjt == ChunkReader.ChunkReaderMode.BUFFER || this.bjU) {
            try {
                this.bjQ.a(this.bjZ.a(chunkReader.SM(), SW()), this.bjP);
            } catch (PngjException e) {
                throw e;
            }
        }
    }

    private static boolean hl(String str) {
        return !com.kwad.sdk.pngencrypt.chunk.b.ho(str);
    }

    @Override // com.kwad.sdk.pngencrypt.b
    protected final DeflatedChunksSet hi(String str) {
        return new j(str, this.bjR, SY(), this.bjO);
    }

    public final j SV() {
        DeflatedChunksSet deflatedChunksSetSQ = SQ();
        if (deflatedChunksSetSQ instanceof j) {
            return (j) deflatedChunksSetSQ;
        }
        return null;
    }

    @Override // com.kwad.sdk.pngencrypt.b
    protected final boolean hj(String str) {
        return str.equals("IDAT");
    }

    @Override // com.kwad.sdk.pngencrypt.b, com.kwad.sdk.pngencrypt.f
    public final int a(byte[] bArr, int i, int i2) {
        return super.a(bArr, i, i2);
    }

    public final k SW() {
        return this.bjM;
    }

    public final e SX() {
        return this.bjO;
    }

    @Override // com.kwad.sdk.pngencrypt.b
    protected final void c(int i, String str, long j) {
        hk(str);
        super.c(i, str, j);
    }

    @Override // com.kwad.sdk.pngencrypt.b, java.io.Closeable, java.lang.AutoCloseable
    public final void close() {
        if (this.bjP != 6) {
            this.bjP = 6;
        }
        super.close();
    }

    public final void aT(long j) {
        this.bjW = j;
    }

    public final void aU(long j) {
        this.bjX = j;
    }

    public final void aV(long j) {
        this.bjY = j;
    }

    @Override // com.kwad.sdk.pngencrypt.b
    protected final boolean SO() {
        return this.bjT;
    }

    public final void cj(boolean z) {
        this.bjT = false;
    }

    private k SY() {
        return this.bjN;
    }
}
