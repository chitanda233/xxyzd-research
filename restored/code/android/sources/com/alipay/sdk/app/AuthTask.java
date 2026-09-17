package com.alipay.sdk.app;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.SystemClock;
import android.text.TextUtils;
import com.alipay.sdk.R;
import com.alipay.sdk.m.l.c;
import com.alipay.sdk.m.w.b;
import com.alipay.sdk.m.y.g;
import com.alipay.sdk.m.y.k;
import com.alipay.sdk.m.y.o;
import com.alipay.sdk.m.y.q;
import java.io.IOException;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class AuthTask {
    public static final Object c = k.class;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Activity f217a;
    public com.alipay.sdk.m.c0.a b;

    public class a implements k.f {
        public a() {
        }

        @Override // com.alipay.sdk.m.y.k.f
        public void a() {
            AuthTask.this.a();
        }

        @Override // com.alipay.sdk.m.y.k.f
        public void b() {
        }
    }

    public AuthTask(Activity activity) {
        this.f217a = activity;
        b.c().a(this.f217a);
        this.b = new com.alipay.sdk.m.c0.a(activity, this.f217a.getString(R.string.alipay_standard_sdk_loading_go_auth));
    }

    public synchronized String auth(String str, boolean z) {
        return innerAuth(new com.alipay.sdk.m.w.a(this.f217a, str, com.alipay.sdk.m.m.b.n), str, z);
    }

    public synchronized Map<String, String> authV2(String str, boolean z) {
        com.alipay.sdk.m.w.a aVar;
        aVar = new com.alipay.sdk.m.w.a(this.f217a, str, "authV2");
        return o.a(aVar, innerAuth(aVar, str, z));
    }

    public final k.f b() {
        return new a();
    }

    public final void c() {
        com.alipay.sdk.m.c0.a aVar = this.b;
        if (aVar != null) {
            aVar.d();
        }
    }

    /* JADX WARN: Code duplicated, block: B:18:0x00c5 A[Catch: all -> 0x013a, DONT_GENERATE, PHI: r10
  0x00c5: PHI (r10v12 java.lang.String) = (r10v2 java.lang.String), (r10v14 java.lang.String) binds: [B:17:0x00c3, B:10:0x0070] A[DONT_GENERATE, DONT_INLINE], TryCatch #1 {, blocks: (B:5:0x0009, B:6:0x000c, B:9:0x0026, B:19:0x00ce, B:18:0x00c5, B:22:0x00da, B:24:0x0126, B:25:0x012f, B:26:0x0139, B:16:0x0079, B:8:0x0020, B:15:0x0076), top: B:32:0x0009, inners: #0 }] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r0v21, types: [android.app.Activity, android.content.Context] */
    public synchronized String innerAuth(com.alipay.sdk.m.w.a aVar, String str, boolean z) {
        String strA;
        StringBuilder sb;
        long jElapsedRealtime;
        StringBuilder sbAppend;
        String string;
        String str2;
        String str3;
        StringBuilder sb2;
        String str4;
        String strA2;
        StringBuilder sbAppend2;
        String str5;
        StringBuilder sbAppend3;
        String str6;
        String strA3;
        StringBuilder sbAppend4;
        String string2;
        String str7;
        String str8;
        com.alipay.sdk.m.o.b bVarI;
        boolean zU;
        String str9 = "";
        synchronized (this) {
            if (z) {
                c();
                b.c().a(this.f217a);
                strA = com.alipay.sdk.m.l.b.a();
                com.alipay.sdk.m.l.a.a("");
                try {
                    strA = a(this.f217a, str, aVar);
                    sb = new StringBuilder("");
                } catch (Exception e) {
                    g.a(e);
                    sb = new StringBuilder("");
                } finally {
                    com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.V, str9 + SystemClock.elapsedRealtime());
                    com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.W, o.a(strA, o.f393a) + "|" + o.a(strA, o.b));
                    if (!com.alipay.sdk.m.o.b.i().u()) {
                        com.alipay.sdk.m.o.b.i().a(aVar, this.f217a, false, 1);
                    }
                    a();
                    com.alipay.sdk.m.m.a.b(this.f217a, aVar, str, aVar.d);
                }
            } else {
                b.c().a(this.f217a);
                strA = com.alipay.sdk.m.l.b.a();
                com.alipay.sdk.m.l.a.a("");
                strA = a(this.f217a, str, aVar);
                sb = new StringBuilder("");
            }
            throw th;
        }
        return strA;
    }

    public final void a() {
        com.alipay.sdk.m.c0.a aVar = this.b;
        if (aVar != null) {
            aVar.a();
        }
    }

    public final String b(Activity activity, String str, com.alipay.sdk.m.w.a aVar) {
        c();
        c cVarA = null;
        try {
            try {
                List<com.alipay.sdk.m.v.b> listA = com.alipay.sdk.m.v.b.a(new com.alipay.sdk.m.u.a().a(aVar, activity, str).c().optJSONObject(com.alipay.sdk.m.n.c.c).optJSONObject(com.alipay.sdk.m.n.c.d));
                a();
                for (int i = 0; i < listA.size(); i++) {
                    if (listA.get(i).a() == com.alipay.sdk.m.v.a.WapPay) {
                        String strA = a(aVar, listA.get(i));
                        a();
                        return strA;
                    }
                }
                a();
            } catch (Throwable th) {
                a();
                throw th;
            }
        } catch (IOException e) {
            c cVarA2 = c.a(c.NETWORK_ERROR.c());
            com.alipay.sdk.m.m.a.a(aVar, "net", e);
            cVarA = cVarA2;
            a();
        } catch (Throwable th2) {
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.C, th2);
            a();
        }
        if (cVarA == null) {
            cVarA = c.a(c.FAILED.c());
        }
        return com.alipay.sdk.m.l.b.a(cVarA.c(), cVarA.b(), "");
    }

    public final String a(Activity activity, String str, com.alipay.sdk.m.w.a aVar) {
        String strA = aVar.a(str);
        List<com.alipay.sdk.m.o.b.C0043b> listM = com.alipay.sdk.m.o.b.i().m();
        if (!com.alipay.sdk.m.o.b.i().g || listM == null) {
            listM = com.alipay.sdk.m.l.a.d;
        }
        if (q.a(aVar, (Context) this.f217a, listM, true)) {
            k kVar = new k(activity, aVar, b());
            String strA2 = kVar.a(strA, false);
            kVar.a();
            if (!TextUtils.equals(strA2, k.j) && !TextUtils.equals(strA2, k.k)) {
                return TextUtils.isEmpty(strA2) ? com.alipay.sdk.m.l.b.a() : strA2;
            }
            com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.i0);
            return b(activity, strA, aVar);
        }
        com.alipay.sdk.m.m.a.a(aVar, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.j0);
        return b(activity, strA, aVar);
    }

    public final String a(com.alipay.sdk.m.w.a aVar, com.alipay.sdk.m.v.b bVar) {
        String[] strArrC = bVar.c();
        Bundle bundle = new Bundle();
        bundle.putString("url", strArrC[0]);
        Intent intent = new Intent(this.f217a, (Class<?>) H5AuthActivity.class);
        intent.putExtras(bundle);
        com.alipay.sdk.m.w.a.C0054a.a(aVar, intent);
        this.f217a.startActivity(intent);
        Object obj = c;
        synchronized (obj) {
            try {
                obj.wait();
            } catch (InterruptedException unused) {
                return com.alipay.sdk.m.l.b.a();
            }
        }
        String strD = com.alipay.sdk.m.l.b.d();
        return TextUtils.isEmpty(strD) ? com.alipay.sdk.m.l.b.a() : strD;
    }
}
