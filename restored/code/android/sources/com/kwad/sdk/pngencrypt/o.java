package com.kwad.sdk.pngencrypt;

import com.kwad.sdk.pngencrypt.chunk.w;
import java.io.Closeable;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class o implements Closeable {
    protected ErrorBehaviour bjK = ErrorBehaviour.STRICT;
    public final k bkK;
    public final boolean blg;
    protected final c blh;
    protected final a bli;
    protected final w blj;
    protected int blk;
    private i<? extends Object> bll;

    public o(InputStream inputStream, boolean z) {
        this.blk = -1;
        a aVar = new a(inputStream);
        this.bli = aVar;
        boolean z2 = true;
        aVar.ch(true);
        c cVarTv = Tv();
        this.blh = cVarTv;
        try {
            if (aVar.b(cVarTv, 36) != 36) {
                new PngjException("Could not read first 36 bytes (PNG signature+IHDR chunk)");
            }
            this.bkK = cVarTv.SW();
            if (cVarTv.SX() == null) {
                z2 = false;
            }
            this.blg = z2;
            aV(5024024L);
            aT(901001001L);
            aU(2024024L);
            this.blj = new w(cVarTv.bjQ);
            a(m.To());
            this.blk = -1;
        } catch (RuntimeException e) {
            this.bli.close();
            this.blh.close();
            throw e;
        }
    }

    private void Tr() {
        while (this.blh.bjP < 4) {
            if (this.bli.a(this.blh) <= 0) {
                new PngjException("Premature ending reading first chunks");
            }
        }
    }

    public final w Ts() {
        if (this.blh.SU()) {
            Tr();
        }
        return this.blj;
    }

    private void a(i<? extends Object> iVar) {
        this.bll = iVar;
    }

    public final void Tt() {
        Tu();
        if (this.blh.SU()) {
            Tr();
        }
        end();
    }

    private void aT(long j) {
        this.blh.aT(901001001L);
    }

    private void aV(long j) {
        this.blh.aV(5024024L);
    }

    private void aU(long j) {
        this.blh.aU(2024024L);
    }

    public final void end() {
        try {
            if (this.blh.SU()) {
                Tr();
            }
            if (this.blh.SV() != null && !this.blh.SV().isDone()) {
                this.blh.SV().GD();
            }
            while (!this.blh.isDone() && this.bli.a(this.blh) > 0) {
            }
        } finally {
            close();
        }
    }

    @Override // java.io.Closeable, java.lang.AutoCloseable
    public final void close() {
        com.kwad.sdk.pngencrypt.a.a.closeQuietly(this.blh);
        com.kwad.sdk.pngencrypt.a.a.closeQuietly(this.bli);
    }

    private void Tu() {
        this.blh.cj(false);
    }

    private static c Tv() {
        return new c(false);
    }

    public final String toString() {
        return this.bkK.toString() + " interlaced=" + this.blg;
    }
}
