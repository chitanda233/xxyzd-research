package com.kwad.sdk.kgeo;

import com.kwad.sdk.core.network.f;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.service.ServiceProvider;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static String bhx;
    private static KGeoInfo bhy;
    private static final AtomicBoolean bhz = new AtomicBoolean();

    public static void eS(int i) {
        if (i == 0) {
            return;
        }
        if (i == 1) {
            RL();
        } else if (i == 2) {
            com.kwad.components.core.request.b.wc().a(new com.kwad.components.core.request.b.a() { // from class: com.kwad.sdk.kgeo.a.1
                @Override // com.kwad.components.core.request.b.a
                public final void we() {
                    com.kwad.components.core.request.b.wc().b(this);
                    a.RL();
                }
            });
        }
    }

    public static String FK() {
        return bhx;
    }

    public static KGeoInfo RK() {
        return bhy;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void RL() {
        try {
            if (bhz.getAndSet(true)) {
                return;
            }
            c.a(ServiceProvider.Um(), new c.a() { // from class: com.kwad.sdk.kgeo.a.2
                @Override // com.kwad.sdk.kgeo.c.a
                public final void onSuccess(String str) {
                    String unused = a.bhx = str;
                    a.RM();
                }

                @Override // com.kwad.sdk.kgeo.c.a
                public final void rb() {
                    a.RM();
                }
            });
        } catch (Throwable unused) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void RM() {
        try {
            new l<f, KGeoResultData>() { // from class: com.kwad.sdk.kgeo.a.3
                @Override // com.kwad.sdk.core.network.l
                public final /* synthetic */ BaseResultData parseData(String str) {
                    return gM(str);
                }

                private static KGeoResultData gM(String str) {
                    KGeoResultData kGeoResultData = new KGeoResultData();
                    kGeoResultData.parseJson(new JSONObject(str));
                    return kGeoResultData;
                }

                @Override // com.kwad.sdk.core.network.a
                public final f createRequest() {
                    return new b();
                }
            }.request(new o<f, KGeoResultData>() { // from class: com.kwad.sdk.kgeo.a.4
                @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
                public final /* synthetic */ void onSuccess(f fVar, BaseResultData baseResultData) {
                    a((KGeoResultData) baseResultData);
                }

                private static void a(KGeoResultData kGeoResultData) {
                    KGeoInfo unused = a.bhy = kGeoResultData.kGeoInfo;
                }
            });
        } catch (Throwable unused) {
        }
    }
}
