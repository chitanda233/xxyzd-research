package cn.thinkingdata.core.network;

import cn.thinkingdata.core.exception.TDHttpException;
import com.baidu.mobads.sdk.internal.cb;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.ProtocolException;
import java.net.SocketTimeoutException;
import java.net.URL;
import java.util.Map;
import java.util.zip.GZIPOutputStream;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLSocketFactory;

/* JADX INFO: loaded from: classes.dex */
public class RealCall implements Call {
    private static final String TAG = "ThinkingAnalytics.RealCall";
    final TEHttpClient client;
    final Request originalRequest;

    class AsyncCall implements Runnable {
        private final TEHttpCallback responseCallback;

        public AsyncCall(TEHttpCallback tEHttpCallback) {
            this.responseCallback = tEHttpCallback;
        }

        @Override // java.lang.Runnable
        public void run() throws Throwable {
            try {
                this.responseCallback.onResponse(RealCall.this.performRequest());
            } catch (TDHttpException e) {
                this.responseCallback.onError(e.errorCode, e.getMessage());
            }
        }
    }

    private RealCall(TEHttpClient tEHttpClient, Request request) {
        this.client = tEHttpClient;
        this.originalRequest = request;
    }

    private String encodeData(String str) throws IOException {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream(str.getBytes().length);
        GZIPOutputStream gZIPOutputStream = new GZIPOutputStream(byteArrayOutputStream);
        gZIPOutputStream.write(str.getBytes());
        gZIPOutputStream.close();
        byteArrayOutputStream.toByteArray();
        byteArrayOutputStream.close();
        return "";
    }

    private HttpURLConnection getHttpURLConnection() throws ProtocolException {
        HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(this.originalRequest.url).openConnection();
        SSLSocketFactory sSLSocketFactory = this.client.sslSocketFactory;
        if (sSLSocketFactory != null && (httpURLConnection instanceof HttpsURLConnection)) {
            ((HttpsURLConnection) httpURLConnection).setSSLSocketFactory(sSLSocketFactory);
        }
        httpURLConnection.setConnectTimeout(this.client.connectTimeout);
        httpURLConnection.setReadTimeout(this.client.readTimeout);
        if ("POST".equals(this.originalRequest.method)) {
            httpURLConnection.setDoOutput(true);
        }
        httpURLConnection.setRequestMethod(this.originalRequest.method);
        return httpURLConnection;
    }

