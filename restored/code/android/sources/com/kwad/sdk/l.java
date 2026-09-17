package com.kwad.sdk;

import android.text.TextUtils;
import android.webkit.MimeTypeMap;
import cn.thinkingdata.core.router.TRouterMap;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.y;
import java.io.Closeable;
import java.io.InputStream;
import java.util.List;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import okhttp3.ConnectionPool;
import okhttp3.OkHttpClient;
import okhttp3.Protocol;
import okhttp3.Request;
import okhttp3.Response;
import okhttp3.internal.Util;

/* JADX INFO: loaded from: classes3.dex */
public final class l implements com.kwad.framework.filedownloader.a.b {
    private final OkHttpClient aGk;
    private final Request.Builder aGl;
    private Request aGm;
    private Response aGn;

    /* synthetic */ l(String str, OkHttpClient okHttpClient, byte b) {
        this(str, okHttpClient);
    }

    private l(Request.Builder builder, OkHttpClient okHttpClient) {
        this.aGl = builder;
        this.aGk = okHttpClient;
    }

    private l(String str, OkHttpClient okHttpClient) {
        this(new Request.Builder().url(str), okHttpClient);
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final void addHeader(String str, String str2) {
        this.aGl.addHeader(str, str2);
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final InputStream getInputStream() {
        Response response = this.aGn;
        if (response == null) {
            throw new IllegalStateException("Please invoke #execute first!");
        }
        return ((com.kwad.sdk.service.a.j) ServiceProvider.get(com.kwad.sdk.service.a.j.class)).wrapInputStream(response.body().byteStream());
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final Map<String, List<String>> Ca() {
        if (this.aGm == null) {
            this.aGm = this.aGl.build();
        }
        return this.aGm.headers().toMultimap();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final Map<String, List<String>> Cb() {
        Response response = this.aGn;
        if (response == null) {
            return null;
        }
        return response.headers().toMultimap();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final String bU(String str) {
        String str2;
        if (com.sigmob.sdk.downloader.core.c.j.equals(str)) {
            try {
                if (TextUtils.isEmpty(com.kwad.framework.filedownloader.f.f.cl(this.aGn.header(str)))) {
                    List listPathSegments = this.aGn.request().url().pathSegments();
                    str2 = (String) listPathSegments.get(listPathSegments.size() - 1);
                    return "attachment; filename=\"" + cQ(str2) + "\"";
                }
                return this.aGn.header(str);
            } catch (Exception unused) {
                str2 = "";
            }
        } else {
            Response response = this.aGn;
            if (response == null) {
                return null;
            }
            return response.header(str);
        }
    }

    private String cQ(String str) {
        String strBU = bU("Content-Type");
        String extension = y.getExtension(str);
        if (TextUtils.isEmpty(strBU) || !TextUtils.isEmpty(extension)) {
            return TextUtils.isEmpty(str) ? System.currentTimeMillis() + ".apk" : str;
        }
        String extensionFromMimeType = MimeTypeMap.getSingleton().getExtensionFromMimeType(strBU);
        return System.currentTimeMillis() + (TextUtils.isEmpty(extensionFromMimeType) ? ".apk" : TRouterMap.DOT + extensionFromMimeType);
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final void execute() {
        if (this.aGm == null) {
            this.aGm = this.aGl.build();
        }
        this.aGn = this.aGk.newCall(this.aGm).execute();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final int getResponseCode() {
        Response response = this.aGn;
        if (response == null) {
            throw new IllegalStateException("Please invoke #execute first!");
        }
        return response.code();
    }

    @Override // com.kwad.framework.filedownloader.a.b
    public final void Cc() {
        this.aGm = null;
        Response response = this.aGn;
        if (response != null && response.body() != null) {
            com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) this.aGn.body());
        }
        this.aGn = null;
    }

    public static class a implements com.kwad.framework.filedownloader.f.c.b {
        private volatile OkHttpClient aGk;
        private OkHttpClient.Builder aGo;

        public a() {
        }

        public a(boolean z) {
            if (z) {
                this.aGo = l.GA();
            } else {
                this.aGo = l.Gz();
            }
        }

        @Override // com.kwad.framework.filedownloader.f.c.b
        public final com.kwad.framework.filedownloader.a.b bV(String str) {
            if (this.aGk == null) {
                synchronized (a.class) {
                    if (this.aGk == null) {
                        OkHttpClient.Builder builder = this.aGo;
                        this.aGk = builder != null ? builder.build() : new OkHttpClient();
                        this.aGo = null;
                    }
                }
            }
            return new l(str, this.aGk, (byte) 0);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static OkHttpClient.Builder Gz() {
        return new OkHttpClient.Builder().connectTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).addInterceptor(new com.kwad.sdk.j.a()).readTimeout(0L, TimeUnit.MILLISECONDS).connectionPool(new ConnectionPool(6, 60000L, TimeUnit.MILLISECONDS)).retryOnConnectionFailure(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static OkHttpClient.Builder GA() {
        return new OkHttpClient.Builder().connectTimeout(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS).addInterceptor(new com.kwad.sdk.j.a()).protocols(Util.immutableList(new Protocol[]{Protocol.HTTP_1_1})).readTimeout(0L, TimeUnit.MILLISECONDS).connectionPool(new ConnectionPool(6, 60000L, TimeUnit.MILLISECONDS)).retryOnConnectionFailure(true);
    }
}
