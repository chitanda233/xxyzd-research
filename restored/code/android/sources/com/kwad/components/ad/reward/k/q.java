package com.kwad.components.ad.reward.k;

import android.content.DialogInterface;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class q extends z {
    private WeakReference<com.kwad.components.ad.reward.g> BX;
    private long zN;

    public q(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.components.ad.reward.g gVar, long j, com.kwad.sdk.core.webview.d.a.a aVar, DialogInterface.OnDismissListener onDismissListener) {
        super(bVar, dVar, aVar, onDismissListener);
        this.zN = j;
        if (gVar != null) {
            this.BX = new WeakReference<>(gVar);
        }
    }

    @Override // com.kwad.components.core.webview.jshandler.z
    public final void kL() {
        super.kL();
        if (this.apL != null) {
            com.kwad.components.ad.reward.c.a.m175if().c(this.apL.getAdTemplate(), com.kwad.components.ad.reward.c.b.STATUS_NONE);
        }
    }

    @Override // com.kwad.components.core.webview.jshandler.z
    public final com.kwad.components.core.e.d.a.C0428a a(com.kwad.components.core.e.d.a.C0428a c0428a, com.kwad.sdk.core.webview.d.b.a aVar, AdTemplate adTemplate) {
        long playDuration;
        WeakReference<com.kwad.components.ad.reward.g> weakReference = this.BX;
        if (weakReference != null && weakReference.get() != null) {
            playDuration = this.BX.get().sr.getPlayDuration();
        } else {
            playDuration = this.zN;
            if (playDuration <= 0) {
                playDuration = 0;
            }
        }
        return super.a(c0428a, aVar, adTemplate).B(playDuration);
    }
}
