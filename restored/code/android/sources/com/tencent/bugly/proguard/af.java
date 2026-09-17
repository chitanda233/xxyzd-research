package com.tencent.bugly.proguard;

import android.content.Context;
import android.os.Process;
import android.os.SystemClock;
import cn.com.chinatelecom.account.api.utils.Constants;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.InetSocketAddress;
import java.net.Proxy;
import java.net.URL;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import java.util.Random;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class af {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static af f3730a;
    protected Context b;
    public Map<String, String> c = null;

    af(Context context) {
        this.b = context;
    }

    /* JADX WARN: Code duplicated, block: B:88:0x0168 A[PHI: r4 r6 r7 r10 r13 r14 r18
  0x0168: PHI (r4v4 java.lang.Throwable) = (r4v3 java.lang.Throwable), (r4v14 java.lang.Throwable) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r6v7 int) = (r6v6 int), (r6v11 int) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r7v4 char) = (r7v3 char), (r7v11 char) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r10v9 java.lang.String) = (r10v8 java.lang.String), (r10v13 java.lang.String) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r13v4 int) = (r13v3 int), (r13v6 int) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r14v5 int) = (r14v4 int), (r14v10 int) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]
  0x0168: PHI (r18v3 int) = (r18v2 int), (r18v8 int) binds: [B:103:0x0188, B:87:0x0166] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:98:0x017b A[Catch: all -> 0x016e, TRY_LEAVE, TryCatch #9 {all -> 0x016e, blocks: (B:23:0x009c, B:25:0x00b3, B:29:0x00c4, B:28:0x00c2, B:49:0x00ed, B:51:0x00f5, B:64:0x0120, B:66:0x012b, B:79:0x014c, B:82:0x0159, B:96:0x0175, B:98:0x017b), top: B:126:0x009c }] */
    /* JADX WARN: Unreachable blocks removed: 2, instructions: 2 */
    public final byte[] a(String str, byte[] bArr, aj ajVar, Map<String, String> map) {
        int i;
        char c;
        int i2;
        Throwable th;
        byte[] bArr2 = null;
        int i3 = 0;
        if (str == null) {
            al.e("Failed for no URL.", new Object[0]);
            return null;
        }
        long length = bArr == null ? 0L : bArr.length;
        int i4 = 1;
        al.c("request: %s, send: %d (pid=%d | tid=%d)", str, Long.valueOf(length), Integer.valueOf(Process.myPid()), Integer.valueOf(Process.myTid()));
        String str2 = str;
        int i5 = 0;
        int i6 = 0;
        int i7 = 0;
        while (i5 <= 0 && i6 <= 0) {
            if (i7 != 0) {
                i = i5;
                i7 = i3;
            } else {
                int i8 = i5 + 1;
                if (i8 > i4) {
                    al.c("try time: ".concat(String.valueOf(i8)), new Object[i3]);
                    SystemClock.sleep(((long) new Random(System.currentTimeMillis()).nextInt(10000)) + ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT);
                }
                i = i8;
            }
            String strC = ab.c(this.b);
            if (strC == null) {
                al.d("Failed to request for network not avail", new Object[i3]);
                c = 2;
                i2 = 1;
            } else {
                ajVar.a(length);
                HttpURLConnection httpURLConnectionA = a(str2, bArr, strC, map);
                if (httpURLConnectionA != null) {
                    try {
                        try {
                            int responseCode = httpURLConnectionA.getResponseCode();
                            al.c("response code ".concat(String.valueOf(responseCode)), new Object[i3]);
                            if (responseCode == 200) {
                                this.c = a(httpURLConnectionA);
                                byte[] bArrB = b(httpURLConnectionA);
                                ajVar.b(bArrB == null ? 0L : bArrB.length);
                                try {
                                    httpURLConnectionA.disconnect();
                                } catch (Throwable th2) {
                                    if (!al.a(th2)) {
                                        th2.printStackTrace();
                                    }
                                }
                                return bArrB;
                            }
                            if (responseCode == 301 || responseCode == 302 || responseCode == 303 || responseCode == 307) {
                                try {
                                    String headerField = httpURLConnectionA.getHeaderField("Location");
                                    if (headerField == null) {
                                        try {
                                            al.e("Failed to redirect: %d".concat(String.valueOf(responseCode)), new Object[0]);
                                            try {
                                                httpURLConnectionA.disconnect();
                                                return null;
                                            } catch (Throwable th3) {
                                                if (al.a(th3)) {
                                                    return null;
                                                }
                                                th3.printStackTrace();
                                                return null;
                                            }
                                        } catch (IOException e) {
                                            e = e;
                                            c = 2;
                                            i7 = 1;
                                        }
                                    } else {
                                        i6++;
                                        c = 2;
                                        try {
                                            Object[] objArr = new Object[2];
                                            objArr[0] = Integer.valueOf(responseCode);
                                            i2 = 1;
                                            try {
                                                objArr[1] = headerField;
                                                al.c("redirect code: %d ,to:%s", objArr);
                                                str2 = headerField;
                                                i7 = 1;
                                                i = 0;
                                            } catch (IOException e2) {
                                                e = e2;
                                                str2 = headerField;
                                                i7 = i2;
                                                i = 0;
                                            }
                                        } catch (IOException e3) {
                                            e = e3;
                                            i2 = 1;
                                        }
                                    }
                                } catch (IOException e4) {
                                    e = e4;
                                    c = 2;
                                    i2 = 1;
                                    i7 = 1;
                                }
                            } else {
                                c = 2;
                                i2 = 1;
                            }
                            try {
                                long contentLength = httpURLConnectionA.getContentLength();
                                if (contentLength < 0) {
                                    contentLength = 0;
                                }
                                ajVar.b(contentLength);
                                try {
                                    httpURLConnectionA.disconnect();
                                } catch (Throwable th4) {
                                    th = th4;
                                    if (!al.a(th)) {
                                        th.printStackTrace();
                                    }
                                }
                            } catch (IOException e5) {
                                e = e5;
                                if (!al.a(e)) {
                                    e.printStackTrace();
                                }
                                httpURLConnectionA.disconnect();
                            }
                        } catch (IOException e6) {
                            e = e6;
                            c = 2;
                        }
                    } catch (Throwable th5) {
                        try {
                            httpURLConnectionA.disconnect();
                            throw th5;
                        } catch (Throwable th6) {
                            if (al.a(th6)) {
                                throw th5;
                            }
                            th6.printStackTrace();
                            throw th5;
                        }
                    }
                    i2 = 1;
                    if (!al.a(e)) {
                        e.printStackTrace();
                    }
                    try {
                        httpURLConnectionA.disconnect();
                    } catch (Throwable th7) {
                        th = th7;
                        if (!al.a(th)) {
                            th.printStackTrace();
                        }
                    }
                } else {
                    c = 2;
                    i2 = 1;
                    al.c("Failed to execute post.", new Object[0]);
                    ajVar.b(0L);
                }
            }
            i5 = i;
            i4 = i2;
            bArr2 = null;
            i3 = 0;
        }
        return bArr2;
    }

    private static Map<String, String> a(HttpURLConnection httpURLConnection) {
        HashMap map = new HashMap();
        Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
        if (headerFields == null || headerFields.size() == 0) {
            return null;
        }
        for (String str : headerFields.keySet()) {
            List<String> list = headerFields.get(str);
            if (list.size() > 0) {
                map.put(str, list.get(0));
            }
        }
        return map;
    }

    private static byte[] b(HttpURLConnection httpURLConnection) {
        BufferedInputStream bufferedInputStream;
        if (httpURLConnection == null) {
            return null;
        }
        try {
            bufferedInputStream = new BufferedInputStream(httpURLConnection.getInputStream());
            try {
                ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
                byte[] bArr = new byte[1024];
                while (true) {
                    int i = bufferedInputStream.read(bArr);
                    if (i <= 0) {
                        break;
                    }
                    byteArrayOutputStream.write(bArr, 0, i);
                }
                byteArrayOutputStream.flush();
                byte[] byteArray = byteArrayOutputStream.toByteArray();
                try {
                    bufferedInputStream.close();
                } catch (Throwable th) {
                    th.printStackTrace();
                }
                return byteArray;
            } catch (Throwable th2) {
                th = th2;
                try {
                    if (!al.a(th)) {
                        th.printStackTrace();
                    }
                    return null;
                } finally {
                    if (bufferedInputStream != null) {
                        try {
                            bufferedInputStream.close();
                        } catch (Throwable th3) {
                            th3.printStackTrace();
                        }
                    }
                }
            }
        } catch (Throwable th4) {
            th = th4;
            bufferedInputStream = null;
        }
    }

    private static HttpURLConnection a(String str, byte[] bArr, String str2, Map<String, String> map) {
        if (str == null) {
            al.e("destUrl is null.", new Object[0]);
            return null;
        }
        HttpURLConnection httpURLConnectionA = a(str2, str);
        if (httpURLConnectionA == null) {
            al.e("Failed to get HttpURLConnection object.", new Object[0]);
            return null;
        }
        try {
            httpURLConnectionA.setRequestProperty("wup_version", Constants.CT_VERSION);
            if (map != null && map.size() > 0) {
                for (Map.Entry<String, String> entry : map.entrySet()) {
                    httpURLConnectionA.setRequestProperty(entry.getKey(), URLEncoder.encode(entry.getValue(), "utf-8"));
                }
            }
            httpURLConnectionA.setRequestProperty("A37", URLEncoder.encode(str2, "utf-8"));
            httpURLConnectionA.setRequestProperty("A38", URLEncoder.encode(str2, "utf-8"));
            OutputStream outputStream = httpURLConnectionA.getOutputStream();
            if (bArr == null) {
                outputStream.write(0);
            } else {
                outputStream.write(bArr);
            }
            return httpURLConnectionA;
        } catch (Throwable th) {
            if (!al.a(th)) {
                th.printStackTrace();
            }
            al.e("Failed to upload, please check your network.", new Object[0]);
            return null;
        }
    }

    private static HttpURLConnection a(String str, String str2) {
        HttpURLConnection httpURLConnection;
        try {
            URL url = new URL(str2);
            if (an.f3744a != null) {
                httpURLConnection = (HttpURLConnection) url.openConnection(an.f3744a);
            } else if (str != null && str.toLowerCase(Locale.US).contains("wap")) {
                httpURLConnection = (HttpURLConnection) url.openConnection(new Proxy(Proxy.Type.HTTP, new InetSocketAddress(System.getProperty("http.proxyHost"), Integer.parseInt(System.getProperty("http.proxyPort")))));
            } else {
                httpURLConnection = (HttpURLConnection) url.openConnection();
            }
            httpURLConnection.setConnectTimeout(KSImageLoader.InnerImageLoadingListener.MAX_DURATION);
            httpURLConnection.setReadTimeout(10000);
            httpURLConnection.setDoOutput(true);
            httpURLConnection.setDoInput(true);
            httpURLConnection.setRequestMethod("POST");
            httpURLConnection.setUseCaches(false);
            httpURLConnection.setInstanceFollowRedirects(false);
            return httpURLConnection;
        } catch (Throwable th) {
            if (al.a(th)) {
                return null;
            }
            th.printStackTrace();
            return null;
        }
    }
}
