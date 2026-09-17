package com.kwad.sdk.utils;

import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class bl implements SensorEventListener {
    private AtomicBoolean SO;
    private final b bqm;
    private final b bqn;
    private final b bqo;
    private AtomicBoolean bqp;
    private final bk.b bqq;

    @Override // android.hardware.SensorEventListener
    public final void onAccuracyChanged(Sensor sensor, int i) {
    }

    /* synthetic */ bl(byte b2) {
        this();
    }

    private bl() {
        byte b2 = 0;
        this.bqm = new b(b2);
        this.bqn = new b(b2);
        this.bqo = new b(b2);
        this.bqp = new AtomicBoolean(false);
        this.SO = new AtomicBoolean(false);
        this.bqq = new bk.b() { // from class: com.kwad.sdk.utils.bl.4
            @Override // com.kwad.sdk.utils.bk.b
            public final void onFailed() {
                bl.this.bqp.compareAndSet(false, true);
            }
        };
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.sdk.utils.bl.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                super.onBackToForeground();
                if (t.US()) {
                    bl.this.register();
                }
            }

            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToBackground() {
                super.onBackToBackground();
                bl.this.WA();
            }
        });
    }

    static class a {
        private static final bl bqs = new bl(0);
    }

    public static bl Wy() {
        return a.bqs;
    }

    public final synchronized List<com.kwad.sdk.k.a.e> Wz() {
        if (!t.US()) {
            return null;
        }
        com.kwad.sdk.core.c.b.Mh();
        if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
            register();
        }
        ArrayList arrayList = new ArrayList();
        this.bqm.aa(arrayList);
        this.bqn.aa(arrayList);
        this.bqo.aa(arrayList);
        return arrayList;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void register() {
        if (this.bqp.get() || this.SO.get()) {
            return;
        }
        i.execute(new bi() { // from class: com.kwad.sdk.utils.bl.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                try {
                    bk bkVarWx = bk.Wx();
                    bl blVar = bl.this;
                    bkVarWx.a(3, 3, blVar, blVar.bqq);
                    bk bkVarWx2 = bk.Wx();
                    bl blVar2 = bl.this;
                    bkVarWx2.a(2, 3, blVar2, blVar2.bqq);
                    bk bkVarWx3 = bk.Wx();
                    bl blVar3 = bl.this;
                    bkVarWx3.a(4, 3, blVar3, blVar3.bqq);
                    bl.this.SO.set(true);
                } catch (Throwable unused) {
                    bl.this.bqp.set(true);
                }
            }
        });
    }

    @Override // android.hardware.SensorEventListener
    public final void onSensorChanged(SensorEvent sensorEvent) {
        int type = sensorEvent.sensor.getType();
        if (type == 1) {
            this.bqm.b(sensorEvent);
        } else if (type == 4) {
            this.bqn.b(sensorEvent);
        } else {
            if (type != 9) {
                return;
            }
            this.bqo.b(sensorEvent);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void WA() {
        if (this.SO.get()) {
            i.execute(new bi() { // from class: com.kwad.sdk.utils.bl.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    bk.Wx().a(bl.this);
                    bl.this.SO.compareAndSet(true, false);
                }
            });
        }
    }

    static class b {
        private SensorEvent bqt;
        private long timestamp;

        private b() {
        }

        /* synthetic */ b(byte b) {
            this();
        }

        public final void b(SensorEvent sensorEvent) {
            this.bqt = sensorEvent;
            this.timestamp = System.currentTimeMillis();
        }

        public final void aa(List<com.kwad.sdk.k.a.e> list) {
            if (this.bqt == null) {
                return;
            }
            com.kwad.sdk.k.a.e eVar = new com.kwad.sdk.k.a.e();
            eVar.sensorType = this.bqt.sensor.getType();
            eVar.timestamp = this.timestamp / 1000;
            for (float f : this.bqt.values) {
                eVar.bmD.add(Float.valueOf(f));
            }
            list.add(eVar);
        }
    }
}
