package com.czhj.volley.toolbox;

import android.os.SystemClock;
import com.alipay.sdk.m.m.b;
import com.alipay.sdk.m.y.c;
import com.czhj.volley.AuthFailureError;
import com.czhj.volley.Cache;
import com.czhj.volley.Header;
import com.czhj.volley.Network;
import com.czhj.volley.NetworkError;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.NoConnectionError;
import com.czhj.volley.Request;
import com.czhj.volley.RetryPolicy;
import com.czhj.volley.ServerError;
import com.czhj.volley.TimeoutError;
import com.czhj.volley.VolleyError;
import com.czhj.volley.VolleyLog;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.SocketTimeoutException;
import java.net.URI;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;
import java.util.TreeSet;

/* JADX INFO: loaded from: classes2.dex */
public class BasicNetwork implements Network {
    protected static final boolean DEBUG = VolleyLog.DEBUG;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f2327a = 3000;
    private static final int b = 4096;
    private final BaseHttpStack c;
    protected final ByteArrayPool mPool;

    public BasicNetwork(BaseHttpStack baseHttpStack) {
        this(baseHttpStack, new ByteArrayPool(4096));
    }

    public BasicNetwork(BaseHttpStack baseHttpStack, ByteArrayPool byteArrayPool) {
        this.c = baseHttpStack;
        this.mPool = byteArrayPool;
    }

    private static List<Header> a(List<Header> list, Cache.Entry entry) {
        TreeSet treeSet = new TreeSet(String.CASE_INSENSITIVE_ORDER);
        if (!list.isEmpty()) {
            Iterator<Header> it = list.iterator();
            while (it.hasNext()) {
                treeSet.add(it.next().getName());
            }
        }
        ArrayList arrayList = new ArrayList(list);
        if (entry.allResponseHeaders != null) {
            if (!entry.allResponseHeaders.isEmpty()) {
                for (Header header : entry.allResponseHeaders) {
                    if (!treeSet.contains(header.getName())) {
                        arrayList.add(header);
                    }
                }
            }
        } else if (!entry.responseHeaders.isEmpty()) {
            for (Map.Entry<String, String> entry2 : entry.responseHeaders.entrySet()) {
                if (!treeSet.contains(entry2.getKey())) {
                    arrayList.add(new Header(entry2.getKey(), entry2.getValue()));
                }
            }
        }
        return arrayList;
    }

    private Map<String, String> a(Cache.Entry entry) {
        if (entry == null) {
            return Collections.emptyMap();
        }
        HashMap map = new HashMap();
        if (entry.etag != null) {
            map.put("If-None-Match", entry.etag);
        }
        if (entry.lastModified > 0) {
            map.put("If-Modified-Since", HttpHeaderParser.a(entry.lastModified));
        }
        return map;
    }

    private void a(long j, Request<?> request, byte[] bArr, int i) {
        if (DEBUG || j > c.f378a) {
            Object[] objArr = new Object[5];
            objArr[0] = request;
            objArr[1] = Long.valueOf(j);
            objArr[2] = bArr != null ? Integer.valueOf(bArr.length) : "null";
            objArr[3] = Integer.valueOf(i);
            objArr[4] = Integer.valueOf(request.getRetryPolicy().getCurrentRetryCount());
            VolleyLog.d("HTTP response for request=<%s> [lifetime=%d], [size=%s], [rc=%d], [retryCount=%s]", objArr);
        }
    }

    private static void a(String str, Request<?> request) {
        request.addMarker(String.format("%s-Redirect [timeout=%s]", str, Integer.valueOf(request.getTimeoutMs())));
    }

    private static void a(String str, Request<?> request, VolleyError volleyError) throws VolleyError {
        RetryPolicy retryPolicy = request.getRetryPolicy();
        int timeoutMs = request.getTimeoutMs();
        try {
            retryPolicy.retry(volleyError);
            request.addMarker(String.format("%s-retry [timeout=%s]", str, Integer.valueOf(timeoutMs)));
        } catch (VolleyError e) {
            request.addMarker(String.format("%s-timeout-giveup [timeout=%s]", str, Integer.valueOf(timeoutMs)));
            throw e;
        }
    }

