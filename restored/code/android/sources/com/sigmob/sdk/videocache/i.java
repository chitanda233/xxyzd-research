package com.sigmob.sdk.videocache;

import android.text.TextUtils;
import com.czhj.sdk.logger.SigmobLog;
import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InterruptedIOException;
import java.net.HttpURLConnection;
import java.net.URI;
import java.net.URL;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class i implements t {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3670a = 5;
    private final com.sigmob.sdk.videocache.sourcestorage.c b;
    private final com.sigmob.sdk.videocache.headers.b c;
    private u d;
    private HttpURLConnection e;
    private InputStream f;

    public i(t source) {
        this.d = source.d();
        this.b = source.e();
        this.c = source.f();
    }

    public i(String url) {
        this(url, com.sigmob.sdk.videocache.sourcestorage.d.a());
    }

    public i(String url, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage) {
        this(url, sourceInfoStorage, new com.sigmob.sdk.videocache.headers.a());
    }

    public i(String url, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage, com.sigmob.sdk.videocache.headers.b headerInjector) {
        this.b = (com.sigmob.sdk.videocache.sourcestorage.c) n.a(sourceInfoStorage);
        this.c = (com.sigmob.sdk.videocache.headers.b) n.a(headerInjector);
        u uVarA = sourceInfoStorage.a(url);
        this.d = uVarA == null ? new u(url, -2147483648L, q.a(url)) : uVarA;
    }

    private long a(HttpURLConnection connection) {
        String headerField = connection.getHeaderField(com.sigmob.sdk.downloader.core.c.e);
        if (headerField == null) {
            return -1L;
        }
        return Long.parseLong(headerField);
    }

    private long a(HttpURLConnection connection, long offset, int responseCode) throws IOException {
        long jA = a(connection);
        if (responseCode == 200) {
            return jA;
        }
        return responseCode == 206 ? jA + offset : this.d.b;
    }

    private HttpURLConnection a(long offset, int timeout) throws p, IOException {
        boolean z;
        String str = this.d.f3681a;
        HttpURLConnection httpURLConnection = this.e;
        if (httpURLConnection != null && offset > 0 && httpURLConnection != null) {
            try {
                httpURLConnection.disconnect();
            } catch (Throwable unused) {
            }
            this.e = null;
            q.a(this.f);
        }
        if (this.e == null) {
            int i = 0;
            do {
                SigmobLog.d("Open connection " + (offset > 0 ? " with offset " + offset : "") + " to " + str);
                HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(str).openConnection();
                this.e = httpURLConnection2;
                a(httpURLConnection2, str);
                if (offset > 0) {
                    this.e.setRequestProperty(com.sigmob.sdk.downloader.core.c.b, "bytes=" + offset + "-");
                }
                if (timeout > 0) {
                    this.e.setConnectTimeout(timeout);
                    this.e.setReadTimeout(timeout);
                }
                int responseCode = this.e.getResponseCode();
                z = responseCode == 301 || responseCode == 302 || responseCode == 303;
                if (z) {
                    String headerField = this.e.getHeaderField("Location");
                    URI uriCreate = URI.create(headerField);
                    if (uriCreate != null && !uriCreate.isAbsolute()) {
                        try {
                            URI uriCreate2 = URI.create(str);
                            if (uriCreate2 != null) {
                                headerField = uriCreate2.resolve(uriCreate).toString();
                            }
                        } catch (Throwable unused2) {
                        }
                    }
                    i++;
                    this.e.disconnect();
                    str = headerField;
                }
                if (i > 5) {
                    throw new p("Too many redirects: " + i);
                }
            } while (z);
        }
        return this.e;
    }

    private void a(HttpURLConnection connection, String url) {
        for (Map.Entry<String, String> entry : this.c.a(url).entrySet()) {
            connection.setRequestProperty(entry.getKey(), entry.getValue());
        }
    }

    private void h() throws p {
        SigmobLog.d("Read content info from " + this.d.f3681a);
        try {
            HttpURLConnection httpURLConnectionA = a(0L, 3000);
            u uVar = new u(this.d.f3681a, a(httpURLConnectionA), httpURLConnectionA.getContentType());
            this.d = uVar;
            this.b.a(uVar.f3681a, this.d);
            SigmobLog.d("Source info fetched: " + this.d);
        } catch (IOException e) {
            SigmobLog.e("Error fetching info from " + this.d.f3681a, e);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public int a(byte[] buffer) throws p {
        InputStream inputStream = this.f;
        if (inputStream == null) {
            throw new p("Error reading data from " + this.d.f3681a + ": connection is absent!");
        }
        try {
            return inputStream.read(buffer, 0, buffer.length);
        } catch (InterruptedIOException e) {
            throw new k("Reading source " + this.d.f3681a + " is interrupted", e);
        } catch (IOException e2) {
            throw new p("Error reading data from " + this.d.f3681a, e2);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public synchronized long a() throws p {
        if (this.d.b == -2147483648L) {
            h();
        }
        return this.d.b;
    }

    @Override // com.sigmob.sdk.videocache.t
    public void a(long offset) throws p {
        try {
            HttpURLConnection httpURLConnectionA = a(offset, 3000);
            this.e = httpURLConnectionA;
            String contentType = httpURLConnectionA.getContentType();
            this.f = new BufferedInputStream(this.e.getInputStream(), 8192);
            HttpURLConnection httpURLConnection = this.e;
            u uVar = new u(this.d.f3681a, a(httpURLConnection, offset, httpURLConnection.getResponseCode()), contentType);
            this.d = uVar;
            this.b.a(uVar.f3681a, this.d);
        } catch (IOException e) {
            throw new p("Error opening connection for " + this.d.f3681a + " with offset " + offset, e);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public void b() throws p {
        HttpURLConnection httpURLConnection = this.e;
        if (httpURLConnection != null) {
            try {
                httpURLConnection.disconnect();
            } catch (ArrayIndexOutOfBoundsException e) {
                SigmobLog.e("Error closing connection correctly. Should happen only on SigmobAndroid L. Until good solution is not know, just ignore this issue :(", e);
            } catch (IllegalArgumentException e2) {
                e = e2;
                throw new RuntimeException("Wait... but why? WTF!? ", e);
            } catch (NullPointerException e3) {
                e = e3;
                throw new RuntimeException("Wait... but why? WTF!? ", e);
            }
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public synchronized String c() throws p {
        if (TextUtils.isEmpty(this.d.c)) {
            h();
        }
        return this.d.c;
    }

    @Override // com.sigmob.sdk.videocache.t
    public u d() {
        return this.d;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.sourcestorage.c e() {
        return this.b;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.headers.b f() {
        return this.c;
    }

    @Override // com.sigmob.sdk.videocache.t
    public String g() {
        return this.d.f3681a;
    }

    public String toString() {
        return "HttpUrlSource{sourceInfo='" + this.d + com.alipay.sdk.m.y.l.d;
    }
}
