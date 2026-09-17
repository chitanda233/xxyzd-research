package com.kwad.components.ad.i;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ai;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements Runnable {
    private static final Handler rt = new Handler(Looper.getMainLooper());
    private static volatile boolean rx;
    private final long ru;
    private final AdTemplate rv;
    private boolean rw = false;
    private d ry;

    static /* synthetic */ boolean access$002(boolean z) {
        rx = false;
        return false;
    }

    public c(com.kwad.components.core.internal.api.a aVar) {
        AdTemplate adTemplate = aVar.getAdTemplate();
        this.rv = adTemplate;
        long jDi = com.kwad.sdk.core.response.helper.a.di(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        this.ru = jDi;
        com.kwad.sdk.core.d.c.d("PushAdManager", "PushAdManager create adTemplate: " + adTemplate.hashCode() + ", " + jDi);
    }

    public final void gf() {
        com.kwad.sdk.core.d.c.w("PushAdManager", "startRequestPushAd processingPush: " + rx);
        if (rx || this.rv.mAdScene == null) {
            return;
        }
        rx = true;
        com.kwad.components.core.j.a.b(this.rv.mAdScene, new com.kwad.components.core.j.a.InterfaceC0443a() { // from class: com.kwad.components.ad.i.c.1
            @Override // com.kwad.components.core.j.a.InterfaceC0443a
            public final void onRequestResult(int i) {
            }

            @Override // com.kwad.components.core.j.a.InterfaceC0443a
            public final void onError(int i, String str) {
                com.kwad.sdk.core.d.c.d("PushAdManager", "onError: " + str);
                c.access$002(false);
            }

            @Override // com.kwad.components.core.j.a.InterfaceC0443a
            public final void e(List<com.kwad.components.core.j.c> list) {
                com.kwad.sdk.core.d.c.d("PushAdManager", "onInnerAdLoad: " + list);
                if (list != null && list.size() > 0) {
                    AdTemplate adTemplate = list.get(0).getAdTemplate();
                    if (com.kwad.sdk.core.response.helper.a.dg(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
                        com.kwad.sdk.core.d.c.d("PushAdManager", "loadPushTK");
                        c.this.ry = new d(ServiceProvider.getContext(), adTemplate);
                        return;
                    }
                    c.access$002(false);
                    com.kwad.sdk.core.d.c.d("PushAdManager", "pushAdInfo templateId invalid");
                    return;
                }
                c.access$002(false);
            }
        });
    }

    @Override // java.lang.Runnable
    public final void run() {
        if (com.kwad.components.core.e.a.e.pt().isShowing()) {
            com.kwad.components.core.e.a.e.pt().a(new com.kwad.components.core.e.a.c() { // from class: com.kwad.components.ad.i.c.2
                @Override // com.kwad.components.core.e.a.c, com.kwad.components.core.e.a.b
                public final void gi() {
                    com.kwad.components.core.e.a.e.pt().b(this);
                    c.this.gg();
                }
            });
        } else {
            gg();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gg() {
        d dVar;
        if (!b.gb().gd()) {
            com.kwad.sdk.core.d.c.d("PushAdManager", "run preCheckResult false");
            return;
        }
        rx = false;
        if (this.rw || (dVar = this.ry) == null || !dVar.gl()) {
            return;
        }
        this.rw = true;
        this.ry.c(new com.kwad.components.ad.b.a.b() { // from class: com.kwad.components.ad.i.c.3
            @Override // com.kwad.components.ad.b.a.b
            public final void Y() {
                ai.bb(System.currentTimeMillis());
                e.go().gk();
            }

            @Override // com.kwad.components.ad.b.a.b
            public final void Z() {
                com.kwad.sdk.core.d.c.d("PushAdManager", "onAdClose: ");
                e.go().gm();
                b.gb().a(c.this);
            }
        });
    }

    public final void d(com.kwad.components.core.internal.api.a aVar) {
        AdTemplate adTemplate = aVar.getAdTemplate();
        if (!adTemplate.equals(this.rv)) {
            com.kwad.sdk.core.d.c.d("PushAdManager", "onAdExit not current ad");
            return;
        }
        com.kwad.sdk.core.d.c.d("PushAdManager", "onAdExit showPushAdDelayTime: " + this.ru + ", adTemplate: " + adTemplate.hashCode());
        if (aVar.supportPushAd()) {
            a(1000001, this, this.ru);
        }
    }

    public final void gh() {
        com.kwad.sdk.core.d.c.d("PushAdManager", "onOutSDKPage: ");
        if (rt.hasMessages(1000001)) {
            return;
        }
        com.kwad.sdk.core.d.c.d("PushAdManager", "onOutSDKPage: sendMessageDelay MSG_WHAT_PAGE_OUT");
        a(1000002, this, 500L);
    }

    private static void a(int i, Runnable runnable, long j) {
        Handler handler = rt;
        Message messageObtain = Message.obtain(handler, runnable);
        messageObtain.what = i;
        handler.sendMessageDelayed(messageObtain, j);
    }
}
