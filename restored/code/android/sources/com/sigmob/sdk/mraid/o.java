package com.sigmob.sdk.mraid;

import android.content.Context;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.am;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class o extends n {
    protected am.a c;
    protected com.sigmob.sdk.mraid2.j d;

    protected o(String uniqueId) {
        super(uniqueId);
    }

    protected am.a a(Context context) {
        return new am.a(context, new am.c() { // from class: com.sigmob.sdk.mraid.o.1
            @Override // com.sigmob.sdk.base.common.am.c
            public void a() {
                if (o.this.d == null) {
                    return;
                }
                o.this.d.a(o.this.f3501a, "twist", "began", new HashMap<>());
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(float progress) {
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(Map<String, Number> info) {
                if (info == null || o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                Number number = info.get("turn_x");
                Number number2 = info.get("turn_y");
                Number number3 = info.get("turn_z");
                Number number4 = info.get("turn_time");
                map.put("x", String.valueOf(number));
                map.put("y", String.valueOf(number2));
                map.put("z", String.valueOf(number3));
                map.put("time", number4);
                o.this.d.a(o.this.f3501a, "twist", PointCategory.END, map);
            }
        }, am.d.WRING);
    }

    public abstract void a(float progress);

    public void a(int level) {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.c(level);
    }

    protected void a(Context context, int type) {
        am.a aVarB;
        if (type == 0) {
            aVarB = b(context);
        } else if (type == 1) {
            aVarB = a(context);
        } else if (type == 2) {
            aVarB = d(context);
        } else {
            if (type != 3) {
                SigmobLog.e("Motion type is not support.");
                return;
            }
            aVarB = c(context);
        }
        this.c = aVarB;
    }

    protected void a(Context context, String type) {
        am.a aVarB;
        type.hashCode();
        switch (type) {
            case "shake":
                aVarB = b(context);
                break;
            case "slope":
                aVarB = d(context);
                break;
            case "swing":
                aVarB = c(context);
                break;
            case "twist":
                aVarB = a(context);
                break;
            default:
                SigmobLog.e("Motion type is not support.");
                return;
        }
        this.c = aVarB;
    }

    public void a(com.sigmob.sdk.mraid2.j motionListener) {
        this.d = motionListener;
    }

    protected am.a b(Context context) {
        am.a aVar = new am.a(context, new am.c() { // from class: com.sigmob.sdk.mraid.o.2
            @Override // com.sigmob.sdk.base.common.am.c
            public void a() {
                if (o.this.d == null) {
                    return;
                }
                o.this.d.a(o.this.f3501a, "shake", "began", new HashMap<>());
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(float progress) {
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(Map<String, Number> info) {
                if (info == null || o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                Number number = info.get("x_max_acc");
                Number number2 = info.get("y_max_acc");
                Number number3 = info.get("z_max_acc");
                map.put("x", String.valueOf(number));
                map.put("y", String.valueOf(number2));
                map.put("z", String.valueOf(number3));
                o.this.d.a(o.this.f3501a, "shake", PointCategory.END, map);
            }
        }, am.d.SHAKE);
        aVar.a(1);
        return aVar;
    }

    public abstract void b(float progress);

    public void b(int sensitivityRaw) {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.b(sensitivityRaw);
    }

    protected am.a c(Context context) {
        am.a aVar = new am.a(context, new am.c() { // from class: com.sigmob.sdk.mraid.o.3
            @Override // com.sigmob.sdk.base.common.am.c
            public void a() {
                if (o.this.d == null) {
                    return;
                }
                o.this.d.a(o.this.f3501a, "swing", "began", new HashMap<>());
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(float progress) {
                o.this.a(progress);
                if (o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                map.put("progress", Integer.valueOf((int) (progress * 100.0f)));
                o.this.d.a(o.this.f3501a, "swing", "progress", map);
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(Map<String, Number> info) {
                if (info == null || o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                Number number = info.get("x_max_acc");
                Number number2 = info.get("y_max_acc");
                Number number3 = info.get("z_max_acc");
                map.put("x", String.valueOf(number));
                map.put("y", String.valueOf(number2));
                map.put("z", String.valueOf(number3));
                o.this.d.a(o.this.f3501a, "swing", PointCategory.END, map);
            }
        }, am.d.SWING);
        aVar.a(1);
        return aVar;
    }

    public void c(int shakeTriggerType) {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.d(shakeTriggerType);
    }

    protected am.a d(Context context) {
        am.a aVar = new am.a(context, new am.c() { // from class: com.sigmob.sdk.mraid.o.4
            @Override // com.sigmob.sdk.base.common.am.c
            public void a() {
                if (o.this.d == null) {
                    return;
                }
                o.this.d.a(o.this.f3501a, "slope", "began", new HashMap<>());
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(float progress) {
                o.this.b(progress);
                if (o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                map.put("progress", Integer.valueOf((int) (progress * 100.0f)));
                o.this.d.a(o.this.f3501a, "slope", "progress", map);
            }

            @Override // com.sigmob.sdk.base.common.am.c
            public void a(Map<String, Number> info) {
                if (info == null || o.this.d == null) {
                    return;
                }
                HashMap<String, Object> map = new HashMap<>();
                Number number = info.get("turn_x");
                Number number2 = info.get("turn_y");
                Number number3 = info.get("turn_z");
                Number number4 = info.get("turn_time");
                map.put("x", String.valueOf(number));
                map.put("y", String.valueOf(number2));
                map.put("z", String.valueOf(number3));
                map.put("time", number4);
                o.this.d.a(o.this.f3501a, "slope", PointCategory.END, map);
            }
        }, am.d.SLOPE);
        aVar.a(1);
        return aVar;
    }

    public void d() {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.a();
    }

    public void d(int widgetIntervalTime) {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.e(widgetIntervalTime);
    }

    public void e(int shakeTimeThreshold) {
        am.a aVar = this.c;
        if (aVar == null) {
            return;
        }
        aVar.f(shakeTimeThreshold);
    }
}
