package com.kwad.sdk.api.loader;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.api.core.IKsAdSDK;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class aa {
    private static final AtomicBoolean aIO = new AtomicBoolean();

    public static void a(final Context context, final IKsAdSDK iKsAdSDK) {
        if (com.kwad.sdk.api.c.HH()) {
            return;
        }
        AtomicBoolean atomicBoolean = aIO;
        if (atomicBoolean.get() || context == null || iKsAdSDK == null) {
            return;
        }
        atomicBoolean.set(true);
        com.kwad.sdk.api.a.a.a(new com.kwad.sdk.api.a.b() { // from class: com.kwad.sdk.api.loader.aa.1
            @Override // com.kwad.sdk.api.a.b
            public final void doTask() {
                try {
                    if (Math.abs(System.currentTimeMillis() - b.r(context, "lastUpdateTime")) < b.r(context, "interval") * 1000) {
                        return;
                    }
                    s.HW().a(new ab() { // from class: com.kwad.sdk.api.loader.aa.1.1
                        @Override // com.kwad.sdk.api.loader.ab
                        public final Context getContext() {
                            return context;
                        }

                        @Override // com.kwad.sdk.api.loader.ab
                        public final String HY() {
                            return aa.HX();
                        }

                        @Override // com.kwad.sdk.api.loader.ab
                        public final IKsAdSDK HZ() {
                            return iKsAdSDK;
                        }
                    }, new s.c<Boolean>() { // from class: com.kwad.sdk.api.loader.aa.1.2
                        @Override // com.kwad.sdk.api.loader.s.c
                        public final /* synthetic */ void m(Boolean bool) {
                            d(bool);
                        }

                        private static void d(Boolean bool) {
                            new StringBuilder("onNewResult: ").append(bool);
                        }
                    });
                } catch (Throwable unused) {
                }
            }
        });
    }

    public static void bu(Context context) {
        i.s(context, "");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static String HX() {
        String strCT = com.kwad.sdk.api.c.cT("https://open.e.kuaishou.com/rest/e/v3/open/sdk2");
        return !TextUtils.isEmpty(strCT) ? strCT : "https://open.e.kuaishou.com/rest/e/v3/open/sdk2";
    }
}
