package com.byazt.ia;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.qq.gdt.action.ActionUtils;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SEEK_EXACT, 15})
public class uj {
    public int c;

    public uj(Context context) {
        try {
            c(context);
        } catch (Throwable unused) {
        }
    }

    private void c(Context context) {
        context.registerReceiver(new c(), new IntentFilter("android.intent.action.BATTERY_CHANGED"));
    }

    public int c() {
        return this.c;
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SEEK_EXACT, 123})
    private class c extends BroadcastReceiver {
        private c() {
        }

        @Override // android.content.BroadcastReceiver
        public void onReceive(Context context, Intent intent) {
            try {
                if ("android.intent.action.BATTERY_CHANGED".equals(intent.getAction())) {
                    uj.this.c = (int) ((intent.getIntExtra(ActionUtils.LEVEL, 0) * 100.0f) / intent.getIntExtra("scale", 100));
                }
            } catch (Throwable unused) {
            }
        }
    }
}
