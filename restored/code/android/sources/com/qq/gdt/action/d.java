package com.qq.gdt.action;

import android.app.Activity;
import android.content.Context;
import android.content.IntentFilter;
import android.content.SharedPreferences;
import android.net.Uri;
import android.os.Build;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.os.SystemClock;
import android.text.TextUtils;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.qq.gdt.action.i.h;
import com.qq.gdt.action.i.j;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.q;
import com.qq.gdt.action.i.t;
import com.qq.gdt.action.i.u;
import com.qq.gdt.action.i.v;
import com.qq.gdt.action.multioprocess.UserMessageChangeReceiver;
import com.tencent.turingfd.sdk.ams.ad.ITuringIoTFeatureMap;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
import java.util.concurrent.atomic.AtomicLong;
import java.util.regex.Pattern;
import javax.crypto.SecretKey;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private static volatile d c;
    private static Handler p;
    private volatile JSONObject E;
    private volatile PrivateController F;
    private volatile Context G;
    private String L;
    private volatile Context l;
    private volatile String m;
    private volatile String n;
    private volatile SecretKey o;
    private volatile String u;
    private static final String b = "GDTAction初始化成功（sdkv: " + e.a() + ", sdkvc: " + e.b() + "）";
    private static volatile boolean d = false;
    private static volatile boolean e = false;
    private static volatile boolean f = false;
    private static volatile boolean g = false;
    private static volatile boolean h = false;
    private static volatile String i = "";
    private static volatile boolean j = false;
    private static volatile boolean k = false;
    private static final Pattern w = Pattern.compile("^[a-zA-Z0-9_.-]{1,200}$", 2);
    private static volatile boolean B = true;
    private static volatile String K = "";
    private final String q = UUID.randomUUID().toString().replaceAll("-", "");
    private AtomicLong r = new AtomicLong(0);
    private AtomicLong s = new AtomicLong(0);
    private String t = "";
    private volatile ChannelType v = ChannelType.CHANNEL_TENCENT;
    private long x = -1;
    private long y = -1;
    private boolean z = true;
    private long A = -1;
    private volatile String C = "";
    private volatile boolean D = false;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile long f3026a = 0;
    private volatile boolean H = false;
    private volatile boolean I = true;
    private volatile boolean J = true;

    private d() {
        p = new Handler(Looper.getMainLooper()) { // from class: com.qq.gdt.action.d.1
            @Override // android.os.Handler
            public void handleMessage(Message message) {
                if (message.what == 1) {
                    d.this.H();
                    GDTAction.logAction("TICKET", d.this.G());
                    d.this.A = SystemClock.elapsedRealtime();
                }
            }
        };
    }

    private String C() {
        return com.qq.gdt.action.multioprocess.a.a.a().b();
    }

    private void D() {
        if (h) {
            return;
        }
        UserMessageChangeReceiver userMessageChangeReceiver = new UserMessageChangeReceiver();
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction(UserMessageChangeReceiver.f3091a);
        intentFilter.addCategory("android.intent.category.DEFAULT");
        try {
            if (Build.VERSION.SDK_INT >= 33) {
                g().registerReceiver(userMessageChangeReceiver, intentFilter, 4);
            } else {
                g().registerReceiver(userMessageChangeReceiver, intentFilter, UserMessageChangeReceiver.b, null);
            }
            h = true;
        } catch (Exception e2) {
            o.c("Error registering receiver: " + e2.getMessage());
        }
        h = true;
    }

    private void E() {
        j.a().b().execute(new Runnable() { // from class: com.qq.gdt.action.d.3
            @Override // java.lang.Runnable
            public void run() {
                o.a("initedPersistent = " + d.g, new Object[0]);
                if (!d.g) {
                    d dVar = d.this;
                    dVar.e(dVar.l);
                    h.f(d.this.l);
                    d.this.F();
                    if (TextUtils.isEmpty(com.qq.gdt.action.a.b.b(d.this.l))) {
                        com.qq.gdt.action.i.d.b(d.this.l);
                    }
                    a.a(d.this.l).b();
                }
                boolean unused = d.g = true;
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void F() {
        this.C = System.getProperty("http.agent");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public JSONObject G() {
        long jElapsedRealtime = (SystemClock.elapsedRealtime() - this.A) / 1000;
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt("begin_time", Long.valueOf(this.y));
            jSONObject.putOpt(MediationConstant.EXTRA_DURATION, Long.valueOf(jElapsedRealtime));
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        return jSONObject;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void H() {
        if (p.hasMessages(1) || !this.z) {
            return;
        }
        p.sendEmptyMessageDelayed(1, b.a(this.l).c());
    }

    public static d a() {
        if (c == null) {
            synchronized (d.class) {
                if (c == null) {
                    c = new d();
                }
            }
        }
        return c;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final GDTAction.a aVar) {
        if (!j) {
            o.a(b);
        }
        if (aVar != null) {
            p.post(new Runnable() { // from class: com.qq.gdt.action.d.4
                @Override // java.lang.Runnable
                public void run() {
                    aVar.a();
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final GDTAction.a aVar, final String str) {
        o.c(str);
        if (aVar != null) {
            p.post(new Runnable() { // from class: com.qq.gdt.action.d.5
                @Override // java.lang.Runnable
                public void run() {
                    aVar.a(str);
                }
            });
        }
    }

    private void b(Activity activity) {
        if (activity != null) {
            try {
                if (activity.getIntent() == null || activity.getIntent().getData() == null) {
                    return;
                }
                Uri data = activity.getIntent().getData();
                String dataString = activity.getIntent().getDataString();
                o.a("getIntentData:" + data, new Object[0]);
                if (!v.a(data.getQueryParameter("gdt_traceid"))) {
                    a(this.l, data.getQueryParameter("gdt_traceid"));
                }
                if (v.a(dataString)) {
                    return;
                }
                b(dataString);
            } catch (Throwable th) {
                o.a("setTraceId err:" + th.getMessage(), new Object[0]);
            }
        }
    }

    private void c(Context context) {
        o.a("initOnce = " + f, new Object[0]);
        if (f) {
            o.a("initOnce has executed", new Object[0]);
            return;
        }
        a(this.l);
        t.f(context);
        com.qq.gdt.action.i.c.a().a(this.l);
        f = true;
    }

    private void c(String str) {
        int i2;
        o.a("ReadConfigChannelId channelId  = " + str, new Object[0]);
        if (v.a(str)) {
            return;
        }
        new ArrayList();
        if (com.qq.gdt.action.multioprocess.d.a().c() != null) {
            List<String> listQ = com.qq.gdt.action.multioprocess.d.a().c().q();
            if (listQ.size() <= 0) {
                o.a("not read channleIds", new Object[0]);
                i2 = 410401;
            } else if (listQ.contains(str)) {
                o.a("you set " + str + " in remote channelid list ，remote channelid list" + TextUtils.join(",", listQ), new Object[0]);
                return;
            } else {
                o.a("you set " + str + " not in remote channelid list ，remote channelid list " + TextUtils.join(",", listQ) + " ，please set", new Object[0]);
                i2 = 41042;
            }
        } else {
            o.a("not read UserMessageSyncByMemory", new Object[0]);
            i2 = 410402;
        }
        com.qq.gdt.action.g.a.a(i2);
    }

    private JSONObject d(boolean z) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        long j2 = z ? this.y : this.x;
        long j3 = j2 < 0 ? -1L : (jElapsedRealtime - j2) / 1000;
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt(MediationConstant.EXTRA_DURATION, Long.valueOf(j3));
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        return jSONObject;
    }

    private void d(Context context) {
        if (context != null) {
            try {
                Context contextD = context.getApplicationContext() == null ? com.qq.gdt.action.i.d.d() : context.getApplicationContext();
                this.l = contextD;
            } catch (Throwable th) {
                o.c("getApplicationContext ex = " + th);
            }
        } else {
            this.l = contextD;
        }
        if (g() != null) {
            D();
        } else {
            o.a("registerUserMessageBroadcast fail , ApplicationContext null", new Object[0]);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(Context context) {
        String strO = o();
        if (v.a(o())) {
            strO = UUID.randomUUID().toString().replaceAll("-", "");
            SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences("com.qq.gdt.action.DeviceIdPref", 0).edit();
            editorEdit.putString("device_id", strO);
            editorEdit.apply();
        }
        o.a("Set device id: " + strO, new Object[0]);
    }

    public static boolean u() {
        return B;
    }

    public boolean A() {
        return this.J;
    }

    public JSONObject a(JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        try {
            jSONObject.put("ainit", e);
            jSONObject.put("byAutoInit", j);
            jSONObject.put("byAutoInitFinal", k);
            jSONObject.put("ifrom", i);
            jSONObject.put("sinit", d);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        return jSONObject;
    }

    public void a(Activity activity) {
        this.z = true;
        this.y = SystemClock.elapsedRealtime();
        GDTAction.logAction("ENTER_FOREGROUND", d(false));
        t.b(this.l, System.currentTimeMillis());
        b(activity);
        this.A = SystemClock.elapsedRealtime();
        H();
        com.qq.gdt.action.f.e.b(this.l);
    }

    public void a(Context context) {
        d(context);
        this.t = com.qq.gdt.action.i.d.a(this.l);
    }

    public void a(Context context, String str) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences("com.qq.gdt.action.DeviceIdPref", 0).edit();
        editorEdit.putString("gdt_traceid", str);
        editorEdit.apply();
        t.d(context, System.currentTimeMillis());
    }

    public synchronized void a(Context context, String str, String str2, ChannelType channelType, String str3, GDTAction.a aVar) {
        a(context, str, str2, channelType, str3, aVar, "0", true, false);
    }

    public void a(PrivateController privateController) {
        this.F = privateController;
    }

    protected void a(com.qq.gdt.action.b.a aVar) {
        a.a(a().g()).a(aVar);
    }

    public synchronized void a(com.qq.gdt.action.multioprocess.b bVar, JSONObject jSONObject, String str) {
        String strC;
        int i2;
        int i3;
        try {
            o.a("package name gcheckUserMessageAndInit  from  = " + str + " userMessage = " + bVar + " eventObject = " + jSONObject, new Object[0]);
            if (bVar == null) {
                o.a("package name get from remote success  usermessage is null ", new Object[0]);
                if (str.equals("auto_init_by_logaction")) {
                    com.qq.gdt.action.g.a.a(40031, jSONObject);
                } else if (str.equals("auto_init_by_start")) {
                    com.qq.gdt.action.g.a.a(41031);
                }
            } else if (bVar.k()) {
                String strB = bVar.b();
                String strC2 = bVar.c();
                ChannelType channelTypeE = bVar.e();
                String strD = bVar.d();
                i = "0";
                o.a("init from last user set", new Object[0]);
                boolean zA = a(g(), strB, strC2, channelTypeE, strD, null, i, false, true);
                if (zA) {
                    com.qq.gdt.action.multioprocess.d.a().a(strB, strC2, channelTypeE, strD, false);
                    b();
                }
                o.a("logActon remote fill result = " + zA, new Object[0]);
                if (str.equals("auto_init_by_logaction")) {
                    if (!zA) {
                        i3 = zA ? 40036 : 40035;
                        com.qq.gdt.action.g.a.a(i3, jSONObject, bVar);
                    }
                } else if (str.equals("auto_init_by_start") && !zA) {
                    i2 = zA ? 41036 : 41035;
                    com.qq.gdt.action.g.a.a(i2, bVar);
                }
            } else if (bVar.l()) {
                o.a("logActon user set not complete", new Object[0]);
                if (str.equals("auto_init_by_logaction")) {
                    com.qq.gdt.action.g.a.a(40032, jSONObject, bVar);
                } else if (str.equals("auto_init_by_start")) {
                    com.qq.gdt.action.g.a.a(41032, bVar);
                }
                String strH = bVar.h();
                String strI = bVar.i();
                ChannelType channelTypeM = bVar.m();
                String strN = bVar.n();
                try {
                    strC = (TextUtils.isEmpty(strN) || !strN.equals("2")) ? C() : bVar.q().get(0);
                } catch (Exception e2) {
                    o.a("channelIdRemote e = " + e2, new Object[0]);
                    strC = "";
                }
                o.a("init from last remote set", new Object[0]);
                boolean zA2 = a(g(), strH, strI, channelTypeM, strC, null, strN, false, true);
                if (zA2) {
                    com.qq.gdt.action.multioprocess.d.a().a(strH, strI, channelTypeM, strC, strN, false);
                    b();
                }
                o.a("logActon remote fill result = " + zA2, new Object[0]);
                if (str.equals("auto_init_by_logaction")) {
                    if (!zA2) {
                        i3 = zA2 ? 400361 : 400351;
                        com.qq.gdt.action.g.a.a(i3, jSONObject, bVar);
                    }
                } else if (str.equals("auto_init_by_start") && !zA2) {
                    i2 = zA2 ? 410361 : 410351;
                    com.qq.gdt.action.g.a.a(i2, bVar);
                }
            } else {
                o.a("logActon remote set not complete", new Object[0]);
                if (str.equals("auto_init_by_logaction")) {
                    com.qq.gdt.action.g.a.a(400321, jSONObject, bVar);
                } else if (str.equals("auto_init_by_start")) {
                    com.qq.gdt.action.g.a.a(410321, bVar);
                }
            }
        } catch (Throwable th) {
            o.a("checkUserMessageAndInit fill exception", th);
            if (str.equals("auto_init_by_logaction")) {
                com.qq.gdt.action.g.a.a(40033, jSONObject, bVar);
            } else if (str.equals("auto_init_by_start")) {
                com.qq.gdt.action.g.a.a(41033, bVar);
            }
        }
    }

    public void a(String str) {
        if (v.a(str) || w.matcher(str).matches()) {
            com.qq.gdt.action.multioprocess.d.a().a(str);
        } else {
            o.c("userUniqueId参数格式不正确");
        }
    }

    public void a(boolean z) {
        this.I = z;
    }

    public synchronized boolean a(Context context, String str, final String str2, ChannelType channelType, String str3, final GDTAction.a aVar, String str4, boolean z, boolean z2) {
        String strC = str3;
        synchronized (this) {
            try {
                o.a("init byAuto = " + z2 + " initfrom = " + str4 + " needSaveUserSetInfo = " + z + " userActionSetId = " + str + " appKey = " + str2 + " channel = " + channelType + " channelId = " + strC, new Object[0]);
                j = z2;
                k = z2;
                i = str4;
                JSONObject jSONObject = new JSONObject();
                jSONObject.put("byAutoInit", z2);
                jSONObject.put("ifrom", str4);
                if (d) {
                    o.b("GDTAction已经初始化过，不需要再次初始化");
                    return false;
                }
                if (context == null) {
                    a(aVar, "GDTAction初始化失败，init方法的context参数不能为null");
                    return false;
                }
                this.l = context.getApplicationContext();
                if (v.a(str)) {
                    com.qq.gdt.action.g.a.a(3002, jSONObject);
                    a(aVar, "GDTAction初始化失败，init方法的userActionSetId参数不能为空");
                    return false;
                }
                this.m = str.trim();
                if (v.a(str2)) {
                    com.qq.gdt.action.g.a.a(ITuringIoTFeatureMap.RIOT_SIM_NUMBER, jSONObject);
                    a(aVar, "GDTAction初始化失败，init方法的appKey参数不能为空");
                    return false;
                }
                this.n = str2.trim();
                if (!v.a(str3) && !w.matcher(strC).matches()) {
                    com.qq.gdt.action.g.a.a(ITuringIoTFeatureMap.RIOT_CAMERA_SERIAL, jSONObject);
                    a(aVar, "GDTAction初始化失败，init方法的channelId参数格式不正确");
                    return false;
                }
                this.u = strC;
                if (v.a(str3)) {
                    strC = C();
                }
                String str5 = strC;
                c(str5);
                this.v = channelType;
                this.G = context;
                if (!q.a(this.l)) {
                    com.qq.gdt.action.g.a.a(ITuringIoTFeatureMap.RIOT_CPU_ID, jSONObject);
                }
                try {
                    o.a("isMainProcess = " + h.a().equals(this.t) + " getApplicationContext().getPackageName() = " + g().getPackageName() + " processName = " + this.t, new Object[0]);
                } catch (Exception e2) {
                    o.c("getAppPackageName " + e2.getMessage());
                    com.qq.gdt.action.g.a.a(3012, jSONObject);
                }
                c(context);
                j.a().b().execute(new Runnable() { // from class: com.qq.gdt.action.d.2
                    @Override // java.lang.Runnable
                    public void run() {
                        try {
                            com.qq.gdt.action.i.e.a();
                            d.this.o = com.qq.gdt.action.i.a.a(str2);
                            o.a("aesKey = " + u.c(d.this.o.getEncoded()), new Object[0]);
                            com.qq.gdt.action.h.b.a();
                            b.a(d.this.l);
                            d.this.a(aVar);
                        } catch (Exception e3) {
                            o.c("GDTAction初始化失败，ErrorCode:01，请联系广点通运营" + e3.getMessage());
                            d.this.a(aVar, "GDTAction初始化失败，ErrorCode:01，请联系广点通运营" + e3.getMessage());
                        }
                    }
                });
                if (z2) {
                    e = true;
                } else {
                    d = true;
                    com.qq.gdt.action.multioprocess.d.a().a(str, str2, channelType, str5, z);
                }
                k = z2;
                jSONObject.put("byAutoInitFinal", k);
                jSONObject.put("ainit", e);
                jSONObject.put("sinit", d);
                return true;
            } catch (Throwable th) {
                o.b("init e ", th);
                return false;
            }
        }
    }

    public String b(Context context) {
        return context.getApplicationContext().getSharedPreferences("com.qq.gdt.action.DeviceIdPref", 0).getString("gdt_traceid", "");
    }

    public void b(String str) {
        K = str;
    }

    public void b(JSONObject jSONObject) {
        if (n.a(jSONObject)) {
            return;
        }
        this.E = jSONObject;
    }

    public void b(boolean z) {
        this.J = z;
    }

    public boolean b() {
        if (this.H) {
            return true;
        }
        synchronized (this) {
            boolean z = false;
            try {
                if (this.G != null && this.m != null && this.n != null) {
                    if (!this.H) {
                        E();
                        this.H = true;
                        z = this.J;
                    }
                    if (z) {
                        GDTAction.logAction("TENCENT_INNER_START_APP");
                    }
                    return true;
                }
                o.c("请先完成初始化，再调用start或logAction方法");
                return false;
            } catch (Throwable th) {
                o.b("gdt start error ", th);
                return false;
            }
        }
    }

    public void c() {
        d((Context) null);
    }

    public boolean d() {
        return d;
    }

    public boolean e() {
        return e;
    }

    public boolean f() {
        return d() || e();
    }

    public Context g() {
        return this.l;
    }

    public String h() {
        return this.m;
    }

    public String i() {
        return this.n;
    }

    public SecretKey j() {
        return this.o;
    }

    public void k() {
        this.z = false;
        this.x = SystemClock.elapsedRealtime();
        GDTAction.logAction("ENTER_BACKGROUND", d(true));
        t.c(this.l, System.currentTimeMillis());
        a.a(this.l).a();
        GDTAction.logAction("TICKET", G());
        p.removeMessages(1);
        com.qq.gdt.action.f.e.c(this.l);
    }

    public String l() {
        return this.q;
    }

    public long m() {
        return this.r.incrementAndGet();
    }

    public long n() {
        return this.s.incrementAndGet();
    }

    public String o() {
        if (v.a(this.L)) {
            this.L = this.l.getApplicationContext().getSharedPreferences("com.qq.gdt.action.DeviceIdPref", 0).getString("device_id", "");
        }
        return this.L;
    }

    public String p() {
        if (v.a(this.t)) {
            this.t = com.qq.gdt.action.i.d.a(this.l);
        }
        return this.t;
    }

    public String q() {
        return this.v.name();
    }

    public String r() {
        return this.u;
    }

    public String s() {
        return com.qq.gdt.action.multioprocess.d.a().d();
    }

    public String t() {
        return com.qq.gdt.action.multioprocess.d.a().f();
    }

    public String v() {
        return this.C;
    }

    public JSONObject w() {
        return this.E;
    }

    public boolean x() {
        return this.H;
    }

    public boolean y() {
        o.a("last vister cp inveter time" + (System.currentTimeMillis() - this.f3026a) + "ms", new Object[0]);
        o.a("network time " + b.a(g()).o() + "ms", new Object[0]);
        return System.currentTimeMillis() - this.f3026a > ((long) b.a(g()).o());
    }

    public String z() {
        return K;
    }
}
