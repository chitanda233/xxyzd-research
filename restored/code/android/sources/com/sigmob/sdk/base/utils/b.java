package com.sigmob.sdk.base.utils;

import com.baidu.mobads.sdk.internal.an;
import com.byazt.tk.AdBaseConstants;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3251a = "b";
    private static final String[] b = {"TencentCOS", "COS", "OSS", "BOS", "S3", "apk", "download", "cdn"};
    private static final String[] c = {"x-cos-", "x-oss-", "x-bce-", "x-amz-", "apk", "download", "attachment"};

    /* JADX WARN: Code duplicated, block: B:176:0x037b  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r3v12 */
    /* JADX WARN: Type inference failed for: r3v2 */
    /* JADX WARN: Type inference failed for: r3v4 */
    public static boolean a(String str) throws Throwable {
        HttpURLConnection httpURLConnection;
        int i;
        long j;
        if (str == null || str.trim().isEmpty()) {
            k.b(f3251a, "isAPKFileEnhanced: URL 为空", new Object[0]);
            return false;
        }
        String lowerCase = str.toLowerCase();
        if (lowerCase.endsWith(".apk")) {
            k.b(f3251a, "isAPKFileEnhanced: URL 以 .apk 结尾", new Object[0]);
            return true;
        }
        if (lowerCase.split("\\?")[0].endsWith(".apk")) {
            k.b(f3251a, "isAPKFileEnhanced: URL 路径以 .apk 结尾", new Object[0]);
            return true;
        }
        try {
            HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(str).openConnection();
            try {
                httpURLConnection2.setRequestMethod(com.sigmob.sdk.downloader.core.c.f3394a);
                httpURLConnection2.setConnectTimeout(3000);
                httpURLConnection2.setReadTimeout(3000);
                httpURLConnection2.setInstanceFollowRedirects(true);
                int responseCode = httpURLConnection2.getResponseCode();
                if (responseCode == 301 || responseCode == 302 || responseCode == 303) {
                    String headerField = httpURLConnection2.getHeaderField("Location");
                    if (headerField != null && !headerField.isEmpty()) {
                        k.e(f3251a, "isAPKFileEnhanced: redirect = " + headerField, new Object[0]);
                        boolean zA = a(headerField);
                        if (httpURLConnection2 != null) {
                            httpURLConnection2.disconnect();
                        }
                        return zA;
                    }
                    k.c(f3251a, "isAPKFileEnhanced: non-redirection", new Object[0]);
                }
                if (responseCode == 200) {
                    Map<String, List<String>> headerFields = httpURLConnection2.getHeaderFields();
                    String contentType = httpURLConnection2.getContentType();
                    String lowerCase2 = contentType == null ? null : contentType.toLowerCase();
                    String headerField2 = httpURLConnection2.getHeaderField(com.sigmob.sdk.downloader.core.c.j);
                    String lowerCase3 = headerField2 == null ? null : headerField2.toLowerCase();
                    String headerField3 = httpURLConnection2.getHeaderField(com.sigmob.sdk.downloader.core.c.e);
                    if (headerField3 != null) {
                        try {
                            j = Long.parseLong(headerField3);
                        } catch (NumberFormatException unused) {
                            j = 0;
                        }
                    } else {
                        j = 0;
                    }
                    String headerField4 = httpURLConnection2.getHeaderField("Server");
                    String lowerCase4 = headerField4 == null ? null : headerField4.toLowerCase();
                    String str2 = f3251a;
                    k.c(str2, "isAPKFileEnhanced Header 分析:", new Object[0]);
                    k.c(str2, "  URL: " + str, new Object[0]);
                    k.c(str2, "  Content-Type: " + contentType, new Object[0]);
                    k.c(str2, "  Content-Disposition: " + headerField2, new Object[0]);
                    long j2 = j;
                    k.c(str2, "  Content-Length: " + j2 + " bytes", new Object[0]);
                    k.c(str2, "  Server: " + headerField4, new Object[0]);
                    if (lowerCase2 != null && (lowerCase2.contains(AdBaseConstants.MIME_APK) || lowerCase2.contains("application/apk"))) {
                        k.b(str2, "isAPKFileEnhanced: 明确的 apk MIME 类型", new Object[0]);
                        if (httpURLConnection2 == null) {
                            return true;
                        }
                        httpURLConnection2.disconnect();
                        return true;
                    }
                    String str3 = lowerCase3;
                    if (str3 != null && (str3.contains(".apk") || str3.contains("attachment"))) {
                        k.b(str2, "isAPKFileEnhanced: Content-Disposition 指示为 apk", new Object[0]);
                        if (httpURLConnection2 == null) {
                            return true;
                        }
                        httpURLConnection2.disconnect();
                        return true;
                    }
                    if (lowerCase2 != null && lowerCase2.contains("application/octet-stream") && j2 > 1048576) {
                        k.b(str2, "isAPKFileEnhanced: octet-stream 类型且文件较大（" + j2 + " bytes）", new Object[0]);
                        if (!lowerCase2.contains("text/html") && !lowerCase2.contains(an.e) && !lowerCase2.contains(an.d) && !lowerCase2.contains("application/xml") && !lowerCase2.contains("image/") && !lowerCase2.contains("video/") && !lowerCase2.contains("audio/")) {
                            String str4 = lowerCase4;
                            if (str4 != null) {
                                for (String str5 : b) {
                                    if (str4.contains(str5.toLowerCase())) {
                                        k.b(f3251a, "isAPKFileEnhanced: indicator = " + str5, new Object[0]);
                                        if (httpURLConnection2 == null) {
                                            return true;
                                        }
                                        httpURLConnection2.disconnect();
                                        return true;
                                    }
                                }
                            }
                            Iterator<Map.Entry<String, List<String>>> it = headerFields.entrySet().iterator();
                            while (it.hasNext()) {
                                String key = it.next().getKey();
                                if (key != null) {
                                    String lowerCase5 = key.toLowerCase();
                                    for (String str6 : c) {
                                        if (lowerCase5.contains(str6.toLowerCase())) {
                                            k.b(f3251a, "isAPKFileEnhanced: key = " + key, new Object[0]);
                                            if (httpURLConnection2 == null) {
                                                return true;
                                            }
                                            httpURLConnection2.disconnect();
                                            return true;
                                        }
                                    }
                                }
                            }
                            if (j2 > 5242880) {
                                k.b(f3251a, "isAPKFileEnhanced: 大文件（" + j2 + " bytes）可能为 apk", new Object[0]);
                                if (httpURLConnection2 == null) {
                                    return true;
                                }
                                httpURLConnection2.disconnect();
                                return true;
                            }
                        }
                        k.b(str2, "isAPKFileEnhanced: 排除已知的非 apk 类型", new Object[0]);
                        if (httpURLConnection2 != null) {
                            httpURLConnection2.disconnect();
                        }
                        return false;
                    }
                    if (c(lowerCase)) {
                        k.b(f3251a, "isAPKFileEnhanced: URL 包含 apk 关键词", new Object[0]);
                        if (httpURLConnection2 == null) {
                            return true;
                        }
                        httpURLConnection2.disconnect();
                        return true;
                    }
                    if (lowerCase2 != null && (lowerCase2.contains("text/html") || lowerCase2.contains("application/xhtml+xml"))) {
                        k.b(f3251a, "isAPKFileEnhanced: 明确排除网页类型", new Object[0]);
                        if (httpURLConnection2 != null) {
                            httpURLConnection2.disconnect();
                        }
                        return false;
                    }
                    if (j2 > 0 && j2 < 1048576) {
                        k.b(f3251a, "isAPKFileEnhanced: 文件太小（" + j2 + " bytes），可能不是 apk", new Object[0]);
                        if (httpURLConnection2 != null) {
                            httpURLConnection2.disconnect();
                        }
                        return false;
                    }
                }
                if (httpURLConnection2 != null) {
                    httpURLConnection2.disconnect();
                }
                i = 0;
            } catch (Exception e) {
                e = e;
                httpURLConnection = httpURLConnection2;
                try {
                    i = 0;
                    i = 0;
                    k.a(f3251a, "isAPKFileEnhanced: error = ", e, new Object[0]);
                    if (httpURLConnection != null) {
                        httpURLConnection.disconnect();
                    }
                } catch (Throwable th) {
                    th = th;
                    if (httpURLConnection != null) {
                        httpURLConnection.disconnect();
                    }
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                httpURLConnection = httpURLConnection2;
                if (httpURLConnection != null) {
                    httpURLConnection.disconnect();
                }
                throw th;
            }
        } catch (Exception e2) {
            e = e2;
            httpURLConnection = null;
        } catch (Throwable th3) {
            th = th3;
            httpURLConnection = null;
        }
        k.b(f3251a, "isAPKFileEnhanced: 未识别为 apk 文件", new Object[i]);
        return i;
    }

    public static boolean b(String url) {
        if (url == null || url.trim().isEmpty()) {
            return false;
        }
        String lowerCase = url.toLowerCase();
        if (lowerCase.endsWith(".apk") || lowerCase.split("\\?")[0].endsWith(".apk") || c(lowerCase)) {
            return true;
        }
        return d(lowerCase);
    }

    private static boolean c(String url) {
        String[] strArr = {"/apk/", "/download/", "/package/", "/install/", "/app/", "apk=", "package=", "download=", "file=", "app=", ".apk?", "version=", "install", com.sigmob.sdk.base.n.q};
        for (int i = 0; i < 14; i++) {
            if (url.contains(strArr[i])) {
                return true;
            }
        }
        return false;
    }

    private static boolean d(String url) {
        String[] strArr = {"download.", "dl.", "cdn.", "oss.", "cos.", "bos.", "apk.", "package.", "file.", "storage.", "bucket."};
        for (int i = 0; i < 11; i++) {
            if (url.contains(strArr[i])) {
                return true;
            }
        }
        return false;
    }
}
