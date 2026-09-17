package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.message.MessageSnapshot;
import java.io.File;
import java.io.IOException;
import java.security.InvalidParameterException;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class d implements com.kwad.framework.filedownloader.a.c, x, x.a, x.b {
    private final s.a azA;
    private long azB;
    private long azC;
    private int azD;
    private boolean azE;
    private boolean azF;
    private String azG;
    private final Object azq;
    private t azu;
    private final a azv;
    private volatile long azx;
    private final s.b azz;
    private volatile byte azw = 0;
    private Throwable azy = null;
    private boolean azH = false;

    interface a {
        com.kwad.framework.filedownloader.d.b Bo();

        com.kwad.framework.filedownloader.a.InterfaceC0481a Bp();

        ArrayList<Object> Bq();

        void setFileName(String str);
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final boolean a(MessageSnapshot messageSnapshot) {
        if (!com.kwad.framework.filedownloader.d.d.x(AT(), messageSnapshot.AT())) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "can't update mStatus change by keep ahead, %d, but the current mStatus is %d, %d", Byte.valueOf(this.azw), Byte.valueOf(AT()), Integer.valueOf(getId()));
            }
            return false;
        }
        e(messageSnapshot);
        return true;
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final boolean b(MessageSnapshot messageSnapshot) {
        byte bAT = AT();
        byte bAT2 = messageSnapshot.AT();
        if (-2 == bAT && com.kwad.framework.filedownloader.d.d.cO(bAT2)) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "High concurrent cause, callback pending, but has already be paused %d", Integer.valueOf(getId()));
            }
            return true;
        }
        if (!com.kwad.framework.filedownloader.d.d.y(bAT, bAT2)) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "can't update mStatus change by keep flow, %d, but the current mStatus is %d, %d", Byte.valueOf(this.azw), Byte.valueOf(AT()), Integer.valueOf(getId()));
            }
            return false;
        }
        e(messageSnapshot);
        return true;
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final boolean c(MessageSnapshot messageSnapshot) {
        if (!com.kwad.framework.filedownloader.d.d.f(this.azv.Bp().Bb())) {
            return false;
        }
        e(messageSnapshot);
        return true;
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final boolean d(MessageSnapshot messageSnapshot) {
        if (!this.azv.Bp().Bb().AN() || messageSnapshot.AT() != -4 || AT() != 2) {
            return false;
        }
        e(messageSnapshot);
        return true;
    }

    private void b(byte b) {
        this.azw = b;
        this.azx = System.currentTimeMillis();
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final t Br() {
        return this.azu;
    }

    @Override // com.kwad.framework.filedownloader.x.a
    public final MessageSnapshot n(Throwable th) {
        b((byte) -1);
        this.azy = th;
        return com.kwad.framework.filedownloader.message.f.a(getId(), Bt(), th);
    }

    /* JADX WARN: Multi-variable type inference failed */
    private void e(MessageSnapshot messageSnapshot) {
        com.kwad.framework.filedownloader.a aVarBb = this.azv.Bp().Bb();
        byte bAT = messageSnapshot.AT();
        b(bAT);
        this.azE = messageSnapshot.AZ();
        if (bAT == -4) {
            this.azz.reset();
            int iCh = h.Bz().ch(aVarBb.getId());
            if (iCh + ((iCh > 1 || !aVarBb.AN()) ? 0 : h.Bz().ch(com.kwad.framework.filedownloader.f.f.C(aVarBb.getUrl(), aVarBb.getTargetFilePath()))) <= 1) {
                byte bCm = n.BK().cm(aVarBb.getId());
                com.kwad.framework.filedownloader.f.d.d(this, "warn, but no mListener to receive, switch to pending %d %d", Integer.valueOf(aVarBb.getId()), Integer.valueOf(bCm));
                if (com.kwad.framework.filedownloader.d.d.cO(bCm)) {
                    b((byte) 1);
                    this.azC = messageSnapshot.CY();
                    long jDa = messageSnapshot.Da();
                    this.azB = jDa;
                    this.azz.start(jDa);
                    this.azu.f(((MessageSnapshot.a) messageSnapshot).Dc());
                    return;
                }
            }
            h.Bz().a(this.azv.Bp(), messageSnapshot);
            return;
        }
        if (bAT == -3) {
            this.azH = messageSnapshot.CZ();
            this.azB = messageSnapshot.CY();
            this.azC = messageSnapshot.CY();
            h.Bz().a(this.azv.Bp(), messageSnapshot);
            return;
        }
        if (bAT == -1) {
            this.azy = messageSnapshot.Db();
            this.azB = messageSnapshot.Da();
            h.Bz().a(this.azv.Bp(), messageSnapshot);
            return;
        }
        if (bAT == 1) {
            this.azB = messageSnapshot.Da();
            this.azC = messageSnapshot.CY();
            this.azu.f(messageSnapshot);
            return;
        }
        if (bAT == 2) {
            this.azC = messageSnapshot.CY();
            this.azF = messageSnapshot.CO();
            this.azG = messageSnapshot.getEtag();
            String fileName = messageSnapshot.getFileName();
            if (fileName != null) {
                if (aVarBb.getFilename() != null) {
                    com.kwad.framework.filedownloader.f.d.d(this, "already has mFilename[%s], but assign mFilename[%s] again", aVarBb.getFilename(), fileName);
                }
                this.azv.setFileName(fileName);
            }
            this.azz.start(this.azB);
            this.azu.h(messageSnapshot);
            return;
        }
        if (bAT == 3) {
            this.azB = messageSnapshot.Da();
            this.azz.X(messageSnapshot.Da());
            this.azu.i(messageSnapshot);
        } else if (bAT != 5) {
            if (bAT != 6) {
                return;
            }
            this.azu.g(messageSnapshot);
        } else {
            this.azB = messageSnapshot.Da();
            this.azy = messageSnapshot.Db();
            this.azD = messageSnapshot.AX();
            this.azz.reset();
            this.azu.k(messageSnapshot);
        }
    }

    @Override // com.kwad.framework.filedownloader.a.c
    public final void onBegin() {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.e(this, "filedownloader:lifecycle:start %s by %d ", toString(), Byte.valueOf(AT()));
        }
    }

    @Override // com.kwad.framework.filedownloader.a.c
    public final void Bk() {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.e(this, "filedownloader:lifecycle:over %s by %d ", toString(), Byte.valueOf(AT()));
        }
        this.azz.end(this.azB);
        if (this.azv.Bq() != null) {
            ArrayList arrayList = (ArrayList) this.azv.Bq().clone();
            int size = arrayList.size();
            for (int i = 0; i < size; i++) {
                arrayList.get(i);
            }
        }
        r.BS().BW().e(this.azv.Bp());
    }

    d(a aVar, Object obj) {
        this.azq = obj;
        this.azv = aVar;
        b bVar = new b();
        this.azz = bVar;
        this.azA = bVar;
        this.azu = new k(aVar.Bp(), this);
    }

    @Override // com.kwad.framework.filedownloader.x
    public final void Bs() {
        boolean z;
        synchronized (this.azq) {
            if (this.azw != 0) {
                com.kwad.framework.filedownloader.f.d.d(this, "High concurrent cause, this task %d will not input to launch pool, because of the status isn't idle : %d", Integer.valueOf(getId()), Byte.valueOf(this.azw));
                return;
            }
            b((byte) 10);
            com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481aBp = this.azv.Bp();
            com.kwad.framework.filedownloader.a aVarBb = interfaceC0481aBp.Bb();
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.e(this, "call start Url[%s], Path[%s] Listener[%s], Tag[%s]", aVarBb.getUrl(), aVarBb.getPath(), aVarBb.AO(), aVarBb.getTag());
            }
            try {
                prepare();
                z = true;
            } catch (Throwable th) {
                h.Bz().b(interfaceC0481aBp);
                h.Bz().a(interfaceC0481aBp, n(th));
                z = false;
            }
            if (z) {
                q.BQ().a(this);
            }
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.e(this, "the task[%d] has been into the launch pool.", Integer.valueOf(getId()));
            }
        }
    }

    @Override // com.kwad.framework.filedownloader.x
    public final boolean pause() {
        if (com.kwad.framework.filedownloader.d.d.cN(AT())) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "High concurrent cause, Already is over, can't pause again, %d %d", Byte.valueOf(AT()), Integer.valueOf(this.azv.Bp().Bb().getId()));
            }
            return false;
        }
        b((byte) -2);
        com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481aBp = this.azv.Bp();
        com.kwad.framework.filedownloader.a aVarBb = interfaceC0481aBp.Bb();
        q.BQ().b(this);
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.e(this, "the task[%d] has been expired from the launch pool.", Integer.valueOf(getId()));
        }
        r.BS();
        if (!r.BU()) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "request pause the task[%d] to the download service, but the download service isn't connected yet.", Integer.valueOf(aVarBb.getId()));
            }
        } else {
            n.BK().cl(aVarBb.getId());
        }
        h.Bz().b(interfaceC0481aBp);
        h.Bz().a(interfaceC0481aBp, com.kwad.framework.filedownloader.message.f.e(aVarBb));
        r.BS().BW().e(interfaceC0481aBp);
        return true;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final byte AT() {
        return this.azw;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final long getStatusUpdateTime() {
        return this.azx;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final void reset() {
        this.azy = null;
        this.azG = null;
        this.azF = false;
        this.azD = 0;
        this.azH = false;
        this.azE = false;
        this.azB = 0L;
        this.azC = 0L;
        this.azz.reset();
        if (com.kwad.framework.filedownloader.d.d.cN(this.azw)) {
            this.azu.BI();
            this.azu = new k(this.azv.Bp(), this);
        } else {
            this.azu.b(this.azv.Bp(), this);
        }
        b((byte) 0);
    }

    @Override // com.kwad.framework.filedownloader.s.a
    public final int getSpeed() {
        return this.azA.getSpeed();
    }

    @Override // com.kwad.framework.filedownloader.x
    public final long Bt() {
        return this.azB;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final long getTotalBytes() {
        return this.azC;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final Throwable AV() {
        return this.azy;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final int AX() {
        return this.azD;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final boolean AZ() {
        return this.azE;
    }

    @Override // com.kwad.framework.filedownloader.x
    public final void free() {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "free the task %d, when the status is %d", Integer.valueOf(getId()), Byte.valueOf(this.azw));
        }
        b((byte) 0);
    }

    private void prepare() throws IOException {
        File file;
        com.kwad.framework.filedownloader.a aVarBb = this.azv.Bp().Bb();
        if (aVarBb.getPath() == null) {
            aVarBb.bR(com.kwad.framework.filedownloader.f.f.ci(aVarBb.getUrl()));
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "save Path is null to %s", aVarBb.getPath());
            }
        }
        if (aVarBb.AN()) {
            file = new File(aVarBb.getPath());
        } else {
            String strCm = com.kwad.framework.filedownloader.f.f.cm(aVarBb.getPath());
            if (strCm == null) {
                throw new InvalidParameterException(com.kwad.framework.filedownloader.f.f.c("the provided mPath[%s] is invalid, can't find its directory", aVarBb.getPath()));
            }
            file = new File(strCm);
        }
        if (!file.exists() && !file.mkdirs() && !file.exists()) {
            throw new IOException(com.kwad.framework.filedownloader.f.f.c("Create parent directory failed, please make sure you have permission to create file or directory on the path: %s", file.getAbsolutePath()));
        }
    }

    private int getId() {
        return this.azv.Bp().Bb().getId();
    }

    @Override // com.kwad.framework.filedownloader.x.b
    public final void start() {
        if (this.azw != 10) {
            com.kwad.framework.filedownloader.f.d.d(this, "High concurrent cause, this task %d will not start, because the of status isn't toLaunchPool: %d", Integer.valueOf(getId()), Byte.valueOf(this.azw));
            return;
        }
        com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481aBp = this.azv.Bp();
        com.kwad.framework.filedownloader.a aVarBb = interfaceC0481aBp.Bb();
        v vVarBW = r.BS().BW();
        try {
            if (vVarBW.f(interfaceC0481aBp)) {
                return;
            }
            synchronized (this.azq) {
                if (this.azw != 10) {
                    com.kwad.framework.filedownloader.f.d.d(this, "High concurrent cause, this task %d will not start, the status can't assign to toFileDownloadService, because the status isn't toLaunchPool: %d", Integer.valueOf(getId()), Byte.valueOf(this.azw));
                    return;
                }
                b((byte) 11);
                h.Bz().b(interfaceC0481aBp);
                if (com.kwad.framework.filedownloader.f.c.a(aVarBb.getId(), aVarBb.getTargetFilePath(), aVarBb.AU(), true)) {
                    return;
                }
                boolean zA = n.BK().a(aVarBb.getUrl(), aVarBb.getPath(), aVarBb.AN(), aVarBb.AL(), aVarBb.AM(), aVarBb.AW(), aVarBb.AU(), this.azv.Bo(), aVarBb.Ba());
                if (this.azw == -2) {
                    com.kwad.framework.filedownloader.f.d.d(this, "High concurrent cause, this task %d will be paused,because of the status is paused, so the pause action must be applied", Integer.valueOf(getId()));
                    if (zA) {
                        n.BK().cl(getId());
                        return;
                    }
                    return;
                }
                if (!zA) {
                    if (vVarBW.f(interfaceC0481aBp)) {
                        return;
                    }
                    MessageSnapshot messageSnapshotN = n(new RuntimeException("Occur Unknown Error, when request to start maybe some problem in binder, maybe the process was killed in unexpected."));
                    if (h.Bz().a(interfaceC0481aBp)) {
                        vVarBW.e(interfaceC0481aBp);
                        h.Bz().b(interfaceC0481aBp);
                    }
                    h.Bz().a(interfaceC0481aBp, messageSnapshotN);
                    return;
                }
                vVarBW.e(interfaceC0481aBp);
            }
        } catch (Throwable th) {
            th.printStackTrace();
            h.Bz().a(interfaceC0481aBp, n(th));
        }
    }
}
