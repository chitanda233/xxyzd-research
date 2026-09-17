package com.kwad.framework.filedownloader.a;

import com.kwad.sdk.api.core.TLSConnectionUtils;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.j;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.Proxy;
import java.net.URL;
import java.net.URLConnection;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements com.kwad.framework.filedownloader.a.b {
    protected URLConnection aAs;

    @Override // com.kwad.framework.filedownloader.a.b
    public final void Cc() {
    }

    public c(String str, a aVar) {
        this(new URL(str), aVar);
    }

    private c(URL url, a aVar) {
        if (aVar == null || aVar.aAt == null) {
            this.aAs = url.openConnection();
        } else {
            this.aAs = url.openConnection(aVar.aAt);
        }
        try {
            TLSConnectionUtils.wrapHttpURLConnection(this.aAs);
        } catch (Throwable unused) {
        }
        if (aVar != null) {
            if (aVar.aAu != null) {
                this.aAs.setReadTimeout(aVar.aAu.intValue());
            }
            if (aVar.aAv != null) {
                this.aAs.setConnectTimeout(aVar.aAv.intValue());
            }
        }
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final void addHeader(String str, String str2) {
        this.aAs.addRequestProperty(str, str2);
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final InputStream getInputStream() throws IOException {
        return ((j) ServiceProvider.get(j.class)).wrapInputStream(this.aAs.getInputStream());
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final Map<String, List<String>> Ca() {
        return this.aAs.getRequestProperties();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final Map<String, List<String>> Cb() {
        return this.aAs.getHeaderFields();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final String bU(String str) {
        return this.aAs.getHeaderField(str);
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final void execute() throws IOException {
        this.aAs.connect();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final int getResponseCode() throws IOException {
        URLConnection uRLConnection = this.aAs;
        if (!(uRLConnection instanceof HttpURLConnection)) {
            return 0;
        }
        try {
            return ((HttpURLConnection) uRLConnection).getResponseCode();
        } catch (Throwable th) {
            throw new IOException(th);
        }
    }

    public static class b implements com.kwad.framework.filedownloader.f.c.b {
        private final a aAw;

        public b() {
            this(null);
        }

        private b(a aVar) {
            this.aAw = null;
        }

        @Override // com.kwad.framework.filedownloader.f.c.b
        public final com.kwad.framework.filedownloader.a.b bV(String str) {
            return new c(str, this.aAw);
        }
    }

    public static class a {
        private Proxy aAt;
        private Integer aAu;
        private Integer aAv;
    }
}
