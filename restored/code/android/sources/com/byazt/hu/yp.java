package com.byazt.hu;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1381, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public class yp extends Handler {
    public WeakReference<c> c;

    public interface c {
        void c(Message message);
    }

    public yp(Looper looper, c cVar) {
        super(looper);
        this.c = new WeakReference<>(cVar);
    }

    @Override // android.os.Handler
    public void handleMessage(Message message) {
        c cVar = this.c.get();
        if (cVar == null || message == null) {
            return;
        }
        cVar.c(message);
    }
}
