package com.byazt.zz;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SHARP, MediaPlayer.MEDIA_PLAYER_OPTION_SLOW_PLAY_TIME})
public class CSJIndependentProcessDownloadService extends CSJDownloadService {
    @Override // com.byazt.zz.CSJDownloadService, android.app.Service
    public void onCreate() {
        super.onCreate();
        ve.c(this);
        if (ve.pu() == null) {
            ve.c(new qy());
        }
        this.c = ve.p();
        this.c.c(new WeakReference(this));
    }
}
