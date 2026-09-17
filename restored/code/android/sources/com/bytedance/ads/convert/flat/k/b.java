package com.bytedance.ads.convert.flat.k;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.Future;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final c f1725a;
    public final e b;
    public final boolean c;
    public final Context d;
    public final AtomicBoolean e = new AtomicBoolean(false);
    public Future<d> f;
    public d g;

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final Context f1726a;

        public a(Context context) {
            this.f1726a = context;
        }

        public static /* synthetic */ com.bytedance.ads.convert.flat.n.a b(a aVar) {
            aVar.getClass();
            return null;
        }
    }

    public b(a aVar) {
        Context applicationContext = aVar.f1726a.getApplicationContext();
        this.d = applicationContext;
        c cVarA = com.bytedance.ads.convert.flat.c.b.a(applicationContext);
        this.f1725a = cVarA;
        this.c = cVarA != null ? cVarA.b(applicationContext) : false;
        this.b = new e(applicationContext);
        a.b(aVar);
    }

    public static <K, V> void a(Map<K, V> map, K k, V v) {
        if (v != null) {
            map.put(k, v);
        }
    }

    public static void a(JSONObject jSONObject, String str, Object obj) {
        if (TextUtils.isEmpty(str) || obj == null) {
            return;
        }
        try {
            jSONObject.put(str, obj);
        } catch (JSONException e) {
            String str2 = "safePutNonEmptyValue error: " + e.getMessage();
        }
    }

    public final d a(Context context, d dVar) {
        c.a aVarA;
        int iIntValue;
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        c cVar = this.f1725a;
        String string = null;
        if (cVar == null || (aVarA = cVar.a(context)) == null) {
            return null;
        }
        if (dVar != null) {
            string = dVar.b;
            Integer num = dVar.f;
            iIntValue = (num == null ? 0 : num.intValue()) + 1;
        } else {
            iIntValue = -1;
        }
        if (TextUtils.isEmpty(string)) {
            string = UUID.randomUUID().toString();
        }
        return new d(aVarA.f1727a, string, Boolean.valueOf(aVarA.b), Long.valueOf(SystemClock.elapsedRealtime() - jElapsedRealtime), Long.valueOf(System.currentTimeMillis()), Integer.valueOf(iIntValue > 0 ? iIntValue : 1), Long.valueOf(aVarA instanceof com.bytedance.ads.convert.flat.m.e.b ? ((com.bytedance.ads.convert.flat.m.e.b) aVarA).c : 0L));
    }
}
