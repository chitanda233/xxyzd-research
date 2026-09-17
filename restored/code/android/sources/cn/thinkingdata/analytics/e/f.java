package cn.thinkingdata.analytics.e;

import android.content.Context;
import android.content.res.Resources;
import cn.thinkingdata.analytics.TDPresetProperties;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class f {
    private static final Map<Context, f> d = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f98a;
    private int b;
    private int c;

    private f(Context context) {
        this.b = 10;
        this.c = 10000;
        Resources resources = context.getResources();
        String packageName = context.getPackageName();
        try {
            this.f98a = packageName;
            this.f98a = resources.getString(resources.getIdentifier("TADeFaultMainProcessName", "string", packageName));
        } catch (Exception unused) {
        }
        try {
            this.b = resources.getInteger(resources.getIdentifier("TARetentionDays", "integer", packageName));
        } catch (Exception unused2) {
        }
        try {
            this.c = resources.getInteger(resources.getIdentifier("TADatabaseLimit", "integer", packageName));
        } catch (Exception unused3) {
        }
        TDPresetProperties.initDisableList(context);
    }

    public static f a(Context context) {
        f fVar;
        Map<Context, f> map = d;
        synchronized (map) {
            fVar = map.get(context);
            if (fVar == null) {
                fVar = new f(context);
                map.put(context, fVar);
            }
        }
        return fVar;
    }

    public long a() {
        int i = this.b;
        if (i > 10 || i < 0) {
            i = 10;
        }
        return 86400000 * ((long) i);
    }

    public String b() {
        return this.f98a;
    }

    public int c() {
        return Math.max(this.c, 5000);
    }
}
