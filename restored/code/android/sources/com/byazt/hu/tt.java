package com.byazt.hu;

import android.os.AsyncTask;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1381, 13})
public class tt {
    public static final c c = new C0145tt();

    @com.byazt.zqa.c(c = {0, 1, 1381, MediaPlayer.MEDIA_PLAYER_OPTION_JX_CODEC_LOW_LATENCY})
    private static class c {
        private c() {
        }

        public <T> void c(AsyncTask<T, ?, ?> asyncTask, T... tArr) {
            try {
                asyncTask.executeOnExecutor(com.byazt.jtc.tt.THREAD_POOL_EXECUTOR, tArr);
            } catch (Throwable unused) {
            }
        }
    }

    /* JADX INFO: renamed from: com.byazt.hu.tt$tt, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, 1381, MediaPlayer.MEDIA_PLAYER_OPTION_GET_PLAY_WASTE_DATA})
    private static class C0145tt extends c {
        private C0145tt() {
            super();
        }

        @Override // com.byazt.hu.tt.c
        public <T> void c(AsyncTask<T, ?, ?> asyncTask, T... tArr) {
            try {
                asyncTask.executeOnExecutor(AsyncTask.THREAD_POOL_EXECUTOR, tArr);
            } catch (Throwable unused) {
            }
        }
    }

    public static <T> void c(AsyncTask<T, ?, ?> asyncTask, T... tArr) {
        c.c(asyncTask, tArr);
    }
}
