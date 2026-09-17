package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.os.Process;
import android.text.TextUtils;
import android.util.Base64;
import dalvik.system.DexFile;
import java.io.File;
import java.io.FileOutputStream;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Flat {
    /* JADX WARN: Code duplicated, block: B:29:0x00a3  */
    /* JADX WARN: Code duplicated, block: B:32:0x00a8  */
    /* JADX WARN: Code duplicated, block: B:51:0x0118 A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:52:0x0119 A[RETURN] */
    public static int a() {
        Object objInvoke;
        Method method;
        Context context;
        File codeCacheDir;
        boolean zBooleanValue;
        int i = Build.VERSION.SDK_INT;
        if (i < 28) {
            return 0;
        }
        if (i < 30) {
            try {
                Method declaredMethod = Class.class.getDeclaredMethod("forName", String.class);
                Method declaredMethod2 = Class.class.getDeclaredMethod("getDeclaredMethod", String.class, Class[].class);
                Class cls = (Class) declaredMethod.invoke(null, "dalvik.system.VMRuntime");
                Method method2 = (Method) declaredMethod2.invoke(cls, "getRuntime", null);
                if (method2 != null && (objInvoke = method2.invoke(null, null)) != null && (method = (Method) declaredMethod2.invoke(cls, "setHiddenApiExemptions", new Class[]{String[].class})) != null) {
                    method.invoke(objInvoke, new String[]{"L"});
                    return 0;
                }
            } catch (Throwable unused) {
            }
        }
        byte[] bArrDecode = Base64.decode("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", 2);
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        if (context != null) {
            codeCacheDir = context.getCodeCacheDir();
        } else {
            String property = System.getProperty("java.io.tmpdir");
            if (TextUtils.isEmpty(property)) {
                codeCacheDir = null;
            } else {
                File file = new File(property);
                if (file.exists()) {
                    codeCacheDir = file;
                } else {
                    codeCacheDir = null;
                }
            }
        }
        if (codeCacheDir == null) {
            zBooleanValue = false;
        } else {
            File file2 = new File(codeCacheDir, String.valueOf(Process.myPid()) + System.currentTimeMillis() + ".dex");
            try {
                FileOutputStream fileOutputStream = new FileOutputStream(file2);
                try {
                    file2.setReadOnly();
                    fileOutputStream.write(bArrDecode);
                    fileOutputStream.close();
                    zBooleanValue = ((Boolean) new DexFile(file2).loadClass("com.turingfd.ref.a", null).getDeclaredMethod("a", null).invoke(null, null)).booleanValue();
                    if (file2.exists()) {
                        file2.delete();
                    }
                } catch (Throwable th) {
                    try {
                        fileOutputStream.close();
                    } catch (Throwable th2) {
                        th.addSuppressed(th2);
                    }
                    throw th;
                }
            } catch (Throwable unused2) {
                if (file2.exists()) {
                    zBooleanValue = false;
                } else {
                    zBooleanValue = false;
                }
                if (zBooleanValue) {
                    return 0;
                }
                return -1;
            }
        }
        if (zBooleanValue) {
            return 0;
        }
        return -1;
    }
}
