package com.sigmob.sdk.downloader.core.interceptor;

import com.sigmob.sdk.downloader.f;
import com.sigmob.sdk.downloader.g;
import java.io.IOException;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public class b implements c.b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final InputStream f3442a;
    private final byte[] b;
    private final com.sigmob.sdk.downloader.core.file.d c;
    private final int d;
    private final f e;
    private final com.sigmob.sdk.downloader.core.dispatcher.a f = g.j().b();

    public b(int blockIndex, InputStream inputStream, com.sigmob.sdk.downloader.core.file.d outputStream, f task) {
        this.d = blockIndex;
        this.f3442a = inputStream;
        this.b = new byte[task.o()];
        this.c = outputStream;
        this.e = task;
    }

    @Override // com.sigmob.sdk.downloader.core.interceptor.c.b
    public long b(com.sigmob.sdk.downloader.core.download.f chain) throws IOException {
        if (chain.f().k()) {
            throw com.sigmob.sdk.downloader.core.exception.c.f3430a;
        }
        g.j().g().b(chain.c());
        int i = this.f3442a.read(this.b);
        if (i == -1) {
            return i;
        }
        this.c.a(this.d, this.b, i);
        long j = i;
        chain.b(j);
        if (this.f.a(this.e)) {
            chain.j();
        }
        return j;
    }
}
