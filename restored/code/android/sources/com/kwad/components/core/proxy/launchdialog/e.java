package com.kwad.components.core.proxy.launchdialog;

import android.app.Application;
import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static e ajl = new e();
    private List<b> ajm = new CopyOnWriteArrayList();
    private a ajn = new a();
    private com.kwad.components.core.proxy.b ajo = new com.kwad.components.core.proxy.b(this.ajn);

    public static e vV() {
        return ajl;
    }

    public final void a(b bVar) {
        if (bVar != null) {
            this.ajm.add(bVar);
        }
    }

    public final void b(b bVar) {
        if (bVar != null) {
            this.ajm.remove(bVar);
        }
    }

    public final void init(Context context) {
        Context applicationContext = context.getApplicationContext();
        if (applicationContext instanceof Application) {
            ((Application) applicationContext).registerActivityLifecycleCallbacks(this.ajo);
        }
    }

    public final void aW(final AdTemplate adTemplate) {
        n(this.ajn.vP());
        vV().a(DetectEventType.USER_CANCEL, new f() { // from class: com.kwad.components.core.proxy.launchdialog.e.1
            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void j(com.kwad.components.core.proxy.a aVar) {
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CANCEL PageLaunchDialogManager onContinue");
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void k(com.kwad.components.core.proxy.a aVar) {
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CANCEL PageLaunchDialogManager onComplete");
                e.this.aY(adTemplate);
                e.this.n(aVar);
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void l(com.kwad.components.core.proxy.a aVar) {
                e.this.n(aVar);
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CANCEL PageLaunchDialogManager onTimeout");
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void m(com.kwad.components.core.proxy.a aVar) {
                e.this.n(aVar);
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CANCEL PageLaunchDialogManager onNotMatch");
            }
        });
        vV().a(DetectEventType.USER_CONFIRM, new f() { // from class: com.kwad.components.core.proxy.launchdialog.e.2
            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void j(com.kwad.components.core.proxy.a aVar) {
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CONFIRM PageLaunchDialogManager onContinue");
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void k(com.kwad.components.core.proxy.a aVar) {
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CONFIRM PageLaunchDialogManager onComplete");
                e.this.aX(adTemplate);
                e.this.n(aVar);
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void l(com.kwad.components.core.proxy.a aVar) {
                e.this.n(aVar);
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CONFIRM PageLaunchDialogManager onTimeout");
            }

            @Override // com.kwad.components.core.proxy.launchdialog.f
            public final void m(com.kwad.components.core.proxy.a aVar) {
                e.this.n(aVar);
                com.kwad.sdk.core.d.c.d("PageLaunchDialogManager", "USER_CONFIRM PageLaunchDialogManager onNotMatch");
            }
        });
        long jEW = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
        Iterator<b> it = this.ajm.iterator();
        while (it.hasNext()) {
            it.next().b(jEW, 1);
        }
    }

    private void a(DetectEventType detectEventType, f fVar) {
        c cVarA = this.ajn.a(detectEventType);
        if (cVarA != null) {
            cVarA.a(fVar);
            cVarA.start();
        }
    }

    public final void n(com.kwad.components.core.proxy.a aVar) {
        this.ajn.i(aVar);
        this.ajn.h(aVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aX(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.c.e(adTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_NETWORK_TRY_COUNT).eb(25));
        long jEW = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
        Iterator<b> it = this.ajm.iterator();
        while (it.hasNext()) {
            it.next().b(jEW, 2);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aY(AdTemplate adTemplate) {
        com.kwad.sdk.core.adlog.c.e(adTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_ALOG_WRITE_FUNC_ADDR).eb(25));
        long jEW = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
        Iterator<b> it = this.ajm.iterator();
        while (it.hasNext()) {
            it.next().b(jEW, 3);
        }
    }
}
