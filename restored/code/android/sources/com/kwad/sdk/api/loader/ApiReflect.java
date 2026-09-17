package com.kwad.sdk.api.loader;

import cn.thinkingdata.core.router.TRouterMap;
import java.lang.reflect.AccessibleObject;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.Member;
import java.lang.reflect.Method;
import java.lang.reflect.Modifier;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public final class ApiReflect {
    private final Class<?> aHI;
    private final Object aHJ;

    public static class ReflectException extends RuntimeException {
        private static final long serialVersionUID = -6213149635297151442L;

        public ReflectException(String str) {
            super(str);
        }

        public ReflectException(String str, Throwable th) {
            super(str, th);
        }

        public ReflectException() {
        }

        public ReflectException(Throwable th) {
            super(th);
        }
    }

    static class a {
        private static final Method aHK;
        private static final Method aHL;
        private static final Method aHM;
        private static final Method aHN;
        private static final Method aHO;
        private static final Method aHP;
        private static final Method aHQ;
        private static final Method aHR;
        private static final Method aHS;
        private static final Method aHT;
        private static final Method aHU;
        private static final Method aHV;
        private static final Method aHW;
        private static final Method aHX;

        static {
            try {
                aHK = Class.class.getDeclaredMethod("forName", String.class);
                aHL = Class.class.getDeclaredMethod("forName", String.class, Boolean.TYPE, ClassLoader.class);
                aHM = Class.class.getDeclaredMethod("getDeclaredField", String.class);
                aHN = Class.class.getDeclaredMethod("getDeclaredFields", new Class[0]);
                aHO = Class.class.getDeclaredMethod("getDeclaredMethod", String.class, Class[].class);
                aHP = Class.class.getDeclaredMethod("getDeclaredMethods", new Class[0]);
                aHQ = Class.class.getDeclaredMethod("getDeclaredConstructor", Class[].class);
                aHR = Class.class.getDeclaredMethod("getDeclaredConstructors", new Class[0]);
                aHS = Class.class.getDeclaredMethod("getField", String.class);
                aHT = Class.class.getDeclaredMethod("getFields", new Class[0]);
                aHU = Class.class.getDeclaredMethod("getMethod", String.class, Class[].class);
                aHV = Class.class.getDeclaredMethod("getMethods", new Class[0]);
                aHW = Class.class.getDeclaredMethod("getConstructor", Class[].class);
                aHX = Class.class.getDeclaredMethod("getConstructors", new Class[0]);
            } catch (NoSuchMethodException e) {
                throw new ReflectException(e);
            }
        }

        static Class forName(String str) throws ClassNotFoundException {
            try {
                return (Class) aHK.invoke(null, str);
            } catch (Exception e) {
                ClassNotFoundException classNotFoundException = new ClassNotFoundException();
                classNotFoundException.initCause(e);
                throw classNotFoundException;
            }
        }

        static Field a(Class cls, String str) throws NoSuchFieldException {
            try {
                return (Field) aHM.invoke(cls, str);
            } catch (Exception e) {
                NoSuchFieldException noSuchFieldException = new NoSuchFieldException();
                noSuchFieldException.initCause(e);
                throw noSuchFieldException;
            }
        }

        static Field b(Class cls, String str) throws NoSuchFieldException {
            try {
                return (Field) aHS.invoke(cls, str);
            } catch (Exception e) {
                NoSuchFieldException noSuchFieldException = new NoSuchFieldException();
                noSuchFieldException.initCause(e);
                throw noSuchFieldException;
            }
        }

        static Method c(Class cls, String str, Class<?>... clsArr) throws NoSuchMethodException {
            try {
                return (Method) aHO.invoke(cls, str, clsArr);
            } catch (Exception e) {
                NoSuchMethodException noSuchMethodException = new NoSuchMethodException();
                noSuchMethodException.initCause(e);
                throw noSuchMethodException;
            }
        }

        static Method d(Class cls, String str, Class<?>... clsArr) throws NoSuchMethodException {
            try {
                return (Method) aHU.invoke(cls, str, clsArr);
            } catch (Exception e) {
                NoSuchMethodException noSuchMethodException = new NoSuchMethodException();
                noSuchMethodException.initCause(e);
                throw noSuchMethodException;
            }
        }

        static Method[] c(Class cls) {
            try {
                return (Method[]) aHP.invoke(cls, new Object[0]);
            } catch (Exception e) {
                throw new ReflectException(e);
            }
        }

        static Method[] d(Class cls) {
            try {
                return (Method[]) aHV.invoke(cls, new Object[0]);
            } catch (Exception e) {
                throw new ReflectException(e);
            }
        }

        static Constructor a(Class cls, Class<?>... clsArr) throws NoSuchMethodException {
            try {
                return (Constructor) aHQ.invoke(cls, clsArr);
            } catch (Exception e) {
                NoSuchMethodException noSuchMethodException = new NoSuchMethodException();
                noSuchMethodException.initCause(e);
                throw noSuchMethodException;
            }
        }

        static Constructor[] e(Class cls) {
            try {
                return (Constructor[]) aHR.invoke(cls, new Object[0]);
            } catch (Exception e) {
                throw new ReflectException(e);
            }
        }
    }

    public static ApiReflect cU(String str) {
        return a(forName(str));
    }

    public static ApiReflect a(Class<?> cls) {
        return new ApiReflect(cls);
    }

    public static ApiReflect k(Object obj) {
        return new ApiReflect(obj == null ? Object.class : obj.getClass(), obj);
    }

    private static ApiReflect a(Class<?> cls, Object obj) {
        return new ApiReflect(cls, obj);
    }

    private static <T extends AccessibleObject> T a(T t) {
        if (t == null) {
            return null;
        }
        if (t instanceof Member) {
            Member member = (Member) t;
            if (Modifier.isPublic(member.getModifiers()) && Modifier.isPublic(member.getDeclaringClass().getModifiers())) {
                return t;
            }
        }
        if (!t.isAccessible()) {
            t.setAccessible(true);
        }
        return t;
    }

    private ApiReflect(Class<?> cls) {
        this(cls, cls);
    }

    private ApiReflect(Class<?> cls, Object obj) {
        this.aHI = cls;
        this.aHJ = obj;
    }

    public final <T> T get() {
        return (T) this.aHJ;
    }

    public final ApiReflect b(String str, Object obj) {
        try {
            Field fieldCW = cW(str);
            if ((fieldCW.getModifiers() & 16) == 16) {
                try {
                    Field fieldA = a.a(Field.class, "modifiers");
                    fieldA.setAccessible(true);
                    fieldA.setInt(fieldCW, fieldCW.getModifiers() & (-17));
                } catch (NoSuchFieldException unused) {
                }
            }
            fieldCW.set(this.aHJ, l(obj));
            return this;
        } catch (Exception e) {
            throw new ReflectException(e);
        }
    }

    public final <T> T get(String str) {
        return (T) cV(str).get();
    }

    private ApiReflect cV(String str) {
        try {
            Field fieldCW = cW(str);
            return a(fieldCW.getType(), fieldCW.get(this.aHJ));
        } catch (Exception e) {
            throw new ReflectException(e);
        }
    }

    private Field cW(String str) {
        Class<?> clsType = type();
        try {
            return (Field) a(a.b(clsType, str));
        } catch (NoSuchFieldException e) {
            do {
                try {
                    return (Field) a(a.a(clsType, str));
                } catch (NoSuchFieldException unused) {
                    clsType = clsType.getSuperclass();
                    if (clsType == null) {
                        throw new ReflectException(e);
                    }
                }
            } while (clsType == null);
            throw new ReflectException(e);
        }
    }

    public final ApiReflect cX(String str) {
        return h(str, new Object[0]);
    }

    private ApiReflect h(String str, Object... objArr) {
        return a(str, c(objArr), objArr);
    }

    public final ApiReflect a(String str, Class<?>[] clsArr, Object... objArr) {
        try {
            try {
                return a(a(str, clsArr), this.aHJ, objArr);
            } catch (NoSuchMethodException unused) {
                return a(b(str, clsArr), this.aHJ, objArr);
            }
        } catch (NoSuchMethodException e) {
            throw new ReflectException(e);
        }
    }

    private Method a(String str, Class<?>[] clsArr) throws NoSuchMethodException {
        Class<?> clsType = type();
        try {
            return a.d(clsType, str, clsArr);
        } catch (NoSuchMethodException unused) {
            do {
                try {
                    return a.c(clsType, str, clsArr);
                } catch (NoSuchMethodException unused2) {
                    clsType = clsType.getSuperclass();
                }
            } while (clsType != null);
            throw new NoSuchMethodException();
        }
    }

    private Method b(String str, Class<?>[] clsArr) throws NoSuchMethodException {
        Class<?> clsType = type();
        for (Method method : a.d(clsType)) {
            if (a(method, str, clsArr)) {
                return method;
            }
        }
        do {
            for (Method method2 : a.c(clsType)) {
                if (a(method2, str, clsArr)) {
                    return method2;
                }
            }
            clsType = clsType.getSuperclass();
        } while (clsType != null);
        throw new NoSuchMethodException("No similar method " + str + " with params " + Arrays.toString(clsArr) + " could be found on type " + type() + TRouterMap.DOT);
    }

    private boolean a(Method method, String str, Class<?>[] clsArr) {
        return method.getName().equals(str) && a(method.getParameterTypes(), clsArr);
    }

    public final ApiReflect HO() {
        return b(new Object[0]);
    }

    private ApiReflect b(Object... objArr) {
        return a(c(objArr), objArr);
    }

    public final ApiReflect a(Class<?>[] clsArr, Object... objArr) {
        try {
            return a((Constructor<?>) a.a(type(), clsArr), objArr);
        } catch (NoSuchMethodException e) {
            for (Constructor constructor : a.e(type())) {
                if (a(constructor.getParameterTypes(), clsArr)) {
                    return a((Constructor<?>) constructor, objArr);
                }
            }
            throw new ReflectException(e);
        }
    }

    private static boolean a(Class<?>[] clsArr, Class<?>[] clsArr2) {
        if (clsArr.length != clsArr2.length) {
            return false;
        }
        for (int i = 0; i < clsArr2.length; i++) {
            if (clsArr2[i] != b.class && !b(clsArr[i]).isAssignableFrom(b(clsArr2[i]))) {
                return false;
            }
        }
        return true;
    }

    public final int hashCode() {
        return this.aHJ.hashCode();
    }

    public final boolean equals(Object obj) {
        if (obj instanceof ApiReflect) {
            return this.aHJ.equals(((ApiReflect) obj).get());
        }
        return false;
    }

    public final String toString() {
        return String.valueOf(this.aHJ);
    }

    private static ApiReflect a(Constructor<?> constructor, Object... objArr) {
        try {
            return a(constructor.getDeclaringClass(), ((Constructor) a(constructor)).newInstance(objArr));
        } catch (Exception e) {
            throw new ReflectException(e);
        }
    }

    private static ApiReflect a(Method method, Object obj, Object... objArr) {
        try {
            a(method);
            if (method.getReturnType() == Void.TYPE) {
                method.invoke(obj, objArr);
                return k(obj);
            }
            return k(method.invoke(obj, objArr));
        } catch (Exception e) {
            throw new ReflectException(e);
        }
    }

    private static Object l(Object obj) {
        return obj instanceof ApiReflect ? ((ApiReflect) obj).get() : obj;
    }

    private static Class<?>[] c(Object... objArr) {
        if (objArr == null) {
            return new Class[0];
        }
        Class<?>[] clsArr = new Class[objArr.length];
        for (int i = 0; i < objArr.length; i++) {
            Object obj = objArr[i];
            clsArr[i] = obj == null ? b.class : obj.getClass();
        }
        return clsArr;
    }

    private static Class<?> forName(String str) {
        try {
            return a.forName(str);
        } catch (Exception e) {
            throw new ReflectException(e);
        }
    }

    private Class<?> type() {
        return this.aHI;
    }

    private static Class<?> b(Class<?> cls) {
        if (cls == null) {
            return null;
        }
        if (!cls.isPrimitive()) {
            return cls;
        }
        if (Boolean.TYPE == cls) {
            return Boolean.class;
        }
        if (Integer.TYPE == cls) {
            return Integer.class;
        }
        if (Long.TYPE == cls) {
            return Long.class;
        }
        if (Short.TYPE == cls) {
            return Short.class;
        }
        if (Byte.TYPE == cls) {
            return Byte.class;
        }
        if (Double.TYPE == cls) {
            return Double.class;
        }
        if (Float.TYPE == cls) {
            return Float.class;
        }
        if (Character.TYPE == cls) {
            return Character.class;
        }
        return Void.TYPE == cls ? Void.class : cls;
    }

    static class b {
        private b() {
        }
    }
}
