package com.tencent.turingfd.sdk.ams.ad;

import android.os.Build;
import android.view.MotionEvent;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
public final class Bilberry {
    public static final Object j = new Object();
    public static int k;
    public static Bilberry l;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Bilberry f3825a;
    public String b;
    public int c;
    public int d;
    public int e;
    public float f;
    public float g;
    public long h;
    public int i = 0;

    public static Bilberry a(String str, MotionEvent motionEvent) {
        Bilberry bilberry;
        Object objInvoke;
        synchronized (j) {
            bilberry = l;
            objInvoke = null;
            if (bilberry == null) {
                bilberry = new Bilberry();
            } else {
                l = bilberry.f3825a;
                k--;
                bilberry.f3825a = null;
            }
        }
        bilberry.b = str;
        bilberry.c = motionEvent.getAction();
        bilberry.d = motionEvent.getDeviceId();
        bilberry.e = motionEvent.getToolType(0);
        bilberry.f = motionEvent.getPressure();
        bilberry.g = motionEvent.getSize();
        bilberry.h = System.currentTimeMillis();
        bilberry.i = 0;
        if (Build.VERSION.SDK_INT >= 30) {
            try {
                Method methodA = Filbert.a((Class) motionEvent.getClass(), "getId", (Class[]) null);
                if (methodA != null) {
                    objInvoke = methodA.invoke(motionEvent, null);
                }
            } catch (Throwable unused) {
            }
            if (objInvoke instanceof Integer) {
                bilberry.i = ((Integer) objInvoke).intValue();
            }
        }
        return bilberry;
    }
}
