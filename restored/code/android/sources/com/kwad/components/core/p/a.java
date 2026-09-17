package com.kwad.components.core.p;

import android.content.Context;
import com.byazt.bv.BaseConstants;
import com.kwad.components.core.proxy.a.b;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.collector.f;
import com.kwad.sdk.components.d;
import com.kwad.sdk.components.p;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.report.g;
import com.kwad.sdk.core.report.n;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.o;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static boolean ajB = false;

    /* JADX INFO: renamed from: com.kwad.components.core.p.a$a, reason: collision with other inner class name */
    static final class C0448a {
        private static final a ajD = new a();
    }

    protected a() {
    }

    public static a vX() {
        return C0448a.ajD;
    }

    public static n P(long j) {
        return new n(j);
    }

    private static n b(long j, AdTemplate adTemplate) {
        return new n(j, adTemplate);
    }

    private static n a(long j, AdTemplate adTemplate, String str) {
        return new n(j, adTemplate, str);
    }

    public final void vY() {
        if (ajB) {
            return;
        }
        ajB = true;
        i.execute(new bi() { // from class: com.kwad.components.core.p.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                n nVarP = a.P(8L);
                nVarP.aWm = f.Im();
                g.a(nVarP);
            }
        });
    }

    public final void aK(Context context) {
        n nVarP = P(11L);
        p pVar = (p) d.f(p.class);
        if (pVar != null) {
            JSONArray[] jSONArrayArrB = pVar.b(context, e.FX());
            nVarP.aVE = jSONArrayArrB[0];
            nVarP.aVF = jSONArrayArrB[1];
            g.a(nVarP);
        }
    }

    public final void f(AdTemplate adTemplate, int i, int i2) {
        n nVarB = b(12006L, adTemplate);
        nVarB.aqT = i;
        nVarB.aMA = i2;
        g.a(nVarB);
    }

    public final void a(AdTemplate adTemplate, String str, String str2) {
        n nVarB = b(10003L, adTemplate);
        nVarB.aVL = str;
        nVarB.errorMsg = str2;
        g.a(nVarB);
    }

    public final void g(AdTemplate adTemplate, int i, int i2) {
        n nVarB = b(10002L, adTemplate);
        nVarB.Nn();
        if (com.kwad.sdk.core.response.helper.e.eE(adTemplate)) {
            nVarB.aVL = com.kwad.sdk.core.response.helper.a.M(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        } else {
            nVarB.aVL = com.kwad.sdk.core.response.helper.e.eO(adTemplate);
        }
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("what", i);
            jSONObject.put(BaseConstants.EVENT_LABEL_EXTRA, i2);
            nVarB.errorMsg = jSONObject.toString();
        } catch (JSONException e) {
            c.printStackTraceOnly(e);
        }
        g.a(nVarB);
    }

    public final void b(AdTemplate adTemplate, String str, String str2) {
        n nVarB = b(10005L, adTemplate);
        if (com.kwad.sdk.core.response.helper.e.eE(adTemplate)) {
            nVarB.aVL = com.kwad.sdk.core.response.helper.a.M(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        } else {
            nVarB.aVL = com.kwad.sdk.core.response.helper.e.eO(adTemplate);
        }
        nVarB.aVL = str;
        nVarB.errorMsg = str2;
        g.a(nVarB);
    }

    public final void aZ(AdTemplate adTemplate) {
        g.a(b(10007L, adTemplate));
    }

    public final void c(JSONArray jSONArray) {
        n nVarP = P(10200L);
        nVarP.aVQ = jSONArray;
        g.a(nVarP);
    }

    public final void e(JSONObject jSONObject, int i) {
        n nVarP = P(10201L);
        ac.putValue(jSONObject, "appChangeType", i);
        nVarP.aVP = jSONObject;
        g.a(nVarP);
    }

    public final void vZ() {
        g.a(P(10101L));
    }

    public final void bG(int i) {
        n nVarP = P(10104L);
        nVarP.aVM = i;
        g.a(nVarP);
    }

    public final void a(int i, AdTemplate adTemplate, String str) {
        g.a(a(i, adTemplate, str));
    }

    public final void wa() {
        g.a(P(10106L));
    }

    public final void bH(int i) {
        n nVarP = P(10107L);
        nVarP.aVN = i;
        g.a(nVarP);
    }

    public final void h(AdTemplate adTemplate, int i) {
        n nVarB = b(10108L, adTemplate);
        nVarB.aVN = i;
        g.a(nVarB);
    }

    public final void g(AdTemplate adTemplate, int i, String str) {
        n nVarB = b(10109L, adTemplate);
        nVarB.aVN = 1;
        nVarB.aVO = str;
        g.a(nVarB);
    }

    public final void a(AdTemplate adTemplate, long j, long j2, int i) {
        n nVarB = b(10203L, adTemplate);
        nVarB.apx = j;
        nVarB.blockDuration = j2;
        nVarB.aVB = i;
        g.a(nVarB);
    }

    public final void h(AdTemplate adTemplate, long j) {
        n nVarB = b(10202L, adTemplate);
        nVarB.aVU = j;
        g.a(nVarB);
    }

    public final void a(boolean z, List<Integer> list) {
        n nVarP = P(10204L);
        nVarP.aVW = z;
        if (list.size() > 0) {
            JSONArray jSONArray = new JSONArray();
            Iterator<Integer> it = list.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next());
            }
            nVarP.aVV = jSONArray;
        }
        g.a(nVarP);
    }

    public final void a(SceneImpl sceneImpl, boolean z, String str) {
        n nVarP = P(10216L);
        nVarP.aVW = z;
        nVarP.aVX = str;
        nVarP.adScene = sceneImpl;
        g.a(nVarP);
    }

    public final void i(AdTemplate adTemplate, long j) {
        n nVarB = b(10206L, adTemplate);
        nVarB.aWk = j;
        g.a(nVarB);
    }

    public final void j(AdTemplate adTemplate, long j) {
        n nVarB = b(10207L, adTemplate);
        nVarB.aWl = j;
        g.a(nVarB);
    }

    public final void ba(AdTemplate adTemplate) {
        g.a(b(10208L, adTemplate));
    }

    public final void bb(AdTemplate adTemplate) {
        g.a(b(10209L, adTemplate));
    }

    public final void h(AdTemplate adTemplate, int i, String str) {
        n nVarB = b(107L, adTemplate);
        nVarB.errorCode = i;
        nVarB.errorMsg = str;
        g.a(nVarB);
    }

    public final void a(AdTemplate adTemplate, long j, int i) {
        n nVarB = b(104L, adTemplate);
        nVarB.clickTime = o.fq(adTemplate);
        nVarB.aWa = j;
        nVarB.aWb = i;
        g.a(nVarB);
    }

    public final void a(b bVar) {
        n nVarP = P(10215L);
        nVarP.ajr = bVar.ajr;
        nVarP.ajy = bVar.ajy;
        nVarP.ajz = bVar.ajz;
        nVarP.ajA = bVar.ajA;
        g.a(nVarP);
    }

    public final void e(String str, String str2, boolean z) {
        g.a(n(str, str2), z);
    }

    public final n n(String str, String str2) {
        n nVarP = P(12200L);
        nVarP.aWt = str;
        nVarP.aWu = str2;
        return nVarP;
    }

    public final void c(long j, int i) {
        if (e.KB()) {
            n nVarP = P(20000L);
            nVarP.timestamp = System.currentTimeMillis();
            nVarP.aWv = i;
            nVarP.posId = j;
            nVarP.aWw = BuildConfig.VERSION_CODE;
            g.a(nVarP);
        }
    }

    public final void i(AdTemplate adTemplate, int i) {
        if (e.KB()) {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            n nVarP = P(20000L);
            nVarP.timestamp = System.currentTimeMillis();
            nVarP.aWv = i;
            nVarP.trace = adInfoEM.trace;
            nVarP.aWw = BuildConfig.VERSION_CODE;
            nVarP.posId = com.kwad.sdk.core.response.helper.e.eF(adTemplate);
            g.a(nVarP);
        }
    }
}
