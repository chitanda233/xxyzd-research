package com.kwad.framework.filedownloader.download;

import android.os.Process;
import com.kuaishou.weapon.p0.g;
import com.kwad.framework.filedownloader.exception.FileDownloadGiveUpRetryException;
import com.kwad.framework.filedownloader.exception.FileDownloadHttpException;
import com.kwad.framework.filedownloader.exception.FileDownloadNetworkPolicyException;
import com.kwad.framework.filedownloader.exception.FileDownloadOutOfSpaceException;
import com.kwad.framework.filedownloader.y;
import com.kwad.sdk.crash.utils.h;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class DownloadLaunchRunnable implements f, Runnable {
    private static final ThreadPoolExecutor aBv = com.kwad.framework.filedownloader.f.b.ch("ConnectionBlock");
    private volatile boolean aBA;
    private volatile Exception aBB;
    private String aBC;
    private long aBD;
    private long aBE;
    private long aBF;
    private long aBG;
    private final com.kwad.framework.filedownloader.b.a aBf;
    private final d aBi;
    private final int aBj;
    private final com.kwad.framework.filedownloader.d.c aBk;
    private final com.kwad.framework.filedownloader.d.b aBl;
    private final boolean aBm;
    private final boolean aBn;
    private final y aBo;
    private boolean aBp;
    int aBq;
    private final boolean aBr;
    private final ArrayList<c> aBs;
    private e aBt;
    private boolean aBu;
    private boolean aBw;
    private boolean aBx;
    private boolean aBy;
    private final AtomicBoolean aBz;
    private volatile boolean nB;

    /* synthetic */ DownloadLaunchRunnable(com.kwad.framework.filedownloader.d.c cVar, com.kwad.framework.filedownloader.d.b bVar, y yVar, int i, int i2, boolean z, boolean z2, int i3, byte b) {
        this(cVar, bVar, yVar, i, i2, z, z2, i3);
    }

    private DownloadLaunchRunnable(com.kwad.framework.filedownloader.d.c cVar, com.kwad.framework.filedownloader.d.b bVar, y yVar, int i, int i2, boolean z, boolean z2, int i3) {
        this.aBj = 5;
        this.aBs = new ArrayList<>(5);
        this.aBD = 0L;
        this.aBE = 0L;
        this.aBF = 0L;
        this.aBG = 0L;
        this.aBz = new AtomicBoolean(true);
        this.nB = false;
        this.aBp = false;
        this.aBk = cVar;
        this.aBl = bVar;
        this.aBm = z;
        this.aBn = z2;
        this.aBf = b.Cm().Co();
        this.aBr = b.Cm().Cq();
        this.aBo = yVar;
        this.aBq = i3;
        this.aBi = new d(cVar, i3, i, i2);
    }

    public final void pause() {
        this.nB = true;
        e eVar = this.aBt;
        if (eVar != null) {
            eVar.pause();
        }
        for (c cVar : (ArrayList) this.aBs.clone()) {
            if (cVar != null) {
                cVar.pause();
            }
        }
    }

    public final void Cw() {
        if (this.aBk.Dm() > 1) {
            List<com.kwad.framework.filedownloader.d.a> listCt = this.aBf.ct(this.aBk.getId());
            if (this.aBk.Dm() == listCt.size()) {
                this.aBk.ac(com.kwad.framework.filedownloader.d.a.y(listCt));
            } else {
                this.aBk.ac(0L);
                this.aBf.cu(this.aBk.getId());
            }
        }
        this.aBi.CF();
    }

    /* JADX WARN: Code duplicated, block: B:14:0x006b  */
    /* JADX WARN: Code duplicated, block: B:156:0x025c A[Catch: all -> 0x0217, TryCatch #25 {all -> 0x0217, blocks: (B:46:0x00cf, B:95:0x01d4, B:97:0x01dd, B:98:0x01e1, B:154:0x0256, B:156:0x025c, B:159:0x0264, B:125:0x021a), top: B:205:0x0256 }] */
    /* JADX WARN: Code duplicated, block: B:161:0x0269 A[Catch: all -> 0x028f, TRY_ENTER, TryCatch #24 {all -> 0x028f, blocks: (B:3:0x0005, B:6:0x0014, B:8:0x001c, B:10:0x0020, B:11:0x0032, B:25:0x0090, B:27:0x0094, B:28:0x0099, B:30:0x009d, B:32:0x00a1, B:43:0x00ca, B:51:0x0129, B:74:0x019d, B:101:0x01e9, B:163:0x026f, B:164:0x0272, B:127:0x0222, B:161:0x0269, B:129:0x0229), top: B:204:0x0005 }] */
    /* JADX WARN: Code duplicated, block: B:163:0x026f A[Catch: all -> 0x028f, TryCatch #24 {all -> 0x028f, blocks: (B:3:0x0005, B:6:0x0014, B:8:0x001c, B:10:0x0020, B:11:0x0032, B:25:0x0090, B:27:0x0094, B:28:0x0099, B:30:0x009d, B:32:0x00a1, B:43:0x00ca, B:51:0x0129, B:74:0x019d, B:101:0x01e9, B:163:0x026f, B:164:0x0272, B:127:0x0222, B:161:0x0269, B:129:0x0229), top: B:204:0x0005 }] */
    /* JADX WARN: Code duplicated, block: B:168:0x027e  */
    /* JADX WARN: Code duplicated, block: B:17:0x0075  */
    /* JADX WARN: Code duplicated, block: B:202:0x0284 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:211:0x0264 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:212:0x0263 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:216:0x0099 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:218:? A[Catch: all -> 0x028f, SYNTHETIC, TRY_LEAVE, TryCatch #24 {all -> 0x028f, blocks: (B:3:0x0005, B:6:0x0014, B:8:0x001c, B:10:0x0020, B:11:0x0032, B:25:0x0090, B:27:0x0094, B:28:0x0099, B:30:0x009d, B:32:0x00a1, B:43:0x00ca, B:51:0x0129, B:74:0x019d, B:101:0x01e9, B:163:0x026f, B:164:0x0272, B:127:0x0222, B:161:0x0269, B:129:0x0229), top: B:204:0x0005 }] */
    @Override // java.lang.Runnable
    public final void run() {
        IOException iOException;
        Exception exc;
        Throwable th;
        long j;
        int iA;
        try {
            Process.setThreadPriority(10);
            if (this.aBk.AT() != 1) {
                if (this.aBk.AT() != -2) {
                    b(new RuntimeException(com.kwad.framework.filedownloader.f.f.c("Task[%d] can't start the download runnable, because its status is %d not %d", Integer.valueOf(this.aBk.getId()), Byte.valueOf(this.aBk.AT()), (byte) 1)));
                } else if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "High concurrent cause, start runnable but already paused %d", Integer.valueOf(this.aBk.getId()));
                }
                this.aBi.CE();
                if (this.nB) {
                    this.aBi.CI();
                } else if (this.aBA) {
                    this.aBi.c(this.aBB);
                } else {
                    try {
                        this.aBi.CJ();
                    } catch (IOException e) {
                        iOException = e;
                        this.aBi.c(iOException);
                    }
                }
            } else {
                if (!this.nB) {
                    this.aBi.CG();
                }
                while (true) {
                    if (this.nB) {
                        if (com.kwad.framework.filedownloader.f.d.aDt) {
                            com.kwad.framework.filedownloader.f.d.c(this, "High concurrent cause, start runnable but already paused %d", Integer.valueOf(this.aBk.getId()));
                        }
                        this.aBi.CE();
                        if (this.nB) {
                            this.aBi.CI();
                        } else if (this.aBA) {
                            this.aBi.c(this.aBB);
                        } else {
                            try {
                                this.aBi.CJ();
                            } catch (IOException e2) {
                                iOException = e2;
                                this.aBi.c(iOException);
                            }
                        }
                    } else {
                        if (this.aBf != null) {
                            com.kwad.framework.filedownloader.a.b bVar = null;
                            try {
                                Cz();
                                List<com.kwad.framework.filedownloader.d.a> listCt = this.aBf.ct(this.aBk.getId());
                                ConnectTask connectTaskCl = new ConnectTask.a().cA(this.aBk.getId()).bW(this.aBk.getUrl()).bX(this.aBk.Dk()).a(this.aBl).a(x(listCt)).Cl();
                                com.kwad.framework.filedownloader.a.b bVarCh = connectTaskCl.Ch();
                                try {
                                    a(connectTaskCl.getRequestHeader(), connectTaskCl, bVarCh);
                                    if (this.nB) {
                                        this.aBk.d((byte) -2);
                                        if (bVarCh != null) {
                                            bVarCh.Cc();
                                        }
                                        this.aBi.CE();
                                        if (this.nB) {
                                            this.aBi.CI();
                                        } else if (this.aBA) {
                                            this.aBi.c(this.aBB);
                                        } else {
                                            try {
                                                this.aBi.CJ();
                                            } catch (IOException e3) {
                                                iOException = e3;
                                                this.aBi.c(iOException);
                                            }
                                        }
                                    } else {
                                        CA();
                                        long total = this.aBk.getTotal();
                                        a(total, this.aBk.CB());
                                        if (!Cx()) {
                                            j = total;
                                            iA = 1;
                                        } else if (this.aBw) {
                                            iA = this.aBk.Dm();
                                            j = total;
                                        } else {
                                            j = total;
                                            iA = b.Cm().a(this.aBk.getId(), this.aBk.getUrl(), this.aBk.getPath(), j);
                                        }
                                        if (iA <= 0) {
                                            throw new IllegalAccessException(com.kwad.framework.filedownloader.f.f.c("invalid connection count %d, the connection count must be larger than 0", bVarCh));
                                        }
                                        if (this.nB) {
                                            this.aBk.d((byte) -2);
                                            if (bVarCh != null) {
                                                bVarCh.Cc();
                                            }
                                            this.aBi.CE();
                                            if (this.nB) {
                                                this.aBi.CI();
                                            } else if (this.aBA) {
                                                this.aBi.c(this.aBB);
                                            } else {
                                                try {
                                                    this.aBi.CJ();
                                                } catch (IOException e4) {
                                                    iOException = e4;
                                                    this.aBi.c(iOException);
                                                }
                                            }
                                        } else {
                                            boolean z = iA == 1;
                                            this.aBu = z;
                                            if (z) {
                                                a(connectTaskCl.Ck(), bVarCh);
                                            } else {
                                                if (bVarCh != null) {
                                                    bVarCh.Cc();
                                                } else {
                                                    bVar = bVarCh;
                                                }
                                                this.aBi.CH();
                                                if (this.aBw) {
                                                    a(iA, listCt);
                                                } else {
                                                    d(j, iA);
                                                }
                                                bVarCh = bVar;
                                            }
                                            if (bVarCh != null) {
                                                bVarCh.Cc();
                                            }
                                        }
                                    }
                                } catch (DiscardSafely unused) {
                                    bVar = bVarCh;
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (!this.nB) {
                                        if (this.aBA) {
                                            this.aBi.c(this.aBB);
                                        } else {
                                            try {
                                                this.aBi.CJ();
                                            } catch (IOException e5) {
                                                iOException = e5;
                                                this.aBi.c(iOException);
                                            }
                                        }
                                    }
                                    this.aBz.set(false);
                                } catch (RetryDirectly unused2) {
                                    bVar = bVarCh;
                                    this.aBk.d((byte) 5);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                } catch (FileDownloadGiveUpRetryException e6) {
                                    e = e6;
                                    exc = e;
                                    bVar = bVarCh;
                                    try {
                                        if (!a(exc)) {
                                            a(exc, 0L);
                                            if (bVar != null) {
                                                bVar.Cc();
                                            }
                                        } else {
                                            b(exc);
                                            if (bVar != null) {
                                                bVar.Cc();
                                            }
                                        }
                                    } catch (Throwable th2) {
                                        th = th2;
                                        if (bVar != null) {
                                            throw th;
                                        }
                                        bVar.Cc();
                                        throw th;
                                    }
                                } catch (IOException e7) {
                                    e = e7;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (ArrayIndexOutOfBoundsException e8) {
                                    e = e8;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (IllegalAccessException e9) {
                                    e = e9;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (IllegalArgumentException e10) {
                                    e = e10;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (InterruptedException e11) {
                                    e = e11;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (NullPointerException e12) {
                                    e = e12;
                                    exc = e;
                                    bVar = bVarCh;
                                    if (!a(exc)) {
                                        a(exc, 0L);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    } else {
                                        b(exc);
                                        if (bVar != null) {
                                            bVar.Cc();
                                        }
                                    }
                                } catch (Throwable th3) {
                                    th = th3;
                                    bVar = bVarCh;
                                    if (bVar != null) {
                                        throw th;
                                    }
                                    bVar.Cc();
                                    throw th;
                                }
                            } catch (DiscardSafely unused3) {
                            } catch (RetryDirectly unused4) {
                            } catch (FileDownloadGiveUpRetryException e13) {
                                e = e13;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        try {
                                            this.aBi.CJ();
                                        } catch (IOException e14) {
                                            iOException = e14;
                                            this.aBi.c(iOException);
                                        }
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (IOException e15) {
                                e = e15;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (ArrayIndexOutOfBoundsException e16) {
                                e = e16;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (IllegalAccessException e17) {
                                e = e17;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (IllegalArgumentException e18) {
                                e = e18;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (InterruptedException e19) {
                                e = e19;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            } catch (NullPointerException e20) {
                                e = e20;
                                exc = e;
                                if (!a(exc)) {
                                    b(exc);
                                    if (bVar != null) {
                                        bVar.Cc();
                                    }
                                    this.aBi.CE();
                                    if (this.nB) {
                                        this.aBi.CI();
                                    } else if (this.aBA) {
                                        this.aBi.c(this.aBB);
                                    } else {
                                        this.aBi.CJ();
                                    }
                                    this.aBz.set(false);
                                }
                                a(exc, 0L);
                                if (bVar != null) {
                                    bVar.Cc();
                                }
                            }
                        }
                        this.aBi.CE();
                        if (this.nB) {
                            this.aBi.CI();
                        } else if (this.aBA) {
                            this.aBi.c(this.aBB);
                        } else {
                            this.aBi.CJ();
                        }
                    }
                }
            }
            this.aBz.set(false);
        } catch (Throwable th4) {
            this.aBi.CE();
            if (this.nB) {
                this.aBi.CI();
            } else if (this.aBA) {
                this.aBi.c(this.aBB);
            } else {
                try {
                    this.aBi.CJ();
                } catch (IOException e21) {
                    this.aBi.c(e21);
                }
            }
            this.aBz.set(false);
            throw th4;
        }
    }

    private boolean Cx() {
        return (!this.aBw || this.aBk.Dm() > 1) && this.aBx && this.aBr && !this.aBy;
    }

    /* JADX WARN: Code duplicated, block: B:21:0x0054  */
    private com.kwad.framework.filedownloader.download.a x(List<com.kwad.framework.filedownloader.d.a> list) {
        long jDj;
        long j;
        int iDm = this.aBk.Dm();
        String strCB = this.aBk.CB();
        String targetFilePath = this.aBk.getTargetFilePath();
        boolean z = iDm > 1;
        if ((!z || this.aBr) && com.kwad.framework.filedownloader.f.f.b(this.aBk.getId(), this.aBk)) {
            if (!this.aBr) {
                jDj = new File(strCB).length();
            } else if (z) {
                if (iDm == list.size()) {
                    jDj = com.kwad.framework.filedownloader.d.a.y(list);
                } else {
                    j = 0;
                }
            } else {
                jDj = this.aBk.Dj();
            }
            j = jDj;
        } else {
            j = 0;
        }
        this.aBk.ac(j);
        boolean z2 = j > 0;
        this.aBw = z2;
        if (!z2) {
            this.aBf.cu(this.aBk.getId());
            com.kwad.framework.filedownloader.f.f.D(targetFilePath, strCB);
        }
        return new com.kwad.framework.filedownloader.download.a(0L, j, 0L, this.aBk.getTotal() - j);
    }

    private void a(Map<String, List<String>> map, ConnectTask connectTask, com.kwad.framework.filedownloader.a.b bVar) throws FileDownloadHttpException, RetryDirectly {
        int id = this.aBk.getId();
        int responseCode = bVar.getResponseCode();
        this.aBx = responseCode == 206 || responseCode == 1;
        boolean z = responseCode == 200 || responseCode == 201 || responseCode == 0;
        String strDk = this.aBk.Dk();
        String strA = com.kwad.framework.filedownloader.f.f.a(id, bVar);
        if (responseCode == 412 || !(strDk == null || strDk.equals(strA) || (!z && !this.aBx)) || ((responseCode == 201 && connectTask.Ci()) || (responseCode == 416 && this.aBk.Dj() > 0))) {
            if (this.aBw) {
                com.kwad.framework.filedownloader.f.d.d(this, "there is precondition failed on this request[%d] with old etag[%s]、new etag[%s]、response requestHttpCode is %d", Integer.valueOf(id), strDk, strA, Integer.valueOf(responseCode));
            }
            this.aBf.cu(this.aBk.getId());
            com.kwad.framework.filedownloader.f.f.D(this.aBk.getTargetFilePath(), this.aBk.CB());
            this.aBw = false;
            if (strDk != null && strDk.equals(strA)) {
                com.kwad.framework.filedownloader.f.d.d(this, "the old etag[%s] is the same to the new etag[%s], but the response status requestHttpCode is %d not Partial(206), so wo have to start this task from very beginning for task[%d]!", strDk, strA, Integer.valueOf(responseCode), Integer.valueOf(id));
                strA = null;
            }
            this.aBk.ac(0L);
            this.aBk.ae(0L);
            this.aBk.ce(strA);
            this.aBk.Dn();
            this.aBf.a(id, this.aBk.Dk(), this.aBk.Dj(), this.aBk.getTotal(), this.aBk.Dm());
            throw new RetryDirectly();
        }
        this.aBC = connectTask.Cj();
        if (this.aBx || z) {
            long jB = com.kwad.framework.filedownloader.f.f.b(id, bVar);
            String strA2 = this.aBk.AN() ? com.kwad.framework.filedownloader.f.f.a(bVar, this.aBk.getUrl()) : null;
            boolean z2 = jB == -1;
            this.aBy = z2;
            this.aBi.a(this.aBw && this.aBx, !z2 ? this.aBk.Dj() + jB : jB, strA, strA2);
            return;
        }
        throw new FileDownloadHttpException(responseCode, map, bVar.Cb());
    }

    private void a(com.kwad.framework.filedownloader.download.a aVar, com.kwad.framework.filedownloader.a.b bVar) throws Throwable {
        if (!this.aBx) {
            this.aBk.ac(0L);
            aVar = new com.kwad.framework.filedownloader.download.a(0L, 0L, aVar.aBa, aVar.contentLength);
        }
        e.a aVar2 = new e.a();
        aVar2.b(this).cE(this.aBk.getId()).cD(-1).bx(this.aBn).d(bVar).c(aVar).cc(this.aBk.CB());
        this.aBk.cL(1);
        this.aBf.w(this.aBk.getId(), 1);
        this.aBt = aVar2.CQ();
        if (this.nB) {
            this.aBk.d((byte) -2);
            this.aBt.pause();
        } else {
            this.aBt.run();
        }
    }

    private void a(int i, List<com.kwad.framework.filedownloader.d.a> list) {
        if (i <= 1 || list.size() != i) {
            throw new IllegalArgumentException();
        }
        b(list, this.aBk.getTotal());
    }

    private void d(long j, int i) {
        long j2 = j / ((long) i);
        int id = this.aBk.getId();
        ArrayList arrayList = new ArrayList();
        int i2 = 0;
        long j3 = 0;
        while (i2 < i) {
            long j4 = i2 == i + (-1) ? 0L : (j3 + j2) - 1;
            com.kwad.framework.filedownloader.d.a aVar = new com.kwad.framework.filedownloader.d.a();
            aVar.setId(id);
            aVar.setIndex(i2);
            aVar.setStartOffset(j3);
            aVar.aa(j3);
            aVar.ab(j4);
            arrayList.add(aVar);
            this.aBf.a(aVar);
            j3 += j2;
            i2++;
        }
        this.aBk.cL(i);
        this.aBf.w(id, i);
        b(arrayList, j);
    }

    private void b(List<com.kwad.framework.filedownloader.d.a> list, long j) {
        long jDg;
        int id = this.aBk.getId();
        String strDk = this.aBk.Dk();
        String url = this.aBC;
        if (url == null) {
            url = this.aBk.getUrl();
        }
        String strCB = this.aBk.CB();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "fetch data with multiple connection(count: [%d]) for task[%d] totalLength[%d]", Integer.valueOf(list.size()), Integer.valueOf(id), Long.valueOf(j));
        }
        boolean z = this.aBw;
        long j2 = 0;
        long jDf = 0;
        for (com.kwad.framework.filedownloader.d.a aVar : list) {
            if (aVar.Dg() == j2) {
                jDg = j - aVar.Df();
            } else {
                jDg = (aVar.Dg() - aVar.Df()) + 1;
            }
            long j3 = jDg;
            jDf += aVar.Df() - aVar.getStartOffset();
            if (j3 == j2) {
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "pass connection[%d-%d], because it has been completed", Integer.valueOf(aVar.getId()), Integer.valueOf(aVar.getIndex()));
                }
            } else {
                c cVarCD = new c.a().cB(id).i(Integer.valueOf(aVar.getIndex())).a(this).bZ(url).ca(z ? strDk : null).c(this.aBl).bv(this.aBn).b(new com.kwad.framework.filedownloader.download.a(aVar.getStartOffset(), aVar.Df(), aVar.Dg(), j3)).cb(strCB).CD();
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "enable multiple connection: %s", aVar);
                }
                this.aBs.add(cVarCD);
            }
            j2 = 0;
        }
        if (jDf != this.aBk.Dj()) {
            com.kwad.framework.filedownloader.f.d.d(this, "correct the sofar[%d] from connection table[%d]", Long.valueOf(this.aBk.Dj()), Long.valueOf(jDf));
            this.aBk.ac(jDf);
        }
        ArrayList arrayList = new ArrayList(this.aBs.size());
        for (c cVar : this.aBs) {
            if (this.nB) {
                cVar.pause();
            } else {
                arrayList.add(Executors.callable(cVar));
            }
        }
        if (this.nB) {
            this.aBk.d((byte) -2);
            return;
        }
        List<Future> listInvokeAll = aBv.invokeAll(arrayList);
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            for (Future future : listInvokeAll) {
                com.kwad.framework.filedownloader.f.d.c(this, "finish sub-task for [%d] %B %B", Integer.valueOf(id), Boolean.valueOf(future.isDone()), Boolean.valueOf(future.isCancelled()));
            }
        }
    }

    private void a(long j, String str) {
        com.kwad.framework.filedownloader.e.a aVarCq = null;
        if (j != -1) {
            try {
                aVarCq = com.kwad.framework.filedownloader.f.f.cq(this.aBk.CB());
                long length = new File(str).length();
                long j2 = j - length;
                long availableBytes = h.getAvailableBytes(str);
                if (availableBytes < j2) {
                    throw new FileDownloadOutOfSpaceException(availableBytes, j2, length);
                }
                if (!com.kwad.framework.filedownloader.f.e.DL().aDz) {
                    aVarCq.setLength(j);
                }
            } catch (Throwable th) {
                if (0 != 0) {
                    aVarCq.close();
                }
                throw th;
            }
        }
        if (aVarCq != null) {
            aVarCq.close();
        }
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final void onProgress(long j) {
        if (this.nB) {
            return;
        }
        this.aBi.onProgress(j);
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final void a(c cVar, long j, long j2) {
        if (this.nB) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "the task[%d] has already been paused, so pass the completed callback", Integer.valueOf(this.aBk.getId()));
                return;
            }
            return;
        }
        int i = cVar == null ? -1 : cVar.aBP;
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "the connection has been completed(%d): [%d, %d)  %d", Integer.valueOf(i), Long.valueOf(j), Long.valueOf(j2), Long.valueOf(this.aBk.getTotal()));
        }
        if (!this.aBu) {
            synchronized (this.aBs) {
                this.aBs.remove(cVar);
            }
        } else {
            if (j == 0 || j2 == this.aBk.getTotal()) {
                return;
            }
            com.kwad.framework.filedownloader.f.d.a(this, "the single task not completed corrected(%d, %d != %d) for task(%d)", Long.valueOf(j), Long.valueOf(j2), Long.valueOf(this.aBk.getTotal()), Integer.valueOf(this.aBk.getId()));
        }
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final boolean a(Exception exc) {
        if (exc instanceof FileDownloadHttpException) {
            int code = ((FileDownloadHttpException) exc).getCode();
            if (this.aBu && code == 416 && !this.aBp) {
                com.kwad.framework.filedownloader.f.f.D(this.aBk.getTargetFilePath(), this.aBk.CB());
                this.aBp = true;
                return true;
            }
        }
        return this.aBq > 0 && !(exc instanceof FileDownloadGiveUpRetryException);
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final void b(Exception exc) {
        this.aBA = true;
        this.aBB = exc;
        if (this.nB) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "the task[%d] has already been paused, so pass the error callback", Integer.valueOf(this.aBk.getId()));
            }
        } else {
            for (c cVar : (ArrayList) this.aBs.clone()) {
                if (cVar != null) {
                    cVar.BI();
                }
            }
        }
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final void a(Exception exc, long j) {
        if (this.nB) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "the task[%d] has already been paused, so pass the retry callback", Integer.valueOf(this.aBk.getId()));
            }
        } else {
            int i = this.aBq;
            int i2 = i - 1;
            this.aBq = i2;
            if (i < 0) {
                com.kwad.framework.filedownloader.f.d.a(this, "valid retry times is less than 0(%d) for download task(%d)", Integer.valueOf(i2), Integer.valueOf(this.aBk.getId()));
            }
            this.aBi.a(exc, this.aBq, j);
        }
    }

    @Override // com.kwad.framework.filedownloader.download.f
    public final void Cy() {
        this.aBf.b(this.aBk.getId(), this.aBk.Dj());
    }

    private void Cz() {
        if (this.aBn && !com.kwad.framework.filedownloader.f.f.co(g.b)) {
            throw new FileDownloadGiveUpRetryException(com.kwad.framework.filedownloader.f.f.c("Task[%d] can't start the download runnable, because this task require wifi, but user application nor current process has %s, so we can't check whether the network type connection.", Integer.valueOf(this.aBk.getId()), g.b));
        }
        if (this.aBn && com.kwad.framework.filedownloader.f.f.DQ()) {
            throw new FileDownloadNetworkPolicyException();
        }
    }

    private void CA() throws RetryDirectly, DiscardSafely {
        int id = this.aBk.getId();
        if (this.aBk.AN()) {
            String targetFilePath = this.aBk.getTargetFilePath();
            int iC = com.kwad.framework.filedownloader.f.f.C(this.aBk.getUrl(), targetFilePath);
            if (com.kwad.framework.filedownloader.f.c.a(id, targetFilePath, this.aBm, false)) {
                this.aBf.cv(id);
                this.aBf.cu(id);
                throw new DiscardSafely();
            }
            com.kwad.framework.filedownloader.d.c cVarCs = this.aBf.cs(iC);
            if (cVarCs != null) {
                if (com.kwad.framework.filedownloader.f.c.a(id, cVarCs, this.aBo, false)) {
                    this.aBf.cv(id);
                    this.aBf.cu(id);
                    throw new DiscardSafely();
                }
                List<com.kwad.framework.filedownloader.d.a> listCt = this.aBf.ct(iC);
                this.aBf.cv(iC);
                this.aBf.cu(iC);
                com.kwad.framework.filedownloader.f.f.cs(this.aBk.getTargetFilePath());
                if (com.kwad.framework.filedownloader.f.f.b(iC, cVarCs)) {
                    this.aBk.ac(cVarCs.Dj());
                    this.aBk.ae(cVarCs.getTotal());
                    this.aBk.ce(cVarCs.Dk());
                    this.aBk.cL(cVarCs.Dm());
                    this.aBf.b(this.aBk);
                    if (listCt != null) {
                        for (com.kwad.framework.filedownloader.d.a aVar : listCt) {
                            aVar.setId(id);
                            this.aBf.a(aVar);
                        }
                    }
                    throw new RetryDirectly();
                }
            }
            if (com.kwad.framework.filedownloader.f.c.a(id, this.aBk.Dj(), this.aBk.CB(), targetFilePath, this.aBo)) {
                this.aBf.cv(id);
                this.aBf.cu(id);
                throw new DiscardSafely();
            }
        }
    }

    public final int getId() {
        return this.aBk.getId();
    }

    public final boolean isAlive() {
        return this.aBz.get() || this.aBi.isAlive();
    }

    public final String CB() {
        return this.aBk.CB();
    }

    class RetryDirectly extends Throwable {
        private static final long serialVersionUID = -4127585119566978768L;

        RetryDirectly() {
        }
    }

    class DiscardSafely extends Throwable {
        private static final long serialVersionUID = 4243896780616180062L;

        DiscardSafely() {
        }
    }

    public static class a {
        private com.kwad.framework.filedownloader.d.b aAR;
        private Integer aBH;
        private Integer aBI;
        private Boolean aBJ;
        private Boolean aBK;
        private Integer aBL;
        private com.kwad.framework.filedownloader.d.c aBk;
        private y aBo;

        public final a e(com.kwad.framework.filedownloader.d.c cVar) {
            this.aBk = cVar;
            return this;
        }

        public final a b(com.kwad.framework.filedownloader.d.b bVar) {
            this.aAR = bVar;
            return this;
        }

        public final a a(y yVar) {
            this.aBo = yVar;
            return this;
        }

        public final a f(Integer num) {
            this.aBH = num;
            return this;
        }

        public final a g(Integer num) {
            this.aBI = num;
            return this;
        }

        public final a b(Boolean bool) {
            this.aBJ = bool;
            return this;
        }

        public final a c(Boolean bool) {
            this.aBK = bool;
            return this;
        }

        public final a h(Integer num) {
            this.aBL = num;
            return this;
        }

        public final DownloadLaunchRunnable CC() {
            if (this.aBk == null || this.aBo == null || this.aBH == null || this.aBI == null || this.aBJ == null || this.aBK == null || this.aBL == null) {
                throw new IllegalArgumentException();
            }
            return new DownloadLaunchRunnable(this.aBk, this.aAR, this.aBo, this.aBH.intValue(), this.aBI.intValue(), this.aBJ.booleanValue(), this.aBK.booleanValue(), this.aBL.intValue(), (byte) 0);
        }
    }
}
