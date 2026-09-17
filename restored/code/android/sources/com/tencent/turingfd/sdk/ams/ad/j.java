package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.text.TextUtils;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class j implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Context f3940a;
    public final /* synthetic */ int b;
    public final /* synthetic */ n c;

    public j(n nVar, Context context, int i) {
        this.c = nVar;
        this.f3940a = context;
        this.b = i;
    }

    @Override // java.lang.Runnable
    public final void run() {
        boolean zBooleanValue;
        n nVar = this.c;
        Context context = this.f3940a;
        int i = this.b;
        nVar.d.getClass();
        String strB = p.b(context, "403");
        try {
            zBooleanValue = TextUtils.isEmpty(strB) ? true : Boolean.valueOf(strB).booleanValue();
        } catch (Throwable unused) {
        }
        for (int i2 = 0; i2 < nVar.f3947a.x; i2++) {
            h hVarB = nVar.b(context, zBooleanValue, i);
            nVar.a(hVarB, true);
            int i3 = hVarB.c;
            if (i3 == 0 || i3 == -30014) {
                break;
            }
        }
        if (zBooleanValue) {
            nVar.d.getClass();
            HashMap map = new HashMap();
            map.put("403", "false");
            p.a(context, map);
        }
        synchronized (nVar.g) {
            nVar.g.set(Boolean.FALSE);
            nVar.g.notifyAll();
        }
    }
}
