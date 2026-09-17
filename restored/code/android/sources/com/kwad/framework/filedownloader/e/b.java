package com.kwad.framework.filedownloader.e;

import com.kwad.framework.filedownloader.f.c;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileDescriptor;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.RandomAccessFile;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.framework.filedownloader.e.a {
    private final BufferedOutputStream aDo;
    private final RandomAccessFile aDp;
    private final FileDescriptor fd;

    b(File file) {
        RandomAccessFile randomAccessFile = new RandomAccessFile(file, "rw");
        this.aDp = randomAccessFile;
        this.fd = randomAccessFile.getFD();
        this.aDo = new BufferedOutputStream(new FileOutputStream(randomAccessFile.getFD()));
    }

    @Override // com.kwad.framework.filedownloader.e.a
    public final void write(byte[] bArr, int i, int i2) throws IOException {
        this.aDo.write(bArr, 0, i2);
    }

    @Override // com.kwad.framework.filedownloader.e.a
    public final void DG() throws IOException {
        this.aDo.flush();
        this.fd.sync();
    }

    @Override // com.kwad.framework.filedownloader.e.a, java.io.Closeable, java.lang.AutoCloseable
    public final void close() throws IOException {
        this.aDo.close();
        this.aDp.close();
    }

    @Override // com.kwad.framework.filedownloader.e.a
    public final void seek(long j) throws IOException {
        this.aDp.seek(j);
    }

    @Override // com.kwad.framework.filedownloader.e.a
    public final void setLength(long j) throws IOException {
        this.aDp.setLength(j);
    }

    public static class a implements c.e {
        @Override // com.kwad.framework.filedownloader.f.c.e
        public final com.kwad.framework.filedownloader.e.a c(File file) {
            return new b(file);
        }
    }
}
