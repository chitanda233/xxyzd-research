package com.cmic.gen.sdk.f;

import android.content.Context;
import android.content.SharedPreferences;
import java.util.Map;

/* JADX INFO: compiled from: SharedPreferencesUtil.java */
/* JADX INFO: loaded from: classes2.dex */
public class l {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Context f2126a;

    public static void a(Context context) {
        f2126a = context.getApplicationContext();
    }

    public static int a(String str, int i) {
        return f2126a.getSharedPreferences("ssoconfigs", 0).getInt(d.a(str), i);
    }

    public static int a(String str, String str2, int i) {
        return f2126a.getSharedPreferences(str, 0).getInt(d.a(str2), i);
    }

    public static long a(String str, long j) {
        return f2126a.getSharedPreferences("ssoconfigs", 0).getLong(d.a(str), j);
    }

    public static long a(String str, String str2, long j) {
        return f2126a.getSharedPreferences(str, 0).getLong(d.a(str2), j);
    }

    public static void a(String str, String str2) {
        SharedPreferences sharedPreferences = f2126a.getSharedPreferences("ssoconfigs", 0);
        sharedPreferences.edit().putString(d.a(str), str2).commit();
    }

    public static void a(Map<String, Object> map) {
        if (map == null || map.isEmpty()) {
            return;
        }
        SharedPreferences.Editor editorEdit = f2126a.getSharedPreferences("ssoconfigs", 0).edit();
        for (String str : map.keySet()) {
            Object obj = map.get(str);
            String strA = d.a(str);
            if (obj instanceof String) {
                editorEdit.putString(strA, (String) obj);
            } else if (obj instanceof Integer) {
                editorEdit.putInt(strA, ((Integer) obj).intValue());
            } else if (obj instanceof Long) {
                editorEdit.putLong(strA, ((Long) obj).longValue());
            } else if (obj instanceof Boolean) {
                editorEdit.putBoolean(strA, ((Boolean) obj).booleanValue());
            }
        }
        editorEdit.commit();
    }

    public static String b(String str, String str2) {
        return f2126a.getSharedPreferences("ssoconfigs", 0).getString(d.a(str), str2);
    }

    public static String a(String str, String str2, String str3) {
        return f2126a.getSharedPreferences(str, 0).getString(d.a(str2), str3);
    }

    public static void a(String str) {
        SharedPreferences sharedPreferences = f2126a.getSharedPreferences("ssoconfigs", 0);
        sharedPreferences.edit().remove(d.a(str)).commit();
    }

    public static a a() {
        return new a(f2126a.getSharedPreferences("ssoconfigs", 0).edit());
    }

    public static a b(String str) {
        return new a(f2126a.getSharedPreferences(str, 0).edit());
    }

    /* JADX INFO: compiled from: SharedPreferencesUtil.java */
    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final SharedPreferences.Editor f2127a;

        a(SharedPreferences.Editor editor) {
            this.f2127a = editor;
        }

        public void a(String str, String str2) {
            this.f2127a.putString(d.a(str), str2);
        }

        public void a(String str, long j) {
            this.f2127a.putLong(d.a(str), j);
        }

        public void a(String str, int i) {
            this.f2127a.putInt(d.a(str), i);
        }

        public void a() {
            this.f2127a.apply();
        }

        public void b() {
            this.f2127a.commit();
        }

        public void c() {
            this.f2127a.clear();
        }

        public void a(String str) {
            this.f2127a.remove(d.a(str));
        }
    }
}
