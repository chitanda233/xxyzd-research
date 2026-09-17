package com.chuanglan.shanyan_sdk;

import android.content.Context;
import androidx.browser.trusted.sharing.ShareTarget;
import com.baidu.mobads.sdk.internal.an;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.Map;
import javax.net.ssl.HttpsURLConnection;
import org.json.JSONObject;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.o, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
abstract class AbstractC0609o {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f1991a;
    private Map b;
    private Context c;

    AbstractC0609o(String str, Context context) {
        this.b = null;
        this.f1991a = str;
        this.c = context;
        this.b = new HashMap();
    }

    private void a(HttpURLConnection httpURLConnection) {
        for (Map.Entry entry : this.b.entrySet()) {
            httpURLConnection.setRequestProperty((String) entry.getKey(), (String) entry.getValue());
        }
    }

    private void a(HttpsURLConnection httpsURLConnection) {
        for (Map.Entry entry : this.b.entrySet()) {
            httpsURLConnection.setRequestProperty((String) entry.getKey(), (String) entry.getValue());
        }
    }

    private byte[] b(Map map) {
        return map == null ? new byte[0] : AbstractC0596b.a(new JSONObject(map).toString());
    }

    /* JADX WARN: Code duplicated, block: B:101:0x0149 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:109:0x0165 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:111:0x016f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:115:0x0156 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:119:0x013f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:121:0x017c A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:136:? A[RETURN, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:139:? A[SYNTHETIC] */
    private void b(V v, Map map, AbstractC0607m abstractC0607m, Boolean bool, String str, int i, int i2) throws Throwable {
        OutputStream outputStream;
        OutputStream outputStream2;
        OutputStream outputStream3;
        HttpsURLConnection httpsURLConnection = null;
        outputStream = null;
        outputStream = null;
        outputStream = null;
        OutputStream outputStream4 = null;
        httpsURLConnection = null;
        try {
            HttpsURLConnection httpsURLConnection2 = (HttpsURLConnection) new URL(this.f1991a).openConnection();
            try {
                httpsURLConnection2.setConnectTimeout(i);
                httpsURLConnection2.setReadTimeout(i2);
                a(httpsURLConnection2);
                if (v == V.GET) {
                    httpsURLConnection2.setRequestMethod("GET");
                    outputStream3 = null;
                } else {
                    if (bool.booleanValue()) {
                        httpsURLConnection2.setRequestMethod("POST");
                        byte[] bArrB = b(map);
                        String strA = AbstractC0598d.a();
                        String strSubstring = strA.substring(0, 16);
                        String strSubstring2 = strA.substring(16);
                        if (str != null && str.length() >= 2) {
                            String strSubstring3 = str.substring(1);
                            String strSubstring4 = str.substring(0, 1);
                            String strA2 = m0.a(strA.getBytes(), m0.a(strSubstring3));
                            byte[] bArrA = AbstractC0596b.a(bArrB, strSubstring, strSubstring2);
                            httpsURLConnection2.setRequestProperty("Content-Type", an.d);
                            httpsURLConnection2.setRequestProperty("Content-Encoding", "gzip");
                            httpsURLConnection2.setRequestProperty("Data-Key", strSubstring4 + strA2);
                            httpsURLConnection2.setRequestProperty("sdkVersion", "2.3.7.5");
                            if (AbstractC0600f.a(strA2)) {
                                abstractC0607m.a(EnumC0611q.REQUEST_FAILED_CODE.e(), "datekey is empty");
                                try {
                                    httpsURLConnection2.disconnect();
                                    return;
                                } catch (Exception e) {
                                    e.printStackTrace();
                                    return;
                                }
                            }
                            outputStream = httpsURLConnection2.getOutputStream();
                            try {
                                outputStream.write(bArrA);
                                outputStream4 = outputStream;
                                outputStream3 = null;
                            } catch (Exception e2) {
                                e = e2;
                                outputStream2 = null;
                                httpsURLConnection = httpsURLConnection2;
                                try {
                                    abstractC0607m.a(e.toString(), e.getClass().getSimpleName());
                                    if (httpsURLConnection != null) {
                                        try {
                                            httpsURLConnection.disconnect();
                                        } catch (Exception e3) {
                                            e3.printStackTrace();
                                        }
                                    }
                                    if (outputStream != null) {
                                        try {
                                            outputStream.flush();
                                            outputStream.close();
                                        } catch (Exception e4) {
                                            e4.printStackTrace();
                                        }
                                    }
                                    if (outputStream2 != null) {
                                        try {
                                            outputStream2.flush();
                                            outputStream2.close();
                                            return;
                                        } catch (Exception e5) {
                                            e5.printStackTrace();
                                            return;
                                        }
                                    }
                                    return;
                                } catch (Throwable th) {
                                    th = th;
                                    if (httpsURLConnection != null) {
                                        try {
                                            httpsURLConnection.disconnect();
                                        } catch (Exception e6) {
                                            e6.printStackTrace();
                                        }
                                    }
                                    if (outputStream != null) {
                                        try {
                                            outputStream.flush();
                                            outputStream.close();
                                        } catch (Exception e7) {
                                            e7.printStackTrace();
                                        }
                                    }
                                    if (outputStream2 != null) {
                                        try {
                                            outputStream2.flush();
                                            outputStream2.close();
                                            throw th;
                                        } catch (Exception e8) {
                                            e8.printStackTrace();
                                            throw th;
                                        }
                                    }
                                    throw th;
                                }
                            } catch (Throwable th2) {
                                th = th2;
                                outputStream2 = null;
                                httpsURLConnection = httpsURLConnection2;
                                if (httpsURLConnection != null) {
                                    httpsURLConnection.disconnect();
                                }
                                if (outputStream != null) {
                                    outputStream.flush();
                                    outputStream.close();
                                }
                                if (outputStream2 != null) {
                                    outputStream2.flush();
                                    outputStream2.close();
                                    throw th;
                                }
                                throw th;
                            }
                        }
                        abstractC0607m.a(EnumC0611q.REQUEST_FAILED_CODE.e(), "pubKey is invalid");
                        try {
                            httpsURLConnection2.disconnect();
                            return;
                        } catch (Exception e9) {
                            e9.printStackTrace();
                            return;
                        }
                    }
                    httpsURLConnection2.setRequestMethod("POST");
                    byte[] bArrA2 = a(map);
                    httpsURLConnection2.setRequestProperty("Content-Type", ShareTarget.ENCODING_TYPE_URL_ENCODED);
                    httpsURLConnection2.setRequestProperty(com.sigmob.sdk.downloader.core.c.e, Integer.toString(bArrA2.length));
                    outputStream3 = httpsURLConnection2.getOutputStream();
                    try {
                        outputStream3.write(bArrA2);
                    } catch (Exception e10) {
                        e = e10;
                        outputStream2 = outputStream3;
                        outputStream = outputStream4;
                        httpsURLConnection = httpsURLConnection2;
                        abstractC0607m.a(e.toString(), e.getClass().getSimpleName());
                        if (httpsURLConnection != null) {
                            httpsURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.flush();
                            outputStream.close();
                        }
                        if (outputStream2 != null) {
                            outputStream2.flush();
                            outputStream2.close();
                            return;
                        }
                        return;
                    } catch (Throwable th3) {
                        th = th3;
                        outputStream2 = outputStream3;
                        outputStream = outputStream4;
                        httpsURLConnection = httpsURLConnection2;
                        if (httpsURLConnection != null) {
                            httpsURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.flush();
                            outputStream.close();
                        }
                        if (outputStream2 != null) {
                            outputStream2.flush();
                            outputStream2.close();
                            throw th;
                        }
                        throw th;
                    }
                }
                abstractC0607m.a(httpsURLConnection2);
                try {
                    httpsURLConnection2.disconnect();
                } catch (Exception e11) {
                    e11.printStackTrace();
                }
                if (outputStream4 != null) {
                    try {
                        outputStream4.flush();
                        outputStream4.close();
                    } catch (Exception e12) {
                        e12.printStackTrace();
                    }
                }
                if (outputStream3 != null) {
                    try {
                        outputStream3.flush();
                        outputStream3.close();
                    } catch (Exception e13) {
                        e13.printStackTrace();
                    }
                }
            } catch (Exception e14) {
                e = e14;
                outputStream = null;
                outputStream2 = null;
            } catch (Throwable th4) {
                th = th4;
                outputStream = null;
                outputStream2 = null;
            }
        } catch (Exception e15) {
            e = e15;
            outputStream = null;
            outputStream2 = null;
        } catch (Throwable th5) {
            th = th5;
            outputStream = null;
            outputStream2 = null;
        }
    }

