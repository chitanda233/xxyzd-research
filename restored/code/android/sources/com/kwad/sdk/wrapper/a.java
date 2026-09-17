package com.kwad.sdk.wrapper;

import android.content.Context;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
final class a {
    private static File aIi;

    private static File i(File file) {
        if (file.exists() && file.isFile()) {
            file.delete();
        }
        if (file.exists() && file.isDirectory()) {
            return file;
        }
        if (!file.exists()) {
            file.mkdirs();
        }
        if (file.exists()) {
            file.isDirectory();
        }
        return file;
    }

    private static File bq(Context context) {
        if (aIi == null) {
            aIi = i(new File(context.getApplicationInfo().dataDir, "ksad_dynamic"));
        }
        return aIi;
    }

    private static String w(Context context, String str) {
        return i(new File(bq(context), "apk-" + str)).getPath();
    }

    static String y(Context context, String str) {
        File file = new File(w(context, str), "dynamic.apk");
        if (file.exists()) {
            return file.getPath();
        }
        return new File(w(context, str), "dynamic_apk").getPath();
    }
}
