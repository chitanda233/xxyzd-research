package com.qq.gdt.action.e.b;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Executor;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final d f3054a;

    e(d dVar) {
        this.f3054a = dVar;
    }

    private static j a(HttpURLConnection httpURLConnection) throws IOException {
        return new j(httpURLConnection.getContentType(), httpURLConnection.getContentLength(), new BufferedInputStream(b(httpURLConnection)), httpURLConnection);
    }

    private static void a(HttpURLConnection httpURLConnection, long j) {
        httpURLConnection.setFixedLengthStreamingMode(j);
    }

    private static void a(HttpURLConnection httpURLConnection, h hVar) throws Throwable {
        httpURLConnection.setDoOutput(true);
        BufferedOutputStream bufferedOutputStream = null;
        if ((hVar.a() != null ? hVar.a().toString() : null) != null) {
            httpURLConnection.addRequestProperty("Content-Type", hVar.a().toString());
        }
        long jB = hVar.b();
        if (jB > 0) {
            a(httpURLConnection, jB);
            httpURLConnection.addRequestProperty(com.sigmob.sdk.downloader.core.c.e, Long.toString(jB));
        } else {
            httpURLConnection.setChunkedStreamingMode(0);
        }
        try {
            BufferedOutputStream bufferedOutputStream2 = new BufferedOutputStream(httpURLConnection.getOutputStream());
            try {
                hVar.a(bufferedOutputStream2);
                k.a(bufferedOutputStream2);
            } catch (Throwable th) {
                th = th;
                bufferedOutputStream = bufferedOutputStream2;
                k.a(bufferedOutputStream);
                throw th;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    private static void a(HttpURLConnection httpURLConnection, Map<String, String> map) {
        for (Map.Entry<String, String> entry : map.entrySet()) {
            String value = entry.getValue();
            if (value != null) {
                httpURLConnection.addRequestProperty(entry.getKey(), value);
            }
        }
    }

    private static InputStream b(HttpURLConnection httpURLConnection) {
        try {
            return httpURLConnection.getInputStream();
        } catch (IOException unused) {
            return httpURLConnection.getErrorStream();
        }
    }

    private static boolean b(g gVar) {
        if (gVar.f() == null) {
            return false;
        }
        return "POST".equals(gVar.e());
    }

    public i a(g gVar) throws Throwable {
        HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(gVar.a()).openConnection();
        httpURLConnection.setRequestMethod(gVar.e());
        httpURLConnection.setReadTimeout(this.f3054a.b);
        httpURLConnection.setConnectTimeout(this.f3054a.f3052a);
        if (gVar.c() > 0) {
            httpURLConnection.setReadTimeout(gVar.c());
        }
        if (gVar.b() > 0) {
            httpURLConnection.setConnectTimeout(gVar.b());
        }
        httpURLConnection.setDoInput(true);
        Map<String, String> mapD = gVar.d();
        if (mapD != null && !mapD.isEmpty()) {
            a(httpURLConnection, mapD);
        }
        if (b(gVar)) {
            a(httpURLConnection, gVar.f());
        }
        httpURLConnection.connect();
        int responseCode = httpURLConnection.getResponseCode();
        String responseMessage = httpURLConnection.getResponseMessage();
        Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
        return new i.a().a(gVar).a(responseCode).a(responseMessage).a(headerFields).a(a(httpURLConnection)).a();
    }

    public Executor a() {
        return this.f3054a.c;
    }
}
