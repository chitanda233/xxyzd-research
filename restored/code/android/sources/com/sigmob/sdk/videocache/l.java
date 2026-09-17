package com.sigmob.sdk.videocache;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.czhj.sdk.logger.SigmobLog;
import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InterruptedIOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import okhttp3.ConnectionPool;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;
import okhttp3.ResponseBody;

/* JADX INFO: loaded from: classes4.dex */
public class l implements t {
    private static final int c = 5;
    private static OkHttpClient d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected volatile long f3672a;
    protected volatile String b;
    private InputStream e;
    private u f;
    private final com.sigmob.sdk.videocache.sourcestorage.c g;
    private final com.sigmob.sdk.videocache.headers.b h;
    private Response i;

    public l(t source) {
        this.f3672a = -2147483648L;
        this.b = "video/mp4";
        this.f = source.d();
        this.g = source.e();
        this.h = source.f();
    }

    public l(String url) {
        this(url, com.sigmob.sdk.videocache.sourcestorage.d.a());
    }

    public l(String url, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage) {
        this(url, sourceInfoStorage, new com.sigmob.sdk.videocache.headers.a());
    }

    public l(String url, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage, com.sigmob.sdk.videocache.headers.b headerInjector) {
        this.f3672a = -2147483648L;
        this.b = "video/mp4";
        this.g = (com.sigmob.sdk.videocache.sourcestorage.c) n.a(sourceInfoStorage);
        this.h = (com.sigmob.sdk.videocache.headers.b) n.a(headerInjector);
        u uVarA = sourceInfoStorage.a(url);
        this.f = uVarA == null ? new u(url, -2147483648L, q.a(url)) : uVarA;
    }

    private long a(Response response, long offset) throws IOException {
        int iCode = response.code();
        int iContentLength = (int) response.body().contentLength();
        if (iCode == 200) {
            return iContentLength;
        }
        return iCode == 206 ? ((long) iContentLength) + offset : this.f3672a;
    }

    private Response a(long offset, int timeout) throws p, IOException {
        if (d == null) {
            d = new OkHttpClient().newBuilder().connectionPool(new ConnectionPool()).connectTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).readTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).writeTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).build();
        }
        String strHeader = this.f.f3681a;
        Response response = this.i;
        if (response != null && offset > 0) {
            try {
                response.close();
            } catch (Throwable unused) {
            }
            this.i = null;
            q.a(this.e);
        }
        if (this.i == null) {
            int i = 0;
            boolean zIsRedirect = false;
            do {
                Request.Builder builder = new Request.Builder();
                builder.get();
                builder.url(strHeader);
                a(builder, strHeader);
                if (offset > 0) {
                    builder.addHeader(com.sigmob.sdk.downloader.core.c.b, "bytes=" + offset + "-");
                }
                Response responseExecute = d.newCall(builder.build()).execute();
                this.i = responseExecute;
                if (responseExecute.isRedirect()) {
                    strHeader = this.i.header("Location");
                    zIsRedirect = this.i.isRedirect();
                    i++;
                }
                if (i > 5) {
                    throw new p("Too many redirects: " + i);
                }
            } while (zIsRedirect);
        }
        return this.i;
    }

    private void a(Request.Builder requestBuilder, String url) {
        for (Map.Entry<String, String> entry : this.h.a(url).entrySet()) {
            requestBuilder.addHeader(entry.getKey(), entry.getValue());
        }
    }

    private void h() throws p {
        try {
            SigmobLog.d("Read content info from " + this.f.f3681a);
            Response responseA = a(0L, 10000);
            if (responseA == null || !responseA.isSuccessful()) {
                throw new p("Fail to fetchContentInfo: " + this.f.f3681a);
            }
            ResponseBody responseBodyBody = responseA.body();
            if (responseBodyBody != null) {
                this.f3672a = (int) responseBodyBody.contentLength();
                if (responseBodyBody.contentType() != null) {
                    this.b = responseBodyBody.contentType().toString();
                }
            }
            u uVar = new u(this.f.f3681a, this.f3672a, this.b);
            this.f = uVar;
            this.g.a(uVar.f3681a, this.f);
        } catch (IOException e) {
            SigmobLog.e("Error fetching info from " + this.f.f3681a, e);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public int a(byte[] buffer) throws p {
        InputStream inputStream = this.e;
        if (inputStream == null) {
            throw new p("Error reading data from " + this.f.f3681a + ": connection is absent!");
        }
        try {
            return inputStream.read(buffer, 0, buffer.length);
        } catch (InterruptedIOException e) {
            throw new k("Reading source " + this.f.f3681a + " is interrupted", e);
        } catch (IOException e2) {
            throw new p("Error reading data from " + this.f.f3681a, e2);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public long a() throws p {
        if (this.f3672a == -2147483648L) {
            h();
        }
        return this.f3672a;
    }

    @Override // com.sigmob.sdk.videocache.t
    public void a(long offset) throws p {
        try {
            Response responseA = a(offset, -1);
            this.i = responseA;
            ResponseBody responseBodyBody = responseA.body();
            if (responseBodyBody != null && responseBodyBody.contentType() != null) {
                this.b = responseBodyBody.contentType().toString();
            }
            this.f3672a = a(this.i, offset);
            this.e = new BufferedInputStream(responseBodyBody.byteStream(), 8192);
            u uVar = new u(this.f.f3681a, this.f3672a, this.b);
            this.f = uVar;
            this.g.a(uVar.f3681a, this.f);
        } catch (IOException e) {
            throw new p("Error opening connection for " + this.f.f3681a + " with offset " + offset, e);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public void b() throws p {
        try {
            q.a(this.e);
        } catch (ArrayIndexOutOfBoundsException e) {
            SigmobLog.e("Error closing connection correctly. Should happen only on SigmobAndroid L. Until good solution is not know, just ignore this issue :(", e);
        } catch (IllegalArgumentException e2) {
            e = e2;
            throw new RuntimeException("Wait... but why? WTF!? If you read it on your device log, please", e);
        } catch (NullPointerException e3) {
            e = e3;
            throw new RuntimeException("Wait... but why? WTF!? If you read it on your device log, please", e);
        }
    }

    @Override // com.sigmob.sdk.videocache.t
    public synchronized String c() throws p {
        if (TextUtils.isEmpty(this.f.c)) {
            h();
        }
        return this.f.c;
    }

    @Override // com.sigmob.sdk.videocache.t
    public u d() {
        return this.f;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.sourcestorage.c e() {
        return this.g;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.headers.b f() {
        return this.h;
    }

    @Override // com.sigmob.sdk.videocache.t
    public String g() {
        return this.f.f3681a;
    }

    public String toString() {
        return "HttpUrlSource{sourceInfo='" + this.f + com.alipay.sdk.m.y.l.d;
    }
}
