package com.sigmob.sdk.videocache;

import android.content.Context;
import android.text.TextUtils;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import java.io.InputStream;
import java.lang.ref.WeakReference;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public class w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static w f3683a;
    private final ExecutorService b = Executors.newFixedThreadPool(8);
    private final Map<String, WeakReference<a>> c = new HashMap();
    private Context d;

    private static class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final String f3684a;
        private final AtomicBoolean b = new AtomicBoolean(false);

        public a(String url) {
            this.f3684a = url;
        }

        /* JADX WARN: Code duplicated, block: B:56:0x0093 A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:60:0x009d A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:71:? A[SYNTHETIC] */
        /* JADX WARN: Multi-variable type inference failed */
        /* JADX WARN: Type inference failed for: r7v0, types: [java.lang.String] */
        /* JADX WARN: Type inference failed for: r7v2 */
        /* JADX WARN: Type inference failed for: r7v4, types: [java.net.HttpURLConnection] */
        private void a(String getURL) throws Throwable {
            HttpURLConnection httpURLConnection;
            InputStream inputStream = null;
            try {
                try {
                    try {
                        httpURLConnection = (HttpURLConnection) new URL(getURL).openConnection();
                        try {
                            httpURLConnection.setConnectTimeout(5000);
                            httpURLConnection.setReadTimeout(5000);
                            httpURLConnection.connect();
                            byte[] bArr = new byte[1024];
                            inputStream = httpURLConnection.getInputStream();
                            while (inputStream.read(bArr) != -1) {
                                if (this.b.get()) {
                                    SigmobLog.d(String.format("cancelPreLoadVideo，取消网络请求，成功（正在下载数据），url = %s", this.f3684a));
                                    break;
                                }
                            }
                            SigmobLog.i(String.format("preloadVideo，网络文件，成功，url = %s", this.f3684a));
                            if (inputStream != null) {
                                try {
                                    inputStream.close();
                                } catch (Exception e) {
                                    e.printStackTrace();
                                }
                            }
                            if (httpURLConnection != null) {
                                httpURLConnection.disconnect();
                            }
                        } catch (Exception e2) {
                            e = e2;
                            SigmobLog.e(String.format("preloadVideo，网络文件，失败，msg = %s，url = %s", e.getMessage(), this.f3684a));
                            if (inputStream != null) {
                                try {
                                    inputStream.close();
                                } catch (Exception e3) {
                                    e3.printStackTrace();
                                }
                            }
                            if (httpURLConnection == null) {
                            } else {
                                httpURLConnection.disconnect();
                            }
                        }
                    } catch (Throwable th) {
                        th = th;
                        if (0 != 0) {
                            try {
                                inputStream.close();
                            } catch (Exception e4) {
                                e4.printStackTrace();
                            }
                        }
                        if (getURL != 0) {
                            throw th;
                        }
                        try {
                            getURL.disconnect();
                            throw th;
                        } catch (Exception e5) {
                            e5.printStackTrace();
                            throw th;
                        }
                    }
                } catch (Exception e6) {
                    e = e6;
                    httpURLConnection = null;
                } catch (Throwable th2) {
                    th = th2;
                    getURL = 0;
                    if (0 != 0) {
                        inputStream.close();
                    }
                    if (getURL != 0) {
                        throw th;
                    }
                    getURL.disconnect();
                    throw th;
                }
            } catch (Exception e7) {
                e7.printStackTrace();
            }
        }

        public void a(boolean cancel) {
            this.b.set(cancel);
        }

        @Override // java.lang.Runnable
        public void run() throws Throwable {
            if (this.b.get()) {
                SigmobLog.i(String.format("cancelPreLoadVideo，取消网络请求，成功（未下载数据），url = %s", this.f3684a));
            } else {
                a(this.f3684a);
            }
        }
    }

    private w(Context context) {
        this.d = context;
    }

    public static synchronized w a(Context context) {
        if (f3683a == null && context != null) {
            f3683a = new w(context.getApplicationContext());
        }
        return f3683a;
    }

    public void a(String url) {
        if (TextUtils.isEmpty(url)) {
            return;
        }
        String url2 = StringUtil.getUrl(url);
        if (!url2.startsWith("http")) {
            SigmobLog.d(String.format("preloadVideo，本地文件：ulr = %s", url2));
            return;
        }
        SigmobLog.d(String.format("preloadVideo，网络文件，开始下载：ulr = %s", url2));
        a aVar = new a(url2);
        this.c.put(url2, new WeakReference<>(aVar));
        this.b.execute(aVar);
    }

    public void b(String url) {
        WeakReference<a> weakReference;
        a aVar;
        SigmobLog.d(String.format("cancelPreLoadVideo，ulr = %s", url));
        if (TextUtils.isEmpty(url) || (weakReference = this.c.get(url)) == null || (aVar = weakReference.get()) == null) {
            return;
        }
        SigmobLog.d(String.format("cancelPreLoadVideo，取消网络请求，ulr = %s", url));
        aVar.a(true);
    }
}
