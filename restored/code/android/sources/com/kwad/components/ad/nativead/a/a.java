package com.kwad.components.ad.nativead.a;

import android.view.View;
import com.kwad.components.core.video.l;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public class a extends Presenter {
    public l mVideoPlayStateListener;
    public b pO;

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        this.pO = (b) SK();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onUnbind() {
        super.onUnbind();
        this.pO.pP.a(this.mVideoPlayStateListener);
    }

    protected static void a(View view, String str) {
        if (view == null) {
            ServiceProvider.reportSdkCaughtException(new RuntimeException(" findViewById failed " + str));
        }
    }
}
