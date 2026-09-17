package com.kuaishou.weapon.p0;

import android.content.Context;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public class cv {
    private static volatile cv b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2691a;

    private cv(Context context) {
        this.f2691a = context;
    }

    public static cv a(Context context) {
        if (b == null) {
            synchronized (cv.class) {
                if (b == null) {
                    b = new cv(context);
                }
            }
        }
        return b;
    }

    public void a(final int i) {
        n.a().a(new Runnable() { // from class: com.kuaishou.weapon.p0.cv.1
            @Override // java.lang.Runnable
            public void run() {
                int i2;
                try {
                    h hVarA = h.a(cv.this.f2691a, "re_po_rt");
                    if (hVarA.b(dd.y, 0) == 1) {
                        long jA = dd.a(cv.this.f2691a).a(dd.bh);
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        long jB = ((long) hVarA.b(dd.z, 8)) * bg.s;
                        int iB = hVarA.b(dd.q, 0);
                        if (jA > 0 && jCurrentTimeMillis - jA < ((long) WeaponHI.ii) * bg.s && WeaponHI.isList != null) {
                            if (WeaponHI.isList.contains(new StringBuilder().append(new Date(jCurrentTimeMillis).getHours()).toString())) {
                                return;
                            }
                        }
                        if (jCurrentTimeMillis - jA >= jB || (i2 = i) == 106 || (i2 == 100 && iB == 1)) {
                            cn.a(cv.this.f2691a, new cf(cv.this.f2691a, i).a(ci.f2676a), ci.f2676a, false, true);
                        }
                    }
                } catch (Throwable unused) {
                }
            }
        });
    }
}
