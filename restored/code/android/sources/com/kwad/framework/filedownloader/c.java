package com.kwad.framework.filedownloader;

import android.text.TextUtils;
import java.io.File;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements com.kwad.framework.filedownloader.a, com.kwad.framework.filedownloader.a.InterfaceC0481a, d.a {
    private final x ayY;
    private final x.a ayZ;
    private int aza;
    private ArrayList<Object> azb;
    private String azc;
    private String azd;
    private boolean aze;
    private com.kwad.framework.filedownloader.d.b azf;
    private i azg;
    private Object azh;
    private final Object azq;
    private final String mUrl;
    private int azi = 0;
    private boolean azj = false;
    private boolean azk = false;
    private int azl = 100;
    private int azm = 10;
    private boolean azn = false;
    volatile int azo = 0;
    private boolean azp = false;
    private final Object azr = new Object();
    private volatile boolean azs = false;

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final com.kwad.framework.filedownloader.a Bb() {
        return this;
    }

    @Override // com.kwad.framework.filedownloader.d.a
    public final com.kwad.framework.filedownloader.a.InterfaceC0481a Bp() {
        return this;
    }

    static /* synthetic */ boolean a(c cVar, boolean z) {
        cVar.azp = true;
        return true;
    }

    c(String str) {
        this.mUrl = str;
        Object obj = new Object();
        this.azq = obj;
        d dVar = new d(this, obj);
        this.ayY = dVar;
        this.ayZ = dVar;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a bR(String str) {
        return c(str, false);
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a c(String str, boolean z) {
        this.azc = str;
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "setPath %s", str);
        }
        this.aze = z;
        if (z) {
            this.azd = null;
        } else {
            this.azd = new File(str).getName();
        }
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a a(i iVar) {
        this.azg = iVar;
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "setListener %s", iVar);
        }
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a i(Object obj) {
        this.azh = obj;
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "setTag %s", obj);
        }
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a bs(boolean z) {
        this.azn = true;
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a cf(int i) {
        this.azi = 3;
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a x(String str, String str2) {
        Bn();
        this.azf.z(str, str2);
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a bS(String str) {
        if (this.azf == null) {
            synchronized (this.azr) {
                if (this.azf == null) {
                    return this;
                }
            }
        }
        this.azf.cd(str);
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a bt(boolean z) {
        this.azj = z;
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a bu(boolean z) {
        this.azk = z;
        return this;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final com.kwad.framework.filedownloader.a.b AI() {
        return new a(this, (byte) 0);
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AJ() {
        if (isRunning()) {
            com.kwad.framework.filedownloader.f.d.d(this, "This task[%d] is running, if you want start the same task, please create a new one by FileDownloader#create", Integer.valueOf(getId()));
            return false;
        }
        this.azo = 0;
        this.azp = false;
        this.azs = false;
        this.ayY.reset();
        return true;
    }

    private boolean Bl() {
        return this.ayY.AT() != 0;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean isRunning() {
        if (r.BS().BW().d(this)) {
            return true;
        }
        return com.kwad.framework.filedownloader.d.d.cO(AT());
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AK() {
        return this.azo != 0;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int start() {
        if (this.azp) {
            throw new IllegalStateException("If you start the task manually, it means this task doesn't belong to a queue, so you must not invoke BaseDownloadTask#ready() or InQueueTask#enqueue() before you start() this method. For detail: If this task doesn't belong to a queue, what is just an isolated task, you just need to invoke BaseDownloadTask#start() to start this task, that's all. In other words, If this task doesn't belong to a queue, you must not invoke BaseDownloadTask#ready() method or InQueueTask#enqueue() method before invoke BaseDownloadTask#start(), If you do that and if there is the same listener object to start a queue in another thread, this task may be assembled by the queue, in that case, when you invoke BaseDownloadTask#start() manually to start this task or this task is started by the queue, there is an exception buried in there, because this task object is started two times without declare BaseDownloadTask#reuse() : 1. you invoke BaseDownloadTask#start() manually;  2. the queue start this task automatically.");
        }
        return Bm();
    }

    private int Bm() {
        if (Bl()) {
            if (isRunning()) {
                throw new IllegalStateException(com.kwad.framework.filedownloader.f.f.c("This task is running %d, if you want to start the same task, please create a new one by FileDownloader.create", Integer.valueOf(getId())));
            }
            throw new IllegalStateException("This task is dirty to restart, If you want to reuse this task, please invoke #reuse method manually and retry to restart again." + this.ayY.toString());
        }
        if (!AK()) {
            Be();
        }
        this.ayY.Bs();
        return getId();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean pause() {
        boolean zPause;
        synchronized (this.azq) {
            zPause = this.ayY.pause();
        }
        return zPause;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean cancel() {
        return pause();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int getId() {
        int i = this.aza;
        if (i != 0) {
            return i;
        }
        if (TextUtils.isEmpty(this.azc) || TextUtils.isEmpty(this.mUrl)) {
            return 0;
        }
        int iG = com.kwad.framework.filedownloader.f.f.g(this.mUrl, this.azc, this.aze);
        this.aza = iG;
        return iG;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final String getUrl() {
        return this.mUrl;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AL() {
        return this.azl;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AM() {
        return this.azm;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final String getPath() {
        return this.azc;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AN() {
        return this.aze;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final String getFilename() {
        return this.azd;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final String getTargetFilePath() {
        return com.kwad.framework.filedownloader.f.f.a(getPath(), AN(), getFilename());
    }

    @Override // com.kwad.framework.filedownloader.a
    public final i AO() {
        return this.azg;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AP() {
        return getSmallFileSoFarBytes();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int getSmallFileSoFarBytes() {
        if (this.ayY.Bt() > 2147483647L) {
            return Integer.MAX_VALUE;
        }
        return (int) this.ayY.Bt();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final long AQ() {
        return this.ayY.Bt();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AR() {
        return getSmallFileTotalBytes();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int getSmallFileTotalBytes() {
        if (this.ayY.getTotalBytes() > 2147483647L) {
            return Integer.MAX_VALUE;
        }
        return (int) this.ayY.getTotalBytes();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final long AS() {
        return this.ayY.getTotalBytes();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int getSpeed() {
        return this.ayY.getSpeed();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final byte AT() {
        return this.ayY.AT();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final long getStatusUpdateTime() {
        return this.ayY.getStatusUpdateTime();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AU() {
        return this.azn;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final Throwable AV() {
        return this.ayY.AV();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final Object getTag() {
        return this.azh;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AW() {
        return this.azi;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final int AX() {
        return this.ayY.AX();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AY() {
        return this.azj;
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean AZ() {
        return this.ayY.AZ();
    }

    @Override // com.kwad.framework.filedownloader.a
    public final boolean Ba() {
        return this.azk;
    }

    private void Bn() {
        if (this.azf == null) {
            synchronized (this.azr) {
                if (this.azf == null) {
                    this.azf = new com.kwad.framework.filedownloader.d.b();
                }
            }
        }
    }

    @Override // com.kwad.framework.filedownloader.d.a
    public final com.kwad.framework.filedownloader.d.b Bo() {
        return this.azf;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final void Bg() {
        this.azs = true;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final void free() {
        this.ayY.free();
        if (h.Bz().a(this)) {
            this.azs = false;
        }
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final void Bh() {
        Bm();
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final boolean Bi() {
        ArrayList<Object> arrayList = this.azb;
        return arrayList != null && arrayList.size() > 0;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final boolean Bf() {
        return this.azs;
    }

    @Override // com.kwad.framework.filedownloader.d.a
    public final void setFileName(String str) {
        this.azd = str;
    }

    @Override // com.kwad.framework.filedownloader.d.a
    public final ArrayList<Object> Bq() {
        return this.azb;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final x.a Bc() {
        return this.ayZ;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final boolean cg(int i) {
        return getId() == i;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final boolean isOver() {
        return com.kwad.framework.filedownloader.d.d.cN(AT());
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final int Bd() {
        return this.azo;
    }

    @Override // com.kwad.framework.filedownloader.a.InterfaceC0481a
    public final void Be() {
        int iHashCode;
        if (AO() != null) {
            iHashCode = AO().hashCode();
        } else {
            iHashCode = hashCode();
        }
        this.azo = iHashCode;
    }

    public final String toString() {
        return com.kwad.framework.filedownloader.f.f.c("%d@%s", Integer.valueOf(getId()), super.toString());
    }

    static final class a implements com.kwad.framework.filedownloader.a.b {
        private final c azt;

        /* synthetic */ a(c cVar, byte b) {
            this(cVar);
        }

        private a(c cVar) {
            this.azt = cVar;
            c.a(cVar, true);
        }

        @Override // com.kwad.framework.filedownloader.a.b
        public final int Bj() {
            int id = this.azt.getId();
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "add the task[%d] to the queue", Integer.valueOf(id));
            }
            h.Bz().c(this.azt);
            return id;
        }
    }
}
