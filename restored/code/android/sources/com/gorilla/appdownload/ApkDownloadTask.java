package com.gorilla.appdownload;

import android.content.Context;
import com.baidu.mobads.sdk.internal.bz;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.security.MessageDigest;
import java.util.Locale;
import java.util.Objects;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
final class ApkDownloadTask {
    private static final int BUFFER_SIZE = 8192;
    private static final int MAX_REDIRECTS = 5;
    private static final String TAG = "GorillaAppDownload";
    private static final ILogger logger = LogFactory.getLogger();
    private volatile boolean cancelled;
    private HttpURLConnection connection;
    private final Context context;
    private final File destinationFile;
    private final String downloadUrl;
    private final Listener listener;
    private volatile boolean running;
    private Thread thread;

    interface Listener {
        void onCancelled();

        void onComplete(File file);

        void onFailure(Exception exc);

        void onProgress(int i);
    }

    ApkDownloadTask(Context context, String str, Listener listener) {
        Context applicationContext = context.getApplicationContext();
        this.context = applicationContext;
        this.downloadUrl = str;
        this.listener = listener;
        this.destinationFile = new File(getDownloadDir(applicationContext), buildFileName(applicationContext, str));
    }

    static File getDownloadDir(Context context) {
        return new File(context.getFilesDir(), "gorilla_app_download");
    }

