package com.kwad.library.solder.lib.ext;

import android.os.Build;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private final int aEO;
    private final String aFc;
    private final String aFd;
    private final String aFe;
    private final String aFf;
    private final String aFg;
    private final String aFh;
    private final String aFi;
    private final boolean aFj;
    private final boolean aFk;
    private final boolean aFl;
    private ExecutorService aFm;
    private String aFn;
    private byte[] aFo;
    private boolean aFp;
    private int aFq;

    /* synthetic */ c(boolean z, boolean z2, String str, String str2, String str3, String str4, String str5, String str6, String str7, int i, String str8, byte[] bArr, boolean z3, boolean z4, ExecutorService executorService, int i2, byte b) {
        this(z, z2, str, str2, str3, str4, str5, str6, str7, i, str8, bArr, z3, z4, executorService, i2);
    }

    private c(boolean z, boolean z2, String str, String str2, String str3, String str4, String str5, String str6, String str7, int i, String str8, byte[] bArr, boolean z3, boolean z4, ExecutorService executorService, int i2) {
        this.aEO = i;
        this.aFc = str2;
        this.aFd = str3;
        this.aFe = str4;
        this.aFf = str5;
        this.aFg = str6;
        this.aFh = str7;
        this.aFi = str;
        this.aFj = z;
        this.aFk = z2;
        this.aFn = str8;
        this.aFo = bArr;
        this.aFp = z3;
        this.aFl = z4;
        this.aFm = executorService;
        this.aFq = i2;
    }

    public final int getRetryCount() {
        return this.aEO;
    }

    public final int Ex() {
        return this.aFq;
    }

    public final String Ey() {
        return this.aFc;
    }

    public final String Ez() {
        return this.aFd;
    }

    public final String EA() {
        return this.aFe;
    }

    public final String EB() {
        return this.aFf;
    }

    public final String EC() {
        return this.aFg;
    }

    public final String ED() {
        return this.aFh;
    }

    public final boolean EE() {
        return this.aFk;
    }

    public final boolean EF() {
        return this.aFl;
    }

    public final ExecutorService EG() {
        return this.aFm;
    }

    public static class a {
        private static final String aFr;
        private String aFi;
        private boolean aFl;
        private ExecutorService aFm;
        private String aFn;
        private byte[] aFo;
        private boolean aFp;
        private int aFs;
        private int aEO = 3;
        private String aFc = "sodler";
        private String aFd = "code-cache";
        private String aFe = "lib";
        private String aFf = "temp";
        private String aFh = aFr;
        private String aFg = ".tmp";
        private boolean aFk = false;
        private boolean aFj = false;

        static {
            aFr = EH() ? "base-1_apk" : "base-1.apk";
        }

        private static boolean EH() {
            return Build.VERSION.SDK_INT == 30 || Build.VERSION.SDK_INT == 31 || Build.VERSION.SDK_INT == 32;
        }

        public final a cG(String str) {
            this.aFc = str;
            return this;
        }

        public final a cY(int i) {
            if (i > 0) {
                this.aEO = i;
            }
            return this;
        }

        public final a bz(boolean z) {
            this.aFp = false;
            return this;
        }

        public final a bA(boolean z) {
            this.aFl = z;
            return this;
        }

        public final a a(ExecutorService executorService) {
            this.aFm = executorService;
            return this;
        }

        public final a cZ(int i) {
            this.aFs = i;
            return this;
        }

        public final c EI() {
            return new c(this.aFj, this.aFk, this.aFi, this.aFc, this.aFd, this.aFe, this.aFf, this.aFg, this.aFh, this.aEO, this.aFn, this.aFo, this.aFp, this.aFl, this.aFm, this.aFs, (byte) 0);
        }
    }
}
