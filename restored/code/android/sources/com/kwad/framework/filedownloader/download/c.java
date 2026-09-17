package com.kwad.framework.filedownloader.download;

import android.os.Process;
import com.kwad.framework.filedownloader.exception.FileDownloadGiveUpRetryException;
import java.io.IOException;
import java.net.SocketException;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements Runnable {
    private final int aAQ;
    private final ConnectTask aBM;
    private final f aBN;
    private e aBO;
    final int aBP;
    private final boolean aBn;
    private final String app;
    private volatile boolean nB;

    /* synthetic */ c(int i, int i2, ConnectTask connectTask, f fVar, boolean z, String str, byte b) {
        this(i, i2, connectTask, fVar, z, str);
    }

    private c(int i, int i2, ConnectTask connectTask, f fVar, boolean z, String str) {
        this.aAQ = i;
        this.aBP = i2;
        this.nB = false;
        this.aBN = fVar;
        this.app = str;
        this.aBM = connectTask;
        this.aBn = z;
    }

    public final void pause() {
        this.nB = true;
        e eVar = this.aBO;
        if (eVar != null) {
            eVar.pause();
        }
    }

    public final void BI() {
        pause();
    }

    @Override // java.lang.Runnable
    public final void run() {
        boolean z;
        Exception e;
        Process.setThreadPriority(10);
        long j = this.aBM.Ck().aAZ;
        com.kwad.framework.filedownloader.a.b bVarCh = null;
        boolean z2 = false;
        while (true) {
            try {
                if (this.nB) {
                    if (bVarCh != null) {
                        bVarCh.Cc();
                        return;
                    }
                    return;
                }
                try {
                    bVarCh = this.aBM.Ch();
                    int responseCode = bVarCh.getResponseCode();
                    if (com.kwad.framework.filedownloader.f.d.aDt) {
                        com.kwad.framework.filedownloader.f.d.c(this, "the connection[%d] for %d, is connected %s with requestHttpCode[%d]", Integer.valueOf(this.aBP), Integer.valueOf(this.aAQ), this.aBM.Ck(), Integer.valueOf(responseCode));
                    }
                    if (responseCode != 206 && responseCode != 200) {
                        throw new SocketException(com.kwad.framework.filedownloader.f.f.c("Connection failed with request[%s] response[%s] http-state[%d] on task[%d-%d], which is changed after verify connection, so please try again.", this.aBM.getRequestHeader(), bVarCh.Cb(), Integer.valueOf(responseCode), Integer.valueOf(this.aAQ), Integer.valueOf(this.aBP)));
                    }
                    try {
                        e.a aVar = new e.a();
                        if (!this.nB) {
                            e eVarCQ = aVar.cE(this.aAQ).cD(this.aBP).b(this.aBN).a(this).bx(this.aBn).d(bVarCh).c(this.aBM.Ck()).cc(this.app).CQ();
                            this.aBO = eVarCQ;
                            eVarCQ.run();
                            if (!this.nB) {
                                break;
                            }
                            this.aBO.pause();
                            break;
                        }
                        if (bVarCh != null) {
                            bVarCh.Cc();
                            return;
                        }
                        return;
                    } catch (FileDownloadGiveUpRetryException | IOException | ArrayIndexOutOfBoundsException | IllegalAccessException | IllegalArgumentException e2) {
                        e = e2;
                        z = true;
                        try {
                            if (!this.aBN.a(e)) {
                                this.aBN.b(e);
                                if (bVarCh != null) {
                                    bVarCh.Cc();
                                    return;
                                }
                                return;
                            }
                            if (z) {
                                e eVar = this.aBO;
                                if (eVar == null) {
                                    com.kwad.framework.filedownloader.f.d.d(this, "it is valid to retry and connection is valid but create fetch-data-task failed, so give up directly with %s", e);
                                    this.aBN.b(e);
                                    if (bVarCh != null) {
                                        bVarCh.Cc();
                                        return;
                                    }
                                    return;
                                }
                                this.aBN.a(e, eVar.aAZ - j);
                            } else {
                                this.aBN.a(e, 0L);
                            }
                            if (bVarCh != null) {
                                bVarCh.Cc();
                            }
                            z2 = z;
                        } catch (Throwable th) {
                            if (bVarCh != null) {
                                bVarCh.Cc();
                            }
                            throw th;
                        }
                    }
                } catch (FileDownloadGiveUpRetryException | IOException | ArrayIndexOutOfBoundsException | IllegalAccessException | IllegalArgumentException e3) {
                    e = e3;
                    z = false;
                }
            } catch (FileDownloadGiveUpRetryException | IOException | ArrayIndexOutOfBoundsException | IllegalAccessException | IllegalArgumentException e4) {
                z = z2;
                e = e4;
            }
            z2 = z;
        }
        if (bVarCh != null) {
            bVarCh.Cc();
        }
    }

    public static class a {
        private Boolean aBK;
        private f aBN;
        private final ConnectTask.a aBQ = new ConnectTask.a();
        private Integer aBR;
        private String app;

        public final a a(f fVar) {
            this.aBN = fVar;
            return this;
        }

        public final a cB(int i) {
            this.aBQ.cA(i);
            return this;
        }

        public final a bZ(String str) {
            this.aBQ.bW(str);
            return this;
        }

        public final a ca(String str) {
            this.aBQ.bX(str);
            return this;
        }

        public final a c(com.kwad.framework.filedownloader.d.b bVar) {
            this.aBQ.a(bVar);
            return this;
        }

        public final a b(com.kwad.framework.filedownloader.download.a aVar) {
            this.aBQ.a(aVar);
            return this;
        }

        public final a cb(String str) {
            this.app = str;
            return this;
        }

        public final a bv(boolean z) {
            this.aBK = Boolean.valueOf(z);
            return this;
        }

        public final a i(Integer num) {
            this.aBR = num;
            return this;
        }

        public final c CD() {
            if (this.aBN == null || this.app == null || this.aBK == null || this.aBR == null) {
                throw new IllegalArgumentException(com.kwad.framework.filedownloader.f.f.c("%s %s %B", this.aBN, this.app, this.aBK));
            }
            ConnectTask connectTaskCl = this.aBQ.Cl();
            return new c(connectTaskCl.aAQ, this.aBR.intValue(), connectTaskCl, this.aBN, this.aBK.booleanValue(), this.app, (byte) 0);
        }
    }
}
