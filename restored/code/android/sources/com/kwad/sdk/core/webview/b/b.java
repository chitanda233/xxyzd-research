package com.kwad.sdk.core.webview.b;

import android.content.Context;
import android.net.Uri;
import android.text.TextUtils;
import android.util.Log;
import android.webkit.WebResourceResponse;
import com.alipay.sdk.m.t.e;
import com.baidu.mobads.sdk.internal.cb;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.crash.utils.h;
import com.kwad.sdk.utils.y;
import java.io.BufferedInputStream;
import java.io.Closeable;
import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URLConnection;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static final Map<String, com.kwad.sdk.core.webview.b.a.b> bcJ = new ConcurrentHashMap();
    private static final Map<String, String> bcK = new ConcurrentHashMap();

    public static WebResourceResponse a(Context context, String str, com.kwad.sdk.h.a.b bVar, com.kwad.sdk.core.webview.b.c.b.a aVar, boolean z) throws Throwable {
        com.kwad.sdk.core.webview.b.a.b bVarA;
        try {
            bVarA = a(context, bVar, str, aVar);
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            aVar.msg = "获取配置文件失败 崩溃" + Log.getStackTraceString(e);
            bVarA = null;
        }
        if (bVarA == null) {
            b(z, aVar.msg);
            if (TextUtils.isEmpty(aVar.msg)) {
                aVar.msg = "获取配置文件失败";
            }
            return null;
        }
        if (TextUtils.isEmpty(bVarA.bcR)) {
            b(z, "getResource [" + str + "] getFilePath from url fail");
            aVar.msg = "getFilePath from url fail";
            return null;
        }
        if (!com.kwad.sdk.core.webview.b.c.c.fS(bVarA.bcN)) {
            b(z, "mimetype为: " + bVarA.bcN + "不在拦截范围的文件");
            aVar.msg = "mimetype为: " + bVarA.bcN + "不在拦截范围的文件";
            return null;
        }
        BufferedInputStream bufferedInputStreamHE = y.hE(bVarA.bcR);
        if (bufferedInputStreamHE == null) {
            b(z, "getResource [" + str + "] inputStream is null");
            aVar.msg = "inputStream is null,本地加载路径：" + bVarA.bcR;
            return null;
        }
        return a(bufferedInputStreamHE, bVarA);
    }

    private static void b(boolean z, String str) {
        if (z) {
            return;
        }
        c.d("HybridResourceManager", str);
    }

    private static WebResourceResponse a(InputStream inputStream, com.kwad.sdk.core.webview.b.a.b bVar) {
        String str = bVar.bcN;
        HashMap map = new HashMap();
        map.put("Access-Control-Allow-Origin", bVar.bcQ.bcL);
        map.put("Access-Control-Allow-Credentials", "true");
        map.put("Timing-Allow-Origin", bVar.bcQ.bcM);
        map.put(e.f, str);
        map.put("Date", bVar.bcQ.bcO);
        map.put("union-cache ", "1");
        return new WebResourceResponse(bVar.bcN, "", bVar.status, cb.k, map, inputStream);
    }

    private static com.kwad.sdk.core.webview.b.a.b a(Context context, com.kwad.sdk.h.a.b bVar, String str, com.kwad.sdk.core.webview.b.c.b.a aVar) throws Throwable {
        InputStreamReader inputStreamReader;
        FileInputStream fileInputStream = null;
        try {
            String strFL = fL(bVar.bgG);
            com.kwad.sdk.core.webview.b.a.b bVarFK = !TextUtils.isEmpty(strFL) ? fK(ae(strFL, str)) : null;
            if (bVarFK != null) {
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                return bVarFK;
            }
            String strN = com.kwad.sdk.core.webview.b.c.a.N(context, bVar.bgH);
            if (strN == null) {
                aVar.msg = "获取配置文件失败 offlinepackage 为空";
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                return null;
            }
            File file = new File(strN);
            if (!file.exists()) {
                aVar.msg = "获取配置文件失败 下载文件路径不存在 " + strN;
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                com.kwad.sdk.crash.utils.b.closeQuietly((Closeable) null);
                return null;
            }
            FileInputStream fileInputStream2 = new FileInputStream(file);
            try {
                inputStreamReader = new InputStreamReader(fileInputStream2);
                try {
                    String strB = h.b(inputStreamReader);
                    if (TextUtils.isEmpty(strB)) {
                        aVar.msg = "获取配置文件失败 mainfest文件不存在";
                        com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream2);
                        com.kwad.sdk.crash.utils.b.closeQuietly(inputStreamReader);
                        return null;
                    }
                    JSONObject jSONObject = new JSONObject(strB);
                    Iterator<String> itKeys = jSONObject.keys();
                    while (itKeys.hasNext()) {
                        String next = itKeys.next();
                        JSONObject jSONObject2 = jSONObject.getJSONObject(next);
                        com.kwad.sdk.core.webview.b.a.b bVar2 = new com.kwad.sdk.core.webview.b.a.b();
                        bVar2.parseJson(jSONObject2);
                        String host = Uri.parse("https://" + next).getHost();
                        bVar2.bcS = host;
                        bVar2.bcR = com.kwad.sdk.core.webview.b.c.a.M(context, bVar.bgH) + "/" + next;
                        if (TextUtils.isEmpty(bVar2.bcN)) {
                            bVar2.bcN = URLConnection.getFileNameMap().getContentTypeFor(bVar2.bcR);
                        }
                        a(next, bVar2);
                        strFL = host;
                    }
                    af(bVar.bgG, strFL);
                    com.kwad.sdk.core.webview.b.a.b bVarFK2 = fK(ae(strFL, str));
                    com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream2);
                    com.kwad.sdk.crash.utils.b.closeQuietly(inputStreamReader);
                    return bVarFK2;
                } catch (Throwable th) {
                    th = th;
                    fileInputStream = fileInputStream2;
                    com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream);
                    com.kwad.sdk.crash.utils.b.closeQuietly(inputStreamReader);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                inputStreamReader = null;
            }
        } catch (Throwable th3) {
            th = th3;
            inputStreamReader = null;
        }
    }

    private static void a(String str, com.kwad.sdk.core.webview.b.a.b bVar) {
        bcJ.put(String.valueOf(str.hashCode()), bVar);
    }

    private static com.kwad.sdk.core.webview.b.a.b fK(String str) {
        return bcJ.get(String.valueOf(str.hashCode()));
    }

    private static String ae(String str, String str2) {
        return str + Uri.parse(str2).getPath();
    }

    private static void af(String str, String str2) {
        if (TextUtils.isEmpty(str2) || TextUtils.isEmpty(str)) {
            return;
        }
        bcK.put(str, str2);
    }

    private static String fL(String str) {
        return bcK.get(str);
    }
}
