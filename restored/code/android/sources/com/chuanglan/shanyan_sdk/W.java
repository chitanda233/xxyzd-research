package com.chuanglan.shanyan_sdk;

import android.content.Context;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class W {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile W f1959a;

    private W() {
    }

    public static W a() {
        if (f1959a == null) {
            synchronized (W.class) {
                if (f1959a == null) {
                    f1959a = new W();
                }
            }
        }
        return f1959a;
    }

    public Map a(String str, Context context) {
        HashMap map = new HashMap();
        String strA = AbstractC0598d.a();
        String strC = C0616v.g().c(context);
        String strD = C0616v.g().d(context);
        String str2 = C0616v.g().b() + "|" + C0616v.g().f() + "|" + C0616v.g().a();
        map.put("i9", strD);
        map.put("i1", str);
        map.put("i3", AbstractC0606l.A);
        map.put("i8", strC);
        map.put("i2", strA);
        map.put("i5", "2.3.7.5");
        map.put("i6", str2);
        map.put("i7", AbstractC0596b.a(map, AbstractC0596b.b(str)));
        return map;
    }

    public Map a(String str, String str2, JSONObject jSONObject, Context context) {
        String strC = C0616v.g().c(context);
        String strD = C0616v.g().d(context);
        HashMap map = new HashMap();
        map.put("a7", str);
        map.put("a5", str2);
        map.put("a8", jSONObject);
        map.put("ab", strC);
        map.put("ac", strD);
        return map;
    }
}
