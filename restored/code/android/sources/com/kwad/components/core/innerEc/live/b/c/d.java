package com.kwad.components.core.innerEc.live.b.c;

import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.info.IHostLivePlayerState;
import com.kwad.sdk.utils.ae;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.core.innerEc.live.b.a.a {
    private com.kwad.components.core.innerEc.live.d.b UZ;
    private boolean VJ;
    private boolean VK;
    private final com.kwad.components.core.innerEc.live.video.a.c VL = new com.kwad.components.core.innerEc.live.video.a.c() { // from class: com.kwad.components.core.innerEc.live.b.c.d.1
        @Override // com.kwad.components.offline.api.core.adInnerEc.fullAdLive.listener.IHostLivePlayerStateChangeListener
        public final void onStateChange(IHostLivePlayerState iHostLivePlayerState) {
            if (iHostLivePlayerState == IHostLivePlayerState.PLAYING) {
                d.a(d.this, true);
            }
        }
    };
    private final com.kwad.components.core.innerEc.live.d.a VM = new com.kwad.components.core.innerEc.live.d.a() { // from class: com.kwad.components.core.innerEc.live.b.c.d.2
        @Override // com.kwad.components.core.innerEc.live.d.a
        public final void sp() {
            ae.W(d.this.getContext(), "直播间加载失败，请稍后重试");
            d.this.getActivity().finish();
        }

        @Override // com.kwad.components.core.innerEc.live.d.a
        public final void aB() {
            d.b(d.this, true);
        }
    };

    static /* synthetic */ boolean a(d dVar, boolean z) {
        dVar.VJ = true;
        return true;
    }

    static /* synthetic */ boolean b(d dVar, boolean z) {
        dVar.VK = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.UZ = this.Uj.UZ;
        this.Uj.UR.a(this.VL);
        this.UZ.a(this.VM);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.UZ.b(this.VM);
        this.Uj.UR.b(this.VL);
    }
}
