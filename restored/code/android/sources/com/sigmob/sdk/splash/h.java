package com.sigmob.sdk.splash;

import android.content.Context;
import android.media.MediaPlayer;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;

/* JADX INFO: loaded from: classes4.dex */
class h extends b {
    private final com.sigmob.sdk.base.views.c b;
    private final BaseAdUnit c;
    private boolean d;

    public h(Context context, BaseAdUnit adUnit) {
        super(context);
        ViewGroup.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
        com.sigmob.sdk.base.views.c cVar = new com.sigmob.sdk.base.views.c(context);
        this.b = cVar;
        setBackgroundColor(-16777216);
        this.c = adUnit;
        addView(cVar, layoutParams);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(MediaPlayer mediaPlayer) {
        this.f3616a = mediaPlayer.getDuration() / 1000;
        mediaPlayer.setVolume(0.0f, 0.0f);
        mediaPlayer.start();
        if (this.d) {
            return;
        }
        this.d = true;
        SigmobLog.i("video onPrepared");
        BaseBroadcastReceiver.a(getContext(), this.c.getUuid(), IntentActions.ACTION_INTERSTITIAL_SHOW);
    }

    @Override // com.sigmob.sdk.splash.b
    public void a() {
        super.setVisibility(0);
        SigmobLog.i("video showAd");
        this.b.setVisibility(0);
        this.b.d();
    }

    @Override // com.sigmob.sdk.splash.b
    public boolean a(BaseAdUnit adUnit) {
        String str;
        if (adUnit == null) {
            str = "adUnit is null.";
        } else {
            String splashFilePath = adUnit.getSplashFilePath();
            if (splashFilePath != null) {
                this.b.a(0, 0);
                this.b.setOnPreparedListener(new MediaPlayer.OnPreparedListener() { // from class: com.sigmob.sdk.splash.h$$ExternalSyntheticLambda0
                    @Override // android.media.MediaPlayer.OnPreparedListener
                    public final void onPrepared(MediaPlayer mediaPlayer) {
                        this.f$0.a(mediaPlayer);
                    }
                });
                this.b.setVideoPath(splashFilePath);
                return true;
            }
            str = "filePath is null.";
        }
        SigmobLog.e(str);
        return false;
    }

    @Override // com.sigmob.sdk.splash.b
    public void b() {
        this.b.a();
    }

    @Override // com.sigmob.sdk.splash.b
    public void c() {
        this.b.b();
    }

    @Override // android.view.View
    public void setVisibility(int visibility) {
        if (visibility == 8) {
            try {
                if (this.b != null) {
                    SigmobLog.i("video GONE");
                    this.b.c();
                    removeAllViews();
                }
            } catch (Throwable th) {
                SigmobLog.e("set splash ad video content error: " + th.getMessage());
            }
        }
        super.setVisibility(visibility);
    }
}
