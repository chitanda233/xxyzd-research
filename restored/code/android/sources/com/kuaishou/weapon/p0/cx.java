package com.kuaishou.weapon.p0;

import android.content.Context;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public class cx {
    private static volatile cx b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f2695a;

    private cx(Context context) {
        this.f2695a = context;
    }

    public static cx a(Context context) {
        if (b == null) {
            synchronized (cx.class) {
                if (b == null) {
                    b = new cx(context);
                }
            }
        }
        return b;
    }

    public void a(final int i) {
        n.a().a(new Runnable() { // from class: com.kuaishou.weapon.p0.cx.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    h hVarA = h.a(cx.this.f2695a, "re_po_rt");
                    if (hVarA.b(dd.G, 1) == 1) {
                        long jA = dd.a(cx.this.f2695a).a(dd.bm);
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        long jB = ((long) hVarA.b(dd.I, 12)) * bg.s;
                        if (jA > 0 && jCurrentTimeMillis - jA < ((long) WeaponHI.ii) * bg.s && WeaponHI.isList != null) {
                            if (WeaponHI.isList.contains(new StringBuilder().append(new Date(jCurrentTimeMillis).getHours()).toString())) {
                                return;
                            }
                        }
                        if (jCurrentTimeMillis - jA >= jB || i == 106) {
                            cn.a(cx.this.f2695a, new ch(cx.this.f2695a).a(ci.h), ci.h, true, true);
                        }
                    }
                } catch (Throwable unused) {
                }
            }
        });
    }
}
