package com.sigmob.sdk.base.common;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.util.Log;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Set;
import java.util.concurrent.CopyOnWriteArraySet;

/* JADX INFO: loaded from: classes3.dex */
public class ag implements SensorEventListener {
    private static final String c = "SensorManagerHelper";
    private static volatile ag d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Set<SensorEventListener> f3145a = new CopyOnWriteArraySet();
    public boolean b = false;
    private final SensorManager e;

    private ag(Context context) {
        this.e = (SensorManager) context.getSystemService("sensor");
    }

    public static ag a(Context context) {
        if (d == null) {
            synchronized (ag.class) {
                if (d == null) {
                    d = new ag(context.getApplicationContext());
                }
            }
        }
        return d;
    }

    private List<Integer> a(int[] typeArr) {
        if (this.e == null || typeArr == null) {
            return new ArrayList();
        }
        ArrayList arrayList = new ArrayList();
        for (int i : typeArr) {
            Sensor defaultSensor = this.e.getDefaultSensor(i);
            if (defaultSensor == null) {
                Log.w(c, "Sensor type " + i + " not found on this device.");
            } else {
                this.e.registerListener(this, defaultSensor, 3);
                arrayList.add(Integer.valueOf(i));
            }
        }
        return arrayList;
    }

    private void b() {
        if (this.b || this.f3145a.isEmpty()) {
            return;
        }
        this.e.unregisterListener(this);
        try {
            com.sigmob.sdk.base.utils.k.c(c, "startListeningIfNeeded: registeredSensors = " + a(new int[]{4, 1, 10, 2}), new Object[0]);
            this.b = true;
        } catch (Exception e) {
            Log.e(c, "Failed to register listener for sensor.", e);
        }
    }

    private void c() {
        if (this.b && this.f3145a.isEmpty()) {
            this.e.unregisterListener(this);
            this.b = false;
        }
    }

    public void a() {
        if (this.b) {
            this.e.unregisterListener(this);
            this.b = false;
        }
        this.f3145a.clear();
        d = null;
    }

    public void a(SensorEventListener listener) {
        if (this.f3145a.add(listener)) {
            b();
        }
    }

    public void b(SensorEventListener listener) {
        if (this.f3145a.remove(listener)) {
            c();
        }
    }

    @Override // android.hardware.SensorEventListener
    public void onAccuracyChanged(Sensor sensor, int accuracy) {
        Iterator<SensorEventListener> it = this.f3145a.iterator();
        while (it.hasNext()) {
            it.next().onAccuracyChanged(sensor, accuracy);
        }
    }

    @Override // android.hardware.SensorEventListener
    public void onSensorChanged(SensorEvent event) {
        Iterator<SensorEventListener> it = this.f3145a.iterator();
        while (it.hasNext()) {
            it.next().onSensorChanged(event);
        }
    }
}
