package com.bytedance.ads.convert.flat.f;

import android.content.Context;
import android.os.Build;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Log;
import com.baidu.mobads.sdk.internal.an;
import com.byazt.nys.PluginConstants;
import com.byazt.quv.AbsServerManager;
import com.bytedance.ads.convert.BDConvert;
import com.bytedance.ads.convert.depend.CustomOaidCallback;
import com.bytedance.ads.convert.flat.a.h;
import com.bytedance.ads.convert.flat.m.g;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.Charset;
import java.util.HashMap;
import java.util.concurrent.TimeUnit;
import kotlin.io.ByteStreamsKt;
import kotlin.jvm.internal.Intrinsics;
import kotlin.text.Charsets;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class a implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Context f1695a;

    public a(Context context) {
        this.f1695a = context;
    }

    /* JADX WARN: Code duplicated, block: B:108:0x0340  */
    /* JADX WARN: Code duplicated, block: B:109:0x0341 A[Catch: all -> 0x0471, TryCatch #0 {all -> 0x0471, blocks: (B:76:0x028c, B:80:0x02b1, B:83:0x02db, B:105:0x0318, B:106:0x031b, B:110:0x0344, B:112:0x0352, B:109:0x0341), top: B:160:0x0231 }] */
    /* JADX WARN: Code duplicated, block: B:114:0x035b  */
    /* JADX WARN: Code duplicated, block: B:116:0x0360  */
    /* JADX WARN: Code duplicated, block: B:118:0x0365  */
    /* JADX WARN: Code duplicated, block: B:122:0x0379  */
    /* JADX WARN: Code duplicated, block: B:125:0x0395  */
    /* JADX WARN: Code duplicated, block: B:127:0x03ab  */
    /* JADX WARN: Code duplicated, block: B:128:0x03c2  */
    /* JADX WARN: Code duplicated, block: B:131:0x03cb  */
    /* JADX WARN: Code duplicated, block: B:134:0x03e8  */
    /* JADX WARN: Code duplicated, block: B:135:0x0401  */
    /* JADX WARN: Code duplicated, block: B:138:0x0411  */
    /* JADX WARN: Code duplicated, block: B:142:0x042d  */
    /* JADX WARN: Code duplicated, block: B:145:0x0438  */
    /* JADX WARN: Code duplicated, block: B:148:0x045d  */
    /* JADX WARN: Code duplicated, block: B:161:0x0318 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:174:? A[RETURN, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:45:0x0124  */
    /* JADX WARN: Code duplicated, block: B:47:0x0128  */
    /* JADX WARN: Code duplicated, block: B:48:0x0178  */
    /* JADX WARN: Code duplicated, block: B:71:0x023c A[Catch: all -> 0x030c, Exception -> 0x0312, TRY_LEAVE, TryCatch #10 {Exception -> 0x0312, all -> 0x030c, blocks: (B:69:0x0231, B:71:0x023c, B:97:0x0304, B:98:0x030b), top: B:160:0x0231 }] */
    /* JADX WARN: Code duplicated, block: B:75:0x0279 A[Catch: all -> 0x02f3, Exception -> 0x02f8, TRY_LEAVE, TryCatch #12 {Exception -> 0x02f8, all -> 0x02f3, blocks: (B:73:0x026c, B:75:0x0279, B:87:0x02eb, B:88:0x02f2), top: B:171:0x026c }] */
    /* JADX WARN: Code duplicated, block: B:78:0x02ae  */
    /* JADX WARN: Code duplicated, block: B:79:0x02af  */
    /* JADX WARN: Code duplicated, block: B:82:0x02da  */
    /* JADX WARN: Code duplicated, block: B:83:0x02db A[Catch: Exception -> 0x02e9, all -> 0x0471, TRY_LEAVE, TryCatch #0 {all -> 0x0471, blocks: (B:76:0x028c, B:80:0x02b1, B:83:0x02db, B:105:0x0318, B:106:0x031b, B:110:0x0344, B:112:0x0352, B:109:0x0341), top: B:160:0x0231 }] */
    /* JADX WARN: Code duplicated, block: B:87:0x02eb A[Catch: all -> 0x02f3, Exception -> 0x02f8, TRY_ENTER, TryCatch #12 {Exception -> 0x02f8, all -> 0x02f3, blocks: (B:73:0x026c, B:75:0x0279, B:87:0x02eb, B:88:0x02f2), top: B:171:0x026c }] */
    /* JADX WARN: Code duplicated, block: B:97:0x0304 A[Catch: all -> 0x030c, Exception -> 0x0312, TRY_ENTER, TryCatch #10 {Exception -> 0x0312, all -> 0x030c, blocks: (B:69:0x0231, B:71:0x023c, B:97:0x0304, B:98:0x030b), top: B:160:0x0231 }] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r15v3 */
    /* JADX WARN: Type inference failed for: r15v4 */
    /* JADX WARN: Type inference failed for: r15v5, types: [java.net.HttpURLConnection] */
    /* JADX WARN: Type inference failed for: r15v6 */
    /* JADX WARN: Type inference failed for: r15v7 */
    /* JADX WARN: Type inference failed for: r6v10, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r6v19 */
    /* JADX WARN: Type inference failed for: r6v21 */
    /* JADX WARN: Type inference failed for: r6v27 */
    /* JADX WARN: Type inference failed for: r6v7 */
    /* JADX WARN: Type inference failed for: r8v10 */
    /* JADX WARN: Type inference failed for: r8v11 */
    /* JADX WARN: Type inference failed for: r8v16 */
    /* JADX WARN: Type inference failed for: r8v17 */
    /* JADX WARN: Type inference failed for: r8v18 */
    /* JADX WARN: Type inference failed for: r8v20, types: [java.io.OutputStream] */
    /* JADX WARN: Type inference failed for: r8v25 */
    /* JADX WARN: Type inference failed for: r8v34 */
    /* JADX WARN: Type inference failed for: r8v35 */
    /* JADX WARN: Type inference failed for: r8v36 */
    /* JADX WARN: Type inference failed for: r8v37 */
    /* JADX WARN: Type inference failed for: r8v38 */
    /* JADX WARN: Type inference failed for: r8v39 */
    /* JADX WARN: Type inference failed for: r8v40 */
    /* JADX WARN: Type inference failed for: r8v41 */
    /* JADX WARN: Type inference failed for: r8v42 */
    /* JADX WARN: Type inference failed for: r8v43 */
    /* JADX WARN: Type inference failed for: r8v44 */
    /* JADX WARN: Type inference failed for: r8v45 */
    /* JADX WARN: Type inference failed for: r8v46 */
    /* JADX WARN: Type inference failed for: r8v47 */
    /* JADX WARN: Type inference failed for: r8v48 */
    /* JADX WARN: Type inference failed for: r8v7 */
    /* JADX WARN: Type inference failed for: r8v8 */
    /* JADX WARN: Type inference failed for: r8v9 */
    @Override // java.lang.Runnable
    public final void run() throws Throwable {
        boolean enableOAID;
        ?? r8;
        ?? r9;
        com.bytedance.ads.convert.flat.k.d dVar;
        ?? r10;
        HashMap map;
        ?? r11;
        String str;
        ?? r12;
        JSONObject body;
        ?? r6;
        ?? r13;
        ?? r15;
        InputStream inputStream;
        HttpURLConnection httpURLConnection;
        OutputStream outputStream;
        String msg;
        JSONObject jSONObject;
        JSONObject jSONObjectOptJSONObject;
        JSONObject jSONObjectOptJSONObject2;
        long jOptLong;
        JSONObject jSONObjectOptJSONObject3;
        JSONObject jSONObjectOptJSONObject4;
        JSONObject jSONObjectOptJSONObject5;
        URLConnection uRLConnectionOpenConnection;
        String string;
        Charset charset;
        String headerField;
        String msg2;
        BDConvert bDConvert;
        String str2;
        String str3 = "request error";
        BDConvert bDConvert2 = BDConvert.INSTANCE;
        String str4 = "msg";
        try {
            try {
                if (bDConvert2.getConfig().getCustomOaidCallback() != null) {
                    b.b = System.currentTimeMillis();
                    CustomOaidCallback customOaidCallback = bDConvert2.getConfig().getCustomOaidCallback();
                    if (customOaidCallback == null || (str2 = customOaidCallback.get()) == null) {
                        str2 = "";
                    }
                    b.c = str2;
                    bDConvert = bDConvert2;
                } else {
                    enableOAID = bDConvert2.getConfig().getEnableOAID();
                    if (enableOAID) {
                        com.bytedance.ads.convert.flat.k.b bVar = new com.bytedance.ads.convert.flat.k.b(new com.bytedance.ads.convert.flat.k.b.a(this.f1695a));
                        boolean z = bVar.c;
                        if (z) {
                            boolean zCompareAndSet = bVar.e.compareAndSet(false, true);
                            if (zCompareAndSet) {
                                bDConvert = enableOAID;
                                com.bytedance.ads.convert.flat.k.a aVar = new com.bytedance.ads.convert.flat.k.a(bVar);
                                bVar.f = com.bytedance.ads.convert.flat.o.a.b.b(new Object[0]).submit(aVar);
                                r8 = aVar;
                            } else {
                                bDConvert = enableOAID;
                                r8 = zCompareAndSet;
                            }
                            com.bytedance.ads.convert.flat.k.d dVar2 = bVar.g;
                            if (dVar2 == null) {
                                long jElapsedRealtime = SystemClock.elapsedRealtime();
                                try {
                                    boolean z2 = bVar.f1725a instanceof g;
                                    long j = z2 ? 1100L : 1000L;
                                    try {
                                        String str5 = "getOaid timeoutMills=" + j;
                                        com.bytedance.ads.convert.flat.k.d dVar3 = bVar.f.get(j, TimeUnit.MILLISECONDS);
                                        String str6 = "getOaid took: " + (SystemClock.elapsedRealtime() - jElapsedRealtime) + " ms";
                                        dVar = dVar3;
                                        r10 = z2;
                                    } catch (Throwable th) {
                                        th = th;
                                        try {
                                            ?? r14 = 1;
                                            bVar.f.cancel(true);
                                            com.bytedance.ads.convert.flat.k.d dVar4 = bVar.g;
                                            if (dVar4 != null) {
                                                String message = th.getMessage();
                                                dVar4.h = message;
                                                r14 = message;
                                            }
                                            String str7 = "getOaid error=" + th.getMessage();
                                            String str8 = "getOaid took: " + (SystemClock.elapsedRealtime() - jElapsedRealtime) + " ms";
                                            r9 = r14;
                                            dVar = dVar2;
                                            r10 = r9;
                                        } catch (Throwable th2) {
                                            String str9 = "getOaid took: " + (SystemClock.elapsedRealtime() - jElapsedRealtime) + " ms";
                                            throw th2;
                                        }
                                    }
                                } catch (Throwable th3) {
                                    th = th3;
                                }
                                if (dVar == null) {
                                    dVar = bVar.g;
                                }
                                if (dVar != null) {
                                    map = new HashMap();
                                    com.bytedance.ads.convert.flat.k.b.a(map, "id", dVar.f1728a);
                                    com.bytedance.ads.convert.flat.k.b.a(map, "req_id", dVar.b);
                                    com.bytedance.ads.convert.flat.k.b.a(map, "is_track_limited", String.valueOf(dVar.c));
                                    com.bytedance.ads.convert.flat.k.b.a(map, "take_ms", String.valueOf(dVar.d));
                                    com.bytedance.ads.convert.flat.k.b.a(map, "time", String.valueOf(dVar.e));
                                    com.bytedance.ads.convert.flat.k.b.a(map, "query_times", String.valueOf(dVar.f));
                                    com.bytedance.ads.convert.flat.k.b.a(map, "hw_id_version_code", String.valueOf(dVar.g));
                                    com.bytedance.ads.convert.flat.k.b.a(map, "error_msg", dVar.h);
                                } else {
                                    map = null;
                                }
                                String str10 = "getOaid return apiMap=" + map;
                                r11 = r10;
                            } else {
                                dVar2 = dVar2;
                                r9 = r8;
                            }
                            dVar = dVar2;
                            r10 = r9;
                            if (dVar == null) {
                                dVar = bVar.g;
                            }
                            if (dVar != null) {
                                map = new HashMap();
                                com.bytedance.ads.convert.flat.k.b.a(map, "id", dVar.f1728a);
                                com.bytedance.ads.convert.flat.k.b.a(map, "req_id", dVar.b);
                                com.bytedance.ads.convert.flat.k.b.a(map, "is_track_limited", String.valueOf(dVar.c));
                                com.bytedance.ads.convert.flat.k.b.a(map, "take_ms", String.valueOf(dVar.d));
                                com.bytedance.ads.convert.flat.k.b.a(map, "time", String.valueOf(dVar.e));
                                com.bytedance.ads.convert.flat.k.b.a(map, "query_times", String.valueOf(dVar.f));
                                com.bytedance.ads.convert.flat.k.b.a(map, "hw_id_version_code", String.valueOf(dVar.g));
                                com.bytedance.ads.convert.flat.k.b.a(map, "error_msg", dVar.h);
                            } else {
                                map = null;
                            }
                            String str11 = "getOaid return apiMap=" + map;
                            r11 = r10;
                        } else {
                            str3 = "request error";
                            map = null;
                        }
                        if (map != null) {
                            b.b = System.currentTimeMillis();
                            String str12 = (String) map.get("id");
                            if (str12 == null) {
                                bDConvert = enableOAID;
                                r11 = z;
                                str12 = "";
                            }
                            bDConvert = enableOAID;
                            r11 = z;
                            b.c = str12;
                        }
                        bDConvert = enableOAID;
                        r11 = z;
                        if (b.c != null) {
                            String msg3 = "oaid fetch: " + b.c.length();
                            Intrinsics.checkNotNullParameter("Convert:Event", "tag");
                            Intrinsics.checkNotNullParameter(msg3, "msg");
                            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                                Log.d("Convert:Event", msg3);
                            }
                        }
                        r12 = r11;
                        if (!TextUtils.isEmpty(b.c) && b.f1696a != null) {
                            r12 = r11;
                            d.b.a();
                            r12 = r11;
                        }
                    }
                    r12 = r11;
                    com.bytedance.ads.convert.flat.e.a aVar2 = com.bytedance.ads.convert.flat.e.a.h;
                    Context context = this.f1695a;
                    Intrinsics.checkNotNullParameter(context, "context");
                    String packageName = context.getPackageName();
                    String string2 = context.getPackageManager().getApplicationInfo(packageName, 128).metaData.getString("hume_convert.AppConvert.sdk.version");
                    System.currentTimeMillis();
                    body = new JSONObject();
                    body.put(AbsServerManager.PACKAGE_QUERY_BINDER, packageName);
                    body.put(PluginConstants.KEY_SDK_VERSION, string2);
                    body.put("os", "android");
                    body.put("os_version", Build.VERSION.RELEASE);
                    String url = com.bytedance.ads.convert.flat.e.a.c;
                    Intrinsics.checkNotNullParameter(url, "url");
                    Intrinsics.checkNotNullParameter(body, "body");
                    Intrinsics.checkNotNullParameter("Convert:Config", "tag");
                    uRLConnectionOpenConnection = new URL(url).openConnection();
                    if (uRLConnectionOpenConnection != null) {
                        throw new NullPointerException("null cannot be cast to non-null type java.net.HttpURLConnection");
                    }
                    httpURLConnection = (HttpURLConnection) uRLConnectionOpenConnection;
                    try {
                        httpURLConnection.setRequestMethod("POST");
                        httpURLConnection.setUseCaches(false);
                        httpURLConnection.setConnectTimeout(5000);
                        httpURLConnection.setReadTimeout(5000);
                        httpURLConnection.setRequestProperty("enable-encrypt", "1");
                        httpURLConnection.setRequestProperty("Content-Type", an.d);
                        httpURLConnection.setDoOutput(true);
                        httpURLConnection.setDoInput(true);
                        httpURLConnection.connect();
                        outputStream = httpURLConnection.getOutputStream();
                        try {
                            string = body.toString();
                            Intrinsics.checkNotNullExpressionValue(string, "body.toString()");
                            charset = Charsets.UTF_8;
                            if (string != null) {
                                throw new NullPointerException("null cannot be cast to non-null type java.lang.String");
                            }
                            byte[] bytes = string.getBytes(charset);
                            Intrinsics.checkNotNullExpressionValue(bytes, "(this as java.lang.String).getBytes(charset)");
                            outputStream.write(bytes);
                            outputStream.close();
                            inputStream = httpURLConnection.getInputStream();
                            try {
                                Intrinsics.checkNotNullExpressionValue(inputStream, "inputStream");
                                jSONObject = new JSONObject(new String(ByteStreamsKt.readBytes(inputStream), Charsets.UTF_8));
                                inputStream.close();
                                int responseCode = httpURLConnection.getResponseCode();
                                headerField = httpURLConnection.getHeaderField("X-Tt-Logid");
                                if (headerField != null) {
                                    headerField = str;
                                }
                                msg2 = "post: response: " + responseCode + '\t' + headerField;
                                Intrinsics.checkNotNullParameter("Convert:Config", "tag");
                                Intrinsics.checkNotNullParameter(msg2, "msg");
                                if (!BDConvert.INSTANCE.getConfig().getEnableLog()) {
                                    Log.d("Convert:Config", msg2);
                                }
                                httpURLConnection.disconnect();
                                outputStream.close();
                                inputStream.close();
                            } catch (Exception e) {
                                e = e;
                                if (httpURLConnection != null) {
                                    try {
                                        httpURLConnection.getHeaderField("X-Tt-Logid");
                                    } catch (Exception unused) {
                                    }
                                }
                                msg = str3 + e.getMessage();
                                Intrinsics.checkNotNullParameter("Convert:Config", "tag");
                                Intrinsics.checkNotNullParameter(msg, "msg");
                                if (!BDConvert.INSTANCE.getConfig().getEnableLog()) {
                                    Log.d("Convert:Config", msg);
                                }
                                JSONObject jSONObject2 = new JSONObject();
                                jSONObject2.put("err_code", "-1");
                                jSONObject2.put("err_msg", e.getMessage());
                                if (httpURLConnection != null) {
                                    httpURLConnection.disconnect();
                                }
                                if (outputStream != null) {
                                    outputStream.close();
                                }
                                if (inputStream != null) {
                                    inputStream.close();
                                }
                                jSONObject = jSONObject2;
                            }
                            com.bytedance.ads.convert.flat.e.a.g = System.currentTimeMillis();
                            jSONObjectOptJSONObject = jSONObject.optJSONObject("inode");
                            if (jSONObjectOptJSONObject != null) {
                                com.bytedance.ads.convert.flat.e.a.d = new com.bytedance.ads.convert.flat.e.a.C0324a(jSONObjectOptJSONObject.optBoolean("enable", false), jSONObjectOptJSONObject.optLong("timeout", 200L));
                            }
                            jSONObjectOptJSONObject2 = jSONObject.optJSONObject("uaid");
                            if (jSONObjectOptJSONObject2 != null) {
                                com.bytedance.ads.convert.flat.e.a.e.f1679a = jSONObjectOptJSONObject2.optBoolean("enable", true);
                                jSONObjectOptJSONObject3 = jSONObjectOptJSONObject2.optJSONObject("mobile");
                                if (jSONObjectOptJSONObject3 != null) {
                                    com.bytedance.ads.convert.flat.e.a.e.b.f1678a = jSONObjectOptJSONObject3.optBoolean("enable", false);
                                    com.bytedance.ads.convert.flat.e.a.e.b.b = jSONObjectOptJSONObject3.optLong("renew_interval", 3300000L);
                                }
                                jSONObjectOptJSONObject4 = jSONObjectOptJSONObject2.optJSONObject("telecom");
                                if (jSONObjectOptJSONObject4 != null) {
                                    com.bytedance.ads.convert.flat.e.a.e.c.f1678a = jSONObjectOptJSONObject4.optBoolean("enable", false);
                                    com.bytedance.ads.convert.flat.e.a.e.c.b = jSONObjectOptJSONObject4.optLong("renew_interval", 3300000L);
                                }
                                jSONObjectOptJSONObject5 = jSONObjectOptJSONObject2.optJSONObject("unicom");
                                if (jSONObjectOptJSONObject5 != null) {
                                    com.bytedance.ads.convert.flat.e.a.e.d.f1678a = jSONObjectOptJSONObject5.optBoolean("enable", false);
                                    com.bytedance.ads.convert.flat.e.a.e.d.b = jSONObjectOptJSONObject5.optLong("renew_interval", 40000L);
                                }
                            } else {
                                str4 = "msg";
                            }
                            jOptLong = jSONObject.optLong("play_session_interval", 60000L);
                            com.bytedance.ads.convert.flat.e.a.f = jOptLong;
                            if (jOptLong != 60000) {
                                com.bytedance.ads.convert.flat.i.g.i.a(com.bytedance.ads.convert.flat.e.a.f);
                            }
                            Intrinsics.checkNotNullParameter("Convert:Event", "tag");
                            Intrinsics.checkNotNullParameter("Config fetch", str4);
                            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                                Log.d("Convert:Event", "Config fetch");
                            }
                            com.bytedance.ads.convert.flat.e.a aVar3 = com.bytedance.ads.convert.flat.e.a.h;
                            if (com.bytedance.ads.convert.flat.e.a.d.f1694a) {
                                com.bytedance.ads.convert.flat.d.b bVar2 = com.bytedance.ads.convert.flat.d.b.b;
                                com.bytedance.ads.convert.flat.d.c cVar = com.bytedance.ads.convert.flat.d.b.f1688a;
                                int[] iArrA = bVar2.a();
                                cVar.getClass();
                                Intrinsics.checkNotNullParameter(iArrA, "<set-?>");
                                cVar.f = iArrA;
                                b.d = System.currentTimeMillis();
                            }
                            h.c.a(com.bytedance.ads.convert.flat.e.a.e);
                            if (com.bytedance.ads.convert.flat.e.a.e.f1679a) {
                                Context context2 = this.f1695a;
                                Intrinsics.checkNotNullParameter(context2, "context");
                                new Thread(new com.bytedance.ads.convert.flat.a.g(context2, null)).start();
                                return;
                            }
                            return;
                        } catch (Exception e2) {
                            e = e2;
                            inputStream = null;
                        } catch (Throwable th4) {
                            th = th4;
                            r15 = httpURLConnection;
                            r6 = 0;
                            r13 = outputStream;
                            if (r15 != 0) {
                                r15.disconnect();
                            }
                            if (r13 != 0) {
                                r13.close();
                            }
                            if (r6 != 0) {
                                r6.close();
                            }
                            throw th;
                        }
                    } catch (Exception e3) {
                        e = e3;
                        inputStream = null;
                        outputStream = null;
                        if (httpURLConnection != null) {
                            httpURLConnection.getHeaderField("X-Tt-Logid");
                        }
                        msg = str3 + e.getMessage();
                        Intrinsics.checkNotNullParameter("Convert:Config", "tag");
                        Intrinsics.checkNotNullParameter(msg, "msg");
                        if (!BDConvert.INSTANCE.getConfig().getEnableLog()) {
                            Log.d("Convert:Config", msg);
                        }
                        JSONObject jSONObject3 = new JSONObject();
                        jSONObject3.put("err_code", "-1");
                        jSONObject3.put("err_msg", e.getMessage());
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.close();
                        }
                        if (inputStream != null) {
                            inputStream.close();
                        }
                        jSONObject = jSONObject3;
                        com.bytedance.ads.convert.flat.e.a.g = System.currentTimeMillis();
                        jSONObjectOptJSONObject = jSONObject.optJSONObject("inode");
                        if (jSONObjectOptJSONObject != null) {
                            com.bytedance.ads.convert.flat.e.a.d = new com.bytedance.ads.convert.flat.e.a.C0324a(jSONObjectOptJSONObject.optBoolean("enable", false), jSONObjectOptJSONObject.optLong("timeout", 200L));
                        }
                        jSONObjectOptJSONObject2 = jSONObject.optJSONObject("uaid");
                        if (jSONObjectOptJSONObject2 != null) {
                            com.bytedance.ads.convert.flat.e.a.e.f1679a = jSONObjectOptJSONObject2.optBoolean("enable", true);
                            jSONObjectOptJSONObject3 = jSONObjectOptJSONObject2.optJSONObject("mobile");
                            if (jSONObjectOptJSONObject3 != null) {
                                com.bytedance.ads.convert.flat.e.a.e.b.f1678a = jSONObjectOptJSONObject3.optBoolean("enable", false);
                                com.bytedance.ads.convert.flat.e.a.e.b.b = jSONObjectOptJSONObject3.optLong("renew_interval", 3300000L);
                            }
                            jSONObjectOptJSONObject4 = jSONObjectOptJSONObject2.optJSONObject("telecom");
                            if (jSONObjectOptJSONObject4 != null) {
                                com.bytedance.ads.convert.flat.e.a.e.c.f1678a = jSONObjectOptJSONObject4.optBoolean("enable", false);
                                com.bytedance.ads.convert.flat.e.a.e.c.b = jSONObjectOptJSONObject4.optLong("renew_interval", 3300000L);
                            }
                            jSONObjectOptJSONObject5 = jSONObjectOptJSONObject2.optJSONObject("unicom");
                            if (jSONObjectOptJSONObject5 != null) {
                                com.bytedance.ads.convert.flat.e.a.e.d.f1678a = jSONObjectOptJSONObject5.optBoolean("enable", false);
                                com.bytedance.ads.convert.flat.e.a.e.d.b = jSONObjectOptJSONObject5.optLong("renew_interval", 40000L);
                            }
                        } else {
                            str4 = "msg";
                        }
                        jOptLong = jSONObject.optLong("play_session_interval", 60000L);
                        com.bytedance.ads.convert.flat.e.a.f = jOptLong;
                        if (jOptLong != 60000) {
                            com.bytedance.ads.convert.flat.i.g.i.a(com.bytedance.ads.convert.flat.e.a.f);
                        }
                        Intrinsics.checkNotNullParameter("Convert:Event", "tag");
                        Intrinsics.checkNotNullParameter("Config fetch", str4);
                        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                            Log.d("Convert:Event", "Config fetch");
                        }
                        com.bytedance.ads.convert.flat.e.a aVar4 = com.bytedance.ads.convert.flat.e.a.h;
                        if (com.bytedance.ads.convert.flat.e.a.d.f1694a) {
                            com.bytedance.ads.convert.flat.d.b bVar3 = com.bytedance.ads.convert.flat.d.b.b;
                            com.bytedance.ads.convert.flat.d.c cVar2 = com.bytedance.ads.convert.flat.d.b.f1688a;
                            int[] iArrA2 = bVar3.a();
                            cVar2.getClass();
                            Intrinsics.checkNotNullParameter(iArrA2, "<set-?>");
                            cVar2.f = iArrA2;
                            b.d = System.currentTimeMillis();
                        }
                        h.c.a(com.bytedance.ads.convert.flat.e.a.e);
                        if (com.bytedance.ads.convert.flat.e.a.e.f1679a) {
                            Context context3 = this.f1695a;
                            Intrinsics.checkNotNullParameter(context3, "context");
                            new Thread(new com.bytedance.ads.convert.flat.a.g(context3, null)).start();
                            return;
                        }
                        return;
                    } catch (Throwable th5) {
                        th = th5;
                        r15 = httpURLConnection;
                        r6 = 0;
                        r13 = 0;
                    }
                }
                uRLConnectionOpenConnection = new URL(url).openConnection();
                if (uRLConnectionOpenConnection != null) {
                    throw new NullPointerException("null cannot be cast to non-null type java.net.HttpURLConnection");
                }
                httpURLConnection = (HttpURLConnection) uRLConnectionOpenConnection;
                httpURLConnection.setRequestMethod("POST");
                httpURLConnection.setUseCaches(false);
                httpURLConnection.setConnectTimeout(5000);
                httpURLConnection.setReadTimeout(5000);
                httpURLConnection.setRequestProperty("enable-encrypt", "1");
                httpURLConnection.setRequestProperty("Content-Type", an.d);
                httpURLConnection.setDoOutput(true);
                httpURLConnection.setDoInput(true);
                httpURLConnection.connect();
                outputStream = httpURLConnection.getOutputStream();
                string = body.toString();
                Intrinsics.checkNotNullExpressionValue(string, "body.toString()");
                charset = Charsets.UTF_8;
                if (string != null) {
                    throw new NullPointerException("null cannot be cast to non-null type java.lang.String");
                }
                byte[] bytes2 = string.getBytes(charset);
                Intrinsics.checkNotNullExpressionValue(bytes2, "(this as java.lang.String).getBytes(charset)");
                outputStream.write(bytes2);
                outputStream.close();
                inputStream = httpURLConnection.getInputStream();
                Intrinsics.checkNotNullExpressionValue(inputStream, "inputStream");
                jSONObject = new JSONObject(new String(ByteStreamsKt.readBytes(inputStream), Charsets.UTF_8));
                inputStream.close();
                int responseCode2 = httpURLConnection.getResponseCode();
                headerField = httpURLConnection.getHeaderField("X-Tt-Logid");
                if (headerField != null) {
                    headerField = str;
                }
                msg2 = "post: response: " + responseCode2 + '\t' + headerField;
                Intrinsics.checkNotNullParameter("Convert:Config", "tag");
                Intrinsics.checkNotNullParameter(msg2, "msg");
                if (!BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d("Convert:Config", msg2);
                }
                httpURLConnection.disconnect();
                outputStream.close();
                inputStream.close();
                com.bytedance.ads.convert.flat.e.a.g = System.currentTimeMillis();
                jSONObjectOptJSONObject = jSONObject.optJSONObject("inode");
                if (jSONObjectOptJSONObject != null) {
                    com.bytedance.ads.convert.flat.e.a.d = new com.bytedance.ads.convert.flat.e.a.C0324a(jSONObjectOptJSONObject.optBoolean("enable", false), jSONObjectOptJSONObject.optLong("timeout", 200L));
                }
                jSONObjectOptJSONObject2 = jSONObject.optJSONObject("uaid");
                if (jSONObjectOptJSONObject2 != null) {
                    com.bytedance.ads.convert.flat.e.a.e.f1679a = jSONObjectOptJSONObject2.optBoolean("enable", true);
                    jSONObjectOptJSONObject3 = jSONObjectOptJSONObject2.optJSONObject("mobile");
                    if (jSONObjectOptJSONObject3 != null) {
                        com.bytedance.ads.convert.flat.e.a.e.b.f1678a = jSONObjectOptJSONObject3.optBoolean("enable", false);
                        com.bytedance.ads.convert.flat.e.a.e.b.b = jSONObjectOptJSONObject3.optLong("renew_interval", 3300000L);
                    }
                    jSONObjectOptJSONObject4 = jSONObjectOptJSONObject2.optJSONObject("telecom");
                    if (jSONObjectOptJSONObject4 != null) {
                        com.bytedance.ads.convert.flat.e.a.e.c.f1678a = jSONObjectOptJSONObject4.optBoolean("enable", false);
                        com.bytedance.ads.convert.flat.e.a.e.c.b = jSONObjectOptJSONObject4.optLong("renew_interval", 3300000L);
                    }
                    jSONObjectOptJSONObject5 = jSONObjectOptJSONObject2.optJSONObject("unicom");
                    if (jSONObjectOptJSONObject5 != null) {
                        com.bytedance.ads.convert.flat.e.a.e.d.f1678a = jSONObjectOptJSONObject5.optBoolean("enable", false);
                        com.bytedance.ads.convert.flat.e.a.e.d.b = jSONObjectOptJSONObject5.optLong("renew_interval", 40000L);
                    }
                } else {
                    str4 = "msg";
                }
                jOptLong = jSONObject.optLong("play_session_interval", 60000L);
                com.bytedance.ads.convert.flat.e.a.f = jOptLong;
                if (jOptLong != 60000) {
                    com.bytedance.ads.convert.flat.i.g.i.a(com.bytedance.ads.convert.flat.e.a.f);
                }
                Intrinsics.checkNotNullParameter("Convert:Event", "tag");
                Intrinsics.checkNotNullParameter("Config fetch", str4);
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d("Convert:Event", "Config fetch");
                }
                com.bytedance.ads.convert.flat.e.a aVar5 = com.bytedance.ads.convert.flat.e.a.h;
                if (com.bytedance.ads.convert.flat.e.a.d.f1694a) {
                    com.bytedance.ads.convert.flat.d.b bVar4 = com.bytedance.ads.convert.flat.d.b.b;
                    com.bytedance.ads.convert.flat.d.c cVar3 = com.bytedance.ads.convert.flat.d.b.f1688a;
                    int[] iArrA3 = bVar4.a();
                    cVar3.getClass();
                    Intrinsics.checkNotNullParameter(iArrA3, "<set-?>");
                    cVar3.f = iArrA3;
                    b.d = System.currentTimeMillis();
                }
                h.c.a(com.bytedance.ads.convert.flat.e.a.e);
                if (com.bytedance.ads.convert.flat.e.a.e.f1679a) {
                    Context context4 = this.f1695a;
                    Intrinsics.checkNotNullParameter(context4, "context");
                    new Thread(new com.bytedance.ads.convert.flat.a.g(context4, null)).start();
                    return;
                }
                return;
            } catch (Throwable th6) {
                th = th6;
                r15 = AbsServerManager.PACKAGE_QUERY_BINDER;
                r6 = body;
                r13 = r12;
            }
        } catch (Exception e4) {
            e = e4;
            inputStream = null;
            httpURLConnection = null;
        } catch (Throwable th7) {
            th = th7;
            r6 = 0;
            r13 = 0;
            r15 = 0;
        }
        bDConvert = enableOAID;
        str3 = "request error";
        str = "";
        r12 = bDConvert;
        r12 = r11;
        com.bytedance.ads.convert.flat.e.a aVar6 = com.bytedance.ads.convert.flat.e.a.h;
        Context context5 = this.f1695a;
        Intrinsics.checkNotNullParameter(context5, "context");
        String packageName2 = context5.getPackageName();
        String string3 = context5.getPackageManager().getApplicationInfo(packageName2, 128).metaData.getString("hume_convert.AppConvert.sdk.version");
        System.currentTimeMillis();
        body = new JSONObject();
        body.put(AbsServerManager.PACKAGE_QUERY_BINDER, packageName2);
        body.put(PluginConstants.KEY_SDK_VERSION, string3);
        body.put("os", "android");
        body.put("os_version", Build.VERSION.RELEASE);
        String url2 = com.bytedance.ads.convert.flat.e.a.c;
        Intrinsics.checkNotNullParameter(url2, "url");
        Intrinsics.checkNotNullParameter(body, "body");
        Intrinsics.checkNotNullParameter("Convert:Config", "tag");
    }
}
