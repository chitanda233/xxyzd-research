package com.qq.gdt.action.i;

import android.app.Application;
import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.os.Build;
import android.os.Process;
import com.baidu.mobads.sdk.internal.bz;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileReader;
import java.lang.reflect.Method;
import java.security.MessageDigest;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Context f3077a = null;
    private static String b = "";
    private static String c = "";
    private static boolean d = false;
    private static final Object e = new Object();
    private static final Object f = new Object();

    public static String a() {
        return Build.VERSION.SDK_INT >= 28 ? Application.getProcessName() : "";
    }

    public static String a(Context context) {
        try {
            if (!v.a(b)) {
                return b;
            }
            String strA = a();
            b = strA;
            if (!v.a(strA)) {
                return b;
            }
            String strB = b();
            b = strB;
            if (!v.a(strB)) {
                return b;
            }
            String strC = c();
            b = strC;
            return strC;
        } catch (Throwable unused) {
            return "";
        }
    }

    private static String a(File file) throws Throwable {
        FileInputStream fileInputStream = null;
        try {
            try {
                byte[] bArr = new byte[8192];
                MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
                FileInputStream fileInputStream2 = new FileInputStream(file);
                while (true) {
                    try {
                        int i = fileInputStream2.read(bArr);
                        if (i == -1) {
                            break;
                        }
                        messageDigest.update(bArr, 0, i);
                    } catch (Exception e2) {
                        e = e2;
                        fileInputStream = fileInputStream2;
                        o.a("file2MD5", e);
                        if (fileInputStream == null) {
                            return "";
                        }
                        try {
                            fileInputStream.close();
                            return "";
                        } catch (Exception e3) {
                            o.a("file2MD5 close fis", e3);
                            return "";
                        }
                    } catch (Throwable th) {
                        th = th;
                        fileInputStream = fileInputStream2;
                        if (fileInputStream != null) {
                            try {
                                fileInputStream.close();
                            } catch (Exception e4) {
                                o.a("file2MD5 close fis", e4);
                            }
                        }
                        throw th;
                    }
                }
                byte[] bArrDigest = messageDigest.digest();
                StringBuilder sb = new StringBuilder(bArrDigest.length * 2);
                for (byte b2 : bArrDigest) {
                    int i2 = b2 & UByte.MAX_VALUE;
                    if (i2 < 16) {
                        sb.append("0");
                    }
                    sb.append(Integer.toHexString(i2));
                }
                String string = sb.toString();
                try {
                    fileInputStream2.close();
                } catch (Exception e5) {
                    o.a("file2MD5 close fis", e5);
                }
                return string;
            } catch (Exception e6) {
                e = e6;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    public static String b() {
        try {
            Method declaredMethod = Class.forName("android.app.ActivityThread", false, Application.class.getClassLoader()).getDeclaredMethod("currentProcessName", new Class[0]);
            declaredMethod.setAccessible(true);
            Object objInvoke = declaredMethod.invoke(null, new Object[0]);
            return objInvoke instanceof String ? (String) objInvoke : "";
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }

    public static String b(Context context) {
        if (d || !v.a(c)) {
            return c;
        }
        synchronized (f) {
            if (!d && v.a(c)) {
                if (context == null) {
                    o.a("readFirstApkFile context is null", new Object[0]);
                    com.qq.gdt.action.g.a.a(2901);
                    return c;
                }
                try {
                    ApplicationInfo applicationInfo = context.getApplicationInfo();
                    File file = new File(applicationInfo.sourceDir);
                    if (file.exists()) {
                        String strA = a(file);
                        o.a("readFirstApkFile Apk file " + applicationInfo.sourceDir + " file2MD5 = " + strA, new Object[0]);
                        d = true;
                        if (v.a(strA)) {
                            com.qq.gdt.action.g.a.a(2903);
                        } else {
                            c = strA;
                        }
                    } else {
                        o.a("readFirstApkFile package:" + applicationInfo.packageName + " Apk file " + applicationInfo.sourceDir + " doesn't exist", new Object[0]);
                        com.qq.gdt.action.g.a.a(2905);
                    }
                } catch (Exception e2) {
                    o.a("readFirstApkFile", e2);
                    com.qq.gdt.action.g.a.a(2904);
                }
                return c;
            }
            return c;
        }
    }

    public static String c() {
        BufferedReader bufferedReader = null;
        try {
            BufferedReader bufferedReader2 = new BufferedReader(new FileReader(new File("/proc/" + Process.myPid() + "/cmdline")));
            try {
                String strTrim = bufferedReader2.readLine().replace((char) 0, ' ').trim();
                try {
                    bufferedReader2.close();
                    return strTrim;
                } catch (Exception e2) {
                    e2.printStackTrace();
                    return strTrim;
                }
            } catch (Throwable th) {
                th = th;
                bufferedReader = bufferedReader2;
                try {
                    th.printStackTrace();
                    return "";
                } finally {
                    if (bufferedReader != null) {
                        try {
                            bufferedReader.close();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                    }
                }
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    public static Context d() {
        if (f3077a == null) {
            synchronized (e) {
                if (f3077a == null) {
                    try {
                        Class<?> cls = Class.forName("android.app.ActivityThread");
                        Object objInvoke = cls.getMethod("currentActivityThread", new Class[0]).invoke(cls, new Object[0]);
                        f3077a = (Context) objInvoke.getClass().getMethod("getApplication", new Class[0]).invoke(objInvoke, new Object[0]);
                        o.a(" AppInfoUtil getContext CONTEXT_INSTANCE = " + f3077a, new Object[0]);
                    } catch (Throwable th) {
                        com.qq.gdt.action.g.a.a(2102);
                        o.a(" AppInfoUtil getContext ex = " + th, new Object[0]);
                    }
                }
            }
        }
        return f3077a;
    }

    public static String e() {
        return c;
    }
}
