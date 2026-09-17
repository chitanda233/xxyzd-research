package com.kwad.components.ad.splashscreen.presenter;

import android.view.View;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends e implements com.kwad.sdk.widget.d {
    private View Hj;
    private boolean Hk;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.Hj = findViewById(R.id.ksad_splash_actionbar_full_screen);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.Hu == null) {
            return;
        }
        this.Hk = com.kwad.sdk.core.response.helper.d.eB(this.Hu.mAdTemplate);
        boolean zO = com.kwad.components.ad.splashscreen.h.o(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        this.Hj.setVisibility(zO ? 0 : 8);
        if (zO) {
            new com.kwad.sdk.widget.h(this.Hj.getContext(), this.Hj, this);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        this.Hu.c(1, view.getContext(), 53, 3);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        com.kwad.sdk.core.d.c.d("FullScreenTouchConvertPresenter", "onSlide: enableSlickClick: " + this.Hk);
        if (SlideConvertHelper.a(this.Hu.mAdTemplate, f, f2, f3, f4)) {
            this.Hu.c(1, view.getContext(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 3);
        }
    }
}
