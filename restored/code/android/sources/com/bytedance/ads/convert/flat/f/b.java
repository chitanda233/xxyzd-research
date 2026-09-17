package com.bytedance.ads.convert.flat.f;

import android.app.ActivityManager;
import android.content.Context;
import android.content.SharedPreferences;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.os.StatFs;
import android.os.SystemClock;
import android.provider.Settings;
import android.text.TextUtils;
import android.util.Log;
import com.baidu.mobads.sdk.internal.an;
import com.baidu.mobads.sdk.internal.bd;
import com.baidu.mobads.sdk.internal.bn;
import com.byazt.hv.TTDownloadField;
import com.byazt.nys.PluginConstants;
import com.byazt.tk.AdBaseConstants;
import com.bytedance.ads.convert.BDConvert;
import com.bytedance.ads.convert.callback.BDConvertLifecycleCallback;
import com.bytedance.ads.convert.depend.CustomAndroidIDCallback;
import com.bytedance.ads.convert.flat.a.f;
import com.bytedance.ads.convert.flat.a.g;
import com.bytedance.ads.convert.flat.a.h;
import com.bytedance.ads.convert.flat.a.i;
import com.bytedance.ads.convert.flat.i.e;
import com.bytedance.ads.convert.hume.readapk.HumeSDK;
import com.kuaishou.weapon.p0.t;
import com.sigmob.sdk.base.n;
import java.io.File;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.Inet6Address;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.Charset;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;
import java.util.UUID;
import kotlin.io.ByteStreamsKt;
import kotlin.jvm.internal.Intrinsics;
import kotlin.text.Charsets;
import kotlin.text.StringsKt;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static JSONObject f1696a = null;
    public static volatile long b = -1;
    public static volatile String c = "";
    public static long d = -1;
    public static final a e = new a();
    public final String f;
    public String g;
    public JSONObject h;
    public final String i;

    public static final class a {
        public final void a(Context context) throws JSONException {
            String str;
            long totalBytes;
            String string;
            String string2;
            com.bytedance.ads.convert.flat.g.a<String, String> aVar;
            String string3;
            com.bytedance.ads.convert.flat.g.a<String, String> aVar2;
            com.bytedance.ads.convert.flat.i.c cVarA;
            String strName;
            String string4;
            Bundle bundle;
            Enumeration<InetAddress> inetAddresses;
            String hostAddress;
            Intrinsics.checkNotNullParameter(context, "context");
            if (b.f1696a == null) {
                com.bytedance.ads.convert.flat.d.b bVar = com.bytedance.ads.convert.flat.d.b.b;
                com.bytedance.ads.convert.flat.d.d config = new com.bytedance.ads.convert.flat.d.d(new f(false, null, null, null, 15), false);
                Intrinsics.checkNotNullParameter(context, "context");
                Intrinsics.checkNotNullParameter(config, "config");
                try {
                    NetworkInterface byName = NetworkInterface.getByName("wlan0");
                    if (byName == null || (inetAddresses = byName.getInetAddresses()) == null) {
                        str = null;
                    } else {
                        str = null;
                        while (inetAddresses.hasMoreElements()) {
                            try {
                                InetAddress inetAddressNextElement = inetAddresses.nextElement();
                                if ((inetAddressNextElement instanceof Inet6Address) && inetAddressNextElement.isLinkLocalAddress() && (hostAddress = inetAddressNextElement.getHostAddress()) != null && StringsKt.startsWith$default(hostAddress, "fe80", false, 2, (Object) null)) {
                                    str = hostAddress;
                                }
                            } catch (Throwable th) {
                                th = th;
                                th.printStackTrace();
                            }
                        }
                    }
                } catch (Throwable th2) {
                    th = th2;
                    str = null;
                }
                com.bytedance.ads.convert.flat.d.c cVar = com.bytedance.ads.convert.flat.d.b.f1688a;
                if (str == null) {
                    str = "";
                }
                cVar.getClass();
                Intrinsics.checkNotNullParameter(str, "<set-?>");
                cVar.f1689a = str;
                long jCurrentTimeMillis = System.currentTimeMillis() - SystemClock.elapsedRealtime();
                com.bytedance.ads.convert.flat.d.c cVar2 = com.bytedance.ads.convert.flat.d.b.f1688a;
                String strValueOf = String.valueOf(jCurrentTimeMillis);
                cVar2.getClass();
                Intrinsics.checkNotNullParameter(strValueOf, "<set-?>");
                cVar2.d = strValueOf;
                try {
                    File externalStorageDirectory = Environment.getExternalStorageDirectory();
                    Intrinsics.checkNotNullExpressionValue(externalStorageDirectory, "Environment.getExternalStorageDirectory()");
                    totalBytes = new StatFs(externalStorageDirectory.getPath()).getTotalBytes();
                } catch (Throwable unused) {
                    totalBytes = -1;
                }
                com.bytedance.ads.convert.flat.d.c cVar3 = com.bytedance.ads.convert.flat.d.b.f1688a;
                String strValueOf2 = String.valueOf(totalBytes);
                cVar3.getClass();
                Intrinsics.checkNotNullParameter(strValueOf2, "<set-?>");
                cVar3.b = strValueOf2;
                Intrinsics.checkNotNullParameter(context, "context");
                ActivityManager.MemoryInfo memoryInfo = new ActivityManager.MemoryInfo();
                Object systemService = context.getSystemService(TTDownloadField.TT_ACTIVITY);
                if (systemService instanceof ActivityManager) {
                    ((ActivityManager) systemService).getMemoryInfo(memoryInfo);
                }
                com.bytedance.ads.convert.flat.d.c cVar4 = com.bytedance.ads.convert.flat.d.b.f1688a;
                String strValueOf3 = String.valueOf(memoryInfo.totalMem);
                cVar4.getClass();
                Intrinsics.checkNotNullParameter(strValueOf3, "<set-?>");
                cVar4.c = strValueOf3;
                Intrinsics.checkNotNullParameter(context, "context");
                JSONArray jSONArray = new JSONArray();
                try {
                    HashMap map = new HashMap();
                    map.put("com.ss.android.ugc.aweme", "a");
                    map.put("com.ss.android.ugc.aweme.lite", "al");
                    map.put("com.dragon.read", t.k);
                    map.put("com.ss.android.article.news", "n");
                    map.put("com.ss.android.article.lite", "nl");
                    PackageManager packageManager = context.getPackageManager();
                    Set<Map.Entry> setEntrySet = map.entrySet();
                    Intrinsics.checkNotNullExpressionValue(setEntrySet, "appPackageNameList.entries");
                    for (Map.Entry entry : setEntrySet) {
                        try {
                            PackageInfo packageInfo = packageManager.getPackageInfo((String) entry.getKey(), 0);
                            long j = packageInfo.firstInstallTime;
                            JSONObject jSONObject = new JSONObject();
                            jSONObject.put("n", entry.getValue());
                            jSONObject.put(t.e, j);
                            if (Intrinsics.areEqual((String) entry.getValue(), "a") || Intrinsics.areEqual((String) entry.getValue(), "n")) {
                                jSONObject.put("u", packageInfo.lastUpdateTime);
                            }
                            jSONArray.put(jSONObject);
                        } catch (Throwable unused2) {
                        }
                    }
                    com.bytedance.ads.convert.flat.d.c cVar5 = com.bytedance.ads.convert.flat.d.b.f1688a;
                    cVar5.getClass();
                    Intrinsics.checkNotNullParameter(jSONArray, "<set-?>");
                    cVar5.e = jSONArray;
                } catch (Throwable unused3) {
                }
                if (config.b) {
                    bVar.a();
                }
                com.bytedance.ads.convert.flat.d.b.f1688a = new com.bytedance.ads.convert.flat.d.c(com.bytedance.ads.convert.flat.d.b.f1688a);
                h.c.a(config.f1692a);
                if (config.f1692a.f1679a) {
                    com.bytedance.ads.convert.flat.d.a aVar3 = new com.bytedance.ads.convert.flat.d.a();
                    Intrinsics.checkNotNullParameter(context, "context");
                    new Thread(new g(context, aVar3)).start();
                }
                com.bytedance.ads.convert.flat.d.c cVar6 = com.bytedance.ads.convert.flat.d.b.f1688a;
                Intrinsics.checkNotNullParameter(context, "context");
                new Thread(new com.bytedance.ads.convert.flat.f.a(context)).start();
                String packageName = context.getPackageName();
                PackageManager packageManager2 = context.getPackageManager();
                ApplicationInfo applicationInfo = packageManager2 != null ? packageManager2.getApplicationInfo(packageName, 128) : null;
                if (applicationInfo == null || (bundle = applicationInfo.metaData) == null || (string = bundle.getString("hume_convert.AppConvert.sdk.version")) == null) {
                    string = "0";
                }
                String str2 = string;
                Intrinsics.checkNotNullExpressionValue(str2, "applicationInfo?.metaDat…vert.sdk.version\") ?: \"0\"");
                Intrinsics.checkNotNullParameter(context, "context");
                String str3 = com.bytedance.ads.convert.flat.i.a.f1701a;
                if (TextUtils.isEmpty(str3)) {
                    try {
                        BDConvert bDConvert = BDConvert.INSTANCE;
                        if (bDConvert.getConfig().getCustomAndroidIDCallback() != null) {
                            CustomAndroidIDCallback customAndroidIDCallback = bDConvert.getConfig().getCustomAndroidIDCallback();
                            if (customAndroidIDCallback == null || (string2 = customAndroidIDCallback.get()) == null) {
                                string2 = "";
                            }
                        } else {
                            string2 = Settings.Secure.getString(context.getContentResolver(), "android_id");
                            Intrinsics.checkNotNullExpressionValue(string2, "Settings.Secure.getStrin…ttings.Secure.ANDROID_ID)");
                        }
                        str3 = string2;
                        com.bytedance.ads.convert.flat.i.a.f1701a = str3;
                    } catch (Exception e) {
                        BDConvertLifecycleCallback lifecycleCallback = BDConvert.INSTANCE.getConfig().getLifecycleCallback();
                        if (lifecycleCallback != null) {
                            lifecycleCallback.onOtherError(6, e);
                        }
                    }
                }
                synchronized (com.bytedance.ads.convert.flat.i.b.b) {
                    Intrinsics.checkNotNullParameter(context, "context");
                    aVar = com.bytedance.ads.convert.flat.i.b.f1702a;
                    if (aVar == null) {
                        SharedPreferences sharedPreferences = context.getSharedPreferences("sp_name_app_unique_id", 0);
                        String string5 = sharedPreferences.getString("app_unique_id", "NULL");
                        if (!Intrinsics.areEqual("NULL", string5)) {
                            com.bytedance.ads.convert.flat.g.a<String, String> aVar4 = new com.bytedance.ads.convert.flat.g.a<>(sharedPreferences.getString("app_unique_id_source", "NULL"), string5);
                            com.bytedance.ads.convert.flat.i.b.f1702a = aVar4;
                            aVar = aVar4;
                        } else {
                            Intrinsics.checkNotNullParameter(context, "context");
                            String str4 = com.bytedance.ads.convert.flat.i.a.f1701a;
                            if (TextUtils.isEmpty(str4)) {
                                try {
                                    BDConvert bDConvert2 = BDConvert.INSTANCE;
                                    if (bDConvert2.getConfig().getCustomAndroidIDCallback() != null) {
                                        CustomAndroidIDCallback customAndroidIDCallback2 = bDConvert2.getConfig().getCustomAndroidIDCallback();
                                        if (customAndroidIDCallback2 == null || (string3 = customAndroidIDCallback2.get()) == null) {
                                            string3 = "";
                                        }
                                    } else {
                                        string3 = Settings.Secure.getString(context.getContentResolver(), "android_id");
                                        Intrinsics.checkNotNullExpressionValue(string3, "Settings.Secure.getStrin…ttings.Secure.ANDROID_ID)");
                                    }
                                    str4 = string3;
                                    com.bytedance.ads.convert.flat.i.a.f1701a = str4;
                                } catch (Exception e2) {
                                    BDConvertLifecycleCallback lifecycleCallback2 = BDConvert.INSTANCE.getConfig().getLifecycleCallback();
                                    if (lifecycleCallback2 != null) {
                                        lifecycleCallback2.onOtherError(6, e2);
                                    }
                                }
                            }
                            if (str4.length() > 0) {
                                aVar2 = new com.bytedance.ads.convert.flat.g.a<>("android_id", str4);
                            } else {
                                String string6 = UUID.randomUUID().toString();
                                Intrinsics.checkNotNullExpressionValue(string6, "UUID.randomUUID().toString()");
                                String strReplace$default = StringsKt.replace$default(string6, "-", "", false, 4, (Object) null);
                                if (strReplace$default == null) {
                                    throw new NullPointerException("null cannot be cast to non-null type java.lang.String");
                                }
                                String strSubstring = strReplace$default.substring(0, 16);
                                Intrinsics.checkNotNullExpressionValue(strSubstring, "(this as java.lang.Strin…ing(startIndex, endIndex)");
                                aVar2 = new com.bytedance.ads.convert.flat.g.a<>("random_id", strSubstring);
                            }
                            com.bytedance.ads.convert.flat.i.b.f1702a = aVar2;
                            SharedPreferences.Editor editorEdit = sharedPreferences.edit();
                            com.bytedance.ads.convert.flat.g.a<String, String> aVar5 = com.bytedance.ads.convert.flat.i.b.f1702a;
                            SharedPreferences.Editor editorPutString = editorEdit.putString("app_unique_id_source", aVar5 != null ? aVar5.f1699a : null);
                            com.bytedance.ads.convert.flat.g.a<String, String> aVar6 = com.bytedance.ads.convert.flat.i.b.f1702a;
                            editorPutString.putString("app_unique_id", aVar6 != null ? aVar6.b : null).apply();
                            aVar = com.bytedance.ads.convert.flat.i.b.f1702a;
                        }
                    }
                }
                com.bytedance.ads.convert.flat.g.a<String, String> aVar7 = aVar;
                JSONObject jSONObject2 = (JSONObject) cVar6.h.getValue();
                com.bytedance.ads.convert.flat.i.d dVar = com.bytedance.ads.convert.flat.i.d.f1704a;
                Intrinsics.checkNotNullParameter(context, "context");
                SharedPreferences sharedPreferences2 = context.getSharedPreferences("sp_name_bd_convert_hume_sdk", 0);
                if (sharedPreferences2.getBoolean("has_read", false)) {
                    cVarA = dVar.a(context);
                } else {
                    try {
                        String extra = HumeSDK.getExtra(context);
                        Intrinsics.checkNotNullExpressionValue(extra, "HumeSDK.getExtra(context)");
                        int length = extra.length() - 1;
                        int i = 0;
                        boolean z = false;
                        while (i <= length) {
                            boolean z2 = Intrinsics.compare((int) extra.charAt(!z ? i : length), 32) <= 0;
                            if (z) {
                                if (!z2) {
                                    break;
                                } else {
                                    length--;
                                }
                            } else if (z2) {
                                i++;
                            } else {
                                z = true;
                            }
                        }
                        String string7 = extra.subSequence(i, length + 1).toString();
                        if (TextUtils.isEmpty(string7)) {
                            sharedPreferences2.edit().putBoolean("has_read", true).apply();
                            cVarA = dVar.a(context);
                        } else {
                            JSONObject jSONObject3 = new JSONObject(string7);
                            com.bytedance.ads.convert.flat.i.c cVar7 = new com.bytedance.ads.convert.flat.i.c(jSONObject3.optString(AdBaseConstants.MARKET_OPEN_CLICK_ID), jSONObject3.optString("click_id_nature"), jSONObject3.optString("hume_channel_id"), com.bytedance.ads.convert.flat.i.f.APK);
                            dVar.a(context, cVar7);
                            cVarA = cVar7;
                        }
                    } catch (JSONException e3) {
                        e3.printStackTrace();
                    }
                }
                Intrinsics.checkNotNullParameter("Convert:Event", "tag");
                Intrinsics.checkNotNullParameter("click_id fetch", "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d("Convert:Event", "click_id fetch");
                }
                String str5 = cVarA.b;
                if (str5 == null) {
                    str5 = "";
                }
                jSONObject2.put(AdBaseConstants.MARKET_OPEN_CLICK_ID, str5);
                com.bytedance.ads.convert.flat.i.f fVar = cVarA.e;
                if (fVar == null) {
                    strName = null;
                } else {
                    Intrinsics.checkNotNull(fVar);
                    strName = fVar.name();
                }
                if (strName == null) {
                    strName = "";
                }
                jSONObject2.put("click_id_source", strName);
                String str6 = cVarA.c;
                if (str6 == null) {
                    str6 = "";
                }
                jSONObject2.put("click_id_nature", str6);
                jSONObject2.put(bn.i, Build.MODEL);
                jSONObject2.put("device_brand", Build.BRAND);
                jSONObject2.put("os_version", "" + Build.VERSION.SDK_INT);
                jSONObject2.put("os_name", "android");
                jSONObject2.put(PluginConstants.KEY_SDK_VERSION, str2);
                String str7 = cVarA.d;
                if (str7 == null) {
                    str7 = "";
                }
                jSONObject2.put("app_channel", str7);
                jSONObject2.put("app_package", packageName);
                try {
                    PackageInfo packageInfo2 = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
                    jSONObject2.put(n.r, packageInfo2.versionName);
                    jSONObject2.put("app_install_time", String.valueOf(packageInfo2.firstInstallTime));
                } catch (PackageManager.NameNotFoundException unused4) {
                }
                jSONObject2.put("open_udid", str3);
                Intrinsics.checkNotNull(aVar7);
                jSONObject2.put("app_unique_id_source", aVar7.f1699a);
                jSONObject2.put("app_unique_id", aVar7.b);
                if (BDConvert.INSTANCE.getConfig().getEnableIPFetch()) {
                    try {
                        JSONObject jSONObject4 = new JSONObject();
                        ArrayList<NetworkInterface> list = Collections.list(NetworkInterface.getNetworkInterfaces());
                        Intrinsics.checkNotNullExpressionValue(list, "Collections.list(Network…e.getNetworkInterfaces())");
                        for (NetworkInterface networkInterface : list) {
                            ArrayList<InetAddress> list2 = Collections.list(networkInterface.getInetAddresses());
                            Intrinsics.checkNotNullExpressionValue(list2, "Collections.list(networkInterface.inetAddresses)");
                            JSONArray jSONArray2 = new JSONArray();
                            for (InetAddress inetAddress : list2) {
                                if (inetAddress instanceof Inet6Address) {
                                    jSONArray2.put(inetAddress.getHostAddress());
                                }
                            }
                            jSONObject4.put(networkInterface.getName(), jSONArray2);
                        }
                        string4 = jSONObject4.toString();
                        Intrinsics.checkNotNullExpressionValue(string4, "jsonObject.toString()");
                    } catch (Exception unused5) {
                        string4 = "{}";
                    }
                } else {
                    string4 = "{}";
                }
                jSONObject2.put("ipv6", string4);
                jSONObject2.put("oaid", b.c);
                jSONObject2.put("u_t", new JSONObject());
                b.f1696a = jSONObject2;
            }
            if (b.f1696a == null) {
                b.f1696a = new JSONObject();
            }
        }
    }

    /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.f.b$b, reason: collision with other inner class name */
    public static final class RunnableC0325b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final /* synthetic */ String f1697a;
        public final /* synthetic */ JSONObject b;
        public final /* synthetic */ String c;

        public RunnableC0325b(String str, JSONObject jSONObject, String str2) {
            this.f1697a = str;
            this.b = jSONObject;
            this.c = str2;
        }

        /* JADX WARN: Code duplicated, block: B:64:0x018b  */
        /* JADX WARN: Code duplicated, block: B:66:0x0190  */
        /* JADX WARN: Code duplicated, block: B:68:0x0195  */
        @Override // java.lang.Runnable
        public final void run() throws Throwable {
            InputStream inputStream;
            OutputStream outputStream;
            String str = "";
            String eventName = this.f1697a;
            JSONObject body = this.b;
            String tag = this.c;
            Intrinsics.checkNotNullParameter("https://analytics.oceanengine.com/sdk/app/", "url");
            Intrinsics.checkNotNullParameter(eventName, "eventName");
            Intrinsics.checkNotNullParameter(body, "body");
            Intrinsics.checkNotNullParameter(tag, "tag");
            HttpURLConnection httpURLConnection = null;
            try {
                URLConnection uRLConnectionOpenConnection = new URL("https://analytics.oceanengine.com/sdk/app/").openConnection();
                if (uRLConnectionOpenConnection == null) {
                    throw new NullPointerException("null cannot be cast to non-null type java.net.HttpURLConnection");
                }
                HttpURLConnection httpURLConnection2 = (HttpURLConnection) uRLConnectionOpenConnection;
                try {
                    httpURLConnection2.setRequestMethod("POST");
                    httpURLConnection2.setUseCaches(false);
                    httpURLConnection2.setConnectTimeout(5000);
                    httpURLConnection2.setReadTimeout(5000);
                    httpURLConnection2.setRequestProperty("enable-encrypt", "1");
                    httpURLConnection2.setRequestProperty("Content-Type", an.d);
                    httpURLConnection2.setDoOutput(true);
                    httpURLConnection2.setDoInput(true);
                    httpURLConnection2.connect();
                    outputStream = httpURLConnection2.getOutputStream();
                    try {
                        String string = e.f1705a.a(body, tag).toString();
                        Intrinsics.checkNotNullExpressionValue(string, "EncryptUtils.doInClient(body, tag).toString()");
                        Charset charset = Charsets.UTF_8;
                        if (string == null) {
                            throw new NullPointerException("null cannot be cast to non-null type java.lang.String");
                        }
                        byte[] bytes = string.getBytes(charset);
                        Intrinsics.checkNotNullExpressionValue(bytes, "(this as java.lang.String).getBytes(charset)");
                        outputStream.write(bytes);
                        outputStream.close();
                        InputStream inputStream2 = httpURLConnection2.getInputStream();
                        Intrinsics.checkNotNullExpressionValue(inputStream2, "inputStream");
                        JSONObject jSONObject = new JSONObject(new String(ByteStreamsKt.readBytes(inputStream2), Charsets.UTF_8));
                        inputStream2.close();
                        int responseCode = httpURLConnection2.getResponseCode();
                        String headerField = httpURLConnection2.getHeaderField("X-Tt-Logid");
                        if (headerField == null) {
                            headerField = "";
                        }
                        String msg = "post: response: " + responseCode + "\t" + httpURLConnection2.getHeaderField("X-Tt-Logid");
                        Intrinsics.checkNotNullParameter(tag, "tag");
                        Intrinsics.checkNotNullParameter(msg, "msg");
                        BDConvert bDConvert = BDConvert.INSTANCE;
                        if (bDConvert.getConfig().getEnableLog()) {
                            Log.d(tag, msg);
                        }
                        if (responseCode != 200) {
                            BDConvertLifecycleCallback lifecycleCallback = bDConvert.getConfig().getLifecycleCallback();
                            if (lifecycleCallback != null) {
                                lifecycleCallback.onEventSendFailure(eventName, 5, headerField, new Exception(jSONObject.toString()));
                            }
                        } else {
                            BDConvertLifecycleCallback lifecycleCallback2 = bDConvert.getConfig().getLifecycleCallback();
                            if (lifecycleCallback2 != null) {
                                lifecycleCallback2.onEventSendSuccess(eventName, headerField);
                            }
                        }
                        httpURLConnection2.disconnect();
                        outputStream.close();
                        inputStream2.close();
                    } catch (Exception e) {
                        e = e;
                        inputStream = null;
                        httpURLConnection = httpURLConnection2;
                        if (httpURLConnection != null) {
                            try {
                                try {
                                    String headerField2 = httpURLConnection.getHeaderField("X-Tt-Logid");
                                    if (headerField2 != null) {
                                        str = headerField2;
                                    }
                                } catch (Throwable th) {
                                    th = th;
                                    if (httpURLConnection != null) {
                                        httpURLConnection.disconnect();
                                    }
                                    if (outputStream != null) {
                                        outputStream.close();
                                    }
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    throw th;
                                }
                            } catch (Exception unused) {
                            }
                        }
                        BDConvert bDConvert2 = BDConvert.INSTANCE;
                        BDConvertLifecycleCallback lifecycleCallback3 = bDConvert2.getConfig().getLifecycleCallback();
                        if (lifecycleCallback3 != null) {
                            lifecycleCallback3.onEventSendFailure(eventName, 5, str, e);
                        }
                        String msg2 = "request error" + e.getMessage();
                        Intrinsics.checkNotNullParameter(tag, "tag");
                        Intrinsics.checkNotNullParameter(msg2, "msg");
                        if (bDConvert2.getConfig().getEnableLog()) {
                            Log.d(tag, msg2);
                        }
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.close();
                        }
                        if (inputStream != null) {
                            inputStream.close();
                        }
                    } catch (Throwable th2) {
                        th = th2;
                        inputStream = null;
                        httpURLConnection = httpURLConnection2;
                        if (httpURLConnection != null) {
                            httpURLConnection.disconnect();
                        }
                        if (outputStream != null) {
                            outputStream.close();
                        }
                        if (inputStream != null) {
                            inputStream.close();
                        }
                        throw th;
                    }
                } catch (Exception e2) {
                    e = e2;
                    inputStream = null;
                    outputStream = null;
                } catch (Throwable th3) {
                    th = th3;
                    inputStream = null;
                    outputStream = null;
                }
            } catch (Exception e3) {
                e = e3;
                inputStream = null;
                outputStream = null;
            } catch (Throwable th4) {
                th = th4;
                inputStream = null;
                outputStream = null;
            }
        }
    }

    public b(String eventName) {
        Intrinsics.checkNotNullParameter(eventName, "eventName");
        this.i = eventName;
        this.f = "Convert:EventReport";
    }

    public final void a(String tag) {
        Intrinsics.checkNotNullParameter(tag, "tag");
        String tag2 = this.f;
        Intrinsics.checkNotNullParameter(tag2, "tag");
        Intrinsics.checkNotNullParameter("post", "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d(tag2, "post");
        }
        JSONObject jSONObject = f1696a;
        if (jSONObject != null) {
            try {
                jSONObject.put("oaid", c);
            } catch (JSONException e2) {
                String tag3 = this.f;
                String msg = "update params failed" + e2.getMessage();
                Intrinsics.checkNotNullParameter(tag3, "tag");
                Intrinsics.checkNotNullParameter(msg, "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d(tag3, msg);
                }
            }
        }
        if (!Intrinsics.areEqual(this.g, "3")) {
            try {
                i iVarA = h.c.a();
                if (Intrinsics.areEqual(iVarA.b, "01128") && jSONObject != null) {
                    jSONObject.put("u_t", new JSONObject(iVarA.a().toString()));
                }
            } catch (Exception e3) {
                String tag4 = this.f;
                String msg2 = "update uaid params failed" + e3.getMessage();
                Intrinsics.checkNotNullParameter(tag4, "tag");
                Intrinsics.checkNotNullParameter(msg2, "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d(tag4, msg2);
                }
            }
        }
        if (jSONObject != null) {
            try {
                com.bytedance.ads.convert.flat.d.b bVar = com.bytedance.ads.convert.flat.d.b.b;
                String string = Arrays.toString(com.bytedance.ads.convert.flat.d.b.f1688a.f);
                Intrinsics.checkNotNullExpressionValue(string, "java.util.Arrays.toString(this)");
                jSONObject.put("inode", string);
            } catch (Exception e4) {
                String tag5 = this.f;
                String msg3 = "update featureV2 params failed" + e4.getMessage();
                Intrinsics.checkNotNullParameter(tag5, "tag");
                Intrinsics.checkNotNullParameter(msg3, "msg");
                if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                    Log.d(tag5, msg3);
                }
            }
        }
        StringBuilder sbAppend = new StringBuilder().append(this.i);
        String str = this.g;
        if (str == null) {
            str = "";
        }
        String string2 = sbAppend.append(str).toString();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("header", jSONObject);
            jSONObject2.put("event_name", this.i);
            jSONObject2.put("local_time", String.valueOf(System.currentTimeMillis()));
            jSONObject2.put(bd.d, String.valueOf(BDConvert.INSTANCE.getInitTime()));
            jSONObject2.put("oaid_callback_time", String.valueOf(b));
            jSONObject2.put("inode_callback_time", String.valueOf(d));
            com.bytedance.ads.convert.flat.e.a aVar = com.bytedance.ads.convert.flat.e.a.h;
            jSONObject2.put("config_callback_time", String.valueOf(com.bytedance.ads.convert.flat.e.a.g));
            jSONObject2.put("event_version", this.g);
            if (StringsKt.isBlank(com.bytedance.ads.convert.flat.i.g.b)) {
                String string3 = UUID.randomUUID().toString();
                Intrinsics.checkNotNullExpressionValue(string3, "UUID.randomUUID().toString()");
                com.bytedance.ads.convert.flat.i.g.b = string3;
            }
            jSONObject2.put("session_id", com.bytedance.ads.convert.flat.i.g.b);
            jSONObject2.put("session_num", com.bytedance.ads.convert.flat.i.g.f);
            JSONObject jSONObject3 = this.h;
            jSONObject2.put("params", jSONObject3 != null ? jSONObject3.toString() : null);
            new Thread(new RunnableC0325b(string2, jSONObject2, tag)).start();
        } catch (Exception e5) {
            e5.printStackTrace();
            String msg4 = "create request params failed, eventName: " + string2 + " error:" + e5.getMessage();
            Intrinsics.checkNotNullParameter(tag, "tag");
            Intrinsics.checkNotNullParameter(msg4, "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.d(tag, msg4);
            }
            BDConvertLifecycleCallback lifecycleCallback = BDConvert.INSTANCE.getConfig().getLifecycleCallback();
            if (lifecycleCallback != null) {
                lifecycleCallback.onEventSendFailure(string2, 4, "", e5);
            }
        }
    }
}
