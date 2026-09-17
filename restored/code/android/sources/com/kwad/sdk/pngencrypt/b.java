package com.kwad.sdk.pngencrypt;

import java.io.Closeable;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b implements f, Closeable {
    static final /* synthetic */ boolean $assertionsDisabled = false;
    private final int bjA;
    private byte[] bjB;
    private int bjC;
    protected boolean bjD;
    protected boolean bjE;
    private int bjF;
    private long bjG;
    private DeflatedChunksSet bjH;
    private ChunkReader bjI;
    private long bjJ;
    private ErrorBehaviour bjK;
    private final byte[] bjz;
    protected boolean closed;

    private static String SR() {
        return "IHDR";
    }

    private static String SS() {
        return "IEND";
    }

    protected boolean C(int i, String str) {
        return false;
    }

    protected boolean SO() {
        return true;
    }

    protected abstract DeflatedChunksSet hi(String str);

    protected boolean hj(String str) {
        return false;
    }

    public b() {
        this(n.Tp());
    }

    private b(byte[] bArr) {
        this.bjB = new byte[8];
        this.bjC = 0;
        this.bjD = false;
        this.bjE = false;
        this.closed = false;
        this.bjF = 0;
        this.bjG = 0L;
        this.bjK = ErrorBehaviour.STRICT;
        this.bjz = bArr;
        int length = bArr == null ? 0 : bArr.length;
        this.bjA = length;
        this.bjD = length <= 0;
    }

    @Override // com.kwad.sdk.pngencrypt.f
    public int a(byte[] bArr, int i, int i2) {
        if (this.closed) {
            return -1;
        }
        if (i2 == 0) {
            return 0;
        }
        if (i2 < 0) {
            new PngjException("This should not happen. Bad length: " + i2);
        }
        if (this.bjD) {
            ChunkReader chunkReader = this.bjI;
            if (chunkReader == null || chunkReader.isDone()) {
                int i3 = this.bjC;
                int i4 = 8 - i3;
                if (i4 <= i2) {
                    i2 = i4;
                }
                System.arraycopy(bArr, i, this.bjB, i3, i2);
                int i5 = this.bjC + i2;
                this.bjC = i5;
                int i6 = i2 + 0;
                this.bjG += (long) i2;
                if (i5 != 8) {
                    return i6;
                }
                this.bjF++;
                c(n.g(this.bjB, 0), com.kwad.sdk.pngencrypt.chunk.b.i(this.bjB, 4), this.bjG - 8);
                this.bjC = 0;
                return i6;
            }
            int iA = this.bjI.a(bArr, i, i2);
            if (iA < 0) {
                return -1;
            }
            int i7 = iA + 0;
            this.bjG += (long) iA;
            return i7;
        }
        int i8 = this.bjA;
        int i9 = this.bjC;
        int i10 = i8 - i9;
        if (i10 <= i2) {
            i2 = i10;
        }
        System.arraycopy(bArr, i, this.bjB, i9, i2);
        int i11 = this.bjC + i2;
        this.bjC = i11;
        if (i11 == this.bjA) {
            l(this.bjB);
            this.bjC = 0;
            this.bjD = true;
        }
        int i12 = i2 + 0;
        this.bjG += (long) i2;
        return i12;
    }

    protected void c(int i, String str, long j) {
        if (str.length() != 4 || !com.kwad.sdk.pngencrypt.chunk.b.blA.matcher(str).matches()) {
            new PngjException("Bad chunk id: " + str);
        }
        if (i < 0) {
            new PngjException("Bad chunk len: " + i);
        }
        if (str.equals("IDAT")) {
            this.bjJ += (long) i;
        }
        boolean zSO = SO();
        boolean zC = C(i, str);
        boolean zHj = hj(str);
        DeflatedChunksSet deflatedChunksSet = this.bjH;
        boolean zHm = (deflatedChunksSet == null || deflatedChunksSet.isClosed()) ? false : this.bjH.hm(str);
        if (zHj && !zC) {
            if (!zHm) {
                DeflatedChunksSet deflatedChunksSet2 = this.bjH;
                if (deflatedChunksSet2 != null && !deflatedChunksSet2.isDone()) {
                    new PngjException("new IDAT-like chunk when previous was not done");
                }
                this.bjH = hi(str);
            }
            this.bjI = new d(i, str, zSO, j, this.bjH) { // from class: com.kwad.sdk.pngencrypt.b.1
                @Override // com.kwad.sdk.pngencrypt.d, com.kwad.sdk.pngencrypt.ChunkReader
                protected final void SN() {
                    super.SN();
                    b.this.a(this);
                }
            };
        } else {
            this.bjI = a(str, i, j, zC);
        }
        ChunkReader chunkReader = this.bjI;
        if (chunkReader == null || zSO) {
            return;
        }
        chunkReader.ci(false);
    }

    private ChunkReader a(String str, int i, long j, boolean z) {
        return new ChunkReader(i, str, j, z ? ChunkReader.ChunkReaderMode.SKIP : ChunkReader.ChunkReaderMode.BUFFER) { // from class: com.kwad.sdk.pngencrypt.b.2
            @Override // com.kwad.sdk.pngencrypt.ChunkReader
            protected final void SN() {
                b.this.a(this);
            }

            @Override // com.kwad.sdk.pngencrypt.ChunkReader
            protected final void a(int i2, byte[] bArr, int i3, int i4) {
                new PngjException("should never happen");
            }
        };
    }

    protected void a(ChunkReader chunkReader) {
        if (this.bjF == 1 && !SR().equals(chunkReader.SM().id)) {
            String str = "Bad first chunk: " + chunkReader.SM().id + " expected: " + SR();
            if (this.bjK.c < ErrorBehaviour.SUPER_LENIENT.c) {
                new PngjException(str);
            }
        }
        SS();
        if (chunkReader.SM().id.equals(SS())) {
            this.bjE = true;
            close();
        }
    }

    private static void l(byte[] bArr) {
        if (Arrays.equals(bArr, n.Tp())) {
            return;
        }
        new PngjException("Bad signature:" + Arrays.toString(bArr));
    }

    @Override // com.kwad.sdk.pngencrypt.f
    public final boolean isDone() {
        return this.bjE;
    }

    public final long SP() {
        return this.bjG;
    }

    public final DeflatedChunksSet SQ() {
        return this.bjH;
    }

    @Override // java.io.Closeable, java.lang.AutoCloseable
    public void close() {
        DeflatedChunksSet deflatedChunksSet = this.bjH;
        if (deflatedChunksSet != null) {
            deflatedChunksSet.close();
        }
        this.closed = true;
    }
}
