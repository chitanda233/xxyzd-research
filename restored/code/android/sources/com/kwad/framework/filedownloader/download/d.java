package com.kwad.framework.filedownloader.download;

import android.database.sqlite.SQLiteFullException;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.Message;
import android.os.SystemClock;
import com.kwad.framework.filedownloader.exception.FileDownloadGiveUpRetryException;
import com.kwad.framework.filedownloader.exception.FileDownloadOutOfSpaceException;
import com.kwad.sdk.crash.utils.h;
import java.io.File;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicLong;
import java.util.concurrent.locks.LockSupport;

/* JADX INFO: loaded from: classes3.dex */
public final class d implements Handler.Callback {
    private volatile Thread aAF;
    private final a aBS;
    private final int aBT;
    private final int aBU;
    private final int aBV;
    private long aBW;
    private HandlerThread aBX;
    private final com.kwad.framework.filedownloader.d.c aBk;
    private volatile boolean aCa;
    private Handler handler;
    private volatile boolean aBY = false;
    private volatile long aBE = 0;
    private final AtomicLong aBZ = new AtomicLong();
    private boolean aCb = true;
    private final com.kwad.framework.filedownloader.b.a aBf = b.Cm().Co();

    d(com.kwad.framework.filedownloader.d.c cVar, int i, int i2, int i3) {
        this.aBk = cVar;
        this.aBU = i2 < 5 ? 5 : i2;
        this.aBV = i3;
        this.aBS = new a();
        this.aBT = i;
    }

    public final boolean isAlive() {
        HandlerThread handlerThread = this.aBX;
        return handlerThread != null && handlerThread.isAlive();
    }

    final void CE() {
        Handler handler = this.handler;
        if (handler != null) {
            handler.removeCallbacksAndMessages(null);
            this.aBX.quit();
            this.aAF = Thread.currentThread();
            while (this.aBY) {
                LockSupport.parkNanos(TimeUnit.MILLISECONDS.toNanos(100L));
            }
            this.aAF = null;
        }
    }

    public final void CF() {
        this.aBk.d((byte) 1);
        this.aBf.cw(this.aBk.getId());
        c((byte) 1);
    }

    final void CG() {
        this.aBk.d((byte) 6);
        c((byte) 6);
        this.aBf.cr(this.aBk.getId());
    }

    final void a(boolean z, long j, String str, String str2) {
        String strDk = this.aBk.Dk();
        if (strDk != null && !strDk.equals(str)) {
            throw new IllegalArgumentException(com.kwad.framework.filedownloader.f.f.c("callback onConnected must with precondition succeed, but the etag is changes(%s != %s)", str, strDk));
        }
        this.aBS.bw(z);
        this.aBk.d((byte) 2);
        this.aBk.ae(j);
        this.aBk.ce(str);
        this.aBk.cg(str2);
        this.aBf.a(this.aBk.getId(), j, str, str2);
        c((byte) 2);
        this.aBW = h(j, this.aBV);
        this.aCa = true;
    }

    final void CH() {
        HandlerThread handlerThread = new HandlerThread("source-status-callback", 10);
        this.aBX = handlerThread;
        handlerThread.start();
        this.handler = new Handler(this.aBX.getLooper(), this);
    }

    final void onProgress(long j) {
        this.aBZ.addAndGet(j);
        this.aBk.ad(j);
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        boolean Z = Z(jElapsedRealtime);
        Handler handler = this.handler;
        if (handler == null) {
            b(jElapsedRealtime, Z);
        } else if (Z) {
            b(handler.obtainMessage(3));
        }
    }

    final void a(Exception exc, int i, long j) {
        this.aBZ.set(0L);
        this.aBk.ad(-j);
        Handler handler = this.handler;
        if (handler == null) {
            a(exc, i);
        } else {
            b(handler.obtainMessage(5, i, 0, exc));
        }
    }

    final void CI() {
        CN();
    }

    final void c(Exception exc) {
        e(exc);
    }

    final void CJ() {
        if (CM()) {
            return;
        }
        CL();
    }

