package com.czhj.devicehelper.cnoaid.impl;

import android.app.Application;
import android.content.Context;

/* JADX INFO: loaded from: classes2.dex */
public final class m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static com.czhj.devicehelper.cnoaid.d f2205a;

    private m() {
    }

    public static com.czhj.devicehelper.cnoaid.d a(Context context) {
        if (context != null && !(context instanceof Application)) {
            context = context.getApplicationContext();
        }
        com.czhj.devicehelper.cnoaid.d dVar = f2205a;
        if (dVar != null) {
            return dVar;
        }
        com.czhj.devicehelper.cnoaid.d dVarB = b(context);
        f2205a = dVarB;
        if (dVarB != null && dVarB.a()) {
            com.czhj.devicehelper.cnoaid.g.a("Manufacturer interface has been found: " + f2205a.getClass().getName());
            return f2205a;
        }
        com.czhj.devicehelper.cnoaid.d dVarC = c(context);
        f2205a = dVarC;
        return dVarC;
    }

    private static com.czhj.devicehelper.cnoaid.d b(Context context) {
        if (com.czhj.devicehelper.cnoaid.h.m() || com.czhj.devicehelper.cnoaid.h.q()) {
            return new i(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.l()) {
            return new j(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.n()) {
            return new l(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.g() || com.czhj.devicehelper.cnoaid.h.h() || com.czhj.devicehelper.cnoaid.h.i()) {
            return new t(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.k()) {
            return new r(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.f()) {
            return new s(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.o()) {
            return new a(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.b() && !com.czhj.devicehelper.cnoaid.h.a()) {
            g gVar = new g(context);
            if (gVar.a()) {
                return gVar;
            }
        }
        if (com.czhj.devicehelper.cnoaid.h.a() || com.czhj.devicehelper.cnoaid.h.d()) {
            return new h(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.e() || com.czhj.devicehelper.cnoaid.h.j()) {
            p pVar = new p(context);
            return pVar.a() ? pVar : new o(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.a(context)) {
            return new b(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.s()) {
            return new c(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.r()) {
            return new e(context);
        }
        if (com.czhj.devicehelper.cnoaid.h.u()) {
            return new q(context);
        }
        return null;
    }

    private static com.czhj.devicehelper.cnoaid.d c(Context context) {
        StringBuilder sb;
        com.czhj.devicehelper.cnoaid.d kVar = new k(context);
        if (kVar.a()) {
            sb = new StringBuilder("Mobile Security Alliance has been found: ");
        } else {
            kVar = new f(context);
            if (!kVar.a()) {
                d dVar = new d();
                com.czhj.devicehelper.cnoaid.g.a("OAID/AAID was not supported: " + dVar.getClass().getName());
                return dVar;
            }
            sb = new StringBuilder("Google Play Service has been found: ");
        }
        com.czhj.devicehelper.cnoaid.g.a(sb.append(kVar.getClass().getName()).toString());
        return kVar;
    }
}
