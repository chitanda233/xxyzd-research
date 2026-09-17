package com.kwad.components.core.request;

import android.content.Context;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ah;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bi;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private static final AtomicBoolean sHasInit = new AtomicBoolean();
    private static volatile boolean ajJ = false;
    private static final List<a> ajK = new CopyOnWriteArrayList();

    public interface a {
        void d(SdkConfigData sdkConfigData);

        void wl();
    }

    public interface b extends a {
        void wm();
    }

    static /* synthetic */ boolean access$102(boolean z) {
        ajJ = true;
        return true;
    }

    public static synchronized void a(a aVar) {
        com.kwad.sdk.core.d.c.d("ConfigRequestManager", "init config");
        if (sHasInit.get()) {
            com.kwad.sdk.core.d.c.d("ConfigRequestManager", "config request manager has init");
        } else {
            ajK.add(aVar);
            com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.components.core.request.h.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    Context contextUm = ServiceProvider.Um();
                    ai.l(contextUm, ai.dp(contextUm) + 1);
                    com.kwad.sdk.core.config.e.bM(contextUm);
                    h.wh();
                    h.wg();
                }
            });
        }
    }

    public static void b(a aVar) {
        try {
            ajK.add(aVar);
            if (com.kwad.sdk.core.config.e.isLoaded()) {
                aVar.wl();
            }
            if (ajJ) {
                aVar.d(com.kwad.sdk.core.config.e.Kd());
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void wg() {
        com.kwad.sdk.core.d.c.d("ConfigRequestManager", "requestConfig");
        new com.kwad.sdk.core.network.l<g, SdkConfigData>() { // from class: com.kwad.components.core.request.h.2
            @Override // com.kwad.sdk.core.network.l
            public final /* synthetic */ BaseResultData parseData(String str) {
                return bf(str);
            }

            private static SdkConfigData bf(String str) {
                SdkConfigData sdkConfigData = new SdkConfigData();
                try {
                    ai.as(ServiceProvider.Um(), str);
                    sdkConfigData.parseJson(new JSONObject(str));
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
                return sdkConfigData;
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.a
            /* JADX INFO: renamed from: wk, reason: merged with bridge method [inline-methods] */
            public g createRequest() {
                GlobalThreadPools.Or().execute(new Runnable() { // from class: com.kwad.components.core.request.h.2.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        try {
                            com.kwad.sdk.core.request.model.e.NF();
                        } catch (Throwable unused) {
                        }
                    }
                });
                return new g();
            }
        }.request(new o<g, SdkConfigData>() { // from class: com.kwad.components.core.request.h.3
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            public final /* synthetic */ void onSuccess(com.kwad.sdk.core.network.f fVar, BaseResultData baseResultData) {
                c((SdkConfigData) baseResultData);
            }

            private static void c(SdkConfigData sdkConfigData) {
                try {
                    com.kwad.sdk.core.d.c.V("ConfigRequestManager", "load config success");
                    com.kwad.sdk.core.config.b.bK(ServiceProvider.Um());
                    com.kwad.sdk.core.config.e.f(sdkConfigData);
                    h.access$102(true);
                    h.a(sdkConfigData);
                    ah.Vj();
                    ah.Vd();
                    ai.l(ServiceProvider.Um(), 0);
                    if (ai.Vq() != com.kwad.sdk.core.config.e.KR()) {
                        ai.f(ServiceProvider.Um(), com.kwad.sdk.core.config.e.KR());
                    }
                    h.sHasInit.set(true);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onError(g gVar, int i, String str) {
                super.onError(gVar, i, str);
                com.kwad.sdk.core.d.c.d("ConfigRequestManager", "onError errorCode=" + i + " errorMsg=" + str);
                h.p(i, str);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void wh() {
        Iterator<a> it = ajK.iterator();
        while (it.hasNext()) {
            try {
                it.next().wl();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(SdkConfigData sdkConfigData) {
        Iterator<a> it = ajK.iterator();
        while (it.hasNext()) {
            try {
                it.next().d(sdkConfigData);
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void p(int i, String str) {
        for (a aVar : ajK) {
            try {
                if (aVar instanceof b) {
                    ((b) aVar).wm();
                }
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }
}
