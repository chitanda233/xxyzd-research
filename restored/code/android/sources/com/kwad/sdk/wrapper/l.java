package com.kwad.sdk.wrapper;

import android.content.Context;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ar;
import com.kwad.sdk.utils.bi;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class l {
    private static a btS;
    private static final AtomicBoolean mHasInit = new AtomicBoolean(false);

    public static class a extends com.kwad.sdk.core.response.a.a {
        public List<String> btU;
        public List<C0541a> btV;

        /* JADX INFO: renamed from: com.kwad.sdk.wrapper.l$a$a, reason: collision with other inner class name */
        public static class C0541a extends com.kwad.sdk.core.response.a.a {
            public String btW;
            public String btX;
        }
    }

    public static boolean eJ(Context context) {
        a aVar = btS;
        if (aVar == null || ar.R(aVar.btU) || ar.R(btS.btV) || !a(context, btS)) {
            return false;
        }
        for (StackTraceElement stackTraceElement : Thread.currentThread().getStackTrace()) {
            if (a(stackTraceElement, btS)) {
                return true;
            }
        }
        return false;
    }

    private static boolean a(Context context, a aVar) {
        String name = context.getClass().getName();
        Iterator it = new CopyOnWriteArrayList(aVar.btU).iterator();
        while (it.hasNext()) {
            if (ar.a((String) it.next(), name)) {
                com.kwad.sdk.core.d.c.d("WrapperBlackHelper", "isBlackClass");
                return true;
            }
        }
        return false;
    }

    private static boolean a(StackTraceElement stackTraceElement, a aVar) {
        String className = stackTraceElement.getClassName();
        String methodName = stackTraceElement.getMethodName();
        for (a.C0541a c0541a : new CopyOnWriteArrayList(aVar.btV)) {
            String str = c0541a.btW;
            String str2 = c0541a.btX;
            if (ar.a(str, className) && ar.a(str2, methodName)) {
                com.kwad.sdk.core.d.c.d("WrapperBlackHelper", "isBlackMethod");
                return true;
            }
        }
        return false;
    }

    public static void OE() {
        if (mHasInit.getAndSet(true)) {
            return;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.wrapper.l.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a unused = l.btS = new a();
                try {
                    l.btS.parseJson((JSONObject) ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).getAppConfigData(null, new com.kwad.sdk.g.b<JSONObject, JSONObject>() { // from class: com.kwad.sdk.wrapper.l.1.1
                        @Override // com.kwad.sdk.g.b
                        public final /* synthetic */ JSONObject apply(JSONObject jSONObject) {
                            return p(jSONObject);
                        }

                        private static JSONObject p(JSONObject jSONObject) {
                            if (jSONObject == null) {
                                return null;
                            }
                            jSONObject.optJSONObject("wrapperBlackConfig");
                            return null;
                        }
                    }));
                } catch (Throwable unused2) {
                }
            }
        });
    }
}
