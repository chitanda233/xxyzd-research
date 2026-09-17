package com.kuaishou.weapon.p0;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public class dc {
    private static volatile dc b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2708a;

    private dc(Context context) {
        this.f2708a = context;
    }

    public static dc a(Context context) {
        if (b == null) {
            synchronized (dc.class) {
                if (b == null) {
                    b = new dc(context);
                }
            }
        }
        return b;
    }

    public void a(final int i) {
        n.a().a(new Runnable() { // from class: com.kuaishou.weapon.p0.dc.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    h hVarA = h.a(dc.this.f2708a, "re_po_rt");
                    if (hVarA.b(dd.B, 0) == 1) {
                        long jA = dd.a(dc.this.f2708a).a(dd.bn);
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        if (jCurrentTimeMillis - jA >= ((long) hVarA.b(dd.E, 2)) * bg.s || i == 106) {
                            try {
                                String strA = new cm(dc.this.f2708a).a(ci.i);
                                int iIntValue = Integer.valueOf(ci.i).intValue();
                                if (strA != null && strA.length() > 10) {
                                    new ba(dc.this.f2708a, strA, iIntValue).a(com.sigmob.sdk.base.n.i);
                                }
                            } catch (Throwable unused) {
                            }
                            dd.a(dc.this.f2708a).a(dd.bn, jCurrentTimeMillis);
                        }
                    }
                } catch (Throwable unused2) {
                }
            }
        });
    }
}
