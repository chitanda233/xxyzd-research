package com.sigmob.sdk.base;

import android.net.Uri;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.x;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.net.CookieManager;
import java.net.HttpCookie;
import java.net.HttpURLConnection;
import java.text.MessageFormat;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class l extends WebViewClient {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static final String f3219a = "Set-Cookie";
    static final String b = "Referer";
    private static final String c = "l";
    private static final String d = "mraid.js";
    private static final String e = "mraid2.js";
    private final boolean f = false;
    private boolean g = false;
    private String h;

    public static WebResourceResponse a(Uri url) {
        String scheme;
        if (url != null && (scheme = url.getScheme()) != null && scheme.startsWith(n.z)) {
            String path = url.getPath();
            if (!s.a((CharSequence) path) && !x.a(path)) {
                try {
                    File file = new File(path);
                    if (file.getCanonicalPath().equals(file.getAbsolutePath()) && file.exists()) {
                        return new WebResourceResponse("text/html", "utf-8", new FileInputStream(file));
                    }
                } catch (Throwable th) {
                    th.printStackTrace();
                }
            }
        }
        return null;
    }

    private static File a(WebResourceResponse webResourceResponse, String url) {
        try {
            Uri uri = Uri.parse(url);
            if (d.a(url)) {
                return null;
            }
            String lastPathSegment = uri.getLastPathSegment();
            if (!s.a((CharSequence) lastPathSegment) && !x.a(lastPathSegment)) {
                File file = new File(com.sigmob.sdk.base.utils.n.c(), lastPathSegment);
                FileUtil.writeToCache(webResourceResponse.getData(), file.getAbsolutePath());
                return file;
            }
        } catch (Throwable unused) {
        }
        return null;
    }

    public static void a(HttpURLConnection conn, CookieManager cookieManager) {
        if (cookieManager == null || conn == null) {
            return;
        }
        Map<String, List<String>> headerFields = conn.getHeaderFields();
        SigmobLog.d("headerFields : " + headerFields.toString());
        List<String> list = headerFields.get(f3219a);
        if (list == null) {
            return;
        }
        for (String str : list) {
            try {
                List<HttpCookie> list2 = HttpCookie.parse(str);
                if (!com.sigmob.sdk.base.utils.f.a(list2)) {
                    SigmobLog.d("{0} -- Reading Cookies from the response :" + conn.getURL().toString());
                    SigmobLog.d("{0} -- Reading Cookies from the response :" + list2.get(0));
                    for (HttpCookie httpCookie : list2) {
                        SigmobLog.d(httpCookie.toString());
                        android.webkit.CookieManager.getInstance().setCookie(conn.getURL().toString(), httpCookie.getName() + "=" + httpCookie.getValue());
                    }
                }
            } catch (NullPointerException unused) {
                SigmobLog.e(MessageFormat.format("{0} -- Null header for the cookie : {1}", conn.getURL().toString(), str));
            }
        }
        android.webkit.CookieManager.getInstance().flush();
    }

    protected static boolean a(String url) {
        String lastPathSegment = Uri.parse(url.toLowerCase(Locale.US)).getLastPathSegment();
        SigmobLogger.d(c, "matchesInjectionUrl: lastPathSegment = " + lastPathSegment, new Object[0]);
        return d.equals(lastPathSegment) || e.equals(lastPathSegment);
    }

    private WebResourceResponse c(String url) {
        String str;
        try {
            Uri uri = Uri.parse(url);
            String host = uri.getHost();
            String scheme = uri.getScheme();
            String lastPathSegment = uri.getLastPathSegment();
            if (!s.a((CharSequence) lastPathSegment) && !x.a(lastPathSegment) && host != null && !a(url) && scheme.startsWith("http") && !host.equals("127.0.0.1") && s.a((CharSequence) uri.getQueryParameter("no-cache")) && (lastPathSegment.endsWith(".js") || lastPathSegment.endsWith(".css"))) {
                String strC = com.sigmob.sdk.base.utils.n.c();
                File file = new File(strC, lastPathSegment);
                if (!file.getCanonicalPath().startsWith(new File(strC).getCanonicalPath())) {
                    return null;
                }
                if (lastPathSegment.endsWith(".js")) {
                    str = "text/javascript";
                } else {
                    str = lastPathSegment.endsWith(".css") ? "text/css" : null;
                }
                if (file.exists()) {
                    WebResourceResponse webResourceResponse = new WebResourceResponse(str, "UTF-8", new FileInputStream(file));
                    HashMap map = new HashMap();
                    map.put("Cache-Control", "no-store");
                    webResourceResponse.setResponseHeaders(map);
                    return webResourceResponse;
                }
                return null;
            }
            return null;
        } catch (Throwable th) {
            SigmobLog.e("useWebResourceCache: error = " + th.getMessage());
        }
    }

    public void a(boolean useCache) {
        this.g = useCache;
    }

    public void b(String url) {
        try {
            Uri uri = Uri.parse(url);
            this.h = uri.getScheme() + "://" + uri.getHost() + "/" + uri.getPath();
        } catch (Throwable unused) {
        }
    }

    public void b(boolean isDisable) {
    }

    @Override // android.webkit.WebViewClient
    public WebResourceResponse shouldInterceptRequest(WebView view, WebResourceRequest request) {
        WebResourceResponse webResourceResponseShouldInterceptRequest;
        File fileA;
        Uri url = request.getUrl();
        String string = url.toString();
        try {
            webResourceResponseShouldInterceptRequest = a(url);
            if (webResourceResponseShouldInterceptRequest != null) {
                return webResourceResponseShouldInterceptRequest;
            }
        } catch (Throwable unused) {
            webResourceResponseShouldInterceptRequest = null;
        }
        if (this.g && (webResourceResponseShouldInterceptRequest = c(string)) != null) {
            return webResourceResponseShouldInterceptRequest;
        }
        if (this.g && !d.a(string) && !a(string)) {
            webResourceResponseShouldInterceptRequest = d.a(string, request.getMethod(), request.getRequestHeaders());
        }
        if (webResourceResponseShouldInterceptRequest == null) {
            webResourceResponseShouldInterceptRequest = super.shouldInterceptRequest(view, request);
        }
        if (this.g && webResourceResponseShouldInterceptRequest != null && (fileA = a(webResourceResponseShouldInterceptRequest, string)) != null && fileA.exists()) {
            try {
                return new WebResourceResponse(webResourceResponseShouldInterceptRequest.getMimeType(), webResourceResponseShouldInterceptRequest.getEncoding(), new FileInputStream(fileA));
            } catch (FileNotFoundException unused2) {
            }
        }
        return webResourceResponseShouldInterceptRequest;
    }

    @Override // android.webkit.WebViewClient
    public WebResourceResponse shouldInterceptRequest(WebView view, String url) {
        WebResourceResponse webResourceResponseShouldInterceptRequest;
        File fileA;
        if (x.a(url)) {
            return null;
        }
        try {
            webResourceResponseShouldInterceptRequest = a(Uri.parse(url));
            if (webResourceResponseShouldInterceptRequest != null) {
                return webResourceResponseShouldInterceptRequest;
            }
        } catch (Throwable unused) {
            webResourceResponseShouldInterceptRequest = null;
        }
        if (this.g && (webResourceResponseShouldInterceptRequest = c(url)) != null) {
            return webResourceResponseShouldInterceptRequest;
        }
        if (this.g && !d.a(url) && !a(url)) {
            webResourceResponseShouldInterceptRequest = d.a(url, "GET", null);
        }
        if (webResourceResponseShouldInterceptRequest == null) {
            webResourceResponseShouldInterceptRequest = super.shouldInterceptRequest(view, url);
        }
        if (this.g && webResourceResponseShouldInterceptRequest != null && (fileA = a(webResourceResponseShouldInterceptRequest, url)) != null && fileA.exists()) {
            try {
                return new WebResourceResponse(webResourceResponseShouldInterceptRequest.getMimeType(), webResourceResponseShouldInterceptRequest.getEncoding(), new FileInputStream(fileA));
            } catch (FileNotFoundException unused2) {
            }
        }
        return webResourceResponseShouldInterceptRequest;
    }
}
