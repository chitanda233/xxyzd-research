package com.sigmob.sdk.base.common;

import android.net.Uri;
import android.os.AsyncTask;
import android.text.TextUtils;
import android.webkit.URLUtil;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.ResponseHeader;
import com.czhj.sdk.common.utils.Md5Util;
import com.czhj.sdk.logger.SigmobLog;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URISyntaxException;
import java.net.URL;
import java.util.HashMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes3.dex */
public class s extends AsyncTask<String, Void, HashMap<String, String>> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3199a = 10;
    private final a b;

    public interface a {
        void a(final String fileName, String url);

        void a(final String message, final Throwable throwable);
    }

    private s(a listener) {
        this.b = listener;
    }

    public static String a(final String urlString) {
        if (!urlString.toLowerCase().contains(".apk")) {
            return null;
        }
        String strB = b(urlString);
        if (!TextUtils.isEmpty(strB)) {
            return strB;
        }
        String strC = c(urlString);
        if (TextUtils.isEmpty(strC)) {
            return null;
        }
        return strC;
    }

    private static String a(String baseUrl, HttpURLConnection httpUrlConnection) throws URISyntaxException, IOException {
        int responseCode = httpUrlConnection.getResponseCode();
        if (responseCode < 200 || responseCode >= 400) {
            return null;
        }
        try {
            return URLUtil.guessFileName(baseUrl, httpUrlConnection.getHeaderField(com.sigmob.sdk.downloader.core.c.j), null);
        } catch (IllegalArgumentException unused) {
            SigmobLog.e("Invalid URL redirection. baseUrl=" + baseUrl);
            throw new URISyntaxException(baseUrl, "Unable to parse invalid URL");
        } catch (NullPointerException e) {
            SigmobLog.e("Invalid URL redirection. baseUrl=" + baseUrl);
            throw e;
        }
    }

    public static void a(String urlString, a listener) {
        try {
            String strA = a(urlString);
            if (TextUtils.isEmpty(strA)) {
                new s(listener).executeOnExecutor(ThreadPoolFactory.BackgroundThreadPool.getInstance().getExecutorService(), urlString);
            } else {
                listener.a(strA, urlString);
            }
        } catch (Throwable th) {
            listener.a("Failed to resolve url", th);
        }
    }

    public static String b(String contentDisposition) {
        try {
            Matcher matcher = Pattern.compile("(fsname=)(.*?apk)", 2).matcher(contentDisposition);
            if (matcher.find()) {
                return matcher.group(2);
            }
            return null;
        } catch (Throwable unused) {
            return null;
        }
    }

    public static String c(String contentDisposition) {
        try {
            Matcher matcher = Pattern.compile("[\\w\\.]+\\.apk", 2).matcher(contentDisposition);
            if (matcher.find()) {
                return matcher.group(0);
            }
            return null;
        } catch (Throwable unused) {
            return null;
        }
    }

    private String d(String urlString) throws URISyntaxException, IOException {
        String str = null;
        while (urlString != null) {
            try {
                str = urlString;
                urlString = e(urlString);
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
                return urlString;
            }
        }
        return str;
    }

    private static String e(final String baseUrl) throws URISyntaxException, IOException {
        HttpURLConnection httpURLConnection;
        String str = null;
        try {
            httpURLConnection = (HttpURLConnection) new URL(baseUrl).openConnection();
            try {
                httpURLConnection.setInstanceFollowRedirects(false);
                httpURLConnection.addRequestProperty(ResponseHeader.USER_AGENT.getKey(), Networking.getUserAgent());
                int responseCode = httpURLConnection.getResponseCode();
                String headerField = httpURLConnection.getHeaderField("Location");
                if (responseCode >= 300 && responseCode < 400) {
                    str = headerField;
                }
                if (httpURLConnection != null) {
                }
            } catch (Throwable th) {
                th = th;
                try {
                    SigmobLog.e("resolveRedirectLocation fail", th);
                    return str;
                } finally {
                    if (httpURLConnection != null) {
                        httpURLConnection.disconnect();
                    }
                }
            }
        } catch (Throwable th2) {
            th = th2;
            httpURLConnection = null;
        }
        return str;
    }

    /* JADX WARN: Code duplicated, block: B:29:0x008e  */
    private String f(final String urlString) {
        HttpURLConnection httpURLConnection;
        String strC;
        HttpURLConnection httpURLConnection2 = null;
        try {
            if (TextUtils.isEmpty(null)) {
                httpURLConnection = (HttpURLConnection) new URL(urlString).openConnection();
                try {
                    httpURLConnection.setInstanceFollowRedirects(false);
                    httpURLConnection.addRequestProperty(ResponseHeader.USER_AGENT.getKey(), Networking.getUserAgent());
                    String strA = a(urlString, httpURLConnection);
                    if (strA != null) {
                        if (strA.contains("fsname=")) {
                            strC = b(urlString);
                        } else if (strA.contains(".apk")) {
                            strC = c(strA);
                        } else {
                            httpURLConnection2 = httpURLConnection;
                            strC = strA;
                        }
                    } else if (TextUtils.isEmpty(urlString)) {
                        strC = null;
                    } else {
                        String[] strArrSplit = Uri.parse(urlString).getPath().split("/");
                        if (strArrSplit.length > 1) {
                            strA = strArrSplit[strArrSplit.length - 1];
                        }
                        if (TextUtils.isEmpty(strA) || !strA.toLowerCase().endsWith(".apk")) {
                            strC = Md5Util.md5(urlString) + ".apk";
                        } else {
                            strC = null;
                        }
                    }
                    httpURLConnection2 = httpURLConnection;
                } catch (Throwable th) {
                    th = th;
                    try {
                        SigmobLog.e("getDownloadUrlFilename", th);
                    } finally {
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                    }
                }
            } else {
                strC = a(urlString);
            }
            if (httpURLConnection2 != null) {
                httpURLConnection2.disconnect();
            }
            return strC;
        } catch (Throwable th2) {
            th = th2;
            httpURLConnection = null;
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public HashMap<String, String> doInBackground(String... urls) {
        if (urls == null || urls.length == 0) {
            return null;
        }
        HashMap<String, String> map = new HashMap<>();
        try {
            String strD = urls[0];
            try {
                strD = d(strD);
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
            }
            map.put("url", strD);
            map.put("fileName", f(strD));
        } catch (Throwable th2) {
            SigmobLog.e(th2.getMessage());
        }
        return map;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onPostExecute(final HashMap<String, String> map) {
        String str;
        String str2;
        if (map != null) {
            str = map.get("fileName");
            str2 = map.get("url");
        } else {
            str = null;
            str2 = null;
        }
        this.b.a(str, str2);
    }

    @Override // android.os.AsyncTask
    protected void onCancelled() {
        super.onCancelled();
        this.b.a("Task for resolving url was cancelled", (Throwable) null);
    }
}
