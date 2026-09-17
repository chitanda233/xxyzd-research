package cn.thinkingdata.core.utils;

import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.lang.reflect.ParameterizedType;
import java.lang.reflect.Type;

/* JADX INFO: loaded from: classes.dex */
public class TAReflectUtils {
    static String TAG = "ThinkingAnalytics.TAReflectUtils";

    public static Object createObject(String str) {
        Class<?> cls;
        try {
            cls = Class.forName(str);
            try {
                return cls.getDeclaredConstructor(new Class[0]).newInstance(new Object[0]);
            } catch (Exception e) {
                e = e;
                e.printStackTrace();
                return cls;
            }
        } catch (Exception e2) {
            e = e2;
            cls = null;
        }
    }

    public static Field getAccessibleField(Object obj, String str) {
        for (Class<?> superclass = obj.getClass(); superclass != Object.class; superclass = superclass.getSuperclass()) {
            if (superclass != null) {
                try {
                    Field declaredField = superclass.getDeclaredField(str);
                    declaredField.setAccessible(true);
                    return declaredField;
                } catch (NoSuchFieldException unused) {
                    continue;
                }
            }
        }
        return null;
    }

    public static Method getAccessibleMethod(Object obj, String str, Class<?>... clsArr) {
        if (obj == null) {
            TDLog.i(TAG, "obj is null!");
            return null;
        }
        for (Class<?> superclass = obj.getClass(); superclass != Object.class; superclass = superclass.getSuperclass()) {
            try {
                Method declaredMethod = superclass.getDeclaredMethod(str, clsArr);
                declaredMethod.setAccessible(true);
                return declaredMethod;
            } catch (NoSuchMethodException unused) {
            }
        }
        return null;
    }

    public static Object getFieldValue(Object obj, String str) {
        Field accessibleField = getAccessibleField(obj, str);
        if (accessibleField == null) {
            throw new IllegalArgumentException("Could not find field [" + str + "] on target [" + obj + "]");
        }
        try {
            return accessibleField.get(obj);
        } catch (IllegalAccessException e) {
            TDLog.e(TAG, e.getMessage());
            return null;
        }
    }

    public static Object getObjectInstance(String str) {
        Class<?> cls;
        try {
            cls = Class.forName(str);
            try {
                return cls.getMethod("getInstance", new Class[0]).invoke(cls, new Object[0]);
            } catch (Exception e) {
                e = e;
                e.printStackTrace();
                return cls;
            }
        } catch (Exception e2) {
            e = e2;
            cls = null;
        }
    }

    public static <T> Class<T> getSuperClassGenericType(Class cls) {
        return getSuperClassGenericType(cls, 0);
    }

    public static Class getSuperClassGenericType(Class cls, int i) {
        String str;
        StringBuilder sbAppend;
        String str2;
        Type genericSuperclass = cls.getGenericSuperclass();
        if (genericSuperclass instanceof ParameterizedType) {
            Type[] actualTypeArguments = ((ParameterizedType) genericSuperclass).getActualTypeArguments();
            if (i >= actualTypeArguments.length || i < 0) {
                TDLog.w(TAG, "Index: " + i + ", Size of " + cls.getSimpleName() + "'s Parameterized Type: " + actualTypeArguments.length);
                return Object.class;
            }
            Type type = actualTypeArguments[i];
            if (type instanceof Class) {
                return (Class) type;
            }
            str = TAG;
            sbAppend = new StringBuilder().append(cls.getSimpleName());
            str2 = " not set the actual class on superclass generic parameter";
        } else {
            str = TAG;
            sbAppend = new StringBuilder().append(cls.getSimpleName());
            str2 = "'s superclass not ParameterizedType";
        }
        TDLog.w(str, sbAppend.append(str2).toString());
        return Object.class;
    }

    public static Object invokeGetterMethod(Object obj, String str) {
        return invokeMethod(obj, "get" + str.trim(), new Object[0], new Class[0]);
    }

    public static Object invokeMethod(Object obj, String str, Object[] objArr, Class<?>... clsArr) {
        Method accessibleMethod = getAccessibleMethod(obj, str, clsArr);
        if (accessibleMethod == null) {
            TDLog.i(TAG, "Could not find method [" + str + "] on target [" + obj + "]");
            return null;
        }
        try {
            return accessibleMethod.invoke(obj, objArr);
        } catch (Exception e) {
            TDLog.e(TAG, e.getMessage());
            return null;
        }
    }

    public static void invokeSetterMethod(Object obj, String str, Object obj2) {
        invokeSetterMethod(obj, str, obj2, null);
    }

    public static void invokeSetterMethod(Object obj, String str, Object obj2, Class<?> cls) {
        if (cls == null) {
            cls = obj2.getClass();
        }
        invokeMethod(obj, "set" + str.trim(), new Object[]{obj2}, cls);
    }

    public static void invokeStaticMethod(String str, String str2, Object[] objArr, Class<?>... clsArr) throws IllegalAccessException, InvocationTargetException {
        Class.forName(str).getDeclaredMethod(str2, clsArr).invoke(null, objArr);
    }

    public static void setFieldValue(Object obj, String str, Object obj2) {
        Field accessibleField = getAccessibleField(obj, str);
        if (accessibleField == null) {
            throw new IllegalArgumentException("Could not find field [" + str + "] on target [" + obj + "]");
        }
        try {
            accessibleField.set(obj, obj2);
        } catch (IllegalAccessException e) {
            TDLog.e(TAG, e.getMessage());
        }
    }
}
