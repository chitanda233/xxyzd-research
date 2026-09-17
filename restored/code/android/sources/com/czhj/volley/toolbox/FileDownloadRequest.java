package com.czhj.volley.toolbox;

import android.text.TextUtils;
import com.czhj.volley.DefaultRetryPolicy;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.Request;
import com.czhj.volley.Response;
import com.czhj.volley.VolleyError;
import com.czhj.volley.VolleyLog;
import com.sigmob.sdk.downloader.core.c;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.RandomAccessFile;
import java.util.HashMap;
import java.util.Map;
import java.util.zip.GZIPInputStream;

/* JADX INFO: loaded from: classes2.dex */
public class FileDownloadRequest extends Request<DownloadItem> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private File f2330a;
    private File b;
    private DownloadItem c;
    private long d;
    private final Object e;
    private FileDownloadListener f;

    public interface FileDownloadListener {
        void downloadProgress(DownloadItem downloadItem, long j, long j2);

        void onCancel(DownloadItem downloadItem);

        void onErrorResponse(DownloadItem downloadItem);

        void onSuccess(DownloadItem downloadItem);
    }

    public FileDownloadRequest(DownloadItem downloadItem, FileDownloadListener fileDownloadListener) {
        super(0, downloadItem.url, null);
        this.d = 0L;
        this.e = new Object();
        this.f = null;
        File file = new File(downloadItem.filePath);
        this.f2330a = file;
        if (file.getParentFile() != null && !this.f2330a.getParentFile().exists()) {
            this.f2330a.getParentFile().mkdirs();
        }
        if (this.f2330a.exists()) {
            this.f2330a.delete();
        }
        this.c = downloadItem;
        this.b = new File(downloadItem.filePath + ".tmp");
        if (!downloadItem.userRange) {
            this.b.delete();
        }
        this.f = fileDownloadListener;
        setRetryPolicy(new DefaultRetryPolicy(10000, 2, 0.0f));
        setShouldCache(false);
        VolleyLog.d("FileDownloadRequest()  [ %s ], url = [%s]", downloadItem.filePath, downloadItem.url);
    }

    @Override // com.czhj.volley.Request
    public void cancel() {
        super.cancel();
        synchronized (this.e) {
            this.f = null;
        }
    }

    @Override // com.czhj.volley.Request
    public void deliverError(VolleyError volleyError) {
        this.c.status = 0;
        if (this.f2330a.exists()) {
            this.f2330a.delete();
        }
        if (this.b.exists()) {
            this.b.delete();
        }
        this.c.error = volleyError;
        this.f.onErrorResponse(this.c);
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.czhj.volley.Request
    public void deliverResponse(DownloadItem downloadItem) {
        this.c.status = 1;
        this.f.onSuccess(downloadItem);
    }

    @Override // com.czhj.volley.Request
    public Map<String, String> getHeaders() {
        HashMap map = new HashMap();
        this.d = this.b.length();
        map.put("Connection", "Keep-Alive");
        map.put("Accept-Encoding", "gzip");
        map.put(c.b, "bytes=" + this.d + "-");
        addMarker("Range,bytes=" + this.d + "-");
        return map;
    }

    @Override // com.czhj.volley.Request
    public Request.Priority getPriority() {
        return Request.Priority.LOW;
    }

    /* JADX WARN: Code duplicated, block: B:100:0x011f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:104:0x01b8 A[EDGE_INSN: B:104:0x01b8->B:58:0x01b8 BREAK  A[LOOP:0: B:36:0x010d->B:57:0x0188], SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:31:0x00fd A[Catch: all -> 0x01fa, TRY_ENTER, TryCatch #5 {all -> 0x01fa, blocks: (B:31:0x00fd, B:33:0x0105, B:32:0x0102), top: B:94:0x00fb }] */
    /* JADX WARN: Code duplicated, block: B:32:0x0102 A[Catch: all -> 0x01fa, TryCatch #5 {all -> 0x01fa, blocks: (B:31:0x00fd, B:33:0x0105, B:32:0x0102), top: B:94:0x00fb }] */
    /* JADX WARN: Code duplicated, block: B:39:0x0119 A[Catch: all -> 0x01f6, TRY_ENTER, TRY_LEAVE, TryCatch #2 {all -> 0x01f6, blocks: (B:35:0x010b, B:36:0x010d, B:39:0x0119, B:45:0x0141), top: B:88:0x010b }] */
    /* JADX WARN: Code duplicated, block: B:45:0x0141 A[Catch: all -> 0x01f6, TRY_ENTER, TRY_LEAVE, TryCatch #2 {all -> 0x01f6, blocks: (B:35:0x010b, B:36:0x010d, B:39:0x0119, B:45:0x0141), top: B:88:0x010b }] */
    /* JADX WARN: Code duplicated, block: B:56:0x0182  */
    /* JADX WARN: Code duplicated, block: B:92:0x01e5 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:98:0x014a A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public byte[] handleRawResponse(HttpResponse httpResponse) throws IOException {
        long length;
        InputStream inputStream;
        RandomAccessFile randomAccessFile;
        RandomAccessFile randomAccessFile2;
        InputStream content;
        byte[] bArr;
        int i;
        FileDownloadListener fileDownloadListener;
        byte[] bArr2;
        String str;
        String str2;
        String str3;
        FileDownloadRequest fileDownloadRequest = this;
        Map<String, String> mapConvertHeaders = FileDownloadNetwork.convertHeaders(httpResponse.getHeaders());
        boolean zIsSupportRange = HttpHeaderParser.isSupportRange(mapConvertHeaders);
        long contentLength = httpResponse.getContentLength();
        int i2 = -1;
        int i3 = 0;
        long j = 0;
        try {
            try {
                try {
                    if (!mapConvertHeaders.containsKey(c.h) || !mapConvertHeaders.get(c.h).equalsIgnoreCase("chunked")) {
                        if (contentLength < 0 || !mapConvertHeaders.containsKey(c.e)) {
                            length = fileDownloadRequest.b.length();
                        } else {
                            if (contentLength == 0 && fileDownloadRequest.f2330a.exists() && fileDownloadRequest.f2330a.length() == contentLength) {
                                fileDownloadRequest.f2330a.renameTo(fileDownloadRequest.b);
                                httpResponse.getContent().close();
                                return new byte[0];
                            }
                            if (zIsSupportRange) {
                                length = fileDownloadRequest.b.length();
                                contentLength += length;
                                String header = HttpHeaderParser.getHeader(mapConvertHeaders, c.f);
                                VolleyLog.d("Content-Range %s", header);
                                if (!TextUtils.isEmpty(header)) {
                                    String str4 = "bytes " + length + "-" + (contentLength - 1);
                                    if (TextUtils.indexOf(header, str4) == -1) {
                                        httpResponse.getContent().close();
                                        fileDownloadRequest.b.delete();
                                        throw new IllegalStateException("The Content-Range Header is invalid Assume[" + str4 + "] vs Real[" + header + "], has remove the temporary file [" + fileDownloadRequest.b + "].");
                                    }
                                }
                            }
                        }
                        inputStream = null;
                        randomAccessFile2 = new RandomAccessFile(fileDownloadRequest.b, "rw");
                        if (zIsSupportRange) {
                            randomAccessFile2.seek(length);
                            j = length;
                        } else {
                            randomAccessFile2.setLength(0L);
                        }
                        content = httpResponse.getContent();
                        bArr = new byte[8192];
                        while (true) {
                            i = content.read(bArr);
                            if (i == i2) {
                                break;
                            }
                            if (isCanceled()) {
                                try {
                                    VolleyLog.v(fileDownloadRequest.c.url + " download  is cancel", new Object[i3]);
                                    break;
                                } catch (Throwable th) {
                                    th = th;
                                    inputStream = content;
                                    randomAccessFile = randomAccessFile2;
                                    throw th;
                                }
                            }
                            randomAccessFile2.write(bArr, i3, i);
                            j += (long) i;
                            fileDownloadListener = fileDownloadRequest.f;
                            if (fileDownloadListener != null) {
                                try {
                                    DownloadItem downloadItem = fileDownloadRequest.c;
                                    str = "recv: ";
                                    str2 = " total: ";
                                    bArr2 = bArr;
                                    randomAccessFile = randomAccessFile2;
                                    str3 = " offset ";
                                    try {
                                        fileDownloadListener.downloadProgress(downloadItem, contentLength, j);
                                    } catch (Throwable th2) {
                                        th = th2;
                                        VolleyLog.e("callback downloadProgress  error " + th.getMessage(), new Object[0]);
                                    }
                                } catch (Throwable th3) {
                                    th = th3;
                                    bArr2 = bArr;
                                    str = "recv: ";
                                    str2 = " total: ";
                                    randomAccessFile = randomAccessFile2;
                                    str3 = " offset ";
                                }
                            } else {
                                bArr2 = bArr;
                                str = "recv: ";
                                str2 = " total: ";
                                randomAccessFile = randomAccessFile2;
                                str3 = " offset ";
                            }
                            try {
                                VolleyLog.d(str + j + str2 + contentLength + str3 + i, new Object[0]);
                                fileDownloadRequest = this;
                                bArr = bArr2;
                                randomAccessFile2 = randomAccessFile;
                                i2 = -1;
                                i3 = 0;
                            } catch (Throwable th4) {
                                th = th4;
                            }
                            th = th4;
                            inputStream = content;
                            try {
                                throw th;
                            } catch (Throwable th5) {
                                if (inputStream != null) {
                                    try {
                                        inputStream.close();
                                    } catch (Throwable unused) {
                                        VolleyLog.v("Error occured when calling consumingContent", new Object[0]);
                                    }
                                }
                                if (randomAccessFile == null) {
                                    throw th5;
                                }
                                randomAccessFile.close();
                                throw th5;
                            }
                        }
                        randomAccessFile = randomAccessFile2;
                        VolleyLog.d("recv: " + j + " total: " + contentLength + " offset " + i, new Object[0]);
                        if (content != null) {
                            try {
                                content.close();
                            } catch (Throwable unused2) {
                                VolleyLog.v("Error occured when calling consumingContent", new Object[0]);
                            }
                        }
                        randomAccessFile.close();
                        return new byte[0];
                    }
                    VolleyLog.d("Response doesn't present Content-Length!", new Object[0]);
                    bArr = new byte[8192];
                    while (true) {
                        i = content.read(bArr);
                        if (i == i2) {
                            break;
                            break;
                        }
                        if (isCanceled()) {
                            VolleyLog.v(fileDownloadRequest.c.url + " download  is cancel", new Object[i3]);
                            break;
                        }
                        randomAccessFile2.write(bArr, i3, i);
                        j += (long) i;
                        fileDownloadListener = fileDownloadRequest.f;
                        if (fileDownloadListener != null) {
                            DownloadItem downloadItem2 = fileDownloadRequest.c;
                            str = "recv: ";
                            str2 = " total: ";
                            bArr2 = bArr;
                            randomAccessFile = randomAccessFile2;
                            str3 = " offset ";
                            fileDownloadListener.downloadProgress(downloadItem2, contentLength, j);
                        } else {
                            bArr2 = bArr;
                            str = "recv: ";
                            str2 = " total: ";
                            randomAccessFile = randomAccessFile2;
                            str3 = " offset ";
                        }
                        VolleyLog.d(str + j + str2 + contentLength + str3 + i, new Object[0]);
                        fileDownloadRequest = this;
                        bArr = bArr2;
                        randomAccessFile2 = randomAccessFile;
                        i2 = -1;
                        i3 = 0;
                        th = th4;
                        inputStream = content;
                        throw th;
                    }
                    randomAccessFile = randomAccessFile2;
                    VolleyLog.d("recv: " + j + " total: " + contentLength + " offset " + i, new Object[0]);
                    if (content != null) {
                        content.close();
                    }
                    randomAccessFile.close();
                    return new byte[0];
                } catch (Throwable th6) {
                    th = th6;
                    randomAccessFile = randomAccessFile2;
                }
                if (zIsSupportRange) {
                    randomAccessFile2.seek(length);
                    j = length;
                } else {
                    randomAccessFile2.setLength(0L);
                }
                content = httpResponse.getContent();
            } catch (Throwable th7) {
                th = th7;
            }
            randomAccessFile2 = new RandomAccessFile(fileDownloadRequest.b, "rw");
        } catch (Throwable th8) {
            th = th8;
            randomAccessFile = null;
        }
        length = 0;
        inputStream = null;
    }

    /* JADX WARN: Code duplicated, block: B:108:0x0119 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:110:0x0109 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:116:? A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:11:0x0039  */
    /* JADX WARN: Code duplicated, block: B:12:0x0047  */
    /* JADX WARN: Code duplicated, block: B:9:0x0031  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v10, types: [long] */
    /* JADX WARN: Type inference failed for: r0v16 */
    /* JADX WARN: Type inference failed for: r0v21 */
    /* JADX WARN: Type inference failed for: r0v22, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r0v29, types: [java.io.InputStream, java.util.zip.GZIPInputStream] */
    /* JADX WARN: Type inference failed for: r0v39 */
    /* JADX WARN: Type inference failed for: r0v40 */
    /* JADX WARN: Type inference failed for: r0v5 */
    /* JADX WARN: Type inference failed for: r1v10 */
    /* JADX WARN: Type inference failed for: r1v14 */
    /* JADX WARN: Type inference failed for: r1v18 */
    /* JADX WARN: Type inference failed for: r1v19 */
    /* JADX WARN: Type inference failed for: r1v20 */
    /* JADX WARN: Type inference failed for: r1v21 */
    /* JADX WARN: Type inference failed for: r1v3 */
    /* JADX WARN: Type inference failed for: r1v7 */
    /* JADX WARN: Type inference failed for: r1v9, types: [java.io.FileOutputStream] */
    /* JADX WARN: Type inference failed for: r5v0 */
    /* JADX WARN: Type inference failed for: r5v1, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r5v2 */
    @Override // com.czhj.volley.Request
    protected Response<DownloadItem> parseNetworkResponse(NetworkResponse networkResponse) throws Throwable {
        boolean zContainsKey;
        ?? gZIPInputStream;
        ?? r1;
        ?? r2;
        FileOutputStream fileOutputStream;
        this.c.networkMs = networkResponse.networkTimeMs;
        if (isCanceled()) {
            return Response.error(new VolleyError("Request was Canceled!"));
        }
        Map<String, String> mapConvertHeaders = FileDownloadNetwork.convertHeaders(networkResponse.allHeaders);
        if (mapConvertHeaders.containsKey(c.h)) {
            String str = "chunked";
            if (mapConvertHeaders.get(c.h).equalsIgnoreCase("chunked")) {
                gZIPInputStream = this.b.length();
                r1 = str;
            } else {
                zContainsKey = mapConvertHeaders.containsKey("content-length");
                if (zContainsKey) {
                    gZIPInputStream = Long.parseLong(mapConvertHeaders.get("content-length")) + this.d;
                    r1 = zContainsKey;
                } else {
                    gZIPInputStream = 0;
                    r1 = zContainsKey;
                }
            }
        } else {
            zContainsKey = mapConvertHeaders.containsKey("content-length");
            if (zContainsKey) {
                gZIPInputStream = Long.parseLong(mapConvertHeaders.get("content-length")) + this.d;
                r1 = zContainsKey;
            } else {
                gZIPInputStream = 0;
                r1 = zContainsKey;
            }
        }
        this.c.size = gZIPInputStream;
        ?? r5 = 0;
        if (!this.b.canRead() || this.b.length() <= 0 || (this.b.length() != gZIPInputStream && gZIPInputStream != 0)) {
            return (this.f2330a.canRead() && this.f2330a.length() == gZIPInputStream) ? Response.success(this.c, null) : Response.error(new VolleyError("Download temporary file was invalid!" + this.b.getAbsolutePath()));
        }
        if (!HttpHeaderParser.isGzipContent(mapConvertHeaders)) {
            return this.b.renameTo(this.f2330a) ? Response.success(this.c, null) : Response.error(new VolleyError("Can't rename the download temporary file!"));
        }
        boolean z = false;
        try {
            try {
                gZIPInputStream = new GZIPInputStream(new FileInputStream(this.b));
                try {
                    fileOutputStream = new FileOutputStream(this.f2330a);
                    try {
                        byte[] bArr = new byte[4096];
                        while (true) {
                            int i = gZIPInputStream.read(bArr, 0, 4096);
                            if (i != -1) {
                                fileOutputStream.write(bArr, 0, i);
                            } else {
                                try {
                                    break;
                                } catch (IOException e) {
                                    VolleyLog.e(e.getMessage(), new Object[0]);
                                }
                            }
                        }
                        gZIPInputStream.close();
                        try {
                            fileOutputStream.close();
                        } catch (IOException e2) {
                            VolleyLog.e(e2.getMessage(), new Object[0]);
                        }
                        z = true;
                    } catch (IOException e3) {
                        e = e3;
                        VolleyLog.e(e.getMessage(), new Object[0]);
                        if (gZIPInputStream != 0) {
                            try {
                                gZIPInputStream.close();
                            } catch (IOException e4) {
                                VolleyLog.e(e4.getMessage(), new Object[0]);
                            }
                        }
                        if (fileOutputStream != null) {
                            try {
                                fileOutputStream.close();
                            } catch (IOException e5) {
                                VolleyLog.e(e5.getMessage(), new Object[0]);
                            }
                        }
                    }
                } catch (IOException e6) {
                    e = e6;
                    fileOutputStream = null;
                } catch (Throwable th) {
                    th = th;
                    r1 = 0;
                    r5 = gZIPInputStream;
                    r2 = r1;
                    if (r5 != 0) {
                        try {
                            r5.close();
                        } catch (IOException e7) {
                            VolleyLog.e(e7.getMessage(), new Object[0]);
                        }
                    }
                    if (r2 != 0) {
                        throw th;
                    }
                    try {
                        r2.close();
                        throw th;
                    } catch (IOException e8) {
                        VolleyLog.e(e8.getMessage(), new Object[0]);
                        throw th;
                    }
                }
            } catch (Throwable th2) {
                th = th2;
            }
        } catch (IOException e9) {
            e = e9;
            gZIPInputStream = 0;
            fileOutputStream = null;
        } catch (Throwable th3) {
            th = th3;
            r2 = 0;
            if (r5 != 0) {
                r5.close();
            }
            if (r2 != 0) {
                throw th;
            }
            r2.close();
            throw th;
        }
        this.b.delete();
        return z ? Response.success(this.c, null) : Response.error(new VolleyError("error gzip unzip the download temporary file!"));
    }

    public void setListener(FileDownloadListener fileDownloadListener) {
        this.f = fileDownloadListener;
    }
}
