package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.CtSetting;
import cn.com.chinatelecom.account.api.ResultListener;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoCallbacks;
import com.cmic.gen.sdk.auth.GenAuthnHelper;
import com.cmic.gen.sdk.auth.GenTokenListener;
import com.unicom.online.account.shield.UniAccountHelper;
import java.util.concurrent.ExecutorService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class k0 {
    private static volatile k0 j;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1983a;
    private GetPhoneInfoCallbacks b;
    private d c;
    private int d;
    private String e;
    private long f;
    private long g;
    private long h;
    private ExecutorService i;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f1984a;
        final /* synthetic */ long b;
        final /* synthetic */ long c;
        final /* synthetic */ long d;
        final /* synthetic */ String e;

        a(int i, long j, long j2, long j3, String str) {
            this.f1984a = i;
            this.b = j;
            this.c = j2;
            this.d = j3;
            this.e = str;
        }

        @Override // java.lang.Runnable
        public void run() throws Throwable {
            try {
                k0.this.a(this.f1984a, this.b, this.c, this.d, this.e);
            } catch (Exception e) {
                k0.this.a("getPhoneInfoMethod Exception" + e, this.e, this.f1984a, this.b, this.c, this.d);
            }
        }
    }

    class b implements ResultListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f1985a;
        final /* synthetic */ String b;
        final /* synthetic */ long c;
        final /* synthetic */ long d;
        final /* synthetic */ long e;
        final /* synthetic */ String f;

        b(int i, String str, long j, long j2, long j3, String str2) {
            this.f1985a = i;
            this.b = str;
            this.c = j;
            this.d = j2;
            this.e = j3;
            this.f = str2;
        }

        @Override // cn.com.chinatelecom.account.api.ResultListener
        public void onResult(String str) {
            try {
                Q.c("LogInfoShanYanLogger", "ct requestPreLogin", str);
                if (AbstractC0600f.a(str)) {
                    k0.this.a(this.f1985a, this.b, this.c, this.d, this.e, -1, (String) null, "ct response isEmpty");
                    return;
                }
                JSONObject jSONObject = new JSONObject(str);
                int iOptInt = jSONObject.optInt(com.alipay.sdk.m.y.o.c);
                String strOptString = jSONObject.optString("msg");
                String strOptString2 = jSONObject.optString("reqId");
                if (iOptInt != 0) {
                    k0.this.a(this.f1985a, this.b, this.c, this.d, this.e, iOptInt, strOptString, strOptString2);
                    return;
                }
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("data");
                if (jSONObjectOptJSONObject == null) {
                    k0.this.a(this.f1985a, this.b, this.c, this.d, this.e, iOptInt, strOptString, strOptString2);
                    return;
                }
                String strOptString3 = jSONObjectOptJSONObject.optString("number");
                String strOptString4 = jSONObjectOptJSONObject.optString("accessCode");
                String strOptString5 = jSONObjectOptJSONObject.optString("gwAuth");
                if (!AbstractC0600f.a(strOptString3) && !AbstractC0600f.a(strOptString4)) {
                    k0.this.a(strOptString3, strOptString4, strOptString5, iOptInt, this.f, this.b, this.f1985a, this.c, this.d, this.e);
                    return;
                }
                k0.this.a(this.f1985a, this.b, this.c, this.d, this.e, iOptInt, strOptString, jSONObjectOptJSONObject + strOptString2);
            } catch (Exception e) {
                k0.this.a("ct requestPreLogin Exception" + e, this.b, this.f1985a, this.c, this.d, this.e);
            }
        }
    }

    class c implements com.unicom.online.account.shield.ResultListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f1986a;
        final /* synthetic */ String b;
        final /* synthetic */ long c;
        final /* synthetic */ long d;
        final /* synthetic */ long e;
        final /* synthetic */ String f;

        c(int i, String str, long j, long j2, long j3, String str2) {
            this.f1986a = i;
            this.b = str;
            this.c = j;
            this.d = j2;
            this.e = j3;
            this.f = str2;
        }

        @Override // com.unicom.online.account.shield.ResultListener
        public void onResult(String str) {
            try {
                Q.c("LogInfoShanYanLogger", "cu cuGetToken", str);
                if (AbstractC0600f.a(str)) {
                    k0.this.a(this.f1986a, this.b, this.c, this.d, this.e, -1, (String) null, "cu response isEmpty");
                    return;
                }
                JSONObject jSONObject = new JSONObject(str);
                int iOptInt = jSONObject.optInt("resultCode");
                String strOptString = jSONObject.optString("resultMsg");
                String strOptString2 = jSONObject.optString("seq");
                if (iOptInt != 100) {
                    k0.this.a(this.f1986a, this.b, this.c, this.d, this.e, iOptInt, strOptString, strOptString2);
                    return;
                }
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("resultData");
                if (jSONObjectOptJSONObject == null) {
                    k0.this.a(this.f1986a, this.b, this.c, this.d, this.e, iOptInt, strOptString, strOptString2);
                    return;
                }
                String strOptString3 = jSONObjectOptJSONObject.optString("fakeMobile");
                String strOptString4 = jSONObjectOptJSONObject.optString("accessCode");
                if (!AbstractC0600f.a(strOptString3) && !AbstractC0600f.a(strOptString4)) {
                    k0.this.a(strOptString3, strOptString4, iOptInt, this.f, this.b, this.f1986a, this.c, this.d, this.e);
                    return;
                }
                k0.this.a(this.f1986a, this.b, this.c, this.d, this.e, iOptInt, strOptString, jSONObjectOptJSONObject + strOptString2);
            } catch (Exception e) {
                k0.this.a("cuPreInfo Exception" + e, this.b, this.f1986a, this.c, this.d, this.e);
            }
        }
    }

    private class d implements GenTokenListener {
        private d() {
        }

        @Override // com.cmic.gen.sdk.auth.GenTokenListener
        public void onGetTokenComplete(int i, JSONObject jSONObject) {
            try {
                Q.c("LogInfoShanYanLogger", "cm onGetTokenComplete", jSONObject, Integer.valueOf(i));
                if (jSONObject == null) {
                    k0 k0Var = k0.this;
                    k0Var.a(k0Var.d, k0.this.e, k0.this.g, k0.this.f, k0.this.h, -1, (String) null, "cm response isEmpty");
                    return;
                }
                int iOptInt = jSONObject.optInt("resultCode");
                String strOptString = jSONObject.optString("desc");
                String strOptString2 = jSONObject.optString("traceId");
                if (iOptInt != 103000) {
                    k0 k0Var2 = k0.this;
                    k0Var2.a(k0Var2.d, k0.this.e, k0.this.g, k0.this.f, k0.this.h, iOptInt, strOptString, strOptString2);
                    return;
                }
                String strB = com.cmic.gen.sdk.f.i.b(k0.this.f1983a);
                if (!AbstractC0600f.a(strB)) {
                    k0.this.a(strB, iOptInt);
                } else {
                    k0 k0Var3 = k0.this;
                    k0Var3.a(k0Var3.d, k0.this.e, k0.this.g, k0.this.f, k0.this.h, iOptInt, strOptString, strOptString2);
                }
            } catch (Exception e) {
                k0.this.a("cm onGetTokenComplete Exception" + e, k0.this.e, k0.this.d, k0.this.g, k0.this.f, k0.this.h);
            }
        }

        /* synthetic */ d(k0 k0Var, a aVar) {
            this();
        }
    }

    private k0() {
    }

    public static k0 b() {
        if (j == null) {
            synchronized (k0.class) {
                if (j == null) {
                    j = new k0();
                }
            }
        }
        return j;
    }

    public void c(int i, String str, long j2, long j3, long j4) {
        String strB = AbstractC0600f.a(str) ? C0616v.g().b(this.f1983a) : str;
        Q.a("ProcessShanYanLogger", "startGetPhoneInfo processName", Integer.valueOf(i), strB);
        strB.hashCode();
        if (strB.equals("CTCC")) {
            String strA = p0.a(this.f1983a, "cl_jm_g2", "ct");
            Q.a("ProcessShanYanLogger", "ctChannelType", strA);
            a(i, strB, j2, j3, j4, "cl_jm_e5", EnumC0611q.CTCC_UNAVAILABLE_CODE, strA);
        } else if (!strB.equals("CUCC")) {
            String strA2 = p0.a(this.f1983a, "cl_jm_g1", "cm");
            Q.a("ProcessShanYanLogger", "cmChannelType", strA2);
            a(i, strB, j2, j3, j4, "cl_jm_e3", EnumC0611q.CMCC_UNAVAILABLE_CODE, strA2);
        } else {
            if (a(i, strB, j2, j3, j4)) {
                return;
            }
            String strA3 = p0.a(this.f1983a, "cl_jm_g3", "cu");
            Q.a("ProcessShanYanLogger", "cuChannelType", strA3);
            a(i, strB, j2, j3, j4, "cl_jm_e4", EnumC0611q.CUCC_UNAVAILABLE_CODE, strA3);
        }
    }

    public void a(Context context, ExecutorService executorService) {
        this.f1983a = context;
        this.i = executorService;
    }

    private void b(int i, String str, long j2, long j3, long j4) {
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.DATA_REQUEST_FAILED_CODE;
        getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, str, j2, j3, j4);
    }

    public void a(int i, String str, long j2, long j3) {
        this.b = new C(this.f1983a);
        AbstractC0601g.d(this.f1983a);
        long jUptimeMillis = SystemClock.uptimeMillis();
        a aVar = new a(i, j2, j3, jUptimeMillis, str);
        if (this.f1983a != null && this.i != null) {
            Q.a("ProcessShanYanLogger", "start preInfo processName", Integer.valueOf(i));
            this.i.execute(aVar);
        } else {
            GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
            EnumC0611q enumC0611q = EnumC0611q.NOT_INITIALIZED_CODE;
            getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + "getPhoneInfoMethod()", i, "Unknown_Operator", j2, j3, jUptimeMillis);
        }
    }

    private void b(String str, int i, long j2, long j3, long j4, String str2) {
        try {
            if (t0.h().d(this.f1983a)) {
                AbstractC0606l.n = f0.a(str);
                AbstractC0606l.o = f0.b(str);
                AbstractC0606l.m = str;
                AbstractC0606l.p = p0.a(this.f1983a, "cl_jm_f8", "");
                GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
                EnumC0611q enumC0611q = EnumC0611q.PRE_CACHE_SUCCESS_CODE;
                getPhoneInfoCallbacks.getPhoneInfoSuccessed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, j2, j3, j4);
            } else {
                t0.h().d();
                a(str, i, j2, j3, j4, str2);
            }
        } catch (Exception e) {
            a("preTimeCheck Exception" + e, str, i, j2, j3, j4);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, long j2, long j3, long j4, String str) throws Throwable {
        AbstractC0601g.a(this.f1983a);
        int iA = p0.a(this.f1983a, "cl_jm_e7", 6);
        j0.a(this.f1983a, ((long) iA) * 1000, i, this.b, j2, j3, j4);
        Q.a("ProcessShanYanLogger", "preInfo", Integer.valueOf(iA), "status", Integer.valueOf(AbstractC0606l.u.get()));
        if (AbstractC0606l.u.get() == AbstractC0606l.r) {
            if (1 == p0.a(this.f1983a, "cl_jm_a6", AbstractC0612r.b)) {
                AbstractC0606l.B = false;
                GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
                EnumC0611q enumC0611q = EnumC0611q.ACCOUNT_DISABLED_CODE;
                getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, C0616v.g().b(this.f1983a), j2, j3, j4);
                return;
            }
            N.b().a(i, j2, j3);
            return;
        }
        c(i, str, j2, j3, j4);
    }

    private void b(String str, int i, long j2, long j3, long j4) {
        int iA = p0.a(this.f1983a, "cl_jm_e7", 6);
        String strA = p0.a(this.f1983a, "cl_jm_c4", "");
        Q.a("ProcessShanYanLogger", "start cu preinfo", strA);
        UniAccountHelper.getInstance().init(this.f1983a, strA, false);
        UniAccountHelper.getInstance().setUseCacheFlag(false);
        UniAccountHelper.getInstance().clearCache();
        UniAccountHelper.getInstance().cuGetToken((iA + 1) * 1000, new c(i, str, j2, j3, j4, strA));
    }

    public boolean a(int i, String str, long j2, long j3, long j4) {
        String[] strArrSplit = p0.a(this.f1983a, "cl_jm_d7", "0").split(",");
        String str2 = strArrSplit.length > 0 ? strArrSplit[0] : "0";
        String str3 = strArrSplit.length > 1 ? strArrSplit[1] : "0";
        Q.a("ProcessShanYanLogger", "startGetPhoneInfo cucc", str2, str3);
        if (!"1".equals(str2)) {
            return false;
        }
        t0.h().d();
        if (!AbstractC0610p.g(this.f1983a)) {
            b(i, str, j2, j3, j4);
            return true;
        }
        int iJ = AbstractC0610p.j(this.f1983a);
        if (iJ != 2 && iJ != 3) {
            boolean zC = AbstractC0610p.c(this.f1983a);
            boolean zA = AbstractC0600f.a(Integer.parseInt(str3));
            Q.a("ProcessShanYanLogger", "startGetPhoneInfo enable", Boolean.valueOf(zC), str3, Boolean.valueOf(zA));
            if (!zC || !zA) {
                return false;
            }
            b(i, str, j2, j3, j4);
            return true;
        }
        b(i, str, j2, j3, j4);
        return true;
    }

    private void a(int i, String str, long j2, long j3, long j4, String str2, EnumC0611q enumC0611q, String str3) {
        int iA = p0.a(this.f1983a, str2, AbstractC0612r.c);
        if (iA != 1 && iA != 2) {
            this.b.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), i, str, j2, j3, j4);
        } else {
            b(str, i, j2, j3, j4, str3);
        }
    }

    private void a(String str, int i, long j2, long j3, long j4, String str2) {
        this.d = i;
        this.f = j3;
        this.h = j4;
        this.g = j2;
        this.e = str;
        Q.a("ProcessShanYanLogger", "operatorPreInfo ", Integer.valueOf(i), str, str2);
        if ("cu".equals(str2)) {
            b(str, i, j2, j3, j4);
        } else if ("ct".equals(str2)) {
            a(str, i, j2, j3, j4);
        } else {
            a();
        }
    }

    private void a() {
        GenAuthnHelper.getInstance(this.f1983a).setOverTime((p0.a(this.f1983a, "cl_jm_e7", 6) + 1) * 1000);
        if (this.c == null) {
            this.c = new d(this, null);
        }
        String strA = p0.a(this.f1983a, "cl_jm_a9", "");
        String strA2 = p0.a(this.f1983a, "cl_jm_c7", "");
        Q.a("ProcessShanYanLogger", "start  cm preinfo", strA);
        GenAuthnHelper.getInstance(this.f1983a).getPhoneInfo(strA, strA2, this.c);
    }

    private void a(String str, int i, long j2, long j3, long j4) {
        int iA = p0.a(this.f1983a, "cl_jm_e7", 6);
        Q.a("ProcessShanYanLogger", "start ct preinfo", str, Integer.valueOf(iA));
        int i2 = iA + 1;
        int i3 = i2 * 500;
        CtAuth.getInstance().requestPreLogin(new CtSetting(i3, i3, i2 * 1000), new b(i, str, j2, j3, j4, p0.a(this.f1983a, "cl_jm_a8", "")));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, String str3, int i, String str4, String str5, int i2, long j2, long j3, long j4) {
        p0.b(this.f1983a, "cl_jm_f8", str);
        p0.b(this.f1983a, "cl_jm_d8", System.currentTimeMillis() + (p0.a(this.f1983a, "cl_jm_b5", 3600L) * 1000));
        p0.b(this.f1983a, "cl_jm_f7", "3" + str4 + "," + str2);
        p0.b(this.f1983a, "cl_jm_d9", str3);
        AbstractC0606l.p = str;
        AbstractC0606l.n = f0.a(str5);
        AbstractC0606l.o = f0.b(str5);
        AbstractC0606l.m = str5;
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.PRE_SUCCESS_CODE;
        getPhoneInfoCallbacks.getPhoneInfoSuccessed(enumC0611q.d(), i, enumC0611q.e(), enumC0611q.c(), i2, j2, j3, j4);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, int i, long j2, long j3, long j4) {
        Q.d("ExceptionShanYanLogger", "Exception in preTimeCheck", str);
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
        getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + "Exception_e=" + str, i, str2, j2, j3, j4);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, int i, String str3, String str4, int i2, long j2, long j3, long j4) {
        p0.b(this.f1983a, "cl_jm_f8", str);
        p0.b(this.f1983a, "cl_jm_d8", System.currentTimeMillis() + (p0.a(this.f1983a, "cl_jm_c6", 3600L) * 1000));
        p0.b(this.f1983a, "cl_jm_f7", "2" + str3 + "," + str2);
        AbstractC0606l.p = str;
        AbstractC0606l.o = f0.b(str4);
        AbstractC0606l.n = f0.a(str4);
        AbstractC0606l.m = str4;
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.PRE_SUCCESS_CODE;
        getPhoneInfoCallbacks.getPhoneInfoSuccessed(enumC0611q.d(), i, enumC0611q.e(), enumC0611q.c(), i2, j2, j3, j4);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, int i) {
        p0.b(this.f1983a, "cl_jm_f8", str);
        p0.b(this.f1983a, "cl_jm_d8", System.currentTimeMillis() + System.currentTimeMillis() + (p0.a(this.f1983a, "cl_jm_b6", 3600L) * 1000));
        AbstractC0606l.p = str;
        AbstractC0606l.n = f0.a(this.e);
        AbstractC0606l.o = f0.b(this.e);
        AbstractC0606l.m = this.e;
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.PRE_SUCCESS_CODE;
        getPhoneInfoCallbacks.getPhoneInfoSuccessed(enumC0611q.d(), i, enumC0611q.e(), enumC0611q.c(), this.d, this.g, this.f, this.h);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, String str, long j2, long j3, long j4, int i2, String str2, String str3) {
        GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.PRE_REQUEST_FAILED_CODE;
        getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), i2 == -1 ? EnumC0611q.AUTH_TOKEN_FAILED_CODE.b() : i2, str2 == null ? EnumC0611q.AUTH_TOKEN_FAILED_CODE.e() : str2, enumC0611q.c() + str3, i, str, j2, j3, j4);
    }
}
