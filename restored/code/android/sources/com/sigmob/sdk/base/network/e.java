package com.sigmob.sdk.base.network;

import android.os.Handler;
import android.os.Looper;
import com.sigmob.sdk.base.utils.k;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.RandomAccessFile;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.Charset;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3237a = "e";
    private static final int g = 4096;
    private final Object b = new Object();
    private final Handler c = new Handler(Looper.getMainLooper());
    private final ExecutorService d = Executors.newFixedThreadPool(Runtime.getRuntime().availableProcessors());
    private volatile boolean e;
    private volatile boolean f;

    public interface a {
        void a(long totalBytes, long currBytes, String filename);

        void a(File downloadFile, String filename);

        void a(Exception e, String filename);

        void b(long totalBytes, long currBytes, String filename);

        void c(long totalBytes, long currBytes, String filename);
    }

    public interface b {
        void a(Exception exception);

        void a(String response);
    }

    private int a(long contentLengthLong, long downloadedLength) {
        if (contentLengthLong <= 0) {
            return -1;
        }
        return (int) ((downloadedLength * 100) / contentLengthLong);
    }

    private long a(HttpURLConnection connection) {
        try {
            if (Long.parseLong(connection.getHeaderField(com.sigmob.sdk.downloader.core.c.e)) <= 0) {
                return b(connection);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return b(connection);
    }

    private String a(InputStream is) throws IOException {
        if (is == null) {
            return "";
        }
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
        StringBuilder sb = new StringBuilder();
        while (true) {
            String line = bufferedReader.readLine();
            if (line == null) {
                return sb.toString();
            }
            sb.append(line).append('\n');
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(a aVar, Exception exc, File file) {
        aVar.a(exc, file.getName());
    }

    private static long b(HttpURLConnection connection) {
        return connection.getContentLengthLong();
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:34:0x00c7  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v0 */
    /* JADX WARN: Type inference failed for: r1v2, types: [java.net.HttpURLConnection] */
    /* JADX WARN: Type inference failed for: r1v3 */
    public /* synthetic */ void b(String str, final b bVar) throws Throwable {
        final Exception e;
        HttpURLConnection httpURLConnection;
        ?? r1 = 0;
        try {
            try {
                httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
                try {
                    httpURLConnection.setRequestMethod("GET");
                    httpURLConnection.setReadTimeout(10000);
                    httpURLConnection.setConnectTimeout(15000);
                    int i = 0;
                    while (i < 3) {
                        int responseCode = httpURLConnection.getResponseCode();
                        k.c(f3237a, "GET response code = " + responseCode + ", response message = " + httpURLConnection.getResponseMessage(), new Object[0]);
                        if (responseCode == 200) {
                            BufferedInputStream bufferedInputStream = new BufferedInputStream(httpURLConnection.getInputStream());
                            final String strA = a(bufferedInputStream);
                            bufferedInputStream.close();
                            if (bVar == null) {
                                break;
                            }
                            this.c.post(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda2
                                @Override // java.lang.Runnable
                                public final void run() {
                                    bVar.a(strA);
                                }
                            });
                            break;
                        }
                        TimeUnit.SECONDS.sleep((long) Math.pow(2.0d, i));
                        i++;
                    }
                    if (i == 3) {
                        throw new IOException("Failed to connect after retries.");
                    }
                    if (httpURLConnection == null) {
                        return;
                    }
                } catch (Exception e2) {
                    e = e2;
                    k.f(f3237a, "Error during GET request error = " + e.getMessage(), new Object[0]);
                    if (bVar != null) {
                        this.c.post(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda3
                            @Override // java.lang.Runnable
                            public final void run() {
                                bVar.a(e);
                            }
                        });
                    }
                    if (httpURLConnection == null) {
                        return;
                    }
                }
            } catch (Throwable th) {
                th = th;
                r1 = str;
                if (r1 != 0) {
                    r1.disconnect();
                }
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            httpURLConnection = null;
        } catch (Throwable th2) {
            th = th2;
            if (r1 != 0) {
                r1.disconnect();
            }
            throw th;
        }
        httpURLConnection.disconnect();
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:166:0x02e3 A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:167:0x02e5 A[Catch: Exception -> 0x02e1, TRY_LEAVE, TryCatch #11 {Exception -> 0x02e1, blocks: (B:163:0x02dd, B:167:0x02e5), top: B:195:0x02dd }] */
    /* JADX WARN: Code duplicated, block: B:171:0x02ee  */
    /* JADX WARN: Code duplicated, block: B:177:0x02fa A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:178:0x02fc A[Catch: Exception -> 0x02f8, TRY_LEAVE, TryCatch #2 {Exception -> 0x02f8, blocks: (B:174:0x02f4, B:178:0x02fc), top: B:185:0x02f4 }] */
    /* JADX WARN: Code duplicated, block: B:185:0x02f4 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:195:0x02dd A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:199:0x02cf A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:223:? A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:225:? A[RETURN, SYNTHETIC] */
    public /* synthetic */ void b(String str, String str2, final a aVar) throws Throwable {
        Throwable th;
        InputStream inputStream;
        RandomAccessFile randomAccessFile;
        HttpURLConnection httpURLConnection;
        RandomAccessFile randomAccessFile2;
        InputStream inputStream2;
        long j;
        RandomAccessFile randomAccessFile3;
        final File file = new File(str);
        long length = file.length();
        long j2 = file.exists() ? length : 0L;
        try {
            httpURLConnection = (HttpURLConnection) new URL(str2).openConnection();
            try {
                try {
                    httpURLConnection.setRequestMethod("GET");
                    httpURLConnection.setConnectTimeout(5000);
                    httpURLConnection.setRequestProperty(com.sigmob.sdk.downloader.core.c.b, "bytes=" + j2 + "-");
                    httpURLConnection.connect();
                    try {
                        if (this.f) {
                            httpURLConnection.disconnect();
                            if (httpURLConnection != null) {
                                httpURLConnection.disconnect();
                                return;
                            }
                            return;
                        }
                        int responseCode = httpURLConnection.getResponseCode();
                        String responseMessage = httpURLConnection.getResponseMessage();
                        boolean z = responseCode == 200;
                        boolean z2 = responseCode == 206;
                        String str3 = f3237a;
                        long j3 = j2;
                        k.c(str3, "downloadFile: responseCode = " + responseCode + ", isOK = " + z + ", isResumeSupported = " + z2, new Object[0]);
                        if (!z2 && !z) {
                            if (aVar != null) {
                                final Exception exc = new Exception("HTTP request failed with status code = " + responseCode + ", response message = " + responseMessage);
                                this.c.post(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda6
                                    @Override // java.lang.Runnable
                                    public final void run() {
                                        e.a(aVar, exc, file);
                                    }
                                });
                            }
                            if (httpURLConnection != null) {
                                httpURLConnection.disconnect();
                                return;
                            }
                            return;
                        }
                        if (z2) {
                            j = j3;
                        } else {
                            file.delete();
                            j = 0;
                        }
                        inputStream2 = httpURLConnection.getInputStream();
                        try {
                            RandomAccessFile randomAccessFile4 = new RandomAccessFile(file, "rw");
                            try {
                                randomAccessFile4.seek(j);
                                long jA = length + a(httpURLConnection);
                                if (aVar != null) {
                                    try {
                                        httpURLConnection = httpURLConnection;
                                        randomAccessFile3 = randomAccessFile4;
                                        try {
                                            aVar.a(jA, j, file.getName());
                                        } catch (Exception e) {
                                            e = e;
                                            randomAccessFile2 = randomAccessFile3;
                                            if (aVar != null) {
                                                try {
                                                    aVar.a(e, file.getName());
                                                } catch (Throwable th2) {
                                                    th = th2;
                                                    randomAccessFile = randomAccessFile2;
                                                    inputStream = inputStream2;
                                                    if (inputStream != null) {
                                                        try {
                                                            inputStream.close();
                                                            if (randomAccessFile != null) {
                                                                randomAccessFile.close();
                                                            }
                                                        } catch (Exception e2) {
                                                            e2.printStackTrace();
                                                        }
                                                    } else if (randomAccessFile != null) {
                                                        randomAccessFile.close();
                                                    }
                                                    if (httpURLConnection != null) {
                                                        throw th;
                                                    }
                                                    httpURLConnection.disconnect();
                                                    throw th;
                                                }
                                            }
                                            if (inputStream2 != null) {
                                                try {
                                                    inputStream2.close();
                                                    if (randomAccessFile2 != null) {
                                                        randomAccessFile2.close();
                                                    }
                                                } catch (Exception e3) {
                                                    e3.printStackTrace();
                                                }
                                            } else if (randomAccessFile2 != null) {
                                                randomAccessFile2.close();
                                            }
                                            if (httpURLConnection == null) {
                                                return;
                                            }
                                        } catch (Throwable th3) {
                                            th = th3;
                                            th = th;
                                            inputStream = inputStream2;
                                            randomAccessFile = randomAccessFile3;
                                            if (inputStream != null) {
                                                inputStream.close();
                                                if (randomAccessFile != null) {
                                                    randomAccessFile.close();
                                                }
                                            } else if (randomAccessFile != null) {
                                                randomAccessFile.close();
                                            }
                                            if (httpURLConnection != null) {
                                                throw th;
                                            }
                                            httpURLConnection.disconnect();
                                            throw th;
                                        }
                                    } catch (Exception e4) {
                                        e = e4;
                                        httpURLConnection = httpURLConnection;
                                        randomAccessFile3 = randomAccessFile4;
                                    } catch (Throwable th4) {
                                        th = th4;
                                        httpURLConnection = httpURLConnection;
                                        randomAccessFile3 = randomAccessFile4;
                                    }
                                } else {
                                    httpURLConnection = httpURLConnection;
                                    randomAccessFile3 = randomAccessFile4;
                                }
                                try {
                                    k.c(str3, "downloadFile onStart: downloadedBytes = " + j + ", totalBytes = " + jA + ", file = " + file.getName(), new Object[0]);
                                    byte[] bArr = new byte[4096];
                                    while (true) {
                                        long j4 = j;
                                        int i = inputStream2.read(bArr);
                                        if (i == -1) {
                                            RandomAccessFile randomAccessFile5 = randomAccessFile3;
                                            if (this.f) {
                                                file.delete();
                                                httpURLConnection.disconnect();
                                                if (inputStream2 != null) {
                                                    try {
                                                        inputStream2.close();
                                                    } catch (Exception e5) {
                                                        e5.printStackTrace();
                                                    }
                                                }
                                                randomAccessFile5.close();
                                                if (httpURLConnection != null) {
                                                    httpURLConnection.disconnect();
                                                    return;
                                                }
                                                return;
                                            }
                                            randomAccessFile5.close();
                                            httpURLConnection.disconnect();
                                            if (!this.e) {
                                                if (aVar != null) {
                                                    aVar.a(file, file.getName());
                                                }
                                                k.c(f3237a, "downloadFile onCompleted: filename = " + file.getName() + ", fileSize = " + file.length(), new Object[0]);
                                            } else if (aVar != null) {
                                                aVar.b(jA, j4, file.getName());
                                            }
                                            if (inputStream2 != null) {
                                                try {
                                                    inputStream2.close();
                                                } catch (Exception e6) {
                                                    e6.printStackTrace();
                                                }
                                            }
                                            randomAccessFile5.close();
                                            if (httpURLConnection == null) {
                                                return;
                                            }
                                            httpURLConnection.disconnect();
                                            return;
                                        }
                                        if (this.f) {
                                            randomAccessFile3.close();
                                            file.delete();
                                            httpURLConnection.disconnect();
                                            if (inputStream2 != null) {
                                                try {
                                                    inputStream2.close();
                                                } catch (Exception e7) {
                                                    e7.printStackTrace();
                                                }
                                            }
                                            randomAccessFile3.close();
                                            if (httpURLConnection != null) {
                                                httpURLConnection.disconnect();
                                                return;
                                            }
                                            return;
                                        }
                                        if (this.e) {
                                            if (aVar != null) {
                                                aVar.b(jA, j4, file.getName());
                                            }
                                            randomAccessFile3.close();
                                            httpURLConnection.disconnect();
                                            if (inputStream2 != null) {
                                                try {
                                                    inputStream2.close();
                                                } catch (Exception e8) {
                                                    e8.printStackTrace();
                                                }
                                            }
                                            randomAccessFile3.close();
                                            if (httpURLConnection != null) {
                                                httpURLConnection.disconnect();
                                                return;
                                            }
                                            return;
                                        }
                                        synchronized (this.b) {
                                            randomAccessFile = randomAccessFile3;
                                            randomAccessFile.write(bArr, 0, i);
                                        }
                                        j = j4 + ((long) i);
                                        if (aVar != null) {
                                            try {
                                                aVar.c(jA, j, file.getName());
                                            } catch (Exception e9) {
                                                e = e9;
                                            } catch (Throwable th5) {
                                                th = th5;
                                                th = th;
                                                inputStream = inputStream2;
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                    if (randomAccessFile != null) {
                                                        randomAccessFile.close();
                                                    }
                                                } else if (randomAccessFile != null) {
                                                    randomAccessFile.close();
                                                }
                                                if (httpURLConnection != null) {
                                                    throw th;
                                                }
                                                httpURLConnection.disconnect();
                                                throw th;
                                            }
                                        }
                                        k.c(f3237a, "downloadFile onProgress: downloadedBytes = " + j + ", totalBytes = " + jA + ", progress = " + a(jA, j) + ", file = " + file.getName(), new Object[0]);
                                        randomAccessFile3 = randomAccessFile;
                                        randomAccessFile2 = randomAccessFile;
                                        if (aVar != null) {
                                            aVar.a(e, file.getName());
                                        }
                                        if (inputStream2 != null) {
                                            inputStream2.close();
                                            if (randomAccessFile2 != null) {
                                                randomAccessFile2.close();
                                            }
                                        } else if (randomAccessFile2 != null) {
                                            randomAccessFile2.close();
                                        }
                                        if (httpURLConnection == null) {
                                            return;
                                        }
                                        httpURLConnection.disconnect();
                                        return;
                                    }
                                } catch (Exception e10) {
                                    e = e10;
                                    randomAccessFile = randomAccessFile3;
                                } catch (Throwable th6) {
                                    th = th6;
                                    randomAccessFile = randomAccessFile3;
                                }
                            } catch (Exception e11) {
                                e = e11;
                                httpURLConnection = httpURLConnection;
                                randomAccessFile = randomAccessFile4;
                            } catch (Throwable th7) {
                                th = th7;
                                httpURLConnection = httpURLConnection;
                                randomAccessFile = randomAccessFile4;
                            }
                        } catch (Exception e12) {
                            e = e12;
                            httpURLConnection = httpURLConnection;
                            randomAccessFile2 = null;
                        } catch (Throwable th8) {
                            httpURLConnection = httpURLConnection;
                            th = th8;
                            inputStream = inputStream2;
                            randomAccessFile = null;
                        }
                    } catch (Throwable th9) {
                        th = th9;
                        inputStream = null;
                    }
                } catch (Throwable th10) {
                    th = th10;
                }
            } catch (Exception e13) {
                e = e13;
                httpURLConnection = httpURLConnection;
                randomAccessFile2 = null;
                inputStream2 = null;
            }
            inputStream = null;
            randomAccessFile = null;
        } catch (Exception e14) {
            e = e14;
            randomAccessFile2 = null;
            inputStream2 = null;
            httpURLConnection = null;
        } catch (Throwable th11) {
            th = th11;
            inputStream = null;
            randomAccessFile = null;
            httpURLConnection = null;
        }
        if (inputStream != null) {
            inputStream.close();
            if (randomAccessFile != null) {
                randomAccessFile.close();
            }
        } else if (randomAccessFile != null) {
            randomAccessFile.close();
        }
        if (httpURLConnection != null) {
            throw th;
        }
        httpURLConnection.disconnect();
        throw th;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(String str, String str2, final b bVar) throws Throwable {
        HttpURLConnection httpURLConnection = null;
        try {
            try {
                HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(str).openConnection();
                try {
                    httpURLConnection2.setRequestMethod("POST");
                    httpURLConnection2.setReadTimeout(10000);
                    httpURLConnection2.setConnectTimeout(15000);
                    httpURLConnection2.setDoOutput(true);
                    httpURLConnection2.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
                    OutputStream outputStream = httpURLConnection2.getOutputStream();
                    BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(outputStream, Charset.forName("UTF-8")));
                    if (str2 == null) {
                        str2 = "";
                    }
                    bufferedWriter.write(str2);
                    bufferedWriter.flush();
                    bufferedWriter.close();
                    outputStream.close();
                    int responseCode = httpURLConnection2.getResponseCode();
                    String responseMessage = httpURLConnection2.getResponseMessage();
                    k.c(f3237a, "POST response code = " + responseCode + ", response message = " + responseMessage, new Object[0]);
                    if (responseCode != 200) {
                        throw new IOException("Unexpected HTTP response code = " + responseCode + ", response message = " + responseMessage);
                    }
                    BufferedInputStream bufferedInputStream = new BufferedInputStream(httpURLConnection2.getInputStream());
                    final String strA = a(bufferedInputStream);
                    bufferedInputStream.close();
                    if (bVar != null) {
                        this.c.post(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda4
                            @Override // java.lang.Runnable
                            public final void run() {
                                bVar.a(strA);
                            }
                        });
                    }
                    if (httpURLConnection2 != null) {
                        httpURLConnection2.disconnect();
                    }
                } catch (Exception e) {
                    e = e;
                    httpURLConnection = httpURLConnection2;
                    k.f(f3237a, "Error during POST request error = " + e.getMessage(), new Object[0]);
                    if (bVar != null) {
                        this.c.post(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda5
                            @Override // java.lang.Runnable
                            public final void run() {
                                bVar.a(e);
                            }
                        });
                    }
                    if (httpURLConnection != null) {
                        httpURLConnection.disconnect();
                    }
                } catch (Throwable th) {
                    th = th;
                    httpURLConnection = httpURLConnection2;
                    if (httpURLConnection != null) {
                        httpURLConnection.disconnect();
                    }
                    throw th;
                }
            } catch (Exception e2) {
                e = e2;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    public void a() {
        this.e = true;
    }

    public void a(final String urlStr, final b callback) {
        this.d.submit(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() throws Throwable {
                this.f$0.b(urlStr, callback);
            }
        });
    }

    public void a(final String urlString, final String destinationPath, final a listener) {
        this.e = false;
        this.f = false;
        this.d.submit(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() throws Throwable {
                this.f$0.b(destinationPath, urlString, listener);
            }
        });
    }

    public void a(final String urlStr, final String jsonStr, final b callback) {
        this.d.submit(new Runnable() { // from class: com.sigmob.sdk.base.network.e$$ExternalSyntheticLambda7
            @Override // java.lang.Runnable
            public final void run() throws Throwable {
                this.f$0.b(urlStr, jsonStr, callback);
            }
        });
    }

    public void b() {
        this.f = true;
    }

    public void c() {
        this.c.removeCallbacksAndMessages(null);
        ExecutorService executorService = this.d;
        if (executorService == null) {
            return;
        }
        executorService.shutdown();
    }
}
