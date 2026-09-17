package com.kwad.components.ad.draw.presenter.livecard;

import com.kwad.components.offline.api.core.adlive.listener.AdLiveHandleClickListener;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.draw.b.a {
    private AdLiveHandleClickListener em = new AdLiveHandleClickListener() { // from class: com.kwad.components.ad.draw.presenter.livecard.a.1
        @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveHandleClickListener
        public final void handleAdLiveClick(int i) {
            if (i == 1) {
                a.this.dL.a(1, a.this.getContext(), 115, 1);
            } else if (i == 2) {
                a.this.dL.a(1, a.this.getContext(), 117, 2);
            }
        }
    };

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.dL.dP != null) {
            this.dL.dP.registerClickListener(this.em);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (this.dL.dP != null) {
            this.dL.dP.unRegisterClickListener(this.em);
        }
    }
}
