package com.sigmob.sdk.base.common;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.models.SensorEntity;
import java.util.HashMap;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;

/* JADX INFO: loaded from: classes3.dex */
public class am {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static String f3151a = "am";
    private static ag b;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.am$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3152a;

        static {
            int[] iArr = new int[d.values().length];
            f3152a = iArr;
            try {
                iArr[d.SLOPE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3152a[d.SWING.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3152a[d.WRING.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
        }
    }

    public static class a implements SensorEventListener {
        static int[] e = {25, 60, 50, 45, 35, 25, 20, 15, 10, 5, 1};
        static float[] f = {4.0f, 10.0f, 8.0f, 6.0f, 5.0f, 4.0f, 3.0f, 2.0f, 1.8f, 1.5f, 1.0f};
        static int[] g = {15, 15, 13, 11, 10, 8, 6, 4, 3, 2, 1};
        static float[] h = {35.0f, 35.0f, 30.0f, 25.0f, 20.0f, 15.0f, 12.0f, 8.0f, 5.0f, 2.0f, 1.0f};
        private static float o = 40.0f;
        private boolean A;
        private float B;
        private long D;
        private Integer E;
        private boolean F;
        private boolean G;
        private Timer H;
        public int b;
        public int c;
        public int d;
        Float k;
        private SensorEvent l;
        private SensorEvent m;
        private SensorEvent n;
        private c p;
        private float q;
        private float r;
        private float s;
        private long t;
        private boolean u;
        private final d v;
        private long w;
        private float x;
        private float y;
        private float z;

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        protected int f3153a = 0;
        float[] i = new float[9];
        float[] j = new float[3];
        private int C = 100;
        private final long I = -1;
        private long J = -1;

        public a(Context context, c motionListener, d type) {
            if (am.b == null && com.sigmob.sdk.base.utils.v.b(context)) {
                ag unused = am.b = ag.a(context);
            }
            this.p = motionListener;
            this.v = type;
        }

        private void a(SensorEvent event, SensorEvent gyroscopeEvent) {
            int iIntValue;
            if (a(event, 3) || a(gyroscopeEvent, 3)) {
                com.sigmob.sdk.base.utils.k.e(am.f3151a, "handleAccelerometerData: event is unavailable.", new Object[0]);
                return;
            }
            float f2 = event.values[0];
            float f3 = event.values[1];
            float f4 = event.values[2];
            float f5 = gyroscopeEvent.values[0];
            float f6 = gyroscopeEvent.values[1];
            float f7 = gyroscopeEvent.values[2];
            double degrees = 0.0d;
            if (this.u) {
                degrees = this.w > 0 ? Math.toDegrees(((float) Math.sqrt(Math.pow(f5, 2.0d) + Math.pow(f6, 2.0d) + Math.pow(f7, 2.0d))) * (((gyroscopeEvent.timestamp - this.w) * 1.0f) / 1.0E9f)) : 0.0d;
                this.w = gyroscopeEvent.timestamp;
            } else {
                this.w = 0L;
            }
            double d = degrees;
            float fSqrt = (float) Math.sqrt(Math.pow(f2, 2.0d) + Math.pow(f3, 2.0d) + Math.pow(f4, 2.0d));
            long jCurrentTimeMillis = System.currentTimeMillis();
            long j = jCurrentTimeMillis - this.t;
            if (Math.abs(this.q) < Math.abs(f2)) {
                this.q = f2;
            }
            if (Math.abs(this.r) < Math.abs(f3)) {
                this.r = f3;
            }
            if (Math.abs(this.s) < Math.abs(f4)) {
                this.s = f4;
            }
            Integer num = this.E;
            if (num == null) {
                int i = this.f3153a;
                if (i <= 0 || i > 10) {
                    this.f3153a = 1;
                }
                iIntValue = g[this.f3153a];
            } else {
                iIntValue = num.intValue();
            }
            o = iIntValue;
            if (fSqrt <= 0.1d) {
                this.t = System.currentTimeMillis();
                return;
            }
            float f8 = h[this.f3153a];
            boolean z = fSqrt > o;
            if (!this.u) {
                this.u = true;
                this.t = jCurrentTimeMillis;
                SigmobLogger.d(am.f3151a, "handleAccelerometerData(start): acceleration = " + fSqrt, new Object[0]);
                if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                    this.p.a();
                    return;
                }
                return;
            }
            if (d > f8 && z) {
                if (f7 >= 0.0f) {
                    this.F = true;
                } else {
                    this.G = true;
                }
                SigmobLogger.d(am.f3151a, "handleAccelerometerData: currentRotationAngle = " + d + ", rotationAngleValue = " + f8 + ", shakeLeftOver = " + this.F + ", shakeRightOver = " + this.G, new Object[0]);
            }
            if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(e()))) {
                return;
            }
            int i2 = this.b;
            if (((i2 == 1 && this.F && this.G) || (i2 == 0 && (this.F || this.G))) && z && j >= this.d) {
                this.u = false;
                SigmobLogger.d(am.f3151a, "handleAccelerometerData(end): acceleration = " + fSqrt + ", sensitivity = " + o + ", currentDuration = " + j + ", shakeTriggerType = " + this.b + ", shakeTimeThreshold = " + this.d, new Object[0]);
                SigmobLog.d("handleAccelerometerData: shake end");
                this.q = 0.0f;
                this.r = 0.0f;
                this.s = 0.0f;
                this.F = false;
                this.G = false;
                HashMap map = new HashMap();
                map.put("x_max_acc", Float.valueOf(this.q * this.C));
                map.put("y_max_acc", Float.valueOf(this.r * this.C));
                map.put("z_max_acc", Float.valueOf(this.s * this.C));
                a(map);
            }
        }

        private void a(Map<String, Number> map) {
            SigmobLogger.d(am.f3151a, "interactionCompleted: type = " + this.v.name() + ", foregroundDuration = " + this.J + ", widgetIntervalTime = " + this.c, new Object[0]);
            if (this.p == null || map == null) {
                return;
            }
            SigmobLogger.d(am.f3151a, "interactionCompleted: map = " + map, new Object[0]);
            this.p.a(map);
            this.J = 0L;
            d();
            if (this.c <= 0) {
                return;
            }
            Timer timer = new Timer();
            this.H = timer;
            timer.schedule(new TimerTask() { // from class: com.sigmob.sdk.base.common.am.a.1
                @Override // java.util.TimerTask, java.lang.Runnable
                public void run() {
                    boolean zC = com.sigmob.sdk.manager.a.c();
                    if (zC) {
                        a.this.J += 1000;
                    }
                    SigmobLogger.d(am.f3151a, "interactionCompleted#run: foreground = " + zC + ", foregroundDuration = " + a.this.J, new Object[0]);
                }
            }, 2000L, 1000L);
        }

        private boolean a(SensorEvent event, int length) {
            return event == null || event.values == null || event.values.length < length;
        }

        private void d() {
            SigmobLogger.d(am.f3151a, "cancelTimer", new Object[0]);
            Timer timer = this.H;
            if (timer == null) {
                return;
            }
            timer.cancel();
            this.H = null;
        }

        private boolean e() {
            long j = this.J;
            boolean z = j == -1 || j >= ((long) this.c);
            boolean z2 = System.currentTimeMillis() - this.D >= 2000;
            boolean z3 = z && z2;
            SigmobLogger.d(am.f3151a, "overWidgetIntervalTime: type = " + this.v.name() + ", foregroundDuration = " + this.J + ", widgetIntervalTime = " + this.c + ", canProceedToJump = " + z + ", isIntervalMet = " + z2 + ", result = " + z3, new Object[0]);
            return z3;
        }

        public void a() {
            if (am.b != null) {
                am.b.b(this);
                am.b.a(this);
            }
            this.k = null;
        }

        public void a(int factor) {
            if (factor > 0) {
                this.C = factor;
            }
        }

        public void a(SensorEntity entity) {
            this.f3153a = entity == null ? 0 : entity.level;
            this.b = entity == null ? 0 : entity.shakeTriggerType;
            this.c = entity == null ? 0 : entity.widgetIntervalTime;
            this.d = entity != null ? entity.shakeTimeThreshold : 0;
        }

        public void b() {
            if (am.b != null) {
                am.b.b(this);
            }
            this.y = 0.0f;
            this.z = 0.0f;
            this.x = 0.0f;
            this.w = 0L;
            this.q = 0.0f;
            this.r = 0.0f;
            this.s = 0.0f;
            this.B = 0.0f;
            this.D = 0L;
            this.k = null;
        }

        public void b(int sensitivity_raw) {
            this.E = Integer.valueOf(sensitivity_raw);
        }

        public void c() {
            b();
            d();
            this.p = null;
        }

        public void c(int level) {
            this.f3153a = level;
        }

        public void d(int shakeTriggerType) {
            this.b = shakeTriggerType;
        }

        public void e(int widgetIntervalTime) {
            this.c = widgetIntervalTime;
        }

        public void f(int shakeTimeThreshold) {
            this.d = shakeTimeThreshold;
        }

        @Override // android.hardware.SensorEventListener
        public void onAccuracyChanged(Sensor sensor, int i) {
            SigmobLogger.d(am.f3151a, "onAccuracyChanged: sensor = " + sensor.toString() + ", i = " + i, new Object[0]);
        }

        /* JADX WARN: Code duplicated, block: B:117:0x02bd  */
        /* JADX WARN: Code duplicated, block: B:120:0x02f6  */
        /* JADX WARN: Code duplicated, block: B:122:0x0300  */
        /* JADX WARN: Code duplicated, block: B:125:0x0309  */
        /* JADX WARN: Code duplicated, block: B:149:0x03d3  */
        /* JADX WARN: Code duplicated, block: B:152:0x03e3  */
        /* JADX WARN: Code duplicated, block: B:155:0x03f3  */
        /* JADX WARN: Code duplicated, block: B:158:0x0406 A[RETURN] */
        /* JADX WARN: Code duplicated, block: B:159:0x0407  */
        /* JADX WARN: Code duplicated, block: B:162:0x040e  */
        /* JADX WARN: Code duplicated, block: B:165:0x041c  */
        /* JADX WARN: Code duplicated, block: B:167:0x0426  */
        /* JADX WARN: Code duplicated, block: B:170:0x042f  */
        /* JADX WARN: Code duplicated, block: B:179:? A[RETURN, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:181:? A[RETURN, SYNTHETIC] */
        @Override // android.hardware.SensorEventListener
        public void onSensorChanged(SensorEvent event) {
            int iIntValue;
            float fAbs;
            float f2;
            int iIntValue2;
            float fAbs2;
            float f3;
            float fIntValue;
            int type = event.sensor.getType();
            if (this.v == d.SHAKE && type == 10) {
                this.l = event;
                a(event, this.n);
                return;
            }
            if (this.v != d.SHAKE && type == 1) {
                this.l = event;
            } else if (type == 2) {
                this.m = event;
            } else if (type == 4) {
                this.n = event;
            }
            if (a(this.l, 3) || a(this.m, 3)) {
                com.sigmob.sdk.base.utils.k.e(am.f3151a, "onSensorChanged: Not enough sensor data (Accelerometer or Magnetic Field) to calculate rotation matrix for type: " + this.v.name(), new Object[0]);
                return;
            }
            SensorManager.getRotationMatrix(this.i, null, this.l.values, this.m.values);
            SensorManager.getOrientation(this.i, this.j);
            float degrees = (float) Math.toDegrees(this.j[0]);
            float degrees2 = (float) Math.toDegrees(this.j[1]);
            float degrees3 = (float) Math.toDegrees(this.j[2]);
            int i = AnonymousClass1.f3152a[this.v.ordinal()];
            if (i != 1) {
                if (i != 2) {
                    if (i == 3 && !com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(e()))) {
                        if (a(this.n, 3)) {
                            com.sigmob.sdk.base.utils.k.e(am.f3151a, "onSensorChanged: Gyroscope event not available for WRING type.", new Object[0]);
                            return;
                        }
                        float f4 = this.n.values[0];
                        float f5 = this.n.values[1];
                        float f6 = this.n.values[2];
                        if (Math.abs(f5) < 1.0f && !this.A) {
                            SigmobLog.d("wring reset");
                            this.w = 0L;
                            return;
                        }
                        Integer num = this.E;
                        if (num == null) {
                            int i2 = this.f3153a;
                            fIntValue = (i2 <= 0 || i2 > 10) ? 4.0f : f[i2];
                        } else {
                            fIntValue = num.intValue();
                        }
                        o = fIntValue;
                        boolean z = ((double) Math.abs(f5)) > 0.1d;
                        this.A = z;
                        if (this.w == 0 && z) {
                            this.w = System.currentTimeMillis();
                            SigmobLog.d("wring start");
                            c cVar = this.p;
                            if (cVar != null) {
                                cVar.a();
                                return;
                            }
                            return;
                        }
                        if (System.currentTimeMillis() - this.w < 200) {
                            return;
                        }
                        if (Math.abs(this.y) < Math.abs(degrees2)) {
                            this.y = degrees2;
                        }
                        if (Math.abs(this.z) < Math.abs(degrees)) {
                            this.z = degrees;
                        }
                        if (Math.abs(this.x) < Math.abs(degrees3)) {
                            this.x = degrees3;
                        }
                        if (this.w > 0) {
                            if (Math.abs(f4) > o || Math.abs(f5) > o || Math.abs(f6) > o) {
                                this.D = System.currentTimeMillis();
                                HashMap map = new HashMap();
                                map.put("turn_x", Integer.valueOf((int) this.y));
                                map.put("turn_y", Integer.valueOf((int) this.x));
                                map.put("turn_z", Integer.valueOf((int) this.z));
                                map.put("turn_time", Long.valueOf(this.D - this.w));
                                a(map);
                                this.w = 0L;
                                this.y = 0.0f;
                                this.z = 0.0f;
                                this.x = 0.0f;
                                this.A = false;
                                return;
                            }
                            return;
                        }
                        return;
                    }
                    return;
                }
                if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(e()))) {
                    return;
                }
                if (this.k == null) {
                    this.k = Float.valueOf(degrees3);
                    this.w = System.currentTimeMillis();
                    if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                        this.p.a();
                        return;
                    }
                    return;
                }
                if (a(this.n, 3)) {
                    com.sigmob.sdk.base.utils.k.e(am.f3151a, "onSensorChanged: Gyroscope event not available for SWING type.", new Object[0]);
                    return;
                }
                float f7 = this.n.values[0];
                float f8 = this.n.values[1];
                float f9 = this.n.values[2];
                if (Math.abs(this.q) < Math.abs(f7)) {
                    this.q = f7;
                }
                if (Math.abs(this.r) < Math.abs(f8)) {
                    this.r = f8;
                }
                if (Math.abs(this.s) < Math.abs(f9)) {
                    this.s = f9;
                }
                Integer num2 = this.E;
                if (num2 == null) {
                    int i3 = this.f3153a;
                    if (i3 <= 0 || i3 > 10) {
                        o = 25.0f;
                    } else {
                        iIntValue2 = e[i3];
                    }
                    fAbs2 = Math.abs(this.k.floatValue() - degrees3);
                    SigmobLogger.d(am.f3151a, "onSensorChanged: previousGyroscopeData = " + this.k + ", roll = " + degrees3, new Object[0]);
                    float f10 = o;
                    f3 = fAbs2 <= f10 ? fAbs2 / f10 : 1.0f;
                    SigmobLogger.d(am.f3151a, "onSensorChanged: offset = " + fAbs2 + ", sensitivity = " + o + ", value = " + f3, new Object[0]);
                    if (((int) (this.B * 100.0f)) != ((int) (f3 * 100.0f))) {
                        this.B = f3;
                        if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                            this.p.a(f3);
                        }
                    }
                    if (f3 > 0.98f) {
                        return;
                    }
                    SigmobLogger.d(am.f3151a, "onSensorChanged: type = " + this.v + ", offset = " + fAbs2 + ", sensitivity = " + o, new Object[0]);
                    this.D = System.currentTimeMillis();
                    HashMap map2 = new HashMap();
                    map2.put("x_max_acc", Float.valueOf(this.q * this.C));
                    map2.put("y_max_acc", Float.valueOf(this.r * this.C));
                    map2.put("z_max_acc", Float.valueOf(this.s * this.C));
                    a(map2);
                    this.q = 0.0f;
                    this.r = 0.0f;
                    this.s = 0.0f;
                } else {
                    iIntValue2 = num2.intValue();
                }
                o = iIntValue2;
                fAbs2 = Math.abs(this.k.floatValue() - degrees3);
                SigmobLogger.d(am.f3151a, "onSensorChanged: previousGyroscopeData = " + this.k + ", roll = " + degrees3, new Object[0]);
                float f11 = o;
                f3 = fAbs2 <= f11 ? fAbs2 / f11 : 1.0f;
                SigmobLogger.d(am.f3151a, "onSensorChanged: offset = " + fAbs2 + ", sensitivity = " + o + ", value = " + f3, new Object[0]);
                if (((int) (this.B * 100.0f)) != ((int) (f3 * 100.0f))) {
                    this.B = f3;
                    if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                        this.p.a(f3);
                    }
                }
                if (f3 > 0.98f) {
                    return;
                }
                SigmobLogger.d(am.f3151a, "onSensorChanged: type = " + this.v + ", offset = " + fAbs2 + ", sensitivity = " + o, new Object[0]);
                this.D = System.currentTimeMillis();
                HashMap map3 = new HashMap();
                map3.put("x_max_acc", Float.valueOf(this.q * this.C));
                map3.put("y_max_acc", Float.valueOf(this.r * this.C));
                map3.put("z_max_acc", Float.valueOf(this.s * this.C));
                a(map3);
                this.q = 0.0f;
                this.r = 0.0f;
                this.s = 0.0f;
            } else {
                if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(e()))) {
                    return;
                }
                if (this.k == null) {
                    this.k = Float.valueOf(degrees2);
                    this.w = System.currentTimeMillis();
                    if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                        this.p.a();
                        return;
                    }
                    return;
                }
                Integer num3 = this.E;
                if (num3 == null) {
                    int i4 = this.f3153a;
                    if (i4 <= 0 || i4 > 10) {
                        o = 25.0f;
                    } else {
                        iIntValue = e[i4];
                    }
                    if (Math.abs(this.y) < Math.abs(degrees2)) {
                        this.y = degrees2;
                    }
                    if (Math.abs(this.z) < Math.abs(degrees)) {
                        this.z = degrees;
                    }
                    if (Math.abs(this.x) < Math.abs(degrees3)) {
                        this.x = degrees3;
                    }
                    fAbs = Math.abs(this.k.floatValue() - degrees2);
                    if (fAbs < 5.0f) {
                        return;
                    }
                    float f12 = o;
                    f2 = fAbs <= f12 ? fAbs / f12 : 1.0f;
                    if (((int) (this.B * 100.0f)) != ((int) (f2 * 100.0f))) {
                        this.B = f2;
                        if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                            this.p.a(f2);
                        }
                    }
                    if (f2 > 0.98f) {
                        return;
                    }
                    SigmobLogger.d(am.f3151a, "onSensorChanged: type = " + this.v + ", offset = " + fAbs + ", sensitivity = " + o, new Object[0]);
                    HashMap map4 = new HashMap();
                    map4.put("turn_x", Integer.valueOf((int) this.y));
                    map4.put("turn_y", Integer.valueOf((int) this.x));
                    map4.put("turn_z", Integer.valueOf((int) this.z));
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    this.D = jCurrentTimeMillis;
                    map4.put("turn_time", Long.valueOf(jCurrentTimeMillis - this.w));
                    a(map4);
                    this.w = 0L;
                    this.y = 0.0f;
                    this.z = 0.0f;
                    this.x = 0.0f;
                } else {
                    iIntValue = num3.intValue();
                }
                o = iIntValue;
                if (Math.abs(this.y) < Math.abs(degrees2)) {
                    this.y = degrees2;
                }
                if (Math.abs(this.z) < Math.abs(degrees)) {
                    this.z = degrees;
                }
                if (Math.abs(this.x) < Math.abs(degrees3)) {
                    this.x = degrees3;
                }
                fAbs = Math.abs(this.k.floatValue() - degrees2);
                if (fAbs < 5.0f) {
                    return;
                }
                float f13 = o;
                f2 = fAbs <= f13 ? fAbs / f13 : 1.0f;
                if (((int) (this.B * 100.0f)) != ((int) (f2 * 100.0f))) {
                    this.B = f2;
                    if (com.sigmob.sdk.base.utils.v.b(this.p)) {
                        this.p.a(f2);
                    }
                }
                if (f2 > 0.98f) {
                    return;
                }
                SigmobLogger.d(am.f3151a, "onSensorChanged: type = " + this.v + ", offset = " + fAbs + ", sensitivity = " + o, new Object[0]);
                HashMap map5 = new HashMap();
                map5.put("turn_x", Integer.valueOf((int) this.y));
                map5.put("turn_y", Integer.valueOf((int) this.x));
                map5.put("turn_z", Integer.valueOf((int) this.z));
                long jCurrentTimeMillis2 = System.currentTimeMillis();
                this.D = jCurrentTimeMillis2;
                map5.put("turn_time", Long.valueOf(jCurrentTimeMillis2 - this.w));
                a(map5);
                this.w = 0L;
                this.y = 0.0f;
                this.z = 0.0f;
                this.x = 0.0f;
            }
            this.B = 0.0f;
            this.k = null;
        }
    }

    public static class b implements c {
        @Override // com.sigmob.sdk.base.common.am.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
        }

        @Override // com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
        }
    }

    public interface c {
        void a();

        void a(float progress);

        void a(Map<String, Number> info);
    }

    public enum d {
        SWING,
        WRING,
        SLOPE,
        SHAKE
    }
}
