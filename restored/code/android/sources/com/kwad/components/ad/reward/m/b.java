package com.kwad.components.ad.reward.m;

import android.content.Context;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.ad.reward.g;
import com.kwad.components.core.video.i;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.k.a<i> implements g.a {
    private com.kwad.components.core.h.c Ct;

    @Override // com.kwad.components.ad.reward.g.a
    public final void hn() {
    }

    public b(AdTemplate adTemplate) {
        super(adTemplate);
        long jO = com.kwad.sdk.core.response.helper.a.O(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        com.kwad.components.core.h.c cVar = new com.kwad.components.core.h.c();
        this.Ct = cVar;
        cVar.E(jO);
    }

    public final FrameLayout T(Context context) {
        FrameLayout imagePlayerView = this.Ct.getImagePlayerView(context);
        this.Ct.setImageScaleType(ImageView.ScaleType.FIT_CENTER);
        return imagePlayerView;
    }

    public final void lm() {
        this.Ct.setURLs(com.kwad.sdk.core.response.helper.a.bg(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)));
        this.Ct.play();
    }

    @Override // com.kwad.components.ad.k.a
    public final void skipToEnd() {
        this.Ct.skipToEnd();
    }

    @Override // com.kwad.components.ad.k.a
    public final long getPlayDuration() {
        return this.Ct.getPlayDuration();
    }

    @Override // com.kwad.components.ad.k.a
    public final void resume() {
        this.Ct.resume();
    }

    @Override // com.kwad.components.ad.k.a
    public final void pause() {
        this.Ct.pause();
    }

    @Override // com.kwad.components.ad.k.a
    public final void b(i iVar) {
        this.Ct.c(iVar);
    }

    @Override // com.kwad.components.ad.k.a
    public final void a(i iVar) {
        this.Ct.d(iVar);
    }

    @Override // com.kwad.components.ad.k.a
    public final void release() {
        super.release();
        this.Ct.destroy();
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void ho() {
        resume();
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hp() {
        pause();
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hq() {
        this.Ct.destroy();
    }
}
