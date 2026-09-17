package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.HandlerThread;
import android.os.Looper;
import android.os.Message;
import android.text.TextUtils;
import android.util.Log;
import android.util.SparseArray;
import cn.thinkingdata.core.exception.TDHttpException;
import java.util.HashMap;
import java.util.Locale;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes4.dex */
public abstract class d0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final long f3921a = System.currentTimeMillis();
    public static final AtomicBoolean b = new AtomicBoolean(false);
    public static final AtomicBoolean c = new AtomicBoolean(false);
    public static final Cascara d = new Cascara(false);
    public static final Cascara e = new Cascara(true);

    public static int a(TuringSDK turingSDK) {
        AtomicBoolean atomicBoolean = c;
        synchronized (atomicBoolean) {
            if (atomicBoolean.get()) {
                return 0;
            }
            int i = turingSDK.f;
            if (i > 0) {
                Olive.f3871a = i;
            }
            if (Olive.f3871a == 0) {
                Log.e("TuringFdJava", "please input valid channel!");
                return -10018;
            }
            Olive.b = turingSDK.z;
            e.a(turingSDK);
            ((Bergamot) Bergamot.f.b()).e = turingSDK.G;
            Log.i("TuringFdJava", b());
            Cprotected.b();
            System.currentTimeMillis();
            i0.a();
            int iC = c(turingSDK);
            if (iC != 0) {
                return iC;
            }
            int iD = d(turingSDK);
            if (iD != 0) {
                return iD;
            }
            e(turingSDK);
            b(turingSDK);
            atomicBoolean.set(true);
            return 0;
        }
    }

    public static void b(TuringSDK turingSDK) {
        Context context;
        n nVar = n.l;
        nVar.f3947a = turingSDK;
        if (!nVar.c) {
            nVar.c = true;
            HandlerThread handlerThread = new HandlerThread("TuringFdCore_209308_" + Olive.f3871a + "_ad", -8);
            handlerThread.start();
            Looper looper = handlerThread.getLooper();
            synchronized (Ccatch.class) {
                context = Ccatch.f3917a;
            }
            nVar.b = new m(nVar, looper, context);
            p pVar = new p(nVar.b);
            nVar.d = pVar;
            s.h.a(turingSDK, pVar);
            new i(nVar).start();
        }
        Kiwifruit.a(turingSDK);
    }

    public static int c(TuringSDK turingSDK) {
        AtomicBoolean atomicBoolean = b;
        if (atomicBoolean.get()) {
            return 0;
        }
        boolean z = true;
        if (turingSDK.h) {
            TextUtils.isEmpty(turingSDK.j);
            String str = turingSDK.j;
            try {
                if (TextUtils.isEmpty(str)) {
                    System.loadLibrary("turingad");
                } else {
                    System.load(str);
                }
            } catch (Throwable th) {
                Log.w("TuringFdJava", th);
                z = false;
            }
            b.set(z);
            if (!z) {
                Log.e("TuringFdJava", "load so failure");
            }
        } else {
            atomicBoolean.set(true);
        }
        if (b.get()) {
            return 0;
        }
        return TDHttpException.ERROR_CONNECT_TIME_OUT;
    }

    public static int d(TuringSDK turingSDK) {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        HashMap map = new HashMap();
        q qVar = q.f;
        boolean zA = Cranberry.a();
        map.put("2008", (zA && qVar.a("e_w_d", false)) ? "1" : "0");
        map.put("2009", (zA && qVar.a("e_r_d", true)) ? "1" : "0");
        map.put("2010", (zA && qVar.a("e_w_nd", true)) ? "1" : "0");
        map.put("2011", (zA && qVar.a("e_r_nd", true)) ? "1" : "0");
        map.put("2025", "0");
        map.put("2028", turingSDK.D ? "1" : "0");
        try {
            int iA = Cantaloupe.a(TNative$aa.i209308_501191CEF186C29F(new SparseArray(), context, map, d, e, (y) y.f3972a.b()));
            if (iA == 0) {
                return 0;
            }
            Log.e("TuringFdJava", "native init fail, err: " + iA);
            return -10020;
        } catch (Throwable th) {
            Log.e("TuringFdJava", "native init exception", th);
            return -10020;
        }
    }

    public static void e(TuringSDK turingSDK) {
        if (turingSDK.t) {
            White white = (White) White.c.b();
            Dorado dorado = turingSDK.f3923a;
            int i = turingSDK.x;
            synchronized (white) {
                if (dorado != null) {
                    if (white.b.compareAndSet(false, true)) {
                        HandlerThread handlerThread = new HandlerThread("TuringFdTMFShark");
                        handlerThread.start();
                        Watermelon watermelon = new Watermelon(handlerThread.getLooper(), dorado, new Taurus(), i);
                        white.f3907a = watermelon;
                        String str = t.f3964a;
                        Tangor tangor = Teazle.f3900a;
                        t.b = "tmf_";
                        Message.obtain(watermelon, 1).sendToTarget();
                    }
                }
            }
        }
    }

    public static String b() {
        TuringSDK turingSDK;
        StringBuilder sb = new StringBuilder("TuringFD v2.93.8 (501191CEF186C29F, ad, 1d1724d");
        Locale locale = Locale.SIMPLIFIED_CHINESE;
        if (!TextUtils.isEmpty("rs")) {
            sb.append(", rs");
        }
        sb.append(", ");
        sb.append("tmfshark" + com.alipay.sdk.m.y.l.b + "105548");
        sb.append(", compiled 2026_04_30_11_19_21)");
        synchronized (e.class) {
            turingSDK = e.H;
        }
        if (turingSDK != null) {
            sb.append(" [");
            StringBuilder sb2 = new StringBuilder();
            sb2.append("url(" + TextUtils.join(",", turingSDK.i) + ")");
            String str = "c(" + turingSDK.f + ")";
            if (!sb2.toString().isEmpty()) {
                sb2.append(com.alipay.sdk.m.y.l.b);
            }
            sb2.append(str);
            if (turingSDK.y) {
                if (!sb2.toString().isEmpty()) {
                    sb2.append(com.alipay.sdk.m.y.l.b);
                }
                sb2.append(com.sigmob.sdk.base.n.m);
            }
            sb.append(sb2.toString());
            sb.append("]");
        }
        return sb.toString();
    }

    public static int a() {
        TuringSDK turingSDK;
        if (!c.get()) {
            return TDHttpException.ERROR_EXCEPTION;
        }
        if (Olive.f3871a == 0) {
            return -10018;
        }
        if (!b.get()) {
            return TDHttpException.ERROR_CONNECT_TIME_OUT;
        }
        synchronized (e.class) {
            turingSDK = e.H;
        }
        Lynx lynx = turingSDK.b;
        if (lynx == null) {
            lynx = e.I;
        }
        return !lynx.userAgreement() ? -10019 : 0;
    }
}
