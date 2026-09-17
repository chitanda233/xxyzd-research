package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.util.Log;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.TreeMap;
import java.util.concurrent.Callable;
import java.util.concurrent.FutureTask;

/* JADX INFO: loaded from: classes4.dex */
public final class Hickory implements Callable {
    public static final HashMap d = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3856a;
    public final Map b;
    public final boolean c;

    public Hickory(Map map, boolean z) {
        this.b = map;
        this.c = z;
        if (map == null || map.isEmpty()) {
            this.f3856a = "";
            return;
        }
        TreeMap treeMap = new TreeMap(new Herbaceous());
        treeMap.putAll(map);
        Iterator it = treeMap.keySet().iterator();
        StringBuilder sb = new StringBuilder();
        while (it.hasNext()) {
            sb.append((String) treeMap.get((Integer) it.next()));
        }
        this.f3856a = sb.toString();
    }

    public final FutureTask a() {
        FutureTask futureTask;
        HashMap map = d;
        synchronized (map) {
            Iterator it = map.entrySet().iterator();
            while (it.hasNext()) {
                if (((FutureTask) ((Map.Entry) it.next()).getValue()).isDone()) {
                    it.remove();
                }
            }
            HashMap map2 = d;
            futureTask = (FutureTask) map2.get(this.f3856a);
            if (futureTask == null || futureTask.isDone()) {
                futureTask = new FutureTask(this);
                Ara.f3820a.submit(futureTask);
                map2.put(this.f3856a, futureTask);
            }
        }
        return futureTask;
    }

    @Override // java.util.concurrent.Callable
    public final Object call() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        Haw haw = new Haw();
        try {
            s sVar = s.h;
            sVar.getClass();
            if (!q.f.d()) {
                try {
                    System.currentTimeMillis();
                    sVar.a(context);
                    System.currentTimeMillis();
                    sVar.b();
                } catch (Throwable unused) {
                }
            }
            haw.b = 0;
            haw.e = System.currentTimeMillis();
            byte[] bArrA = Kiwifruit.a(context, this.b, haw, this.c);
            haw.f = System.currentTimeMillis();
            haw.c = bArrA.length;
            Lichee licheeA = Kiwifruit.a(bArrA, haw);
            Kiwifruit.a(context, licheeA);
            Kiwifruit.a(context, haw);
            return licheeA;
        } catch (Throwable th) {
            Log.w("TuringFdJava", th);
            return new Lichee(-10015);
        }
    }
}