    static RealCall newRealCall(TEHttpClient tEHttpClient, Request request) {
        return new RealCall(tEHttpClient, request);
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:104:0x0155  */
    /* JADX WARN: Code duplicated, block: B:114:0x0146 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:116:0x0141 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:121:0x0150 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:123:0x014b A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:140:? A[SYNTHETIC] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r1v1 */
    /* JADX WARN: Type inference failed for: r1v12, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v13 */
    /* JADX WARN: Type inference failed for: r1v14 */
    /* JADX WARN: Type inference failed for: r1v17 */
    /* JADX WARN: Type inference failed for: r1v18 */
    /* JADX WARN: Type inference failed for: r1v19 */
    /* JADX WARN: Type inference failed for: r1v4, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v5 */
    /* JADX WARN: Type inference failed for: r1v8 */
    /* JADX WARN: Type inference failed for: r2v0 */
    /* JADX WARN: Type inference failed for: r2v1, types: [java.io.BufferedOutputStream] */
    /* JADX WARN: Type inference failed for: r2v2 */
    /* JADX WARN: Type inference failed for: r2v5 */
    /* JADX WARN: Type inference failed for: r2v6 */
    public TDNetResponse performRequest() throws Throwable {
        HttpURLConnection httpURLConnection;
        OutputStream outputStream;
        HttpURLConnection httpURLConnection2;
        BufferedReader bufferedReader;
        ?? r1;
        BufferedOutputStream bufferedOutputStream;
        BufferedOutputStream bufferedOutputStream2;
        Object obj;
        BufferedOutputStream bufferedOutputStream3;
        BufferedOutputStream bufferedOutputStream4;
        ?? inputStream = "Service unavailable with response code: ";
        ?? r2 = 0;
        r2 = 0;
        r2 = 0;
        try {
            try {
                httpURLConnection = getHttpURLConnection();
                try {
                    httpURLConnection.setUseCaches(this.originalRequest.useCache);
                    setHeaders(httpURLConnection);
                    if ("POST".equals(this.originalRequest.method)) {
                        String strEncodeData = this.originalRequest.body;
                        if (this.originalRequest.gzip) {
                            strEncodeData = encodeData(strEncodeData);
                        }
                        httpURLConnection.setFixedLengthStreamingMode(strEncodeData.getBytes("UTF-8").length);
                        outputStream = httpURLConnection.getOutputStream();
                        try {
                            BufferedOutputStream bufferedOutputStream5 = new BufferedOutputStream(outputStream);
                            try {
                                bufferedOutputStream5.write(strEncodeData.getBytes("UTF-8"));
                                bufferedOutputStream5.flush();
                                bufferedOutputStream5.close();
                                try {
                                    outputStream.close();
                                } catch (SocketTimeoutException e) {
                                    e = e;
                                    bufferedOutputStream4 = null;
                                    throw new TDHttpException(TDHttpException.ERROR_CONNECT_TIME_OUT, e.getMessage());
                                } catch (Exception e2) {
                                    e = e2;
                                    bufferedOutputStream3 = null;
                                    throw new TDHttpException(TDHttpException.ERROR_EXCEPTION, e.getMessage());
                                } catch (Throwable th) {
                                    th = th;
                                    inputStream = 0;
                                    obj = null;
                                    httpURLConnection2 = httpURLConnection;
                                    bufferedReader = null;
                                    r2 = obj;
                                    if (r2 != 0) {
                                        try {
                                            r2.close();
                                        } catch (IOException unused) {
                                        }
                                    }
                                    if (outputStream != null) {
                                        try {
                                            outputStream.close();
                                        } catch (IOException unused2) {
                                        }
                                    }
                                    if (inputStream != 0) {
                                        try {
                                            inputStream.close();
                                        } catch (IOException unused3) {
                                        }
                                    }
                                    if (bufferedReader != null) {
                                        try {
                                            bufferedReader.close();
                                        } catch (IOException unused4) {
                                        }
                                    }
                                    if (httpURLConnection2 != null) {
                                        throw th;
                                    }
                                    httpURLConnection2.disconnect();
                                    throw th;
                                }
                            } catch (SocketTimeoutException e3) {
                                e = e3;
                                bufferedOutputStream4 = bufferedOutputStream5;
                            } catch (Exception e4) {
                                e = e4;
                                bufferedOutputStream3 = bufferedOutputStream5;
                            } catch (Throwable th2) {
                                th = th2;
                                inputStream = 0;
                                obj = bufferedOutputStream5;
                            }
                        } catch (SocketTimeoutException e5) {
                            e = e5;
                            throw new TDHttpException(TDHttpException.ERROR_CONNECT_TIME_OUT, e.getMessage());
                        } catch (Exception e6) {
                            e = e6;
                            throw new TDHttpException(TDHttpException.ERROR_EXCEPTION, e.getMessage());
                        } catch (Throwable th3) {
                            th = th3;
                            inputStream = 0;
                            httpURLConnection2 = httpURLConnection;
                            bufferedReader = null;
                            if (r2 != 0) {
                                r2.close();
                            }
                            if (outputStream != null) {
                                outputStream.close();
                            }
                            if (inputStream != 0) {
                                inputStream.close();
                            }
                            if (bufferedReader != null) {
                                bufferedReader.close();
                            }
                            if (httpURLConnection2 != null) {
                                throw th;
                            }
                            httpURLConnection2.disconnect();
                            throw th;
                        }
                    }
                    try {
                        int responseCode = httpURLConnection.getResponseCode();
                        if (responseCode != 200) {
                            throw new TDHttpException(responseCode, "Service unavailable with response code: " + responseCode);
                        }
                        TDNetResponse tDNetResponse = new TDNetResponse();
                        tDNetResponse.responseHeaders = httpURLConnection.getHeaderFields();
                        inputStream = httpURLConnection.getInputStream();
                        try {
                            BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(inputStream));
                            try {
                                StringBuilder sb = new StringBuilder();
                                while (true) {
                                    String line = bufferedReader2.readLine();
                                    if (line == null) {
                                        break;
                                    }
                                    sb.append(line);
                                }
                                inputStream.close();
                                bufferedReader2.close();
                                tDNetResponse.statusCode = 200;
                                tDNetResponse.msg = cb.o;
                                tDNetResponse.responseData = sb.toString();
                                if (inputStream != 0) {
                                    try {
                                        inputStream.close();
                                    } catch (IOException unused5) {
                                    }
                                }
                                try {
                                    bufferedReader2.close();
                                } catch (IOException unused6) {
                                }
                                if (httpURLConnection != null) {
                                    httpURLConnection.disconnect();
                                }
                                return tDNetResponse;
                            } catch (SocketTimeoutException e7) {
                                e = e7;
                                throw new TDHttpException(TDHttpException.ERROR_CONNECT_TIME_OUT, e.getMessage());
                            } catch (Exception e8) {
                                e = e8;
                                throw new TDHttpException(TDHttpException.ERROR_EXCEPTION, e.getMessage());
                            } catch (Throwable th4) {
                                th = th4;
                                httpURLConnection2 = httpURLConnection;
                                bufferedReader = bufferedReader2;
                                outputStream = null;
                                if (r2 != 0) {
                                    r2.close();
                                }
                                if (outputStream != null) {
                                    outputStream.close();
                                }
                                if (inputStream != 0) {
                                    inputStream.close();
                                }
                                if (bufferedReader != null) {
                                    bufferedReader.close();
                                }
                                if (httpURLConnection2 != null) {
                                    throw th;
                                }
                                httpURLConnection2.disconnect();
                                throw th;
                            }
                        } catch (SocketTimeoutException e9) {
                            e = e9;
                            bufferedOutputStream2 = null;
                            bufferedOutputStream4 = bufferedOutputStream2;
                            throw new TDHttpException(TDHttpException.ERROR_CONNECT_TIME_OUT, e.getMessage());
                        } catch (Exception e10) {
                            e = e10;
                            bufferedOutputStream = null;
                            bufferedOutputStream3 = bufferedOutputStream;
                            throw new TDHttpException(TDHttpException.ERROR_EXCEPTION, e.getMessage());
                        } catch (Throwable th5) {
                            th = th5;
                            outputStream = null;
                            r1 = inputStream;
                            obj = outputStream;
                            inputStream = r1;
                            httpURLConnection2 = httpURLConnection;
                            bufferedReader = null;
                            r2 = obj;
                            if (r2 != 0) {
                                r2.close();
                            }
                            if (outputStream != null) {
                                outputStream.close();
                            }
                            if (inputStream != 0) {
                                inputStream.close();
                            }
                            if (bufferedReader != null) {
                                bufferedReader.close();
                            }
                            if (httpURLConnection2 != null) {
                                throw th;
                            }
                            httpURLConnection2.disconnect();
                            throw th;
                        }
                    } catch (SocketTimeoutException e11) {
                        e = e11;
                        bufferedOutputStream2 = null;
                    } catch (Exception e12) {
                        e = e12;
                        bufferedOutputStream = null;
                    } catch (Throwable th6) {
                        th = th6;
                        r1 = 0;
                        outputStream = null;
                    }
                } catch (SocketTimeoutException e13) {
                    e = e13;
                } catch (Exception e14) {
                    e = e14;
                } catch (Throwable th7) {
                    th = th7;
                    outputStream = null;
                }
            } catch (Throwable th8) {
                th = th8;
            }
        } catch (SocketTimeoutException e15) {
            e = e15;
            httpURLConnection = null;
        } catch (Exception e16) {
            e = e16;
            httpURLConnection = null;
        } catch (Throwable th9) {
            th = th9;
            httpURLConnection = null;
            outputStream = null;
        }
    }

    private void setHeaders(HttpURLConnection httpURLConnection) {
        Map<String, String> map = this.originalRequest.headers;
        if (map.size() > 0) {
            for (String str : map.keySet()) {
                httpURLConnection.setRequestProperty(str, map.get(str));
            }
        }
    }

    @Override // cn.thinkingdata.core.network.Call
    public void enqueue(TEHttpCallback tEHttpCallback) {
        tEHttpCallback.callBackOnMainThread = this.originalRequest.callBackOnMainThread;
        this.client.dispatcher.execute(new AsyncCall(tEHttpCallback));
    }

    @Override // cn.thinkingdata.core.network.Call
    public TDNetResponse execute() {
        try {
            return performRequest();
        } catch (TDHttpException e) {
            TDNetResponse tDNetResponse = new TDNetResponse();
            tDNetResponse.statusCode = e.errorCode;
            tDNetResponse.msg = e.getMessage();
            return tDNetResponse;
        }
    }
}
