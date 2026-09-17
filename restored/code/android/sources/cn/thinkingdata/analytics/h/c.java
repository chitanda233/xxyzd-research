package cn.thinkingdata.analytics.h;

import android.text.TextUtils;
import androidx.browser.trusted.sharing.ShareTarget;
import cn.thinkingdata.analytics.TDConfig;
import cn.thinkingdata.core.utils.Base64Coder;
import cn.thinkingdata.core.utils.TDLog;
import com.baidu.mobads.sdk.internal.an;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.security.InvalidParameterException;
import java.util.List;
import java.util.Map;
import java.util.zip.GZIPOutputStream;
import javax.net.ssl.HostnameVerifier;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLSession;

/* JADX INFO: loaded from: classes.dex */
public class c implements h {

    class a implements HostnameVerifier {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f116a;

        a(c cVar, String str) {
            this.f116a = str;
        }

        @Override // javax.net.ssl.HostnameVerifier
        public boolean verify(String str, SSLSession sSLSession) {
            return HttpsURLConnection.getDefaultHostnameVerifier().verify(this.f116a, sSLSession);
        }
    }

    private String a(TDConfig tDConfig) {
        String serverUrl = tDConfig.getServerUrl();
        if (!tDConfig.isNormal()) {
            serverUrl = tDConfig.getDebugUrl();
        }
        if (!tDConfig.mEnableDNS) {
            return serverUrl;
        }
        String strB = tDConfig.mDnsServiceManager.b();
        String strA = tDConfig.mDnsServiceManager.a();
        if (!TextUtils.isEmpty(strB)) {
            return serverUrl.replace(strA, strB);
        }
        tDConfig.mDnsServiceManager.a((List<TDConfig.TDDNSService>) null);
        return serverUrl;
    }

    private String a(String str) throws IOException {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream(str.getBytes().length);
        GZIPOutputStream gZIPOutputStream = new GZIPOutputStream(byteArrayOutputStream);
        gZIPOutputStream.write(str.getBytes());
        gZIPOutputStream.close();
        byte[] byteArray = byteArrayOutputStream.toByteArray();
        byteArrayOutputStream.close();
        return new String(Base64Coder.encode(byteArray));
    }

