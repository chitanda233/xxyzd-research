package com.chuanglan.shanyan_sdk;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import com.alipay.sdk.app.AlipayApi;
import com.byazt.nys.PluginConstants;
import com.chuanglan.shanyan_sdk.listener.ActionListener;
import com.chuanglan.shanyan_sdk.listener.AuthPageActionListener;
import com.chuanglan.shanyan_sdk.listener.AuthenticationExecuteListener;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoListener;
import com.chuanglan.shanyan_sdk.listener.InitListener;
import com.chuanglan.shanyan_sdk.listener.LoginActivityStatusListener;
import com.chuanglan.shanyan_sdk.listener.OnClickPrivacyListener;
import com.chuanglan.shanyan_sdk.listener.OneKeyLoginListener;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthListener;
import com.chuanglan.shanyan_sdk.listener.PricacyOnClickListener;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import com.chuanglan.shanyan_sdk.view.ShanYanOneKeyActivity;
import java.lang.ref.WeakReference;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingDeque;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
public class t0 {
    private static volatile t0 p;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2002a;
    private OpenLoginAuthListener e;
    private OneKeyLoginListener f;
    private ActionListener g;
    private ExecutorService h;
    private ViewGroup i;
    private CheckBox m;
    private Button n;
    private boolean o;
    private volatile CopyOnWriteArrayList b = new CopyOnWriteArrayList();
    private volatile CopyOnWriteArrayList c = new CopyOnWriteArrayList();
    private volatile CopyOnWriteArrayList d = new CopyOnWriteArrayList();
    private ShanYanUIConfig j = null;
    private ShanYanUIConfig k = null;
    private ShanYanUIConfig l = null;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Context f2003a;

        a(Context context) {
            this.f2003a = context;
        }

