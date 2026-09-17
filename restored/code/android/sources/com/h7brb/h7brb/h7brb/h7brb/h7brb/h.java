package com.h7brb.h7brb.h7brb.h7brb.h7brb;

import android.content.Context;
import android.util.SparseArray;
import com.bytedance.msdk.adapter.ks.KsDrawLoader;
import com.bytedance.msdk.adapter.ks.base.config.MediationAdSlotValueSet;
import com.kwad.sdk.api.KsAdSDK;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.KsScene;
import java.util.ArrayList;
import java.util.List;
import java.util.function.Function;

/* JADX INFO: loaded from: classes3.dex */
public class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final KsDrawLoader f2573a;
    private boolean b;

    private static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private KsLoadManager.DrawAdListener f2575a;
        private KsDrawLoader b;

        public a(final Context context, KsDrawLoader ksDrawLoader, final MediationAdSlotValueSet mediationAdSlotValueSet, final boolean z) {
            this.b = ksDrawLoader;
            this.f2575a = new KsLoadManager.DrawAdListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.h.a.1
                @Override // com.kwad.sdk.api.KsLoadManager.DrawAdListener
                public void onDrawAdLoad(List<KsDrawAd> list) {
                    if (list != null && list.size() != 0) {
                        ArrayList arrayList = new ArrayList();
                        for (KsDrawAd ksDrawAd : list) {
                            if (ksDrawAd != null) {
                                Function<SparseArray<Object>, Object> gMBridge = a.this.b.getGMBridge();
                                new b(context, a.this.b, gMBridge, ksDrawAd, mediationAdSlotValueSet, z);
                                arrayList.add(gMBridge);
                            }
                        }
                        if (arrayList.size() > 0) {
                            a.this.b.notifyAdSuccess(arrayList);
                            return;
                        }
                    } else if (a.this.b == null) {
                        return;
                    }
                    a.this.b.notifyAdFailed(80001, "请求成功，但无广告可用");
                }

                @Override // com.kwad.sdk.api.KsLoadManager.DrawAdListener
                public void onError(int i, String str) {
                    if (a.this.b != null) {
                        a.this.b.notifyAdFailed(i, str);
                    }
                }
            };
        }

        public void a(KsScene ksScene) {
            KsLoadManager loadManager = KsAdSDK.getLoadManager();
            if (loadManager != null) {
                loadManager.loadDrawAd(ksScene, this.f2575a);
                return;
            }
            KsDrawLoader ksDrawLoader = this.b;
            if (ksDrawLoader != null) {
                ksDrawLoader.notifyAdFailed(80001, "loadManager is null can not load ads");
            }
        }
    }

    public h(KsDrawLoader ksDrawLoader) {
        this.f2573a = ksDrawLoader;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        try {
            KsScene.Builder builder = new KsScene.Builder(Long.valueOf(mediationAdSlotValueSet.getADNId()).longValue());
            f.a(builder, mediationAdSlotValueSet, "DRAW");
            builder.height(mediationAdSlotValueSet.getHeight());
            builder.width(mediationAdSlotValueSet.getWidth());
            builder.adNum(mediationAdSlotValueSet.getAdCount());
            new a(context, this.f2573a, mediationAdSlotValueSet, this.b).a(builder.build());
        } catch (Exception unused) {
            this.f2573a.notifyAdFailed(80001, "代码位ID不合法");
        }
    }

    public void a(final Context context, final MediationAdSlotValueSet mediationAdSlotValueSet) {
        boolean zA = p.a(this.f2573a, mediationAdSlotValueSet);
        this.b = zA;
        if (zA) {
            o.a(new Runnable() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.h.1
                @Override // java.lang.Runnable
                public void run() {
                    h.this.b(context.getApplicationContext(), mediationAdSlotValueSet);
                    o.a(getClass().getName(), context.getApplicationContext());
                }
            });
        } else {
            b(context.getApplicationContext(), mediationAdSlotValueSet);
        }
    }
}
