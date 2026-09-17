package com.alipay.sdk.m.l;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import com.alipay.sdk.m.y.q;
import com.baidu.mobads.sdk.internal.cb;
import java.util.Collections;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f309a = 1010;
    public static a b;

    public interface a {
        void a(boolean z, JSONObject jSONObject, String str);
    }

    public static boolean a(com.alipay.sdk.m.w.a aVar, Context context) {
        return q.a(aVar, context, (List<com.alipay.sdk.m.o.b.C0043b>) Collections.singletonList(new com.alipay.sdk.m.o.b.C0043b("com.taobao.taobao", 0, "")), false);
    }

    public static boolean a(com.alipay.sdk.m.w.a aVar, Activity activity, int i, String str, String str2, a aVar2) {
        try {
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.u0);
            activity.startActivityForResult(new Intent(str2, Uri.parse(str)), i);
            b = aVar2;
            return true;
        } catch (Throwable th) {
            aVar2.a(false, null, "UNKNOWN_ERROR");
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.y0, th);
            return false;
        }
    }

    public static boolean a(com.alipay.sdk.m.w.a aVar, int i, int i2, Intent intent) {
        if (i != 1010 || intent == null) {
            return false;
        }
        a aVar2 = b;
        if (aVar2 == null) {
            return true;
        }
        b = null;
        if (i2 == -1) {
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.x0, intent.toUri(1));
            aVar2.a(true, q.a(intent), cb.k);
        } else if (i2 != 0) {
            com.alipay.sdk.m.m.a.b(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.w0, "" + i2);
        } else {
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.v0, intent.toUri(1));
            aVar2.a(false, null, "CANCELED");
        }
        return true;
    }
}
