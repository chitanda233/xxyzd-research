package com.sigmob.sdk.downloader.core.interceptor.connect;

import com.sigmob.sdk.downloader.core.download.f;
import com.sigmob.sdk.downloader.core.interceptor.c;
import com.sigmob.sdk.downloader.g;
import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class b implements c.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3443a = "HeaderInterceptor";

    @Override // com.sigmob.sdk.downloader.core.interceptor.c.a
    public com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a a(f chain) throws IOException {
        com.sigmob.sdk.downloader.core.breakpoint.c cVarD = chain.d();
        com.sigmob.sdk.downloader.core.connection.a aVarI = chain.i();
        com.sigmob.sdk.downloader.f fVarC = chain.c();
        Map<String, List<String>> mapB = fVarC.b();
        if (mapB != null) {
            com.sigmob.sdk.downloader.core.c.a(mapB, aVarI);
        }
        if (mapB == null || !mapB.containsKey("User-Agent")) {
            com.sigmob.sdk.downloader.core.c.a(aVarI);
        }
        int iE = chain.e();
        com.sigmob.sdk.downloader.core.breakpoint.a aVarB = cVarD.b(iE);
        if (aVarB == null) {
            throw new IOException("No block-info found on " + iE);
        }
        String str = "bytes=" + aVarB.c() + "-";
        if (!cVarD.b()) {
            str = str + aVarB.e();
        }
        aVarI.a(com.sigmob.sdk.downloader.core.c.b, str);
        com.sigmob.sdk.downloader.core.c.b(f3443a, "AssembleHeaderRange (" + fVarC.c() + ") block(" + iE + ") downloadFrom(" + aVarB.c() + ") currentOffset(" + aVarB.a() + ")");
        String strK = cVarD.k();
        if (!com.sigmob.sdk.downloader.core.c.a((CharSequence) strK)) {
            aVarI.a(com.sigmob.sdk.downloader.core.c.c, strK);
        }
        if (chain.f().k()) {
            throw com.sigmob.sdk.downloader.core.exception.c.f3430a;
        }
        g.j().b().a().b(fVarC, iE, aVarI.c());
        com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a interfaceC0560aN = chain.n();
        if (chain.f().k()) {
            throw com.sigmob.sdk.downloader.core.exception.c.f3430a;
        }
        Map<String, List<String>> mapF = interfaceC0560aN.f();
        if (mapF == null) {
            mapF = new HashMap<>();
        }
        g.j().b().a().a(fVarC, iE, interfaceC0560aN.d(), mapF);
        g.j().g().a(interfaceC0560aN, iE, cVarD).a();
        String strC = interfaceC0560aN.c(com.sigmob.sdk.downloader.core.c.e);
        chain.a((strC == null || strC.length() == 0) ? com.sigmob.sdk.downloader.core.c.d(interfaceC0560aN.c(com.sigmob.sdk.downloader.core.c.f)) : com.sigmob.sdk.downloader.core.c.b(strC));
        return interfaceC0560aN;
    }
}
