package com.chuanglan.shanyan_sdk;

import android.app.Application;
import android.content.Context;
import android.os.Handler;
import android.os.HandlerThread;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingDeque;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class A {
    private static volatile A n;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1930a;
    private String b;
    private I c;
    private List d;
    private List e;
    private ExecutorService i;
    private boolean f = false;
    private int g = 10000;
    private int h = 1;
    private long j = 100;
    private int k = 0;
    private AtomicBoolean l = new AtomicBoolean(false);
    private final C0618x.c m = new a();

    class a implements C0618x.c {
        a() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() throws Throwable {
            Q.a("ActivityLifecycleShanYanLogger", "enterBackground");
            A.this.d();
        }

        @Override // com.chuanglan.shanyan_sdk.C0618x.c
        public void a() {
            A.this.f().execute(new Runnable() { // from class: com.chuanglan.shanyan_sdk.A$a$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() throws Throwable {
                    this.f$0.b();
                }
            });
        }
    }

    class b extends AbstractC0599e {
        final /* synthetic */ boolean b;
        final /* synthetic */ JSONObject c;
        final /* synthetic */ String d;

        b(boolean z, JSONObject jSONObject, String str) {
            this.b = z;
            this.c = jSONObject;
            this.d = str;
        }

        @Override // com.chuanglan.shanyan_sdk.AbstractC0599e
        public void a(String str) throws Throwable {
            A.this.a(str, this.b);
        }

        @Override // com.chuanglan.shanyan_sdk.AbstractC0607m
        public void a(String str, String str2) throws Throwable {
            A.this.a(str, str2, this.c, this.b, this.d);
        }
    }

    private A() {
    }

    /* JADX WARN: Code duplicated, block: B:15:0x0088 A[PHI: r1
  0x0088: PHI (r1v5 int) = (r1v7 int), (r1v8 int) binds: [B:14:0x0086, B:11:0x0081] A[DONT_GENERATE, DONT_INLINE]] */
    private void c(int i, int i2, String str, String str2, String str3, int i3, int i4, int i5, long j, long j2, long j3, boolean z, int i6) throws Throwable {
        int i7;
        boolean z2;
        long jA = p0.a(this.f1930a, "cl_jm_b9", 600L);
        Q.a("NetworkShanYanLogger", "full params", Long.valueOf(jA), Integer.valueOf(i3), Integer.valueOf(i4), Integer.valueOf(i), Boolean.valueOf(AbstractC0606l.B), str2, Integer.valueOf(i5));
        if (jA == -1 || !AbstractC0606l.B) {
            return;
        }
        C0619y c0619yA = a(i, i2, str, str2, str3, i3, i4, i5, j, j2, j3, i6);
        if (i4 == 1 && i5 == 0) {
            i7 = i3;
            if (i7 != 4) {
                z2 = true;
            }
            a(c0619yA, z2);
            if (i7 == 1 || this.l.getAndSet(true)) {
            }
            a(jA);
            return;
        }
        i7 = i3;
        if (z) {
            z2 = true;
        } else {
            z2 = false;
        }
        a(c0619yA, z2);
        if (i7 == 1) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d() throws Throwable {
        try {
            this.j = p0.a(this.f1930a, "cl_jm_b8", 100L);
            I i = this.c;
            if (i != null) {
                long jC = i.c();
                Q.a("NetworkShanYanLogger", "full reportCount", Long.valueOf(this.j), Long.valueOf(jC));
                if (jC > 0) {
                    this.h = (int) Math.ceil(jC / this.j);
                    Q.a("NetworkShanYanLogger", "full reportCount", Long.valueOf(this.j), Integer.valueOf(this.h));
                    k();
                    this.f = false;
                }
            }
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Background report execution failed", e);
        }
    }

    private String e() {
        String strA = p0.a(this.f1930a, "cl_jm_c3", "");
        return AbstractC0600f.b(strA) ? strA : this.b;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public ExecutorService f() {
        ExecutorService executorService = this.i;
        if (executorService == null || executorService.isShutdown()) {
            this.i = new ThreadPoolExecutor(1, Integer.MAX_VALUE, 120L, TimeUnit.SECONDS, new LinkedBlockingDeque());
        }
        return this.i;
    }

    public static A g() {
        if (n == null) {
            synchronized (A.class) {
                if (n == null) {
                    n = new A();
                }
            }
        }
        return n;
    }

    private long h() {
        long jA = p0.a(this.f1930a, "cl_jm_e2", 1L);
        if (jA != 1) {
            return jA;
        }
        long jCurrentTimeMillis = System.currentTimeMillis();
        p0.b(this.f1930a, "cl_jm_e2", jCurrentTimeMillis);
        return jCurrentTimeMillis;
    }

    private void i() {
        Context context;
        if (this.c != null || (context = this.f1930a) == null) {
            return;
        }
        this.c = new I(context);
    }

    private void j() {
        Iterator it = Arrays.asList("sysdk.cl2009.com", "sylogs.cl2009.com").iterator();
        while (it.hasNext()) {
            a((String) it.next());
        }
        String strA = p0.a(this.f1930a, "cl_jm_g4", "");
        if (AbstractC0600f.b(strA)) {
            a(strA);
        }
        String strB = new h0().b();
        if (strB != null) {
            Q.c("NetworkShanYanLogger", "log list", AbstractC0606l.N);
            n0.b = "https://" + strB + "/log/fdr/v3";
        }
        Q.a("NetworkShanYanLogger", "log upload", strB, Boolean.valueOf(this.f));
    }

    private void k() throws Throwable {
        try {
            Q.c("NetworkShanYanLogger", "nonRealTimeReport");
            p0.b(this.f1930a, "cl_jm_e2", System.currentTimeMillis());
            this.d = new ArrayList();
            long jA = p0.a(this.f1930a, "cl_jm_b8", 100L);
            this.j = jA;
            this.d.addAll(this.c.a(String.valueOf(jA)));
            ArrayList arrayList = new ArrayList();
            this.e = arrayList;
            arrayList.addAll(this.c.a());
            a(true);
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Report upload failed", e);
        }
    }

    private boolean l() {
        if (!AbstractC0606l.B || !AbstractC0606l.D) {
            return false;
        }
        long jA = p0.a(this.f1930a, "cl_jm_b9", 600L);
        return (jA == -1 || jA == 0 || !"1".equals(p0.a(this.f1930a, "cl_jm_c1", "1"))) ? false : true;
    }

    private void m() throws Throwable {
        this.j = p0.a(this.f1930a, "cl_jm_b8", 100L);
        I i = this.c;
        if (i == null || i.c() <= 0) {
            return;
        }
        this.h = (int) Math.ceil(this.c.c() / this.j);
        k();
        this.f = false;
    }

    public void b(Context context) {
        if (context != null) {
            C0618x.e().b((Application) context, this.m);
            C0618x.c();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(int i, int i2, String str, String str2, String str3, int i3, int i4, int i5, long j, long j2, long j3, boolean z, int i6) throws Throwable {
        try {
            if (this.f1930a != null) {
                c(i, i2, str, str2, str3, i3, i4, i5, j, j2, j3, z, i6);
            }
        } catch (Exception e) {
            e.printStackTrace();
            Q.b("NetworkShanYanLogger", "Full report processing failed", e);
        }
    }

    public void a(Context context, String str) {
        this.f1930a = context.getApplicationContext();
        this.b = str;
    }

    public void a() {
        try {
            if (l()) {
                Q.a("ActivityLifecycleShanYanLogger", "shouldEnable");
                if (this.f1930a != null) {
                    C0618x.e().b((Application) this.f1930a, this.m);
                    C0618x.e().a((Application) this.f1930a, this.m);
                }
            }
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Background report setup failed", e);
        }
    }

    private void b(JSONObject jSONObject) {
        JSONArray jSONArrayOptJSONArray;
        try {
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("r3");
            if (jSONObjectOptJSONObject != null && (jSONArrayOptJSONArray = jSONObjectOptJSONObject.optJSONArray("r4")) != null && jSONArrayOptJSONArray.length() != 0) {
                String strOptString = ((JSONObject) jSONArrayOptJSONArray.get(0)).optString("r8");
                if (AbstractC0600f.a(strOptString)) {
                    return;
                }
                boolean zOptBoolean = jSONObjectOptJSONObject.optBoolean("r5");
                p0.b(this.f1930a, "cl_jm_b1", strOptString);
                p0.b(this.f1930a, "cl_jm_a7", zOptBoolean);
                if (zOptBoolean) {
                    AbstractC0606l.M.remove(strOptString);
                    AbstractC0606l.M.add(0, strOptString);
                } else if (!AbstractC0606l.M.contains(strOptString)) {
                    AbstractC0606l.M.add(strOptString);
                }
            }
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Domain initialization failed", e);
        }
    }

    public void a(Context context) {
        if (context != null) {
            this.f1930a = context.getApplicationContext();
            C0618x.e().a((Application) context, this.m);
        }
    }

    public void a(final int i, final int i2, final String str, final String str2, final String str3, final int i3, final int i4, final int i5, final long j, final long j2, final long j3, final boolean z, final int i6) {
        f().execute(new Runnable() { // from class: com.chuanglan.shanyan_sdk.A$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() throws Throwable {
                this.f$0.b(i, i2, str, str2, str3, i3, i4, i5, j, j2, j3, z, i6);
            }
        });
    }

    private C0619y a(int i, int i2, String str, String str2, String str3, int i3, int i4, int i5, long j, long j2, long j3, int i6) {
        C0619y c0619y = new C0619y();
        c0619y.b = str3;
        c0619y.h = p0.a(this.f1930a, "cl_jm_a2", "");
        c0619y.d = "JC";
        c0619y.e = C0616v.g().f();
        c0619y.f = C0616v.g().h();
        c0619y.g = "2.3.7.5";
        c0619y.m = i3;
        c0619y.n = i4;
        c0619y.o = j;
        c0619y.p = j3;
        c0619y.q = j2;
        c0619y.r = i5;
        c0619y.s = i;
        c0619y.t = AbstractC0600f.a(i, str);
        c0619y.u = i2;
        c0619y.v = str2;
        c0619y.w = i6;
        c0619y.k = "-1";
        c0619y.l = "-1";
        c0619y.c = -1;
        c0619y.i = "-1";
        c0619y.j = "-1";
        if (i3 == 4 || i3 == 11) {
            a(c0619y, i5);
        }
        return c0619y;
    }

    private C0620z c() {
        C0620z c0620z = new C0620z();
        c0620z.b = "2";
        c0620z.c = C0616v.g().a();
        c0620z.d = C0616v.g().b();
        c0620z.e = p0.a(this.f1930a, v0.f2017a, "-1");
        c0620z.f2037a = p0.a(this.f1930a, "cl_jm_a3", "");
        return c0620z;
    }

    private void b() throws Throwable {
        try {
            I i = this.c;
            if (i == null || !i.a(this.g)) {
                return;
            }
            this.c.a(String.valueOf((int) (((double) this.g) * 0.1d)));
            I i2 = this.c;
            i2.a(i2.b());
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "DB count check failed", e);
        }
    }

    private void a(C0619y c0619y, int i) {
        c0619y.i = C0616v.g().d();
        c0619y.j = String.valueOf(AbstractC0610p.j(this.f1930a));
        if (AbstractC0606l.O && !"-1".equals(p0.a(this.f1930a, "cl_jm_d4", "0"))) {
            c0619y.c = C0616v.g().e(this.f1930a);
        }
        if (AbstractC0610p.g(this.f1930a)) {
            c0619y.k = "0";
        }
        if (AbstractC0610p.c(this.f1930a)) {
            c0619y.l = "0";
        }
        if (i == 1) {
            p0.b(this.f1930a, "cl_jm_a2", "");
        }
    }

    private void a(long j) {
        if (j != 0) {
            long j2 = Long.parseLong(p0.a(this.f1930a, "cl_jm_b7", "120"));
            if (j2 > 0) {
                HandlerThread handlerThread = new HandlerThread("ReportHandlerThread");
                handlerThread.start();
                new Handler(handlerThread.getLooper()).postDelayed(new Runnable() { // from class: com.chuanglan.shanyan_sdk.A$$ExternalSyntheticLambda1
                    @Override // java.lang.Runnable
                    public final void run() throws Throwable {
                        this.f$0.d();
                    }
                }, j2 * 1000);
            }
        }
    }

    private void a(C0619y c0619y, boolean z) throws Throwable {
        if (AbstractC0606l.B) {
            try {
                i();
                C0620z c0620zC = c();
                c0619y.f2036a = c0620zC.f2037a;
                c0619y.x = p0.a(this.f1930a, "cl_jm_f5", "-1");
                long jA = p0.a(this.f1930a, "cl_jm_b9", 600L);
                if (jA == -1) {
                    return;
                }
                long jH = h();
                if (jA == 0) {
                    a(c0620zC, c0619y);
                } else {
                    this.c.a(c0620zC);
                    this.c.a(c0619y, z);
                    if (a(c0619y.m, jH, jA)) {
                        m();
                    }
                }
            } catch (Exception e) {
                Q.b("NetworkShanYanLogger", "Full report failed", e);
            }
        }
    }

    private boolean a(int i, long j, long j2) {
        return i == 4 || i == 11 || System.currentTimeMillis() > j + (j2 * 1000);
    }

    private void a(C0620z c0620z, C0619y c0619y) throws Throwable {
        try {
            ArrayList arrayList = new ArrayList();
            this.d = arrayList;
            arrayList.add(c0619y);
            ArrayList arrayList2 = new ArrayList();
            this.e = arrayList2;
            arrayList2.add(c0620z);
            a(false);
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Real-time report upload failed", e);
        }
    }

    private void a(boolean z) throws Throwable {
        Q.c("NetworkShanYanLogger", "reportUpload");
        List list = this.d;
        if (list == null || this.e == null || list.isEmpty() || this.e.isEmpty()) {
            return;
        }
        JSONArray jSONArrayA = AbstractC0596b.a(this.d);
        JSONArray jSONArrayB = AbstractC0596b.b(this.e);
        Q.c("NetworkShanYanLogger", "deviceJsonArray");
        if (jSONArrayA.length() == 0 || jSONArrayB.length() == 0) {
            return;
        }
        JSONObject jSONObject = new JSONObject();
        jSONObject.put("a4", jSONArrayA);
        jSONObject.put("a2", new JSONArray("[\"i4\", \"bk\",\"bp\", \"bm\", \"b2\", \"bc\", \"bh\", \"ba\", \"b7\", \"bi\", \"b8\",\"bg\", \"bj\", \"bb\", \"bl\", \"b5\", \"b1\", \"b4\", \"be\", \"b3\", \"b6\", \"bd\", \"b9\", \"bf\"]"));
        jSONObject.put("a3", jSONArrayB);
        jSONObject.put("a1", new JSONArray("[\"i4\", \"i8\", \"i1\", \"i7\", \"i9\"]"));
        Q.c("NetworkShanYanLogger", "full upload", Boolean.valueOf(z), Integer.valueOf(jSONArrayA.length()), Integer.valueOf(this.d.size()), Integer.valueOf(jSONArrayB.length()), Integer.valueOf(this.e.size()));
        j();
        a(new C0602h(n0.b, this.f1930a), jSONObject, z, "");
    }

    private void a(String str) {
        if (AbstractC0606l.N.contains(str)) {
            return;
        }
        AbstractC0606l.N.add(str);
    }

    private void a(C0602h c0602h, JSONObject jSONObject, boolean z, String str) throws Throwable {
        this.g = p0.a(this.f1930a, "cl_jm_b4", 10000);
        if (AbstractC0600f.a(str)) {
            str = AbstractC0598d.a();
        }
        String strE = e();
        Q.a("ProcessShanYanLogger", "log request id", strE);
        if (AbstractC0600f.b(strE)) {
            String strA = p0.a(this.f1930a, "cl_jm_d2", "0MFwwDQYJKoZIhvcNAQEBBQADSwAwSAJBAJaqWkyQhbQ6EbYBFaxhfblDc3wmzSV27D/CncV6b1dG9DW/9rPqKLP9TvpcxA8OTgQR/WZ1YKwtcHJurR83spkCAwEAAQ==");
            Map mapA = W.a().a(strE, str, jSONObject, this.f1930a);
            Q.c("NetworkShanYanLogger", "map", mapA);
            c0602h.a(mapA, new b(z, jSONObject, str), Boolean.TRUE, strA);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, boolean z) throws Throwable {
        try {
            Q.c("NetworkShanYanLogger", "onSuccess", str);
            if (AbstractC0600f.a(str)) {
                if (z) {
                    b();
                    return;
                }
                return;
            }
            JSONObject jSONObject = new JSONObject(str);
            if (jSONObject.optInt("r1") == 0) {
                if (z) {
                    a(jSONObject);
                }
                b(jSONObject);
            } else if (z) {
                b();
            }
        } catch (JSONException e) {
            Q.b("NetworkShanYanLogger", "Response parsing failed", e);
            if (z) {
                b();
            }
        }
    }

    private void a(JSONObject jSONObject) throws Throwable {
        int i;
        I i2 = this.c;
        if (i2 != null) {
            i2.a(i2.b());
            this.h--;
        }
        if (this.h <= 0 || (i = this.k) >= 10) {
            return;
        }
        this.k = i + 1;
        k();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, JSONObject jSONObject, boolean z, String str3) throws Throwable {
        try {
            Q.c("NetworkShanYanLogger", "onFailure", str, str2);
            if (!this.f) {
                this.f = true;
                C0602h c0602h = new C0602h("https://sylogs.cl2009.com/log/fdr/v3", this.f1930a);
                Q.a("NetworkShanYanLogger", "log again", "sylogs.cl2009.com", Boolean.valueOf(this.f));
                a(c0602h, jSONObject, z, str3);
            } else if (z) {
                b();
            }
        } catch (Exception e) {
            Q.b("NetworkShanYanLogger", "Failure handling failed", e);
        }
    }
}