    private byte[] a(InputStream inputStream, int i) throws IOException {
        byte[] byteArray;
        PoolingByteArrayOutputStream poolingByteArrayOutputStream = new PoolingByteArrayOutputStream(this.mPool, i);
        int i2 = 1024;
        if (i > 0 && i < 1024) {
            i2 = i;
        }
        byte[] buf = null;
        try {
            buf = this.mPool.getBuf(i2);
            long j = 0;
            while (true) {
                int i3 = inputStream.read(buf, 0, i2);
                if (i3 == -1 || (i >= 1 && j >= i)) {
                    break;
                }
                poolingByteArrayOutputStream.write(buf, 0, i3);
                j += (long) i3;
            }
            byteArray = poolingByteArrayOutputStream.toByteArray();
            if (inputStream != null) {
                try {
                    inputStream.close();
                } catch (IOException unused) {
                    VolleyLog.v("Error occurred when closing InputStream", new Object[0]);
                }
            }
            this.mPool.returnBuf(buf);
        } catch (Throwable th) {
            try {
                VolleyLog.e("readError", th.getMessage());
                byteArray = poolingByteArrayOutputStream.toByteArray();
                if (inputStream != null) {
                    try {
                        inputStream.close();
                    } catch (IOException unused2) {
                        VolleyLog.v("Error occurred when closing InputStream", new Object[0]);
                    }
                }
                this.mPool.returnBuf(buf);
            } finally {
                if (inputStream != null) {
                    try {
                        inputStream.close();
                    } catch (IOException unused3) {
                        VolleyLog.v("Error occurred when closing InputStream", new Object[0]);
                    }
                }
                this.mPool.returnBuf(buf);
                poolingByteArrayOutputStream.close();
            }
        }
        return byteArray;
    }

    protected static Map<String, String> convertHeaders(List<Header> list) {
        TreeMap treeMap = new TreeMap(String.CASE_INSENSITIVE_ORDER);
        for (int i = 0; i < list.size(); i++) {
            Header header = list.get(i);
            treeMap.put(header.getName(), header.getValue());
        }
        return treeMap;
    }

    protected void logError(String str, String str2, long j) {
        VolleyLog.v("HTTP ERROR(%s) %d ms to fetch %s", str, Long.valueOf(SystemClock.elapsedRealtime() - j), str2);
    }

