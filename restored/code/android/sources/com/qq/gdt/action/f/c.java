package com.qq.gdt.action.f;

import com.qq.gdt.action.i.o;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile c f3071a;

    public static c a() {
        if (f3071a == null) {
            synchronized (c.class) {
                if (f3071a == null) {
                    f3071a = new c();
                }
            }
        }
        return f3071a;
    }

    private boolean b() {
        boolean z = com.qq.gdt.action.d.a().g() != null;
        if (!z) {
            o.a("event sendToNetwork 上下文 未准备好！！！！ ", new Object[0]);
        }
        return z;
    }

    public void a(int i, com.qq.gdt.action.b.a aVar, JSONObject jSONObject) {
        String strC;
        String strA;
        long jB;
        long jD;
        if (aVar != null) {
            try {
                strC = aVar.c();
                strA = aVar.a();
                jB = aVar.b();
                jD = aVar.d();
            } catch (Exception e) {
                o.b("RecorderWrapper event e ", e);
                return;
            }
        } else {
            strC = null;
            strA = null;
            jD = -1;
            jB = -1;
        }
        try {
            if (d.a(strC, i)) {
                com.qq.gdt.action.f.a.a aVar2 = new com.qq.gdt.action.f.a.a(i, System.currentTimeMillis(), com.qq.gdt.action.d.a().l(), strC, strA, jD, jSONObject, jB, com.qq.gdt.action.d.a().n());
                if (b()) {
                    b.a().a(aVar2);
                } else {
                    com.qq.gdt.action.h.a.a(aVar2);
                    o.a("event不落DB直接发送，eventId:  " + aVar2.b() + ", eventLogId:" + aVar2.k(), new Object[0]);
                }
            }
        } catch (Exception e2) {
            o.b("RecorderWrapper event e ", e2);
        }
    }
}