    private byte[] a(Map map) {
        String string;
        if (map == null) {
            return new byte[0];
        }
        StringBuilder sb = new StringBuilder();
        for (Map.Entry entry : map.entrySet()) {
            sb.append(URLEncoder.encode((String) entry.getKey(), "utf-8"));
            sb.append("=");
            sb.append(URLEncoder.encode(String.valueOf(entry.getValue()), "utf-8"));
            sb.append(com.alipay.sdk.m.w.a.p);
        }
        if (sb.length() > 0) {
            string = sb.substring(0, sb.length() - 1);
        } else {
            string = sb.toString();
        }
        return string.getBytes("UTF-8");
    }

    void a(V v, Map map, AbstractC0607m abstractC0607m, Boolean bool, String str) throws Throwable {
        int iMax;
        int i;
        int iIndexOf;
        int i2;
        int iA = p0.a(this.c, "cl_jm_e6", 6);
        if (bool.booleanValue()) {
            iMax = 5000;
            i = 25000;
        } else {
            iMax = Math.max(Math.round(((iA * 1000) - AbstractC0606l.z) / 2), 2000);
            i = iMax;
        }
        if (P.b && (iIndexOf = this.f1991a.indexOf("//")) != -1 && (i2 = iIndexOf + 4) < this.f1991a.length()) {
            Q.c("NetworkShanYanLogger", "test:", this.f1991a.substring(i2));
        }
        if (this.f1991a.startsWith("https")) {
            b(v, map, abstractC0607m, bool, str, iMax, i);
        } else {
            a(v, map, abstractC0607m, bool, str, iMax, i);
        }
    }

