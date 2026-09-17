package com.byazt.zb;

import android.content.Context;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Vibrator;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO, 72})
public class da {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static SensorManager f1610a;
    public static c c;
    public static final float[] tt = new float[3];
    public static final float[] ve = new float[3];
    public static final float[] uj = new float[9];
    public static final float[] n = new float[3];

    private static int c(int i) {
        if (i == 0 || i == 1 || i == 2 || i == 3) {
            return i;
        }
        return 2;
    }

    public static void c(c cVar) {
        c = cVar;
    }

    private static SensorManager c(Context context) {
        if (f1610a == null) {
            synchronized (da.class) {
                if (f1610a == null) {
                    f1610a = (SensorManager) context.getSystemService("sensor");
                }
            }
        }
        return f1610a;
    }

    private static boolean c() {
        c cVar = c;
        return cVar == null || !cVar.tt();
    }

    public static void c(Context context, SensorEventListener sensorEventListener, int i) {
        if (sensorEventListener == null || context == null) {
            return;
        }
        try {
            if (c()) {
                return;
            }
            c cVar = c;
            if (cVar == null || !cVar.ve()) {
                SensorManager sensorManagerC = c(context);
                sensorManagerC.registerListener(sensorEventListener, sensorManagerC.getDefaultSensor(1), c(i));
            }
        } catch (Throwable th) {
            sp.c("SensorHub", "startListenAccelerometer error", th);
        }
    }

    public static void tt(Context context, SensorEventListener sensorEventListener, int i) {
        if (sensorEventListener == null || context == null) {
            return;
        }
        try {
            if (c()) {
                return;
            }
            c cVar = c;
            if (cVar == null || !cVar.ve()) {
                SensorManager sensorManagerC = c(context);
                sensorManagerC.registerListener(sensorEventListener, sensorManagerC.getDefaultSensor(4), c(i));
            }
        } catch (Throwable th) {
            sp.c("SensorHub", "startListenGyroscope error", th);
        }
    }

    public static void ve(Context context, SensorEventListener sensorEventListener, int i) {
        if (sensorEventListener == null || context == null) {
            return;
        }
        try {
            if (c()) {
                return;
            }
            c cVar = c;
            if (cVar == null || !cVar.ve()) {
                SensorManager sensorManagerC = c(context);
                sensorManagerC.registerListener(sensorEventListener, sensorManagerC.getDefaultSensor(10), c(i));
            }
        } catch (Throwable th) {
            sp.c("SensorHub", "startListenLinearAcceleration error", th);
        }
    }

    public static void uj(Context context, SensorEventListener sensorEventListener, int i) {
        if (sensorEventListener == null || context == null) {
            return;
        }
        try {
            if (c()) {
                return;
            }
            c cVar = c;
            if (cVar == null || !cVar.ve()) {
                SensorManager sensorManagerC = c(context);
                sensorManagerC.registerListener(sensorEventListener, sensorManagerC.getDefaultSensor(1), c(i));
                sensorManagerC.registerListener(sensorEventListener, sensorManagerC.getDefaultSensor(2), c(i));
            }
        } catch (Throwable th) {
            sp.c("SensorHub", "startListenRotationVector err", th);
        }
    }

    public static void c(Context context, SensorEventListener sensorEventListener) {
        if (sensorEventListener == null || context == null) {
            return;
        }
        try {
            c(context).unregisterListener(sensorEventListener);
        } catch (Throwable th) {
            sp.c("SensorHub", "stopListen error", th);
        }
    }

    public static void c(Context context, long j) {
        if (context == null) {
            return;
        }
        ((Vibrator) context.getSystemService("vibrator")).vibrate(j);
    }
}
