package com.kwad.framework.filedownloader.download;

import android.os.SystemClock;
import com.kwad.framework.filedownloader.exception.FileDownloadGiveUpRetryException;
import com.kwad.framework.filedownloader.exception.FileDownloadNetworkPolicyException;
import java.io.Closeable;
import java.io.IOException;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private final int aAQ;
    private final long aAY;
    long aAZ;
    private final f aBN;
    private final int aBP;
    private final long aBa;
    private final com.kwad.framework.filedownloader.b.a aBf;
    private final boolean aBn;
    private final c aCf;
    private final com.kwad.framework.filedownloader.a.b aCg;
    private com.kwad.framework.filedownloader.e.a aCh;
    private volatile long aCi;
    private volatile long aCj;
    private final String app;
    private final long contentLength;
    private volatile boolean nB;

    /* synthetic */ e(com.kwad.framework.filedownloader.a.b bVar, com.kwad.framework.filedownloader.download.a aVar, c cVar, int i, int i2, boolean z, f fVar, String str, byte b) {
        this(bVar, aVar, cVar, i, i2, z, fVar, str);
    }

    public final void pause() {
        this.nB = true;
    }

    private e(com.kwad.framework.filedownloader.a.b bVar, com.kwad.framework.filedownloader.download.a aVar, c cVar, int i, int i2, boolean z, f fVar, String str) {
        this.aCi = 0L;
        this.aCj = 0L;
        this.aBN = fVar;
        this.app = str;
        this.aCg = bVar;
        this.aBn = z;
        this.aCf = cVar;
        this.aBP = i2;
        this.aAQ = i;
        this.aBf = b.Cm().Co();
        this.aAY = aVar.aAY;
        this.aBa = aVar.aBa;
        this.aAZ = aVar.aAZ;
        this.contentLength = aVar.contentLength;
    }

    public final void run() throws Throwable {
        com.kwad.framework.filedownloader.e.a aVarCq;
        if (this.nB) {
            return;
        }
        long jB = com.kwad.framework.filedownloader.f.f.b(this.aBP, this.aCg);
        if (jB == 0) {
            throw new FileDownloadGiveUpRetryException(com.kwad.framework.filedownloader.f.f.c("there isn't any content need to download on %d-%d with the content-length is 0", Integer.valueOf(this.aAQ), Integer.valueOf(this.aBP)));
        }
        long j = this.contentLength;
        if (j > 0 && jB != j) {
            throw new FileDownloadGiveUpRetryException(com.kwad.framework.filedownloader.f.f.c("require %s with contentLength(%d), but the backend response contentLength is %d on downloadId[%d]-connectionIndex[%d], please ask your backend dev to fix such problem.", this.aBa == 0 ? com.kwad.framework.filedownloader.f.f.c("range[%d-)", Long.valueOf(this.aAZ)) : com.kwad.framework.filedownloader.f.f.c("range[%d-%d)", Long.valueOf(this.aAZ), Long.valueOf(this.aBa)), Long.valueOf(this.contentLength), Long.valueOf(jB), Integer.valueOf(this.aAQ), Integer.valueOf(this.aBP)));
        }
        long j2 = this.aAZ;
        try {
            boolean zCq = b.Cm().Cq();
            if (this.aCf != null && !zCq) {
                throw new IllegalAccessException("can't using multi-download when the output stream can't support seek");
            }
            aVarCq = com.kwad.framework.filedownloader.f.f.cq(this.app);
            try {
                this.aCh = aVarCq;
                if (zCq) {
                    aVarCq.seek(this.aAZ);
                }
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "start fetch(%d): range [%d, %d), seek to[%d]", Integer.valueOf(this.aBP), Long.valueOf(this.aAY), Long.valueOf(this.aBa), Long.valueOf(this.aAZ));
                }
                InputStream inputStream = this.aCg.getInputStream();
                byte[] bArr = new byte[4096];
                if (this.nB) {
                    com.kwad.sdk.crash.utils.b.closeQuietly(inputStream);
                    com.kwad.sdk.crash.utils.b.closeQuietly(aVarCq);
                    return;
                }
                while (true) {
                    int i = inputStream.read(bArr);
                    if (i == -1) {
                        break;
                    }
                    aVarCq.write(bArr, 0, i);
                    long j3 = i;
                    this.aAZ += j3;
                    this.aBN.onProgress(j3);
                    CP();
                    if (this.nB) {
                        break;
                    } else if (this.aBn && com.kwad.framework.filedownloader.f.f.DQ()) {
                        throw new FileDownloadNetworkPolicyException();
                    }
                }
                if (aVarCq != null) {
                    sync();
                }
                com.kwad.sdk.crash.utils.b.closeQuietly(inputStream);
                com.kwad.sdk.crash.utils.b.closeQuietly(aVarCq);
                long j4 = this.aAZ - j2;
                if (jB != -1 && jB != j4) {
                    throw new FileDownloadGiveUpRetryException(com.kwad.framework.filedownloader.f.f.c("fetched length[%d] != content length[%d], range[%d, %d) offset[%d] fetch begin offset", Long.valueOf(j4), Long.valueOf(jB), Long.valueOf(this.aAY), Long.valueOf(this.aBa), Long.valueOf(this.aAZ), Long.valueOf(j2)));
                }
                this.aBN.a(this.aCf, this.aAY, this.aBa);
            } catch (Throwable th) {
                th = th;
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                com.kwad.sdk.crash.utils.b.closeQuietly(aVarCq);
                throw th;
            }
        } catch (Throwable th2) {
            th = th2;
            aVarCq = null;
        }
    }

    private void CP() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (com.kwad.framework.filedownloader.f.f.i(this.aAZ - this.aCi, jElapsedRealtime - this.aCj)) {
            sync();
            this.aCi = this.aAZ;
            this.aCj = jElapsedRealtime;
        }
    }

    private void sync() {
        boolean z;
        long jUptimeMillis = SystemClock.uptimeMillis();
        try {
            this.aCh.DG();
            z = true;
        } catch (IOException e) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "Because of the system cannot guarantee that all the buffers have been synchronized with physical media, or write to filefailed, we just not flushAndSync process to database too %s", e);
            }
            z = false;
        }
        if (z) {
            if (this.aCf != null) {
                this.aBf.a(this.aAQ, this.aBP, this.aAZ);
            } else {
                this.aBN.Cy();
            }
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "require flushAndSync id[%d] index[%d] offset[%d], consume[%d]", Integer.valueOf(this.aAQ), Integer.valueOf(this.aBP), Long.valueOf(this.aAZ), Long.valueOf(SystemClock.uptimeMillis() - jUptimeMillis));
            }
        }
    }

    public static class a {
        Integer aAW;
        com.kwad.framework.filedownloader.download.a aAX;
        Boolean aBK;
        f aBN;
        Integer aBR;
        com.kwad.framework.filedownloader.a.b aCg;
        c aCk;
        String app;

        public final a d(com.kwad.framework.filedownloader.a.b bVar) {
            this.aCg = bVar;
            return this;
        }

        public final a c(com.kwad.framework.filedownloader.download.a aVar) {
            this.aAX = aVar;
            return this;
        }

        public final a b(f fVar) {
            this.aBN = fVar;
            return this;
        }

        public final a cc(String str) {
            this.app = str;
            return this;
        }

        public final a bx(boolean z) {
            this.aBK = Boolean.valueOf(z);
            return this;
        }

        public final a a(c cVar) {
            this.aCk = cVar;
            return this;
        }

        public final a cD(int i) {
            this.aBR = Integer.valueOf(i);
            return this;
        }

        public final a cE(int i) {
            this.aAW = Integer.valueOf(i);
            return this;
        }

        public final e CQ() {
            if (this.aBK == null || this.aCg == null || this.aAX == null || this.aBN == null || this.app == null || this.aAW == null || this.aBR == null) {
                throw new IllegalArgumentException();
            }
            return new e(this.aCg, this.aAX, this.aCk, this.aAW.intValue(), this.aBR.intValue(), this.aBK.booleanValue(), this.aBN, this.app, (byte) 0);
        }
    }
}