    /* JADX WARN: Code duplicated, block: B:127:0x0216 A[Catch: all -> 0x0174, TryCatch #12 {all -> 0x0174, blocks: (B:4:0x0012, B:88:0x017f, B:90:0x019a, B:103:0x01c2, B:105:0x01c8, B:106:0x01cd, B:107:0x01d1, B:108:0x01d6, B:112:0x01df, B:114:0x01e5, B:115:0x01eb, B:116:0x01f0, B:118:0x01f3, B:120:0x01f9, B:121:0x01ff, B:122:0x0204, B:123:0x0205, B:124:0x020a, B:125:0x020b, B:126:0x0212, B:127:0x0216, B:128:0x021c, B:137:0x0241, B:138:0x0246, B:140:0x0248, B:141:0x0264, B:142:0x0265), top: B:174:0x0012 }] */
    /* JADX WARN: Code duplicated, block: B:128:0x021c A[Catch: all -> 0x0174, TRY_LEAVE, TryCatch #12 {all -> 0x0174, blocks: (B:4:0x0012, B:88:0x017f, B:90:0x019a, B:103:0x01c2, B:105:0x01c8, B:106:0x01cd, B:107:0x01d1, B:108:0x01d6, B:112:0x01df, B:114:0x01e5, B:115:0x01eb, B:116:0x01f0, B:118:0x01f3, B:120:0x01f9, B:121:0x01ff, B:122:0x0204, B:123:0x0205, B:124:0x020a, B:125:0x020b, B:126:0x0212, B:127:0x0216, B:128:0x021c, B:137:0x0241, B:138:0x0246, B:140:0x0248, B:141:0x0264, B:142:0x0265), top: B:174:0x0012 }] */
    /* JADX WARN: Code duplicated, block: B:184:0x0226 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:186:0x0241 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:193:0x0008 A[ADDED_TO_REGION, REMOVE, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:88:0x017f A[Catch: all -> 0x0174, TRY_ENTER, TryCatch #12 {all -> 0x0174, blocks: (B:4:0x0012, B:88:0x017f, B:90:0x019a, B:103:0x01c2, B:105:0x01c8, B:106:0x01cd, B:107:0x01d1, B:108:0x01d6, B:112:0x01df, B:114:0x01e5, B:115:0x01eb, B:116:0x01f0, B:118:0x01f3, B:120:0x01f9, B:121:0x01ff, B:122:0x0204, B:123:0x0205, B:124:0x020a, B:125:0x020b, B:126:0x0212, B:127:0x0216, B:128:0x021c, B:137:0x0241, B:138:0x0246, B:140:0x0248, B:141:0x0264, B:142:0x0265), top: B:174:0x0012 }] */
    /* JADX WARN: Code duplicated, block: B:90:0x019a A[Catch: all -> 0x0174, TRY_LEAVE, TryCatch #12 {all -> 0x0174, blocks: (B:4:0x0012, B:88:0x017f, B:90:0x019a, B:103:0x01c2, B:105:0x01c8, B:106:0x01cd, B:107:0x01d1, B:108:0x01d6, B:112:0x01df, B:114:0x01e5, B:115:0x01eb, B:116:0x01f0, B:118:0x01f3, B:120:0x01f9, B:121:0x01ff, B:122:0x0204, B:123:0x0205, B:124:0x020a, B:125:0x020b, B:126:0x0212, B:127:0x0216, B:128:0x021c, B:137:0x0241, B:138:0x0246, B:140:0x0248, B:141:0x0264, B:142:0x0265), top: B:174:0x0012 }] */
    /* JADX WARN: Code duplicated, block: B:92:0x01ac A[ADDED_TO_REGION] */
    @Override // com.czhj.volley.Network
    public NetworkResponse performRequest(Request<?> request) throws Throwable {
        List<Header> list;
        Throwable th;
        int statusCode;
        String str;
        VolleyError networkError;
        ServerError serverError;
        List<Header> list2;
        byte[] bArrA;
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        while (true) {
            List<Header> listEmptyList = Collections.emptyList();
            HttpResponse httpResponseExecuteRequest = null;
            byte[] bArr = null;
            HttpResponse httpResponse = null;
            HttpResponse httpResponse2 = null;
            try {
                try {
                    httpResponseExecuteRequest = this.c.executeRequest(request, a(request.getCacheEntry()));
                    try {
                        try {
                            int statusCode2 = httpResponseExecuteRequest.getStatusCode();
                            List<Header> headers = httpResponseExecuteRequest.getHeaders();
                            if (statusCode2 == 304) {
                                Cache.Entry cacheEntry = request.getCacheEntry();
                                if (cacheEntry == null) {
                                    NetworkResponse networkResponse = new NetworkResponse(304, (byte[]) null, true, SystemClock.elapsedRealtime() - jElapsedRealtime, headers);
                                    if (httpResponseExecuteRequest != null && httpResponseExecuteRequest.getContent() != null) {
                                        try {
                                            httpResponseExecuteRequest.getContent().close();
                                        } catch (IOException e) {
                                            VolleyLog.e(e.getMessage(), new Object[0]);
                                        }
                                    }
                                    return networkResponse;
                                }
                                NetworkResponse networkResponse2 = new NetworkResponse(304, cacheEntry.data, true, SystemClock.elapsedRealtime() - jElapsedRealtime, a(headers, cacheEntry));
                                if (httpResponseExecuteRequest != null && httpResponseExecuteRequest.getContent() != null) {
                                    try {
                                        httpResponseExecuteRequest.getContent().close();
                                    } catch (IOException e2) {
                                        VolleyLog.e(e2.getMessage(), new Object[0]);
                                    }
                                }
                                return networkResponse2;
                            }
                            if (statusCode2 == 301 || statusCode2 == 302) {
                                try {
                                    String string = convertHeaders(headers).get("Location");
                                    URI uriCreate = URI.create(string);
                                    if (uriCreate != null) {
                                        try {
                                            if (!uriCreate.isAbsolute()) {
                                                try {
                                                    URI uriCreate2 = URI.create(request.getUrl());
                                                    if (uriCreate2 != null) {
                                                        string = uriCreate2.resolve(uriCreate).toString();
                                                    }
                                                } catch (Throwable unused) {
                                                }
                                            }
                                        } catch (IOException e3) {
                                            e = e3;
                                            list = headers;
                                            httpResponseExecuteRequest = httpResponseExecuteRequest;
                                            if (httpResponseExecuteRequest == null) {
                                                throw new NoConnectionError(e);
                                            }
                                            statusCode = httpResponseExecuteRequest.getStatusCode();
                                            VolleyLog.e("Unexpected response code %d for %s", Integer.valueOf(statusCode), request.getUrl());
                                            if (bArr != null) {
                                                NetworkResponse networkResponse3 = new NetworkResponse(statusCode, bArr, false, SystemClock.elapsedRealtime() - jElapsedRealtime, list);
                                                if (statusCode != 301) {
                                                    a("redirect", request);
                                                } else {
                                                    a("redirect", request);
                                                }
                                                if (httpResponseExecuteRequest == null) {
                                                }
                                            } else {
                                                str = "network";
                                                networkError = new NetworkError(e);
                                            }
                                            a(str, request, networkError);
                                            if (httpResponseExecuteRequest == null) {
                                            }
                                        }
                                    }
                                    request.setRedirectURL(string);
                                    request.addMarker("redirectURL: " + string);
                                } catch (IOException e4) {
                                    e = e4;
                                    list2 = headers;
                                    bArr = null;
                                    list = list2;
                                    if (httpResponseExecuteRequest == null) {
                                        throw new NoConnectionError(e);
                                    }
                                    statusCode = httpResponseExecuteRequest.getStatusCode();
                                    VolleyLog.e("Unexpected response code %d for %s", Integer.valueOf(statusCode), request.getUrl());
                                    if (bArr != null) {
                                        NetworkResponse networkResponse4 = new NetworkResponse(statusCode, bArr, false, SystemClock.elapsedRealtime() - jElapsedRealtime, list);
                                        if (statusCode != 301 || statusCode == 302) {
                                            a("redirect", request);
                                        } else if (statusCode == 401 || statusCode == 403) {
                                            str = b.n;
                                            networkError = new AuthFailureError(networkResponse4);
                                        } else {
                                            if (statusCode < 400 || statusCode > 499) {
                                                if (statusCode < 500 || statusCode > 599) {
                                                    if (statusCode <= 599) {
                                                        throw new ServerError(networkResponse4);
                                                    }
                                                    if (!request.shouldRetryServerErrors()) {
                                                        throw new ServerError(networkResponse4);
                                                    }
                                                    serverError = new ServerError(networkResponse4);
                                                } else {
                                                    if (!request.shouldRetryServerErrors()) {
                                                        throw new ServerError(networkResponse4);
                                                    }
                                                    serverError = new ServerError(networkResponse4);
                                                }
                                            } else {
                                                if (!request.shouldRetryServerErrors()) {
                                                    throw new ServerError(networkResponse4);
                                                }
                                                serverError = new ServerError(networkResponse4);
                                            }
                                            a("server", request, serverError);
                                        }
                                        if (httpResponseExecuteRequest == null && httpResponseExecuteRequest.getContent() != null) {
                                            try {
                                                httpResponseExecuteRequest.getContent().close();
                                            } catch (IOException e5) {
                                                VolleyLog.e(e5.getMessage(), new Object[0]);
                                            }
                                        }
                                    } else {
                                        str = "network";
                                        networkError = new NetworkError(e);
                                    }
                                    a(str, request, networkError);
                                    if (httpResponseExecuteRequest == null) {
                                    }
                                }
                            }
                            InputStream content = httpResponseExecuteRequest.getContent();
                            if (content != null) {
                                int contentLength = httpResponseExecuteRequest.getContentLength();
                                if (request.getMaxLength() >= 0) {
                                    contentLength = request.getMaxLength();
                                }
                                bArrA = a(content, contentLength);
                            } else {
                                bArrA = new byte[0];
                            }
                            byte[] bArr2 = bArrA;
                            try {
                                list2 = headers;
                                try {
                                    a(SystemClock.elapsedRealtime() - jElapsedRealtime, request, bArr2, statusCode2);
                                    if (statusCode2 < 200 || statusCode2 > 299) {
                                        throw new IOException();
                                    }
                                    NetworkResponse networkResponse5 = new NetworkResponse(statusCode2, bArr2, false, SystemClock.elapsedRealtime() - jElapsedRealtime, list2);
                                    if (httpResponseExecuteRequest != null && httpResponseExecuteRequest.getContent() != null) {
                                        try {
                                            httpResponseExecuteRequest.getContent().close();
                                        } catch (IOException e6) {
                                            VolleyLog.e(e6.getMessage(), new Object[0]);
                                        }
                                    }
                                    return networkResponse5;
                                } catch (IOException e7) {
                                    e = e7;
                                    bArr = bArr2;
                                    list = list2;
                                    if (httpResponseExecuteRequest == null) {
                                        throw new NoConnectionError(e);
                                    }
                                    statusCode = httpResponseExecuteRequest.getStatusCode();
                                    VolleyLog.e("Unexpected response code %d for %s", Integer.valueOf(statusCode), request.getUrl());
                                    if (bArr != null) {
                                        NetworkResponse networkResponse6 = new NetworkResponse(statusCode, bArr, false, SystemClock.elapsedRealtime() - jElapsedRealtime, list);
                                        if (statusCode != 301) {
                                            a("redirect", request);
                                        } else {
                                            a("redirect", request);
                                        }
                                        if (httpResponseExecuteRequest == null) {
                                        }
                                    } else {
                                        str = "network";
                                        networkError = new NetworkError(e);
                                    }
                                    a(str, request, networkError);
                                    if (httpResponseExecuteRequest == null) {
                                    }
                                }
                            } catch (IOException e8) {
                                e = e8;
                                list2 = headers;
                            }
                        } catch (IOException e9) {
                            e = e9;
                            list = listEmptyList;
                        }
                    } catch (MalformedURLException e10) {
                        e = e10;
                        throw new RuntimeException("Bad URL " + request.getUrl(), e);
                    } catch (SocketTimeoutException unused2) {
                        httpResponse2 = httpResponseExecuteRequest;
                        a("socket", request, new TimeoutError());
                        if (httpResponse2 != null && httpResponse2.getContent() != null) {
                            try {
                                httpResponse2.getContent().close();
                            } catch (IOException e11) {
                                VolleyLog.e(e11.getMessage(), new Object[0]);
                            }
                        }
                    } catch (Throwable th2) {
                        th = th2;
                        httpResponse = httpResponseExecuteRequest;
                        if (httpResponse == null || httpResponse.getContent() == null) {
                            throw th;
                        }
                        try {
                            httpResponse.getContent().close();
                            throw th;
                        } catch (IOException e12) {
                            VolleyLog.e(e12.getMessage(), new Object[0]);
                            throw th;
                        }
                    }
                } catch (Throwable th3) {
                    th = th3;
                }
            } catch (MalformedURLException e13) {
                e = e13;
            } catch (SocketTimeoutException unused3) {
            } catch (IOException e14) {
                e = e14;
                list = listEmptyList;
                bArr = null;
            }
        }
    }
}
