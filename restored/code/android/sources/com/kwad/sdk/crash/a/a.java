package com.kwad.sdk.crash.a;

import android.content.Context;
import android.os.Build;
import android.os.Environment;
import android.text.TextUtils;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ab;
import com.kwad.sdk.utils.y;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static Context aWI;
    private static String bem;

    public static void init(Context context, String str) {
        aWI = context;
        bem = str;
        bem = y.T(context, "kwad_ex");
    }

    public static File Qv() {
        File file;
        if (!TextUtils.isEmpty(bem)) {
            file = new File(bem);
        } else {
            Context contextHP = aWI;
            if (contextHP == null) {
                contextHP = ServiceProvider.Um();
            }
            if (contextHP == null) {
                try {
                    contextHP = ab.HP();
                } catch (Throwable unused) {
                }
            }
            file = contextHP != null ? new File(getDataDir(contextHP), "kwad_ex") : null;
        }
        if (file != null && !file.exists()) {
            file.mkdir();
        }
        return file;
    }

    public static File Qw() {
        return new File(Qv(), "java_crash/dump");
    }

    private static File getDataDir(Context context) {
        if (Build.VERSION.SDK_INT >= 29) {
            return new File(context.getExternalFilesDir(null).getAbsolutePath());
        }
        File dataDir = context.getDataDir();
        if (dataDir != null) {
            return dataDir;
        }
        File file = new File(Environment.getDataDirectory().getPath() + "/data/" + context.getPackageName());
        return !file.exists() ? new File("/data/data/" + context.getPackageName()) : file;
    }

    public static File Qx() {
        return new File(Qv(), "anr_log/dump");
    }

    public static File Qy() {
        return new File(Qv(), "native_crash_log/dump");
    }

    public static boolean A(File file) {
        if (file == null) {
            return false;
        }
        return file.exists() || file.mkdirs();
    }
}
