package com.kwad.components.core.innerEc.live;

import android.app.Application;
import android.content.Context;
import com.kwad.components.core.innerEc.e;
import com.kwad.components.core.innerEc.f;
import com.kwad.components.core.innerEc.live.slide.LiveDetailActivity;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ab;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static AtomicBoolean TA = new AtomicBoolean(false);
    public static a Tz;

    public static void c(Application application) {
        if (TA.get()) {
            return;
        }
        com.kwad.components.core.emotion.a.a(application);
        TA.set(true);
    }

    public static boolean rG() {
        boolean z = false;
        try {
            if (ab.a("java.lang.String", "join", new Class[]{CharSequence.class, Iterable.class}) != null) {
                z = true;
            }
        } catch (Throwable unused) {
        }
        c.d("FullLiveModule", "checkEnv envEnable" + z);
        return z;
    }

    public static void b(Context context, final AdTemplate adTemplate, final com.kwad.components.core.e.d.a.C0428a c0428a) {
        com.kwad.components.core.innerEc.logger.a.aO(adTemplate);
        Tz = new a() { // from class: com.kwad.components.core.innerEc.live.b.1
            @Override // com.kwad.components.core.innerEc.live.a
            public final void rE() {
                c.d("FullLiveModule", "FullLiveModule onLaunchSuccess");
            }

            @Override // com.kwad.components.core.innerEc.live.a
            public final void rF() {
                c.d("FullLiveModule", "FullLiveModule onLaunchFail");
                adTemplate.setHasInnerEcFailed(true);
                com.kwad.components.core.innerEc.logger.a.l(adTemplate, "onLaunchFail");
                com.kwad.components.core.e.d.a.C0428a c0428a2 = c0428a;
                if (c0428a2 != null) {
                    f.G(c0428a2);
                }
                b.Tz = null;
            }
        };
        String string = new StringBuilder().append(e.re().getUserId()).toString();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        adTemplate.liveInfo.kwaiUserId = string;
        adTemplate.liveInfo.deeplink = com.kwad.sdk.core.response.helper.a.da(adInfoEM);
        long jFj = com.kwad.sdk.core.response.helper.e.fj(adTemplate);
        if ((com.kwad.sdk.core.response.helper.e.eG(adTemplate) == 2) && c0428a != null && c0428a.ee() == 115 && jFj != 0) {
            adTemplate.liveInfo.shopItemId = String.valueOf(jFj);
        } else {
            adTemplate.liveInfo.shopItemId = "";
        }
        LiveDetailActivity.launch(context, adTemplate.createAdResultData());
    }
}
