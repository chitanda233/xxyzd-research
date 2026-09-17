package com.kwad.sdk.core.diskcache.b;

import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import java.io.File;
import java.io.IOException;
import java.io.OutputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    static void a(final com.kwad.sdk.core.diskcache.a.a aVar, final String str, final String str2) {
        i.execute(new bi() { // from class: com.kwad.sdk.core.diskcache.b.b.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                OutputStream outputStreamEi = null;
                try {
                    com.kwad.sdk.core.diskcache.a.a.C0505a c0505aEm = aVar.em(str2);
                    if (c0505aEm != null) {
                        outputStreamEi = c0505aEm.ei(0);
                        if (b.a(str, outputStreamEi, new com.kwad.sdk.core.network.a.a.C0515a())) {
                            c0505aEm.commit();
                        } else {
                            c0505aEm.abort();
                        }
                        aVar.flush();
                    }
                } catch (IOException unused) {
                } finally {
                    com.kwad.sdk.crash.utils.b.closeQuietly(outputStreamEi);
                }
            }
        });
    }

    static File a(com.kwad.sdk.core.diskcache.a.a aVar, String str) throws Throwable {
        com.kwad.sdk.core.diskcache.a.a.c cVarEl;
        com.kwad.sdk.core.diskcache.a.a.c cVar = null;
        try {
            cVarEl = aVar.el(str);
            if (cVarEl != null) {
                try {
                    File fileEl = cVarEl.el(0);
                    com.kwad.sdk.crash.utils.b.closeQuietly(cVarEl);
                    return fileEl;
                } catch (IOException unused) {
                } catch (Throwable th) {
                    th = th;
                    cVar = cVarEl;
                    com.kwad.sdk.crash.utils.b.closeQuietly(cVar);
                    throw th;
                }
            }
        } catch (IOException unused2) {
            cVarEl = null;
        } catch (Throwable th2) {
            th = th2;
        }
        com.kwad.sdk.crash.utils.b.closeQuietly(cVarEl);
        return null;
    }

    static boolean a(com.kwad.sdk.core.diskcache.a.a aVar, String str, String str2, com.kwad.sdk.core.network.a.a.C0515a c0515a) {
        boolean z = false;
        OutputStream outputStreamEi = null;
        try {
            try {
                com.kwad.sdk.core.diskcache.a.a.C0505a c0505aEm = aVar.em(str2);
                if (c0505aEm != null) {
                    outputStreamEi = c0505aEm.ei(0);
                    if (a(str, outputStreamEi, c0515a)) {
                        c0505aEm.commit();
                        z = true;
                    } else {
                        c0505aEm.abort();
                    }
                    aVar.flush();
                }
            } catch (IOException e) {
                c0515a.msg = e.getMessage();
            }
            return z;
        } finally {
            com.kwad.sdk.crash.utils.b.closeQuietly(outputStreamEi);
        }
    }

    public static boolean a(String str, OutputStream outputStream, com.kwad.sdk.core.network.a.a.C0515a c0515a) {
        return com.kwad.sdk.core.network.a.a.a(str, outputStream, c0515a, -1L, true, null);
    }
}
