package com.byazt.hy;

import android.os.SystemClock;
import com.byazt.gqp.i;
import com.byazt.gqp.m;
import com.byazt.gqp.nu;
import com.byazt.gqp.yp;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.IOException;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_BASEPLAYER_VIDEO_BUFLEN, 20})
public class c {
    public static volatile long c = 0;
    public static volatile String tt = "0";

    public static String c() {
        return System.currentTimeMillis() - c < 7200000 ? tt : "0";
    }

    /* JADX INFO: renamed from: com.byazt.hy.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_BASEPLAYER_VIDEO_BUFLEN, 44})
    public static class C0147c implements i {
        @Override // com.byazt.gqp.i
        public m c(i.c cVar) throws IOException {
            nu nuVarA;
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            yp ypVarC = cVar.c();
            m mVarC = cVar.c(ypVarC);
            if (!"GET".equalsIgnoreCase(ypVarC.ve()) || (nuVarA = mVarC.a()) == null) {
                return mVarC;
            }
            long jC = nuVarA.c();
            long jElapsedRealtime2 = SystemClock.elapsedRealtime() - jElapsedRealtime;
            if (jElapsedRealtime2 > 0 && jC > 10240) {
                String unused = c.tt = String.format("%.2f", Double.valueOf(((jC / 1024.0d) / jElapsedRealtime2) * 1000.0d));
                long unused2 = c.c = System.currentTimeMillis();
                String unused3 = c.tt;
            }
            return mVarC;
        }
    }
}
