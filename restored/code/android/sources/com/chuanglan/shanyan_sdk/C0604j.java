package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import android.util.Base64;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.CtSetting;
import cn.com.chinatelecom.account.api.ResultListener;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.chuanglan.shanyan_sdk.listener.AuthCallbacks;
import com.cmic.gen.sdk.auth.GenAuthnHelper;
import com.cmic.gen.sdk.auth.GenTokenListener;
import com.czhj.sdk.common.Constants;
import com.sigmob.sdk.base.models.ClickCommon;
import com.unicom.online.account.shield.UniAccountHelper;
import java.util.concurrent.ExecutorService;
import org.json.JSONObject;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.j, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public class C0604j {
    private static volatile C0604j l;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1975a;
    private AuthCallbacks b;
    private String c;
    private String d;
    private final d e = new d(this, null);
    private ExecutorService f;
    private String g;
    private long h;
    private long i;
    private long j;
    private String k;

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.j$a */
    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ long f1976a;
        final /* synthetic */ long b;
        final /* synthetic */ long c;

        a(long j, long j2, long j3) {
            this.f1976a = j;
            this.b = j2;
            this.c = j3;
        }

        @Override // java.lang.Runnable
        public void run() throws Throwable {
            try {
                AbstractC0601g.a(C0604j.this.f1975a);
                Q.a("ProcessShanYanLogger", "auth check", 11, "int status", Integer.valueOf(AbstractC0606l.u.get()));
                if (AbstractC0606l.u.get() != AbstractC0606l.r) {
                    C0604j.a().c(this.f1976a, this.b, this.c);
                } else if (AbstractC0612r.c == p0.a(C0604j.this.f1975a, "cl_jm_a6", AbstractC0612r.b)) {
                    AbstractC0606l.B = false;
                    AuthCallbacks authCallbacks = C0604j.this.b;
                    EnumC0611q enumC0611q = EnumC0611q.ACCOUNT_DISABLED_CODE;
                    authCallbacks.authFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), 11, C0616v.g().b(C0604j.this.f1975a), this.f1976a, this.b, this.c);
                } else {
                    N.b().a(11, this.f1976a, this.b);
                }
            } catch (Exception e) {
                C0604j.this.a(C0616v.g().b(C0604j.this.f1975a), this.f1976a, this.b, this.c, "authStart Exception" + e);
            }
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.j$b */
    class b implements ResultListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ long f1977a;
        final /* synthetic */ long b;
        final /* synthetic */ long c;

        b(long j, long j2, long j3) {
            this.f1977a = j;
            this.b = j2;
            this.c = j3;
        }

        @Override // cn.com.chinatelecom.account.api.ResultListener
        public void onResult(String str) {
            try {
                Q.c("LogInfoShanYanLogger", "ct requestPreLogin", str);
                if (AbstractC0600f.a(str)) {
                    C0604j.this.a(-1, (String) null, "ctcc response isEmpty");
                    return;
                }
                JSONObject jSONObject = new JSONObject(str);
                int iOptInt = jSONObject.optInt(com.alipay.sdk.m.y.o.c);
                String strOptString = jSONObject.optString("msg");
                String strOptString2 = jSONObject.optString("reqId");
                if (iOptInt != 0) {
                    C0604j.this.a(iOptInt, strOptString, strOptString2);
                    return;
                }
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("data");
                if (jSONObjectOptJSONObject == null) {
                    C0604j.this.a(iOptInt, strOptString, strOptString2);
                    return;
                }
                String strOptString3 = jSONObjectOptJSONObject.optString("accessCode");
                String strOptString4 = jSONObjectOptJSONObject.optString("gwAuth");
                if (AbstractC0600f.a(strOptString3)) {
                    C0604j.this.a(iOptInt, strOptString, strOptString2);
                } else {
                    C0604j.this.a("CTCC", "3" + p0.a(C0604j.this.f1975a, "cl_jm_a8", "") + "," + strOptString3, strOptString4, this.f1977a, this.b, this.c);
                }
            } catch (Exception e) {
                C0604j.this.a("CTCC", this.f1977a, this.b, this.c, "ctcc onResult Exception" + e);
            }
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.j$c */
    class c implements com.unicom.online.account.shield.ResultListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f1978a;
        final /* synthetic */ long b;
        final /* synthetic */ long c;
        final /* synthetic */ long d;

        c(String str, long j, long j2, long j3) {
            this.f1978a = str;
            this.b = j;
            this.c = j2;
            this.d = j3;
        }

        @Override // com.unicom.online.account.shield.ResultListener
        public void onResult(String str) {
            try {
                Q.c("LogInfoShanYanLogger", "cu cuGetToken", str);
                if (AbstractC0600f.a(str)) {
                    C0604j.this.a(-1, (String) null, "cucc response isEmpty");
                    return;
                }
                JSONObject jSONObject = new JSONObject(str);
                int iOptInt = jSONObject.optInt("resultCode");
                String strOptString = jSONObject.optString("resultMsg");
                String strOptString2 = jSONObject.optString("seq");
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("resultData");
                if (iOptInt == 100 && jSONObjectOptJSONObject != null) {
                    String strOptString3 = jSONObjectOptJSONObject.optString("accessCode");
                    if (AbstractC0600f.a(strOptString3)) {
                        C0604j.this.a(iOptInt, strOptString, jSONObjectOptJSONObject + strOptString2);
                        return;
                    } else {
                        C0604j.this.a("CUCC", "2" + this.f1978a + "," + strOptString3, "", this.b, this.c, this.d);
                        return;
                    }
                }
                C0604j.this.a(iOptInt, strOptString, jSONObjectOptJSONObject + strOptString2);
            } catch (Exception e) {
                C0604j.this.a("CUCC", this.b, this.c, this.d, "cucc onResult Exception" + e);
            }
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.j$d */
    private class d implements GenTokenListener {
        private d() {
        }

        @Override // com.cmic.gen.sdk.auth.GenTokenListener
        public void onGetTokenComplete(int i, JSONObject jSONObject) {
            try {
                Q.c("LogInfoShanYanLogger", "cm onGetTokenComplete", jSONObject, Integer.valueOf(i));
                if (jSONObject == null) {
                    C0604j.this.a(-1, (String) null, "auth response isEmpty");
                    return;
                }
                int iOptInt = jSONObject.optInt("resultCode");
                String strOptString = jSONObject.optString("desc");
                String strOptString2 = jSONObject.optString("traceId");
                if (jSONObject.has(Constants.TOKEN) && iOptInt == 103000) {
                    String strOptString3 = jSONObject.optString(Constants.TOKEN);
                    if (AbstractC0600f.a(strOptString3)) {
                        C0604j.this.a(iOptInt, strOptString, "token is empty" + strOptString2);
                        return;
                    } else {
                        C0604j c0604j = C0604j.this;
                        c0604j.a(c0604j.g, C0604j.this.a(strOptString3), "", C0604j.this.i, C0604j.this.h, C0604j.this.j);
                        return;
                    }
                }
                C0604j.this.a(iOptInt, strOptString, strOptString2);
            } catch (Exception e) {
                C0604j c0604j2 = C0604j.this;
                c0604j2.a(c0604j2.g, C0604j.this.i, C0604j.this.h, C0604j.this.j, "mCMCCAuth onGetTokenComplete Exception" + e);
            }
        }

        /* synthetic */ d(C0604j c0604j, a aVar) {
            this();
        }
    }

    private C0604j() {
    }

    private void b(long j, long j2, long j3) {
        int iA = p0.a(this.f1975a, "cl_jm_e7", 6);
        String strA = p0.a(this.f1975a, "cl_jm_c4", new String());
        Q.a("ProcessShanYanLogger", "start cu mobileAuth", strA);
        UniAccountHelper.getInstance().init(this.f1975a, strA, false);
        UniAccountHelper.getInstance().cuGetToken((iA + 1) * 1000, new c(strA, j, j2, j3));
    }

    /* JADX WARN: Code duplicated, block: B:14:0x0047  */
    public void c(long j, long j2, long j3) {
        byte b2;
        try {
            String strB = C0616v.g().b(this.f1975a);
            Q.a("ProcessShanYanLogger", "auth start", 11, strB);
            int iHashCode = strB.hashCode();
            if (iHashCode != 2078865) {
                if (iHashCode == 2079826 && strB.equals("CUCC")) {
                    b2 = 0;
                } else {
                    b2 = -1;
                }
            } else if (strB.equals("CTCC")) {
                b2 = 1;
            } else {
                b2 = -1;
            }
            if (b2 == 0) {
                if (a(11, j, j2, j3)) {
                    return;
                }
                String strA = p0.a(this.f1975a, "cl_jm_g3", "cu");
                Q.a("ProcessShanYanLogger", "cuChannelType", strA);
                a(strB, j, j2, j3, "cl_jm_e4", EnumC0611q.CUCC_UNAVAILABLE_CODE, strA);
                return;
            }
            if (b2 != 1) {
                String strA2 = p0.a(this.f1975a, "cl_jm_g1", "cm");
                Q.a("ProcessShanYanLogger", "cmChannelType", strA2);
                a(strB, j, j2, j3, "cl_jm_e3", EnumC0611q.CMCC_UNAVAILABLE_CODE, strA2);
            } else {
                String strA3 = p0.a(this.f1975a, "cl_jm_g2", "ct");
                Q.a("ProcessShanYanLogger", "ctChannelType", strA3);
                a(strB, j, j2, j3, "cl_jm_e5", EnumC0611q.CTCC_UNAVAILABLE_CODE, strA3);
            }
        } catch (Exception e) {
            a(C0616v.g().b(this.f1975a), j, j2, j3, "startAuth Exception" + e);
        }
    }

    public static C0604j a() {
        if (l == null) {
            synchronized (C0604j.class) {
                if (l == null) {
                    l = new C0604j();
                }
            }
        }
        return l;
    }

    public void a(Context context, String str, ExecutorService executorService) {
        this.f1975a = context;
        this.c = str;
        this.f = executorService;
    }

    public void a(long j, long j2) {
        this.b = new C0603i();
        long jUptimeMillis = SystemClock.uptimeMillis();
        a aVar = new a(j, j2, jUptimeMillis);
        if (this.f1975a != null && this.f != null) {
            if (AbstractC0606l.t != AbstractC0606l.x.getAndSet(AbstractC0606l.t)) {
                this.f.execute(aVar);
                return;
            } else {
                Q.d("ExceptionShanYanLogger", "auth is in progress");
                return;
            }
        }
        AuthCallbacks authCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.NOT_INITIALIZED_CODE;
        authCallbacks.authFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + ":auth()", 11, "Unknown_Operator", j, j2, jUptimeMillis);
    }

    private boolean a(int i, long j, long j2, long j3) {
        String str = "0";
        String strA = p0.a(this.f1975a, "cl_jm_d7", "0");
        if (strA.contains(",")) {
            String[] strArrSplit = strA.split(",");
            String str2 = strArrSplit.length == 1 ? strArrSplit[0] : "0";
            if (strArrSplit.length == 2) {
                str2 = strArrSplit[0];
                str = strArrSplit[1];
            }
            strA = str2;
        }
        Q.a("ProcessShanYanLogger", "startGetPhoneInfo cucc", strA, str);
        if ("1".equals(strA)) {
            t0.h().d();
            boolean zG = AbstractC0610p.g(this.f1975a);
            if (zG) {
                int iJ = AbstractC0610p.j(this.f1975a);
                if (iJ != 2 && iJ != 3) {
                    boolean zC = AbstractC0610p.c(this.f1975a);
                    boolean zA = AbstractC0600f.a(Integer.parseInt(str));
                    Q.a("ProcessShanYanLogger", "startGetPhoneInfo enable", Boolean.valueOf(zC), str);
                    if (zC && zA) {
                        AuthCallbacks authCallbacks = this.b;
                        EnumC0611q enumC0611q = EnumC0611q.DATA_REQUEST_FAILED_CODE;
                        authCallbacks.authFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + zG + iJ + zC, i, "CUCC", j, j2, j3);
                    }
                } else {
                    AuthCallbacks authCallbacks2 = this.b;
                    EnumC0611q enumC0611q2 = EnumC0611q.DATA_REQUEST_FAILED_CODE;
                    authCallbacks2.authFailed(enumC0611q2.d(), enumC0611q2.b(), enumC0611q2.e(), enumC0611q2.c() + zG + iJ, i, "CUCC", j, j2, j3);
                    return true;
                }
            } else {
                AuthCallbacks authCallbacks3 = this.b;
                EnumC0611q enumC0611q3 = EnumC0611q.DATA_REQUEST_FAILED_CODE;
                authCallbacks3.authFailed(enumC0611q3.d(), enumC0611q3.b(), enumC0611q3.e(), enumC0611q3.c() + zG, i, "CUCC", j, j2, j3);
                return true;
            }
        }
        return false;
    }

    private void a(String str, long j, long j2, long j3, String str2, EnumC0611q enumC0611q, String str3) {
        int iA = p0.a(this.f1975a, str2, AbstractC0612r.c);
        if (iA != 1) {
            if (iA != 2) {
                this.b.authFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), 11, str, j, j2, j3);
                return;
            } else {
                a(str, "5");
                return;
            }
        }
        if ("cu".equals(str3)) {
            b(j, j2, j3);
        } else if ("ct".equals(str3)) {
            a(j, j2, j3);
        } else {
            a(str, "1");
        }
    }

    private void a(long j, long j2, long j3) {
        int iA = p0.a(this.f1975a, "cl_jm_e7", 6);
        Q.a("ProcessShanYanLogger", "start ct preinfo", Integer.valueOf(iA));
        int i = iA + 1;
        int i2 = i * 500;
        CtAuth.getInstance().requestPreLogin(new CtSetting(i2, i2, i * 1000), new b(j, j2, j3));
    }

    private void a(String str, String str2) {
        this.g = str;
        this.h = SystemClock.uptimeMillis();
        this.j = SystemClock.uptimeMillis();
        this.i = System.currentTimeMillis();
        this.d = str2;
        this.k = p0.a(this.f1975a, "cl_jm_a9", new String());
        String strA = p0.a(this.f1975a, "cl_jm_c7", new String());
        GenAuthnHelper.getInstance(this.f1975a).setOverTime((p0.a(this.f1975a, "cl_jm_e7", 6) + 1) * 1000);
        Q.a("ProcessShanYanLogger", "start  cm mobileAuth", this.k);
        GenAuthnHelper.getInstance(this.f1975a).mobileAuth(this.k, strA, this.e);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, String str3, long j, long j2, long j3) {
        String str4;
        try {
            String strSubstring = str2.substring(0, 1);
            int iIndexOf = str2.indexOf(44);
            String strSubstring2 = str2.substring(1, iIndexOf);
            String strSubstring3 = str2.substring(iIndexOf + 1);
            String strA = p0.a(this.f1975a, "cl_jm_c3", "");
            String strA2 = p0.a(this.f1975a, "cl_jm_c2", "");
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(IAdInterListener.AdReqParam.AP, strA);
            jSONObject.put("tk", strSubstring3);
            jSONObject.put("au", str3);
            String strB = AbstractC0601g.b(this.f1975a);
            String strB2 = AbstractC0596b.b(this.c);
            String strSubstring4 = strB2.substring(0, 16);
            String strSubstring5 = strB2.substring(16);
            String str5 = "," + strB;
            String strA3 = p0.a(this.f1975a, "cl_jm_a3", "");
            p0.b(this.f1975a, "cl_jm_f5", str5);
            jSONObject.put("dd", strA3 + str5);
            jSONObject.put("ud", p0.a(this.f1975a, "cl_jm_a2", ""));
            jSONObject.put("vs", "2.3.7.5");
            jSONObject.put("tp", "1");
            jSONObject.put("nlt", "1");
            jSONObject.put(ClickCommon.CLICK_SCENE_AD, strSubstring2);
            String strEncodeToString = Base64.encodeToString(AbstractC0596b.a(jSONObject.toString().getBytes("UTF-8"), strSubstring4, strSubstring5), 11);
            JSONObject jSONObject2 = new JSONObject();
            if (AbstractC0600f.b(strA2) && "1".equals(strA2)) {
                str4 = "A" + strSubstring + strA + "-" + strEncodeToString;
            } else {
                str4 = "A" + strSubstring + "-" + strEncodeToString;
            }
            jSONObject2.put(Constants.TOKEN, str4);
            String string = jSONObject2.toString();
            Q.c("LogInfoShanYanLogger", "pre token", strSubstring4, strSubstring5, jSONObject);
            AuthCallbacks authCallbacks = this.b;
            EnumC0611q enumC0611q = EnumC0611q.AUTH_TOKEN_SUCCESS_CODE;
            authCallbacks.authSuccessed(enumC0611q.d(), enumC0611q.b(), string, enumC0611q.c(), 11, str, j, j2, j3);
        } catch (Exception e) {
            a(C0616v.g().b(this.f1975a), j, j2, j3, "phoneNumVerify Exception" + e);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, String str, String str2) {
        AuthCallbacks authCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.AUTH_TOKEN_FAILED_CODE;
        authCallbacks.authFailed(enumC0611q.d(), i == -1 ? enumC0611q.b() : i, str == null ? enumC0611q.e() : str, enumC0611q.c() + str2, 11, this.g, this.i, this.h, this.j);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String a(String str) {
        String str2;
        String str3 = this.g;
        str3.hashCode();
        str3.hashCode();
        switch (str3) {
            case "CMHK":
                str2 = n0.c;
                break;
            case "CTCC":
                str2 = "t,";
                break;
            case "CUCC":
                str2 = "u,";
                break;
            default:
                str2 = "m,";
                break;
        }
        return this.d + this.k + "," + str2 + str;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, long j, long j2, long j3, String str2) {
        Q.d("ExceptionShanYanLogger", str2);
        AuthCallbacks authCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
        authCallbacks.authFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + str2, 11, str, j, j2, j3);
    }
}
