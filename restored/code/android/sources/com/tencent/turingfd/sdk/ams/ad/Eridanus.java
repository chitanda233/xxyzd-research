package com.tencent.turingfd.sdk.ams.ad;

import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Eridanus {
    /* JADX WARN: Code duplicated, block: B:51:0x00ee A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:62:? A[SYNTHETIC] */
    public static void a(Gooseberry gooseberry) throws Throwable {
        HttpURLConnection httpURLConnection;
        Throwable th;
        URL url = gooseberry.f3852a;
        HashMap map = gooseberry.b;
        BufferedInputStream bufferedInputStream = null;
        try {
            httpURLConnection = (HttpURLConnection) url.openConnection();
            try {
                httpURLConnection.setRequestProperty("User-Agent", "Turing");
                httpURLConnection.setRequestProperty("Accept-Charset", "utf-8");
                if (!map.isEmpty()) {
                    for (Map.Entry entry : map.entrySet()) {
                        httpURLConnection.setRequestProperty((String) entry.getKey(), (String) entry.getValue());
                    }
                }
                httpURLConnection.setRequestMethod("GET");
                httpURLConnection.setUseCaches(false);
                httpURLConnection.setConnectTimeout(gooseberry.c);
                httpURLConnection.setReadTimeout(gooseberry.d);
                httpURLConnection.setInstanceFollowRedirects(gooseberry.e);
                Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
                if (headerFields != null) {
                    HashMap map2 = new HashMap();
                    for (Map.Entry<String, List<String>> entry2 : headerFields.entrySet()) {
                        map2.put(entry2.getKey(), entry2.getValue().get(0));
                    }
                }
                int responseCode = httpURLConnection.getResponseCode();
                try {
                    if (responseCode != 200) {
                        if (responseCode != 305) {
                            switch (responseCode) {
                                case 300:
                                case 301:
                                case 302:
                                case 303:
                                    break;
                                default:
                                    httpURLConnection.disconnect();
                                    return;
                            }
                        }
                        httpURLConnection.getHeaderField("Location");
                    } else {
                        BufferedInputStream bufferedInputStream2 = new BufferedInputStream(httpURLConnection.getInputStream());
                        try {
                            ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
                            byte[] bArr = new byte[4096];
                            while (true) {
                                int i = bufferedInputStream2.read(bArr);
                                if (-1 == i) {
                                    break;
                                } else {
                                    byteArrayOutputStream.write(bArr, 0, i);
                                }
                            }
                            URL url2 = httpURLConnection.getURL();
                            if (!url.getHost().equals(url2.getHost())) {
                                url2.toString();
                            }
                            byteArrayOutputStream.toByteArray();
                            GalacticCore.a(bufferedInputStream2);
                        } catch (Throwable th2) {
                            th = th2;
                            bufferedInputStream = bufferedInputStream2;
                            GalacticCore.a(bufferedInputStream);
                            if (httpURLConnection != null) {
                                throw th;
                            }
                            try {
                                httpURLConnection.disconnect();
                                throw th;
                            } catch (Throwable unused) {
                                throw th;
                            }
                        }
                    }
                    httpURLConnection.disconnect();
                } catch (Throwable unused2) {
                }
            } catch (Throwable th3) {
                th = th3;
                th = th;
                GalacticCore.a(bufferedInputStream);
                if (httpURLConnection != null) {
                    throw th;
                }
                httpURLConnection.disconnect();
                throw th;
            }
        } catch (Throwable th4) {
            th = th4;
            httpURLConnection = null;
        }
    }
}
