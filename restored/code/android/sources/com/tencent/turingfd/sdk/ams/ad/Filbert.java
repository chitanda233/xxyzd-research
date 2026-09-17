package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Filbert {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final ConcurrentHashMap f3848a = new ConcurrentHashMap();
    public static final ConcurrentHashMap b = new ConcurrentHashMap();
    public static final ConcurrentHashMap c = new ConcurrentHashMap();
    public static final Object d = new Object();

    public static Object a(String str, String str2) {
        Class<?> cls;
        try {
            ConcurrentHashMap concurrentHashMap = f3848a;
            cls = (Class) concurrentHashMap.get(str);
            if (cls == null) {
                cls = Class.forName(str);
                Class<?> cls2 = (Class) concurrentHashMap.putIfAbsent(str, cls);
                if (cls2 != null) {
                    cls = cls2;
                }
            }
        } catch (Throwable unused) {
            cls = null;
        }
        try {
            return a(cls, str2, (Object) null);
        } catch (Throwable unused2) {
            return null;
        }
    }

    public static Field a(Class cls, String str) {
        if (cls == null) {
            return null;
        }
        ConcurrentHashMap concurrentHashMap = b;
        ConcurrentHashMap concurrentHashMap2 = (ConcurrentHashMap) concurrentHashMap.get(cls);
        if (concurrentHashMap2 == null) {
            concurrentHashMap.putIfAbsent(cls, new ConcurrentHashMap());
            concurrentHashMap2 = (ConcurrentHashMap) concurrentHashMap.get(cls);
            if (concurrentHashMap2 == null) {
                return null;
            }
        }
        Wild wild = (Wild) concurrentHashMap2.get(str);
        if (wild != null) {
            Object objA = wild.a();
            if (objA instanceof Field) {
                return (Field) objA;
            }
            if (objA != null) {
                return null;
            }
        } else {
            concurrentHashMap2.putIfAbsent(str, new Wild());
            wild = (Wild) concurrentHashMap2.get(str);
            if (wild == null) {
                return null;
            }
        }
        try {
            Field declaredField = cls.getDeclaredField(str);
            declaredField.setAccessible(true);
            wild.a(declaredField, -1L);
            return declaredField;
        } catch (Throwable unused) {
            wild.a(d, 60000L);
            return null;
        }
    }

    public static Method a(Class cls, String str, Class... clsArr) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        ConcurrentHashMap concurrentHashMap = c;
        ConcurrentHashMap concurrentHashMap2 = (ConcurrentHashMap) concurrentHashMap.get(cls);
        if (concurrentHashMap2 == null) {
            concurrentHashMap.putIfAbsent(cls, new ConcurrentHashMap());
            concurrentHashMap2 = (ConcurrentHashMap) concurrentHashMap.get(cls);
            if (concurrentHashMap2 == null) {
                return null;
            }
        }
        StringBuilder sb = new StringBuilder(str);
        if (clsArr != null) {
            for (Class cls2 : clsArr) {
                sb.append("+");
                sb.append(cls2.getName());
            }
        }
        String string = sb.toString();
        Wild wild = (Wild) concurrentHashMap2.get(string);
        if (wild != null) {
            Object objA = wild.a();
            if (objA instanceof Method) {
                return (Method) objA;
            }
            if (objA != null) {
                return null;
            }
        } else {
            concurrentHashMap2.putIfAbsent(string, new Wild());
            wild = (Wild) concurrentHashMap2.get(string);
            if (wild == null) {
                return null;
            }
        }
        try {
            Method declaredMethod = cls.getDeclaredMethod(str, clsArr);
            declaredMethod.setAccessible(true);
            wild.a(declaredMethod, -1L);
            return declaredMethod;
        } catch (Throwable unused) {
            wild.a(d, 60000L);
            return null;
        }
    }

    public static Object a(Class cls, String str, Object obj) {
        try {
            Field fieldA = a(cls, str);
            if (fieldA == null) {
                return null;
            }
            return fieldA.get(obj);
        } catch (Throwable unused) {
            return null;
        }
    }
}
