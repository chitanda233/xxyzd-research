package com.kwad.sdk.core.videocache;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.utils.az;
import java.io.BufferedInputStream;
import java.io.Closeable;
import java.io.IOException;
import java.io.InputStream;
import java.io.InterruptedIOException;
import java.util.Arrays;
import java.util.concurrent.TimeUnit;
import okhttp3.ConnectionSpec;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends p {
    private final com.kwad.sdk.core.videocache.d.c aZN;
    private final com.kwad.sdk.core.videocache.b.b aZO;
    private n bal;
    private InputStream ban;
    private OkHttpClient bas = new OkHttpClient();

    public j(String str, com.kwad.sdk.core.videocache.d.c cVar, com.kwad.sdk.core.videocache.b.b bVar) {
        this.aZN = (com.kwad.sdk.core.videocache.d.c) az.checkNotNull(cVar);
        this.aZO = (com.kwad.sdk.core.videocache.b.b) az.checkNotNull(bVar);
        n nVarFE = cVar.fE(str);
        this.bal = nVarFE == null ? new n(str, -2147483648L, l.fC(str)) : nVarFE;
    }

    public j(j jVar) {
        this.bal = jVar.bal;
        this.aZN = jVar.aZN;
        this.aZO = jVar.aZO;
    }

    @Override // com.kwad.sdk.core.videocache.m
    public final synchronized long length() {
        if (this.bal.baB == -2147483648L) {
            Pp();
        }
        if (this.bal.baB == -2147483648L) {
            Pn();
        }
        return this.bal.baB;
    }

    private void Pp() {
        n nVarFE;
        com.kwad.sdk.core.videocache.d.c cVar = this.aZN;
        if (cVar == null || !(cVar instanceof com.kwad.sdk.core.videocache.d.b) || (nVarFE = cVar.fE(getUrl())) == null || TextUtils.isEmpty(nVarFE.baC) || nVarFE.baB == -2147483648L) {
            return;
        }
        this.bal = nVarFE;
    }

    @Override // com.kwad.sdk.core.videocache.m
    public final void aM(long j) throws ProxyCacheException {
        try {
            Response responseF = f(j, -1);
            String string = responseF.body().contentType().toString();
            long jA = a(responseF, j);
            this.ban = new BufferedInputStream(responseF.body().byteStream(), 1024);
            n nVar = new n(this.bal.url, jA, string);
            this.bal = nVar;
            this.aZN.a(nVar.url, this.bal);
        } catch (IOException e) {
            throw new ProxyCacheException("Error opening connection for " + getUrl() + " with offset " + j, e);
        }
    }

    private long a(Response response, long j) {
        int iCode = response.code();
        long jContentLength = response.body().contentLength();
        if (iCode == 200) {
            return jContentLength;
        }
        return iCode == 206 ? jContentLength + j : this.bal.baB;
    }

    @Override // com.kwad.sdk.core.videocache.m
    public final void close() {
        com.kwad.sdk.crash.utils.b.closeQuietly(this.ban);
    }

    @Override // com.kwad.sdk.core.videocache.m
    public final int read(byte[] bArr) throws ProxyCacheException {
        InputStream inputStream = this.ban;
        if (inputStream == null) {
            throw new ProxyCacheException("Error reading data from " + this.bal.url + ": connection is absent!");
        }
        try {
            return inputStream.read(bArr, 0, 1024);
        } catch (InterruptedIOException e) {
            throw new InterruptedProxyCacheException("Reading source " + this.bal.url + " is interrupted", e);
        } catch (IOException e2) {
            throw new ProxyCacheException("Error reading data from " + this.bal.url, e2);
        }
    }

    private void Pn() {
        Response responseEF = null;
        try {
            try {
                responseEF = eF(10000);
                if (responseEF == null || !responseEF.isSuccessful()) {
                    throw new ProxyCacheException("Fail to fetchContentInfo: " + getUrl());
                }
                n nVar = new n(this.bal.url, c(responseEF), responseEF.header("Content-Type"));
                this.bal = nVar;
                this.aZN.a(nVar.url, this.bal);
                com.kwad.sdk.core.d.c.d("HttpUrlSource", "Source info fetched: " + this.bal);
                if (responseEF == null || responseEF.body() == null) {
                    return;
                }
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) responseEF.body());
            } catch (IOException unused) {
                com.kwad.sdk.core.d.c.e("HttpUrlSource", "Error fetching info from " + this.bal.url);
                if (0 == 0 || responseEF.body() == null) {
                }
            }
        } catch (Throwable th) {
            if (0 != 0 && responseEF.body() != null) {
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) responseEF.body());
            }
            throw th;
        }
    }

    private static long c(Response response) {
        String strHeader = response.header(com.sigmob.sdk.downloader.core.c.e);
        if (strHeader == null) {
            return -1L;
        }
        return Long.parseLong(strHeader);
    }

    private Response f(long j, int i) throws ProxyCacheException {
        Response responseExecute;
        OkHttpClient.Builder builderNewBuilder = this.bas.newBuilder();
        int i2 = 0;
        builderNewBuilder.connectionSpecs(Arrays.asList(ConnectionSpec.MODERN_TLS, ConnectionSpec.COMPATIBLE_TLS, ConnectionSpec.CLEARTEXT));
        try {
            builderNewBuilder.dns(new com.kwad.sdk.core.network.a.d());
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
        this.bas = builderNewBuilder.build();
        String url = getUrl();
        boolean zIsRedirect = false;
        do {
            Request.Builder builder = new Request.Builder();
            builder.get();
            builder.url(url);
            if (j > 0) {
                builder.addHeader(com.sigmob.sdk.downloader.core.c.b, "bytes=" + j + "-");
            }
            responseExecute = this.bas.newCall(builder.build()).execute();
            if (responseExecute.isRedirect()) {
                url = responseExecute.header("Location");
                zIsRedirect = responseExecute.isRedirect();
                i2++;
            }
            if (i2 > 5) {
                throw new ProxyCacheException("Too many redirects: " + i2);
            }
        } while (zIsRedirect);
        return responseExecute;
    }

    private Response eF(int i) throws ProxyCacheException {
        Response responseExecute;
        OkHttpClient.Builder builderNewBuilder = new OkHttpClient().newBuilder();
        builderNewBuilder.connectTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS);
        builderNewBuilder.readTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS);
        builderNewBuilder.writeTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS);
        int i2 = 0;
        builderNewBuilder.connectionSpecs(Arrays.asList(ConnectionSpec.MODERN_TLS, ConnectionSpec.COMPATIBLE_TLS, ConnectionSpec.CLEARTEXT));
        try {
            builderNewBuilder.dns(new com.kwad.sdk.core.network.a.d());
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
        this.bas = builderNewBuilder.build();
        String url = getUrl();
        boolean zIsRedirect = false;
        do {
            Request.Builder builder = new Request.Builder();
            builder.head();
            builder.url(url);
            responseExecute = this.bas.newCall(builder.build()).execute();
            if (responseExecute.isRedirect()) {
                url = responseExecute.header("Location");
                zIsRedirect = responseExecute.isRedirect();
                i2++;
            }
            if (i2 > 5) {
                throw new ProxyCacheException("Too many redirects: " + i2);
            }
        } while (zIsRedirect);
        return responseExecute;
    }

    @Override // com.kwad.sdk.core.videocache.p
    public final synchronized String Po() {
        if (TextUtils.isEmpty(this.bal.baC)) {
            Pp();
        }
        if (TextUtils.isEmpty(this.bal.baC)) {
            Pn();
        }
        return this.bal.baC;
    }

    @Override // com.kwad.sdk.core.videocache.p
    public final String getUrl() {
        return this.bal.url;
    }

    @Override // com.kwad.sdk.core.videocache.p
    public final String toString() {
        return "HttpUrlSource{sourceInfo='" + this.bal + com.alipay.sdk.m.y.l.d;
    }
}
