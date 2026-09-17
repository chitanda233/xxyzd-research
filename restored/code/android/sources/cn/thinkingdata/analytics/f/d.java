package cn.thinkingdata.analytics.f;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
public class d {
    private static final Object b = new Object();
    private static final Object c = new Object();
    private static d d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final e f107a;

    private d(Context context) {
        this.f107a = new e(context);
    }

    public static d a(Context context) {
        if (d == null) {
            synchronized (d.class) {
                if (d == null) {
                    d = new d(context);
                }
            }
        }
        return d;
    }

    public void a() {
        synchronized (c) {
            this.f107a.save(5, null);
        }
    }

    public void a(Long l) {
        this.f107a.save(4, l);
    }

    public Long b() {
        return (Long) this.f107a.get(4);
    }

    public String c() {
        String str;
        synchronized (c) {
            str = (String) this.f107a.get(5);
        }
        return str;
    }

    public String d() {
        String str;
        synchronized (b) {
            str = (String) this.f107a.get(9);
        }
        return str;
    }
}
