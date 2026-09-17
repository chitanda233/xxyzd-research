package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.Environment;
import java.io.File;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.w, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0617w {
    private static Context b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f2028a = File.separator;
    private static File c = null;

    private static String a() {
        return "cl_jm_file";
    }

    public static void a(Context context) {
        b = context;
    }

    public static File b() {
        if (c == null) {
            c = a(b, a() + f2028a + "database");
        }
        return c;
    }

    private static File a(Context context, String str) {
        File file;
        if (!Environment.getExternalStorageState().equals("mounted")) {
            file = new File(context.getCacheDir(), str);
        } else {
            file = new File(Environment.getExternalStorageDirectory(), str);
        }
        if (!file.exists()) {
            file.mkdirs();
        }
        return file;
    }

    public static File a(File file, String str) {
        File file2 = new File(file, str);
        try {
            if (!file2.exists()) {
                file2.createNewFile();
            }
            return file2;
        } catch (Exception e) {
            e.printStackTrace();
            return file2;
        }
    }
}
