package com.cmic.gen.sdk.c.a;

import android.os.SystemClock;
import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import com.cmic.gen.sdk.c.b.e;
import com.cmic.gen.sdk.c.b.h;
import com.cmic.gen.sdk.c.b.i;
import com.cmic.gen.sdk.f.r;
import java.io.Closeable;
import java.io.EOFException;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.URL;
import java.net.UnknownHostException;
import java.util.Map;
import javax.net.ssl.HostnameVerifier;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLSession;
import javax.net.ssl.SSLSocketFactory;

/* JADX INFO: compiled from: ConnectionInterceptor.java */
/* JADX INFO: loaded from: classes2.dex */
public class a implements b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static com.cmic.gen.sdk.c.c f2067a;

    /* JADX WARN: Code duplicated, block: B:103:0x0261  */
    /* JADX WARN: Code duplicated, block: B:104:0x0265  */
    /* JADX WARN: Code duplicated, block: B:107:0x026c A[Catch: all -> 0x02dc, TryCatch #10 {all -> 0x02dc, blocks: (B:105:0x0268, B:107:0x026c, B:109:0x0274, B:111:0x027c), top: B:149:0x0268 }] */
    /* JADX WARN: Code duplicated, block: B:114:0x028d  */
    /* JADX WARN: Code duplicated, block: B:117:0x02ab  */
    /* JADX WARN: Code duplicated, block: B:118:0x02ae  */
    /* JADX WARN: Code duplicated, block: B:121:0x02c1  */
    /* JADX WARN: Code duplicated, block: B:12:0x0073  */
    /* JADX WARN: Code duplicated, block: B:135:0x02ea  */
    /* JADX WARN: Code duplicated, block: B:138:0x0308  */
    /* JADX WARN: Code duplicated, block: B:139:0x030b  */
    /* JADX WARN: Code duplicated, block: B:142:0x031e  */
    /* JADX WARN: Code duplicated, block: B:147:0x0331  */
    @Override // com.cmic.gen.sdk.c.a.b
    public void a(com.cmic.gen.sdk.c.c.c cVar, com.cmic.gen.sdk.c.d.c cVar2, com.cmic.gen.sdk.a aVar) throws Throwable {
        String str;
        HttpsURLConnection httpsURLConnection;
        OutputStream outputStream;
        InputStream inputStream;
        String string;
        com.cmic.gen.sdk.c.d.a aVarA;
        int i;
        String string2;
        URL url;
        boolean z;
        HttpsURLConnection httpsURLConnection2;
        com.cmic.gen.sdk.c.d.c cVar3 = cVar2;
        String str2 = "remote_ip";
        com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "请求地址: " + cVar.a());
        cVar.a(SystemClock.elapsedRealtime());
        StringBuilder sb = new StringBuilder();
        int responseCode = -1;
        try {
            String strA = cVar.a();
            URL url2 = new URL(strA);
            final String host = url2.getHost();
            h hVarK = cVar.k();
            str = "";
            try {
                if ((hVarK instanceof i) || (hVarK instanceof e)) {
                    String strB = aVar.b("remote_ip");
                    if (TextUtils.isEmpty(strB)) {
                        url = url2;
                        z = false;
                    } else {
                        url = new URL(strA.replaceFirst(host, strB));
                        cVar.a("dnsParseResult", "0");
                        z = true;
                    }
                } else {
                    url = url2;
                    z = false;
                }
                if (cVar.h() != null) {
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "开始wifi下取号" + url);
                    httpsURLConnection2 = (HttpsURLConnection) cVar.h().openConnection(url);
                } else {
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "使用当前网络环境发送请求" + url);
                    httpsURLConnection2 = (HttpsURLConnection) url.openConnection();
                }
                httpsURLConnection = httpsURLConnection2;
                try {
                    Map<String, String> mapC = cVar.c();
                    if (mapC != null) {
                        for (String str3 : mapC.keySet()) {
                            httpsURLConnection.addRequestProperty(str3, mapC.get(str3));
                            mapC = mapC;
                        }
                    }
                    if ((httpsURLConnection instanceof HttpsURLConnection) && ((hVarK instanceof i) || (hVarK instanceof e))) {
                        if (z) {
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "host = " + host);
                            httpsURLConnection.setRequestProperty("Host", host);
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "need sni handle");
                            httpsURLConnection.setSSLSocketFactory(new com.cmic.gen.sdk.c.d(httpsURLConnection, cVar.h(), aVar));
                            httpsURLConnection.setHostnameVerifier(new HostnameVerifier() { // from class: com.cmic.gen.sdk.c.a.a.1
                                @Override // javax.net.ssl.HostnameVerifier
                                public boolean verify(String str4, SSLSession sSLSession) {
                                    return HttpsURLConnection.getDefaultHostnameVerifier().verify(host, sSLSession);
                                }
                            });
                        } else {
                            httpsURLConnection.setSSLSocketFactory(a(hVarK, aVar));
                        }
                    }
                    httpsURLConnection.setDoInput(true);
                    httpsURLConnection.setInstanceFollowRedirects(false);
                    httpsURLConnection.setConnectTimeout(5000);
                    httpsURLConnection.setReadTimeout(5000);
                    httpsURLConnection.setDefaultUseCaches(false);
                    String strE = cVar.e();
                    httpsURLConnection.setRequestMethod(strE);
                    httpsURLConnection.setDoOutput(true);
                    if (cVar instanceof com.cmic.gen.sdk.c.c.b) {
                        httpsURLConnection.connect();
                        ((com.cmic.gen.sdk.c.c.b) cVar).a(aVar);
                    }
                    if (strE.endsWith("POST")) {
                        outputStream = httpsURLConnection.getOutputStream();
                        try {
                            outputStream.write(cVar.d().getBytes("utf-8"));
                            outputStream.flush();
                        } catch (Exception e) {
                            e = e;
                            str2 = "remote_ip";
                            inputStream = null;
                            try {
                                e.printStackTrace();
                                com.cmic.gen.sdk.f.c.a("ConnectionInterceptor", "请求失败: " + cVar.a());
                                aVar.a().f2094a.add(e);
                                if (e instanceof EOFException) {
                                    i = 200050;
                                } else {
                                    i = 102102;
                                }
                                try {
                                    if (e instanceof UnknownHostException) {
                                        aVar.a(str2, a());
                                    }
                                    a(outputStream);
                                    a(inputStream);
                                    if (httpsURLConnection != null) {
                                        httpsURLConnection.disconnect();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + i);
                                    StringBuilder sb2 = new StringBuilder("responseResult: ");
                                    if (TextUtils.isEmpty(sb)) {
                                        string2 = str;
                                    } else {
                                        string2 = sb.toString();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb2.append(string2).toString());
                                    if (i != 200) {
                                    }
                                    a(cVar, aVar);
                                    cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                                } catch (Throwable th) {
                                    th = th;
                                    responseCode = i;
                                    a(outputStream);
                                    a(inputStream);
                                    if (httpsURLConnection != null) {
                                        httpsURLConnection.disconnect();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                                    StringBuilder sb3 = new StringBuilder("responseResult: ");
                                    if (TextUtils.isEmpty(sb)) {
                                        string = str;
                                    } else {
                                        string = sb.toString();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb3.append(string).toString());
                                    if (responseCode != 200 || responseCode == 301 || responseCode == 302) {
                                        a(cVar, aVar);
                                        cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                                    } else {
                                        a(cVar, aVar);
                                        cVar3.a(com.cmic.gen.sdk.c.d.a.a(responseCode));
                                    }
                                    throw th;
                                }
                            } catch (Throwable th2) {
                                th = th2;
                                responseCode = responseCode;
                            }
                        } catch (Throwable th3) {
                            th = th3;
                            responseCode = -1;
                            inputStream = null;
                            a(outputStream);
                            a(inputStream);
                            if (httpsURLConnection != null) {
                                httpsURLConnection.disconnect();
                            }
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                            StringBuilder sb4 = new StringBuilder("responseResult: ");
                            if (TextUtils.isEmpty(sb)) {
                                string = str;
                            } else {
                                string = sb.toString();
                            }
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb4.append(string).toString());
                            if (responseCode != 200) {
                                a(cVar, aVar);
                                cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                            } else {
                                a(cVar, aVar);
                                cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                            }
                            throw th;
                        }
                    } else {
                        outputStream = null;
                    }
                    responseCode = httpsURLConnection.getResponseCode();
                    try {
                        inputStream = httpsURLConnection.getInputStream();
                        try {
                            byte[] bArr = new byte[2048];
                            while (true) {
                                int i2 = inputStream.read(bArr);
                                if (i2 <= 0) {
                                    break;
                                }
                                str2 = str2;
                                try {
                                    sb.append(new String(bArr, 0, i2, "utf-8"));
                                    cVar3 = cVar2;
                                    str2 = str2;
                                } catch (Exception e2) {
                                    e = e2;
                                    cVar3 = cVar2;
                                    responseCode = responseCode;
                                    e.printStackTrace();
                                    com.cmic.gen.sdk.f.c.a("ConnectionInterceptor", "请求失败: " + cVar.a());
                                    aVar.a().f2094a.add(e);
                                    if (e instanceof EOFException) {
                                        i = 200050;
                                    } else {
                                        i = 102102;
                                    }
                                    if (e instanceof UnknownHostException) {
                                        aVar.a(str2, a());
                                    }
                                    a(outputStream);
                                    a(inputStream);
                                    if (httpsURLConnection != null) {
                                        httpsURLConnection.disconnect();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + i);
                                    StringBuilder sb5 = new StringBuilder("responseResult: ");
                                    if (TextUtils.isEmpty(sb)) {
                                        string2 = str;
                                    } else {
                                        string2 = sb.toString();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb5.append(string2).toString());
                                    if (i != 200) {
                                    }
                                    a(cVar, aVar);
                                    cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                                } catch (Throwable th4) {
                                    th = th4;
                                    cVar3 = cVar2;
                                    a(outputStream);
                                    a(inputStream);
                                    if (httpsURLConnection != null) {
                                        httpsURLConnection.disconnect();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                                    StringBuilder sb6 = new StringBuilder("responseResult: ");
                                    if (TextUtils.isEmpty(sb)) {
                                        string = str;
                                    } else {
                                        string = sb.toString();
                                    }
                                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb6.append(string).toString());
                                    if (responseCode != 200) {
                                        a(cVar, aVar);
                                        cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                                    } else {
                                        a(cVar, aVar);
                                        cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                                    }
                                    throw th;
                                }
                            }
                            str2 = str2;
                            com.cmic.gen.sdk.c.d.b bVar = new com.cmic.gen.sdk.c.d.b(responseCode, httpsURLConnection.getHeaderFields(), sb.toString());
                            a(outputStream);
                            a(inputStream);
                            if (httpsURLConnection != null) {
                                httpsURLConnection.disconnect();
                            }
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                            com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseResult: " + (TextUtils.isEmpty(sb) ? str : sb.toString()));
                            if (responseCode == 200 || responseCode == 301 || responseCode == 302) {
                                a(cVar, aVar);
                                cVar2.a(bVar);
                            } else {
                                a(cVar, aVar);
                                aVarA = com.cmic.gen.sdk.c.d.a.a(responseCode);
                                cVar3 = cVar2;
                                cVar3.a(aVarA);
                            }
                        } catch (Exception e3) {
                            e = e3;
                            str2 = str2;
                        } catch (Throwable th5) {
                            th = th5;
                        }
                    } catch (Exception e4) {
                        e = e4;
                        str2 = "remote_ip";
                        responseCode = responseCode;
                        inputStream = null;
                        e.printStackTrace();
                        com.cmic.gen.sdk.f.c.a("ConnectionInterceptor", "请求失败: " + cVar.a());
                        aVar.a().f2094a.add(e);
                        if (e instanceof EOFException) {
                            i = 200050;
                        } else {
                            i = 102102;
                        }
                        if ((e instanceof UnknownHostException) && ((cVar.k() instanceof i) || (cVar.k() instanceof e))) {
                            aVar.a(str2, a());
                        }
                        a(outputStream);
                        a(inputStream);
                        if (httpsURLConnection != null) {
                            httpsURLConnection.disconnect();
                        }
                        com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + i);
                        StringBuilder sb7 = new StringBuilder("responseResult: ");
                        if (TextUtils.isEmpty(sb)) {
                            string2 = str;
                        } else {
                            string2 = sb.toString();
                        }
                        com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb7.append(string2).toString());
                        if (i != 200 || i == 301 || i == 302) {
                            a(cVar, aVar);
                            cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                        } else {
                            a(cVar, aVar);
                            aVarA = com.cmic.gen.sdk.c.d.a.a(i);
                            cVar3.a(aVarA);
                        }
                    } catch (Throwable th6) {
                        th = th6;
                        inputStream = null;
                        a(outputStream);
                        a(inputStream);
                        if (httpsURLConnection != null) {
                            httpsURLConnection.disconnect();
                        }
                        com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                        StringBuilder sb8 = new StringBuilder("responseResult: ");
                        if (TextUtils.isEmpty(sb)) {
                            string = str;
                        } else {
                            string = sb.toString();
                        }
                        com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb8.append(string).toString());
                        if (responseCode != 200) {
                            a(cVar, aVar);
                            cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                        } else {
                            a(cVar, aVar);
                            cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                        }
                        throw th;
                    }
                } catch (Exception e5) {
                    e = e5;
                    str2 = "remote_ip";
                    outputStream = null;
                    inputStream = null;
                    e.printStackTrace();
                    com.cmic.gen.sdk.f.c.a("ConnectionInterceptor", "请求失败: " + cVar.a());
                    aVar.a().f2094a.add(e);
                    if (e instanceof EOFException) {
                        i = 200050;
                    } else {
                        i = 102102;
                    }
                    if (e instanceof UnknownHostException) {
                        aVar.a(str2, a());
                    }
                    a(outputStream);
                    a(inputStream);
                    if (httpsURLConnection != null) {
                        httpsURLConnection.disconnect();
                    }
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + i);
                    StringBuilder sb9 = new StringBuilder("responseResult: ");
                    if (TextUtils.isEmpty(sb)) {
                        string2 = str;
                    } else {
                        string2 = sb.toString();
                    }
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb9.append(string2).toString());
                    if (i != 200) {
                    }
                    a(cVar, aVar);
                    cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                } catch (Throwable th7) {
                    th = th7;
                    outputStream = null;
                    inputStream = null;
                    a(outputStream);
                    a(inputStream);
                    if (httpsURLConnection != null) {
                        httpsURLConnection.disconnect();
                    }
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                    StringBuilder sb10 = new StringBuilder("responseResult: ");
                    if (TextUtils.isEmpty(sb)) {
                        string = str;
                    } else {
                        string = sb.toString();
                    }
                    com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb10.append(string).toString());
                    if (responseCode != 200) {
                        a(cVar, aVar);
                        cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                    } else {
                        a(cVar, aVar);
                        cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                    }
                    throw th;
                }
            } catch (Exception e6) {
                e = e6;
                httpsURLConnection = null;
                outputStream = null;
                inputStream = null;
                e.printStackTrace();
                com.cmic.gen.sdk.f.c.a("ConnectionInterceptor", "请求失败: " + cVar.a());
                aVar.a().f2094a.add(e);
                if (e instanceof EOFException) {
                    i = 200050;
                } else {
                    i = 102102;
                }
                if (e instanceof UnknownHostException) {
                    aVar.a(str2, a());
                }
                a(outputStream);
                a(inputStream);
                if (httpsURLConnection != null) {
                    httpsURLConnection.disconnect();
                }
                com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + i);
                StringBuilder sb11 = new StringBuilder("responseResult: ");
                if (TextUtils.isEmpty(sb)) {
                    string2 = str;
                } else {
                    string2 = sb.toString();
                }
                com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb11.append(string2).toString());
                if (i != 200) {
                }
                a(cVar, aVar);
                cVar3.a((com.cmic.gen.sdk.c.d.b) null);
            } catch (Throwable th8) {
                th = th8;
                httpsURLConnection = null;
                outputStream = null;
                inputStream = null;
                a(outputStream);
                a(inputStream);
                if (httpsURLConnection != null) {
                    httpsURLConnection.disconnect();
                }
                com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", "responseCode: " + responseCode);
                StringBuilder sb12 = new StringBuilder("responseResult: ");
                if (TextUtils.isEmpty(sb)) {
                    string = str;
                } else {
                    string = sb.toString();
                }
                com.cmic.gen.sdk.f.c.b("ConnectionInterceptor", sb12.append(string).toString());
                if (responseCode != 200) {
                    a(cVar, aVar);
                    cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                } else {
                    a(cVar, aVar);
                    cVar3.a((com.cmic.gen.sdk.c.d.b) null);
                }
                throw th;
            }
        } catch (Exception e7) {
            e = e7;
            str = "";
        } catch (Throwable th9) {
            th = th9;
            str = "";
        }
    }

    private void a(com.cmic.gen.sdk.c.c.c cVar, com.cmic.gen.sdk.a aVar) {
        if (cVar.a().contains("uniConfig")) {
            return;
        }
        r.c(aVar, String.valueOf(SystemClock.elapsedRealtime() - cVar.i()));
    }

    private void a(Closeable closeable) {
        if (closeable != null) {
            try {
                closeable.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    private String a() {
        return com.cmic.gen.sdk.b.f2062a[0] + TRouterMap.DOT + com.cmic.gen.sdk.b.f2062a[2] + TRouterMap.DOT + com.cmic.gen.sdk.b.f2062a[4] + TRouterMap.DOT + com.cmic.gen.sdk.b.f2062a[6];
    }

    public synchronized SSLSocketFactory a(h hVar, com.cmic.gen.sdk.a aVar) {
        if (hVar instanceof e) {
            com.cmic.gen.sdk.c.c cVar = new com.cmic.gen.sdk.c.c(HttpsURLConnection.getDefaultSSLSocketFactory(), aVar);
            if (f2067a == null) {
                f2067a = cVar;
            }
            return cVar;
        }
        if (f2067a == null) {
            f2067a = new com.cmic.gen.sdk.c.c(HttpsURLConnection.getDefaultSSLSocketFactory(), aVar);
        }
        return f2067a;
    }
}
