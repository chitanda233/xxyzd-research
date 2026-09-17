package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.SharedPreferences;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes2.dex */
public abstract class p0 {
    public static String a(Context context, String str, String str2) {
        if (context != null) {
            try {
                String string = u0.a(context).b().getString(str, str2);
                if (AbstractC0600f.b(string)) {
                    return string;
                }
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getString _key=", str, "defaultValue", str2, "Exception", e);
            }
        }
        return str2;
    }

    public static void b(Context context, String str, String str2) {
        if (context != null) {
            try {
                a.a(u0.a(context).a().putString(str, str2));
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "putString _key=", str, "value", str2, "Exception", e);
            }
        }
    }

    private static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final Method f1994a = a();

        private static Method a() {
            try {
                return SharedPreferences.Editor.class.getMethod("apply", null);
            } catch (Exception e) {
                e.printStackTrace();
                return null;
            }
        }

        static void a(SharedPreferences.Editor editor) {
            try {
                Method method = f1994a;
                if (method != null) {
                    method.invoke(editor, null);
                    return;
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
            editor.commit();
        }
    }

    public static void b(Context context, String str, int i) {
        if (context != null) {
            try {
                a.a(u0.a(context).a().putInt(str, i));
            } catch (Exception e) {
                Q.d("ExceptionShanYanLogger", "putInt _key=", str, "value", Integer.valueOf(i), "Exception", e);
            }
        }
    }

    public static int a(Context context, String str, int i) {
        if (context != null) {
            try {
                return u0.a(context).b().getInt(str, i);
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getInt _key=", str, "defaultValue", Integer.valueOf(i), "Exception", e);
            }
        }
        return i;
    }

    public static void b(Context context, String str, boolean z) {
        if (context != null) {
            try {
                a.a(u0.a(context).a().putBoolean(str, z));
            } catch (Exception e) {
                Q.d("ExceptionShanYanLogger", "putBoolean _key=", str, "value", Boolean.valueOf(z), "Exception", e);
            }
        }
    }

    public static boolean a(Context context, String str, boolean z) {
        if (context != null) {
            try {
                return u0.a(context).b().getBoolean(str, z);
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getBoolean _key=", str, "defaultValue", Boolean.valueOf(z), "Exception", e);
            }
        }
        return z;
    }

    public static void b(Context context, String str, long j) {
        if (context != null) {
            try {
                a.a(u0.a(context).a().putLong(str, j));
            } catch (Exception e) {
                Q.d("ExceptionShanYanLogger", "putLong _key=", str, "value", Long.valueOf(j), "Exception", e);
            }
        }
    }

    public static long a(Context context, String str, long j) {
        if (context != null) {
            try {
                return u0.a(context).b().getLong(str, j);
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "getLong _key=", str, "defaultValue", Long.valueOf(j), "Exception", e);
            }
        }
        return j;
    }
}
