package com.sigmob.sdk.base.device.compat;

import android.os.Environment;
import android.text.TextUtils;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.InvocationTargetException;
import java.util.Properties;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private d() {
    }

    public static String a(String key) throws Throwable {
        String strE;
        if (key != null && !key.isEmpty()) {
            try {
                strE = c(key);
            } catch (Exception unused) {
                strE = null;
            }
            if (strE != null && !strE.isEmpty()) {
                return strE;
            }
            try {
                strE = d(key);
            } catch (IOException unused2) {
            }
            if (strE != null && !strE.isEmpty()) {
                return strE;
            }
            try {
                strE = e(key);
            } catch (IOException unused3) {
            }
            if (strE != null && !strE.isEmpty()) {
                return strE;
            }
        }
        return "";
    }

    public static String[] a(String[] keys) {
        if (keys == null) {
            return new String[0];
        }
        String[] strArr = new String[keys.length];
        for (int i = 0; i < keys.length; i++) {
            strArr[i] = a(keys[i]);
        }
        return strArr;
    }

    public static String b(String[] keys) throws Throwable {
        if (keys == null) {
            return "";
        }
        for (String str : keys) {
            String strA = a(str);
            if (!strA.isEmpty()) {
                return strA;
            }
        }
        return "";
    }

    public static boolean b(String key) {
        return !TextUtils.isEmpty(a(key));
    }

    private static String c(String key) throws IllegalAccessException, NoSuchMethodException, ClassNotFoundException, InvocationTargetException {
        Class<?> cls = Class.forName("android.os.SystemProperties");
        return (String) cls.getMethod("get", String.class, String.class).invoke(cls, key, "");
    }

    public static boolean c(String[] keys) {
        if (keys == null) {
            return false;
        }
        for (String str : keys) {
            if (b(str)) {
                return true;
            }
        }
        return false;
    }

    private static String d(String key) throws Throwable {
        BufferedReader bufferedReader = null;
        try {
            BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(Runtime.getRuntime().exec("getprop " + key).getInputStream()), 1024);
            try {
                String line = bufferedReader2.readLine();
                if (line != null) {
                    try {
                        bufferedReader2.close();
                    } catch (IOException unused) {
                    }
                    return line;
                }
                try {
                    bufferedReader2.close();
                } catch (IOException unused2) {
                }
                return null;
            } catch (Throwable th) {
                th = th;
                bufferedReader = bufferedReader2;
                if (bufferedReader != null) {
                    try {
                        bufferedReader.close();
                    } catch (IOException unused3) {
                    }
                }
                throw th;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    private static String e(String key) throws Throwable {
        FileInputStream fileInputStream = null;
        try {
            Properties properties = new Properties();
            FileInputStream fileInputStream2 = new FileInputStream(new File(Environment.getRootDirectory(), "build.prop"));
            try {
                properties.load(fileInputStream2);
                String property = properties.getProperty(key, "");
                try {
                    fileInputStream2.close();
                } catch (IOException unused) {
                }
                return property;
            } catch (Throwable th) {
                th = th;
                fileInputStream = fileInputStream2;
                if (fileInputStream != null) {
                    try {
                        fileInputStream.close();
                    } catch (IOException unused2) {
                    }
                }
                throw th;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }
}
