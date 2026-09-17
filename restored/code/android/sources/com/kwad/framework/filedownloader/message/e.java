package com.kwad.framework.filedownloader.message;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private volatile g aCA;
    private volatile b aCB;

    public interface b {
        void r(MessageSnapshot messageSnapshot);
    }

    public static final class a {
        private static final e aCC = new e();
    }

    public static e Dd() {
        return a.aCC;
    }

    public final void a(b bVar) {
        this.aCB = bVar;
        if (bVar == null) {
            this.aCA = null;
        } else {
            this.aCA = new g(5, bVar);
        }
    }

    public final void s(MessageSnapshot messageSnapshot) {
        if (messageSnapshot instanceof com.kwad.framework.filedownloader.message.b) {
            if (this.aCB != null) {
                this.aCB.r(messageSnapshot);
            }
        } else if (this.aCA != null) {
            this.aCA.u(messageSnapshot);
        }
    }
}
