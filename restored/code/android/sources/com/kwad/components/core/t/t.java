package com.kwad.components.core.t;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.sdk.internal.api.SceneImpl;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class t {
    public static final String TAG = "t";
    private static final String alU = "com.kwad.components.core.t.t";
    private static volatile t alV;
    private boolean alW = false;
    private com.kwad.sdk.core.config.item.r.a alX;

    private t() {
    }

    public static t xg() {
        if (alV == null) {
            synchronized (t.class) {
                if (alV == null) {
                    alV = new t();
                }
            }
        }
        return alV;
    }

    public final void init() {
        com.kwad.sdk.core.config.item.r.a aVar = (com.kwad.sdk.core.config.item.r.a) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aNS);
        this.alX = aVar;
        if (aVar != null) {
            xi();
        }
    }

    public final boolean b(SceneImpl sceneImpl, String str) {
        boolean zA = this.alW ? a(this.alX.aRi, this.alX.aRj) : false;
        com.kwad.components.core.p.a.vX().a(sceneImpl, zA, str);
        return zA;
    }

    public final int xh() {
        com.kwad.sdk.core.config.item.r.a aVar = this.alX;
        if (aVar != null) {
            return aVar.aRl;
        }
        return 0;
    }

    private void xi() {
        com.kwad.sdk.core.config.item.r.a aVar = this.alX;
        if (aVar == null) {
            return;
        }
        if (!this.alW && aVar.aRk.size() > 0) {
            Iterator<String> it = this.alX.aRk.iterator();
            while (it.hasNext()) {
                boolean zBm = bm(it.next());
                this.alW = zBm;
                if (zBm) {
                    break;
                }
            }
        }
        if (this.alW) {
            ArrayList arrayList = new ArrayList();
            if (this.alX.aRh.size() > 0) {
                for (Map.Entry<Integer, String> entry : this.alX.aRh.entrySet()) {
                    if (bm(entry.getValue())) {
                        arrayList.add(entry.getKey());
                    }
                }
            }
            com.kwad.components.core.p.a.vX().a(a(this.alX.aRi, this.alX.aRj), arrayList);
        }
    }

    private boolean a(List<String> list, List<String> list2) {
        if (list == null || list.size() <= 0) {
            return false;
        }
        StackTraceElement[] stackTrace = Thread.currentThread().getStackTrace();
        for (StackTraceElement stackTraceElement : stackTrace) {
            String className = stackTraceElement.getClassName();
            if (className != null) {
                Iterator<String> it = list.iterator();
                while (it.hasNext()) {
                    if (className.contains(it.next())) {
                        return true;
                    }
                }
            }
        }
        com.kwad.sdk.m.b.TM().c(stackTrace);
        return a(list2, stackTrace);
    }

    private boolean a(List<String> list, StackTraceElement[] stackTraceElementArr) {
        if (list != null && !list.isEmpty()) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            com.kwad.sdk.core.d.c.d(TAG, "checkBySuper begin:" + jElapsedRealtime);
            for (StackTraceElement stackTraceElement : stackTraceElementArr) {
                String className = stackTraceElement.getClassName();
                if (className != null && bk(className) && bl(className)) {
                    try {
                        if (a(list, Class.forName(className).getSuperclass())) {
                            R(jElapsedRealtime);
                            return true;
                        }
                    } catch (Throwable unused) {
                    }
                    try {
                        if (className.contains("$") && a(list, Class.forName(className.substring(0, className.lastIndexOf("$"))).getSuperclass())) {
                            R(jElapsedRealtime);
                            return true;
                        }
                    } catch (Throwable unused2) {
                        continue;
                    }
                }
            }
            R(jElapsedRealtime);
        }
        return false;
    }

    private static void R(long j) {
        com.kwad.sdk.core.d.c.d(TAG, "checkBySuper end:" + (SystemClock.elapsedRealtime() - j));
    }

    private static boolean a(List<String> list, Class cls) {
        int i = 0;
        while (cls != null && !TextUtils.equals(cls.getName(), "java.lang.Object")) {
            Iterator<String> it = list.iterator();
            while (it.hasNext()) {
                if (cls.getName().contains(it.next())) {
                    return true;
                }
            }
            cls = cls.getSuperclass();
            i++;
            if (i >= 4) {
                break;
            }
        }
        return false;
    }

    private static boolean bk(String str) {
        return (str.startsWith("android") || str.startsWith("java") || str.startsWith("dalvik") || str.startsWith("com.android") || str.contains(alU) || !str.startsWith("androidx")) ? false : true;
    }

    private static boolean bl(String str) {
        return !str.startsWith("com.kwad");
    }

    private static boolean bm(String str) {
        if (TextUtils.isEmpty(str)) {
            return false;
        }
        try {
            return Class.forName(str) != null;
        } catch (Throwable unused) {
        }
    }
}
