package com.sigmob.sdk.base;

import android.text.TextUtils;
import android.util.Log;
import android.webkit.WebResourceResponse;
import com.baidu.mobads.sdk.internal.an;
import com.sigmob.sdk.base.utils.x;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.CookieManager;
import java.net.HttpCookie;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.Charset;
import java.text.MessageFormat;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3213a = "Cookie";
    private static final String b = "e";
    private static final CookieManager c = new CookieManager();

    private static InputStream a(InputStream inputStream, String str) throws IOException {
        byte[] bArr = new byte[1024];
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        while (true) {
            int i = inputStream.read(bArr);
            if (i == -1) {
                break;
            }
            byteArrayOutputStream.write(bArr, 0, i);
        }
        String str2 = new String(byteArrayOutputStream.toByteArray());
        if (str == null) {
            str = Charset.defaultCharset().displayName();
        }
        return new ByteArrayInputStream(str2.getBytes(str));
    }

    public static Map<String, String> a(Map<String, List<String>> maps) {
        StringBuilder sb = new StringBuilder();
        HashMap map = new HashMap();
        for (Map.Entry<String, List<String>> entry : maps.entrySet()) {
            List<String> value = entry.getValue();
            sb.delete(0, sb.length());
            if (value != null && value.size() > 0) {
                Iterator<String> it = value.iterator();
                while (it.hasNext()) {
                    sb.append(it.next());
                    sb.append(com.alipay.sdk.m.y.l.b);
                }
            }
            if (sb.length() > 0) {
                sb.deleteCharAt(sb.length() - 1);
            }
            map.put(entry.getKey(), sb.toString());
        }
        return map;
    }

    public static void a(HttpURLConnection conn, CookieManager cookieManager) {
        if (cookieManager == null || conn == null) {
            return;
        }
        Map<String, List<String>> headerFields = conn.getHeaderFields();
        Log.d(b, "headerFields : " + headerFields.toString());
        List<String> list = headerFields.get("Set-Cookie");
        if (list == null) {
            return;
        }
        for (String str : list) {
            try {
                List<HttpCookie> list2 = HttpCookie.parse(str);
                if (list2 != null && !list2.isEmpty()) {
                    String str2 = b;
                    Log.d(str2, "{0} -- Reading Cookies from the response :" + conn.getURL().toString());
                    Log.d(str2, "{0} -- Reading Cookies from the response :" + list2.get(0));
                    for (HttpCookie httpCookie : list2) {
                        Log.d(b, httpCookie.toString());
                        android.webkit.CookieManager.getInstance().setCookie(conn.getURL().toString(), httpCookie.getName() + "=" + httpCookie.getValue());
                    }
                }
            } catch (NullPointerException unused) {
                Log.e(b, MessageFormat.format("{0} -- Null header for the cookie : {1}", conn.getURL().toString(), str));
            }
        }
        android.webkit.CookieManager.getInstance().flush();
    }

    public WebResourceResponse a(String str, String method, Map<String, String> map) {
        List<String> list;
        String str2 = "UTF-8";
        if (x.a(str)) {
            return null;
        }
        try {
            HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
            httpURLConnection.setRequestMethod(method);
            if (map != null && map.size() > 0) {
                for (Map.Entry<String, String> entry : map.entrySet()) {
                    httpURLConnection.setRequestProperty(entry.getKey(), entry.getValue());
                }
            }
            String cookie = android.webkit.CookieManager.getInstance().getCookie(str);
            if (!TextUtils.isEmpty(cookie)) {
                for (String str3 : cookie.split(com.alipay.sdk.m.y.l.b)) {
                    httpURLConnection.addRequestProperty(f3213a.toLowerCase(), str3.replace(" ", ""));
                }
            }
            httpURLConnection.connect();
            int responseCode = httpURLConnection.getResponseCode();
            String contentType = httpURLConnection.getContentType();
            String contentEncoding = httpURLConnection.getContentEncoding();
            InputStream inputStream = httpURLConnection.getInputStream();
            a(httpURLConnection, c);
            Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
            if ((responseCode == 301 || responseCode == 302) && (list = headerFields.get("Location")) != null && list.size() > 0) {
                return a(list.get(0), "GET", null);
            }
            if (contentType != null) {
                contentType = contentType.split(com.alipay.sdk.m.y.l.b)[0];
                if (contentType.contains(com.baidu.mobads.sdk.internal.a.b) || contentType.contains("javascript")) {
                    if (contentType.contains(an.e)) {
                        contentType = "text/html";
                    }
                    inputStream = a(inputStream, "UTF-8");
                }
                WebResourceResponse webResourceResponse = new WebResourceResponse(contentType, str2, inputStream);
                webResourceResponse.setResponseHeaders(a(headerFields));
                return webResourceResponse;
            }
            inputStream = null;
            str2 = contentEncoding;
            WebResourceResponse webResourceResponse2 = new WebResourceResponse(contentType, str2, inputStream);
            webResourceResponse2.setResponseHeaders(a(headerFields));
            return webResourceResponse2;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
