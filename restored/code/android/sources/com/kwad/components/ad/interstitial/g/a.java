package com.kwad.components.ad.interstitial.g;

import android.app.Activity;
import android.content.DialogInterface;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.interstitial.f.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static boolean e(final c cVar) {
        Activity ownerActivity;
        if (cVar.lp != null && (ownerActivity = cVar.lp.getOwnerActivity()) != null && !ownerActivity.isFinishing()) {
            AdInfo adInfoEM = e.eM(cVar.mAdTemplate);
            int iDT = com.kwad.components.ad.interstitial.c.b.dT();
            int iDU = com.kwad.components.ad.interstitial.c.b.dU();
            if (iDT > com.kwad.sdk.core.response.helper.a.cD(adInfoEM) && iDU < com.kwad.sdk.core.response.helper.a.cE(adInfoEM)) {
                if (com.kwad.sdk.core.response.helper.a.cF(adInfoEM) == 2) {
                    com.kwad.components.ad.interstitial.h.b.f(cVar);
                    return true;
                }
                if (com.kwad.sdk.core.response.helper.a.cF(adInfoEM) == 1) {
                    new com.kwad.components.core.page.widget.a(ownerActivity, com.kwad.sdk.core.response.helper.a.cG(adInfoEM), new com.kwad.components.core.page.widget.a.InterfaceC0453a() { // from class: com.kwad.components.ad.interstitial.g.a.1
                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void c(DialogInterface dialogInterface) {
                        }

                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void a(DialogInterface dialogInterface) {
                            dialogInterface.dismiss();
                            com.kwad.sdk.core.adlog.c.c(cVar.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dZ(8));
                        }

                        @Override // com.kwad.components.core.page.widget.a.InterfaceC0453a
                        public final void b(DialogInterface dialogInterface) {
                            c cVar2 = cVar;
                            cVar2.a(false, -1, cVar2.cB);
                            dialogInterface.dismiss();
                            com.kwad.sdk.core.adlog.c.e(cVar.mAdTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS).dZ(8));
                            cVar.lp.dismiss();
                        }
                    }).show();
                    com.kwad.sdk.core.adlog.c.d(cVar.mAdTemplate, new JSONObject(), new com.kwad.sdk.core.adlog.c.b().dU(149).dZ(8));
                    return true;
                }
            }
        }
        return false;
    }
}