    @Override // cn.thinkingdata.analytics.h.h
    public String a(TDConfig tDConfig, String str, Map<String, String> map) throws Throwable {
        HttpURLConnection httpURLConnection;
        OutputStream outputStream;
        InputStream inputStream;
        BufferedReader bufferedReader;
        String strA;
        BufferedOutputStream bufferedOutputStream = null;
        try {
            boolean z = !tDConfig.isNormal();
            httpURLConnection = (HttpURLConnection) new URL(a(tDConfig)).openConnection();
            try {
                if (tDConfig.getSSLSocketFactory() != null) {
                    try {
                        if (httpURLConnection instanceof HttpsURLConnection) {
                            ((HttpsURLConnection) httpURLConnection).setSSLSocketFactory(tDConfig.getSSLSocketFactory());
                        }
                    } catch (Throwable th) {
                        th = th;
                        inputStream = null;
                        bufferedReader = null;
                        outputStream = null;
                    }
                }
                String strA2 = tDConfig.mDnsServiceManager.a();
                if (tDConfig.mEnableDNS && strA2 != null && (httpURLConnection instanceof HttpsURLConnection)) {
                    ((HttpsURLConnection) httpURLConnection).setHostnameVerifier(new a(this, strA2));
                }
                if (str == null) {
                    throw new InvalidParameterException("Content is null");
                }
                httpURLConnection.setConnectTimeout(15000);
                httpURLConnection.setReadTimeout(20000);
                httpURLConnection.setDoOutput(true);
                httpURLConnection.setRequestMethod("POST");
                if (z) {
                    httpURLConnection.setRequestProperty("Content-Type", ShareTarget.ENCODING_TYPE_URL_ENCODED);
                    httpURLConnection.setUseCaches(false);
                    httpURLConnection.setRequestProperty("charset", "utf-8");
                    strA = str;
                } else {
                    httpURLConnection.setRequestProperty("Content-Type", an.e);
                    try {
                        strA = a(str);
                    } catch (IOException e) {
                        throw new InvalidParameterException(e.getMessage());
                    }
                }
                if (map != null) {
                    for (Map.Entry<String, String> entry : map.entrySet()) {
                        httpURLConnection.setRequestProperty(entry.getKey(), entry.getValue());
                    }
                }
                httpURLConnection.setFixedLengthStreamingMode(strA.getBytes("UTF-8").length);
                outputStream = httpURLConnection.getOutputStream();
                try {
                    BufferedOutputStream bufferedOutputStream2 = new BufferedOutputStream(outputStream);
                    try {
                        bufferedOutputStream2.write(strA.getBytes("UTF-8"));
                        bufferedOutputStream2.flush();
                        bufferedOutputStream2.close();
                        try {
                            outputStream.close();
                            try {
                                int responseCode = httpURLConnection.getResponseCode();
                                TDLog.d("ThinkingAnalytics.HttpService", "ret_code:" + responseCode);
                                if (responseCode != 200) {
                                    if (!tDConfig.mEnableDNS) {
                                        throw new h.a("Service unavailable with response code: " + responseCode);
                                    }
                                    tDConfig.mEnableDNS = false;
                                    String strA3 = a(tDConfig, str, map);
                                    if (httpURLConnection != null) {
                                        httpURLConnection.disconnect();
                                    }
                                    return strA3;
                                }
                                InputStream inputStream2 = httpURLConnection.getInputStream();
                                try {
                                    BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(inputStream2));
                                    try {
                                        StringBuilder sb = new StringBuilder();
                                        while (true) {
                                            String line = bufferedReader2.readLine();
                                            if (line == null) {
                                                break;
                                            }
                                            sb.append(line);
                                        }
                                        inputStream2.close();
                                        bufferedReader2.close();
                                        String string = sb.toString();
                                        if (inputStream2 != null) {
                                            try {
                                                inputStream2.close();
                                            } catch (IOException unused) {
                                            }
                                        }
                                        try {
                                            bufferedReader2.close();
                                        } catch (IOException unused2) {
                                        }
                                        if (httpURLConnection != null) {
                                            httpURLConnection.disconnect();
                                        }
                                        return string;
                                    } catch (Throwable th2) {
                                        outputStream = null;
                                        inputStream = inputStream2;
                                        th = th2;
                                        bufferedReader = bufferedReader2;
                                    }
                                } catch (Throwable th3) {
                                    outputStream = null;
                                    bufferedOutputStream2 = null;
                                    inputStream = inputStream2;
                                    th = th3;
                                    bufferedReader = null;
                                    bufferedOutputStream = bufferedOutputStream2;
                                }
                            } catch (Throwable th4) {
                                th = th4;
                                inputStream = null;
                                outputStream = null;
                                bufferedOutputStream2 = null;
                            }
                        } catch (Throwable th5) {
                            th = th5;
                            inputStream = null;
                            bufferedOutputStream2 = null;
                        }
                    } catch (Throwable th6) {
                        th = th6;
                        inputStream = null;
                    }
                } catch (Throwable th7) {
                    th = th7;
                    inputStream = null;
                    bufferedReader = null;
                }
            } catch (Throwable th8) {
                th = th8;
                outputStream = null;
            }
        } catch (Throwable th9) {
            th = th9;
            httpURLConnection = null;
            outputStream = null;
        }
        inputStream = null;
        bufferedReader = null;
        if (bufferedOutputStream != null) {
            try {
                bufferedOutputStream.close();
            } catch (IOException unused3) {
            }
        }
        if (outputStream != null) {
            try {
                outputStream.close();
            } catch (IOException unused4) {
            }
        }
        if (inputStream != null) {
            try {
                inputStream.close();
            } catch (IOException unused5) {
            }
        }
        if (bufferedReader != null) {
            try {
                bufferedReader.close();
            } catch (IOException unused6) {
            }
        }
        if (httpURLConnection == null) {
            throw th;
        }
        httpURLConnection.disconnect();
        throw th;
    }
}