    /* JADX WARN: Code duplicated, block: B:101:0x0149 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:109:0x0165 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:111:0x016f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:115:0x0156 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:119:0x013f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:121:0x017c A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:136:? A[RETURN, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:139:? A[SYNTHETIC] */
    private void a(V v, Map map, AbstractC0607m abstractC0607m, Boolean bool, String str, int i, int i2) throws Throwable {
        OutputStream outputStream;
        OutputStream outputStream2;
        OutputStream outputStream3;
        HttpURLConnection httpURLConnection = null;
        outputStream = null;
        outputStream = null;
        outputStream = null;
        OutputStream outputStream4 = null;
        httpURLConnection = null;
        try {
            HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(this.f1991a).openConnection();
            try {
                httpURLConnection2.setConnectTimeout(i);
                httpURLConnection2.setReadTimeout(i2);
                a(httpURLConnection2);
                if (v == V.GET) {
                    httpURLConnection2.setRequestMethod("GET");
                    outputStream3 = null;
                } else {
                    if (bool.booleanValue()) {
                        httpURLConnection2.setRequestMethod("POST");
                        byte[] bArrB = b(map);
                        String strA = AbstractC0598d.a();
                        String strSubstring = strA.substring(0, 16);
                        String strSubstring2 = strA.substring(16);
                        if (str != null && str.length() >= 2) {
                            String strSubstring3 = str.substring(1);
                            String strSubstring4 = str.substring(0, 1);
                            String strA2 = m0.a(strA.getBytes(), m0.a(strSubstring3));
                            byte[] bArrA = AbstractC0596b.a(bArrB, strSubstring, strSubstring2);
                            httpURLConnection2.setRequestProperty("Content-Type", an.d);
                            httpURLConnection2.setRequestProperty("Content-Encoding", "gzip");
                            httpURLConnection2.setRequestProperty("Data-Key", strSubstring4 + strA2);
                            httpURLConnection2.setRequestProperty("sdkVersion", "2.3.7.5");
                            if (AbstractC0600f.a(strA2)) {
                                abstractC0607m.a(EnumC0611q.REQUEST_FAILED_CODE.e(), "datekey is empty");
                                try {
                                    httpURLConnection2.disconnect();
                                    return;
                                } catch (Exception e) {
                                    e.printStackTrace();
                                    return;
                                }
                            }
                            outputStream = httpURLConnection2.getOutputStream();
                            try {
                                outputStream.write(bArrA);
                                outputStream4 = outputStream;
                                outputStream3 = null;
                            } catch (Exception e2) {
                                e = e2;
                                outputStream2 = null;
                                httpURLConnection = httpURLConnection2;
                                try {
                                    abstractC0607m.a(e.toString(), e.getClass().getSimpleName());
                                    if (httpURLConnection != null) {
                                        try {
                                            httpURLConnection.disconnect();
                                        } catch (Exception e3) {
                                            e3.printStackTrace();
                                        }
                                    }
                                    if (outputStream != null) {
                                        try {
                                            outputStream.flush();
                                            outputStream.close();
                                        } catch (Exception e4) {
                                            e4.printStackTrace();
                                        }
                                    }
                                    if (outputStream2 != null) {
                                        try {
                                            outputStream2.flush();
                                            outputStream2.close();
                                            return;
                                        } catch (Exception e5) {
                                            e5.printStackTrace();
                                            return;
                                        }
                                    }
                                    return;
                                } catch (Throwable th) {
                                    th = th;
                                    if (httpURLConnection != null) {
                                        try {
                                            httpURLConnection.disconnect();
                                        } catch (Exception e6) {
                                            e6.printStackTrace();
                                        }
                                    }
                                    if (outputStream != null) {
                                        try {
                                            outputStream.flush();
                                            outputStream.close();
                                        } catch (Exception e7) {
                                            e7.printStackTrace();
                                        }
                                    }
                                    if (outputStream2 != null) {
                                        try {
                                            outputStream2.flush();
                                            outputStream2.close();
                                            throw th;
                                        } catch (Exception e8) {
                                            e8.printStackTrace();
                                            throw th;
                                        }
                                    }
                                    throw th;
                                }
                            } catch (Throwable th2) {
                                th = th2;
                                outputStream2 = null;
                                httpURLConnection = httpURLConnection2;
                                if (httpURLConnection != null) {
                                    httpURLConnection.disconnect();
                                }
                                if (outputStream != null) {
                                    outputStream.flush();
                                    outputStream.close();
                                }
                                if (outputStream2 != null) {
                                    outputStream2.flush();
                                    outputStream2.close();
                                    throw th;
                                }
                                throw th;
                            }
                        }
                        abstractC0607m.a(EnumC0611q.REQUEST_FAILED_CODE.e(), "pubKey is invalid");
                        try {
                            httpURLConnection2.disconnect();
                            return;
                        } catch (Exception e9) {
                            e9.printStackTrace();
                            return;
                        }
                    }
                    httpURLConnection2.setRequestMethod("POST");
                    byte[] bArrA2 = a(map);
                    httpURLConnection2.setRequestProperty("Content-Type", ShareTarget.ENCODING_TYPE_URL_ENCODED);
                    httpURLConnection2.setRequestProperty(com.sigmob.sdk.downloader.core.c.e, Integer.toString(bArrA2.length));
                    outputStream3 = httpURLConnection2.getOutputStream();
                    try {
                        outputStream3.write(bArrA2);
                    } catch (Exception e10) {
                        e = e10;
                        outputStream2 = outputStream3;
                        outputStream = outputStream4;
                        httpURLConnection = httpURLConnection2;
                        abstractC0607m.a(e.toString(), e.getClass().getSimpleName());
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.flush();
                            outputStream.close();
                        }
                        if (outputStream2 != null) {
                            outputStream2.flush();
                            outputStream2.close();
                            return;
                        }
                        return;
                    } catch (Throwable th3) {
                        th = th3;
                        outputStream2 = outputStream3;
                        outputStream = outputStream4;
                        httpURLConnection = httpURLConnection2;
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.flush();
                            outputStream.close();
                        }
                        if (outputStream2 != null) {
                            outputStream2.flush();
                            outputStream2.close();
                            throw th;
                        }
                        throw th;
                    }
                }
                abstractC0607m.a(httpURLConnection2);
                try {
                    httpURLConnection2.disconnect();
                } catch (Exception e11) {
                    e11.printStackTrace();
                }
                if (outputStream4 != null) {
                    try {
                        outputStream4.flush();
                        outputStream4.close();
                    } catch (Exception e12) {
                        e12.printStackTrace();
                    }
                }
                if (outputStream3 != null) {
                    try {
                        outputStream3.flush();
                        outputStream3.close();
                    } catch (Exception e13) {
                        e13.printStackTrace();
                    }
                }
            } catch (Exception e14) {
                e = e14;
                outputStream = null;
                outputStream2 = null;
            } catch (Throwable th4) {
                th = th4;
                outputStream = null;
                outputStream2 = null;
            }
        } catch (Exception e15) {
            e = e15;
            outputStream = null;
            outputStream2 = null;
        } catch (Throwable th5) {
            th = th5;
            outputStream = null;
            outputStream2 = null;
        }
    }
}
