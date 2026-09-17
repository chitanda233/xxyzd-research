package com.kwad.sdk.core.d;

import android.util.Log;
import com.ksad.annotation.invoker.ForInvoker;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public static boolean aSP = true;
    private static boolean aSQ = com.kwad.sdk.core.d.a.oV.booleanValue();
    private static final com.kwad.sdk.core.d.a.a aSR = new b();
    private static final List<com.kwad.sdk.core.d.a.a> aSS = new CopyOnWriteArrayList();

    interface a {
        void b(com.kwad.sdk.core.d.a.a aVar);
    }

    @ForInvoker(methodId = "registerLogger")
    private static void Mp() {
        com.kwad.sdk.commercial.g.a.register();
    }

    public static void a(com.kwad.sdk.core.d.a.a aVar) {
        List<com.kwad.sdk.core.d.a.a> list = aSS;
        if (list.contains(aVar)) {
            return;
        }
        list.add(aVar);
    }

    public static void init(boolean z) {
        aSP = z;
        List<com.kwad.sdk.core.d.a.a> list = aSS;
        list.clear();
        list.add(aSR);
        Mp();
    }

    private static void a(a aVar) {
        for (com.kwad.sdk.core.d.a.a aVar2 : aSS) {
            if (aVar2 != null) {
                try {
                    aVar.b(aVar2);
                } catch (Exception unused) {
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static String eG(String str) {
        return "KSAd_" + str;
    }

    private static String eH(String str) {
        return str + " " + DT();
    }

    public static void d(String str, String str2) {
        U(eG(str), eH(str2));
    }

    public static void d(String str, Throwable th) {
        d(str, th.getMessage());
    }

    private static void T(final String str, final String str2) {
        a(new a() { // from class: com.kwad.sdk.core.d.c.1
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.d(str, str2);
            }
        });
    }

    private static void U(String str, String str2) {
        if (str2 != null && str2.length() > 4000) {
            T(str, str2.substring(0, 4000));
            U(str, str2.substring(4000));
        } else {
            T(str, str2);
        }
    }

    public static void v(final String str, String str2) {
        final String strEH = eH(str2);
        a(new a() { // from class: com.kwad.sdk.core.d.c.4
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.v(c.eG(str), strEH);
            }
        });
    }

    public static void V(final String str, String str2) {
        final String strEH = eH(str2);
        a(new a() { // from class: com.kwad.sdk.core.d.c.5
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.v(c.eG(str), strEH, true);
            }
        });
    }

    public static void i(final String str, String str2) {
        final String strEH = eH(str2);
        a(new a() { // from class: com.kwad.sdk.core.d.c.6
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.i(c.eG(str), strEH);
            }
        });
    }

    public static void w(final String str, String str2) {
        final String strEH = eH(str2);
        a(new a() { // from class: com.kwad.sdk.core.d.c.7
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.w(c.eG(str), strEH);
            }
        });
    }

    public static void w(final String str, Throwable th) {
        final String strEH = eH(Log.getStackTraceString(th));
        a(new a() { // from class: com.kwad.sdk.core.d.c.8
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.w(c.eG(str), strEH, com.kwad.sdk.core.d.a.oV.booleanValue());
            }
        });
    }

    public static void e(final String str, String str2) {
        final String strEH = eH(str2);
        a(new a() { // from class: com.kwad.sdk.core.d.c.9
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.e(c.eG(str), strEH);
            }
        });
    }

    public static void c(final String str, String str2, String str3) {
        final String strEH = eH(str2 + '\n' + str3);
        a(new a() { // from class: com.kwad.sdk.core.d.c.10
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.e(c.eG(str), strEH);
            }
        });
    }

    public static void e(final String str, String str2, Throwable th) {
        final String strEH = eH(str2 + '\n' + Log.getStackTraceString(th));
        a(new a() { // from class: com.kwad.sdk.core.d.c.11
            @Override // com.kwad.sdk.core.d.c.a
            public final void b(com.kwad.sdk.core.d.a.a aVar) {
                aVar.e(c.eG(str), strEH);
            }
        });
    }

    public static void printStackTrace(final Throwable th) {
        if (th != null) {
            a(new a() { // from class: com.kwad.sdk.core.d.c.2
                @Override // com.kwad.sdk.core.d.c.a
                public final void b(com.kwad.sdk.core.d.a.a aVar) {
                    aVar.printStackTraceOnly(th);
                }
            });
        }
        if (com.kwad.sdk.core.d.a.oV.booleanValue()) {
            throw new RuntimeException(th);
        }
    }

    public static void printStackTraceOnly(final Throwable th) {
        if (th != null) {
            a(new a() { // from class: com.kwad.sdk.core.d.c.3
                @Override // com.kwad.sdk.core.d.c.a
                public final void b(com.kwad.sdk.core.d.a.a aVar) {
                    aVar.printStackTraceOnly(th);
                }
            });
        }
    }

    private static String DT() {
        int lineNumber;
        String fileName;
        if (!aSQ) {
            return "";
        }
        StackTraceElement[] stackTrace = new Throwable().getStackTrace();
        if (stackTrace.length > 3) {
            fileName = stackTrace[3].getFileName();
            lineNumber = stackTrace[3].getLineNumber();
        } else {
            lineNumber = -1;
            fileName = "unknown";
        }
        return "(" + fileName + ':' + lineNumber + ')';
    }
}