        @Override // java.lang.Runnable
        public void run() {
            a0.b().c(this.f2003a);
        }
    }

    class b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2004a;
        final /* synthetic */ int b;
        final /* synthetic */ String c;
        final /* synthetic */ String d;
        final /* synthetic */ int e;
        final /* synthetic */ String f;
        final /* synthetic */ int g;
        final /* synthetic */ long h;
        final /* synthetic */ long i;
        final /* synthetic */ long j;

        b(int i, int i2, String str, String str2, int i3, String str3, int i4, long j, long j2, long j3) {
            this.f2004a = i;
            this.b = i2;
            this.c = str;
            this.d = str2;
            this.e = i3;
            this.f = str3;
            this.g = i4;
            this.h = j;
            this.i = j2;
            this.j = j3;
        }

        /* JADX WARN: Multi-variable type inference failed */
        @Override // java.lang.Runnable
        public void run() {
            char c = 2;
            int i = 1;
            char c2 = 0;
            try {
                int i2 = 0;
                for (InitListener initListener : t0.this.b) {
                    Integer numValueOf = Integer.valueOf(this.f2004a);
                    Integer numValueOf2 = Integer.valueOf(this.b);
                    String str = this.c;
                    String str2 = this.d;
                    Object[] objArr = new Object[6];
                    objArr[c2] = "initCallBack code";
                    objArr[i] = numValueOf;
                    objArr[c] = "processName";
                    objArr[3] = numValueOf2;
                    objArr[4] = str;
                    objArr[5] = str2;
                    Q.a("ProcessShanYanLogger", objArr);
                    initListener.getInitStatus(this.f2004a, this.d);
                    if (t0.this.b.size() > i) {
                        i2 = i;
                    }
                    A.g().a(this.f2004a, this.e, this.d, this.f, this.c, this.b, 1, this.g, this.h, this.i, this.j, i2, 1);
                    c = 2;
                    i = 1;
                    c2 = 0;
                }
                t0.this.b.clear();
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "initCallBack Exception", e);
            }
        }
    }

    class c implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2005a;
        final /* synthetic */ int b;
        final /* synthetic */ String c;
        final /* synthetic */ String d;
        final /* synthetic */ int e;
        final /* synthetic */ String f;
        final /* synthetic */ int g;
        final /* synthetic */ int h;
        final /* synthetic */ long i;
        final /* synthetic */ long j;
        final /* synthetic */ long k;

        c(int i, int i2, String str, String str2, int i3, String str3, int i4, int i5, long j, long j2, long j3) {
            this.f2005a = i;
            this.b = i2;
            this.c = str;
            this.d = str2;
            this.e = i3;
            this.f = str3;
            this.g = i4;
            this.h = i5;
            this.i = j;
            this.j = j2;
            this.k = j3;
        }

        /* JADX WARN: Multi-variable type inference failed */
        @Override // java.lang.Runnable
        public void run() {
            char c = 2;
            int i = 1;
            char c2 = 0;
            try {
                int i2 = 0;
                for (GetPhoneInfoListener getPhoneInfoListener : t0.this.c) {
                    Integer numValueOf = Integer.valueOf(this.f2005a);
                    Integer numValueOf2 = Integer.valueOf(this.b);
                    String str = this.c;
                    String str2 = this.d;
                    Object[] objArr = new Object[6];
                    objArr[c2] = "preInfoCallBack code";
                    objArr[i] = numValueOf;
                    objArr[c] = "processName";
                    objArr[3] = numValueOf2;
                    objArr[4] = str;
                    objArr[5] = str2;
                    Q.a("ProcessShanYanLogger", objArr);
                    getPhoneInfoListener.getPhoneInfoStatus(this.f2005a, this.d);
                    if (t0.this.c.size() > i) {
                        i2 = i;
                    }
                    A.g().a(this.f2005a, this.e, this.d, this.f, this.c, this.b, this.g, this.h, this.i, this.j, this.k, i2, 1);
                    c = 2;
                    i = 1;
                    c2 = 0;
                }
                t0.this.c.clear();
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getPhoneInfoCallBack Exception", e);
            }
        }
    }

    class d implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2006a;
        final /* synthetic */ String b;
        final /* synthetic */ String c;

        d(int i, String str, String str2) {
            this.f2006a = i;
            this.b = str;
            this.c = str2;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                Q.a("ProcessShanYanLogger", "start activity CallBack", Integer.valueOf(this.f2006a), this.b, Integer.valueOf(AbstractC0606l.v.get()), this.c);
                if (t0.this.e != null) {
                    t0.this.e.getOpenLoginAuthStatus(this.f2006a, this.c);
                    t0.this.e = null;
                }
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getOpenLoginAuthStatus Exception", e);
            }
        }
    }

    class e implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2007a;
        final /* synthetic */ String b;
        final /* synthetic */ String c;
        final /* synthetic */ int d;
        final /* synthetic */ String e;
        final /* synthetic */ int f;
        final /* synthetic */ int g;
        final /* synthetic */ long h;
        final /* synthetic */ long i;
        final /* synthetic */ long j;

        e(int i, String str, String str2, int i2, String str3, int i3, int i4, long j, long j2, long j3) {
            this.f2007a = i;
            this.b = str;
            this.c = str2;
            this.d = i2;
            this.e = str3;
            this.f = i3;
            this.g = i4;
            this.h = j;
            this.i = j2;
            this.j = j3;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                Q.a("ProcessShanYanLogger", "get token CallBack", Integer.valueOf(this.f2007a), com.alipay.sdk.m.y.o.c, this.b, this.c);
                if (t0.this.f != null) {
                    t0.this.f.getOneKeyLoginStatus(this.f2007a, this.c);
                }
                if (t0.this.n != null) {
                    t0.this.n.setClickable(true);
                }
                if (this.f2007a != EnumC0611q.USER_CANCEL_CODE.d()) {
                    t0.h().d();
                    if (t0.this.o) {
                        t0.this.f();
                    }
                }
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getLoginTokenCallBack Exception", e);
            }
            A.g().a(this.f2007a, this.d, this.c, this.e, this.b, 4, this.f, this.g, this.h, this.i, this.j, false, 1);
        }
    }

    class f implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2008a;
        final /* synthetic */ String b;
        final /* synthetic */ String c;
        final /* synthetic */ int d;
        final /* synthetic */ String e;
        final /* synthetic */ int f;
        final /* synthetic */ int g;
        final /* synthetic */ long h;
        final /* synthetic */ long i;
        final /* synthetic */ long j;

        f(int i, String str, String str2, int i2, String str3, int i3, int i4, long j, long j2, long j3) {
            this.f2008a = i;
            this.b = str;
            this.c = str2;
            this.d = i2;
            this.e = str3;
            this.f = i3;
            this.g = i4;
            this.h = j;
            this.i = j2;
            this.j = j3;
        }

        /* JADX WARN: Multi-variable type inference failed */
        @Override // java.lang.Runnable
        public void run() {
            char c = 2;
            int i = 1;
            char c2 = 0;
            try {
                int i2 = 0;
                for (AuthenticationExecuteListener authenticationExecuteListener : t0.this.d) {
                    Integer numValueOf = Integer.valueOf(this.f2008a);
                    String str = this.b;
                    String str2 = this.c;
                    Object[] objArr = new Object[4];
                    objArr[c2] = "getAuthTokenCallBack code";
                    objArr[i] = numValueOf;
                    objArr[c] = str;
                    objArr[3] = str2;
                    Q.a("ProcessShanYanLogger", objArr);
                    authenticationExecuteListener.authenticationRespond(this.f2008a, this.c);
                    if (t0.this.d.size() > i) {
                        i2 = i;
                    }
                    A.g().a(this.f2008a, this.d, this.c, this.e, this.b, 11, this.f, this.g, this.h, this.i, this.j, i2, 1);
                    c = 2;
                    i = 1;
                    c2 = 0;
                }
                t0.this.d.clear();
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getAuthTokenCallBack Exception", e);
            }
        }
    }

    class g implements AuthPageActionListener {
        g() {
        }

        @Override // com.chuanglan.shanyan_sdk.listener.AuthPageActionListener
        public void setAuthPageActionListener(int i, int i2, String str) {
            if (t0.this.g != null) {
                t0.this.g.ActionListner(i, i2, str);
            }
            Q.a("ProcessShanYanLogger", "setAuthPageActionListener type", Integer.valueOf(i), PluginConstants.KEY_ERROR_CODE, Integer.valueOf(i2), "message", str);
        }
    }

    private t0() {
    }

    public boolean i() {
        Q.a("ProcessShanYanLogger", "getPreIntStatus");
        return p0.a(this.f2002a, "cl_jm_f4", false);
    }

    public CheckBox j() {
        Q.a("ProcessShanYanLogger", "getPrivacyCheckBox");
        return this.m;
    }

    public void k() {
        CheckBox checkBox;
        try {
            Q.a("ProcessShanYanLogger", "performLoginClick");
            if (this.n == null || (checkBox = this.m) == null || !checkBox.isChecked() || this.m.getVisibility() != 0) {
                return;
            }
            this.n.performClick();
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public void l() {
        Q.a("ProcessShanYanLogger", "removeAllListener");
        AbstractC0606l.Q = null;
        AbstractC0606l.R = null;
        this.e = null;
        this.f = null;
        this.g = null;
    }

    public void m() {
        Q.a("UIShanYanLogger", "setAuthThemeConfig innerSet", Boolean.valueOf(this.k == null), Boolean.valueOf(this.l == null), Boolean.valueOf(this.j == null));
        if (this.k == null && this.l == null && this.j == null) {
            ShanYanUIConfig shanYanUIConfigBuild = new ShanYanUIConfig.Builder().build();
            com.chuanglan.shanyan_sdk.tool.a.b().a(shanYanUIConfigBuild, shanYanUIConfigBuild, shanYanUIConfigBuild);
        }
        com.chuanglan.shanyan_sdk.tool.a.b().a(this.k, this.l, this.j);
    }

    public void n() {
        Q.a("ProcessShanYanLogger", "unregisterOnClickPrivacyListener");
        AbstractC0606l.Q = null;
        AbstractC0606l.R = null;
    }

    public static t0 h() {
        if (p == null) {
            synchronized (t0.class) {
                if (p == null) {
                    p = new t0();
                }
            }
        }
        return p;
    }

    public void b(int i, int i2, String str, String str2, String str3, int i3, int i4, long j, long j2, long j3) {
        AbstractC0601g.a(new f(i, str3, str, i2, str2, i3, i4, j, j2, j3));
    }

    public void c(int i, int i2, String str, String str2, String str3, int i3, int i4, long j, long j2, long j3) {
        AbstractC0601g.a(new e(i, str3, str, i2, str2, i3, i4, j, j2, j3));
    }

    public void d(int i, int i2, String str, String str2, String str3, int i3, int i4, long j, long j2, long j3) {
        AbstractC0601g.a(new b(i, i3, str3, str, i2, str2, i4, j, j2, j3));
    }

    public void e(Context context) {
        Q.a("ProcessShanYanLogger", "registerActivityLifecycleCallbacks");
        if (context != null) {
            A.g().a(context.getApplicationContext());
        }
    }

    public void f(boolean z) {
        Q.a("ProcessShanYanLogger", "setLoadingVisibility", Boolean.valueOf(z));
        try {
            ViewGroup viewGroup = this.i;
            if (viewGroup != null) {
                if (z) {
                    viewGroup.setVisibility(0);
                } else {
                    viewGroup.setVisibility(8);
                }
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "setLoadingVisibility Exception", e2);
        }
    }

    public void g(boolean z) {
        Q.a("ProcessShanYanLogger", "setReadPhoneStatePermissionEnable", Boolean.valueOf(z));
        AbstractC0606l.E = z;
    }

    public void a(Context context, String str, InitListener initListener) {
        try {
            Q.a("ProcessShanYanLogger", "initialization");
            if (AbstractC0601g.a(1, context)) {
                this.f2002a = context;
                this.b.add(initListener);
                N.b().a(context, str);
                N.b().a(System.currentTimeMillis(), SystemClock.uptimeMillis());
                Q.a("ProcessShanYanLogger", "initialization version", "2.3.7.5", "JC", AlipayApi.c, str, "packageSign", C0616v.g().d(context), "packageName", C0616v.g().c(context));
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "initialization Exception", e2);
        }
    }

    public void b() {
        try {
            Q.a("ProcessShanYanLogger", "inner init clear");
            p0.b(this.f2002a, "cl_jm_b2", 0L);
            p0.b(this.f2002a, "cl_jm_f2", false);
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "clearInitCache Exception=", e2);
        }
    }

    public void c() {
        Q.a("ProcessShanYanLogger", "clearScripCache");
        d();
    }

    public void d() {
        Q.a("ProcessShanYanLogger", "inner preInfo clear");
        p0.b(this.f2002a, "cl_jm_f4", false);
        p0.b(this.f2002a, "cl_jm_d8", 0L);
    }

    public void i(boolean z) {
        Q.a("ProcessShanYanLogger", "unregisterActivityLifecycleCallbacks", Boolean.valueOf(z));
        if (this.f2002a != null) {
            A.g().b(this.f2002a.getApplicationContext());
        }
    }

    public Activity g() {
        Q.a("ProcessShanYanLogger", "getAuthActivity");
        try {
            WeakReference<ShanYanOneKeyActivity> weakReference = ShanYanOneKeyActivity.mLoginActivityWeakReference;
            if (weakReference == null) {
                Q.a("ProcessShanYanLogger", "getAuthActivity: weakRef is null");
                return null;
            }
            ShanYanOneKeyActivity shanYanOneKeyActivity = weakReference.get();
            if (shanYanOneKeyActivity == null) {
                Q.a("ProcessShanYanLogger", "getAuthActivity: activity is null");
                return null;
            }
            if (shanYanOneKeyActivity.isFinishing()) {
                Q.a("ProcessShanYanLogger", "getAuthActivity: activity is finishing");
                return null;
            }
            if (shanYanOneKeyActivity.isDestroyed()) {
                Q.a("ProcessShanYanLogger", "getAuthActivity: activity is destroyed");
                return null;
            }
            Q.a("ProcessShanYanLogger", "getAuthActivity: returning valid activity");
            return shanYanOneKeyActivity;
        } catch (Exception e2) {
            Q.d("ExceptionShanYanLogger", "getAuthActivity Exception", e2);
            return null;
        }
    }

    public void c(boolean z) {
        Q.a("ProcessShanYanLogger", "getIpEnable", Boolean.valueOf(z));
        AbstractC0606l.F = z;
    }

    public void e() {
        x0.a(this.i);
        this.i = null;
    }

    public boolean c(Context context) {
        try {
            boolean zA = p0.a(context, "cl_jm_f4", false);
            Q.a("ProcessShanYanLogger", "save info", Boolean.valueOf(zA));
            if (!zA) {
                return false;
            }
            String strA = p0.a(context, "cl_jm_f8", "");
            Q.a("ProcessShanYanLogger", "fakeNumber", strA);
            if (AbstractC0600f.a(strA) || C0616v.g().e(context) < 1) {
                return false;
            }
            boolean zB = AbstractC0610p.b(context, "scripCache_sub");
            Q.a("ProcessShanYanLogger", "isChange", Boolean.valueOf(zB));
            if (zB) {
                return false;
            }
            long jCurrentTimeMillis = System.currentTimeMillis();
            long jA = p0.a(context, "cl_jm_d8", 1L);
            Q.a("ProcessShanYanLogger", "time", Long.valueOf(jCurrentTimeMillis), Long.valueOf(jA));
            if (jCurrentTimeMillis > jA) {
                return false;
            }
            String strA2 = p0.a(context, "cl_jm_f6", "");
            String strA3 = p0.a(context, "cl_jm_g3", "");
            String strA4 = p0.a(context, "cl_jm_g2", "");
            boolean z = "CUCC".equals(strA2) && "cu".equals(strA3);
            boolean z2 = "CTCC".equals(strA2) && "ct".equals(strA4);
            if (!z && !z2) {
                return true;
            }
            String strA5 = p0.a(context, "cl_jm_f7", "");
            Q.a("ProcessShanYanLogger", "accessCode", strA5);
            return AbstractC0600f.b(strA5);
        } catch (Exception e2) {
            e2.printStackTrace();
            return false;
        }
    }

    public void d(boolean z) {
        Q.a("ProcessShanYanLogger", "getOaidEnable", Boolean.valueOf(z));
        AbstractC0606l.J = z;
    }

    public void e(boolean z) {
        Q.a("ProcessShanYanLogger", "setCheckBoxValue", Boolean.valueOf(z));
        CheckBox checkBox = this.m;
        if (checkBox != null) {
            checkBox.setChecked(z);
        }
    }

    public void b(boolean z) {
        Q.a("ProcessShanYanLogger", "getImeiEnable", Boolean.valueOf(z));
    }

    public boolean d(Context context) {
        boolean zC = c(context);
        Q.a("ProcessShanYanLogger", "final info", Boolean.valueOf(zC));
        return zC;
    }

    public String b(Context context) {
        String strB;
        String str = "Unknown_Operator";
        try {
            if (!AbstractC0606l.U.get() && !"Unknown_Operator".equals(AbstractC0606l.q)) {
                strB = AbstractC0606l.q;
                Q.a("ProcessShanYanLogger", "currentOperarotType auth: " + strB);
            } else {
                strB = C0616v.g().b(context);
                Q.a("ProcessShanYanLogger", "getCurrentOperatorType: " + strB);
            }
            str = strB;
        } catch (Exception e2) {
            Q.b("ProcessShanYanLogger", "getOperatorInfo error", e2);
        }
        return AbstractC0600f.c(str);
    }

    public void h(boolean z) {
        Q.a("ProcessShanYanLogger", "setRunningAppProcessesEnable", Boolean.valueOf(z));
        AbstractC0606l.D = z;
    }

    public void f() {
        Q.a("ProcessShanYanLogger", "finishAuthActivity");
        try {
            WeakReference<ShanYanOneKeyActivity> weakReference = ShanYanOneKeyActivity.mLoginActivityWeakReference;
            if (weakReference == null) {
                Q.a("ProcessShanYanLogger", "finishAuthActivity: weakRef is null");
                return;
            }
            ShanYanOneKeyActivity shanYanOneKeyActivity = weakReference.get();
            if (shanYanOneKeyActivity == null) {
                Q.a("ProcessShanYanLogger", "finishAuthActivity: activity is null");
            } else if (shanYanOneKeyActivity.isFinishing()) {
                Q.a("ProcessShanYanLogger", "finishAuthActivity: activity already finishing");
            } else {
                shanYanOneKeyActivity.finish();
                Q.a("ProcessShanYanLogger", "finishAuthActivity: activity finished successfully");
            }
        } catch (Exception e2) {
            Q.d("ExceptionShanYanLogger", "finishAuthActivity Exception", e2);
        }
    }

    public void a(GetPhoneInfoListener getPhoneInfoListener) {
        try {
            Q.a("ProcessShanYanLogger", "getPhoneInfo", "2.3.7.5");
            if (AbstractC0601g.a(2, this.f2002a)) {
                this.c.add(getPhoneInfoListener);
                k0.b().a(2, null, System.currentTimeMillis(), SystemClock.uptimeMillis());
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "getPhoneInfo Exception", e2);
        }
    }

    private void a(Context context) {
        ExecutorService executorService = this.h;
        if (executorService == null || executorService.isShutdown()) {
            this.h = new ThreadPoolExecutor(8, Integer.MAX_VALUE, 120L, TimeUnit.SECONDS, new LinkedBlockingDeque());
        }
        this.h.execute(new a(context));
    }

    public void a(AuthenticationExecuteListener authenticationExecuteListener) {
        try {
            Q.a("ProcessShanYanLogger", "startAuthentication");
            if (AbstractC0601g.a(11, this.f2002a)) {
                this.d.add(authenticationExecuteListener);
                C0604j.a().a(System.currentTimeMillis(), SystemClock.uptimeMillis());
                a(this.f2002a);
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "startAuthentication Exception", e2);
        }
    }

    public void a(int i, int i2, String str, String str2, String str3, int i3, int i4, int i5, long j, long j2, long j3) {
        AbstractC0601g.a(new c(i, i3, str3, str, i2, str2, i4, i5, j, j2, j3));
    }

    public void a(int i, int i2, String str, String str2, String str3, int i3, int i4, long j, long j2, long j3) {
        if (this.e != null) {
            AbstractC0601g.a(new d(i, str3, str));
            A.g().a(i, i2, str, str2, str3, 3, i3, i4, j, j2, j3, false, 1);
        }
    }

    public void a() {
        try {
            b();
            d();
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "clearInitCache Exception=", e2);
        }
    }

    public void a(boolean z) {
        Q.a("ProcessShanYanLogger", "checkProcessesEnable", Boolean.valueOf(z));
        AbstractC0606l.C = z;
    }

    public void a(boolean z, String[] strArr) {
        Q.a("ProcessShanYanLogger", "setPrivacyUrlWhiteList", Boolean.valueOf(z));
        AbstractC0606l.K = z;
        AbstractC0606l.L.clear();
        if (strArr != null) {
            for (String str : strArr) {
                if (str != null && !str.isEmpty()) {
                    AbstractC0606l.L.add(str);
                }
            }
        }
    }

    public void a(ViewGroup viewGroup) {
        this.i = viewGroup;
    }

    public void a(ShanYanUIConfig shanYanUIConfig, ShanYanUIConfig shanYanUIConfig2, ShanYanUIConfig shanYanUIConfig3) {
        Q.a("UIShanYanLogger", "setAuthThemeConfig");
        this.l = shanYanUIConfig2;
        this.j = shanYanUIConfig3;
        if (shanYanUIConfig != null) {
            this.k = shanYanUIConfig;
            Q.a("UIShanYanLogger", "setAuthThemeConfig portraitUIConfig", shanYanUIConfig.toString());
        } else if (shanYanUIConfig2 != null) {
            this.k = shanYanUIConfig2;
        }
        if (shanYanUIConfig2 != null) {
            Q.a("UIShanYanLogger", "setAuthThemeConfig landUIConfig", shanYanUIConfig2.toString());
        }
        if (shanYanUIConfig3 != null) {
            Q.a("UIShanYanLogger", "setAuthThemeConfig shanYanUIConfig", shanYanUIConfig3.toString());
        }
    }

    public void a(boolean z, OpenLoginAuthListener openLoginAuthListener, OneKeyLoginListener oneKeyLoginListener) {
        try {
            Q.a("ProcessShanYanLogger", "openLoginAuth", Boolean.valueOf(z), "2.3.7.5");
            this.o = z;
            this.e = openLoginAuthListener;
            this.f = oneKeyLoginListener;
            if (AbstractC0601g.a(3, this.f2002a)) {
                T.a().a(3, System.currentTimeMillis(), SystemClock.uptimeMillis());
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "openLoginAuth Exception", e2);
        }
    }

    public void a(ActionListener actionListener) {
        try {
            Q.a("ProcessShanYanLogger", "setActionListener");
            this.g = actionListener;
            AbstractC0606l.S = new g();
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public void a(CheckBox checkBox) {
        this.m = checkBox;
    }

    public void a(Button button) {
        this.n = button;
    }

    public void a(Context context, String str, String str2) {
        Q.a("ProcessShanYanLogger", "startPrivacyProtocolActivity", str, str2);
        AbstractC0595a.a(context, str, str2);
    }

    public void a(LoginActivityStatusListener loginActivityStatusListener) {
        Q.a("ProcessShanYanLogger", "setLoginActivityStatusListener");
        AbstractC0606l.T = loginActivityStatusListener;
    }

    public void a(OnClickPrivacyListener onClickPrivacyListener) {
        Q.a("ProcessShanYanLogger", "setOnClickPrivacyListener");
        AbstractC0606l.Q = onClickPrivacyListener;
    }

    public void a(PricacyOnClickListener pricacyOnClickListener) {
        Q.a("ProcessShanYanLogger", "setPrivacyOnClickListener");
        AbstractC0606l.R = pricacyOnClickListener;
    }
}
