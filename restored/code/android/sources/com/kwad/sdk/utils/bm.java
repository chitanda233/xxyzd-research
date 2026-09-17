package com.kwad.sdk.utils;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.util.SparseArray;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class bm {
    private static bm bqu;
    private SensorManager bqv;
    private final List<Integer> bqw;
    private final SparseArray<Sensor> bqx;

    public static bm WC() {
        if (bqu == null) {
            synchronized (bm.class) {
                if (bqu == null) {
                    bqu = new bm();
                }
            }
        }
        return bqu;
    }

    private bm() {
        ArrayList arrayList = new ArrayList();
        this.bqw = arrayList;
        this.bqx = new SparseArray<>();
        arrayList.addAll(Arrays.asList(1, 9, 10, 2, 4));
    }

    public final SensorManager checkAndObtainSensorManager(Context context) {
        if (WE()) {
            return el(context);
        }
        return null;
    }

    public final Sensor getDefaultSensor(Context context, int i) {
        com.kwad.sdk.core.d.c.d("SensorManagerWrapper", "getDefaultSensor type:" + i);
        if (!WE()) {
            com.kwad.sdk.core.d.c.w("SensorManagerWrapper", "getDefaultSensor checkEnableSensor not enable sensor");
            return null;
        }
        if (this.bqx.get(i) == null) {
            if (!this.bqw.contains(Integer.valueOf(i))) {
                this.bqw.add(Integer.valueOf(i));
            }
            em(context);
        }
        Sensor sensor = this.bqx.get(i);
        com.kwad.sdk.core.d.c.w("SensorManagerWrapper", "getDefaultSensor result:" + sensor);
        return sensor;
    }

    public final boolean registerListener(Context context, SensorEventListener sensorEventListener, Sensor sensor, int i) {
        com.kwad.sdk.core.d.c.d("SensorManagerWrapper", "registerListener sensor:" + sensor + ", listener: " + sensorEventListener);
        if (!WE()) {
            return false;
        }
        try {
            return el(context).registerListener(sensorEventListener, sensor, i);
        } catch (Exception unused) {
            return false;
        }
    }

    public final void unregisterListener(SensorEventListener sensorEventListener) {
        SensorManager sensorManager;
        com.kwad.sdk.core.d.c.d("SensorManagerWrapper", "unregisterListener listener:" + sensorEventListener);
        if (WE() && (sensorManager = this.bqv) != null) {
            try {
                sensorManager.unregisterListener(sensorEventListener);
            } catch (Throwable unused) {
            }
        }
    }

    private static boolean WD() {
        return !be.useSensorManagerDisable();
    }

    private SensorManager el(Context context) {
        if (this.bqv == null) {
            this.bqv = (SensorManager) context.getSystemService("sensor");
        }
        return this.bqv;
    }

    private void em(Context context) {
        SensorManager sensorManagerEl = el(context);
        com.kwad.sdk.core.d.c.w("SensorManagerWrapper", "fetchMultiSensors SensorManager.getSensorList call ");
        List<Sensor> sensorList = sensorManagerEl.getSensorList(-1);
        if (sensorList != null) {
            Iterator<Integer> it = this.bqw.iterator();
            while (it.hasNext()) {
                int iIntValue = it.next().intValue();
                for (Sensor sensor : sensorList) {
                    if (iIntValue == sensor.getType()) {
                        this.bqx.put(iIntValue, sensor);
                        break;
                    }
                }
            }
        }
    }

    private boolean WE() {
        boolean zWD = WD();
        com.kwad.sdk.core.d.c.d("SensorManagerWrapper", "checkEnableSensor enable:" + zWD);
        if (zWD) {
            return true;
        }
        this.bqv = null;
        return false;
    }
}
