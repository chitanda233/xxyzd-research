package com.tencent.turingfd.sdk.ams.ad;

import android.app.Activity;
import android.content.Context;
import android.location.LocationListener;
import android.os.Looper;
import android.util.Log;
import android.view.Window;
import java.lang.ref.WeakReference;
import java.util.Map;
import java.util.concurrent.FutureTask;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.TimeoutException;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes4.dex */
public class TuringRiskService {
    public static LocationListener getLocationListener() {
        return (LocationListener) Bergamot.f.b();
    }

    public static RiskDetectResp reqRiskDetectV2(Context context) {
        return reqRiskDetectV2(context, true, null);
    }

    public static boolean screenProtect(Activity activity) {
        try {
            activity.getWindow().addFlags(8192);
            return true;
        } catch (Throwable th) {
            Log.e("", "screenProtect fail", th);
            return false;
        }
    }

    public static boolean screenUnProtect(Activity activity) {
        try {
            activity.getWindow().clearFlags(8192);
            return true;
        } catch (Throwable th) {
            Log.e("", "screenUnProtect fail", th);
            return false;
        }
    }

    public static void setRemoteControlProtectionEnabled(boolean z) {
        Cassiopeia.b.set(z);
        Cassiopeia.d.set(z);
    }

    public static boolean setScreenProtectionEnabled(boolean z) {
        Window window;
        Pear.b.set(z);
        WeakReference weakReference = Pear.c;
        if (weakReference == null || (window = (Window) weakReference.get()) == null) {
            return true;
        }
        return z ? Pear.b(window) : Pear.a(window);
    }

    public static void setScreenViewingProtectionEnabled(boolean z) {
        if (z) {
            AtomicInteger atomicInteger = Cassiopeia.f3834a;
            synchronized (atomicInteger) {
                atomicInteger.get();
                atomicInteger.set(-1);
            }
        } else {
            Cassiopeia.a();
        }
        Cassiopeia.c.set(z);
    }

    public static RiskDetectResp reqRiskDetectV2(Context context, boolean z) {
        return reqRiskDetectV2(context, z, null);
    }

    /* JADX WARN: Code duplicated, block: B:56:0x00c7  */
    /* JADX WARN: Multi-variable type inference failed */
    public static RiskDetectResp reqRiskDetectV2(Context context, boolean z, Map<Integer, String> map) {
        boolean z2;
        Lichee lichee;
        TuringSDK turingSDK;
        int iA = d0.a();
        if (iA != 0) {
            Log.i("TuringDebug", "init error : " + iA);
            lichee = new Lichee(iA);
        } else {
            String str = Kiwifruit.f3858a;
            if (Looper.myLooper() == Looper.getMainLooper()) {
                lichee = new Lichee(-10008);
            } else {
                Lichee licheeB = Kiwifruit.b(context);
                if (licheeB != null && (licheeB.e & 1) != 0) {
                    z2 = z;
                    z2 = z;
                    z2 = true;
                }
                z2 = z;
                z2 = z;
                z2 = z;
                boolean z3 = z2;
                if (map != null && !map.isEmpty()) {
                    z3 = z2;
                    z3 = 2;
                }
                z3 = z2;
                boolean z4 = (z3 & 1) != 0;
                boolean z5 = (z3 & 2) == 0;
                if (z4 && licheeB != null) {
                    if (Carambola.b(context) && Math.abs(System.currentTimeMillis() - licheeB.c) >= licheeB.d) {
                        new Hickory(null, true).a();
                    }
                } else if (Carambola.b(context)) {
                    FutureTask futureTaskA = new Hickory(map, false).a();
                    try {
                        synchronized (e.class) {
                            turingSDK = e.H;
                        }
                        lichee = (Lichee) futureTaskA.get(turingSDK.w, TimeUnit.MILLISECONDS);
                    } catch (TimeoutException unused) {
                        if (!z5 || licheeB == null) {
                            lichee = new Lichee(-10004);
                        } else {
                            lichee = licheeB;
                        }
                    } catch (Exception e) {
                        Log.w("TuringFdJava", e);
                        if (!z5 || licheeB == null) {
                            lichee = new Lichee(-10015);
                        } else {
                            lichee = licheeB;
                        }
                    }
                } else if (!z5 || licheeB == null) {
                    lichee = new Lichee(-10012);
                }
                lichee = licheeB;
            }
        }
        return new b0(lichee);
    }
}
