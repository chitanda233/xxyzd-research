package com.kwad.components.core.page.d;

import android.view.View;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.widget.FeedVideoView;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends Presenter {
    private int adR;
    private FeedVideoView adS;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        final com.kwad.components.core.page.recycle.e eVar = (com.kwad.components.core.page.recycle.e) SK();
        KsAdVideoPlayConfig ksAdVideoPlayConfigBuild = new KsAdVideoPlayConfig.Builder().videoSoundEnable(eVar.adTemplate.mIsAudioEnable).build();
        FeedVideoView feedVideoView = (FeedVideoView) getRootView();
        this.adS = feedVideoView;
        feedVideoView.d(com.kwad.sdk.core.response.helper.c.ex(eVar.adTemplate));
        this.adS.a(ksAdVideoPlayConfigBuild, eVar.QK);
        this.adS.setVisibility(0);
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(eVar.adTemplate);
        this.adS.setOnEndBtnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.page.d.b.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                try {
                    if (com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
                        if (eVar.QK != null) {
                            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(b.this.getActivity()).as(false).at(false).ax(true).aF(eVar.adTemplate).av(false));
                            com.kwad.sdk.core.adlog.c.a(eVar.adTemplate, 50, b.this.adS.getTouchCoords());
                            return;
                        }
                        return;
                    }
                    if (eVar.afv == null || eVar.afv.getAdapter() == null || eVar.afv.getAdapter().getItemCount() <= 1) {
                        return;
                    }
                    eVar.afv.scrollToPosition(1);
                    com.kwad.sdk.core.adlog.c.a(eVar.adTemplate, 50, b.this.adS.getTouchCoords());
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
        if (com.kwad.sdk.core.response.helper.a.aw(adInfoEM)) {
            this.adS.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.page.d.b.2
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    try {
                        if (com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
                            if (eVar.QK != null) {
                                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(b.this.getActivity()).as(false).at(false).ax(true).aF(eVar.adTemplate).av(false));
                                com.kwad.sdk.core.adlog.c.a(eVar.adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_BIT_RATE, b.this.adS.getTouchCoords());
                                return;
                            }
                            return;
                        }
                        if (eVar.afv == null || eVar.afv.getAdapter() == null || eVar.afv.getAdapter().getItemCount() <= 1) {
                            return;
                        }
                        eVar.afv.scrollToPosition(1);
                        com.kwad.sdk.core.adlog.c.a(eVar.adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_BIT_RATE, b.this.adS.getTouchCoords());
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                }
            });
        }
        this.adS.setWindowFullScreenListener(new FeedVideoView.a() { // from class: com.kwad.components.core.page.d.b.3
            @Override // com.kwad.components.core.widget.FeedVideoView.a
            public final void ut() {
                if (eVar.afv != null) {
                    b.this.adR = eVar.afv.computeVerticalScrollOffset();
                }
            }

            @Override // com.kwad.components.core.widget.FeedVideoView.a
            public final void uu() {
                if (eVar.afv != null) {
                    eVar.afv.scrollToPosition(b.this.adR);
                }
            }
        });
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.adS.release();
    }
}
