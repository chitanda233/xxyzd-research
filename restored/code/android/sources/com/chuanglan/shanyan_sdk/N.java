package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.Process;
import android.os.SystemClock;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.TraceLogger;
import com.chuanglan.shanyan_sdk.listener.InitCallbacks;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingDeque;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class N {
    private static volatile N g;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private InitCallbacks f1948a;
    private String b;
    private Context c;
    private ExecutorService d;
    private ExecutorService e;
    private int f;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ long f1949a;
        final /* synthetic */ long b;

        a(long j, long j2) {
            this.f1949a = j;
            this.b = j2;
        }

        @Override // java.lang.Runnable
        public void run() throws Throwable {
            if (N.this.d == null || N.this.d.isShutdown()) {
                N.this.d = new ThreadPoolExecutor(8, Integer.MAX_VALUE, 120L, TimeUnit.SECONDS, new LinkedBlockingDeque());
            }
            N.this.d.execute(new i0().a());
            Process.setThreadPriority(-20);
            N.this.a(1, this.f1949a, this.b);
        }
    }

    class c implements TraceLogger {
        c() {
        }

        @Override // cn.com.chinatelecom.account.api.TraceLogger
        public void debug(String str, String str2) {
            Q.a("ProcessShanYanLogger", "debug s", str, "s1", str2);
        }

        @Override // cn.com.chinatelecom.account.api.TraceLogger
        public void info(String str, String str2) {
            Q.a("ProcessShanYanLogger", "info s", str, "s1", str2);
        }

        @Override // cn.com.chinatelecom.account.api.TraceLogger
        public void warn(String str, String str2, Throwable th) {
            Q.a("ProcessShanYanLogger", "warn s", str, "s1", str2, "throwable", th);
        }
    }

    private N() {
    }

    public static N b() {
        if (g == null) {
            synchronized (N.class) {
                if (g == null) {
                    g = new N();
                }
            }
        }
        return g;
    }

    private void c() {
        if (!AbstractC0606l.P) {
            a("ipv6.cl2009.com");
        } else {
            AbstractC0606l.M.remove("ipv6.cl2009.com");
            AbstractC0606l.M.add(0, "ipv6.cl2009.com");
        }
    }

    private void e() {
        a(Arrays.asList("sy.cl2m.cn", "fs.cl2009.com", "sy.new253.com", "sy.cl2009.com"));
        String strA = p0.a(this.c, "cl_jm_b1", "");
        if (AbstractC0600f.b(strA)) {
            if (p0.a(this.c, "cl_jm_a7", false)) {
                AbstractC0606l.M.add(0, strA);
            } else {
                a(strA);
            }
        }
        c();
    }

    private String f() {
        long jCurrentTimeMillis = System.currentTimeMillis();
        String strB = new g0().b();
        AbstractC0606l.z = (int) (System.currentTimeMillis() - jCurrentTimeMillis);
        Q.c("ProcessShanYanLogger", "init list", AbstractC0606l.M);
        return strB;
    }

    public void d() {
        try {
            String strA = p0.a(this.c, "cl_jm_a8", "");
            String strA2 = p0.a(this.c, "cl_jm_c9", "");
            Q.a("ProcessShanYanLogger", "start ct init", strA);
            if (P.f1953a) {
                CtAuth.getInstance().init(this.c, strA, strA2, new c());
            } else {
                CtAuth.getInstance().init(this.c, strA, strA2, null);
            }
        } catch (Throwable th) {
            th.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CtAuth init Exception", th);
        }
    }

    class b extends AbstractC0599e {
        final /* synthetic */ Map b;
        final /* synthetic */ int c;
        final /* synthetic */ long d;
        final /* synthetic */ long e;
        final /* synthetic */ long f;

        b(Map map, int i, long j, long j2, long j3) {
            this.b = map;
            this.c = i;
            this.d = j;
            this.e = j2;
            this.f = j3;
        }

        @Override // com.chuanglan.shanyan_sdk.AbstractC0599e
        public void a(String str) {
            Q.c("LogInfoShanYanLogger", "initStart params", this.b, "\nresult==", str);
            N.this.a(str, this.c, this.d, this.e, this.f);
        }

        @Override // com.chuanglan.shanyan_sdk.AbstractC0607m
        public void a(String str, String str2) throws Throwable {
            N.this.a(str, str2, this.c, this.d, this.e, this.f);
        }
    }

    public void a(Context context, String str) {
        ExecutorService executorService = this.e;
        if (executorService == null || executorService.isShutdown()) {
            this.e = new ThreadPoolExecutor(1, Integer.MAX_VALUE, 120L, TimeUnit.SECONDS, new LinkedBlockingDeque());
        }
        this.b = str;
        this.c = context;
        this.f = 0;
        AbstractC0617w.a(context);
        k0.b().a(context, this.e);
        T.a().a(context, this.e);
        E.a().a(context, str, this.e);
        C0604j.a().a(context, str, this.e);
        A.g().a(context, str);
        a();
        AbstractC0601g.d(context);
        AbstractC0601g.c(context);
    }

    private void c(String str) {
        if (!AbstractC0600f.b(str) || str.length() < 3) {
            return;
        }
        int i = Integer.parseInt(String.valueOf(str.charAt(0)));
        int i2 = Integer.parseInt(String.valueOf(str.charAt(1)));
        int i3 = Integer.parseInt(String.valueOf(str.charAt(2)));
        int iA = p0.a(this.c, "cl_jm_e3", AbstractC0612r.c);
        int iA2 = p0.a(this.c, "cl_jm_e4", AbstractC0612r.c);
        int iA3 = p0.a(this.c, "cl_jm_e5", AbstractC0612r.c);
        if (iA == i && iA2 == i2 && iA3 == i3) {
            return;
        }
        t0.h().d();
        p0.b(this.c, "cl_jm_e3", i);
        p0.b(this.c, "cl_jm_e4", i2);
        p0.b(this.c, "cl_jm_e5", i3);
    }

    private void b(String str) {
        if (str != null) {
            n0.f1990a = "https://" + str + "/flash/thin/accountInit/v3";
        }
    }

    private void a() {
        String strA = p0.a(this.c, "cl_jm_a5", "");
        if (AbstractC0600f.a(strA) || !"2.3.7.5".equals(strA)) {
            p0.b(this.c, "cl_jm_a5", "2.3.7.5");
            t0.h().a();
        }
    }

    public void a(long j, long j2) {
        a aVar = new a(j, j2);
        if (AbstractC0606l.t != AbstractC0606l.u.getAndSet(AbstractC0606l.t)) {
            this.e.execute(aVar);
        } else {
            Q.d("ExceptionShanYanLogger", "Initialization is in progress");
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r10v11 */
    /* JADX WARN: Type inference failed for: r10v12 */
    /* JADX WARN: Type inference failed for: r10v3 */
    public void a(int i, long j, long j2) throws Throwable {
        char c2;
        int i2;
        long jUptimeMillis = SystemClock.uptimeMillis();
        char c3 = 1;
        try {
            this.f1948a = new L(this.c);
            int i3 = i;
            i2 = i3;
            if (i3 == c3) {
                long j3 = jUptimeMillis;
                M.a(((long) p0.a(this.c, "cl_jm_e6", 6)) * 1000, this.f1948a, i, j, j2, j3);
                i2 = j3;
            }
            String strA = p0.a(this.c, "cl_jm_a6", "0");
            Q.a("ProcessShanYanLogger", "initStart processName", Integer.valueOf(i), "user", strA);
            try {
                if (AbstractC0600f.b(strA) && "1".equals(strA)) {
                    AbstractC0606l.B = false;
                    EnumC0611q enumC0611q = EnumC0611q.ACCOUNT_DISABLED_CODE;
                    a(enumC0611q, enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, j, j2, jUptimeMillis);
                    return;
                }
                A.g().a();
                AbstractC0606l.u.set(AbstractC0606l.t);
                boolean zA = p0.a(this.c, "cl_jm_f2", false);
                String strA2 = p0.a(this.c, "cl_jm_c3", "");
                String strA3 = p0.a(this.c, "cl_jm_e1", "");
                if (AbstractC0600f.a(this.b)) {
                    EnumC0611q enumC0611q2 = EnumC0611q.APPID_NULL_CODE;
                    a(enumC0611q2, enumC0611q2.b(), enumC0611q2.e(), enumC0611q2.c(), i, j, j2, jUptimeMillis);
                    return;
                }
                try {
                    if (zA && !AbstractC0600f.a(strA2) && this.b.equals(strA3)) {
                        if ((SystemClock.uptimeMillis() - p0.a(this.c, "cl_jm_e9", SystemClock.uptimeMillis())) / 1000 < p0.a(this.c, "cl_jm_b2", AbstractC0612r.f1996a)) {
                            InitCallbacks initCallbacks = this.f1948a;
                            EnumC0611q enumC0611q3 = EnumC0611q.INIT_CACHE_SUCCESS_CODE;
                            i2 = 2;
                            initCallbacks.initSuccessed(enumC0611q3.d(), enumC0611q3.b(), enumC0611q3.e(), enumC0611q3.c(), i, j, j2, jUptimeMillis);
                        } else {
                            i2 = 2;
                            InitCallbacks initCallbacks2 = this.f1948a;
                            EnumC0611q enumC0611q4 = EnumC0611q.INIT_CACHE_SUCCESS_CODE;
                            initCallbacks2.initSuccessed(enumC0611q4.d(), enumC0611q4.b(), enumC0611q4.e(), enumC0611q4.c(), -1, j, j2, jUptimeMillis);
                            a(i, j, j2, jUptimeMillis);
                        }
                    } else {
                        i2 = 2;
                        p0.b(this.c, "cl_jm_e1", this.b);
                        a(i, j, j2, jUptimeMillis);
                    }
                    return;
                } catch (Exception e) {
                    e = e;
                }
            } catch (Exception e2) {
                e = e2;
                c3 = c3;
                c2 = 2;
                i2 = 2;
            }
        } catch (Exception e3) {
            e = e3;
            c2 = 0;
            c3 = c3;
            i2 = 2;
        }
        e.printStackTrace();
        Object[] objArr = new Object[i2];
        objArr[c2] = "initStart Exception";
        objArr[c3] = e;
        Q.d("ExceptionShanYanLogger", objArr);
        EnumC0611q enumC0611q5 = EnumC0611q.SDK_EXCEPTION_CODE;
        a(enumC0611q5, enumC0611q5.b(), enumC0611q5.e(), "initStart--Exception_" + e, i, j, j2, jUptimeMillis);
    }

    private void a(int i, long j, long j2, long j3) throws Throwable {
        Q.a("ProcessShanYanLogger", "getOperatorInfo start");
        e();
        String strF = f();
        b(strF);
        Q.a("ProcessShanYanLogger", "init getOperatorData", strF, Integer.valueOf(this.f));
        a(new C0602h(n0.f1990a, this.c), i, j, j2, j3);
    }

    private void a(List list) {
        Iterator it = list.iterator();
        while (it.hasNext()) {
            a((String) it.next());
        }
    }

    private void a(String str) {
        if (AbstractC0606l.M.contains(str)) {
            return;
        }
        AbstractC0606l.M.add(str);
    }

    private void a(C0602h c0602h, int i, long j, long j2, long j3) throws Throwable {
        Map mapA = W.a().a(this.b, this.c);
        c0602h.a(mapA, new b(mapA, i, j, j2, j3), Boolean.FALSE, "");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, int i, long j, long j2, long j3) throws Throwable {
        try {
            if (this.f == 0) {
                this.f = 1;
                b("fs.cl2009.com");
                String str3 = n0.f1990a;
                Q.a("ProcessShanYanLogger", "init onFailure again", str, str3.substring(0, 15), Integer.valueOf(this.f));
                a(new C0602h(str3, this.c), i, j, j2, j3);
            } else {
                EnumC0611q enumC0611q = EnumC0611q.REQUEST_FAILED_CODE;
                a(enumC0611q, enumC0611q.b(), enumC0611q.e(), str2 + str, i, j, j2, j3);
            }
        } catch (Exception e) {
            e.printStackTrace();
            EnumC0611q enumC0611q2 = EnumC0611q.SDK_EXCEPTION_CODE;
            a(enumC0611q2, enumC0611q2.b(), enumC0611q2.e(), "getOperatorData--Exception_" + e, i, j, j2, j3);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, int i, long j, long j2, long j3) {
        try {
            if (AbstractC0600f.a(str)) {
                EnumC0611q enumC0611q = EnumC0611q.REQUEST_DATA_ERROR_CODE;
                a(enumC0611q, enumC0611q.b(), enumC0611q.e(), "result isEmpty", i, j, j2, j3);
                return;
            }
            JSONObject jSONObject = new JSONObject(str);
            int iOptInt = jSONObject.optInt("r1");
            String strOptString = jSONObject.optString("r2");
            if (iOptInt == 0) {
                a(jSONObject, i, j, j2, j3, iOptInt, strOptString, str);
            } else {
                a(EnumC0611q.REQUEST_DATA_ERROR_CODE, iOptInt, strOptString, str, i, j, j2, j3);
            }
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "getOperatorData Exception", e);
            EnumC0611q enumC0611q2 = EnumC0611q.SDK_EXCEPTION_CODE;
            a(enumC0611q2, enumC0611q2.b(), enumC0611q2.e(), "getOperatorData--Exception_" + e, i, j, j2, j3);
        }
    }

    private void a(JSONObject jSONObject, int i, long j, long j2, long j3, int i2, String str, String str2) {
        JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("r3");
        if (jSONObjectOptJSONObject != null) {
            String strOptString = jSONObjectOptJSONObject.optString("r5");
            if ("1".equals(strOptString)) {
                p0.b(this.c, "cl_jm_a6", strOptString);
                EnumC0611q enumC0611q = EnumC0611q.ACCOUNT_DISABLED_CODE;
                a(enumC0611q, enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, j, j2, j3);
                return;
            }
            a(jSONObjectOptJSONObject);
            c(jSONObjectOptJSONObject.optString("rk"));
            p0.b(this.c, "cl_jm_f2", true);
            p0.b(this.c, "cl_jm_e9", SystemClock.uptimeMillis());
            InitCallbacks initCallbacks = this.f1948a;
            EnumC0611q enumC0611q2 = EnumC0611q.INIT_SUCCESS_CODE;
            initCallbacks.initSuccessed(enumC0611q2.d(), enumC0611q2.b(), enumC0611q2.e(), enumC0611q2.c(), i, j, j2, j3);
            return;
        }
        a(EnumC0611q.REQUEST_DATA_ERROR_CODE, i2, str, str2, i, j, j2, j3);
    }

    private void a(JSONObject jSONObject) {
        String strOptString = jSONObject.optString("r7");
        String strOptString2 = jSONObject.optString("rt");
        String strOptString3 = jSONObject.optString("rq");
        String strOptString4 = jSONObject.optString("r6");
        String strOptString5 = jSONObject.optString("rw");
        String strOptString6 = jSONObject.optString("rp");
        String strOptString7 = jSONObject.optString("rj");
        String strOptString8 = jSONObject.optString("ri");
        String strOptString9 = jSONObject.optString("rb");
        String strOptString10 = jSONObject.optString("rd");
        String strOptString11 = jSONObject.optString("rs");
        String strOptString12 = jSONObject.optString("rc");
        String strOptString13 = jSONObject.optString("r9");
        String strOptString14 = jSONObject.optString("s2");
        String strOptString15 = jSONObject.optString("ry");
        String strOptString16 = jSONObject.optString("ro");
        String strOptString17 = jSONObject.optString("rz");
        String strOptString18 = jSONObject.optString("sc");
        String strOptString19 = jSONObject.optString(com.kuaishou.weapon.p0.t.w);
        String strOptString20 = jSONObject.optString("rh");
        String strOptString21 = jSONObject.optString("rn");
        String strOptString22 = jSONObject.optString("s4");
        String strOptString23 = jSONObject.optString("s5");
        String strOptString24 = jSONObject.optString("s6");
        String strOptString25 = jSONObject.optString("s7");
        p0.b(this.c, "cl_jm_a9", strOptString);
        p0.b(this.c, "cl_jm_c7", strOptString2);
        p0.b(this.c, "cl_jm_a8", strOptString4);
        p0.b(this.c, "cl_jm_c9", strOptString5);
        p0.b(this.c, "cl_jm_c4", strOptString3);
        p0.b(this.c, "cl_jm_c3", strOptString6);
        if (AbstractC0600f.b(strOptString25)) {
            p0.b(this.c, "cl_jm_g4", strOptString25);
        }
        if (AbstractC0600f.b(strOptString20)) {
            p0.b(this.c, "cl_jm_b7", strOptString20);
        }
        if (AbstractC0600f.b(strOptString22)) {
            p0.b(this.c, "cl_jm_g1", strOptString22);
        }
        if (AbstractC0600f.b(strOptString23)) {
            p0.b(this.c, "cl_jm_g2", strOptString23);
        }
        if (AbstractC0600f.b(strOptString24)) {
            p0.b(this.c, "cl_jm_g3", strOptString24);
        }
        if (AbstractC0600f.b(strOptString19)) {
            p0.b(this.c, "cl_jm_c1", strOptString19);
        }
        if (AbstractC0600f.b(strOptString17)) {
            p0.b(this.c, "cl_jm_d3", strOptString17);
        }
        if (AbstractC0600f.b(strOptString18)) {
            p0.b(this.c, "cl_jm_d4", strOptString18);
        }
        if (AbstractC0600f.b(strOptString16)) {
            p0.b(this.c, "cl_jm_c2", strOptString16);
        }
        if (AbstractC0600f.b(strOptString21) && strOptString21.contains(",")) {
            String[] strArrSplit = strOptString21.split(",");
            String str = strArrSplit[0];
            String str2 = strArrSplit[1];
            String str3 = strArrSplit[2];
            p0.b(this.c, "cl_jm_e6", Integer.parseInt(str));
            int i = AbstractC0606l.y;
            if (-1 == i) {
                p0.b(this.c, "cl_jm_e7", Integer.parseInt(str2));
                p0.b(this.c, "cl_jm_e8", Integer.parseInt(str3));
            } else {
                p0.b(this.c, "cl_jm_e7", i);
                p0.b(this.c, "cl_jm_e8", AbstractC0606l.y);
            }
        }
        if (AbstractC0600f.b(strOptString7)) {
            p0.b(this.c, "cl_jm_b9", Long.parseLong(strOptString7));
        }
        if (AbstractC0600f.b(strOptString8)) {
            p0.b(this.c, "cl_jm_b8", Long.parseLong(strOptString8));
        }
        if (AbstractC0600f.b(strOptString9)) {
            p0.b(this.c, "cl_jm_b4", Integer.parseInt(strOptString9));
        }
        if (AbstractC0600f.b(strOptString10)) {
            p0.b(this.c, "cl_jm_b6", Long.parseLong(strOptString10));
        }
        if (AbstractC0600f.b(strOptString11)) {
            p0.b(this.c, "cl_jm_c6", Long.parseLong(strOptString11));
        }
        if (AbstractC0600f.b(strOptString12)) {
            p0.b(this.c, "cl_jm_b5", Long.parseLong(strOptString12));
        }
        if (AbstractC0600f.b(strOptString13)) {
            p0.b(this.c, "cl_jm_b2", Long.parseLong(strOptString13));
        }
        if (AbstractC0600f.b(strOptString15)) {
            p0.b(this.c, "cl_jm_d2", strOptString15);
        }
        if (AbstractC0600f.b(strOptString14)) {
            p0.b(this.c, "cl_jm_d7", strOptString14);
        }
    }

    private void a(EnumC0611q enumC0611q, int i, String str, String str2, int i2, long j, long j2, long j3) {
        InitCallbacks initCallbacks = this.f1948a;
        if (initCallbacks != null) {
            initCallbacks.initFailed(enumC0611q.d(), i, str, str2, i2, j, j2, j3);
        }
    }
}
