package com.sigmob.sdk.downloader.core.interceptor;

import com.sigmob.sdk.downloader.core.download.f;
import com.sigmob.sdk.downloader.core.exception.g;
import java.io.IOException;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes3.dex */
public class a implements c.a, c.b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3441a = "BreakpointInterceptor";
    private static final Pattern b = Pattern.compile(".*\\d+ *- *(\\d+) */ *\\d+");

    static long a(String contentRange) {
        Matcher matcher = b.matcher(contentRange);
        if (matcher.find()) {
            return Long.parseLong(matcher.group(1));
        }
        return -1L;
    }

    /* JADX WARN: Code duplicated, block: B:7:0x001a  */
    long a(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) {
        long j;
        String strC = connected.c(com.sigmob.sdk.downloader.core.c.f);
        if (com.sigmob.sdk.downloader.core.c.a((CharSequence) strC)) {
            j = -1;
        } else {
            long jA = a(strC);
            if (jA > 0) {
                j = jA + 1;
            } else {
                j = -1;
            }
        }
        if (j >= 0) {
            return j;
        }
        String strC2 = connected.c(com.sigmob.sdk.downloader.core.c.e);
        return !com.sigmob.sdk.downloader.core.c.a((CharSequence) strC2) ? Long.parseLong(strC2) : j;
    }

    @Override // com.sigmob.sdk.downloader.core.interceptor.c.a
    public com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a a(f chain) throws IOException {
        com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a interfaceC0560aN = chain.n();
        com.sigmob.sdk.downloader.core.breakpoint.c cVarD = chain.d();
        if (chain.f().k()) {
            throw com.sigmob.sdk.downloader.core.exception.c.f3430a;
        }
        if (cVarD.g() == 1 && !cVarD.b()) {
            long jA = a(interfaceC0560aN);
            long j = cVarD.j();
            if (jA > 0 && jA != j) {
                com.sigmob.sdk.downloader.core.c.b(f3441a, "SingleBlock special check: the response instance-length[" + jA + "] isn't equal to the instance length from trial-connection[" + j + "]");
                boolean z = cVarD.b(0).c() != 0;
                com.sigmob.sdk.downloader.core.breakpoint.a aVar = new com.sigmob.sdk.downloader.core.breakpoint.a(0L, jA);
                cVarD.f();
                cVarD.a(aVar);
                if (z) {
                    com.sigmob.sdk.downloader.core.c.a(f3441a, "Discard breakpoint because of on this special case, we have to download from beginning");
                    throw new g("Discard breakpoint because of on this special case, we have to download from beginning");
                }
                com.sigmob.sdk.downloader.g.j().b().a().a(chain.c(), cVarD, com.sigmob.sdk.downloader.core.cause.b.CONTENT_LENGTH_CHANGED);
            }
        }
        try {
            if (chain.r().a(cVarD)) {
                return interfaceC0560aN;
            }
            throw new IOException("Update store failed!");
        } catch (Exception e) {
            throw new IOException("Update store failed!", e);
        }
    }

    @Override // com.sigmob.sdk.downloader.core.interceptor.c.b
    public long b(f chain) throws IOException {
        long jA = chain.a();
        int iE = chain.e();
        boolean z = jA != -1;
        com.sigmob.sdk.downloader.core.file.d dVarG = chain.g();
        long j = 0;
        while (true) {
            try {
                long jP = chain.p();
                if (jP == -1) {
                    break;
                }
                j += jP;
            } catch (Throwable th) {
                chain.j();
                if (!chain.f().d()) {
                    dVarG.a(iE);
                }
                throw th;
            }
        }
        chain.j();
        if (!chain.f().d()) {
            dVarG.a(iE);
        }
        if (z) {
            dVarG.b(iE);
            if (j != jA) {
                throw new IOException("Fetch-length isn't equal to the response content-length, " + j + "!= " + jA);
            }
        }
        return j;
    }
}