    void start() {
        if (this.running) {
            return;
        }
        this.cancelled = false;
        this.running = true;
        Thread thread = new Thread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() throws Throwable {
                this.f$0.download();
            }
        }, TAG);
        this.thread = thread;
        thread.start();
    }

    void cancel() {
        this.cancelled = true;
        HttpURLConnection httpURLConnection = this.connection;
        if (httpURLConnection != null) {
            httpURLConnection.disconnect();
        }
        Thread thread = this.thread;
        if (thread != null) {
            thread.interrupt();
        }
    }

    boolean isRunning() {
        return this.running;
    }

    File getDestinationFile() {
        return this.destinationFile;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r2v1 */
    /* JADX WARN: Type inference failed for: r2v17 */
    /* JADX WARN: Type inference failed for: r2v18 */
    /* JADX WARN: Type inference failed for: r2v3, types: [java.net.HttpURLConnection] */
    public void download() throws Throwable {
        boolean z;
        ?? r2;
        HttpURLConnection httpURLConnectionOpenConnection;
        HttpURLConnection httpURLConnection;
        int i = 0;
        try {
            try {
                File parentFile = this.destinationFile.getParentFile();
                if (parentFile != null && !parentFile.exists() && !parentFile.mkdirs()) {
                    throw new IllegalStateException("Create download directory failed: " + parentFile.getAbsolutePath());
                }
                if (this.destinationFile.exists() && !this.destinationFile.delete()) {
                    logger.warning(TAG, "Delete old apk failed: " + this.destinationFile.getAbsolutePath());
                }
                httpURLConnectionOpenConnection = openConnection(this.downloadUrl);
                try {
                    try {
                        this.connection = httpURLConnectionOpenConnection;
                        int responseCode = httpURLConnectionOpenConnection.getResponseCode();
                        if (responseCode < 200 || responseCode >= 300) {
                            throw new IllegalStateException("Server returned HTTP " + responseCode);
                        }
                        long contentLengthLong = httpURLConnectionOpenConnection.getContentLengthLong();
                        InputStream inputStream = httpURLConnectionOpenConnection.getInputStream();
                        try {
                            FileOutputStream fileOutputStream = new FileOutputStream(this.destinationFile);
                            try {
                                byte[] bArr = new byte[8192];
                                long j = 0;
                                int i2 = -1;
                                long j2 = 0;
                                int i3 = -1;
                                while (true) {
                                    int i4 = inputStream.read(bArr);
                                    if (i4 == i2) {
                                        fileOutputStream.flush();
                                        fileOutputStream.close();
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                        final boolean z2 = i3 < 100;
                                        ThreadUtil.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda3
                                            @Override // java.lang.Runnable
                                            public final void run() {
                                                this.f$0.m126lambda$download$1$comgorillaappdownloadApkDownloadTask(z2);
                                            }
                                        });
                                        this.running = false;
                                        this.connection = null;
                                        httpURLConnection = httpURLConnectionOpenConnection;
                                        if (httpURLConnectionOpenConnection != null) {
                                            break;
                                        } else {
                                            return;
                                        }
                                    }
                                    if (!this.cancelled && !Thread.currentThread().isInterrupted()) {
                                        fileOutputStream.write(bArr, i, i4);
                                        j2 += (long) i4;
                                        if (contentLengthLong > j) {
                                            final int iMin = (int) Math.min(100L, (j2 * 100) / contentLengthLong);
                                            if (iMin > i3) {
                                                ThreadUtil.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda2
                                                    @Override // java.lang.Runnable
                                                    public final void run() {
                                                        this.f$0.m125lambda$download$0$comgorillaappdownloadApkDownloadTask(iMin);
                                                    }
                                                });
                                                i3 = iMin;
                                            }
                                            i = 0;
                                            j = 0;
                                        } else {
                                            i = 0;
                                        }
                                        i2 = -1;
                                    }
                                    deletePartialFile();
                                    final Listener listener = this.listener;
                                    Objects.requireNonNull(listener);
                                    ThreadUtil.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda1
                                        @Override // java.lang.Runnable
                                        public final void run() {
                                            listener.onCancelled();
                                        }
                                    });
                                    fileOutputStream.close();
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    this.running = false;
                                    this.connection = null;
                                    if (httpURLConnectionOpenConnection != null) {
                                        httpURLConnectionOpenConnection.disconnect();
                                        return;
                                    }
                                    return;
                                }
                                httpURLConnection.disconnect();
                            } catch (Throwable th) {
                                try {
                                    fileOutputStream.close();
                                    throw th;
                                } catch (Throwable th2) {
                                    th.addSuppressed(th2);
                                    throw th;
                                }
                            }
                        } catch (Throwable th3) {
                            if (inputStream == null) {
                                throw th3;
                            }
                            try {
                                inputStream.close();
                                throw th3;
                            } catch (Throwable th4) {
                                th3.addSuppressed(th4);
                                throw th3;
                            }
                        }
                    } catch (Exception e) {
                        e = e;
                        if (this.cancelled) {
                            deletePartialFile();
                            final Listener listener2 = this.listener;
                            Objects.requireNonNull(listener2);
                            ThreadUtil.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda1
                                @Override // java.lang.Runnable
                                public final void run() {
                                    listener2.onCancelled();
                                }
                            });
                            this.running = false;
                            this.connection = null;
                            if (httpURLConnectionOpenConnection != null) {
                                httpURLConnectionOpenConnection.disconnect();
                                return;
                            }
                            return;
                        }
                        ThreadUtil.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.ApkDownloadTask$$ExternalSyntheticLambda4
                            @Override // java.lang.Runnable
                            public final void run() {
                                this.f$0.m127lambda$download$2$comgorillaappdownloadApkDownloadTask(e);
                            }
                        });
                        this.running = false;
                        this.connection = null;
                        httpURLConnection = httpURLConnectionOpenConnection;
                        if (httpURLConnectionOpenConnection == null) {
                        }
                    }
                } catch (Throwable th5) {
                    th = th5;
                    z = false;
                    r2 = httpURLConnectionOpenConnection;
                    this.running = z;
                    this.connection = null;
                    if (r2 != 0) {
                        r2.disconnect();
                    }
                    throw th;
                }
            } catch (Throwable th6) {
                th = th6;
                z = false;
                r2 = "Delete old apk failed: ";
            }
        } catch (Exception e2) {
            e = e2;
            httpURLConnectionOpenConnection = null;
        } catch (Throwable th7) {
            th = th7;
            z = false;
            r2 = 0;
        }
    }

    /* JADX INFO: renamed from: lambda$download$0$com-gorilla-appdownload-ApkDownloadTask, reason: not valid java name */
    /* synthetic */ void m125lambda$download$0$comgorillaappdownloadApkDownloadTask(int i) {
        this.listener.onProgress(i);
    }

    /* JADX INFO: renamed from: lambda$download$1$com-gorilla-appdownload-ApkDownloadTask, reason: not valid java name */
    /* synthetic */ void m126lambda$download$1$comgorillaappdownloadApkDownloadTask(boolean z) {
        if (z) {
            this.listener.onProgress(100);
        }
        this.listener.onComplete(this.destinationFile);
    }

    /* JADX INFO: renamed from: lambda$download$2$com-gorilla-appdownload-ApkDownloadTask, reason: not valid java name */
    /* synthetic */ void m127lambda$download$2$comgorillaappdownloadApkDownloadTask(Exception exc) {
        this.listener.onFailure(exc);
    }

    private HttpURLConnection openConnection(String str) throws Exception {
        URL url = new URL(str);
        int i = 0;
        while (i <= 5) {
            HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();
            httpURLConnection.setConnectTimeout(15000);
            httpURLConnection.setReadTimeout(KSImageLoader.InnerImageLoadingListener.MAX_DURATION);
            httpURLConnection.setInstanceFollowRedirects(false);
            int responseCode = httpURLConnection.getResponseCode();
            if (responseCode != 302 && responseCode != 301 && responseCode != 303 && responseCode != 307 && responseCode != 308) {
                return httpURLConnection;
            }
            String headerField = httpURLConnection.getHeaderField("Location");
            httpURLConnection.disconnect();
            if (headerField == null || headerField.length() == 0) {
                throw new IllegalStateException("Redirect without Location header");
            }
            i++;
            url = new URL(url, headerField);
        }
        throw new IllegalStateException("Too many redirects");
    }

    private void deletePartialFile() {
        if (!this.destinationFile.exists() || this.destinationFile.delete()) {
            return;
        }
        logger.warning(TAG, "Delete partial apk failed: " + this.destinationFile.getAbsolutePath());
    }

    private static String buildFileName(Context context, String str) {
        return upperMd5(str + context.getPackageName()) + ".apk";
    }

    private static String upperMd5(String str) {
        try {
            byte[] bArrDigest = MessageDigest.getInstance(bz.f456a).digest(str.getBytes("UTF-8"));
            StringBuilder sb = new StringBuilder();
            for (byte b : bArrDigest) {
                sb.append(String.format(Locale.US, "%02x", Integer.valueOf(b & UByte.MAX_VALUE)));
            }
            return sb.toString().toUpperCase(Locale.US).substring(8, 24);
        } catch (Exception unused) {
            return String.valueOf(Math.abs(str.hashCode()));
        }
    }
}
