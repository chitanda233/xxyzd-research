package com.sigmob.sdk.downloader.core.interceptor.connect;

import com.sigmob.sdk.downloader.core.download.f;
import com.sigmob.sdk.downloader.core.interceptor.c;
import com.sigmob.sdk.downloader.g;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class a implements c.a {
    @Override // com.sigmob.sdk.downloader.core.interceptor.c.a
    public com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a a(f chain) throws IOException {
        g.j().g().b(chain.c());
        g.j().g().b();
        return chain.i().a();
    }
}
