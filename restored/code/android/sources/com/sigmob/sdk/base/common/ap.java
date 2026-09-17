package com.sigmob.sdk.base.common;

import android.net.Uri;
import android.os.AsyncTask;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.ResponseHeader;
import com.czhj.sdk.logger.SigmobLog;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class ap extends AsyncTask<String, Void, String> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3161a = 10;
    private final a b;

    public interface a {
        void a(String resolvedUrl);

        void a(String message, Throwable throwable);
    }

    private ap(a listener) {
        this.b = listener;
    }

    private static String a(String baseUrl, HttpURLConnection httpUrlConnection) throws Throwable {
        URI uri = new URI(baseUrl);
        int responseCode = httpUrlConnection.getResponseCode();
        String headerField = httpUrlConnection.getHeaderField("Location");
        if (responseCode < 300 || responseCode >= 400) {
            return null;
        }
        try {
            return uri.resolve(headerField).toString();
        } catch (IllegalArgumentException unused) {
            SigmobLog.e("Invalid URL redirection. baseUrl=" + baseUrl + "\n redirectUrl=" + headerField);
            throw new URISyntaxException(headerField, "Unable to parse invalid URL");
        } catch (Throwable th) {
            SigmobLog.e("Invalid URL redirection. baseUrl=" + baseUrl + "\n redirectUrl=" + headerField);
            throw th;
        }
    }

    public static void a(String urlString, a listener) {
        try {
            new ap(listener).executeOnExecutor(ThreadPoolFactory.BackgroundThreadPool.getInstance().getExecutorService(), urlString);
        } catch (Throwable th) {
            listener.a("Failed to resolve url", th);
        }
    }

    private String b(String urlString) throws Throwable {
        HttpURLConnection httpURLConnection = null;
        try {
            HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(urlString).openConnection();
            try {
                httpURLConnection2.setInstanceFollowRedirects(false);
                httpURLConnection2.addRequestProperty(ResponseHeader.USER_AGENT.getKey(), Networking.getUserAgent());
                String strA = a(urlString, httpURLConnection2);
                if (httpURLConnection2 != null) {
                    InputStream inputStream = httpURLConnection2.getInputStream();
                    if (inputStream != null) {
                        try {
                            inputStream.close();
                        } catch (Throwable unused) {
                            SigmobLog.d("IOException when closing httpUrlConnection. Ignoring.");
                        }
                    }
                    httpURLConnection2.disconnect();
                }
                return strA;
            } catch (Throwable th) {
                th = th;
                httpURLConnection = httpURLConnection2;
                if (httpURLConnection != null) {
                    InputStream inputStream2 = httpURLConnection.getInputStream();
                    if (inputStream2 != null) {
                        try {
                            inputStream2.close();
                        } catch (Throwable unused2) {
                            SigmobLog.d("IOException when closing httpUrlConnection. Ignoring.");
                        }
                    }
                    httpURLConnection.disconnect();
                }
                throw th;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public String doInBackground(String... urls) {
        String str = null;
        if (urls == null || urls.length == 0) {
            return null;
        }
        try {
            String strB = urls[0];
            while (true) {
                String str2 = str;
                str = strB;
                if (str == null) {
                    return str2;
                }
                try {
                    if (!an.OPEN_WITH_BROWSER.a(Uri.parse(str), 0)) {
                        return str;
                    }
                    strB = b(str);
                } catch (Throwable th) {
                    str = str2;
                    th = th;
                }
                SigmobLog.w(th.getMessage());
                return str;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onPostExecute(String resolvedUrl) {
        super.onPostExecute(resolvedUrl);
        if (isCancelled() || resolvedUrl == null) {
            onCancelled();
        } else {
            this.b.a(resolvedUrl);
        }
    }

    @Override // android.os.AsyncTask
    public void onCancelled() {
        super.onCancelled();
        this.b.a("Task for resolving url was cancelled", null);
    }
}