    private synchronized void b(Message message) {
        if (!this.aBX.isAlive()) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "require callback %d but the host thread of the flow has already dead, what is occurred because of there are several reason can final this flow on different thread.", Integer.valueOf(message.what));
            }
            return;
        }
        try {
            this.handler.sendMessage(message);
        } catch (IllegalStateException e) {
            if (!this.aBX.isAlive()) {
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "require callback %d but the host thread of the flow has already dead, what is occurred because of there are several reason can final this flow on different thread.", Integer.valueOf(message.what));
                    return;
                }
                return;
            }
            throw e;
        }
    }

    private static long h(long j, long j2) {
        if (j2 <= 0) {
            return -1L;
        }
        if (j == -1) {
            return 1L;
        }
        long j3 = j / (j2 + 1);
        if (j3 <= 0) {
            return 1L;
        }
        return j3;
    }

    private Exception d(Exception exc) {
        long length;
        String strCB = this.aBk.CB();
        if ((!this.aBk.isChunked() && !com.kwad.framework.filedownloader.f.e.DL().aDz) || !(exc instanceof IOException) || !new File(strCB).exists()) {
            return exc;
        }
        long availableBytes = h.getAvailableBytes(strCB);
        if (availableBytes > 4096) {
            return exc;
        }
        File file = new File(strCB);
        if (!file.exists()) {
            com.kwad.framework.filedownloader.f.d.a(this, exc, "Exception with: free space isn't enough, and the target file not exist.", new Object[0]);
            length = 0;
        } else {
            length = file.length();
        }
        return new FileDownloadOutOfSpaceException(availableBytes, 4096L, length, exc);
    }

    private void a(SQLiteFullException sQLiteFullException) {
        int id = this.aBk.getId();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "the data of the task[%d] is dirty, because the SQLite full exception[%s], so remove it from the database directly.", Integer.valueOf(id), sQLiteFullException.toString());
        }
        this.aBk.cf(sQLiteFullException.toString());
        this.aBk.d((byte) -1);
        this.aBf.cv(id);
        this.aBf.cu(id);
    }

    private void CK() {
        String strCB = this.aBk.CB();
        String targetFilePath = this.aBk.getTargetFilePath();
        File file = new File(strCB);
        try {
            File file2 = new File(targetFilePath);
            if (file2.exists()) {
                long length = file2.length();
                if (!file2.delete()) {
                    throw new IOException(com.kwad.framework.filedownloader.f.f.c("Can't delete the old file([%s], [%d]), so can't replace it with the new downloaded one.", targetFilePath, Long.valueOf(length)));
                }
                com.kwad.framework.filedownloader.f.d.d(this, "The target file([%s], [%d]) will be replaced with the new downloaded file[%d]", targetFilePath, Long.valueOf(length), Long.valueOf(file.length()));
            }
            if (!file.renameTo(file2)) {
                throw new IOException(com.kwad.framework.filedownloader.f.f.c("Can't rename the  temp downloaded file(%s) to the target file(%s)", strCB, targetFilePath));
            }
            if (!file.exists() || file.delete()) {
                return;
            }
            com.kwad.framework.filedownloader.f.d.d(this, "delete the temp file(%s) failed, on completed downloading.", strCB);
        } catch (Throwable th) {
            if (file.exists() && !file.delete()) {
                com.kwad.framework.filedownloader.f.d.d(this, "delete the temp file(%s) failed, on completed downloading.", strCB);
            }
            throw th;
        }
    }

    /* JADX WARN: Code duplicated, block: B:11:0x0024  */
    @Override // android.os.Handler.Callback
    public final boolean handleMessage(Message message) {
        this.aBY = true;
        int i = message.what;
        try {
            if (i == 3) {
                b(SystemClock.elapsedRealtime(), true);
            } else {
                if (i == 5) {
                    a((Exception) message.obj, message.arg1);
                }
                this.aBY = false;
                if (this.aAF != null) {
                    LockSupport.unpark(this.aAF);
                }
                return true;
            }
            this.aBY = false;
            if (this.aAF != null) {
                LockSupport.unpark(this.aAF);
            }
            return true;
        } catch (Throwable th) {
            this.aBY = false;
            if (this.aAF != null) {
                LockSupport.unpark(this.aAF);
            }
            throw th;
        }
    }

    private void b(long j, boolean z) {
        if (this.aBk.Dj() == this.aBk.getTotal()) {
            this.aBf.b(this.aBk.getId(), this.aBk.Dj());
            return;
        }
        if (this.aCa) {
            this.aCa = false;
            this.aBk.d((byte) 3);
        }
        if (z) {
            this.aBE = j;
            c((byte) 3);
            this.aBZ.set(0L);
        }
    }

    private void CL() {
        CK();
        this.aBk.d((byte) -3);
        this.aBf.c(this.aBk.getId(), this.aBk.getTotal());
        this.aBf.cu(this.aBk.getId());
        c((byte) -3);
        if (com.kwad.framework.filedownloader.f.e.DL().aDA) {
            com.kwad.framework.filedownloader.services.f.f(this.aBk);
        }
    }

    private boolean CM() {
        if (this.aBk.isChunked()) {
            com.kwad.framework.filedownloader.d.c cVar = this.aBk;
            cVar.ae(cVar.Dj());
        } else if (this.aBk.Dj() != this.aBk.getTotal()) {
            c(new FileDownloadGiveUpRetryException(com.kwad.framework.filedownloader.f.f.c("sofar[%d] not equal total[%d]", Long.valueOf(this.aBk.Dj()), Long.valueOf(this.aBk.getTotal()))));
            return true;
        }
        return false;
    }

    private void a(Exception exc, int i) {
        Exception excD = d(exc);
        this.aBS.f(excD);
        this.aBS.cC(this.aBT - i);
        this.aBk.d((byte) 5);
        this.aBk.cf(excD.toString());
        this.aBf.a(this.aBk.getId(), excD);
        c((byte) 5);
    }

    private void CN() {
        this.aBk.d((byte) -2);
        this.aBf.d(this.aBk.getId(), this.aBk.Dj());
        c((byte) -2);
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$PrimitiveArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    private void e(Exception exc) {
        SQLiteFullException sQLiteFullException;
        Exception excD = d(exc);
        if (excD instanceof SQLiteFullException) {
            a((SQLiteFullException) excD);
            sQLiteFullException = excD;
        } else {
            try {
                this.aBk.d((byte) -1);
                this.aBk.cf(exc.toString());
                this.aBf.a(this.aBk.getId(), excD, this.aBk.Dj());
                sQLiteFullException = excD;
            } catch (SQLiteFullException e) {
                SQLiteFullException sQLiteFullException2 = e;
                a(sQLiteFullException2);
                sQLiteFullException = sQLiteFullException2;
            }
        }
        this.aBS.f(sQLiteFullException);
        c((byte) -1);
    }

    private boolean Z(long j) {
        if (!this.aCb) {
            return this.aBW != -1 && this.aBZ.get() >= this.aBW && j - this.aBE >= ((long) this.aBU);
        }
        this.aCb = false;
        return true;
    }

    private void c(byte b) {
        if (b == -2) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "High concurrent cause, Already paused and we don't need to call-back to Task in here, %d", Integer.valueOf(this.aBk.getId()));
                return;
            }
            return;
        }
        com.kwad.framework.filedownloader.message.e.Dd().s(com.kwad.framework.filedownloader.message.f.a(b, this.aBk, this.aBS));
    }

    public static class a {
        private boolean aCc;
        private Exception aCd;
        private int aCe;

        final void bw(boolean z) {
            this.aCc = z;
        }

        public final boolean CO() {
            return this.aCc;
        }

        final void f(Exception exc) {
            this.aCd = exc;
        }

        final void cC(int i) {
            this.aCe = i;
        }

        public final Exception getException() {
            return this.aCd;
        }

        public final int AX() {
            return this.aCe;
        }
    }
}
