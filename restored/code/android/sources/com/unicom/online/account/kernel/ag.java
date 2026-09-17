package com.unicom.online.account.kernel;

import android.os.Build;
import android.text.TextUtils;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.URL;
import java.nio.charset.Charset;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import javax.net.ssl.SSLSocket;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ag {
    public static final Charset b = Charset.forName("UTF-8");
    public static final String c = "Mozilla/5.0 (Linux; Android " + Build.VERSION.RELEASE + ") UnicomApp";

    public static af b(p pVar, String str, HashMap map, String str2) throws ae, IOException {
        boolean z;
        if (TextUtils.isEmpty(str)) {
            throw new IllegalArgumentException("请求URL不能为空");
        }
        if (TextUtils.isEmpty(str2)) {
            try {
                str2 = new URL(str).getHost();
            } catch (Exception e) {
                throw new IllegalArgumentException("无法从URL中提取域名", e);
            }
        }
        SSLSocket sSLSocket = pVar.b;
        af afVar = new af();
        try {
            sSLSocket.setSoTimeout(bi.b().e);
        } catch (Exception e2) {
            e2.getMessage();
        }
        try {
            String path = new URL(str).getPath();
            String query = new URL(str).getQuery();
            if (query != null && !query.isEmpty()) {
                path = path + "?" + query;
            }
            if (TextUtils.isEmpty(path)) {
                path = "/";
            }
            StringBuilder sb = new StringBuilder();
            sb.append("GET ").append(path).append(" HTTP/1.1\r\n");
            sb.append("Host: ").append(str2).append("\r\n");
            sb.append("Connection: close\r\n");
            Iterator it = map.entrySet().iterator();
            boolean z2 = false;
            while (true) {
                z = true;
                if (!it.hasNext()) {
                    break;
                }
                if ("user-agent".equalsIgnoreCase((String) ((Map.Entry) it.next()).getKey())) {
                    z2 = true;
                }
            }
            if (!z2) {
                sb.append("User-Agent: ").append(c).append("\r\n");
            }
            for (Map.Entry entry : map.entrySet()) {
                sb.append((String) entry.getKey()).append(": ").append((String) entry.getValue()).append("\r\n");
            }
            sb.append("\r\n");
            OutputStream outputStream = sSLSocket.getOutputStream();
            Charset charset = b;
            PrintWriter printWriter = new PrintWriter(new OutputStreamWriter(outputStream, charset));
            printWriter.print(sb.toString());
            printWriter.flush();
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(sSLSocket.getInputStream(), charset));
            StringBuilder sb2 = new StringBuilder();
            HashMap map2 = new HashMap();
            String str3 = null;
            String str4 = null;
            int i = 0;
            while (true) {
                String line = bufferedReader.readLine();
                if (line == null) {
                    afVar.b = i;
                    afVar.c = sb2.toString().trim();
                    afVar.d = str3;
                    afVar.e = map2;
                    return afVar;
                }
                if (!z) {
                    sb2.append(line).append("\n");
                } else if (str4 == null) {
                    if (line.startsWith("HTTP/1.") && line.length() > 12) {
                        try {
                            i = Integer.parseInt(line.substring(9, 12));
                        } catch (NumberFormatException unused) {
                        }
                    }
                    str4 = line;
                } else if (line.isEmpty()) {
                    z = false;
                } else {
                    int iIndexOf = line.indexOf(58);
                    if (iIndexOf > 0) {
                        String lowerCase = line.substring(0, iIndexOf).trim().toLowerCase();
                        String strTrim = line.substring(iIndexOf + 1).trim();
                        map2.put(lowerCase, strTrim);
                        if ("location".equals(lowerCase)) {
                            str3 = strTrim;
                        }
                    }
                }
            }
        } catch (IOException e3) {
            as.b(e3);
            e3.getMessage();
            ao.v = "GET请求IO异常: " + e3.getMessage();
            throw new IOException("HTTP请求IO异常: " + e3.getMessage(), e3);
        } catch (Exception e4) {
            as.b(e4);
            e4.getMessage();
            ao.v = "GET请求异常: " + e4.getMessage();
            throw new ae("HTTP请求异常: " + e4.getMessage(), e4);
        }
    }
}
