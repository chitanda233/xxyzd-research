package com.kwad.sdk.api;

import com.kwad.sdk.api.core.IKsAdSDK;
import java.util.List;
import java.util.Set;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static List<Throwable> PL;
    private static IKsAdSDK aHC;
    public static Set<String> aHD;

    static /* synthetic */ List z(List list) {
        PL = null;
        return null;
    }

    public static void a(IKsAdSDK iKsAdSDK) {
        aHC = iKsAdSDK;
        HJ();
    }

    public static IKsAdSDK HG() {
        return aHC;
    }

    public static boolean HH() {
        Boolean bool = (Boolean) g("enableDynamic", new Object[0]);
        return (bool == null || bool.booleanValue()) ? false : true;
    }

    public static int HI() {
        Integer num = (Integer) g("getAutoRevertTime", new Object[0]);
        if (num != null) {
            return num.intValue();
        }
        return -1;
    }

    private static void HJ() {
        try {
            aHD = (Set) g("getThrowClassNotFoundSet", new Object[0]);
        } catch (Throwable unused) {
            aHD = null;
        }
    }

    public static <T> T g(String str, Object... objArr) {
        try {
            T t = (T) aHC.dM(str, objArr);
            if (t != null) {
                return t;
            }
            return null;
        } catch (Throwable unused) {
            return null;
        }
    }

    public static String cT(String str) {
        return (String) g("TRANSFORM_API_HOST", str);
    }

    public static void t(Throwable th) {
        try {
            if (aHC != null && KsAdSDK.haseInit()) {
                aHC.re(th);
            } else {
                b(th);
            }
        } catch (Throwable unused) {
        }
    }

    private static void b(Throwable th) {
        try {
            if (PL == null) {
                PL = new CopyOnWriteArrayList();
            }
            PL.add(th);
        } catch (Throwable unused) {
        }
    }

    public static void pf() {
        try {
            com.kwad.sdk.api.a.a.a(new com.kwad.sdk.api.a.b() { // from class: com.kwad.sdk.api.c.1
                @Override // com.kwad.sdk.api.a.b
                public final void doTask() {
                    try {
                        if (c.PL == null) {
                            return;
                        }
                        for (Throwable th : c.PL) {
                            if (c.aHC != null && KsAdSDK.haseInit()) {
                                c.aHC.re(th);
                            }
                        }
                        c.PL.clear();
                        c.z(null);
                    } catch (Throwable unused) {
                    }
                }
            });
        } catch (Throwable unused) {
        }
    }
}
