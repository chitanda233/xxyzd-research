package com.kwad.components.core.page.widget.a;

import android.app.Activity;
import android.app.Fragment;
import com.kwad.components.core.proxy.j;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private j ahw;

    public final j a(String str, Activity activity, j jVar) {
        return a(str, activity, jVar, new f(), -1);
    }

    private j a(String str, Activity activity, j jVar, g gVar, int i) {
        return a(str, activity, jVar, gVar, -1, null);
    }

    private j a(String str, Activity activity, j jVar, g gVar, int i, c cVar) {
        if (gVar == null) {
            gVar = new f();
        }
        e eVarBa = gVar.ba(str);
        eVarBa.ahH = i;
        eVarBa.ahJ = null;
        eVarBa.ahC = 0.8f;
        eVarBa.ahD = com.kwad.sdk.c.a.a.a(activity, 4.0f);
        a(activity, eVarBa);
        return a(activity, jVar, eVarBa);
    }

    private static void a(Activity activity, e eVar) {
        float f = eVar.ahA;
        if (f >= 1.0f) {
            eVar.ahz = true;
            eVar.ahA = 1.0f;
        } else if (f < 0.0f) {
            eVar.ahA = 0.0f;
        }
        if (eVar.ahz) {
            eVar.ahB = com.kwad.sdk.c.a.a.k(activity);
        } else {
            if (eVar.ahA <= 0.0f || eVar.ahA > 1.0f) {
                return;
            }
            eVar.ahB = com.kwad.sdk.c.a.a.k(activity) * f;
        }
    }

    private j a(Activity activity, j jVar, e eVar) {
        j jVarA = a(jVar, eVar);
        this.ahw = jVarA;
        jVarA.a(activity.getFragmentManager(), "WEB_HALF_DIALOG");
        return this.ahw;
    }

    private j a(j jVar, e eVar) {
        a aVarA = a.a(eVar);
        if (!eVar.ahF) {
            aVarA.bs((int) eVar.ahB);
        }
        return a(aVarA, jVar, eVar);
    }

    private b a(a aVar, final j jVar, e eVar) {
        aVar.a(new b.a() { // from class: com.kwad.components.core.page.widget.a.d.1
            @Override // com.kwad.components.core.page.widget.a.b.a
            public final Fragment vv() {
                return jVar;
            }
        });
        if (eVar.ahH > 0) {
            aVar.br(eVar.ahH);
        }
        return aVar;
    }

    public final void dismiss() {
        j jVar = this.ahw;
        if (jVar != null) {
            jVar.dismiss();
        }
    }
}
