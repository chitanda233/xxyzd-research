package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.LiveConfigKey;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.UUID;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class bp {
    public static volatile bp c;
    public static WeakReference d;
    public final ExecutorService b = Executors.newSingleThreadExecutor();

    public static Context b() {
        WeakReference weakReference = d;
        if (weakReference != null) {
            return (Context) weakReference.get();
        }
        return null;
    }

    public static String c() {
        String str = u.b;
        if (!TextUtils.isEmpty(str)) {
            return str;
        }
        return "seqEmpty" + System.currentTimeMillis() + "-" + UUID.randomUUID().toString().substring(0, 6);
    }

    public static String d() {
        if (bh.b(ap.i).booleanValue()) {
            ap.i = ao.b;
        }
        return ap.i;
    }

    public static bp e() {
        if (c == null) {
            synchronized (bp.class) {
                if (c == null) {
                    c = new bp();
                }
            }
        }
        return c;
    }

    public final void f() {
        boolean z = ap.b;
        try {
            Context contextB = b();
            String str = ao.b;
            ArrayList arrayListB = bf.b(contextB);
            ao.o = arrayListB;
            if (arrayListB.isEmpty()) {
                ao.b(b(), d(), LiveConfigKey.DEFAULT_TLS_PORT);
                ao.b(1, b(), ao.f, LiveConfigKey.DEFAULT_TLS_PORT);
            }
        } catch (Exception unused) {
            ao.o = new ArrayList();
        }
        this.b.submit(new bo(this));
    }

    public static void b(int i, Context context, String str, String str2) {
        if (str.equals("_Token_")) {
            String strConcat = str.concat("_isOk_");
            String str3 = (i == 2 || i == 3 || i == 4 || i == 5) ? "T" + i : "";
            if (bh.c(str2).booleanValue()) {
                String strB = c.b(1, context, str3, strConcat);
                if (bh.c(strB).booleanValue()) {
                    try {
                        SharedPreferences.Editor editorEdit = context.getSharedPreferences("cuAuthCacheName", 0).edit();
                        editorEdit.putString(strB, str2);
                        editorEdit.commit();
                    } catch (Exception e) {
                        e.getMessage();
                    }
                }
            }
        }
    }

    public static String b(int i, int i2, String str, int i3, int i4, int i5, String str2) {
        ak akVar = an.b;
        if (!ap.b) {
            return "";
        }
        if (bh.b(str).booleanValue()) {
            c();
        }
        try {
            LinkedHashMap linkedHashMap = new LinkedHashMap();
            linkedHashMap.put(com.alipay.sdk.m.y.o.c, Integer.valueOf(i));
            linkedHashMap.put("type", Integer.valueOf(i2));
            int i6 = 1;
            linkedHashMap.put("os", 1);
            linkedHashMap.put("apiKey", ap.j);
            linkedHashMap.put("seq", u.b);
            linkedHashMap.put("ret_code", Integer.valueOf(i3));
            linkedHashMap.put("sdk_v", "6.3.3CR001B1208");
            linkedHashMap.put("setTime", Integer.valueOf(i4));
            int i7 = ao.q;
            if (i7 != 0) {
                if (i7 != 1) {
                    i6 = i7 != 2 ? -1 : 0;
                } else {
                    i6 = 2;
                }
            }
            linkedHashMap.put("netType", Integer.valueOf(i6));
            linkedHashMap.put("newNetworkErrMsg", ao.v);
            linkedHashMap.put("access_process", new al());
            linkedHashMap.put("err_info", new am(str2, i5));
            return new JSONObject(linkedHashMap).toString();
        } catch (Exception e) {
            as.b(e);
            return "";
        }
    }
}
