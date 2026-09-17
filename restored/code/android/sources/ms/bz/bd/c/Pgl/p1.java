package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes4.dex */
public final class p1 implements SensorEventListener {
    private static volatile p1 c;
    private SensorManager tt;
    private int ve;
    private int uj = 0;
    private float[] n = new float[3];

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ArrayList f4087a = new ArrayList();

    static {
        new DecimalFormat((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "798ae3", new byte[]{118, 117, 27}));
        c = null;
    }

    private p1(Context context) {
        this.tt = null;
        Context applicationContext = context.getApplicationContext();
        if (applicationContext != null) {
            this.tt = (SensorManager) applicationContext.getSystemService((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "e754d9", new byte[]{com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.H, 72, com.sigmob.sdk.archives.tar.e.Q, 84, 60}));
        }
    }

    public static p1 c(Context context) {
        if (c == null) {
            synchronized (p1.class) {
                if (c == null) {
                    c = new p1(context);
                }
            }
        }
        return c;
    }

    private synchronized void n() {
        try {
            SensorManager sensorManager = this.tt;
            if (sensorManager != null) {
                int i = this.ve - 1;
                this.ve = i;
                if (i == 0) {
                    sensorManager.unregisterListener(this);
                }
            }
        } catch (Exception unused) {
            com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "802a38", new byte[]{58, 33, 66, 42, 25});
        }
    }

    private synchronized void uj() {
        try {
            SensorManager sensorManager = this.tt;
            if (sensorManager != null) {
                if (this.ve == 0) {
                    if (!this.tt.registerListener(this, sensorManager.getDefaultSensor(1), 3)) {
                        return;
                    }
                }
                this.ve++;
            }
        } catch (Exception unused) {
        }
    }

    public final JSONArray c() {
        byte b;
        JSONArray jSONArray;
        BigDecimal bigDecimal;
        try {
            b = pble.c() != null ? (byte) 1 : (byte) 0;
        } catch (Throwable unused) {
            b = -1;
        }
        if (b != 1) {
            return null;
        }
        uj();
        try {
            try {
                synchronized (this) {
                    int i = 0;
                    while (this.uj == 0 && i < 10) {
                        i++;
                        wait(1000L);
                    }
                }
                jSONArray = new JSONArray();
                jSONArray.put(new BigDecimal(this.n[0]).setScale(2, 4));
                jSONArray.put(new BigDecimal(this.n[1]).setScale(2, 4));
                bigDecimal = new BigDecimal(this.n[2]);
            } catch (Exception unused2) {
                com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "367a0c", new byte[]{com.sigmob.sdk.archives.tar.e.I, 39, 71, 42, 8});
                jSONArray = new JSONArray();
                jSONArray.put(new BigDecimal(this.n[0]).setScale(2, 4));
                jSONArray.put(new BigDecimal(this.n[1]).setScale(2, 4));
                bigDecimal = new BigDecimal(this.n[2]);
            }
            jSONArray.put(bigDecimal.setScale(2, 4));
            n();
            this.uj = 0;
            return jSONArray;
        } catch (Throwable th) {
            JSONArray jSONArray2 = new JSONArray();
            jSONArray2.put(new BigDecimal(this.n[0]).setScale(2, 4));
            jSONArray2.put(new BigDecimal(this.n[1]).setScale(2, 4));
            jSONArray2.put(new BigDecimal(this.n[2]).setScale(2, 4));
            n();
            this.uj = 0;
            throw th;
        }
    }

    @Override // android.hardware.SensorEventListener
    public final void onAccuracyChanged(Sensor sensor, int i) {
    }

    @Override // android.hardware.SensorEventListener
    public final void onSensorChanged(SensorEvent sensorEvent) {
        this.n = sensorEvent.values;
        this.uj = 1;
    }

    public final synchronized void tt() {
        JSONArray jSONArrayC = c();
        if (jSONArrayC == null) {
            return;
        }
        this.f4087a.add(jSONArrayC);
        try {
            int size = this.f4087a.size();
            if (size > 100) {
                ArrayList arrayList = new ArrayList(this.f4087a.subList(size - 50, size));
                this.f4087a.clear();
                this.f4087a = arrayList;
            }
        } catch (Throwable unused) {
        }
    }

    public final synchronized String ve() {
        StringBuilder sb = new StringBuilder();
        int size = this.f4087a.size();
        if (size <= 0) {
            return null;
        }
        try {
            ArrayList arrayList = this.f4087a;
            int i = size - 50;
            if (i <= 0) {
                i = 0;
            }
            List<JSONArray> listSubList = arrayList.subList(i, size);
            if (listSubList.size() > 0) {
                for (JSONArray jSONArray : listSubList) {
                    if (jSONArray != null) {
                        sb.append(jSONArray.get(0).toString());
                        sb.append((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "85f56d", new byte[]{101}));
                        sb.append(jSONArray.get(1).toString());
                        sb.append((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "142404", new byte[]{108}));
                        sb.append(jSONArray.get(2).toString());
                        sb.append((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "8435e7", new byte[]{com.sigmob.sdk.archives.tar.e.M}));
                    }
                }
            }
            if (sb.length() > 0) {
                sb.delete(sb.length() - 1, sb.length());
            }
        } catch (Throwable unused) {
        }
        return sb.toString();
    }
}
