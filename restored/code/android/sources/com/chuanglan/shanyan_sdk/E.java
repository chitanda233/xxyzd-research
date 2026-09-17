package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import android.util.Base64;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.chuanglan.shanyan_sdk.listener.LoginAuthCallbacks;
import com.cmic.gen.sdk.auth.GenAuthnHelper;
import com.cmic.gen.sdk.auth.GenTokenListener;
import com.cmic.gen.sdk.view.GenAuthThemeConfig;
import com.cmic.gen.sdk.view.GenLoginClickListener;
import com.czhj.sdk.common.Constants;
import com.sigmob.sdk.base.models.ClickCommon;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingDeque;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class E {
    private static volatile E m;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1935a;
    private LoginAuthCallbacks b;
    private long c;
    private long d;
    private long e;
    private String f;
    private String g;
    private String h;
    private d i;
    private ExecutorService j;
    private ExecutorService k;
    private String l;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ long f1936a;
        final /* synthetic */ long b;
        final /* synthetic */ int c;
        final /* synthetic */ long d;

        a(long j, long j2, int i, long j3) {
            this.f1936a = j;
            this.b = j2;
            this.c = i;
            this.d = j3;
        }

        /* JADX WARN: Code duplicated, block: B:14:0x006d  */
        @Override // java.lang.Runnable
        public void run() {
            byte b;
            try {
                try {
                    String strB = C0616v.g().b(E.this.f1935a);
                    int iA = p0.a(E.this.f1935a, "cl_jm_e8", 6);
                    LoginAuthCallbacks loginAuthCallbacks = E.this.b;
                    long j = this.f1936a;
                    D.a(strB, ((long) iA) * 1000, loginAuthCallbacks, j, this.b, j);
                    Q.a("ProcessShanYanLogger", "start getToken", strB, Integer.valueOf(iA));
                    int iHashCode = strB.hashCode();
                    if (iHashCode != 2078865) {
                        if (iHashCode == 2079826 && strB.equals("CUCC")) {
                            b = 0;
                        } else {
                            b = -1;
                        }
                    } else if (strB.equals("CTCC")) {
                        b = 1;
                    } else {
                        b = -1;
                    }
                    if (b != 0) {
                        if (b != 1) {
                            String strA = p0.a(E.this.f1935a, "cl_jm_g1", "cm");
                            Q.a("ProcessShanYanLogger", "cmChannelType", strA);
                            E.this.a(this.c, strB, this.f1936a, this.b, this.d, "cl_jm_e3", EnumC0611q.CMCC_UNAVAILABLE_CODE, strA);
                        } else {
                            String strA2 = p0.a(E.this.f1935a, "cl_jm_g2", "ct");
                            Q.a("ProcessShanYanLogger", "ctChannelType", strA2);
                            E.this.a(this.c, strB, this.f1936a, this.b, this.d, "cl_jm_e5", EnumC0611q.CTCC_UNAVAILABLE_CODE, strA2);
                        }
                    } else {
                        if (k0.b().a(this.c, strB, this.f1936a, this.b, this.d)) {
                            return;
                        }
                        String strA3 = p0.a(E.this.f1935a, "cl_jm_g3", "cu");
                        Q.a("ProcessShanYanLogger", "cuChannelType", strA3);
                        E.this.a(this.c, strB, this.f1936a, this.b, this.d, "cl_jm_e4", EnumC0611q.CUCC_UNAVAILABLE_CODE, strA3);
                    }
                } catch (Exception e) {
                    E.this.a(C0616v.g().b(E.this.f1935a), this.f1936a, this.b, this.d, "startGetToken Exception" + e);
                }
            } finally {
                AbstractC0606l.w.set(AbstractC0606l.r);
            }
        }
    }

    class b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Context f1937a;

        b(Context context) {
            this.f1937a = context;
        }

        @Override // java.lang.Runnable
        public void run() {
            a0.b().c(this.f1937a);
        }
    }

    class c implements GenLoginClickListener {
        c() {
        }

        @Override // com.cmic.gen.sdk.view.GenLoginClickListener
        public void onLoginClickComplete(Context context, JSONObject jSONObject) {
        }

        @Override // com.cmic.gen.sdk.view.GenLoginClickListener
        public void onLoginClickStart(Context context, JSONObject jSONObject) {
        }
    }

    private class d implements GenTokenListener {
        private d() {
        }

        @Override // com.cmic.gen.sdk.auth.GenTokenListener
        public void onGetTokenComplete(int i, JSONObject jSONObject) {
            try {
                Q.c("LogInfoShanYanLogger", "cm onGetTokenComplete", jSONObject, Integer.valueOf(i));
                GenAuthnHelper.getInstance(E.this.f1935a).quitAuthActivity();
                if (jSONObject == null) {
                    E.this.a(-1, (String) null, "login response isEmpty");
                    return;
                }
                int iOptInt = jSONObject.optInt("resultCode");
                String strOptString = jSONObject.optString("desc");
                String strOptString2 = jSONObject.optString("traceId");
                if (jSONObject.has(Constants.TOKEN) && iOptInt == 103000) {
                    String strOptString3 = jSONObject.optString(Constants.TOKEN);
                    if (AbstractC0600f.a(strOptString3)) {
                        E.this.a(iOptInt, strOptString, "token is empty" + strOptString2);
                        return;
                    }
                    AbstractC0606l.p = com.cmic.gen.sdk.f.i.b(E.this.f1935a);
                    p0.b(E.this.f1935a, "cl_jm_f8", AbstractC0606l.p);
                    p0.b(E.this.f1935a, "cl_jm_f7", E.this.a(strOptString3));
                    String str = E.this.g;
                    AbstractC0606l.m = str;
                    E e = E.this;
                    e.a(str, e.e, E.this.d, E.this.c);
                    return;
                }
                E.this.a(iOptInt, strOptString, strOptString2);
            } catch (Exception e2) {
                GenAuthnHelper.getInstance(E.this.f1935a).quitAuthActivity();
                E.this.a(C0616v.g().b(E.this.f1935a), E.this.e, E.this.d, E.this.c, "onGetTokenComplete Exception" + e2);
            }
        }

        /* synthetic */ d(E e, a aVar) {
            this();
        }
    }

    private E() {
    }

    public static E a() {
        if (m == null) {
            synchronized (E.class) {
                if (m == null) {
                    m = new E();
                }
            }
        }
        return m;
    }

    public void a(Context context, String str, ExecutorService executorService) {
        this.f1935a = context;
        this.f = str;
        this.j = executorService;
    }

    public void a(int i, long j, long j2) {
        this.b = new S(this.f1935a);
        long jUptimeMillis = SystemClock.uptimeMillis();
        AbstractC0601g.d(this.f1935a);
        a(this.f1935a);
        Context context = this.f1935a;
        if (context != null && this.j != null) {
            if (AbstractC0606l.t == AbstractC0606l.w.getAndSet(AbstractC0606l.t)) {
                Q.d("ExceptionShanYanLogger", "startGetToken is in progress");
                return;
            } else {
                this.j.execute(new a(j, j2, i, jUptimeMillis));
                return;
            }
        }
        Q.d("ExceptionShanYanLogger", "startGetToken context", context, this.j);
        LoginAuthCallbacks loginAuthCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.NOT_INITIALIZED_CODE;
        loginAuthCallbacks.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + ":startGetToken()", "Unknown_Operator", j, j2, jUptimeMillis);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, String str, long j, long j2, long j3, String str2, EnumC0611q enumC0611q, String str3) {
        int iA = p0.a(this.f1935a, str2, AbstractC0612r.c);
        Q.a("ProcessShanYanLogger", "channelSwitch", Integer.valueOf(iA));
        if (iA != 1 && iA != 2) {
            this.b.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), str, j, j2, j3);
            return;
        }
        if (!"cu".equals(str3) && !"ct".equals(str3)) {
            a(str, j, j2, j3, iA);
            return;
        }
        boolean zD = t0.h().d(this.f1935a);
        Q.a("ProcessShanYanLogger", "startGetToken status", Boolean.valueOf(zD));
        String strA = p0.a(this.f1935a, "cl_jm_f7", "");
        if (zD && !AbstractC0600f.a(strA)) {
            a(AbstractC0606l.m, j, j2, j3);
        } else {
            k0.b().a(i, str, j, j2);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, long j, long j2, long j3, String str2) {
        Q.d("ExceptionShanYanLogger", str2);
        LoginAuthCallbacks loginAuthCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
        loginAuthCallbacks.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + str2, str, j, j2, j3);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, String str, String str2) {
        LoginAuthCallbacks loginAuthCallbacks = this.b;
        EnumC0611q enumC0611q = EnumC0611q.REQUEST_TOKEN_ERROR_CODE;
        int iD = enumC0611q.d();
        if (i == -1) {
            i = enumC0611q.b();
        }
        if (str == null) {
            str = enumC0611q.e();
        }
        String str3 = str;
        if (str2 == null) {
            str2 = enumC0611q.c();
        }
        loginAuthCallbacks.getTokenFailed(iD, i, str3, str2, this.g, this.e, this.d, this.c);
    }

    private void a(Context context) {
        ExecutorService executorService = this.k;
        if (executorService == null || executorService.isShutdown()) {
            this.k = new ThreadPoolExecutor(8, Integer.MAX_VALUE, 120L, TimeUnit.SECONDS, new LinkedBlockingDeque());
        }
        this.k.execute(new b(context));
    }

    public void a(String str, long j, long j2, long j3, int i) {
        this.e = j;
        this.d = j2;
        this.c = j3;
        this.g = str;
        if (i == 1) {
            this.h = "1";
        } else {
            this.h = "5";
        }
        GenAuthnHelper.getInstance(this.f1935a).setAuthThemeConfig(new GenAuthThemeConfig.Builder().setPrivacyState(true).setLogBtnClickListener(new c()).build());
        GenAuthnHelper.getInstance(this.f1935a).setOverTime((p0.a(this.f1935a, "cl_jm_e8", 6) + 1) * 1000);
        this.l = p0.a(this.f1935a, "cl_jm_a9", "");
        String strA = p0.a(this.f1935a, "cl_jm_c7", "");
        if (this.i == null) {
            this.i = new d(this, null);
        }
        Q.a("ProcessShanYanLogger", "start  cm loginAuth", this.l);
        GenAuthnHelper.getInstance(this.f1935a).loginAuth(this.l, strA, this.i);
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
        return this.h + this.l + "," + str2 + str;
    }

    public void a(String str, long j, long j2, long j3) {
        String str2;
        try {
            String strA = p0.a(this.f1935a, "cl_jm_f7", "");
            if (AbstractC0600f.a(strA)) {
                a(-1, (String) null, "accessCode is empty");
                return;
            }
            String strSubstring = strA.substring(0, 1);
            int iIndexOf = strA.indexOf(44);
            String strSubstring2 = strA.substring(1, iIndexOf);
            String strSubstring3 = strA.substring(iIndexOf + 1);
            String strA2 = p0.a(this.f1935a, "cl_jm_d9", "");
            String strA3 = p0.a(this.f1935a, "cl_jm_c3", "");
            String strA4 = p0.a(this.f1935a, "cl_jm_c2", "");
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(IAdInterListener.AdReqParam.AP, strA3);
            jSONObject.put("tk", strSubstring3);
            jSONObject.put("au", strA2);
            String strB = AbstractC0601g.b(this.f1935a);
            String strA5 = p0.a(this.f1935a, "cl_jm_f8", "");
            String strB2 = AbstractC0596b.b(this.f);
            String strSubstring4 = strB2.substring(0, 16);
            String strSubstring5 = strB2.substring(16);
            String str3 = Base64.encodeToString(AbstractC0596b.a(strA5.getBytes("UTF-8"), strSubstring4, strSubstring5), 11) + "," + strB;
            String strA6 = p0.a(this.f1935a, "cl_jm_a3", "");
            p0.b(this.f1935a, "cl_jm_f5", str3);
            jSONObject.put("dd", strA6 + "," + str3);
            jSONObject.put("ud", p0.a(this.f1935a, "cl_jm_a2", ""));
            jSONObject.put("vs", "2.3.7.5");
            jSONObject.put("tp", "0");
            jSONObject.put("nlt", "1");
            jSONObject.put(ClickCommon.CLICK_SCENE_AD, strSubstring2);
            String strEncodeToString = Base64.encodeToString(AbstractC0596b.a(jSONObject.toString().getBytes("UTF-8"), strSubstring4, strSubstring5), 11);
            JSONObject jSONObject2 = new JSONObject();
            if (AbstractC0600f.b(strA4) && "1".equals(strA4)) {
                str2 = "A" + strSubstring + strA3 + "-" + strEncodeToString;
            } else {
                str2 = "A" + strSubstring + "-" + strEncodeToString;
            }
            jSONObject2.put(Constants.TOKEN, str2);
            String string = jSONObject2.toString();
            Q.a("ProcessShanYanLogger", "token id", strA3, Integer.valueOf(iIndexOf), str, strSubstring2);
            Q.c("LogInfoShanYanLogger", "pre token", strSubstring4, strSubstring5, jSONObject);
            LoginAuthCallbacks loginAuthCallbacks = this.b;
            EnumC0611q enumC0611q = EnumC0611q.LOGIN_SUCCESS_CODE;
            loginAuthCallbacks.getTokenSuccessed(enumC0611q.d(), enumC0611q.b(), string, enumC0611q.c(), j, j2, j3);
        } catch (Exception e) {
            a(str, j, j2, j3, "getMobileNum Exception" + e);
        }
    }
}
