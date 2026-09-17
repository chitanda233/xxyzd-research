package com.sigmob.sdk.downloader.core.interceptor;

import com.sigmob.sdk.downloader.core.download.f;
import com.sigmob.sdk.downloader.core.exception.g;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class d implements c.a, c.b {
    @Override // com.sigmob.sdk.downloader.core.interceptor.c.a
    public com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a a(f chain) throws IOException {
        com.sigmob.sdk.downloader.core.download.d dVarF = chain.f();
        while (true) {
            try {
                if (dVarF.k()) {
                    throw com.sigmob.sdk.downloader.core.exception.c.f3430a;
                }
                return chain.n();
            } catch (IOException e) {
                if (!(e instanceof g)) {
                    chain.f().e(e);
                    chain.g().d(chain.e());
                    throw e;
                }
                chain.l();
            }
        }
    }

    @Override // com.sigmob.sdk.downloader.core.interceptor.c.b
    public long b(f chain) throws IOException {
        try {
            return chain.o();
        } catch (IOException e) {
            chain.f().e(e);
            throw e;
        }
    }
}
