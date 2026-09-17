package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import android.view.accessibility.AccessibilityEvent;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.try, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Ctry implements InvocationHandler {
    public static final String b = Cinstanceof.a(Cinstanceof.e1);

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AtomicReference f3967a = new AtomicReference();

    @Override // java.lang.reflect.InvocationHandler
    public final Object invoke(Object obj, Method method, Object[] objArr) throws Throwable {
        int i;
        String str = b;
        if (!TextUtils.isEmpty(str) && str.equals(method.getName()) && Void.TYPE.equals(method.getReturnType()) && objArr != null && objArr.length > 0) {
            Object obj2 = objArr[0];
            if (obj2 instanceof AccessibilityEvent) {
                AccessibilityEvent accessibilityEvent = (AccessibilityEvent) obj2;
                int eventType = accessibilityEvent.getEventType();
                if (eventType == 0) {
                    AtomicInteger atomicInteger = Cassiopeia.f3834a;
                } else {
                    AtomicInteger atomicInteger2 = Cassiopeia.f3834a;
                    synchronized (atomicInteger2) {
                        i = atomicInteger2.get();
                    }
                    if ((eventType & i) != 0) {
                        Cassiopeia.a(accessibilityEvent);
                        return null;
                    }
                }
                Cassiopeia.b(accessibilityEvent);
            }
        }
        Object obj3 = this.f3967a.get();
        if (obj3 == null) {
            return null;
        }
        try {
            return method.invoke(obj3, objArr);
        } catch (InvocationTargetException e) {
            Throwable cause = e.getCause();
            if (cause != null) {
                throw cause;
            }
            throw e;
        }
    }
}
