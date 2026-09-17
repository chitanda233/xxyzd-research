package com.byazt.gg;

import android.app.Application;
import android.content.Context;
import com.byazt.bog.n;
import com.byazt.lm.uj;
import com.byazt.quv.AbsServerManager;
import com.byazt.zqa.c;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.TTAppContextHolder;

/* JADX INFO: loaded from: classes.dex */
@c(c = {0, 1, 2027, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_BITRATE})
public class MainServerManager extends AbsServerManager {
    @Override // com.byazt.quv.AbsServerManager, android.content.ContentProvider
    public boolean onCreate() {
        Context applicationContext = getContext().getApplicationContext();
        TTAppContextHolder.setContext(applicationContext);
        if (!n.c() && (applicationContext instanceof Application)) {
            ((Application) applicationContext).registerActivityLifecycleCallbacks(uj.instance().getActivityLifecycleCallback());
        }
        return super.onCreate();
    }
}
