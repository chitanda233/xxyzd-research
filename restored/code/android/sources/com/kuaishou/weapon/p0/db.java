package com.kuaishou.weapon.p0;

import android.content.Context;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public class db {
    private static volatile db b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2706a;

    private db(Context context) {
        this.f2706a = context;
    }

    public static db a(Context context) {
        if (b == null) {
            synchronized (db.class) {
                if (b == null) {
                    b = new db(context);
                }
            }
        }
        return b;
    }

    public void a(final int i) {
        n.a().a(new Runnable() { // from class: com.kuaishou.weapon.p0.db.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    h hVarA = h.a(db.this.f2706a, "re_po_rt");
                    if (hVarA.b(dd.aC, 1) == 1) {
                        long jA = dd.a(db.this.f2706a).a();
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        long jB = ((long) hVarA.b(dd.aE, 8)) * bg.s;
                        if (jA > 0 && jCurrentTimeMillis - jA < ((long) WeaponHI.ii) * bg.s && WeaponHI.isList != null) {
                            if (WeaponHI.isList.contains(new StringBuilder().append(new Date(jCurrentTimeMillis).getHours()).toString())) {
                                return;
                            }
                        }
                        if (jCurrentTimeMillis - jA >= jB || i == 106) {
                            cn.a(db.this.f2706a, new cl(db.this.f2706a, i).a(ci.c), ci.c, true, true);
                        }
                    }
                } catch (Throwable unused) {
                }
            }
        });
    }
}
